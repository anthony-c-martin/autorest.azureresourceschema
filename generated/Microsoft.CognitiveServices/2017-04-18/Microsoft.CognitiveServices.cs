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
            CognitiveServicesAccountProperties = new NamedObjectType("CognitiveServicesAccountProperties", new ITypeProperty[]{new TypeProperty("customSubDomainName", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("networkAcls", () => NetworkRuleSet, TypePropertyFlags.None), new LazyTypeProperty("encryption", () => Encryption, TypePropertyFlags.None), new TypeProperty("userOwnedStorage", new TypedArrayType(new NamedObjectType("userOwnedStorage", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("privateEndpointConnections", new TypedArrayType(new NamedObjectType("privateEndpointConnections", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("publicNetworkAccess", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("apiProperties", () => CognitiveServicesAccountApiProperties, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            NetworkRuleSet = new NamedObjectType("NetworkRuleSet", new ITypeProperty[]{new TypeProperty("defaultAction", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("ipRules", new TypedArrayType(new NamedObjectType("ipRules", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("virtualNetworkRules", new TypedArrayType(new NamedObjectType("virtualNetworkRules", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            IpRule = new NamedObjectType("IpRule", new ITypeProperty[]{new TypeProperty("value", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            VirtualNetworkRule = new NamedObjectType("VirtualNetworkRule", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("state", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("ignoreMissingVnetServiceEndpoint", LanguageConstants.Bool, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            Encryption = new NamedObjectType("Encryption", new ITypeProperty[]{new LazyTypeProperty("keyVaultProperties", () => KeyVaultProperties, TypePropertyFlags.None), new TypeProperty("keySource", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            KeyVaultProperties = new NamedObjectType("KeyVaultProperties", new ITypeProperty[]{new TypeProperty("keyName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("keyVersion", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("keyVaultUri", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            UserOwnedStorage = new NamedObjectType("UserOwnedStorage", new ITypeProperty[]{new TypeProperty("resourceId", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            PrivateEndpointConnection = new NamedObjectType("PrivateEndpointConnection", new ITypeProperty[]{new LazyTypeProperty("properties", () => PrivateEndpointConnectionProperties, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            PrivateEndpointConnectionProperties = new NamedObjectType("PrivateEndpointConnectionProperties", new ITypeProperty[]{new LazyTypeProperty("privateEndpoint", () => PrivateEndpoint, TypePropertyFlags.None), new LazyTypeProperty("privateLinkServiceConnectionState", () => PrivateLinkServiceConnectionState, TypePropertyFlags.Required), new TypeProperty("groupIds", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            PrivateEndpoint = new NamedObjectType("PrivateEndpoint", new ITypeProperty[]{}, null, TypePropertyFlags.None);
            PrivateLinkServiceConnectionState = new NamedObjectType("PrivateLinkServiceConnectionState", new ITypeProperty[]{new TypeProperty("status", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("actionRequired", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            CognitiveServicesAccountApiProperties = new NamedObjectType("CognitiveServicesAccountApiProperties", new ITypeProperty[]{new TypeProperty("qnaRuntimeEndpoint", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("statisticsEnabled", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("eventHubConnectionString", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("storageAccountConnectionString", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            Sku = new NamedObjectType("Sku", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            Identity = new NamedObjectType("Identity", new ITypeProperty[]{new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("userAssignedIdentities", new NamedObjectType("userAssignedIdentities", new ITypeProperty[]{}, new NamedObjectType("additionalProperties", new ITypeProperty[]{}, null, TypePropertyFlags.None), TypePropertyFlags.None), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            UserAssignedIdentity = new NamedObjectType("UserAssignedIdentity", new ITypeProperty[]{new TypeProperty("principalId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("clientId", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_accounts = new ResourceType("Microsoft.CognitiveServices/accounts", new ITypeProperty[]{new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("properties", () => CognitiveServicesAccountProperties, TypePropertyFlags.Required), new LazyTypeProperty("sku", () => Sku, TypePropertyFlags.None), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new LazyTypeProperty("identity", () => Identity, TypePropertyFlags.None), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_accounts);
            ResourceType_accounts_privateEndpointConnections = new ResourceType("Microsoft.CognitiveServices/accounts/privateEndpointConnections", new ITypeProperty[]{new LazyTypeProperty("properties", () => PrivateEndpointConnectionProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_accounts_privateEndpointConnections);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_accounts, () => InstanceLazy.Value.ResourceType_accounts);
            registrar.RegisterType(ResourceTypeReference_accounts_privateEndpointConnections, () => InstanceLazy.Value.ResourceType_accounts_privateEndpointConnections);
        }
        private readonly ResourceType ResourceType_accounts;
        private readonly ResourceType ResourceType_accounts_privateEndpointConnections;
        private readonly TypeSymbol CognitiveServicesAccountProperties;
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
