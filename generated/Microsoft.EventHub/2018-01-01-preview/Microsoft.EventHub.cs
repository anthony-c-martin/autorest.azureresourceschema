// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_EventHub_2018_01_01_preview
    {
        private const string ProviderNamespace = "Microsoft.EventHub";
        private const string ApiVersion = "2018-01-01-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_clusters = new ResourceTypeReference(ProviderNamespace, new[]{"clusters"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_namespaces = new ResourceTypeReference(ProviderNamespace, new[]{"namespaces"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_namespaces_ipfilterrules = new ResourceTypeReference(ProviderNamespace, new[]{"namespaces", "ipfilterrules"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_namespaces_virtualnetworkrules = new ResourceTypeReference(ProviderNamespace, new[]{"namespaces", "virtualnetworkrules"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_namespaces_networkRuleSets = new ResourceTypeReference(ProviderNamespace, new[]{"namespaces", "networkRuleSets"}, ApiVersion);
        private static Lazy<Microsoft_EventHub_2018_01_01_preview> InstanceLazy = new Lazy<Microsoft_EventHub_2018_01_01_preview>(() => new Microsoft_EventHub_2018_01_01_preview());
        private Microsoft_EventHub_2018_01_01_preview()
        {
            ClusterSku = new NamedObjectType("ClusterSku", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("capacity", LanguageConstants.Int, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ClusterProperties = new NamedObjectType("ClusterProperties", new ITypeProperty[]{}, null, TypePropertyFlags.None);
            IpFilterRuleProperties = new NamedObjectType("IpFilterRuleProperties", new ITypeProperty[]{new TypeProperty("ipMask", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("action", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("filterName", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            Sku = new NamedObjectType("Sku", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tier", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("capacity", LanguageConstants.Int, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            Identity = new NamedObjectType("Identity", new ITypeProperty[]{new TypeProperty("principalId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tenantId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            EHNamespaceProperties = new NamedObjectType("EHNamespaceProperties", new ITypeProperty[]{new TypeProperty("clusterArmId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("isAutoInflateEnabled", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("maximumThroughputUnits", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("kafkaEnabled", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("zoneRedundant", LanguageConstants.Bool, TypePropertyFlags.None), new LazyTypeProperty("encryption", () => Encryption, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            Encryption = new NamedObjectType("Encryption", new ITypeProperty[]{new TypeProperty("keyVaultProperties", new TypedArrayType(new NamedObjectType("keyVaultProperties", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("keySource", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            KeyVaultProperties = new NamedObjectType("KeyVaultProperties", new ITypeProperty[]{new TypeProperty("keyName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("keyVaultUri", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("keyVersion", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            VirtualNetworkRuleProperties = new NamedObjectType("VirtualNetworkRuleProperties", new ITypeProperty[]{new TypeProperty("virtualNetworkSubnetId", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            NetworkRuleSetProperties = new NamedObjectType("NetworkRuleSetProperties", new ITypeProperty[]{new TypeProperty("trustedServiceAccessEnabled", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("defaultAction", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("virtualNetworkRules", new TypedArrayType(new NamedObjectType("virtualNetworkRules", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("ipRules", new TypedArrayType(new NamedObjectType("ipRules", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            NWRuleSetVirtualNetworkRules = new NamedObjectType("NWRuleSetVirtualNetworkRules", new ITypeProperty[]{new LazyTypeProperty("subnet", () => Subnet, TypePropertyFlags.None), new TypeProperty("ignoreMissingVnetServiceEndpoint", LanguageConstants.Bool, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            Subnet = new NamedObjectType("Subnet", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            NWRuleSetIpRules = new NamedObjectType("NWRuleSetIpRules", new ITypeProperty[]{new TypeProperty("ipMask", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("action", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_clusters = new ResourceType("Microsoft.EventHub/clusters", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new LazyTypeProperty("sku", () => ClusterSku, TypePropertyFlags.None), new LazyTypeProperty("properties", () => ClusterProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_clusters);
            ResourceType_namespaces = new ResourceType("Microsoft.EventHub/namespaces", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new LazyTypeProperty("sku", () => Sku, TypePropertyFlags.None), new LazyTypeProperty("identity", () => Identity, TypePropertyFlags.None), new LazyTypeProperty("properties", () => EHNamespaceProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_namespaces);
            ResourceType_namespaces_ipfilterrules = new ResourceType("Microsoft.EventHub/namespaces/ipfilterrules", new ITypeProperty[]{new LazyTypeProperty("properties", () => IpFilterRuleProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_namespaces_ipfilterrules);
            ResourceType_namespaces_virtualnetworkrules = new ResourceType("Microsoft.EventHub/namespaces/virtualnetworkrules", new ITypeProperty[]{new LazyTypeProperty("properties", () => VirtualNetworkRuleProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_namespaces_virtualnetworkrules);
            ResourceType_namespaces_networkRuleSets = new ResourceType("Microsoft.EventHub/namespaces/networkRuleSets", new ITypeProperty[]{new LazyTypeProperty("properties", () => NetworkRuleSetProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_namespaces_networkRuleSets);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_clusters, () => InstanceLazy.Value.ResourceType_clusters);
            registrar.RegisterType(ResourceTypeReference_namespaces, () => InstanceLazy.Value.ResourceType_namespaces);
            registrar.RegisterType(ResourceTypeReference_namespaces_ipfilterrules, () => InstanceLazy.Value.ResourceType_namespaces_ipfilterrules);
            registrar.RegisterType(ResourceTypeReference_namespaces_virtualnetworkrules, () => InstanceLazy.Value.ResourceType_namespaces_virtualnetworkrules);
            registrar.RegisterType(ResourceTypeReference_namespaces_networkRuleSets, () => InstanceLazy.Value.ResourceType_namespaces_networkRuleSets);
        }
        private readonly ResourceType ResourceType_clusters;
        private readonly ResourceType ResourceType_namespaces;
        private readonly ResourceType ResourceType_namespaces_ipfilterrules;
        private readonly ResourceType ResourceType_namespaces_virtualnetworkrules;
        private readonly ResourceType ResourceType_namespaces_networkRuleSets;
        private readonly TypeSymbol ClusterSku;
        private readonly TypeSymbol ClusterProperties;
        private readonly TypeSymbol IpFilterRuleProperties;
        private readonly TypeSymbol Sku;
        private readonly TypeSymbol Identity;
        private readonly TypeSymbol EHNamespaceProperties;
        private readonly TypeSymbol Encryption;
        private readonly TypeSymbol KeyVaultProperties;
        private readonly TypeSymbol VirtualNetworkRuleProperties;
        private readonly TypeSymbol NetworkRuleSetProperties;
        private readonly TypeSymbol NWRuleSetVirtualNetworkRules;
        private readonly TypeSymbol Subnet;
        private readonly TypeSymbol NWRuleSetIpRules;
    }
}
