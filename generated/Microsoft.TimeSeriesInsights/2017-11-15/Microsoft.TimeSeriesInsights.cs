// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_TimeSeriesInsights_2017_11_15
    {
        private const string ProviderNamespace = "Microsoft.TimeSeriesInsights";
        private const string ApiVersion = "2017-11-15";
        private static readonly ResourceTypeReference ResourceTypeReference_environments = new ResourceTypeReference(ProviderNamespace, new[]{"environments"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_environments_eventSources = new ResourceTypeReference(ProviderNamespace, new[]{"environments", "eventSources"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_environments_referenceDataSets = new ResourceTypeReference(ProviderNamespace, new[]{"environments", "referenceDataSets"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_environments_accessPolicies = new ResourceTypeReference(ProviderNamespace, new[]{"environments", "accessPolicies"}, ApiVersion);
        private static Lazy<Microsoft_TimeSeriesInsights_2017_11_15> InstanceLazy = new Lazy<Microsoft_TimeSeriesInsights_2017_11_15>(() => new Microsoft_TimeSeriesInsights_2017_11_15());
        private Microsoft_TimeSeriesInsights_2017_11_15()
        {
            Sku = new NamedObjectType("Sku", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("capacity", LanguageConstants.Int, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            EnvironmentCreationProperties = new NamedObjectType("EnvironmentCreationProperties", new ITypeProperty[]{new TypeProperty("dataRetentionTime", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("storageLimitExceededBehavior", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("partitionKeyProperties", LanguageConstants.Array, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            PartitionKeyProperty = new NamedObjectType("PartitionKeyProperty", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            EventHubEventSourceCreateOrUpdateParameters = new NamedObjectType("EventHubEventSourceCreateOrUpdateParameters", new ITypeProperty[]{new LazyTypeProperty("properties", () => EventHubEventSourceCreationProperties, TypePropertyFlags.Required), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            EventHubEventSourceCreationProperties = new NamedObjectType("EventHubEventSourceCreationProperties", new ITypeProperty[]{new TypeProperty("provisioningState", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("timestampPropertyName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("eventSourceResourceId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("serviceBusNamespace", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("eventHubName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("consumerGroupName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("keyName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("sharedAccessKey", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            IoTHubEventSourceCreateOrUpdateParameters = new NamedObjectType("IoTHubEventSourceCreateOrUpdateParameters", new ITypeProperty[]{new LazyTypeProperty("properties", () => IoTHubEventSourceCreationProperties, TypePropertyFlags.Required), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            IoTHubEventSourceCreationProperties = new NamedObjectType("IoTHubEventSourceCreationProperties", new ITypeProperty[]{new TypeProperty("provisioningState", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("timestampPropertyName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("eventSourceResourceId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("iotHubName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("consumerGroupName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("keyName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("sharedAccessKey", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ReferenceDataSetCreationProperties = new NamedObjectType("ReferenceDataSetCreationProperties", new ITypeProperty[]{new TypeProperty("keyProperties", LanguageConstants.Array, TypePropertyFlags.Required), new TypeProperty("dataStringComparisonBehavior", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ReferenceDataSetKeyProperty = new NamedObjectType("ReferenceDataSetKeyProperty", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            AccessPolicyResourceProperties = new NamedObjectType("AccessPolicyResourceProperties", new ITypeProperty[]{new TypeProperty("principalObjectId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("roles", LanguageConstants.Array, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_environments = new ResourceType("Microsoft.TimeSeriesInsights/environments", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("sku", () => Sku, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => EnvironmentCreationProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_environments);
            ResourceType_environments_eventSources = new ResourceType("Microsoft.TimeSeriesInsights/environments/eventSources", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_environments_eventSources);
            ResourceType_environments_referenceDataSets = new ResourceType("Microsoft.TimeSeriesInsights/environments/referenceDataSets", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("properties", () => ReferenceDataSetCreationProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_environments_referenceDataSets);
            ResourceType_environments_accessPolicies = new ResourceType("Microsoft.TimeSeriesInsights/environments/accessPolicies", new ITypeProperty[]{new LazyTypeProperty("properties", () => AccessPolicyResourceProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_environments_accessPolicies);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_environments, () => InstanceLazy.Value.ResourceType_environments);
            registrar.RegisterType(ResourceTypeReference_environments_eventSources, () => InstanceLazy.Value.ResourceType_environments_eventSources);
            registrar.RegisterType(ResourceTypeReference_environments_referenceDataSets, () => InstanceLazy.Value.ResourceType_environments_referenceDataSets);
            registrar.RegisterType(ResourceTypeReference_environments_accessPolicies, () => InstanceLazy.Value.ResourceType_environments_accessPolicies);
        }
        private readonly ResourceType ResourceType_environments;
        private readonly ResourceType ResourceType_environments_eventSources;
        private readonly ResourceType ResourceType_environments_referenceDataSets;
        private readonly ResourceType ResourceType_environments_accessPolicies;
        private readonly TypeSymbol Sku;
        private readonly TypeSymbol EnvironmentCreationProperties;
        private readonly TypeSymbol PartitionKeyProperty;
        private readonly TypeSymbol EventHubEventSourceCreateOrUpdateParameters;
        private readonly TypeSymbol EventHubEventSourceCreationProperties;
        private readonly TypeSymbol IoTHubEventSourceCreateOrUpdateParameters;
        private readonly TypeSymbol IoTHubEventSourceCreationProperties;
        private readonly TypeSymbol ReferenceDataSetCreationProperties;
        private readonly TypeSymbol ReferenceDataSetKeyProperty;
        private readonly TypeSymbol AccessPolicyResourceProperties;
    }
}
