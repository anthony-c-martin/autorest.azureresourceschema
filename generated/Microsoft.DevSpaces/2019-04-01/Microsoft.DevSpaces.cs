// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_DevSpaces_2019_04_01
    {
        private const string ProviderNamespace = "Microsoft.DevSpaces";
        private const string ApiVersion = "2019-04-01";
        private static readonly ResourceTypeReference ResourceTypeReference_controllers = new ResourceTypeReference(ProviderNamespace, new[]{"controllers"}, ApiVersion);
        private static Lazy<Microsoft_DevSpaces_2019_04_01> InstanceLazy = new Lazy<Microsoft_DevSpaces_2019_04_01>(() => new Microsoft_DevSpaces_2019_04_01());
        private Microsoft_DevSpaces_2019_04_01()
        {
            ControllerProperties = new NamedObjectType("ControllerProperties", new ITypeProperty[]{new TypeProperty("targetContainerHostResourceId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("targetContainerHostCredentialsBase64", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            Sku = new NamedObjectType("Sku", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tier", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_controllers = new ResourceType("Microsoft.DevSpaces/controllers", new ITypeProperty[]{new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("properties", () => ControllerProperties, TypePropertyFlags.Required), new LazyTypeProperty("sku", () => Sku, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_controllers);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_controllers, () => InstanceLazy.Value.ResourceType_controllers);
        }
        private readonly ResourceType ResourceType_controllers;
        private readonly TypeSymbol ControllerProperties;
        private readonly TypeSymbol Sku;
    }
}
