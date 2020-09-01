// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_HanaOnAzure_2017_11_03_preview
    {
        private const string ProviderNamespace = "Microsoft.HanaOnAzure";
        private const string ApiVersion = "2017-11-03-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_hanaInstances = new ResourceTypeReference(ProviderNamespace, new[]{"hanaInstances"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_sapMonitors = new ResourceTypeReference(ProviderNamespace, new[]{"sapMonitors"}, ApiVersion);
        private static Lazy<Microsoft_HanaOnAzure_2017_11_03_preview> InstanceLazy = new Lazy<Microsoft_HanaOnAzure_2017_11_03_preview>(() => new Microsoft_HanaOnAzure_2017_11_03_preview());
        private Microsoft_HanaOnAzure_2017_11_03_preview()
        {
            HanaInstanceProperties = new NamedObjectType("HanaInstanceProperties", new ITypeProperty[]{new LazyTypeProperty("hardwareProfile", () => HardwareProfile, TypePropertyFlags.None), new LazyTypeProperty("storageProfile", () => StorageProfile, TypePropertyFlags.None), new LazyTypeProperty("osProfile", () => OSProfile, TypePropertyFlags.None), new LazyTypeProperty("networkProfile", () => NetworkProfile, TypePropertyFlags.None), new TypeProperty("partnerNodeId", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            HardwareProfile = new NamedObjectType("HardwareProfile", new ITypeProperty[]{}, null, TypePropertyFlags.None);
            StorageProfile = new NamedObjectType("StorageProfile", new ITypeProperty[]{new TypeProperty("osDisks", new TypedArrayType(new NamedObjectType("osDisks", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            Disk = new NamedObjectType("Disk", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("diskSizeGB", LanguageConstants.Int, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            OSProfile = new NamedObjectType("OSProfile", new ITypeProperty[]{new TypeProperty("computerName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("sshPublicKey", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            NetworkProfile = new NamedObjectType("NetworkProfile", new ITypeProperty[]{new TypeProperty("networkInterfaces", new TypedArrayType(new NamedObjectType("networkInterfaces", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            IpAddress = new NamedObjectType("IpAddress", new ITypeProperty[]{new TypeProperty("ipAddress", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            SapMonitorProperties = new NamedObjectType("SapMonitorProperties", new ITypeProperty[]{new TypeProperty("hanaSubnet", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("hanaHostname", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("hanaDbName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("hanaDbSqlPort", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("hanaDbUsername", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("hanaDbPassword", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("hanaDbPasswordKeyVaultUrl", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("hanaDbCredentialsMsiId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("keyVaultId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("logAnalyticsWorkspaceArmId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("enableCustomerAnalytics", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("logAnalyticsWorkspaceId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("logAnalyticsWorkspaceSharedKey", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_hanaInstances = new ResourceType("Microsoft.HanaOnAzure/hanaInstances", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("properties", () => HanaInstanceProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_hanaInstances);
            ResourceType_sapMonitors = new ResourceType("Microsoft.HanaOnAzure/sapMonitors", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("properties", () => SapMonitorProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_sapMonitors);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_hanaInstances, () => InstanceLazy.Value.ResourceType_hanaInstances);
            registrar.RegisterType(ResourceTypeReference_sapMonitors, () => InstanceLazy.Value.ResourceType_sapMonitors);
        }
        private readonly ResourceType ResourceType_hanaInstances;
        private readonly ResourceType ResourceType_sapMonitors;
        private readonly TypeSymbol HanaInstanceProperties;
        private readonly TypeSymbol HardwareProfile;
        private readonly TypeSymbol StorageProfile;
        private readonly TypeSymbol Disk;
        private readonly TypeSymbol OSProfile;
        private readonly TypeSymbol NetworkProfile;
        private readonly TypeSymbol IpAddress;
        private readonly TypeSymbol SapMonitorProperties;
    }
}
