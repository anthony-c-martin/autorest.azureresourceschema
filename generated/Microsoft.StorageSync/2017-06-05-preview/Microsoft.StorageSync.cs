// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_StorageSync_2017_06_05_preview
    {
        private const string ProviderNamespace = "Microsoft.StorageSync";
        private const string ApiVersion = "2017-06-05-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_storageSyncServices = new ResourceTypeReference(ProviderNamespace, new[]{"storageSyncServices"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_storageSyncServices_syncGroups = new ResourceTypeReference(ProviderNamespace, new[]{"storageSyncServices", "syncGroups"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_storageSyncServices_registeredServers = new ResourceTypeReference(ProviderNamespace, new[]{"storageSyncServices", "registeredServers"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_storageSyncServices_syncGroups_cloudEndpoints = new ResourceTypeReference(ProviderNamespace, new[]{"storageSyncServices", "syncGroups", "cloudEndpoints"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_storageSyncServices_syncGroups_serverEndpoints = new ResourceTypeReference(ProviderNamespace, new[]{"storageSyncServices", "syncGroups", "serverEndpoints"}, ApiVersion);
        private static Lazy<Microsoft_StorageSync_2017_06_05_preview> InstanceLazy = new Lazy<Microsoft_StorageSync_2017_06_05_preview>(() => new Microsoft_StorageSync_2017_06_05_preview());
        private Microsoft_StorageSync_2017_06_05_preview()
        {
            StorageSyncServiceProperties = new NamedObjectType("StorageSyncServiceProperties", new ITypeProperty[]{new TypeProperty("storageSyncServiceStatus", LanguageConstants.Int, TypePropertyFlags.ReadOnly), new TypeProperty("storageSyncServiceUid", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            SyncGroupProperties = new NamedObjectType("SyncGroupProperties", new ITypeProperty[]{new TypeProperty("uniqueId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("syncGroupStatus", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            CloudEndpointProperties = new NamedObjectType("CloudEndpointProperties", new ITypeProperty[]{new TypeProperty("storageAccountKey", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("storageAccount", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("storageAccountResourceId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("storageAccountShareName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("storageAccountTenantId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("partnershipId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("friendlyName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("backupEnabled", LanguageConstants.Bool, TypePropertyFlags.ReadOnly), new TypeProperty("provisioningState", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("lastWorkflowId", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ServerEndpointProperties = new NamedObjectType("ServerEndpointProperties", new ITypeProperty[]{new TypeProperty("serverLocalPath", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("cloudTiering", UnionType.Create(new StringLiteralType("'on'"), new StringLiteralType("'off'")), TypePropertyFlags.None), new TypeProperty("volumeFreeSpacePercent", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("friendlyName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("lastSyncSuccess", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("syncErrorState", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("syncErrorStateTimestamp", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("syncErrorDirection", UnionType.Create(new StringLiteralType("'none'"), new StringLiteralType("'initialize'"), new StringLiteralType("'download'"), new StringLiteralType("'upload'"), new StringLiteralType("'recall'")), TypePropertyFlags.None), new TypeProperty("itemUploadErrorCount", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("itemDownloadErrorCount", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("syncErrorContext", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("currentProgressType", UnionType.Create(new StringLiteralType("'none'"), new StringLiteralType("'initialize'"), new StringLiteralType("'download'"), new StringLiteralType("'upload'"), new StringLiteralType("'recall'")), TypePropertyFlags.None), new TypeProperty("itemProgressCount", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("itemTotalCount", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("byteProgress", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("totalProgress", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("byteTotal", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("serverResourceId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("provisioningState", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("lastWorkflowId", LanguageConstants.String, TypePropertyFlags.None)}, null);
            RegisteredServerProperties = new NamedObjectType("RegisteredServerProperties", new ITypeProperty[]{new TypeProperty("serverCertificate", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("agentVersion", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("serverOSVersion", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("serverManagementtErrorCode", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("lastHeartBeat", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("provisioningState", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("serverRole", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("clusterId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("clusterName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("serverId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("storageSyncServiceUid", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("lastWorkflowId", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ResourceType_storageSyncServices = new ResourceType("Microsoft.StorageSync/storageSyncServices", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.StorageSync/storageSyncServices'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("properties", () => StorageSyncServiceProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2017-06-05-preview'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_storageSyncServices);
            ResourceType_storageSyncServices_syncGroups = new ResourceType("Microsoft.StorageSync/storageSyncServices/syncGroups", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.StorageSync/storageSyncServices/syncGroups'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new LazyTypeProperty("properties", () => SyncGroupProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2017-06-05-preview'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_storageSyncServices_syncGroups);
            ResourceType_storageSyncServices_registeredServers = new ResourceType("Microsoft.StorageSync/storageSyncServices/registeredServers", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.StorageSync/storageSyncServices/registeredServers'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new LazyTypeProperty("properties", () => RegisteredServerProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2017-06-05-preview'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_storageSyncServices_registeredServers);
            ResourceType_storageSyncServices_syncGroups_cloudEndpoints = new ResourceType("Microsoft.StorageSync/storageSyncServices/syncGroups/cloudEndpoints", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.StorageSync/storageSyncServices/syncGroups/cloudEndpoints'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new LazyTypeProperty("properties", () => CloudEndpointProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2017-06-05-preview'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_storageSyncServices_syncGroups_cloudEndpoints);
            ResourceType_storageSyncServices_syncGroups_serverEndpoints = new ResourceType("Microsoft.StorageSync/storageSyncServices/syncGroups/serverEndpoints", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.StorageSync/storageSyncServices/syncGroups/serverEndpoints'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new LazyTypeProperty("properties", () => ServerEndpointProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2017-06-05-preview'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_storageSyncServices_syncGroups_serverEndpoints);
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
        private readonly TypeSymbol StorageSyncServiceProperties;
        private readonly TypeSymbol SyncGroupProperties;
        private readonly TypeSymbol CloudEndpointProperties;
        private readonly TypeSymbol ServerEndpointProperties;
        private readonly TypeSymbol RegisteredServerProperties;
    }
}
