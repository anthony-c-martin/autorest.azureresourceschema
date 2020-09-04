// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_Storage_2015_05_01_preview
    {
        private const string ProviderNamespace = "Microsoft.Storage";
        private const string ApiVersion = "2015-05-01-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_storageAccounts = new ResourceTypeReference(ProviderNamespace, new[]{"storageAccounts"}, ApiVersion);
        private static Lazy<Microsoft_Storage_2015_05_01_preview> InstanceLazy = new Lazy<Microsoft_Storage_2015_05_01_preview>(() => new Microsoft_Storage_2015_05_01_preview());
        private Microsoft_Storage_2015_05_01_preview()
        {
            StorageAccountPropertiesCreateParameters = new NamedObjectType("StorageAccountPropertiesCreateParameters", new ITypeProperty[]{new TypeProperty("accountType", UnionType.Create(new StringLiteralType("'Standard_LRS'"), new StringLiteralType("'Standard_ZRS'"), new StringLiteralType("'Standard_GRS'"), new StringLiteralType("'Standard_RAGRS'"), new StringLiteralType("'Premium_LRS'")), TypePropertyFlags.None)}, null);
            ResourceType_storageAccounts = new ResourceType("Microsoft.Storage/storageAccounts", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.Storage/storageAccounts'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("properties", () => StorageAccountPropertiesCreateParameters, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2015-05-01-preview'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_storageAccounts);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_storageAccounts, () => InstanceLazy.Value.ResourceType_storageAccounts);
        }
        private readonly ResourceType ResourceType_storageAccounts;
        private readonly TypeSymbol StorageAccountPropertiesCreateParameters;
    }
}
