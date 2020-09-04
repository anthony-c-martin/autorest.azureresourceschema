// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_WindowsIoT_2018_02_16_preview
    {
        private const string ProviderNamespace = "Microsoft.WindowsIoT";
        private const string ApiVersion = "2018-02-16-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_deviceServices = new ResourceTypeReference(ProviderNamespace, new[]{"deviceServices"}, ApiVersion);
        private static Lazy<Microsoft_WindowsIoT_2018_02_16_preview> InstanceLazy = new Lazy<Microsoft_WindowsIoT_2018_02_16_preview>(() => new Microsoft_WindowsIoT_2018_02_16_preview());
        private Microsoft_WindowsIoT_2018_02_16_preview()
        {
            DeviceServiceProperties = new NamedObjectType("DeviceServiceProperties", new ITypeProperty[]{new TypeProperty("notes", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("startDate", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("quantity", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("billingDomainName", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("adminDomainName", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ResourceType_deviceServices = new ResourceType("Microsoft.WindowsIoT/deviceServices", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.WindowsIoT/deviceServices'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("etag", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("properties", () => DeviceServiceProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2018-02-16-preview'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_deviceServices);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_deviceServices, () => InstanceLazy.Value.ResourceType_deviceServices);
        }
        private readonly ResourceType ResourceType_deviceServices;
        private readonly TypeSymbol DeviceServiceProperties;
    }
}
