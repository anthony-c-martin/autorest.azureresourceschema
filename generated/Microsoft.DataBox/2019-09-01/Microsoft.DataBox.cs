// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_DataBox_2019_09_01
    {
        private const string ProviderNamespace = "Microsoft.DataBox";
        private const string ApiVersion = "2019-09-01";
        private static readonly ResourceTypeReference ResourceTypeReference_jobs = new ResourceTypeReference(ProviderNamespace, new[]{"jobs"}, ApiVersion);
        private static Lazy<Microsoft_DataBox_2019_09_01> InstanceLazy = new Lazy<Microsoft_DataBox_2019_09_01>(() => new Microsoft_DataBox_2019_09_01());
        private Microsoft_DataBox_2019_09_01()
        {
            Sku = new NamedObjectType("Sku", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("displayName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("family", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            JobProperties = new NamedObjectType("JobProperties", new ITypeProperty[]{new LazyTypeProperty("details", () => JobDetails, TypePropertyFlags.None), new TypeProperty("deliveryType", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("deliveryInfo", () => JobDeliveryInfo, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            JobDetails = new NamedObjectType("JobDetails", new ITypeProperty[]{new TypeProperty("expectedDataSizeInTerabytes", LanguageConstants.Int, TypePropertyFlags.None), new LazyTypeProperty("contactDetails", () => ContactDetails, TypePropertyFlags.Required), new LazyTypeProperty("shippingAddress", () => ShippingAddress, TypePropertyFlags.Required), new TypeProperty("destinationAccountDetails", new TypedArrayType(new NamedObjectType("destinationAccountDetails", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.Required), new LazyTypeProperty("preferences", () => Preferences, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ContactDetails = new NamedObjectType("ContactDetails", new ITypeProperty[]{new TypeProperty("contactName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("phone", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("phoneExtension", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("mobile", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("emailList", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.Required), new TypeProperty("notificationPreference", new TypedArrayType(new NamedObjectType("notificationPreference", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            NotificationPreference = new NamedObjectType("NotificationPreference", new ITypeProperty[]{new TypeProperty("stageName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("sendNotification", LanguageConstants.Bool, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ShippingAddress = new NamedObjectType("ShippingAddress", new ITypeProperty[]{new TypeProperty("streetAddress1", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("streetAddress2", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("streetAddress3", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("city", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("stateOrProvince", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("country", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("postalCode", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("zipExtendedCode", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("companyName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("addressType", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            DestinationAccountDetails = new NamedObjectType("DestinationAccountDetails", new ITypeProperty[]{new TypeProperty("accountId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("sharePassword", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            DestinationManagedDiskDetails = new NamedObjectType("DestinationManagedDiskDetails", new ITypeProperty[]{new TypeProperty("resourceGroupId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("stagingStorageAccountId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("dataDestinationType", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            DestinationStorageAccountDetails = new NamedObjectType("DestinationStorageAccountDetails", new ITypeProperty[]{new TypeProperty("storageAccountId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("dataDestinationType", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            Preferences = new NamedObjectType("Preferences", new ITypeProperty[]{new TypeProperty("preferredDataCenterRegion", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new LazyTypeProperty("transportPreferences", () => TransportPreferences, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            TransportPreferences = new NamedObjectType("TransportPreferences", new ITypeProperty[]{new TypeProperty("preferredShipmentType", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            DataBoxDiskJobDetails = new NamedObjectType("DataBoxDiskJobDetails", new ITypeProperty[]{new TypeProperty("preferredDisks", new NamedObjectType("preferredDisks", new ITypeProperty[]{}, LanguageConstants.Int, TypePropertyFlags.None), TypePropertyFlags.None), new TypeProperty("passkey", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("jobDetailsType", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            DataBoxHeavyJobDetails = new NamedObjectType("DataBoxHeavyJobDetails", new ITypeProperty[]{new TypeProperty("devicePassword", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("jobDetailsType", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            DataBoxJobDetails = new NamedObjectType("DataBoxJobDetails", new ITypeProperty[]{new TypeProperty("devicePassword", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("jobDetailsType", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            JobDeliveryInfo = new NamedObjectType("JobDeliveryInfo", new ITypeProperty[]{new TypeProperty("scheduledDateTime", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_jobs = new ResourceType("Microsoft.DataBox/jobs", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new LazyTypeProperty("sku", () => Sku, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => JobProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_jobs);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_jobs, () => InstanceLazy.Value.ResourceType_jobs);
        }
        private readonly ResourceType ResourceType_jobs;
        private readonly TypeSymbol Sku;
        private readonly TypeSymbol JobProperties;
        private readonly TypeSymbol JobDetails;
        private readonly TypeSymbol ContactDetails;
        private readonly TypeSymbol NotificationPreference;
        private readonly TypeSymbol ShippingAddress;
        private readonly TypeSymbol DestinationAccountDetails;
        private readonly TypeSymbol DestinationManagedDiskDetails;
        private readonly TypeSymbol DestinationStorageAccountDetails;
        private readonly TypeSymbol Preferences;
        private readonly TypeSymbol TransportPreferences;
        private readonly TypeSymbol DataBoxDiskJobDetails;
        private readonly TypeSymbol DataBoxHeavyJobDetails;
        private readonly TypeSymbol DataBoxJobDetails;
        private readonly TypeSymbol JobDeliveryInfo;
    }
}
