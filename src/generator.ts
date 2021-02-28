// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

import { ChoiceSchema, CodeModel, HttpMethod, HttpParameter, HttpRequest, HttpResponse, ImplementationLocation, ObjectSchema, Operation, Parameter, ParameterLocation, Protocol, Request, Response, Schema, SchemaResponse, StatusCode } from "@autorest/codemodel";
import { Host } from "@autorest/extension-base";
import { generateProviderTypes } from './types';
import { ProviderDefinition, ResourceDescriptor, ScopeType } from './models';

function logWarning(message: string) {
  // TODO
}

function getHttpRequests(requests: Request[] | undefined) {
  return requests?.map(x => x.protocol.http as HttpRequest).filter(x => !!x) ?? [];
}

export async function generate(codeModel: CodeModel, host: Host): Promise<void> {
  const apiVersions = codeModel.operationGroups
    .flatMap(group => group.operations
      .flatMap(op => (op.apiVersions ?? []).map(v => v.version)))
    .filter((x, i, a) => a.indexOf(x) === i);

  for (const apiVersion of apiVersions) {
    generateTypes(codeModel, host, apiVersion);
  }
}

function hasStatusCode(response: Response, statusCode: string) {
  const statusCodes = (response.protocol.http as HttpResponse)?.statusCodes;
  if (!statusCodes) {
    return;
  }

  return (statusCodes as string[]).includes(statusCode);
}

function getGetSchema(operation?: Operation) {
  const responses = operation?.responses ?? [];
  const validResponses = [
    // order 200 responses before default
    ...responses.filter(r => hasStatusCode(r, "200")),
    ...responses.filter(r => hasStatusCode(r, "default")),
  ];

  if (!operation || validResponses.length === 0) {
    return;
  }

  for (const response of validResponses) {
    const schemaResponse = response as SchemaResponse;
    if (schemaResponse) {
      return { 
        response: (response.protocol.http as HttpResponse),
        schema: schemaResponse.schema
      };
    }
  }

  return { 
    response: (validResponses[0].protocol.http as HttpResponse),
  };
}

function getPutSchema(operation?: Operation) {
  const requests = operation?.requests ?? [];
  const validRequests = requests.filter(r => (r.protocol.http as HttpRequest)?.method === HttpMethod.Put);

  if (!operation || validRequests.length === 0) {
    return;
  }

  for (const request of validRequests) {
    const parameters = [...(operation.parameters || []), ...(request.parameters || [])];
    const bodyParameters = parameters.filter(p => (p.protocol.http as HttpParameter)?.in === ParameterLocation.Body);
    if (bodyParameters.length > 0) {
      return { 
        request: (request.protocol.http as HttpRequest),
        schema: bodyParameters[0].schema,
      };
    }
  }

  return { 
    request: (validRequests[0].protocol.http as HttpRequest),
  };
}

function generateTypes(codeModel: CodeModel, host: Host, apiVersion: string) {
  const providerDefinitions: {[key: string]: ProviderDefinition} = {};
  const operations = codeModel.operationGroups.flatMap(x => x.operations);

  const getOperationsByPath: {[key: string]: Operation} = {};
  const putOperationsByPath: {[key: string]: Operation} = {};
  operations.forEach(operation => {
    const requests = getHttpRequests(operation.requests);
    const getRequest = requests.filter(r => r.method === HttpMethod.Get)[0];
    if (getRequest) {
      getOperationsByPath[getRequest.path.toLowerCase()] = operation;
    }
    const putRequest = requests.filter(r => r.method === HttpMethod.Put)[0];
    if (putRequest) {
      putOperationsByPath[putRequest.path.toLowerCase()] = operation;
    }
  });

  for (const lcPath in putOperationsByPath) {
    const putOperation = putOperationsByPath[lcPath];
    const getOperation = getOperationsByPath[lcPath];

    const putData = getPutSchema(putOperation);
    const getData = getGetSchema(getOperation);
    if (!putData) {
      continue;
    }

    const { success, failureReason, descriptors } = parseMethod(putData.request.path, [...(putOperation.parameters || []), ...(putData.request.parameters || [])], apiVersion);
    if (!success) {
      logWarning(`Skipping path '${putData.request.path}': ${failureReason}`);
      continue;
    }

    for (const descriptor of descriptors) {
      if (!providerDefinitions[descriptor.namespace]) {
        providerDefinitions[descriptor.namespace] = {
          namespace: descriptor.namespace,
          apiVersion,
          codeModel,
          resources: []
        };
      }
      const providerDefinition = providerDefinitions[descriptor.namespace];

      providerDefinition.resources.push({
        descriptor,
        putRequest: putData.request,
        putSchema: putData.schema,
        getSchema: getData?.schema,
      });
    }
  }

  return Object.values(providerDefinitions)
    .map(definition => generateProviderTypes(codeModel, host, definition));
}

const parentScopePrefix = /^.*\/providers\//ig;
const managementGroupPrefix = /^\/providers\/Microsoft.Management\/managementGroups\/{\w+}\/$/i;
const tenantPrefix = /^\/$/i;
const subscriptionPrefix = /^\/subscriptions\/{\w+}\/$/i;
const resourceGroupPrefix = /^\/subscriptions\/{\w+}\/resourceGroups\/{\w+}\/$/i;
const resourceGroupMethod = /^\/subscriptions\/{\w+}\/resourceGroups\/{\w+}$/i;

function parseMethod(path: string, parameters: Parameter[], apiVersion: string) {
  path = getNormalizedMethodPath(path);
  
  const finalProvidersMatch = path.match(parentScopePrefix)?.last;
  if (!finalProvidersMatch) {
    return { success: false, failureReason: `Unable to locate "/providers/" segment`, descriptors: [] };
  }

  const parentScope = path.substr(0, finalProvidersMatch.length - "providers/".length);
  const routingScope = trimScope(path.substr(finalProvidersMatch.length));

  const namespace = routingScope.substr(0, routingScope.indexOf('/'));
  if (isPathVariable(namespace)) {
    return { success: false, failureReason: `Unable to process parameterized provider namespace "${namespace}"`, descriptors: [] };
  }

  const { success, failureReason, resourceTypes } = parseResourceTypes(parameters, routingScope);
  if (!success) {
    return { success: false, failureReason, descriptors: [] };
  }

  const resNameParam = routingScope.substr(routingScope.lastIndexOf('/') + 1);
  const constantName = isPathVariable(resNameParam) ? undefined : resNameParam;

  const scopeType = getScopeTypeFromParentScope(parentScope);

  const descriptors: ResourceDescriptor[] = resourceTypes.map(type => ({
    scopeType,
    namespace,
    typeSegments: type,
    apiVersion,
    constantName,
  }));

  return { success: true, failureReason: '', descriptors };
}

function parseResourceTypes(parameters: Parameter[], routingScope: string) {
  const typeSegments = routingScope.split('/').slice(1).filter((_, i) => i % 2 === 0);
  const nameSegments = routingScope.split('/').slice(1).filter((_, i) => i % 2 === 1);

  if (typeSegments.length === 0) {
    return { success: false, failureReason: `Unable to find type segments`, resourceTypes: [] };
  }

  if (typeSegments.length !== nameSegments.length) {
    return { success: false, failureReason: `Found mismatch between type segments (${typeSegments.length}) and name segments (${nameSegments.length})`, resourceTypes: [] };
  }

  let resourceTypes: string[][] = [[]];
  for (const typeSegment of typeSegments) {
    if (isPathVariable(typeSegment)) {
      const parameterName = trimParamBraces(typeSegment);
      const parameter = parameters.filter(p => 
        p.implementation === ImplementationLocation.Method &&        
        p.language.default.name === parameterName)[0];

      if (!parameter) {
        return { success: false, failureReason: `Found undefined parameter reference ${typeSegment}`, resourceTypes: [] };
      }

      const choiceSchema = (parameter.schema as ChoiceSchema);
      if (!choiceSchema) {
        return { success: false, failureReason: `Parameter reference ${typeSegment} is not defined as an enum`, resourceTypes: [] };
      }

      if (choiceSchema.choices.length === 0) {
        return { success: false, failureReason: `Parameter reference ${typeSegment} is defined as an enum, but doesn't have any specified values`, resourceTypes: [] };
      }

      resourceTypes = resourceTypes.flatMap(type => choiceSchema.choices.map(v => [...type, v.value.toString()]));
    } else {
      resourceTypes = resourceTypes.map(type => [...type, typeSegment]);
    }
  }

  return { success: true, failureReason: '', resourceTypes };
}

function getNormalizedMethodPath(path: string) {
  if (resourceGroupMethod.test(path)) {
    // resource groups are a special case - the swagger API is not defined as a provider API, but they are still deployable in a template as if it was.
    return "/subscriptions/{subscriptionId}/providers/Microsoft.Resources/resourceGroups/{resourceGroupName}";
  }

  return path;
}


function getScopeTypeFromParentScope(parentScope: string)
{
  if (tenantPrefix.test(parentScope)) {
    return ScopeType.Tenant;
  }

  if (managementGroupPrefix.test(parentScope)) {
      return ScopeType.ManagementGroup;
  }

  if (resourceGroupPrefix.test(parentScope)) {
      return ScopeType.ResourceGroup;
  }

  if (subscriptionPrefix.test(parentScope)) {
      return ScopeType.Subscription;
  }

  if (parentScopePrefix.test(parentScope)) {
      return ScopeType.Extension;
  }

  // ambiguous - without any further information, we have to assume 'all'
  return ScopeType.Unknown;
}

function trimScope(scope: string) {
  return scope.replace(/\/*$/, '').replace(/^\/*/, '');
}

function isPathVariable(pathSegment: string) {
  return pathSegment.startsWith('{') && pathSegment.endsWith('}');
}

function trimParamBraces(pathSegment: string) {
  return pathSegment.substr(1, pathSegment.length - 2);
}