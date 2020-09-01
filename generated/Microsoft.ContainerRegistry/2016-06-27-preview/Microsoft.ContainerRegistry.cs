// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_ContainerRegistry_2016_06_27_preview
    {
        private const string ProviderNamespace = "Microsoft.ContainerRegistry";
        private const string ApiVersion = "2016-06-27-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_registries = new ResourceTypeReference(ProviderNamespace, new[]{"registries"}, ApiVersion);
        private static Lazy<Microsoft_ContainerRegistry_2016_06_27_preview> InstanceLazy = new Lazy<Microsoft_ContainerRegistry_2016_06_27_preview>(() => new Microsoft_ContainerRegistry_2016_06_27_preview());
        private Microsoft_ContainerRegistry_2016_06_27_preview()
        {
            RegistryProperties = new NamedObjectType("RegistryProperties", new ITypeProperty[]{new TypeProperty("adminUserEnabled", LanguageConstants.Bool, TypePropertyFlags.None), new LazyTypeProperty("storageAccount", () => StorageAccountProperties, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            StorageAccountProperties = new NamedObjectType("StorageAccountProperties", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("accessKey", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ResourceType_registries = new ResourceType("Microsoft.ContainerRegistry/registries", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new LazyTypeProperty("properties", () => RegistryProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_registries);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_registries, () => InstanceLazy.Value.ResourceType_registries);
        }
        private readonly ResourceType ResourceType_registries;
        private readonly TypeSymbol RegistryProperties;
        private readonly TypeSymbol StorageAccountProperties;
    }
}
