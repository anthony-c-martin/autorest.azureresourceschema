// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_HybridData_2016_06_01
    {
        private const string ProviderNamespace = "Microsoft.HybridData";
        private const string ApiVersion = "2016-06-01";
        private static readonly ResourceTypeReference ResourceTypeReference_dataManagers = new ResourceTypeReference(ProviderNamespace, new[]{"dataManagers"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_dataManagers_dataStores = new ResourceTypeReference(ProviderNamespace, new[]{"dataManagers", "dataStores"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_dataManagers_dataServices_jobDefinitions = new ResourceTypeReference(ProviderNamespace, new[]{"dataManagers", "dataServices", "jobDefinitions"}, ApiVersion);
        private static Lazy<Microsoft_HybridData_2016_06_01> InstanceLazy = new Lazy<Microsoft_HybridData_2016_06_01>(() => new Microsoft_HybridData_2016_06_01());
        private Microsoft_HybridData_2016_06_01()
        {
            Sku = new NamedObjectType("Sku", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tier", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            JobDefinitionProperties = new NamedObjectType("JobDefinitionProperties", new ITypeProperty[]{new TypeProperty("dataSourceId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("dataSinkId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("schedules", new TypedArrayType(new NamedObjectType("schedules", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("state", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("lastModifiedTime", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("runLocation", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("userConfirmation", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("dataServiceInput", new NamedObjectType("dataServiceInput", new ITypeProperty[]{}, null, TypePropertyFlags.None), TypePropertyFlags.None), new TypeProperty("customerSecrets", new TypedArrayType(new NamedObjectType("customerSecrets", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            Schedule = new NamedObjectType("Schedule", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("policyList", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            CustomerSecret = new NamedObjectType("CustomerSecret", new ITypeProperty[]{new TypeProperty("keyIdentifier", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("keyValue", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("algorithm", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            DataStoreProperties = new NamedObjectType("DataStoreProperties", new ITypeProperty[]{new TypeProperty("repositoryId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("state", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("extendedProperties", new NamedObjectType("extendedProperties", new ITypeProperty[]{}, null, TypePropertyFlags.None), TypePropertyFlags.None), new TypeProperty("dataStoreTypeId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("customerSecrets", new TypedArrayType(new NamedObjectType("customerSecrets", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_dataManagers = new ResourceType("Microsoft.HybridData/dataManagers", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new LazyTypeProperty("sku", () => Sku, TypePropertyFlags.None), new TypeProperty("etag", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_dataManagers);
            ResourceType_dataManagers_dataStores = new ResourceType("Microsoft.HybridData/dataManagers/dataStores", new ITypeProperty[]{new LazyTypeProperty("properties", () => DataStoreProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_dataManagers_dataStores);
            ResourceType_dataManagers_dataServices_jobDefinitions = new ResourceType("Microsoft.HybridData/dataManagers/dataServices/jobDefinitions", new ITypeProperty[]{new LazyTypeProperty("properties", () => JobDefinitionProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_dataManagers_dataServices_jobDefinitions);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_dataManagers, () => InstanceLazy.Value.ResourceType_dataManagers);
            registrar.RegisterType(ResourceTypeReference_dataManagers_dataStores, () => InstanceLazy.Value.ResourceType_dataManagers_dataStores);
            registrar.RegisterType(ResourceTypeReference_dataManagers_dataServices_jobDefinitions, () => InstanceLazy.Value.ResourceType_dataManagers_dataServices_jobDefinitions);
        }
        private readonly ResourceType ResourceType_dataManagers;
        private readonly ResourceType ResourceType_dataManagers_dataStores;
        private readonly ResourceType ResourceType_dataManagers_dataServices_jobDefinitions;
        private readonly TypeSymbol Sku;
        private readonly TypeSymbol JobDefinitionProperties;
        private readonly TypeSymbol Schedule;
        private readonly TypeSymbol CustomerSecret;
        private readonly TypeSymbol DataStoreProperties;
    }
}
