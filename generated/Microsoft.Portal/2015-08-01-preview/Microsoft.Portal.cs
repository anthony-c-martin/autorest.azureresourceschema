// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_Portal_2015_08_01_preview
    {
        private const string ProviderNamespace = "Microsoft.Portal";
        private const string ApiVersion = "2015-08-01-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_dashboards = new ResourceTypeReference(ProviderNamespace, new[]{"dashboards"}, ApiVersion);
        private static Lazy<Microsoft_Portal_2015_08_01_preview> InstanceLazy = new Lazy<Microsoft_Portal_2015_08_01_preview>(() => new Microsoft_Portal_2015_08_01_preview());
        private Microsoft_Portal_2015_08_01_preview()
        {
            DashboardProperties = new NamedObjectType("DashboardProperties", new ITypeProperty[]{new TypeProperty("lenses", new NamedObjectType("lenses", new ITypeProperty[]{}, new LazyTypeProperty("additionalProperties", () => DashboardLens, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("metadata", new NamedObjectType("metadata", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.Any, TypePropertyFlags.None)), TypePropertyFlags.None)}, null);
            DashboardLens = new NamedObjectType("DashboardLens", new ITypeProperty[]{new TypeProperty("order", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("parts", new NamedObjectType("parts", new ITypeProperty[]{}, new LazyTypeProperty("additionalProperties", () => DashboardParts, TypePropertyFlags.None)), TypePropertyFlags.Required), new TypeProperty("metadata", new NamedObjectType("metadata", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.Any, TypePropertyFlags.None)), TypePropertyFlags.None)}, null);
            DashboardParts = new NamedObjectType("DashboardParts", new ITypeProperty[]{new LazyTypeProperty("position", () => DashboardPartsPosition, TypePropertyFlags.Required), new TypeProperty("metadata", new NamedObjectType("metadata", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.Any, TypePropertyFlags.None)), TypePropertyFlags.None)}, null);
            DashboardPartsPosition = new NamedObjectType("DashboardPartsPosition", new ITypeProperty[]{new TypeProperty("x", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("y", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("rowSpan", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("colSpan", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("metadata", new NamedObjectType("metadata", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.Any, TypePropertyFlags.None)), TypePropertyFlags.None)}, null);
            ResourceType_dashboards = new ResourceType("Microsoft.Portal/dashboards", new ITypeProperty[]{new LazyTypeProperty("properties", () => DashboardProperties, TypePropertyFlags.Required), new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.Portal/dashboards'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("apiVersion", new StringLiteralType("'2015-08-01-preview'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_dashboards);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_dashboards, () => InstanceLazy.Value.ResourceType_dashboards);
        }
        private readonly ResourceType ResourceType_dashboards;
        private readonly TypeSymbol DashboardProperties;
        private readonly TypeSymbol DashboardLens;
        private readonly TypeSymbol DashboardParts;
        private readonly TypeSymbol DashboardPartsPosition;
    }
}
