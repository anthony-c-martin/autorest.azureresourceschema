// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_IoTSpaces_2017_10_01_preview
    {
        private const string ProviderNamespace = "Microsoft.IoTSpaces";
        private const string ApiVersion = "2017-10-01-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_Graph = new ResourceTypeReference(ProviderNamespace, new[]{"Graph"}, ApiVersion);
        private static Lazy<Microsoft_IoTSpaces_2017_10_01_preview> InstanceLazy = new Lazy<Microsoft_IoTSpaces_2017_10_01_preview>(() => new Microsoft_IoTSpaces_2017_10_01_preview());
        private Microsoft_IoTSpaces_2017_10_01_preview()
        {
            IoTSpacesProperties = new NamedObjectType("IoTSpacesProperties", new ITypeProperty[]{new LazyTypeProperty("storageContainer", () => StorageContainerProperties, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            StorageContainerProperties = new NamedObjectType("StorageContainerProperties", new ITypeProperty[]{new TypeProperty("connectionString", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("subscriptionId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("resourceGroup", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("containerName", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            IoTSpacesSkuInfo = new NamedObjectType("IoTSpacesSkuInfo", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ResourceType_Graph = new ResourceType("Microsoft.IoTSpaces/Graph", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new LazyTypeProperty("properties", () => IoTSpacesProperties, TypePropertyFlags.Required), new LazyTypeProperty("sku", () => IoTSpacesSkuInfo, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_Graph);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_Graph, () => InstanceLazy.Value.ResourceType_Graph);
        }
        private readonly ResourceType ResourceType_Graph;
        private readonly TypeSymbol IoTSpacesProperties;
        private readonly TypeSymbol StorageContainerProperties;
        private readonly TypeSymbol IoTSpacesSkuInfo;
    }
}
