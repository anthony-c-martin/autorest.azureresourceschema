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
            SBSku = new NamedObjectType("SBSku", new ITypeProperty[]{new TypeProperty("name", UnionType.Create(new StringLiteralType("'Basic'"), new StringLiteralType("'Standard'"), new StringLiteralType("'Premium'")), TypePropertyFlags.Required), new TypeProperty("tier", UnionType.Create(new StringLiteralType("'Basic'"), new StringLiteralType("'Standard'"), new StringLiteralType("'Premium'")), TypePropertyFlags.None), new TypeProperty("capacity", LanguageConstants.Int, TypePropertyFlags.None)}, null);
            SBNamespaceProperties = new NamedObjectType("SBNamespaceProperties", new ITypeProperty[]{new TypeProperty("provisioningState", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("createdAt", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("updatedAt", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("serviceBusEndpoint", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("metricId", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("zoneRedundant", LanguageConstants.Bool, TypePropertyFlags.None), new LazyTypeProperty("encryption", () => Encryption, TypePropertyFlags.None)}, null);
            Encryption = new NamedObjectType("Encryption", new ITypeProperty[]{new LazyTypeProperty("keyVaultProperties", () => KeyVaultProperties, TypePropertyFlags.None), new TypeProperty("keySource", new StringLiteralType("'Microsoft.KeyVault'"), TypePropertyFlags.None)}, null);
            KeyVaultProperties = new NamedObjectType("KeyVaultProperties", new ITypeProperty[]{new TypeProperty("keyName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("keyVaultUri", LanguageConstants.String, TypePropertyFlags.None)}, null);
            IpFilterRuleProperties = new NamedObjectType("IpFilterRuleProperties", new ITypeProperty[]{new TypeProperty("ipMask", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("action", UnionType.Create(new StringLiteralType("'Accept'"), new StringLiteralType("'Reject'")), TypePropertyFlags.None), new TypeProperty("filterName", LanguageConstants.String, TypePropertyFlags.None)}, null);
            VirtualNetworkRuleProperties = new NamedObjectType("VirtualNetworkRuleProperties", new ITypeProperty[]{new TypeProperty("virtualNetworkSubnetId", LanguageConstants.String, TypePropertyFlags.None)}, null);
            NetworkRuleSetProperties = new NamedObjectType("NetworkRuleSetProperties", new ITypeProperty[]{new TypeProperty("defaultAction", UnionType.Create(new StringLiteralType("'Allow'"), new StringLiteralType("'Deny'")), TypePropertyFlags.None), new LazyTypeProperty("virtualNetworkRules", () => new TypedArrayType(NWRuleSetVirtualNetworkRules), TypePropertyFlags.None), new LazyTypeProperty("ipRules", () => new TypedArrayType(NWRuleSetIpRules), TypePropertyFlags.None)}, null);
            NWRuleSetVirtualNetworkRules = new NamedObjectType("NWRuleSetVirtualNetworkRules", new ITypeProperty[]{new LazyTypeProperty("subnet", () => Subnet, TypePropertyFlags.None), new TypeProperty("ignoreMissingVnetServiceEndpoint", LanguageConstants.Bool, TypePropertyFlags.None)}, null);
            Subnet = new NamedObjectType("Subnet", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.None)}, null);
            NWRuleSetIpRules = new NamedObjectType("NWRuleSetIpRules", new ITypeProperty[]{new TypeProperty("ipMask", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("action", new StringLiteralType("'Allow'"), TypePropertyFlags.None)}, null);
            ResourceType_namespaces = new ResourceType("Microsoft.ServiceBus/namespaces", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.ServiceBus/namespaces'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("sku", () => SBSku, TypePropertyFlags.None), new LazyTypeProperty("properties", () => SBNamespaceProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2018-01-01-preview'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_namespaces);
            ResourceType_namespaces_ipfilterrules = new ResourceType("Microsoft.ServiceBus/namespaces/ipfilterrules", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.ServiceBus/namespaces/ipfilterrules'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new LazyTypeProperty("properties", () => IpFilterRuleProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2018-01-01-preview'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_namespaces_ipfilterrules);
            ResourceType_namespaces_virtualnetworkrules = new ResourceType("Microsoft.ServiceBus/namespaces/virtualnetworkrules", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.ServiceBus/namespaces/virtualnetworkrules'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new LazyTypeProperty("properties", () => VirtualNetworkRuleProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2018-01-01-preview'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_namespaces_virtualnetworkrules);
            ResourceType_namespaces_networkrulesets = new ResourceType("Microsoft.ServiceBus/namespaces/networkrulesets", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.ServiceBus/namespaces/networkrulesets'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new LazyTypeProperty("properties", () => NetworkRuleSetProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2018-01-01-preview'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_namespaces_networkrulesets);
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
