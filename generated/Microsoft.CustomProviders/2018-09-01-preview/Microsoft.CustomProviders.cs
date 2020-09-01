// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_CustomProviders_2018_09_01_preview
    {
        private const string ProviderNamespace = "Microsoft.CustomProviders";
        private const string ApiVersion = "2018-09-01-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_resourceProviders = new ResourceTypeReference(ProviderNamespace, new[]{"resourceProviders"}, ApiVersion);
        private static Lazy<Microsoft_CustomProviders_2018_09_01_preview> InstanceLazy = new Lazy<Microsoft_CustomProviders_2018_09_01_preview>(() => new Microsoft_CustomProviders_2018_09_01_preview());
        private Microsoft_CustomProviders_2018_09_01_preview()
        {
            CustomRPManifestProperties = new NamedObjectType("CustomRPManifestProperties", new ITypeProperty[]{new TypeProperty("actions", new TypedArrayType(new NamedObjectType("actions", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("resourceTypes", new TypedArrayType(new NamedObjectType("resourceTypes", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("validations", new TypedArrayType(new NamedObjectType("validations", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            CustomRPActionRouteDefinition = new NamedObjectType("CustomRPActionRouteDefinition", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("endpoint", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("routingType", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            CustomRPResourceTypeRouteDefinition = new NamedObjectType("CustomRPResourceTypeRouteDefinition", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("endpoint", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("routingType", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            CustomRPValidations = new NamedObjectType("CustomRPValidations", new ITypeProperty[]{new TypeProperty("validationType", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("specification", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            AssociationProperties = new NamedObjectType("AssociationProperties", new ITypeProperty[]{new TypeProperty("targetResourceId", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_resourceProviders = new ResourceType("Microsoft.CustomProviders/resourceProviders", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new LazyTypeProperty("properties", () => CustomRPManifestProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_resourceProviders);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_resourceProviders, () => InstanceLazy.Value.ResourceType_resourceProviders);
        }
        private readonly ResourceType ResourceType_resourceProviders;
        private readonly TypeSymbol CustomRPManifestProperties;
        private readonly TypeSymbol CustomRPActionRouteDefinition;
        private readonly TypeSymbol CustomRPResourceTypeRouteDefinition;
        private readonly TypeSymbol CustomRPValidations;
        private readonly TypeSymbol AssociationProperties;
    }
}
