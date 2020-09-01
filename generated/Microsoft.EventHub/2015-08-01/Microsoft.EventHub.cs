// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_EventHub_2015_08_01
    {
        private const string ProviderNamespace = "Microsoft.EventHub";
        private const string ApiVersion = "2015-08-01";
        private static readonly ResourceTypeReference ResourceTypeReference_namespaces = new ResourceTypeReference(ProviderNamespace, new[]{"namespaces"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_namespaces_AuthorizationRules = new ResourceTypeReference(ProviderNamespace, new[]{"namespaces", "AuthorizationRules"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_namespaces_eventhubs = new ResourceTypeReference(ProviderNamespace, new[]{"namespaces", "eventhubs"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_namespaces_eventhubs_authorizationRules = new ResourceTypeReference(ProviderNamespace, new[]{"namespaces", "eventhubs", "authorizationRules"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_namespaces_eventhubs_consumergroups = new ResourceTypeReference(ProviderNamespace, new[]{"namespaces", "eventhubs", "consumergroups"}, ApiVersion);
        private static Lazy<Microsoft_EventHub_2015_08_01> InstanceLazy = new Lazy<Microsoft_EventHub_2015_08_01>(() => new Microsoft_EventHub_2015_08_01());
        private Microsoft_EventHub_2015_08_01()
        {
            Sku = new NamedObjectType("Sku", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tier", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("capacity", LanguageConstants.Int, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            NamespaceProperties = new NamedObjectType("NamespaceProperties", new ITypeProperty[]{new TypeProperty("status", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("provisioningState", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("createdAt", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("updatedAt", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("serviceBusEndpoint", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("enabled", LanguageConstants.Bool, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            SharedAccessAuthorizationRuleProperties = new NamedObjectType("SharedAccessAuthorizationRuleProperties", new ITypeProperty[]{new TypeProperty("rights", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            EventHubProperties = new NamedObjectType("EventHubProperties", new ITypeProperty[]{new TypeProperty("messageRetentionInDays", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("partitionCount", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("status", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ConsumerGroupProperties = new NamedObjectType("ConsumerGroupProperties", new ITypeProperty[]{new TypeProperty("userMetadata", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_namespaces = new ResourceType("Microsoft.EventHub/namespaces", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("sku", () => Sku, TypePropertyFlags.None), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new LazyTypeProperty("properties", () => NamespaceProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_namespaces);
            ResourceType_namespaces_AuthorizationRules = new ResourceType("Microsoft.EventHub/namespaces/AuthorizationRules", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new LazyTypeProperty("properties", () => SharedAccessAuthorizationRuleProperties, TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_namespaces_AuthorizationRules);
            ResourceType_namespaces_eventhubs = new ResourceType("Microsoft.EventHub/namespaces/eventhubs", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new LazyTypeProperty("properties", () => EventHubProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_namespaces_eventhubs);
            ResourceType_namespaces_eventhubs_authorizationRules = new ResourceType("Microsoft.EventHub/namespaces/eventhubs/authorizationRules", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new LazyTypeProperty("properties", () => SharedAccessAuthorizationRuleProperties, TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_namespaces_eventhubs_authorizationRules);
            ResourceType_namespaces_eventhubs_consumergroups = new ResourceType("Microsoft.EventHub/namespaces/eventhubs/consumergroups", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new LazyTypeProperty("properties", () => ConsumerGroupProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_namespaces_eventhubs_consumergroups);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_namespaces, () => InstanceLazy.Value.ResourceType_namespaces);
            registrar.RegisterType(ResourceTypeReference_namespaces_AuthorizationRules, () => InstanceLazy.Value.ResourceType_namespaces_AuthorizationRules);
            registrar.RegisterType(ResourceTypeReference_namespaces_eventhubs, () => InstanceLazy.Value.ResourceType_namespaces_eventhubs);
            registrar.RegisterType(ResourceTypeReference_namespaces_eventhubs_authorizationRules, () => InstanceLazy.Value.ResourceType_namespaces_eventhubs_authorizationRules);
            registrar.RegisterType(ResourceTypeReference_namespaces_eventhubs_consumergroups, () => InstanceLazy.Value.ResourceType_namespaces_eventhubs_consumergroups);
        }
        private readonly ResourceType ResourceType_namespaces;
        private readonly ResourceType ResourceType_namespaces_AuthorizationRules;
        private readonly ResourceType ResourceType_namespaces_eventhubs;
        private readonly ResourceType ResourceType_namespaces_eventhubs_authorizationRules;
        private readonly ResourceType ResourceType_namespaces_eventhubs_consumergroups;
        private readonly TypeSymbol Sku;
        private readonly TypeSymbol NamespaceProperties;
        private readonly TypeSymbol SharedAccessAuthorizationRuleProperties;
        private readonly TypeSymbol EventHubProperties;
        private readonly TypeSymbol ConsumerGroupProperties;
    }
}
