// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_CognitiveServices_2017_04_18
    {
        private const string ProviderNamespace = "Microsoft.CognitiveServices";
        private const string ApiVersion = "2017-04-18";
        private static readonly ResourceTypeReference ResourceTypeReference_accounts = new ResourceTypeReference(ProviderNamespace, new[]{"accounts"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_accounts_privateEndpointConnections = new ResourceTypeReference(ProviderNamespace, new[]{"accounts", "privateEndpointConnections"}, ApiVersion);
        private static Lazy<Microsoft_CognitiveServices_2017_04_18> InstanceLazy = new Lazy<Microsoft_CognitiveServices_2017_04_18>(() => new Microsoft_CognitiveServices_2017_04_18());
        private Microsoft_CognitiveServices_2017_04_18()
        {
            CognitiveServicesAccountProperties = new NamedObjectType("CognitiveServicesAccountProperties", new ITypeProperty[]{new TypeProperty("provisioningState", UnionType.Create(new StringLiteralType("'Creating'"), new StringLiteralType("'ResolvingDNS'"), new StringLiteralType("'Moving'"), new StringLiteralType("'Deleting'"), new StringLiteralType("'Succeeded'"), new StringLiteralType("'Failed'")), TypePropertyFlags.ReadOnly), new TypeProperty("endpoint", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("internalId", LanguageConstants.String, TypePropertyFlags.ReadOnly), new LazyTypeProperty("capabilities", () => new TypedArrayType(SkuCapability), TypePropertyFlags.ReadOnly), new TypeProperty("customSubDomainName", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("networkAcls", () => NetworkRuleSet, TypePropertyFlags.None), new LazyTypeProperty("encryption", () => Encryption, TypePropertyFlags.None), new LazyTypeProperty("userOwnedStorage", () => new TypedArrayType(UserOwnedStorage), TypePropertyFlags.None), new LazyTypeProperty("privateEndpointConnections", () => new TypedArrayType(PrivateEndpointConnection), TypePropertyFlags.None), new TypeProperty("publicNetworkAccess", UnionType.Create(new StringLiteralType("'Enabled'"), new StringLiteralType("'Disabled'")), TypePropertyFlags.None), new LazyTypeProperty("apiProperties", () => CognitiveServicesAccountApiProperties, TypePropertyFlags.None)}, null);
            SkuCapability = new NamedObjectType("SkuCapability", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("value", LanguageConstants.String, TypePropertyFlags.None)}, null);
            NetworkRuleSet = new NamedObjectType("NetworkRuleSet", new ITypeProperty[]{new TypeProperty("defaultAction", UnionType.Create(new StringLiteralType("'Allow'"), new StringLiteralType("'Deny'")), TypePropertyFlags.None), new LazyTypeProperty("ipRules", () => new TypedArrayType(IpRule), TypePropertyFlags.None), new LazyTypeProperty("virtualNetworkRules", () => new TypedArrayType(VirtualNetworkRule), TypePropertyFlags.None)}, null);
            IpRule = new NamedObjectType("IpRule", new ITypeProperty[]{new TypeProperty("value", LanguageConstants.String, TypePropertyFlags.Required)}, null);
            VirtualNetworkRule = new NamedObjectType("VirtualNetworkRule", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("state", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("ignoreMissingVnetServiceEndpoint", LanguageConstants.Bool, TypePropertyFlags.None)}, null);
            Encryption = new NamedObjectType("Encryption", new ITypeProperty[]{new LazyTypeProperty("keyVaultProperties", () => KeyVaultProperties, TypePropertyFlags.None), new TypeProperty("keySource", UnionType.Create(new StringLiteralType("'Microsoft.CognitiveServices'"), new StringLiteralType("'Microsoft.KeyVault'")), TypePropertyFlags.None)}, null);
            KeyVaultProperties = new NamedObjectType("KeyVaultProperties", new ITypeProperty[]{new TypeProperty("keyName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("keyVersion", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("keyVaultUri", LanguageConstants.String, TypePropertyFlags.None)}, null);
            UserOwnedStorage = new NamedObjectType("UserOwnedStorage", new ITypeProperty[]{new TypeProperty("resourceId", LanguageConstants.String, TypePropertyFlags.None)}, null);
            PrivateEndpointConnection = new NamedObjectType("PrivateEndpointConnection", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.ReadOnly), new LazyTypeProperty("properties", () => PrivateEndpointConnectionProperties, TypePropertyFlags.None)}, null);
            PrivateEndpointConnectionProperties = new NamedObjectType("PrivateEndpointConnectionProperties", new ITypeProperty[]{new LazyTypeProperty("privateEndpoint", () => PrivateEndpoint, TypePropertyFlags.None), new LazyTypeProperty("privateLinkServiceConnectionState", () => PrivateLinkServiceConnectionState, TypePropertyFlags.Required), new TypeProperty("groupIds", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None)}, null);
            PrivateEndpoint = new NamedObjectType("PrivateEndpoint", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            PrivateLinkServiceConnectionState = new NamedObjectType("PrivateLinkServiceConnectionState", new ITypeProperty[]{new TypeProperty("status", UnionType.Create(new StringLiteralType("'Pending'"), new StringLiteralType("'Approved'"), new StringLiteralType("'Rejected'"), new StringLiteralType("'Disconnected'")), TypePropertyFlags.None), new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("actionRequired", LanguageConstants.String, TypePropertyFlags.None)}, null);
            CognitiveServicesAccountApiProperties = new NamedObjectType("CognitiveServicesAccountApiProperties", new ITypeProperty[]{new TypeProperty("qnaRuntimeEndpoint", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("statisticsEnabled", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("eventHubConnectionString", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("storageAccountConnectionString", LanguageConstants.String, TypePropertyFlags.None)}, null);
            Sku = new NamedObjectType("Sku", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tier", UnionType.Create(new StringLiteralType("'Free'"), new StringLiteralType("'Standard'"), new StringLiteralType("'Premium'")), TypePropertyFlags.ReadOnly)}, null);
            Identity = new NamedObjectType("Identity", new ITypeProperty[]{new TypeProperty("type", UnionType.Create(new StringLiteralType("'None'"), new StringLiteralType("'SystemAssigned'"), new StringLiteralType("'UserAssigned'")), TypePropertyFlags.None), new TypeProperty("tenantId", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("principalId", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("userAssignedIdentities", new NamedObjectType("userAssignedIdentities", new ITypeProperty[]{}, new LazyTypeProperty("additionalProperties", () => UserAssignedIdentity, TypePropertyFlags.None)), TypePropertyFlags.None)}, null);
            UserAssignedIdentity = new NamedObjectType("UserAssignedIdentity", new ITypeProperty[]{new TypeProperty("principalId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("clientId", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ResourceType_accounts = new ResourceType("Microsoft.CognitiveServices/accounts", new ITypeProperty[]{new TypeProperty("etag", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new LazyTypeProperty("properties", () => CognitiveServicesAccountProperties, TypePropertyFlags.Required), new LazyTypeProperty("sku", () => Sku, TypePropertyFlags.None), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("type", new StringLiteralType("'Microsoft.CognitiveServices/accounts'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new LazyTypeProperty("identity", () => Identity, TypePropertyFlags.None), new TypeProperty("apiVersion", new StringLiteralType("'2017-04-18'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_accounts);
            ResourceType_accounts_privateEndpointConnections = new ResourceType("Microsoft.CognitiveServices/accounts/privateEndpointConnections", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.CognitiveServices/accounts/privateEndpointConnections'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new LazyTypeProperty("properties", () => PrivateEndpointConnectionProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2017-04-18'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_accounts_privateEndpointConnections);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_accounts, () => InstanceLazy.Value.ResourceType_accounts);
            registrar.RegisterType(ResourceTypeReference_accounts_privateEndpointConnections, () => InstanceLazy.Value.ResourceType_accounts_privateEndpointConnections);
        }
        private readonly ResourceType ResourceType_accounts;
        private readonly ResourceType ResourceType_accounts_privateEndpointConnections;
        private readonly TypeSymbol CognitiveServicesAccountProperties;
        private readonly TypeSymbol SkuCapability;
        private readonly TypeSymbol NetworkRuleSet;
        private readonly TypeSymbol IpRule;
        private readonly TypeSymbol VirtualNetworkRule;
        private readonly TypeSymbol Encryption;
        private readonly TypeSymbol KeyVaultProperties;
        private readonly TypeSymbol UserOwnedStorage;
        private readonly TypeSymbol PrivateEndpointConnection;
        private readonly TypeSymbol PrivateEndpointConnectionProperties;
        private readonly TypeSymbol PrivateEndpoint;
        private readonly TypeSymbol PrivateLinkServiceConnectionState;
        private readonly TypeSymbol CognitiveServicesAccountApiProperties;
        private readonly TypeSymbol Sku;
        private readonly TypeSymbol Identity;
        private readonly TypeSymbol UserAssignedIdentity;
    }
}
