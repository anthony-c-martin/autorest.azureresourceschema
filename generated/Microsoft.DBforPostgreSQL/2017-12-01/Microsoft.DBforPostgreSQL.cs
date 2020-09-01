// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_DBforPostgreSQL_2017_12_01
    {
        private const string ProviderNamespace = "Microsoft.DBforPostgreSQL";
        private const string ApiVersion = "2017-12-01";
        private static readonly ResourceTypeReference ResourceTypeReference_servers = new ResourceTypeReference(ProviderNamespace, new[]{"servers"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_servers_firewallRules = new ResourceTypeReference(ProviderNamespace, new[]{"servers", "firewallRules"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_servers_virtualNetworkRules = new ResourceTypeReference(ProviderNamespace, new[]{"servers", "virtualNetworkRules"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_servers_databases = new ResourceTypeReference(ProviderNamespace, new[]{"servers", "databases"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_servers_configurations = new ResourceTypeReference(ProviderNamespace, new[]{"servers", "configurations"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_servers_Administrators = new ResourceTypeReference(ProviderNamespace, new[]{"servers", "Administrators"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_servers_securityAlertPolicies = new ResourceTypeReference(ProviderNamespace, new[]{"servers", "securityAlertPolicies"}, ApiVersion);
        private static Lazy<Microsoft_DBforPostgreSQL_2017_12_01> InstanceLazy = new Lazy<Microsoft_DBforPostgreSQL_2017_12_01>(() => new Microsoft_DBforPostgreSQL_2017_12_01());
        private Microsoft_DBforPostgreSQL_2017_12_01()
        {
            ResourceIdentity = new NamedObjectType("ResourceIdentity", new ITypeProperty[]{new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            Sku = new NamedObjectType("Sku", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tier", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("capacity", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("size", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("family", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ServerPropertiesForCreate = new NamedObjectType("ServerPropertiesForCreate", new ITypeProperty[]{new TypeProperty("version", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("sslEnforcement", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("minimalTlsVersion", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("infrastructureEncryption", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("publicNetworkAccess", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("storageProfile", () => StorageProfile, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            StorageProfile = new NamedObjectType("StorageProfile", new ITypeProperty[]{new TypeProperty("backupRetentionDays", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("geoRedundantBackup", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("storageMB", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("storageAutogrow", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ServerPropertiesForDefaultCreate = new NamedObjectType("ServerPropertiesForDefaultCreate", new ITypeProperty[]{new TypeProperty("administratorLogin", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("administratorLoginPassword", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("createMode", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ServerPropertiesForRestore = new NamedObjectType("ServerPropertiesForRestore", new ITypeProperty[]{new TypeProperty("sourceServerId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("restorePointInTime", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("createMode", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ServerPropertiesForGeoRestore = new NamedObjectType("ServerPropertiesForGeoRestore", new ITypeProperty[]{new TypeProperty("sourceServerId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("createMode", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ServerPropertiesForReplica = new NamedObjectType("ServerPropertiesForReplica", new ITypeProperty[]{new TypeProperty("sourceServerId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("createMode", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            FirewallRuleProperties = new NamedObjectType("FirewallRuleProperties", new ITypeProperty[]{new TypeProperty("startIpAddress", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("endIpAddress", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            VirtualNetworkRuleProperties = new NamedObjectType("VirtualNetworkRuleProperties", new ITypeProperty[]{new TypeProperty("virtualNetworkSubnetId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("ignoreMissingVnetServiceEndpoint", LanguageConstants.Bool, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            DatabaseProperties = new NamedObjectType("DatabaseProperties", new ITypeProperty[]{new TypeProperty("charset", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("collation", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ConfigurationProperties = new NamedObjectType("ConfigurationProperties", new ITypeProperty[]{new TypeProperty("value", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("source", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ServerAdministratorProperties = new NamedObjectType("ServerAdministratorProperties", new ITypeProperty[]{new TypeProperty("administratorType", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("login", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("sid", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tenantId", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            SecurityAlertPolicyProperties = new NamedObjectType("SecurityAlertPolicyProperties", new ITypeProperty[]{new TypeProperty("state", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("disabledAlerts", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("emailAddresses", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("emailAccountAdmins", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("storageEndpoint", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("storageAccountAccessKey", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("retentionDays", LanguageConstants.Int, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_servers = new ResourceType("Microsoft.DBforPostgreSQL/servers", new ITypeProperty[]{new LazyTypeProperty("identity", () => ResourceIdentity, TypePropertyFlags.None), new LazyTypeProperty("sku", () => Sku, TypePropertyFlags.None), new LazyTypeProperty("properties", () => ServerPropertiesForCreate, TypePropertyFlags.Required), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_servers);
            ResourceType_servers_firewallRules = new ResourceType("Microsoft.DBforPostgreSQL/servers/firewallRules", new ITypeProperty[]{new LazyTypeProperty("properties", () => FirewallRuleProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_servers_firewallRules);
            ResourceType_servers_virtualNetworkRules = new ResourceType("Microsoft.DBforPostgreSQL/servers/virtualNetworkRules", new ITypeProperty[]{new LazyTypeProperty("properties", () => VirtualNetworkRuleProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_servers_virtualNetworkRules);
            ResourceType_servers_databases = new ResourceType("Microsoft.DBforPostgreSQL/servers/databases", new ITypeProperty[]{new LazyTypeProperty("properties", () => DatabaseProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_servers_databases);
            ResourceType_servers_configurations = new ResourceType("Microsoft.DBforPostgreSQL/servers/configurations", new ITypeProperty[]{new LazyTypeProperty("properties", () => ConfigurationProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_servers_configurations);
            ResourceType_servers_Administrators = new ResourceType("Microsoft.DBforPostgreSQL/servers/Administrators", new ITypeProperty[]{new LazyTypeProperty("properties", () => ServerAdministratorProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_servers_Administrators);
            ResourceType_servers_securityAlertPolicies = new ResourceType("Microsoft.DBforPostgreSQL/servers/securityAlertPolicies", new ITypeProperty[]{new LazyTypeProperty("properties", () => SecurityAlertPolicyProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_servers_securityAlertPolicies);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_servers, () => InstanceLazy.Value.ResourceType_servers);
            registrar.RegisterType(ResourceTypeReference_servers_firewallRules, () => InstanceLazy.Value.ResourceType_servers_firewallRules);
            registrar.RegisterType(ResourceTypeReference_servers_virtualNetworkRules, () => InstanceLazy.Value.ResourceType_servers_virtualNetworkRules);
            registrar.RegisterType(ResourceTypeReference_servers_databases, () => InstanceLazy.Value.ResourceType_servers_databases);
            registrar.RegisterType(ResourceTypeReference_servers_configurations, () => InstanceLazy.Value.ResourceType_servers_configurations);
            registrar.RegisterType(ResourceTypeReference_servers_Administrators, () => InstanceLazy.Value.ResourceType_servers_Administrators);
            registrar.RegisterType(ResourceTypeReference_servers_securityAlertPolicies, () => InstanceLazy.Value.ResourceType_servers_securityAlertPolicies);
        }
        private readonly ResourceType ResourceType_servers;
        private readonly ResourceType ResourceType_servers_firewallRules;
        private readonly ResourceType ResourceType_servers_virtualNetworkRules;
        private readonly ResourceType ResourceType_servers_databases;
        private readonly ResourceType ResourceType_servers_configurations;
        private readonly ResourceType ResourceType_servers_Administrators;
        private readonly ResourceType ResourceType_servers_securityAlertPolicies;
        private readonly TypeSymbol ResourceIdentity;
        private readonly TypeSymbol Sku;
        private readonly TypeSymbol ServerPropertiesForCreate;
        private readonly TypeSymbol StorageProfile;
        private readonly TypeSymbol ServerPropertiesForDefaultCreate;
        private readonly TypeSymbol ServerPropertiesForRestore;
        private readonly TypeSymbol ServerPropertiesForGeoRestore;
        private readonly TypeSymbol ServerPropertiesForReplica;
        private readonly TypeSymbol FirewallRuleProperties;
        private readonly TypeSymbol VirtualNetworkRuleProperties;
        private readonly TypeSymbol DatabaseProperties;
        private readonly TypeSymbol ConfigurationProperties;
        private readonly TypeSymbol ServerAdministratorProperties;
        private readonly TypeSymbol SecurityAlertPolicyProperties;
    }
}
