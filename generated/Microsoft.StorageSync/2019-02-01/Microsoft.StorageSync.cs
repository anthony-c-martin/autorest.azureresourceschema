// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_StorageSync_2019_02_01
    {
        private const string ProviderNamespace = "Microsoft.StorageSync";
        private const string ApiVersion = "2019-02-01";
        private static readonly ResourceTypeReference ResourceTypeReference_storageSyncServices = new ResourceTypeReference(ProviderNamespace, new[]{"storageSyncServices"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_storageSyncServices_syncGroups = new ResourceTypeReference(ProviderNamespace, new[]{"storageSyncServices", "syncGroups"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_storageSyncServices_registeredServers = new ResourceTypeReference(ProviderNamespace, new[]{"storageSyncServices", "registeredServers"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_storageSyncServices_syncGroups_cloudEndpoints = new ResourceTypeReference(ProviderNamespace, new[]{"storageSyncServices", "syncGroups", "cloudEndpoints"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_storageSyncServices_syncGroups_serverEndpoints = new ResourceTypeReference(ProviderNamespace, new[]{"storageSyncServices", "syncGroups", "serverEndpoints"}, ApiVersion);
        private static Lazy<Microsoft_StorageSync_2019_02_01> InstanceLazy = new Lazy<Microsoft_StorageSync_2019_02_01>(() => new Microsoft_StorageSync_2019_02_01());
        private Microsoft_StorageSync_2019_02_01()
        {
            CloudEndpointCreateParametersProperties = new NamedObjectType("CloudEndpointCreateParametersProperties", new ITypeProperty[]{new TypeProperty("storageAccountResourceId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("azureFileShareName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("storageAccountTenantId", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ServerEndpointCreateParametersProperties = new NamedObjectType("ServerEndpointCreateParametersProperties", new ITypeProperty[]{new TypeProperty("serverLocalPath", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("cloudTiering", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("volumeFreeSpacePercent", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("tierFilesOlderThanDays", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("friendlyName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("serverResourceId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("offlineDataTransfer", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("offlineDataTransferShareName", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            RegisteredServerCreateParametersProperties = new NamedObjectType("RegisteredServerCreateParametersProperties", new ITypeProperty[]{new TypeProperty("serverCertificate", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("agentVersion", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("serverOSVersion", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("lastHeartBeat", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("serverRole", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("clusterId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("clusterName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("serverId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("friendlyName", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_storageSyncServices = new ResourceType("Microsoft.StorageSync/storageSyncServices", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("properties", LanguageConstants.Any, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_storageSyncServices);
            ResourceType_storageSyncServices_syncGroups = new ResourceType("Microsoft.StorageSync/storageSyncServices/syncGroups", new ITypeProperty[]{new TypeProperty("properties", LanguageConstants.Any, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_storageSyncServices_syncGroups);
            ResourceType_storageSyncServices_registeredServers = new ResourceType("Microsoft.StorageSync/storageSyncServices/registeredServers", new ITypeProperty[]{new LazyTypeProperty("properties", () => RegisteredServerCreateParametersProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_storageSyncServices_registeredServers);
            ResourceType_storageSyncServices_syncGroups_cloudEndpoints = new ResourceType("Microsoft.StorageSync/storageSyncServices/syncGroups/cloudEndpoints", new ITypeProperty[]{new LazyTypeProperty("properties", () => CloudEndpointCreateParametersProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_storageSyncServices_syncGroups_cloudEndpoints);
            ResourceType_storageSyncServices_syncGroups_serverEndpoints = new ResourceType("Microsoft.StorageSync/storageSyncServices/syncGroups/serverEndpoints", new ITypeProperty[]{new LazyTypeProperty("properties", () => ServerEndpointCreateParametersProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_storageSyncServices_syncGroups_serverEndpoints);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_storageSyncServices, () => InstanceLazy.Value.ResourceType_storageSyncServices);
            registrar.RegisterType(ResourceTypeReference_storageSyncServices_syncGroups, () => InstanceLazy.Value.ResourceType_storageSyncServices_syncGroups);
            registrar.RegisterType(ResourceTypeReference_storageSyncServices_registeredServers, () => InstanceLazy.Value.ResourceType_storageSyncServices_registeredServers);
            registrar.RegisterType(ResourceTypeReference_storageSyncServices_syncGroups_cloudEndpoints, () => InstanceLazy.Value.ResourceType_storageSyncServices_syncGroups_cloudEndpoints);
            registrar.RegisterType(ResourceTypeReference_storageSyncServices_syncGroups_serverEndpoints, () => InstanceLazy.Value.ResourceType_storageSyncServices_syncGroups_serverEndpoints);
        }
        private readonly ResourceType ResourceType_storageSyncServices;
        private readonly ResourceType ResourceType_storageSyncServices_syncGroups;
        private readonly ResourceType ResourceType_storageSyncServices_registeredServers;
        private readonly ResourceType ResourceType_storageSyncServices_syncGroups_cloudEndpoints;
        private readonly ResourceType ResourceType_storageSyncServices_syncGroups_serverEndpoints;
        private readonly TypeSymbol CloudEndpointCreateParametersProperties;
        private readonly TypeSymbol ServerEndpointCreateParametersProperties;
        private readonly TypeSymbol RegisteredServerCreateParametersProperties;
    }
}
