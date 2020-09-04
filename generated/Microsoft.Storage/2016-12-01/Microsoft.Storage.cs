// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_Storage_2016_12_01
    {
        private const string ProviderNamespace = "Microsoft.Storage";
        private const string ApiVersion = "2016-12-01";
        private static readonly ResourceTypeReference ResourceTypeReference_storageAccounts = new ResourceTypeReference(ProviderNamespace, new[]{"storageAccounts"}, ApiVersion);
        private static Lazy<Microsoft_Storage_2016_12_01> InstanceLazy = new Lazy<Microsoft_Storage_2016_12_01>(() => new Microsoft_Storage_2016_12_01());
        private Microsoft_Storage_2016_12_01()
        {
            Sku = new NamedObjectType("Sku", new ITypeProperty[]{new TypeProperty("name", UnionType.Create(new StringLiteralType("'Standard_LRS'"), new StringLiteralType("'Standard_GRS'"), new StringLiteralType("'Standard_RAGRS'"), new StringLiteralType("'Standard_ZRS'"), new StringLiteralType("'Premium_LRS'")), TypePropertyFlags.Required), new TypeProperty("tier", UnionType.Create(new StringLiteralType("'Standard'"), new StringLiteralType("'Premium'")), TypePropertyFlags.ReadOnly)}, null);
            StorageAccountPropertiesCreateParameters = new NamedObjectType("StorageAccountPropertiesCreateParameters", new ITypeProperty[]{new LazyTypeProperty("customDomain", () => CustomDomain, TypePropertyFlags.None), new LazyTypeProperty("encryption", () => Encryption, TypePropertyFlags.None), new TypeProperty("accessTier", UnionType.Create(new StringLiteralType("'Hot'"), new StringLiteralType("'Cool'")), TypePropertyFlags.None), new TypeProperty("supportsHttpsTrafficOnly", LanguageConstants.Bool, TypePropertyFlags.None)}, null);
            CustomDomain = new NamedObjectType("CustomDomain", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("useSubDomainName", LanguageConstants.Bool, TypePropertyFlags.None)}, null);
            Encryption = new NamedObjectType("Encryption", new ITypeProperty[]{new LazyTypeProperty("services", () => EncryptionServices, TypePropertyFlags.None), new TypeProperty("keySource", new StringLiteralType("'Microsoft.Storage'"), TypePropertyFlags.Required)}, null);
            EncryptionServices = new NamedObjectType("EncryptionServices", new ITypeProperty[]{new LazyTypeProperty("blob", () => EncryptionService, TypePropertyFlags.None), new LazyTypeProperty("file", () => EncryptionService, TypePropertyFlags.None), new LazyTypeProperty("table", () => EncryptionService, TypePropertyFlags.ReadOnly), new LazyTypeProperty("queue", () => EncryptionService, TypePropertyFlags.ReadOnly)}, null);
            EncryptionService = new NamedObjectType("EncryptionService", new ITypeProperty[]{new TypeProperty("enabled", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("lastEnabledTime", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            ResourceType_storageAccounts = new ResourceType("Microsoft.Storage/storageAccounts", new ITypeProperty[]{new LazyTypeProperty("sku", () => Sku, TypePropertyFlags.Required), new TypeProperty("kind", UnionType.Create(new StringLiteralType("'Storage'"), new StringLiteralType("'BlobStorage'")), TypePropertyFlags.Required), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("properties", () => StorageAccountPropertiesCreateParameters, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.Storage/storageAccounts'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", new StringLiteralType("'2016-12-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_storageAccounts);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_storageAccounts, () => InstanceLazy.Value.ResourceType_storageAccounts);
        }
        private readonly ResourceType ResourceType_storageAccounts;
        private readonly TypeSymbol Sku;
        private readonly TypeSymbol StorageAccountPropertiesCreateParameters;
        private readonly TypeSymbol CustomDomain;
        private readonly TypeSymbol Encryption;
        private readonly TypeSymbol EncryptionServices;
        private readonly TypeSymbol EncryptionService;
    }
}
