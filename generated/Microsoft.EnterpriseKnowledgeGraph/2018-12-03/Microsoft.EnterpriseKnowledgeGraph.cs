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
            Sku = new NamedObjectType("Sku", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            EnterpriseKnowledgeGraphProperties = new NamedObjectType("EnterpriseKnowledgeGraphProperties", new ITypeProperty[]{new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("metadata", new NamedObjectType("metadata", new ITypeProperty[]{}, null, TypePropertyFlags.None), TypePropertyFlags.None), new TypeProperty("provisioningState", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_services = new ResourceType("Microsoft.EnterpriseKnowledgeGraph/services", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new LazyTypeProperty("sku", () => Sku, TypePropertyFlags.None), new LazyTypeProperty("properties", () => EnterpriseKnowledgeGraphProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_services);
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
