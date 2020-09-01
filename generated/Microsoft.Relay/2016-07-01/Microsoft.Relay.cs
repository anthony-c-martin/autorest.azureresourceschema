// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_Relay_2016_07_01
    {
        private const string ProviderNamespace = "Microsoft.Relay";
        private const string ApiVersion = "2016-07-01";
        private static readonly ResourceTypeReference ResourceTypeReference_namespaces = new ResourceTypeReference(ProviderNamespace, new[]{"namespaces"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_namespaces_AuthorizationRules = new ResourceTypeReference(ProviderNamespace, new[]{"namespaces", "AuthorizationRules"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_namespaces_HybridConnections = new ResourceTypeReference(ProviderNamespace, new[]{"namespaces", "HybridConnections"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_namespaces_WcfRelays = new ResourceTypeReference(ProviderNamespace, new[]{"namespaces", "WcfRelays"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_namespaces_HybridConnections_authorizationRules = new ResourceTypeReference(ProviderNamespace, new[]{"namespaces", "HybridConnections", "authorizationRules"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_namespaces_WcfRelays_authorizationRules = new ResourceTypeReference(ProviderNamespace, new[]{"namespaces", "WcfRelays", "authorizationRules"}, ApiVersion);
        private static Lazy<Microsoft_Relay_2016_07_01> InstanceLazy = new Lazy<Microsoft_Relay_2016_07_01>(() => new Microsoft_Relay_2016_07_01());
        private Microsoft_Relay_2016_07_01()
        {
            Sku = new NamedObjectType("Sku", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tier", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            RelayNamespaceProperties = new NamedObjectType("RelayNamespaceProperties", new ITypeProperty[]{}, null, TypePropertyFlags.None);
            AuthorizationRuleProperties = new NamedObjectType("AuthorizationRuleProperties", new ITypeProperty[]{new TypeProperty("rights", LanguageConstants.Array, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            HybridConnectionProperties = new NamedObjectType("HybridConnectionProperties", new ITypeProperty[]{new TypeProperty("requiresClientAuthorization", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("userMetadata", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            WcfRelayProperties = new NamedObjectType("WcfRelayProperties", new ITypeProperty[]{new TypeProperty("relayType", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("requiresClientAuthorization", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("requiresTransportSecurity", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("userMetadata", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_namespaces = new ResourceType("Microsoft.Relay/namespaces", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("sku", () => Sku, TypePropertyFlags.None), new LazyTypeProperty("properties", () => RelayNamespaceProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_namespaces);
            ResourceType_namespaces_AuthorizationRules = new ResourceType("Microsoft.Relay/namespaces/AuthorizationRules", new ITypeProperty[]{new LazyTypeProperty("properties", () => AuthorizationRuleProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_namespaces_AuthorizationRules);
            ResourceType_namespaces_HybridConnections = new ResourceType("Microsoft.Relay/namespaces/HybridConnections", new ITypeProperty[]{new LazyTypeProperty("properties", () => HybridConnectionProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_namespaces_HybridConnections);
            ResourceType_namespaces_WcfRelays = new ResourceType("Microsoft.Relay/namespaces/WcfRelays", new ITypeProperty[]{new LazyTypeProperty("properties", () => WcfRelayProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_namespaces_WcfRelays);
            ResourceType_namespaces_HybridConnections_authorizationRules = new ResourceType("Microsoft.Relay/namespaces/HybridConnections/authorizationRules", new ITypeProperty[]{new LazyTypeProperty("properties", () => AuthorizationRuleProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_namespaces_HybridConnections_authorizationRules);
            ResourceType_namespaces_WcfRelays_authorizationRules = new ResourceType("Microsoft.Relay/namespaces/WcfRelays/authorizationRules", new ITypeProperty[]{new LazyTypeProperty("properties", () => AuthorizationRuleProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_namespaces_WcfRelays_authorizationRules);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_namespaces, () => InstanceLazy.Value.ResourceType_namespaces);
            registrar.RegisterType(ResourceTypeReference_namespaces_AuthorizationRules, () => InstanceLazy.Value.ResourceType_namespaces_AuthorizationRules);
            registrar.RegisterType(ResourceTypeReference_namespaces_HybridConnections, () => InstanceLazy.Value.ResourceType_namespaces_HybridConnections);
            registrar.RegisterType(ResourceTypeReference_namespaces_WcfRelays, () => InstanceLazy.Value.ResourceType_namespaces_WcfRelays);
            registrar.RegisterType(ResourceTypeReference_namespaces_HybridConnections_authorizationRules, () => InstanceLazy.Value.ResourceType_namespaces_HybridConnections_authorizationRules);
            registrar.RegisterType(ResourceTypeReference_namespaces_WcfRelays_authorizationRules, () => InstanceLazy.Value.ResourceType_namespaces_WcfRelays_authorizationRules);
        }
        private readonly ResourceType ResourceType_namespaces;
        private readonly ResourceType ResourceType_namespaces_AuthorizationRules;
        private readonly ResourceType ResourceType_namespaces_HybridConnections;
        private readonly ResourceType ResourceType_namespaces_WcfRelays;
        private readonly ResourceType ResourceType_namespaces_HybridConnections_authorizationRules;
        private readonly ResourceType ResourceType_namespaces_WcfRelays_authorizationRules;
        private readonly TypeSymbol Sku;
        private readonly TypeSymbol RelayNamespaceProperties;
        private readonly TypeSymbol AuthorizationRuleProperties;
        private readonly TypeSymbol HybridConnectionProperties;
        private readonly TypeSymbol WcfRelayProperties;
    }
}
