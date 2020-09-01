// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_Sql_2015_05_01_preview
    {
        private const string ProviderNamespace = "Microsoft.Sql";
        private const string ApiVersion = "2015-05-01-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_servers_encryptionProtector = new ResourceTypeReference(ProviderNamespace, new[]{"servers", "encryptionProtector"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_servers_failoverGroups = new ResourceTypeReference(ProviderNamespace, new[]{"servers", "failoverGroups"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_servers_keys = new ResourceTypeReference(ProviderNamespace, new[]{"servers", "keys"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_servers_syncAgents = new ResourceTypeReference(ProviderNamespace, new[]{"servers", "syncAgents"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_servers_virtualNetworkRules = new ResourceTypeReference(ProviderNamespace, new[]{"servers", "virtualNetworkRules"}, ApiVersion);
        private static Lazy<Microsoft_Sql_2015_05_01_preview> InstanceLazy = new Lazy<Microsoft_Sql_2015_05_01_preview>(() => new Microsoft_Sql_2015_05_01_preview());
        private Microsoft_Sql_2015_05_01_preview()
        {
            EncryptionProtectorProperties = new NamedObjectType("EncryptionProtectorProperties", new ITypeProperty[]{new TypeProperty("serverKeyName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("serverKeyType", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            FailoverGroupProperties = new NamedObjectType("FailoverGroupProperties", new ITypeProperty[]{new LazyTypeProperty("readWriteEndpoint", () => FailoverGroupReadWriteEndpoint, TypePropertyFlags.Required), new LazyTypeProperty("readOnlyEndpoint", () => FailoverGroupReadOnlyEndpoint, TypePropertyFlags.None), new TypeProperty("partnerServers", LanguageConstants.Array, TypePropertyFlags.Required), new TypeProperty("databases", LanguageConstants.Array, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            FailoverGroupReadWriteEndpoint = new NamedObjectType("FailoverGroupReadWriteEndpoint", new ITypeProperty[]{new TypeProperty("failoverPolicy", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("failoverWithDataLossGracePeriodMinutes", LanguageConstants.Int, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            FailoverGroupReadOnlyEndpoint = new NamedObjectType("FailoverGroupReadOnlyEndpoint", new ITypeProperty[]{new TypeProperty("failoverPolicy", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            PartnerInfo = new NamedObjectType("PartnerInfo", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ServerKeyProperties = new NamedObjectType("ServerKeyProperties", new ITypeProperty[]{new TypeProperty("serverKeyType", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("uri", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("thumbprint", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("creationDate", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            SyncAgentProperties = new NamedObjectType("SyncAgentProperties", new ITypeProperty[]{new TypeProperty("syncDatabaseId", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            VirtualNetworkRuleProperties = new NamedObjectType("VirtualNetworkRuleProperties", new ITypeProperty[]{new TypeProperty("virtualNetworkSubnetId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("ignoreMissingVnetServiceEndpoint", LanguageConstants.Bool, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_servers_encryptionProtector = new ResourceType("Microsoft.Sql/servers/encryptionProtector", new ITypeProperty[]{new LazyTypeProperty("properties", () => EncryptionProtectorProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_servers_encryptionProtector);
            ResourceType_servers_failoverGroups = new ResourceType("Microsoft.Sql/servers/failoverGroups", new ITypeProperty[]{new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("properties", () => FailoverGroupProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_servers_failoverGroups);
            ResourceType_servers_keys = new ResourceType("Microsoft.Sql/servers/keys", new ITypeProperty[]{new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("properties", () => ServerKeyProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_servers_keys);
            ResourceType_servers_syncAgents = new ResourceType("Microsoft.Sql/servers/syncAgents", new ITypeProperty[]{new LazyTypeProperty("properties", () => SyncAgentProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_servers_syncAgents);
            ResourceType_servers_virtualNetworkRules = new ResourceType("Microsoft.Sql/servers/virtualNetworkRules", new ITypeProperty[]{new LazyTypeProperty("properties", () => VirtualNetworkRuleProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_servers_virtualNetworkRules);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_servers_encryptionProtector, () => InstanceLazy.Value.ResourceType_servers_encryptionProtector);
            registrar.RegisterType(ResourceTypeReference_servers_failoverGroups, () => InstanceLazy.Value.ResourceType_servers_failoverGroups);
            registrar.RegisterType(ResourceTypeReference_servers_keys, () => InstanceLazy.Value.ResourceType_servers_keys);
            registrar.RegisterType(ResourceTypeReference_servers_syncAgents, () => InstanceLazy.Value.ResourceType_servers_syncAgents);
            registrar.RegisterType(ResourceTypeReference_servers_virtualNetworkRules, () => InstanceLazy.Value.ResourceType_servers_virtualNetworkRules);
        }
        private readonly ResourceType ResourceType_servers_encryptionProtector;
        private readonly ResourceType ResourceType_servers_failoverGroups;
        private readonly ResourceType ResourceType_servers_keys;
        private readonly ResourceType ResourceType_servers_syncAgents;
        private readonly ResourceType ResourceType_servers_virtualNetworkRules;
        private readonly TypeSymbol EncryptionProtectorProperties;
        private readonly TypeSymbol FailoverGroupProperties;
        private readonly TypeSymbol FailoverGroupReadWriteEndpoint;
        private readonly TypeSymbol FailoverGroupReadOnlyEndpoint;
        private readonly TypeSymbol PartnerInfo;
        private readonly TypeSymbol ServerKeyProperties;
        private readonly TypeSymbol SyncAgentProperties;
        private readonly TypeSymbol VirtualNetworkRuleProperties;
    }
}
