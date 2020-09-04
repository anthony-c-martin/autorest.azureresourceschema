// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_ServiceFabricMesh_2018_09_01_preview
    {
        private const string ProviderNamespace = "Microsoft.ServiceFabricMesh";
        private const string ApiVersion = "2018-09-01-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_secrets = new ResourceTypeReference(ProviderNamespace, new[]{"secrets"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_volumes = new ResourceTypeReference(ProviderNamespace, new[]{"volumes"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_networks = new ResourceTypeReference(ProviderNamespace, new[]{"networks"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_gateways = new ResourceTypeReference(ProviderNamespace, new[]{"gateways"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_applications = new ResourceTypeReference(ProviderNamespace, new[]{"applications"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_secrets_values = new ResourceTypeReference(ProviderNamespace, new[]{"secrets", "values"}, ApiVersion);
        private static Lazy<Microsoft_ServiceFabricMesh_2018_09_01_preview> InstanceLazy = new Lazy<Microsoft_ServiceFabricMesh_2018_09_01_preview>(() => new Microsoft_ServiceFabricMesh_2018_09_01_preview());
        private Microsoft_ServiceFabricMesh_2018_09_01_preview()
        {
            SecretResourceProperties = new DiscriminatedObjectType("SecretResourceProperties", "kind", new ITypeProperty[]{new LazyTypeProperty("SecretResourceProperties", () => InlinedValueSecretResourceProperties, TypePropertyFlags.None)});
            InlinedValueSecretResourceProperties = new NamedObjectType("InlinedValueSecretResourceProperties", new ITypeProperty[]{new TypeProperty("kind", new StringLiteralType("'inlinedValue'"), TypePropertyFlags.Required), new TypeProperty("provisioningState", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("status", UnionType.Create(new StringLiteralType("'Unknown'"), new StringLiteralType("'Ready'"), new StringLiteralType("'Upgrading'"), new StringLiteralType("'Creating'"), new StringLiteralType("'Deleting'"), new StringLiteralType("'Failed'")), TypePropertyFlags.ReadOnly), new TypeProperty("statusDetails", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("contentType", LanguageConstants.String, TypePropertyFlags.None)}, null);
            SecretValueResourceProperties = new NamedObjectType("SecretValueResourceProperties", new ITypeProperty[]{new TypeProperty("provisioningState", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("value", LanguageConstants.String, TypePropertyFlags.None)}, null);
            VolumeResourceProperties = new NamedObjectType("VolumeResourceProperties", new ITypeProperty[]{new TypeProperty("provisioningState", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("status", UnionType.Create(new StringLiteralType("'Unknown'"), new StringLiteralType("'Ready'"), new StringLiteralType("'Upgrading'"), new StringLiteralType("'Creating'"), new StringLiteralType("'Deleting'"), new StringLiteralType("'Failed'")), TypePropertyFlags.ReadOnly), new TypeProperty("statusDetails", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("provider", new StringLiteralType("'SFAzureFile'"), TypePropertyFlags.Required), new LazyTypeProperty("azureFileParameters", () => VolumeProviderParametersAzureFile, TypePropertyFlags.None)}, null);
            VolumeProviderParametersAzureFile = new NamedObjectType("VolumeProviderParametersAzureFile", new ITypeProperty[]{new TypeProperty("accountName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("accountKey", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("shareName", LanguageConstants.String, TypePropertyFlags.Required)}, null);
            NetworkResourceProperties = new DiscriminatedObjectType("NetworkResourceProperties", "kind", new ITypeProperty[]{new LazyTypeProperty("NetworkResourceProperties", () => LocalNetworkResourceProperties, TypePropertyFlags.None)});
            LocalNetworkResourceProperties = new NamedObjectType("LocalNetworkResourceProperties", new ITypeProperty[]{new TypeProperty("networkAddressPrefix", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("kind", new StringLiteralType("'Local'"), TypePropertyFlags.Required), new TypeProperty("provisioningState", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("status", UnionType.Create(new StringLiteralType("'Unknown'"), new StringLiteralType("'Ready'"), new StringLiteralType("'Upgrading'"), new StringLiteralType("'Creating'"), new StringLiteralType("'Deleting'"), new StringLiteralType("'Failed'")), TypePropertyFlags.ReadOnly), new TypeProperty("statusDetails", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            GatewayResourceProperties = new NamedObjectType("GatewayResourceProperties", new ITypeProperty[]{new TypeProperty("provisioningState", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("sourceNetwork", () => NetworkRef, TypePropertyFlags.Required), new LazyTypeProperty("destinationNetwork", () => NetworkRef, TypePropertyFlags.Required), new LazyTypeProperty("tcp", () => new TypedArrayType(TcpConfig), TypePropertyFlags.None), new LazyTypeProperty("http", () => new TypedArrayType(HttpConfig), TypePropertyFlags.None), new TypeProperty("status", UnionType.Create(new StringLiteralType("'Unknown'"), new StringLiteralType("'Ready'"), new StringLiteralType("'Upgrading'"), new StringLiteralType("'Creating'"), new StringLiteralType("'Deleting'"), new StringLiteralType("'Failed'")), TypePropertyFlags.ReadOnly), new TypeProperty("statusDetails", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("ipAddress", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            NetworkRef = new NamedObjectType("NetworkRef", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("endpointRefs", () => new TypedArrayType(EndpointRef), TypePropertyFlags.None)}, null);
            EndpointRef = new NamedObjectType("EndpointRef", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None)}, null);
            TcpConfig = new NamedObjectType("TcpConfig", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("port", LanguageConstants.Int, TypePropertyFlags.Required), new LazyTypeProperty("destination", () => GatewayDestination, TypePropertyFlags.Required)}, null);
            GatewayDestination = new NamedObjectType("GatewayDestination", new ITypeProperty[]{new TypeProperty("applicationName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("serviceName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("endpointName", LanguageConstants.String, TypePropertyFlags.Required)}, null);
            HttpConfig = new NamedObjectType("HttpConfig", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("port", LanguageConstants.Int, TypePropertyFlags.Required), new LazyTypeProperty("hosts", () => new TypedArrayType(HttpHostConfig), TypePropertyFlags.Required)}, null);
            HttpHostConfig = new NamedObjectType("HttpHostConfig", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("routes", () => new TypedArrayType(HttpRouteConfig), TypePropertyFlags.Required)}, null);
            HttpRouteConfig = new NamedObjectType("HttpRouteConfig", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("match", () => HttpRouteMatchRule, TypePropertyFlags.Required), new LazyTypeProperty("destination", () => GatewayDestination, TypePropertyFlags.Required)}, null);
            HttpRouteMatchRule = new NamedObjectType("HttpRouteMatchRule", new ITypeProperty[]{new LazyTypeProperty("path", () => HttpRouteMatchPath, TypePropertyFlags.Required), new LazyTypeProperty("headers", () => new TypedArrayType(HttpRouteMatchHeader), TypePropertyFlags.None)}, null);
            HttpRouteMatchPath = new NamedObjectType("HttpRouteMatchPath", new ITypeProperty[]{new TypeProperty("value", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("rewrite", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("type", new StringLiteralType("'prefix'"), TypePropertyFlags.Required)}, null);
            HttpRouteMatchHeader = new NamedObjectType("HttpRouteMatchHeader", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("value", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("type", new StringLiteralType("'exact'"), TypePropertyFlags.None)}, null);
            ApplicationResourceProperties = new NamedObjectType("ApplicationResourceProperties", new ITypeProperty[]{new TypeProperty("provisioningState", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("services", () => new TypedArrayType(ServiceResourceDescription), TypePropertyFlags.None), new LazyTypeProperty("diagnostics", () => DiagnosticsDescription, TypePropertyFlags.None), new TypeProperty("debugParams", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("serviceNames", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.ReadOnly), new TypeProperty("status", UnionType.Create(new StringLiteralType("'Unknown'"), new StringLiteralType("'Ready'"), new StringLiteralType("'Upgrading'"), new StringLiteralType("'Creating'"), new StringLiteralType("'Deleting'"), new StringLiteralType("'Failed'")), TypePropertyFlags.ReadOnly), new TypeProperty("statusDetails", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("healthState", UnionType.Create(new StringLiteralType("'Invalid'"), new StringLiteralType("'Ok'"), new StringLiteralType("'Warning'"), new StringLiteralType("'Error'"), new StringLiteralType("'Unknown'")), TypePropertyFlags.ReadOnly), new TypeProperty("unhealthyEvaluation", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            ServiceResourceDescription = new NamedObjectType("ServiceResourceDescription", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.ReadOnly), new LazyTypeProperty("properties", () => ServiceResourceProperties, TypePropertyFlags.Required)}, null);
            ServiceResourceProperties = new NamedObjectType("ServiceResourceProperties", new ITypeProperty[]{new TypeProperty("provisioningState", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("osType", UnionType.Create(new StringLiteralType("'Linux'"), new StringLiteralType("'Windows'")), TypePropertyFlags.Required), new LazyTypeProperty("codePackages", () => new TypedArrayType(ContainerCodePackageProperties), TypePropertyFlags.Required), new LazyTypeProperty("networkRefs", () => new TypedArrayType(NetworkRef), TypePropertyFlags.None), new LazyTypeProperty("diagnostics", () => DiagnosticsRef, TypePropertyFlags.None), new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("replicaCount", LanguageConstants.Int, TypePropertyFlags.None), new LazyTypeProperty("autoScalingPolicies", () => new TypedArrayType(AutoScalingPolicy), TypePropertyFlags.None), new TypeProperty("status", UnionType.Create(new StringLiteralType("'Unknown'"), new StringLiteralType("'Ready'"), new StringLiteralType("'Upgrading'"), new StringLiteralType("'Creating'"), new StringLiteralType("'Deleting'"), new StringLiteralType("'Failed'")), TypePropertyFlags.ReadOnly), new TypeProperty("statusDetails", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("healthState", UnionType.Create(new StringLiteralType("'Invalid'"), new StringLiteralType("'Ok'"), new StringLiteralType("'Warning'"), new StringLiteralType("'Error'"), new StringLiteralType("'Unknown'")), TypePropertyFlags.ReadOnly), new TypeProperty("unhealthyEvaluation", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            ContainerCodePackageProperties = new NamedObjectType("ContainerCodePackageProperties", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("image", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("imageRegistryCredential", () => ImageRegistryCredential, TypePropertyFlags.None), new TypeProperty("entrypoint", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("commands", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new LazyTypeProperty("environmentVariables", () => new TypedArrayType(EnvironmentVariable), TypePropertyFlags.None), new LazyTypeProperty("settings", () => new TypedArrayType(Setting), TypePropertyFlags.None), new LazyTypeProperty("labels", () => new TypedArrayType(ContainerLabel), TypePropertyFlags.None), new LazyTypeProperty("endpoints", () => new TypedArrayType(EndpointProperties), TypePropertyFlags.None), new LazyTypeProperty("resources", () => ResourceRequirements, TypePropertyFlags.Required), new LazyTypeProperty("volumeRefs", () => new TypedArrayType(VolumeReference), TypePropertyFlags.None), new LazyTypeProperty("volumes", () => new TypedArrayType(ApplicationScopedVolume), TypePropertyFlags.None), new LazyTypeProperty("diagnostics", () => DiagnosticsRef, TypePropertyFlags.None), new LazyTypeProperty("reliableCollectionsRefs", () => new TypedArrayType(ReliableCollectionsRef), TypePropertyFlags.None), new LazyTypeProperty("instanceView", () => ContainerInstanceView, TypePropertyFlags.ReadOnly)}, null);
            ImageRegistryCredential = new NamedObjectType("ImageRegistryCredential", new ITypeProperty[]{new TypeProperty("server", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("username", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("password", LanguageConstants.String, TypePropertyFlags.None)}, null);
            EnvironmentVariable = new NamedObjectType("EnvironmentVariable", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("value", LanguageConstants.String, TypePropertyFlags.None)}, null);
            Setting = new NamedObjectType("Setting", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("value", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ContainerLabel = new NamedObjectType("ContainerLabel", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("value", LanguageConstants.String, TypePropertyFlags.Required)}, null);
            EndpointProperties = new NamedObjectType("EndpointProperties", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("port", LanguageConstants.Int, TypePropertyFlags.None)}, null);
            ResourceRequirements = new NamedObjectType("ResourceRequirements", new ITypeProperty[]{new LazyTypeProperty("requests", () => ResourceRequests, TypePropertyFlags.Required), new LazyTypeProperty("limits", () => ResourceLimits, TypePropertyFlags.None)}, null);
            ResourceRequests = new NamedObjectType("ResourceRequests", new ITypeProperty[]{new TypeProperty("memoryInGB", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("cpu", LanguageConstants.Int, TypePropertyFlags.Required)}, null);
            ResourceLimits = new NamedObjectType("ResourceLimits", new ITypeProperty[]{new TypeProperty("memoryInGB", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("cpu", LanguageConstants.Int, TypePropertyFlags.None)}, null);
            VolumeReference = new NamedObjectType("VolumeReference", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("readOnly", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("destinationPath", LanguageConstants.String, TypePropertyFlags.Required)}, null);
            ApplicationScopedVolume = new NamedObjectType("ApplicationScopedVolume", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("readOnly", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("destinationPath", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("creationParameters", () => ApplicationScopedVolumeCreationParameters, TypePropertyFlags.Required)}, null);
            ApplicationScopedVolumeCreationParameters = new DiscriminatedObjectType("ApplicationScopedVolumeCreationParameters", "kind", new ITypeProperty[]{new LazyTypeProperty("ApplicationScopedVolumeCreationParameters", () => ApplicationScopedVolumeCreationParametersServiceFabricVolumeDisk, TypePropertyFlags.None)});
            ApplicationScopedVolumeCreationParametersServiceFabricVolumeDisk = new NamedObjectType("ApplicationScopedVolumeCreationParametersServiceFabricVolumeDisk", new ITypeProperty[]{new TypeProperty("sizeDisk", UnionType.Create(new StringLiteralType("'Small'"), new StringLiteralType("'Medium'"), new StringLiteralType("'Large'")), TypePropertyFlags.Required), new TypeProperty("kind", new StringLiteralType("'ServiceFabricVolumeDisk'"), TypePropertyFlags.Required), new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None)}, null);
            DiagnosticsRef = new NamedObjectType("DiagnosticsRef", new ITypeProperty[]{new TypeProperty("enabled", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("sinkRefs", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None)}, null);
            ReliableCollectionsRef = new NamedObjectType("ReliableCollectionsRef", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("doNotPersistState", LanguageConstants.Bool, TypePropertyFlags.None)}, null);
            ContainerInstanceView = new NamedObjectType("ContainerInstanceView", new ITypeProperty[]{new TypeProperty("restartCount", LanguageConstants.Int, TypePropertyFlags.None), new LazyTypeProperty("currentState", () => ContainerState, TypePropertyFlags.None), new LazyTypeProperty("previousState", () => ContainerState, TypePropertyFlags.None), new LazyTypeProperty("events", () => new TypedArrayType(ContainerEvent), TypePropertyFlags.None)}, null);
            ContainerState = new NamedObjectType("ContainerState", new ITypeProperty[]{new TypeProperty("state", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("startTime", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("exitCode", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("finishTime", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("detailStatus", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ContainerEvent = new NamedObjectType("ContainerEvent", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("count", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("firstTimestamp", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("lastTimestamp", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("message", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.None)}, null);
            AutoScalingPolicy = new NamedObjectType("AutoScalingPolicy", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("trigger", () => AutoScalingTrigger, TypePropertyFlags.Required), new LazyTypeProperty("mechanism", () => AutoScalingMechanism, TypePropertyFlags.Required)}, null);
            AutoScalingTrigger = LanguageConstants.Any;
            AutoScalingMechanism = LanguageConstants.Any;
            DiagnosticsDescription = new NamedObjectType("DiagnosticsDescription", new ITypeProperty[]{new LazyTypeProperty("sinks", () => new TypedArrayType(DiagnosticsSinkProperties), TypePropertyFlags.None), new TypeProperty("enabled", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("defaultSinkRefs", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None)}, null);
            DiagnosticsSinkProperties = new DiscriminatedObjectType("DiagnosticsSinkProperties", "kind", new ITypeProperty[]{new LazyTypeProperty("DiagnosticsSinkProperties", () => AzureInternalMonitoringPipelineSinkDescription, TypePropertyFlags.None)});
            AzureInternalMonitoringPipelineSinkDescription = new NamedObjectType("AzureInternalMonitoringPipelineSinkDescription", new ITypeProperty[]{new TypeProperty("accountName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("namespace", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("maConfigUrl", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("fluentdConfigUrl", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("autoKeyConfigUrl", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("kind", new StringLiteralType("'AzureInternalMonitoringPipeline'"), TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ResourceType_secrets = new ResourceType("Microsoft.ServiceFabricMesh/secrets", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.ServiceFabricMesh/secrets'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => SecretResourceProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2018-09-01-preview'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_secrets);
            ResourceType_volumes = new ResourceType("Microsoft.ServiceFabricMesh/volumes", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.ServiceFabricMesh/volumes'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => VolumeResourceProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2018-09-01-preview'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_volumes);
            ResourceType_networks = new ResourceType("Microsoft.ServiceFabricMesh/networks", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.ServiceFabricMesh/networks'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => NetworkResourceProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2018-09-01-preview'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_networks);
            ResourceType_gateways = new ResourceType("Microsoft.ServiceFabricMesh/gateways", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.ServiceFabricMesh/gateways'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => GatewayResourceProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2018-09-01-preview'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_gateways);
            ResourceType_applications = new ResourceType("Microsoft.ServiceFabricMesh/applications", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.ServiceFabricMesh/applications'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => ApplicationResourceProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2018-09-01-preview'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_applications);
            ResourceType_secrets_values = new ResourceType("Microsoft.ServiceFabricMesh/secrets/values", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.ServiceFabricMesh/secrets/values'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => SecretValueResourceProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2018-09-01-preview'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_secrets_values);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_secrets, () => InstanceLazy.Value.ResourceType_secrets);
            registrar.RegisterType(ResourceTypeReference_volumes, () => InstanceLazy.Value.ResourceType_volumes);
            registrar.RegisterType(ResourceTypeReference_networks, () => InstanceLazy.Value.ResourceType_networks);
            registrar.RegisterType(ResourceTypeReference_gateways, () => InstanceLazy.Value.ResourceType_gateways);
            registrar.RegisterType(ResourceTypeReference_applications, () => InstanceLazy.Value.ResourceType_applications);
            registrar.RegisterType(ResourceTypeReference_secrets_values, () => InstanceLazy.Value.ResourceType_secrets_values);
        }
        private readonly ResourceType ResourceType_secrets;
        private readonly ResourceType ResourceType_volumes;
        private readonly ResourceType ResourceType_networks;
        private readonly ResourceType ResourceType_gateways;
        private readonly ResourceType ResourceType_applications;
        private readonly ResourceType ResourceType_secrets_values;
        private readonly TypeSymbol SecretResourceProperties;
        private readonly TypeSymbol InlinedValueSecretResourceProperties;
        private readonly TypeSymbol SecretValueResourceProperties;
        private readonly TypeSymbol VolumeResourceProperties;
        private readonly TypeSymbol VolumeProviderParametersAzureFile;
        private readonly TypeSymbol NetworkResourceProperties;
        private readonly TypeSymbol LocalNetworkResourceProperties;
        private readonly TypeSymbol GatewayResourceProperties;
        private readonly TypeSymbol NetworkRef;
        private readonly TypeSymbol EndpointRef;
        private readonly TypeSymbol TcpConfig;
        private readonly TypeSymbol GatewayDestination;
        private readonly TypeSymbol HttpConfig;
        private readonly TypeSymbol HttpHostConfig;
        private readonly TypeSymbol HttpRouteConfig;
        private readonly TypeSymbol HttpRouteMatchRule;
        private readonly TypeSymbol HttpRouteMatchPath;
        private readonly TypeSymbol HttpRouteMatchHeader;
        private readonly TypeSymbol ApplicationResourceProperties;
        private readonly TypeSymbol ServiceResourceDescription;
        private readonly TypeSymbol ServiceResourceProperties;
        private readonly TypeSymbol ContainerCodePackageProperties;
        private readonly TypeSymbol ImageRegistryCredential;
        private readonly TypeSymbol EnvironmentVariable;
        private readonly TypeSymbol Setting;
        private readonly TypeSymbol ContainerLabel;
        private readonly TypeSymbol EndpointProperties;
        private readonly TypeSymbol ResourceRequirements;
        private readonly TypeSymbol ResourceRequests;
        private readonly TypeSymbol ResourceLimits;
        private readonly TypeSymbol VolumeReference;
        private readonly TypeSymbol ApplicationScopedVolume;
        private readonly TypeSymbol ApplicationScopedVolumeCreationParameters;
        private readonly TypeSymbol ApplicationScopedVolumeCreationParametersServiceFabricVolumeDisk;
        private readonly TypeSymbol DiagnosticsRef;
        private readonly TypeSymbol ReliableCollectionsRef;
        private readonly TypeSymbol ContainerInstanceView;
        private readonly TypeSymbol ContainerState;
        private readonly TypeSymbol ContainerEvent;
        private readonly TypeSymbol AutoScalingPolicy;
        private readonly TypeSymbol AutoScalingTrigger;
        private readonly TypeSymbol AutoScalingMechanism;
        private readonly TypeSymbol DiagnosticsDescription;
        private readonly TypeSymbol DiagnosticsSinkProperties;
        private readonly TypeSymbol AzureInternalMonitoringPipelineSinkDescription;
    }
}
