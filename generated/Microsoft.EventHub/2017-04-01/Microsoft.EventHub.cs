// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_EventHub_2017_04_01
    {
        private const string ProviderNamespace = "Microsoft.EventHub";
        private const string ApiVersion = "2017-04-01";
        private static readonly ResourceTypeReference ResourceTypeReference_namespaces_authorizationRules = new ResourceTypeReference(ProviderNamespace, new[]{"namespaces", "authorizationRules"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_namespaces_disasterRecoveryConfigs = new ResourceTypeReference(ProviderNamespace, new[]{"namespaces", "disasterRecoveryConfigs"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_namespaces_eventhubs = new ResourceTypeReference(ProviderNamespace, new[]{"namespaces", "eventhubs"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_namespaces_eventhubs_authorizationRules = new ResourceTypeReference(ProviderNamespace, new[]{"namespaces", "eventhubs", "authorizationRules"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_namespaces_eventhubs_consumergroups = new ResourceTypeReference(ProviderNamespace, new[]{"namespaces", "eventhubs", "consumergroups"}, ApiVersion);
        private static Lazy<Microsoft_EventHub_2017_04_01> InstanceLazy = new Lazy<Microsoft_EventHub_2017_04_01>(() => new Microsoft_EventHub_2017_04_01());
        private Microsoft_EventHub_2017_04_01()
        {
            AuthorizationRuleProperties = new NamedObjectType("AuthorizationRuleProperties", new ITypeProperty[]{new TypeProperty("rights", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ArmDisasterRecoveryProperties = new NamedObjectType("ArmDisasterRecoveryProperties", new ITypeProperty[]{new TypeProperty("partnerNamespace", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("alternateName", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            EventhubProperties = new NamedObjectType("EventhubProperties", new ITypeProperty[]{new TypeProperty("messageRetentionInDays", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("partitionCount", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("status", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("captureDescription", () => CaptureDescription, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            CaptureDescription = new NamedObjectType("CaptureDescription", new ITypeProperty[]{new TypeProperty("enabled", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("encoding", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("intervalInSeconds", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("sizeLimitInBytes", LanguageConstants.Int, TypePropertyFlags.None), new LazyTypeProperty("destination", () => Destination, TypePropertyFlags.None), new TypeProperty("skipEmptyArchives", LanguageConstants.Bool, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            Destination = new NamedObjectType("Destination", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("properties", () => DestinationProperties, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            DestinationProperties = new NamedObjectType("DestinationProperties", new ITypeProperty[]{new TypeProperty("storageAccountResourceId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("blobContainer", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("archiveNameFormat", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ConsumerGroupProperties = new NamedObjectType("ConsumerGroupProperties", new ITypeProperty[]{new TypeProperty("userMetadata", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_namespaces_authorizationRules = new ResourceType("Microsoft.EventHub/namespaces/authorizationRules", new ITypeProperty[]{new LazyTypeProperty("properties", () => AuthorizationRuleProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_namespaces_authorizationRules);
            ResourceType_namespaces_disasterRecoveryConfigs = new ResourceType("Microsoft.EventHub/namespaces/disasterRecoveryConfigs", new ITypeProperty[]{new LazyTypeProperty("properties", () => ArmDisasterRecoveryProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_namespaces_disasterRecoveryConfigs);
            ResourceType_namespaces_eventhubs = new ResourceType("Microsoft.EventHub/namespaces/eventhubs", new ITypeProperty[]{new LazyTypeProperty("properties", () => EventhubProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_namespaces_eventhubs);
            ResourceType_namespaces_eventhubs_authorizationRules = new ResourceType("Microsoft.EventHub/namespaces/eventhubs/authorizationRules", new ITypeProperty[]{new LazyTypeProperty("properties", () => AuthorizationRuleProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_namespaces_eventhubs_authorizationRules);
            ResourceType_namespaces_eventhubs_consumergroups = new ResourceType("Microsoft.EventHub/namespaces/eventhubs/consumergroups", new ITypeProperty[]{new LazyTypeProperty("properties", () => ConsumerGroupProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_namespaces_eventhubs_consumergroups);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_namespaces_authorizationRules, () => InstanceLazy.Value.ResourceType_namespaces_authorizationRules);
            registrar.RegisterType(ResourceTypeReference_namespaces_disasterRecoveryConfigs, () => InstanceLazy.Value.ResourceType_namespaces_disasterRecoveryConfigs);
            registrar.RegisterType(ResourceTypeReference_namespaces_eventhubs, () => InstanceLazy.Value.ResourceType_namespaces_eventhubs);
            registrar.RegisterType(ResourceTypeReference_namespaces_eventhubs_authorizationRules, () => InstanceLazy.Value.ResourceType_namespaces_eventhubs_authorizationRules);
            registrar.RegisterType(ResourceTypeReference_namespaces_eventhubs_consumergroups, () => InstanceLazy.Value.ResourceType_namespaces_eventhubs_consumergroups);
        }
        private readonly ResourceType ResourceType_namespaces_authorizationRules;
        private readonly ResourceType ResourceType_namespaces_disasterRecoveryConfigs;
        private readonly ResourceType ResourceType_namespaces_eventhubs;
        private readonly ResourceType ResourceType_namespaces_eventhubs_authorizationRules;
        private readonly ResourceType ResourceType_namespaces_eventhubs_consumergroups;
        private readonly TypeSymbol AuthorizationRuleProperties;
        private readonly TypeSymbol ArmDisasterRecoveryProperties;
        private readonly TypeSymbol EventhubProperties;
        private readonly TypeSymbol CaptureDescription;
        private readonly TypeSymbol Destination;
        private readonly TypeSymbol DestinationProperties;
        private readonly TypeSymbol ConsumerGroupProperties;
    }
}
