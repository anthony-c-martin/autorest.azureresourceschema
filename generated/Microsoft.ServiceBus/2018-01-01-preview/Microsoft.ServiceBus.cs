// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_ServiceBus_2018_01_01_preview
    {
        private const string ProviderNamespace = "Microsoft.ServiceBus";
        private const string ApiVersion = "2018-01-01-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_namespaces = new ResourceTypeReference(ProviderNamespace, new[]{"namespaces"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_namespaces_ipfilterrules = new ResourceTypeReference(ProviderNamespace, new[]{"namespaces", "ipfilterrules"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_namespaces_virtualnetworkrules = new ResourceTypeReference(ProviderNamespace, new[]{"namespaces", "virtualnetworkrules"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_namespaces_networkrulesets = new ResourceTypeReference(ProviderNamespace, new[]{"namespaces", "networkrulesets"}, ApiVersion);
        private static Lazy<Microsoft_ServiceBus_2018_01_01_preview> InstanceLazy = new Lazy<Microsoft_ServiceBus_2018_01_01_preview>(() => new Microsoft_ServiceBus_2018_01_01_preview());
        private Microsoft_ServiceBus_2018_01_01_preview()
        {
            SBSku = new NamedObjectType("SBSku", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tier", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("capacity", LanguageConstants.Int, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            SBNamespaceProperties = new NamedObjectType("SBNamespaceProperties", new ITypeProperty[]{new TypeProperty("zoneRedundant", LanguageConstants.Bool, TypePropertyFlags.None), new LazyTypeProperty("encryption", () => Encryption, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            Encryption = new NamedObjectType("Encryption", new ITypeProperty[]{new LazyTypeProperty("keyVaultProperties", () => KeyVaultProperties, TypePropertyFlags.None), new TypeProperty("keySource", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            KeyVaultProperties = new NamedObjectType("KeyVaultProperties", new ITypeProperty[]{new TypeProperty("keyName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("keyVaultUri", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            IpFilterRuleProperties = new NamedObjectType("IpFilterRuleProperties", new ITypeProperty[]{new TypeProperty("ipMask", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("action", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("filterName", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            VirtualNetworkRuleProperties = new NamedObjectType("VirtualNetworkRuleProperties", new ITypeProperty[]{new TypeProperty("virtualNetworkSubnetId", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            NetworkRuleSetProperties = new NamedObjectType("NetworkRuleSetProperties", new ITypeProperty[]{new TypeProperty("defaultAction", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("virtualNetworkRules", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("ipRules", LanguageConstants.Array, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            NWRuleSetVirtualNetworkRules = new NamedObjectType("NWRuleSetVirtualNetworkRules", new ITypeProperty[]{new LazyTypeProperty("subnet", () => Subnet, TypePropertyFlags.None), new TypeProperty("ignoreMissingVnetServiceEndpoint", LanguageConstants.Bool, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            Subnet = new NamedObjectType("Subnet", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            NWRuleSetIpRules = new NamedObjectType("NWRuleSetIpRules", new ITypeProperty[]{new TypeProperty("ipMask", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("action", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_namespaces = new ResourceType("Microsoft.ServiceBus/namespaces", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("sku", () => SBSku, TypePropertyFlags.None), new LazyTypeProperty("properties", () => SBNamespaceProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_namespaces);
            ResourceType_namespaces_ipfilterrules = new ResourceType("Microsoft.ServiceBus/namespaces/ipfilterrules", new ITypeProperty[]{new LazyTypeProperty("properties", () => IpFilterRuleProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_namespaces_ipfilterrules);
            ResourceType_namespaces_virtualnetworkrules = new ResourceType("Microsoft.ServiceBus/namespaces/virtualnetworkrules", new ITypeProperty[]{new LazyTypeProperty("properties", () => VirtualNetworkRuleProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_namespaces_virtualnetworkrules);
            ResourceType_namespaces_networkrulesets = new ResourceType("Microsoft.ServiceBus/namespaces/networkrulesets", new ITypeProperty[]{new LazyTypeProperty("properties", () => NetworkRuleSetProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_namespaces_networkrulesets);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_namespaces, () => InstanceLazy.Value.ResourceType_namespaces);
            registrar.RegisterType(ResourceTypeReference_namespaces_ipfilterrules, () => InstanceLazy.Value.ResourceType_namespaces_ipfilterrules);
            registrar.RegisterType(ResourceTypeReference_namespaces_virtualnetworkrules, () => InstanceLazy.Value.ResourceType_namespaces_virtualnetworkrules);
            registrar.RegisterType(ResourceTypeReference_namespaces_networkrulesets, () => InstanceLazy.Value.ResourceType_namespaces_networkrulesets);
        }
        private readonly ResourceType ResourceType_namespaces;
        private readonly ResourceType ResourceType_namespaces_ipfilterrules;
        private readonly ResourceType ResourceType_namespaces_virtualnetworkrules;
        private readonly ResourceType ResourceType_namespaces_networkrulesets;
        private readonly TypeSymbol SBSku;
        private readonly TypeSymbol SBNamespaceProperties;
        private readonly TypeSymbol Encryption;
        private readonly TypeSymbol KeyVaultProperties;
        private readonly TypeSymbol IpFilterRuleProperties;
        private readonly TypeSymbol VirtualNetworkRuleProperties;
        private readonly TypeSymbol NetworkRuleSetProperties;
        private readonly TypeSymbol NWRuleSetVirtualNetworkRules;
        private readonly TypeSymbol Subnet;
        private readonly TypeSymbol NWRuleSetIpRules;
    }
}
