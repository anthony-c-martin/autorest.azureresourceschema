// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_DataBoxEdge_2019_03_01
    {
        private const string ProviderNamespace = "Microsoft.DataBoxEdge";
        private const string ApiVersion = "2019-03-01";
        private static readonly ResourceTypeReference ResourceTypeReference_dataBoxEdgeDevices = new ResourceTypeReference(ProviderNamespace, new[]{"dataBoxEdgeDevices"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_dataBoxEdgeDevices_bandwidthSchedules = new ResourceTypeReference(ProviderNamespace, new[]{"dataBoxEdgeDevices", "bandwidthSchedules"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_dataBoxEdgeDevices_orders = new ResourceTypeReference(ProviderNamespace, new[]{"dataBoxEdgeDevices", "orders"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_dataBoxEdgeDevices_roles = new ResourceTypeReference(ProviderNamespace, new[]{"dataBoxEdgeDevices", "roles"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_dataBoxEdgeDevices_shares = new ResourceTypeReference(ProviderNamespace, new[]{"dataBoxEdgeDevices", "shares"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_dataBoxEdgeDevices_storageAccountCredentials = new ResourceTypeReference(ProviderNamespace, new[]{"dataBoxEdgeDevices", "storageAccountCredentials"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_dataBoxEdgeDevices_triggers = new ResourceTypeReference(ProviderNamespace, new[]{"dataBoxEdgeDevices", "triggers"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_dataBoxEdgeDevices_users = new ResourceTypeReference(ProviderNamespace, new[]{"dataBoxEdgeDevices", "users"}, ApiVersion);
        private static Lazy<Microsoft_DataBoxEdge_2019_03_01> InstanceLazy = new Lazy<Microsoft_DataBoxEdge_2019_03_01>(() => new Microsoft_DataBoxEdge_2019_03_01());
        private Microsoft_DataBoxEdge_2019_03_01()
        {
            Sku = new NamedObjectType("Sku", new ITypeProperty[]{new TypeProperty("name", UnionType.Create(new StringLiteralType("'Gateway'"), new StringLiteralType("'Edge'")), TypePropertyFlags.None), new TypeProperty("tier", new StringLiteralType("'Standard'"), TypePropertyFlags.None)}, null);
            DataBoxEdgeDeviceProperties = new NamedObjectType("DataBoxEdgeDeviceProperties", new ITypeProperty[]{new TypeProperty("dataBoxEdgeDeviceStatus", UnionType.Create(new StringLiteralType("'ReadyToSetup'"), new StringLiteralType("'Online'"), new StringLiteralType("'Offline'"), new StringLiteralType("'NeedsAttention'"), new StringLiteralType("'Disconnected'"), new StringLiteralType("'PartiallyDisconnected'")), TypePropertyFlags.None), new TypeProperty("serialNumber", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("modelDescription", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("deviceType", new StringLiteralType("'DataBoxEdgeDevice'"), TypePropertyFlags.ReadOnly), new TypeProperty("friendlyName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("culture", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("deviceModel", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("deviceSoftwareVersion", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("deviceLocalCapacity", LanguageConstants.Int, TypePropertyFlags.ReadOnly), new TypeProperty("timeZone", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("deviceHcsVersion", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("configuredRoleTypes", new TypedArrayType(UnionType.Create(new StringLiteralType("'IOT'"), new StringLiteralType("'ASA'"), new StringLiteralType("'Functions'"), new StringLiteralType("'Cognitive'"))), TypePropertyFlags.ReadOnly)}, null);
            BandwidthScheduleProperties = new NamedObjectType("BandwidthScheduleProperties", new ITypeProperty[]{new TypeProperty("start", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("stop", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("rateInMbps", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("days", new TypedArrayType(UnionType.Create(new StringLiteralType("'Sunday'"), new StringLiteralType("'Monday'"), new StringLiteralType("'Tuesday'"), new StringLiteralType("'Wednesday'"), new StringLiteralType("'Thursday'"), new StringLiteralType("'Friday'"), new StringLiteralType("'Saturday'"))), TypePropertyFlags.Required)}, null);
            OrderProperties = new NamedObjectType("OrderProperties", new ITypeProperty[]{new LazyTypeProperty("contactInformation", () => ContactDetails, TypePropertyFlags.Required), new LazyTypeProperty("shippingAddress", () => Address, TypePropertyFlags.Required), new LazyTypeProperty("currentStatus", () => OrderStatus, TypePropertyFlags.None), new LazyTypeProperty("orderHistory", () => new TypedArrayType(OrderStatus), TypePropertyFlags.ReadOnly), new TypeProperty("serialNumber", LanguageConstants.String, TypePropertyFlags.ReadOnly), new LazyTypeProperty("deliveryTrackingInfo", () => new TypedArrayType(TrackingInfo), TypePropertyFlags.ReadOnly), new LazyTypeProperty("returnTrackingInfo", () => new TypedArrayType(TrackingInfo), TypePropertyFlags.ReadOnly)}, null);
            ContactDetails = new NamedObjectType("ContactDetails", new ITypeProperty[]{new TypeProperty("contactPerson", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("companyName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("phone", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("emailList", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.Required)}, null);
            Address = new NamedObjectType("Address", new ITypeProperty[]{new TypeProperty("addressLine1", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("addressLine2", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("addressLine3", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("postalCode", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("city", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("state", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("country", LanguageConstants.String, TypePropertyFlags.Required)}, null);
            OrderStatus = new NamedObjectType("OrderStatus", new ITypeProperty[]{new TypeProperty("status", UnionType.Create(new StringLiteralType("'Untracked'"), new StringLiteralType("'AwaitingFulfilment'"), new StringLiteralType("'AwaitingPreparation'"), new StringLiteralType("'AwaitingShipment'"), new StringLiteralType("'Shipped'"), new StringLiteralType("'Arriving'"), new StringLiteralType("'Delivered'"), new StringLiteralType("'ReplacementRequested'"), new StringLiteralType("'LostDevice'"), new StringLiteralType("'Declined'"), new StringLiteralType("'ReturnInitiated'"), new StringLiteralType("'AwaitingReturnShipment'"), new StringLiteralType("'ShippedBack'"), new StringLiteralType("'CollectedAtMicrosoft'")), TypePropertyFlags.Required), new TypeProperty("updateDateTime", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("comments", LanguageConstants.String, TypePropertyFlags.None)}, null);
            TrackingInfo = new NamedObjectType("TrackingInfo", new ITypeProperty[]{new TypeProperty("serialNumber", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("carrierName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("trackingId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("trackingUrl", LanguageConstants.String, TypePropertyFlags.None)}, null);
            IoTRole = new NamedObjectType("IoTRole", new ITypeProperty[]{new LazyTypeProperty("properties", () => IoTRoleProperties, TypePropertyFlags.None), new TypeProperty("kind", new StringLiteralType("'IOT'"), TypePropertyFlags.Required), new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            IoTRoleProperties = new NamedObjectType("IoTRoleProperties", new ITypeProperty[]{new TypeProperty("hostPlatform", UnionType.Create(new StringLiteralType("'Windows'"), new StringLiteralType("'Linux'")), TypePropertyFlags.Required), new LazyTypeProperty("ioTDeviceDetails", () => IoTDeviceInfo, TypePropertyFlags.Required), new LazyTypeProperty("ioTEdgeDeviceDetails", () => IoTDeviceInfo, TypePropertyFlags.Required), new LazyTypeProperty("shareMappings", () => new TypedArrayType(MountPointMap), TypePropertyFlags.None), new TypeProperty("roleStatus", UnionType.Create(new StringLiteralType("'Enabled'"), new StringLiteralType("'Disabled'")), TypePropertyFlags.Required)}, null);
            IoTDeviceInfo = new NamedObjectType("IoTDeviceInfo", new ITypeProperty[]{new TypeProperty("deviceId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("ioTHostHub", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("authentication", () => Authentication, TypePropertyFlags.None)}, null);
            Authentication = new NamedObjectType("Authentication", new ITypeProperty[]{new LazyTypeProperty("symmetricKey", () => SymmetricKey, TypePropertyFlags.None)}, null);
            SymmetricKey = new NamedObjectType("SymmetricKey", new ITypeProperty[]{new LazyTypeProperty("connectionString", () => AsymmetricEncryptedSecret, TypePropertyFlags.None)}, null);
            AsymmetricEncryptedSecret = new NamedObjectType("AsymmetricEncryptedSecret", new ITypeProperty[]{new TypeProperty("value", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("encryptionCertThumbprint", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("encryptionAlgorithm", UnionType.Create(new StringLiteralType("'None'"), new StringLiteralType("'AES256'"), new StringLiteralType("'RSAES_PKCS1_v_1_5'")), TypePropertyFlags.Required)}, null);
            MountPointMap = new NamedObjectType("MountPointMap", new ITypeProperty[]{new TypeProperty("shareId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("roleId", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("mountPoint", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("roleType", UnionType.Create(new StringLiteralType("'IOT'"), new StringLiteralType("'ASA'"), new StringLiteralType("'Functions'"), new StringLiteralType("'Cognitive'")), TypePropertyFlags.ReadOnly)}, null);
            ShareProperties = new NamedObjectType("ShareProperties", new ITypeProperty[]{new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("shareStatus", UnionType.Create(new StringLiteralType("'Online'"), new StringLiteralType("'Offline'")), TypePropertyFlags.Required), new TypeProperty("monitoringStatus", UnionType.Create(new StringLiteralType("'Enabled'"), new StringLiteralType("'Disabled'")), TypePropertyFlags.Required), new LazyTypeProperty("azureContainerInfo", () => AzureContainerInfo, TypePropertyFlags.None), new TypeProperty("accessProtocol", UnionType.Create(new StringLiteralType("'SMB'"), new StringLiteralType("'NFS'")), TypePropertyFlags.Required), new LazyTypeProperty("userAccessRights", () => new TypedArrayType(UserAccessRight), TypePropertyFlags.None), new LazyTypeProperty("clientAccessRights", () => new TypedArrayType(ClientAccessRight), TypePropertyFlags.None), new LazyTypeProperty("refreshDetails", () => RefreshDetails, TypePropertyFlags.None), new LazyTypeProperty("shareMappings", () => new TypedArrayType(MountPointMap), TypePropertyFlags.ReadOnly), new TypeProperty("dataPolicy", UnionType.Create(new StringLiteralType("'Cloud'"), new StringLiteralType("'Local'")), TypePropertyFlags.None)}, null);
            AzureContainerInfo = new NamedObjectType("AzureContainerInfo", new ITypeProperty[]{new TypeProperty("storageAccountCredentialId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("containerName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("dataFormat", UnionType.Create(new StringLiteralType("'BlockBlob'"), new StringLiteralType("'PageBlob'"), new StringLiteralType("'AzureFile'")), TypePropertyFlags.Required)}, null);
            UserAccessRight = new NamedObjectType("UserAccessRight", new ITypeProperty[]{new TypeProperty("userId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("accessType", UnionType.Create(new StringLiteralType("'Change'"), new StringLiteralType("'Read'"), new StringLiteralType("'Custom'")), TypePropertyFlags.Required)}, null);
            ClientAccessRight = new NamedObjectType("ClientAccessRight", new ITypeProperty[]{new TypeProperty("client", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("accessPermission", UnionType.Create(new StringLiteralType("'NoAccess'"), new StringLiteralType("'ReadOnly'"), new StringLiteralType("'ReadWrite'")), TypePropertyFlags.Required)}, null);
            RefreshDetails = new NamedObjectType("RefreshDetails", new ITypeProperty[]{new TypeProperty("inProgressRefreshJobId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("lastCompletedRefreshJobTimeInUTC", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("errorManifestFile", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("lastJob", LanguageConstants.String, TypePropertyFlags.None)}, null);
            StorageAccountCredentialProperties = new NamedObjectType("StorageAccountCredentialProperties", new ITypeProperty[]{new TypeProperty("alias", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("userName", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("accountKey", () => AsymmetricEncryptedSecret, TypePropertyFlags.None), new TypeProperty("connectionString", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("sslStatus", UnionType.Create(new StringLiteralType("'Enabled'"), new StringLiteralType("'Disabled'")), TypePropertyFlags.Required), new TypeProperty("blobDomainName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("accountType", UnionType.Create(new StringLiteralType("'GeneralPurposeStorage'"), new StringLiteralType("'BlobStorage'")), TypePropertyFlags.Required)}, null);
            FileEventTrigger = new NamedObjectType("FileEventTrigger", new ITypeProperty[]{new LazyTypeProperty("properties", () => FileTriggerProperties, TypePropertyFlags.Required), new TypeProperty("kind", new StringLiteralType("'FileEvent'"), TypePropertyFlags.Required), new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            FileTriggerProperties = new NamedObjectType("FileTriggerProperties", new ITypeProperty[]{new LazyTypeProperty("sourceInfo", () => FileSourceInfo, TypePropertyFlags.Required), new LazyTypeProperty("sinkInfo", () => RoleSinkInfo, TypePropertyFlags.Required), new TypeProperty("customContextTag", LanguageConstants.String, TypePropertyFlags.None)}, null);
            FileSourceInfo = new NamedObjectType("FileSourceInfo", new ITypeProperty[]{new TypeProperty("shareId", LanguageConstants.String, TypePropertyFlags.Required)}, null);
            RoleSinkInfo = new NamedObjectType("RoleSinkInfo", new ITypeProperty[]{new TypeProperty("roleId", LanguageConstants.String, TypePropertyFlags.Required)}, null);
            PeriodicTimerEventTrigger = new NamedObjectType("PeriodicTimerEventTrigger", new ITypeProperty[]{new LazyTypeProperty("properties", () => PeriodicTimerProperties, TypePropertyFlags.Required), new TypeProperty("kind", new StringLiteralType("'PeriodicTimerEvent'"), TypePropertyFlags.Required), new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            PeriodicTimerProperties = new NamedObjectType("PeriodicTimerProperties", new ITypeProperty[]{new LazyTypeProperty("sourceInfo", () => PeriodicTimerSourceInfo, TypePropertyFlags.Required), new LazyTypeProperty("sinkInfo", () => RoleSinkInfo, TypePropertyFlags.Required), new TypeProperty("customContextTag", LanguageConstants.String, TypePropertyFlags.None)}, null);
            PeriodicTimerSourceInfo = new NamedObjectType("PeriodicTimerSourceInfo", new ITypeProperty[]{new TypeProperty("startTime", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("schedule", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("topic", LanguageConstants.String, TypePropertyFlags.None)}, null);
            UserProperties = new NamedObjectType("UserProperties", new ITypeProperty[]{new LazyTypeProperty("encryptedPassword", () => AsymmetricEncryptedSecret, TypePropertyFlags.None), new LazyTypeProperty("shareAccessRights", () => new TypedArrayType(ShareAccessRight), TypePropertyFlags.None)}, null);
            ShareAccessRight = new NamedObjectType("ShareAccessRight", new ITypeProperty[]{new TypeProperty("shareId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("accessType", UnionType.Create(new StringLiteralType("'Change'"), new StringLiteralType("'Read'"), new StringLiteralType("'Custom'")), TypePropertyFlags.Required)}, null);
            ResourceType_dataBoxEdgeDevices = new ResourceType("Microsoft.DataBoxEdge/dataBoxEdgeDevices", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.DataBoxEdge/dataBoxEdgeDevices'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("sku", () => Sku, TypePropertyFlags.None), new TypeProperty("etag", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("properties", () => DataBoxEdgeDeviceProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2019-03-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_dataBoxEdgeDevices);
            ResourceType_dataBoxEdgeDevices_bandwidthSchedules = new ResourceType("Microsoft.DataBoxEdge/dataBoxEdgeDevices/bandwidthSchedules", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.DataBoxEdge/dataBoxEdgeDevices/bandwidthSchedules'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new LazyTypeProperty("properties", () => BandwidthScheduleProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2019-03-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_dataBoxEdgeDevices_bandwidthSchedules);
            ResourceType_dataBoxEdgeDevices_orders = new ResourceType("Microsoft.DataBoxEdge/dataBoxEdgeDevices/orders", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.DataBoxEdge/dataBoxEdgeDevices/orders'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new LazyTypeProperty("properties", () => OrderProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2019-03-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_dataBoxEdgeDevices_orders);
            ResourceType_dataBoxEdgeDevices_roles = new ResourceType("Microsoft.DataBoxEdge/dataBoxEdgeDevices/roles", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.DataBoxEdge/dataBoxEdgeDevices/roles'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", new StringLiteralType("'2019-03-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_dataBoxEdgeDevices_roles);
            ResourceType_dataBoxEdgeDevices_shares = new ResourceType("Microsoft.DataBoxEdge/dataBoxEdgeDevices/shares", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.DataBoxEdge/dataBoxEdgeDevices/shares'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new LazyTypeProperty("properties", () => ShareProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2019-03-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_dataBoxEdgeDevices_shares);
            ResourceType_dataBoxEdgeDevices_storageAccountCredentials = new ResourceType("Microsoft.DataBoxEdge/dataBoxEdgeDevices/storageAccountCredentials", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.DataBoxEdge/dataBoxEdgeDevices/storageAccountCredentials'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new LazyTypeProperty("properties", () => StorageAccountCredentialProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2019-03-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_dataBoxEdgeDevices_storageAccountCredentials);
            ResourceType_dataBoxEdgeDevices_triggers = new ResourceType("Microsoft.DataBoxEdge/dataBoxEdgeDevices/triggers", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.DataBoxEdge/dataBoxEdgeDevices/triggers'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", new StringLiteralType("'2019-03-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_dataBoxEdgeDevices_triggers);
            ResourceType_dataBoxEdgeDevices_users = new ResourceType("Microsoft.DataBoxEdge/dataBoxEdgeDevices/users", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.DataBoxEdge/dataBoxEdgeDevices/users'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new LazyTypeProperty("properties", () => UserProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2019-03-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_dataBoxEdgeDevices_users);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_dataBoxEdgeDevices, () => InstanceLazy.Value.ResourceType_dataBoxEdgeDevices);
            registrar.RegisterType(ResourceTypeReference_dataBoxEdgeDevices_bandwidthSchedules, () => InstanceLazy.Value.ResourceType_dataBoxEdgeDevices_bandwidthSchedules);
            registrar.RegisterType(ResourceTypeReference_dataBoxEdgeDevices_orders, () => InstanceLazy.Value.ResourceType_dataBoxEdgeDevices_orders);
            registrar.RegisterType(ResourceTypeReference_dataBoxEdgeDevices_roles, () => InstanceLazy.Value.ResourceType_dataBoxEdgeDevices_roles);
            registrar.RegisterType(ResourceTypeReference_dataBoxEdgeDevices_shares, () => InstanceLazy.Value.ResourceType_dataBoxEdgeDevices_shares);
            registrar.RegisterType(ResourceTypeReference_dataBoxEdgeDevices_storageAccountCredentials, () => InstanceLazy.Value.ResourceType_dataBoxEdgeDevices_storageAccountCredentials);
            registrar.RegisterType(ResourceTypeReference_dataBoxEdgeDevices_triggers, () => InstanceLazy.Value.ResourceType_dataBoxEdgeDevices_triggers);
            registrar.RegisterType(ResourceTypeReference_dataBoxEdgeDevices_users, () => InstanceLazy.Value.ResourceType_dataBoxEdgeDevices_users);
        }
        private readonly ResourceType ResourceType_dataBoxEdgeDevices;
        private readonly ResourceType ResourceType_dataBoxEdgeDevices_bandwidthSchedules;
        private readonly ResourceType ResourceType_dataBoxEdgeDevices_orders;
        private readonly ResourceType ResourceType_dataBoxEdgeDevices_roles;
        private readonly ResourceType ResourceType_dataBoxEdgeDevices_shares;
        private readonly ResourceType ResourceType_dataBoxEdgeDevices_storageAccountCredentials;
        private readonly ResourceType ResourceType_dataBoxEdgeDevices_triggers;
        private readonly ResourceType ResourceType_dataBoxEdgeDevices_users;
        private readonly TypeSymbol Sku;
        private readonly TypeSymbol DataBoxEdgeDeviceProperties;
        private readonly TypeSymbol BandwidthScheduleProperties;
        private readonly TypeSymbol OrderProperties;
        private readonly TypeSymbol ContactDetails;
        private readonly TypeSymbol Address;
        private readonly TypeSymbol OrderStatus;
        private readonly TypeSymbol TrackingInfo;
        private readonly TypeSymbol IoTRole;
        private readonly TypeSymbol IoTRoleProperties;
        private readonly TypeSymbol IoTDeviceInfo;
        private readonly TypeSymbol Authentication;
        private readonly TypeSymbol SymmetricKey;
        private readonly TypeSymbol AsymmetricEncryptedSecret;
        private readonly TypeSymbol MountPointMap;
        private readonly TypeSymbol ShareProperties;
        private readonly TypeSymbol AzureContainerInfo;
        private readonly TypeSymbol UserAccessRight;
        private readonly TypeSymbol ClientAccessRight;
        private readonly TypeSymbol RefreshDetails;
        private readonly TypeSymbol StorageAccountCredentialProperties;
        private readonly TypeSymbol FileEventTrigger;
        private readonly TypeSymbol FileTriggerProperties;
        private readonly TypeSymbol FileSourceInfo;
        private readonly TypeSymbol RoleSinkInfo;
        private readonly TypeSymbol PeriodicTimerEventTrigger;
        private readonly TypeSymbol PeriodicTimerProperties;
        private readonly TypeSymbol PeriodicTimerSourceInfo;
        private readonly TypeSymbol UserProperties;
        private readonly TypeSymbol ShareAccessRight;
    }
}
