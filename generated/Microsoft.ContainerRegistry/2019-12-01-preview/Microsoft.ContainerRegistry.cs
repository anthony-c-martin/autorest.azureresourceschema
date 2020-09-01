// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_ContainerRegistry_2019_12_01_preview
    {
        private const string ProviderNamespace = "Microsoft.ContainerRegistry";
        private const string ApiVersion = "2019-12-01-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_registries = new ResourceTypeReference(ProviderNamespace, new[]{"registries"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_registries_exportPipelines = new ResourceTypeReference(ProviderNamespace, new[]{"registries", "exportPipelines"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_registries_importPipelines = new ResourceTypeReference(ProviderNamespace, new[]{"registries", "importPipelines"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_registries_pipelineRuns = new ResourceTypeReference(ProviderNamespace, new[]{"registries", "pipelineRuns"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_registries_privateEndpointConnections = new ResourceTypeReference(ProviderNamespace, new[]{"registries", "privateEndpointConnections"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_registries_replications = new ResourceTypeReference(ProviderNamespace, new[]{"registries", "replications"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_registries_webhooks = new ResourceTypeReference(ProviderNamespace, new[]{"registries", "webhooks"}, ApiVersion);
        private static Lazy<Microsoft_ContainerRegistry_2019_12_01_preview> InstanceLazy = new Lazy<Microsoft_ContainerRegistry_2019_12_01_preview>(() => new Microsoft_ContainerRegistry_2019_12_01_preview());
        private Microsoft_ContainerRegistry_2019_12_01_preview()
        {
            IdentityProperties = new NamedObjectType("IdentityProperties", new ITypeProperty[]{new TypeProperty("principalId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tenantId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("userAssignedIdentities", new NamedObjectType("userAssignedIdentities", new ITypeProperty[]{}, new NamedObjectType("additionalProperties", new ITypeProperty[]{}, null, TypePropertyFlags.None), TypePropertyFlags.None), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            UserIdentityProperties = new NamedObjectType("UserIdentityProperties", new ITypeProperty[]{new TypeProperty("principalId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("clientId", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ExportPipelineProperties = new NamedObjectType("ExportPipelineProperties", new ITypeProperty[]{new LazyTypeProperty("target", () => ExportPipelineTargetProperties, TypePropertyFlags.Required), new TypeProperty("options", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ExportPipelineTargetProperties = new NamedObjectType("ExportPipelineTargetProperties", new ITypeProperty[]{new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("uri", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("keyVaultUri", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            Sku = new NamedObjectType("Sku", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            RegistryProperties = new NamedObjectType("RegistryProperties", new ITypeProperty[]{new TypeProperty("adminUserEnabled", LanguageConstants.Bool, TypePropertyFlags.None), new LazyTypeProperty("storageAccount", () => StorageAccountProperties, TypePropertyFlags.None), new LazyTypeProperty("networkRuleSet", () => NetworkRuleSet, TypePropertyFlags.None), new LazyTypeProperty("policies", () => Policies, TypePropertyFlags.None), new LazyTypeProperty("encryption", () => EncryptionProperty, TypePropertyFlags.None), new TypeProperty("dataEndpointEnabled", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("publicNetworkAccess", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            StorageAccountProperties = new NamedObjectType("StorageAccountProperties", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            NetworkRuleSet = new NamedObjectType("NetworkRuleSet", new ITypeProperty[]{new TypeProperty("defaultAction", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("virtualNetworkRules", new TypedArrayType(new NamedObjectType("virtualNetworkRules", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("ipRules", new TypedArrayType(new NamedObjectType("ipRules", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            VirtualNetworkRule = new NamedObjectType("VirtualNetworkRule", new ITypeProperty[]{new TypeProperty("action", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            IPRule = new NamedObjectType("IPRule", new ITypeProperty[]{new TypeProperty("action", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("value", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            Policies = new NamedObjectType("Policies", new ITypeProperty[]{new LazyTypeProperty("quarantinePolicy", () => QuarantinePolicy, TypePropertyFlags.None), new LazyTypeProperty("trustPolicy", () => TrustPolicy, TypePropertyFlags.None), new LazyTypeProperty("retentionPolicy", () => RetentionPolicy, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            QuarantinePolicy = new NamedObjectType("QuarantinePolicy", new ITypeProperty[]{new TypeProperty("status", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            TrustPolicy = new NamedObjectType("TrustPolicy", new ITypeProperty[]{new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("status", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            RetentionPolicy = new NamedObjectType("RetentionPolicy", new ITypeProperty[]{new TypeProperty("days", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("status", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            EncryptionProperty = new NamedObjectType("EncryptionProperty", new ITypeProperty[]{new TypeProperty("status", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("keyVaultProperties", () => KeyVaultProperties, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            KeyVaultProperties = new NamedObjectType("KeyVaultProperties", new ITypeProperty[]{new TypeProperty("keyIdentifier", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("identity", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ImportPipelineProperties = new NamedObjectType("ImportPipelineProperties", new ITypeProperty[]{new LazyTypeProperty("source", () => ImportPipelineSourceProperties, TypePropertyFlags.Required), new LazyTypeProperty("trigger", () => PipelineTriggerProperties, TypePropertyFlags.None), new TypeProperty("options", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ImportPipelineSourceProperties = new NamedObjectType("ImportPipelineSourceProperties", new ITypeProperty[]{new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("uri", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("keyVaultUri", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            PipelineTriggerProperties = new NamedObjectType("PipelineTriggerProperties", new ITypeProperty[]{new LazyTypeProperty("sourceTrigger", () => PipelineSourceTriggerProperties, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            PipelineSourceTriggerProperties = new NamedObjectType("PipelineSourceTriggerProperties", new ITypeProperty[]{new TypeProperty("status", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            PipelineRunProperties = new NamedObjectType("PipelineRunProperties", new ITypeProperty[]{new LazyTypeProperty("request", () => PipelineRunRequest, TypePropertyFlags.None), new TypeProperty("forceUpdateTag", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            PipelineRunRequest = new NamedObjectType("PipelineRunRequest", new ITypeProperty[]{new TypeProperty("pipelineResourceId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("artifacts", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new LazyTypeProperty("source", () => PipelineRunSourceProperties, TypePropertyFlags.None), new LazyTypeProperty("target", () => PipelineRunTargetProperties, TypePropertyFlags.None), new TypeProperty("catalogDigest", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            PipelineRunSourceProperties = new NamedObjectType("PipelineRunSourceProperties", new ITypeProperty[]{new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            PipelineRunTargetProperties = new NamedObjectType("PipelineRunTargetProperties", new ITypeProperty[]{new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            PrivateEndpointConnectionProperties = new NamedObjectType("PrivateEndpointConnectionProperties", new ITypeProperty[]{new LazyTypeProperty("privateEndpoint", () => PrivateEndpoint, TypePropertyFlags.None), new LazyTypeProperty("privateLinkServiceConnectionState", () => PrivateLinkServiceConnectionState, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            PrivateEndpoint = new NamedObjectType("PrivateEndpoint", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            PrivateLinkServiceConnectionState = new NamedObjectType("PrivateLinkServiceConnectionState", new ITypeProperty[]{new TypeProperty("status", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("actionsRequired", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ReplicationProperties = new NamedObjectType("ReplicationProperties", new ITypeProperty[]{new TypeProperty("regionEndpointEnabled", LanguageConstants.Bool, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            WebhookPropertiesCreateParameters = new NamedObjectType("WebhookPropertiesCreateParameters", new ITypeProperty[]{new TypeProperty("serviceUri", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("customHeaders", new NamedObjectType("customHeaders", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new TypeProperty("status", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("scope", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("actions", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ResourceType_registries = new ResourceType("Microsoft.ContainerRegistry/registries", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new LazyTypeProperty("sku", () => Sku, TypePropertyFlags.Required), new LazyTypeProperty("identity", () => IdentityProperties, TypePropertyFlags.None), new LazyTypeProperty("properties", () => RegistryProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_registries);
            ResourceType_registries_exportPipelines = new ResourceType("Microsoft.ContainerRegistry/registries/exportPipelines", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("identity", () => IdentityProperties, TypePropertyFlags.None), new LazyTypeProperty("properties", () => ExportPipelineProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_registries_exportPipelines);
            ResourceType_registries_importPipelines = new ResourceType("Microsoft.ContainerRegistry/registries/importPipelines", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("identity", () => IdentityProperties, TypePropertyFlags.None), new LazyTypeProperty("properties", () => ImportPipelineProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_registries_importPipelines);
            ResourceType_registries_pipelineRuns = new ResourceType("Microsoft.ContainerRegistry/registries/pipelineRuns", new ITypeProperty[]{new LazyTypeProperty("properties", () => PipelineRunProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_registries_pipelineRuns);
            ResourceType_registries_privateEndpointConnections = new ResourceType("Microsoft.ContainerRegistry/registries/privateEndpointConnections", new ITypeProperty[]{new LazyTypeProperty("properties", () => PrivateEndpointConnectionProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_registries_privateEndpointConnections);
            ResourceType_registries_replications = new ResourceType("Microsoft.ContainerRegistry/registries/replications", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new LazyTypeProperty("properties", () => ReplicationProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_registries_replications);
            ResourceType_registries_webhooks = new ResourceType("Microsoft.ContainerRegistry/registries/webhooks", new ITypeProperty[]{new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => WebhookPropertiesCreateParameters, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_registries_webhooks);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_registries, () => InstanceLazy.Value.ResourceType_registries);
            registrar.RegisterType(ResourceTypeReference_registries_exportPipelines, () => InstanceLazy.Value.ResourceType_registries_exportPipelines);
            registrar.RegisterType(ResourceTypeReference_registries_importPipelines, () => InstanceLazy.Value.ResourceType_registries_importPipelines);
            registrar.RegisterType(ResourceTypeReference_registries_pipelineRuns, () => InstanceLazy.Value.ResourceType_registries_pipelineRuns);
            registrar.RegisterType(ResourceTypeReference_registries_privateEndpointConnections, () => InstanceLazy.Value.ResourceType_registries_privateEndpointConnections);
            registrar.RegisterType(ResourceTypeReference_registries_replications, () => InstanceLazy.Value.ResourceType_registries_replications);
            registrar.RegisterType(ResourceTypeReference_registries_webhooks, () => InstanceLazy.Value.ResourceType_registries_webhooks);
        }
        private readonly ResourceType ResourceType_registries;
        private readonly ResourceType ResourceType_registries_exportPipelines;
        private readonly ResourceType ResourceType_registries_importPipelines;
        private readonly ResourceType ResourceType_registries_pipelineRuns;
        private readonly ResourceType ResourceType_registries_privateEndpointConnections;
        private readonly ResourceType ResourceType_registries_replications;
        private readonly ResourceType ResourceType_registries_webhooks;
        private readonly TypeSymbol IdentityProperties;
        private readonly TypeSymbol UserIdentityProperties;
        private readonly TypeSymbol ExportPipelineProperties;
        private readonly TypeSymbol ExportPipelineTargetProperties;
        private readonly TypeSymbol Sku;
        private readonly TypeSymbol RegistryProperties;
        private readonly TypeSymbol StorageAccountProperties;
        private readonly TypeSymbol NetworkRuleSet;
        private readonly TypeSymbol VirtualNetworkRule;
        private readonly TypeSymbol IPRule;
        private readonly TypeSymbol Policies;
        private readonly TypeSymbol QuarantinePolicy;
        private readonly TypeSymbol TrustPolicy;
        private readonly TypeSymbol RetentionPolicy;
        private readonly TypeSymbol EncryptionProperty;
        private readonly TypeSymbol KeyVaultProperties;
        private readonly TypeSymbol ImportPipelineProperties;
        private readonly TypeSymbol ImportPipelineSourceProperties;
        private readonly TypeSymbol PipelineTriggerProperties;
        private readonly TypeSymbol PipelineSourceTriggerProperties;
        private readonly TypeSymbol PipelineRunProperties;
        private readonly TypeSymbol PipelineRunRequest;
        private readonly TypeSymbol PipelineRunSourceProperties;
        private readonly TypeSymbol PipelineRunTargetProperties;
        private readonly TypeSymbol PrivateEndpointConnectionProperties;
        private readonly TypeSymbol PrivateEndpoint;
        private readonly TypeSymbol PrivateLinkServiceConnectionState;
        private readonly TypeSymbol ReplicationProperties;
        private readonly TypeSymbol WebhookPropertiesCreateParameters;
    }
}
