// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_WindowsIoT_2019_06_01
    {
        private const string ProviderNamespace = "Microsoft.WindowsIoT";
        private const string ApiVersion = "2019-06-01";
        private static readonly ResourceTypeReference ResourceTypeReference_deviceServices = new ResourceTypeReference(ProviderNamespace, new[]{"deviceServices"}, ApiVersion);
        private static Lazy<Microsoft_WindowsIoT_2019_06_01> InstanceLazy = new Lazy<Microsoft_WindowsIoT_2019_06_01>(() => new Microsoft_WindowsIoT_2019_06_01());
        private Microsoft_WindowsIoT_2019_06_01()
        {
            ResourceType_deviceServices = new ResourceType("Microsoft.WindowsIoT/deviceServices", new ITypeProperty[]{new TypeProperty("notes", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("quantity", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("billingDomainName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("adminDomainName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_deviceServices);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_deviceServices, () => InstanceLazy.Value.ResourceType_deviceServices);
        }
        private readonly ResourceType ResourceType_deviceServices;
    }
}
