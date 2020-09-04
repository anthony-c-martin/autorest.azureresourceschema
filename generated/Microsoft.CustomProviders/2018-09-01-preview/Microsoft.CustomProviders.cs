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
            CustomRPManifestProperties = new NamedObjectType("CustomRPManifestProperties", new ITypeProperty[]{new LazyTypeProperty("actions", () => new TypedArrayType(CustomRPActionRouteDefinition), TypePropertyFlags.None), new LazyTypeProperty("resourceTypes", () => new TypedArrayType(CustomRPResourceTypeRouteDefinition), TypePropertyFlags.None), new LazyTypeProperty("validations", () => new TypedArrayType(CustomRPValidations), TypePropertyFlags.None), new TypeProperty("provisioningState", UnionType.Create(new StringLiteralType("'Accepted'"), new StringLiteralType("'Deleting'"), new StringLiteralType("'Running'"), new StringLiteralType("'Succeeded'"), new StringLiteralType("'Failed'")), TypePropertyFlags.ReadOnly)}, null);
            CustomRPActionRouteDefinition = new NamedObjectType("CustomRPActionRouteDefinition", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("endpoint", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("routingType", new StringLiteralType("'Proxy'"), TypePropertyFlags.None)}, null);
            CustomRPResourceTypeRouteDefinition = new NamedObjectType("CustomRPResourceTypeRouteDefinition", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("endpoint", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("routingType", UnionType.Create(new StringLiteralType("'Proxy'"), new StringLiteralType("'Proxy,Cache'")), TypePropertyFlags.None)}, null);
            CustomRPValidations = new NamedObjectType("CustomRPValidations", new ITypeProperty[]{new TypeProperty("validationType", new StringLiteralType("'Swagger'"), TypePropertyFlags.None), new TypeProperty("specification", LanguageConstants.String, TypePropertyFlags.Required)}, null);
            AssociationProperties = new NamedObjectType("AssociationProperties", new ITypeProperty[]{new TypeProperty("targetResourceId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("provisioningState", UnionType.Create(new StringLiteralType("'Accepted'"), new StringLiteralType("'Deleting'"), new StringLiteralType("'Running'"), new StringLiteralType("'Succeeded'"), new StringLiteralType("'Failed'")), TypePropertyFlags.ReadOnly)}, null);
            ResourceType_resourceProviders = new ResourceType("Microsoft.CustomProviders/resourceProviders", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.CustomProviders/resourceProviders'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("properties", () => CustomRPManifestProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2018-09-01-preview'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_resourceProviders);
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
