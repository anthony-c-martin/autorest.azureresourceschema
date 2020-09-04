// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_EnterpriseKnowledgeGraph_2018_12_03
    {
        private const string ProviderNamespace = "Microsoft.EnterpriseKnowledgeGraph";
        private const string ApiVersion = "2018-12-03";
        private static readonly ResourceTypeReference ResourceTypeReference_services = new ResourceTypeReference(ProviderNamespace, new[]{"services"}, ApiVersion);
        private static Lazy<Microsoft_EnterpriseKnowledgeGraph_2018_12_03> InstanceLazy = new Lazy<Microsoft_EnterpriseKnowledgeGraph_2018_12_03>(() => new Microsoft_EnterpriseKnowledgeGraph_2018_12_03());
        private Microsoft_EnterpriseKnowledgeGraph_2018_12_03()
        {
            Sku = new NamedObjectType("Sku", new ITypeProperty[]{new TypeProperty("name", UnionType.Create(new StringLiteralType("'F0'"), new StringLiteralType("'S1'")), TypePropertyFlags.Required)}, null);
            EnterpriseKnowledgeGraphProperties = new NamedObjectType("EnterpriseKnowledgeGraphProperties", new ITypeProperty[]{new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("metadata", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("provisioningState", UnionType.Create(new StringLiteralType("'Creating'"), new StringLiteralType("'Deleting'"), new StringLiteralType("'Failed'"), new StringLiteralType("'Succeeded'")), TypePropertyFlags.None)}, null);
            ResourceType_services = new ResourceType("Microsoft.EnterpriseKnowledgeGraph/services", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.EnterpriseKnowledgeGraph/services'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("sku", () => Sku, TypePropertyFlags.None), new LazyTypeProperty("properties", () => EnterpriseKnowledgeGraphProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2018-12-03'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_services);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_services, () => InstanceLazy.Value.ResourceType_services);
        }
        private readonly ResourceType ResourceType_services;
        private readonly TypeSymbol Sku;
        private readonly TypeSymbol EnterpriseKnowledgeGraphProperties;
    }
}
