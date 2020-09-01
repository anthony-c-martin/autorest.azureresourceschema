// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_Relay_2017_04_01
    {
        private const string ProviderNamespace = "Microsoft.Relay";
        private const string ApiVersion = "2017-04-01";
        private static readonly ResourceTypeReference ResourceTypeReference_namespaces = new ResourceTypeReference(ProviderNamespace, new[]{"namespaces"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_namespaces_authorizationRules = new ResourceTypeReference(ProviderNamespace, new[]{"namespaces", "authorizationRules"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_namespaces_hybridConnections = new ResourceTypeReference(ProviderNamespace, new[]{"namespaces", "hybridConnections"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_namespaces_wcfRelays = new ResourceTypeReference(ProviderNamespace, new[]{"namespaces", "wcfRelays"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_namespaces_hybridConnections_authorizationRules = new ResourceTypeReference(ProviderNamespace, new[]{"namespaces", "hybridConnections", "authorizationRules"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_namespaces_wcfRelays_authorizationRules = new ResourceTypeReference(ProviderNamespace, new[]{"namespaces", "wcfRelays", "authorizationRules"}, ApiVersion);
        private static Lazy<Microsoft_Relay_2017_04_01> InstanceLazy = new Lazy<Microsoft_Relay_2017_04_01>(() => new Microsoft_Relay_2017_04_01());
        private Microsoft_Relay_2017_04_01()
        {
            Sku = new NamedObjectType("Sku", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tier", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            RelayNamespaceProperties = new NamedObjectType("RelayNamespaceProperties", new ITypeProperty[]{}, null, TypePropertyFlags.None);
            AuthorizationRuleProperties = new NamedObjectType("AuthorizationRuleProperties", new ITypeProperty[]{new TypeProperty("rights", LanguageConstants.Array, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            HybridConnectionProperties = new NamedObjectType("HybridConnectionProperties", new ITypeProperty[]{new TypeProperty("requiresClientAuthorization", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("userMetadata", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            WcfRelayProperties = new NamedObjectType("WcfRelayProperties", new ITypeProperty[]{new TypeProperty("relayType", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("requiresClientAuthorization", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("requiresTransportSecurity", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("userMetadata", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_namespaces = new ResourceType("Microsoft.Relay/namespaces", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("sku", () => Sku, TypePropertyFlags.None), new LazyTypeProperty("properties", () => RelayNamespaceProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_namespaces);
            ResourceType_namespaces_authorizationRules = new ResourceType("Microsoft.Relay/namespaces/authorizationRules", new ITypeProperty[]{new LazyTypeProperty("properties", () => AuthorizationRuleProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_namespaces_authorizationRules);
            ResourceType_namespaces_hybridConnections = new ResourceType("Microsoft.Relay/namespaces/hybridConnections", new ITypeProperty[]{new LazyTypeProperty("properties", () => HybridConnectionProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_namespaces_hybridConnections);
            ResourceType_namespaces_wcfRelays = new ResourceType("Microsoft.Relay/namespaces/wcfRelays", new ITypeProperty[]{new LazyTypeProperty("properties", () => WcfRelayProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_namespaces_wcfRelays);
            ResourceType_namespaces_hybridConnections_authorizationRules = new ResourceType("Microsoft.Relay/namespaces/hybridConnections/authorizationRules", new ITypeProperty[]{new LazyTypeProperty("properties", () => AuthorizationRuleProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_namespaces_hybridConnections_authorizationRules);
            ResourceType_namespaces_wcfRelays_authorizationRules = new ResourceType("Microsoft.Relay/namespaces/wcfRelays/authorizationRules", new ITypeProperty[]{new LazyTypeProperty("properties", () => AuthorizationRuleProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_namespaces_wcfRelays_authorizationRules);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_namespaces, () => InstanceLazy.Value.ResourceType_namespaces);
            registrar.RegisterType(ResourceTypeReference_namespaces_authorizationRules, () => InstanceLazy.Value.ResourceType_namespaces_authorizationRules);
            registrar.RegisterType(ResourceTypeReference_namespaces_hybridConnections, () => InstanceLazy.Value.ResourceType_namespaces_hybridConnections);
            registrar.RegisterType(ResourceTypeReference_namespaces_wcfRelays, () => InstanceLazy.Value.ResourceType_namespaces_wcfRelays);
            registrar.RegisterType(ResourceTypeReference_namespaces_hybridConnections_authorizationRules, () => InstanceLazy.Value.ResourceType_namespaces_hybridConnections_authorizationRules);
            registrar.RegisterType(ResourceTypeReference_namespaces_wcfRelays_authorizationRules, () => InstanceLazy.Value.ResourceType_namespaces_wcfRelays_authorizationRules);
        }
        private readonly ResourceType ResourceType_namespaces;
        private readonly ResourceType ResourceType_namespaces_authorizationRules;
        private readonly ResourceType ResourceType_namespaces_hybridConnections;
        private readonly ResourceType ResourceType_namespaces_wcfRelays;
        private readonly ResourceType ResourceType_namespaces_hybridConnections_authorizationRules;
        private readonly ResourceType ResourceType_namespaces_wcfRelays_authorizationRules;
        private readonly TypeSymbol Sku;
        private readonly TypeSymbol RelayNamespaceProperties;
        private readonly TypeSymbol AuthorizationRuleProperties;
        private readonly TypeSymbol HybridConnectionProperties;
        private readonly TypeSymbol WcfRelayProperties;
    }
}
