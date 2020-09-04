// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_ContainerRegistry_2019_05_01
    {
        private const string ProviderNamespace = "Microsoft.ContainerRegistry";
        private const string ApiVersion = "2019-05-01";
        private static readonly ResourceTypeReference ResourceTypeReference_registries = new ResourceTypeReference(ProviderNamespace, new[]{"registries"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_registries_replications = new ResourceTypeReference(ProviderNamespace, new[]{"registries", "replications"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_registries_webhooks = new ResourceTypeReference(ProviderNamespace, new[]{"registries", "webhooks"}, ApiVersion);
        private static Lazy<Microsoft_ContainerRegistry_2019_05_01> InstanceLazy = new Lazy<Microsoft_ContainerRegistry_2019_05_01>(() => new Microsoft_ContainerRegistry_2019_05_01());
        private Microsoft_ContainerRegistry_2019_05_01()
        {
            Sku = new NamedObjectType("Sku", new ITypeProperty[]{new TypeProperty("name", UnionType.Create(new StringLiteralType("'Classic'"), new StringLiteralType("'Basic'"), new StringLiteralType("'Standard'"), new StringLiteralType("'Premium'")), TypePropertyFlags.Required), new TypeProperty("tier", UnionType.Create(new StringLiteralType("'Classic'"), new StringLiteralType("'Basic'"), new StringLiteralType("'Standard'"), new StringLiteralType("'Premium'")), TypePropertyFlags.ReadOnly)}, null);
            RegistryProperties = new NamedObjectType("RegistryProperties", new ITypeProperty[]{new TypeProperty("loginServer", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("creationDate", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("provisioningState", UnionType.Create(new StringLiteralType("'Creating'"), new StringLiteralType("'Updating'"), new StringLiteralType("'Deleting'"), new StringLiteralType("'Succeeded'"), new StringLiteralType("'Failed'"), new StringLiteralType("'Canceled'")), TypePropertyFlags.ReadOnly), new LazyTypeProperty("status", () => Status, TypePropertyFlags.ReadOnly), new TypeProperty("adminUserEnabled", LanguageConstants.Bool, TypePropertyFlags.None), new LazyTypeProperty("storageAccount", () => StorageAccountProperties, TypePropertyFlags.None), new LazyTypeProperty("networkRuleSet", () => NetworkRuleSet, TypePropertyFlags.None), new LazyTypeProperty("policies", () => Policies, TypePropertyFlags.None)}, null);
            Status = new NamedObjectType("Status", new ITypeProperty[]{new TypeProperty("displayStatus", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("message", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("timestamp", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            StorageAccountProperties = new NamedObjectType("StorageAccountProperties", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.Required)}, null);
            NetworkRuleSet = new NamedObjectType("NetworkRuleSet", new ITypeProperty[]{new TypeProperty("defaultAction", UnionType.Create(new StringLiteralType("'Allow'"), new StringLiteralType("'Deny'")), TypePropertyFlags.Required), new LazyTypeProperty("virtualNetworkRules", () => new TypedArrayType(VirtualNetworkRule), TypePropertyFlags.None), new LazyTypeProperty("ipRules", () => new TypedArrayType(IPRule), TypePropertyFlags.None)}, null);
            VirtualNetworkRule = new NamedObjectType("VirtualNetworkRule", new ITypeProperty[]{new TypeProperty("action", new StringLiteralType("'Allow'"), TypePropertyFlags.None), new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.Required)}, null);
            IPRule = new NamedObjectType("IPRule", new ITypeProperty[]{new TypeProperty("action", new StringLiteralType("'Allow'"), TypePropertyFlags.None), new TypeProperty("value", LanguageConstants.String, TypePropertyFlags.Required)}, null);
            Policies = new NamedObjectType("Policies", new ITypeProperty[]{new LazyTypeProperty("quarantinePolicy", () => QuarantinePolicy, TypePropertyFlags.None), new LazyTypeProperty("trustPolicy", () => TrustPolicy, TypePropertyFlags.None), new LazyTypeProperty("retentionPolicy", () => RetentionPolicy, TypePropertyFlags.None)}, null);
            QuarantinePolicy = new NamedObjectType("QuarantinePolicy", new ITypeProperty[]{new TypeProperty("status", UnionType.Create(new StringLiteralType("'enabled'"), new StringLiteralType("'disabled'")), TypePropertyFlags.None)}, null);
            TrustPolicy = new NamedObjectType("TrustPolicy", new ITypeProperty[]{new TypeProperty("type", new StringLiteralType("'Notary'"), TypePropertyFlags.None), new TypeProperty("status", UnionType.Create(new StringLiteralType("'enabled'"), new StringLiteralType("'disabled'")), TypePropertyFlags.None)}, null);
            RetentionPolicy = new NamedObjectType("RetentionPolicy", new ITypeProperty[]{new TypeProperty("days", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("lastUpdatedTime", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("status", UnionType.Create(new StringLiteralType("'enabled'"), new StringLiteralType("'disabled'")), TypePropertyFlags.None)}, null);
            ReplicationProperties = new NamedObjectType("ReplicationProperties", new ITypeProperty[]{new TypeProperty("provisioningState", UnionType.Create(new StringLiteralType("'Creating'"), new StringLiteralType("'Updating'"), new StringLiteralType("'Deleting'"), new StringLiteralType("'Succeeded'"), new StringLiteralType("'Failed'"), new StringLiteralType("'Canceled'")), TypePropertyFlags.ReadOnly), new LazyTypeProperty("status", () => Status, TypePropertyFlags.ReadOnly)}, null);
            WebhookPropertiesCreateParameters = new NamedObjectType("WebhookPropertiesCreateParameters", new ITypeProperty[]{new TypeProperty("serviceUri", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("customHeaders", new NamedObjectType("customHeaders", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("status", UnionType.Create(new StringLiteralType("'enabled'"), new StringLiteralType("'disabled'")), TypePropertyFlags.None), new TypeProperty("scope", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("actions", new TypedArrayType(UnionType.Create(new StringLiteralType("'push'"), new StringLiteralType("'delete'"), new StringLiteralType("'quarantine'"), new StringLiteralType("'chart_push'"), new StringLiteralType("'chart_delete'"))), TypePropertyFlags.Required)}, null);
            ResourceType_registries = new ResourceType("Microsoft.ContainerRegistry/registries", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.ContainerRegistry/registries'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("sku", () => Sku, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => RegistryProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2019-05-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_registries);
            ResourceType_registries_replications = new ResourceType("Microsoft.ContainerRegistry/registries/replications", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.ContainerRegistry/registries/replications'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("properties", () => ReplicationProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2019-05-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_registries_replications);
            ResourceType_registries_webhooks = new ResourceType("Microsoft.ContainerRegistry/registries/webhooks", new ITypeProperty[]{new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => WebhookPropertiesCreateParameters, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.ContainerRegistry/registries/webhooks'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", new StringLiteralType("'2019-05-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_registries_webhooks);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_registries, () => InstanceLazy.Value.ResourceType_registries);
            registrar.RegisterType(ResourceTypeReference_registries_replications, () => InstanceLazy.Value.ResourceType_registries_replications);
            registrar.RegisterType(ResourceTypeReference_registries_webhooks, () => InstanceLazy.Value.ResourceType_registries_webhooks);
        }
        private readonly ResourceType ResourceType_registries;
        private readonly ResourceType ResourceType_registries_replications;
        private readonly ResourceType ResourceType_registries_webhooks;
        private readonly TypeSymbol Sku;
        private readonly TypeSymbol RegistryProperties;
        private readonly TypeSymbol Status;
        private readonly TypeSymbol StorageAccountProperties;
        private readonly TypeSymbol NetworkRuleSet;
        private readonly TypeSymbol VirtualNetworkRule;
        private readonly TypeSymbol IPRule;
        private readonly TypeSymbol Policies;
        private readonly TypeSymbol QuarantinePolicy;
        private readonly TypeSymbol TrustPolicy;
        private readonly TypeSymbol RetentionPolicy;
        private readonly TypeSymbol ReplicationProperties;
        private readonly TypeSymbol WebhookPropertiesCreateParameters;
    }
}
