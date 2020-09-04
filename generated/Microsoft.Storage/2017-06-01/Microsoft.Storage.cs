// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_Storage_2017_06_01
    {
        private const string ProviderNamespace = "Microsoft.Storage";
        private const string ApiVersion = "2017-06-01";
        private static readonly ResourceTypeReference ResourceTypeReference_storageAccounts = new ResourceTypeReference(ProviderNamespace, new[]{"storageAccounts"}, ApiVersion);
        private static Lazy<Microsoft_Storage_2017_06_01> InstanceLazy = new Lazy<Microsoft_Storage_2017_06_01>(() => new Microsoft_Storage_2017_06_01());
        private Microsoft_Storage_2017_06_01()
        {
            Sku = new NamedObjectType("Sku", new ITypeProperty[]{new TypeProperty("name", UnionType.Create(new StringLiteralType("'Standard_LRS'"), new StringLiteralType("'Standard_GRS'"), new StringLiteralType("'Standard_RAGRS'"), new StringLiteralType("'Standard_ZRS'"), new StringLiteralType("'Premium_LRS'")), TypePropertyFlags.Required), new TypeProperty("tier", UnionType.Create(new StringLiteralType("'Standard'"), new StringLiteralType("'Premium'")), TypePropertyFlags.ReadOnly), new TypeProperty("resourceType", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("kind", UnionType.Create(new StringLiteralType("'Storage'"), new StringLiteralType("'BlobStorage'")), TypePropertyFlags.ReadOnly), new TypeProperty("locations", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.ReadOnly), new LazyTypeProperty("capabilities", () => new TypedArrayType(SKUCapability), TypePropertyFlags.ReadOnly), new LazyTypeProperty("restrictions", () => new TypedArrayType(Restriction), TypePropertyFlags.None)}, null);
            SKUCapability = new NamedObjectType("SKUCapability", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("value", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            Restriction = new NamedObjectType("Restriction", new ITypeProperty[]{new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("values", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.ReadOnly), new TypeProperty("reasonCode", UnionType.Create(new StringLiteralType("'QuotaId'"), new StringLiteralType("'NotAvailableForSubscription'")), TypePropertyFlags.None)}, null);
            Identity = new NamedObjectType("Identity", new ITypeProperty[]{new TypeProperty("principalId", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("tenantId", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("type", new StringLiteralType("'SystemAssigned'"), TypePropertyFlags.Required)}, null);
            StorageAccountPropertiesCreateParameters = new NamedObjectType("StorageAccountPropertiesCreateParameters", new ITypeProperty[]{new LazyTypeProperty("customDomain", () => CustomDomain, TypePropertyFlags.None), new LazyTypeProperty("encryption", () => Encryption, TypePropertyFlags.None), new LazyTypeProperty("networkAcls", () => NetworkRuleSet, TypePropertyFlags.None), new TypeProperty("accessTier", UnionType.Create(new StringLiteralType("'Hot'"), new StringLiteralType("'Cool'")), TypePropertyFlags.None), new TypeProperty("supportsHttpsTrafficOnly", LanguageConstants.Bool, TypePropertyFlags.None)}, null);
            CustomDomain = new NamedObjectType("CustomDomain", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("useSubDomainName", LanguageConstants.Bool, TypePropertyFlags.None)}, null);
            Encryption = new NamedObjectType("Encryption", new ITypeProperty[]{new LazyTypeProperty("services", () => EncryptionServices, TypePropertyFlags.None), new TypeProperty("keySource", UnionType.Create(new StringLiteralType("'Microsoft.Storage'"), new StringLiteralType("'Microsoft.Keyvault'")), TypePropertyFlags.Required), new LazyTypeProperty("keyvaultproperties", () => KeyVaultProperties, TypePropertyFlags.None)}, null);
            EncryptionServices = new NamedObjectType("EncryptionServices", new ITypeProperty[]{new LazyTypeProperty("blob", () => EncryptionService, TypePropertyFlags.None), new LazyTypeProperty("file", () => EncryptionService, TypePropertyFlags.None), new LazyTypeProperty("table", () => EncryptionService, TypePropertyFlags.ReadOnly), new LazyTypeProperty("queue", () => EncryptionService, TypePropertyFlags.ReadOnly)}, null);
            EncryptionService = new NamedObjectType("EncryptionService", new ITypeProperty[]{new TypeProperty("enabled", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("lastEnabledTime", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            KeyVaultProperties = new NamedObjectType("KeyVaultProperties", new ITypeProperty[]{new TypeProperty("keyname", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("keyversion", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("keyvaulturi", LanguageConstants.String, TypePropertyFlags.None)}, null);
            NetworkRuleSet = new NamedObjectType("NetworkRuleSet", new ITypeProperty[]{new TypeProperty("bypass", UnionType.Create(new StringLiteralType("'None'"), new StringLiteralType("'Logging'"), new StringLiteralType("'Metrics'"), new StringLiteralType("'AzureServices'")), TypePropertyFlags.None), new LazyTypeProperty("virtualNetworkRules", () => new TypedArrayType(VirtualNetworkRule), TypePropertyFlags.None), new LazyTypeProperty("ipRules", () => new TypedArrayType(IPRule), TypePropertyFlags.None), new TypeProperty("defaultAction", UnionType.Create(new StringLiteralType("'Allow'"), new StringLiteralType("'Deny'")), TypePropertyFlags.Required)}, null);
            VirtualNetworkRule = new NamedObjectType("VirtualNetworkRule", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("action", new StringLiteralType("'Allow'"), TypePropertyFlags.None), new TypeProperty("state", UnionType.Create(new StringLiteralType("'provisioning'"), new StringLiteralType("'deprovisioning'"), new StringLiteralType("'succeeded'"), new StringLiteralType("'failed'"), new StringLiteralType("'networkSourceDeleted'")), TypePropertyFlags.None)}, null);
            IPRule = new NamedObjectType("IPRule", new ITypeProperty[]{new TypeProperty("value", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("action", new StringLiteralType("'Allow'"), TypePropertyFlags.None)}, null);
            ResourceType_storageAccounts = new ResourceType("Microsoft.Storage/storageAccounts", new ITypeProperty[]{new LazyTypeProperty("sku", () => Sku, TypePropertyFlags.Required), new TypeProperty("kind", UnionType.Create(new StringLiteralType("'Storage'"), new StringLiteralType("'BlobStorage'")), TypePropertyFlags.Required), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("identity", () => Identity, TypePropertyFlags.None), new LazyTypeProperty("properties", () => StorageAccountPropertiesCreateParameters, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.Storage/storageAccounts'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", new StringLiteralType("'2017-06-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_storageAccounts);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_storageAccounts, () => InstanceLazy.Value.ResourceType_storageAccounts);
        }
        private readonly ResourceType ResourceType_storageAccounts;
        private readonly TypeSymbol Sku;
        private readonly TypeSymbol SKUCapability;
        private readonly TypeSymbol Restriction;
        private readonly TypeSymbol Identity;
        private readonly TypeSymbol StorageAccountPropertiesCreateParameters;
        private readonly TypeSymbol CustomDomain;
        private readonly TypeSymbol Encryption;
        private readonly TypeSymbol EncryptionServices;
        private readonly TypeSymbol EncryptionService;
        private readonly TypeSymbol KeyVaultProperties;
        private readonly TypeSymbol NetworkRuleSet;
        private readonly TypeSymbol VirtualNetworkRule;
        private readonly TypeSymbol IPRule;
    }
}
