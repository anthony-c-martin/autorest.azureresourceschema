// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_Peering_2020_04_01
    {
        private const string ProviderNamespace = "Microsoft.Peering";
        private const string ApiVersion = "2020-04-01";
        private static readonly ResourceTypeReference ResourceTypeReference_peerings = new ResourceTypeReference(ProviderNamespace, new[]{"peerings"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_peeringServices = new ResourceTypeReference(ProviderNamespace, new[]{"peeringServices"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_peerings_registeredAsns = new ResourceTypeReference(ProviderNamespace, new[]{"peerings", "registeredAsns"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_peerings_registeredPrefixes = new ResourceTypeReference(ProviderNamespace, new[]{"peerings", "registeredPrefixes"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_peeringServices_prefixes = new ResourceTypeReference(ProviderNamespace, new[]{"peeringServices", "prefixes"}, ApiVersion);
        private static Lazy<Microsoft_Peering_2020_04_01> InstanceLazy = new Lazy<Microsoft_Peering_2020_04_01>(() => new Microsoft_Peering_2020_04_01());
        private Microsoft_Peering_2020_04_01()
        {
            PeerAsnProperties = new NamedObjectType("PeerAsnProperties", new ITypeProperty[]{new TypeProperty("peerAsn", LanguageConstants.Int, TypePropertyFlags.None), new LazyTypeProperty("peerContactDetail", () => new TypedArrayType(ContactDetail), TypePropertyFlags.None), new TypeProperty("peerName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("validationState", UnionType.Create(new StringLiteralType("'None'"), new StringLiteralType("'Pending'"), new StringLiteralType("'Approved'"), new StringLiteralType("'Failed'")), TypePropertyFlags.None), new TypeProperty("errorMessage", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            ContactDetail = new NamedObjectType("ContactDetail", new ITypeProperty[]{new TypeProperty("role", UnionType.Create(new StringLiteralType("'Noc'"), new StringLiteralType("'Policy'"), new StringLiteralType("'Technical'"), new StringLiteralType("'Service'"), new StringLiteralType("'Escalation'"), new StringLiteralType("'Other'")), TypePropertyFlags.None), new TypeProperty("email", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("phone", LanguageConstants.String, TypePropertyFlags.None)}, null);
            PeeringRegisteredAsnProperties = new NamedObjectType("PeeringRegisteredAsnProperties", new ITypeProperty[]{new TypeProperty("asn", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("peeringServicePrefixKey", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("provisioningState", UnionType.Create(new StringLiteralType("'Succeeded'"), new StringLiteralType("'Updating'"), new StringLiteralType("'Deleting'"), new StringLiteralType("'Failed'")), TypePropertyFlags.ReadOnly)}, null);
            PeeringRegisteredPrefixProperties = new NamedObjectType("PeeringRegisteredPrefixProperties", new ITypeProperty[]{new TypeProperty("prefix", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("prefixValidationState", UnionType.Create(new StringLiteralType("'None'"), new StringLiteralType("'Invalid'"), new StringLiteralType("'Verified'"), new StringLiteralType("'Failed'"), new StringLiteralType("'Pending'"), new StringLiteralType("'Warning'"), new StringLiteralType("'Unknown'")), TypePropertyFlags.ReadOnly), new TypeProperty("peeringServicePrefixKey", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("errorMessage", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("provisioningState", UnionType.Create(new StringLiteralType("'Succeeded'"), new StringLiteralType("'Updating'"), new StringLiteralType("'Deleting'"), new StringLiteralType("'Failed'")), TypePropertyFlags.ReadOnly)}, null);
            PeeringSku = new NamedObjectType("PeeringSku", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tier", UnionType.Create(new StringLiteralType("'Basic'"), new StringLiteralType("'Premium'")), TypePropertyFlags.None), new TypeProperty("family", UnionType.Create(new StringLiteralType("'Direct'"), new StringLiteralType("'Exchange'")), TypePropertyFlags.None), new TypeProperty("size", UnionType.Create(new StringLiteralType("'Free'"), new StringLiteralType("'Metered'"), new StringLiteralType("'Unlimited'")), TypePropertyFlags.None)}, null);
            PeeringProperties = new NamedObjectType("PeeringProperties", new ITypeProperty[]{new LazyTypeProperty("direct", () => PeeringPropertiesDirect, TypePropertyFlags.None), new LazyTypeProperty("exchange", () => PeeringPropertiesExchange, TypePropertyFlags.None), new TypeProperty("peeringLocation", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("provisioningState", UnionType.Create(new StringLiteralType("'Succeeded'"), new StringLiteralType("'Updating'"), new StringLiteralType("'Deleting'"), new StringLiteralType("'Failed'")), TypePropertyFlags.ReadOnly)}, null);
            PeeringPropertiesDirect = new NamedObjectType("PeeringPropertiesDirect", new ITypeProperty[]{new LazyTypeProperty("connections", () => new TypedArrayType(DirectConnection), TypePropertyFlags.None), new TypeProperty("useForPeeringService", LanguageConstants.Bool, TypePropertyFlags.ReadOnly), new LazyTypeProperty("peerAsn", () => SubResource, TypePropertyFlags.None), new TypeProperty("directPeeringType", UnionType.Create(new StringLiteralType("'Edge'"), new StringLiteralType("'Transit'"), new StringLiteralType("'Cdn'"), new StringLiteralType("'Internal'"), new StringLiteralType("'Ix'"), new StringLiteralType("'IxRs'")), TypePropertyFlags.None)}, null);
            DirectConnection = new NamedObjectType("DirectConnection", new ITypeProperty[]{new TypeProperty("bandwidthInMbps", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("provisionedBandwidthInMbps", LanguageConstants.Int, TypePropertyFlags.ReadOnly), new TypeProperty("sessionAddressProvider", UnionType.Create(new StringLiteralType("'Microsoft'"), new StringLiteralType("'Peer'")), TypePropertyFlags.None), new TypeProperty("useForPeeringService", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("peeringDBFacilityId", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("connectionState", UnionType.Create(new StringLiteralType("'None'"), new StringLiteralType("'PendingApproval'"), new StringLiteralType("'Approved'"), new StringLiteralType("'ProvisioningStarted'"), new StringLiteralType("'ProvisioningFailed'"), new StringLiteralType("'ProvisioningCompleted'"), new StringLiteralType("'Validating'"), new StringLiteralType("'Active'")), TypePropertyFlags.ReadOnly), new LazyTypeProperty("bgpSession", () => BgpSession, TypePropertyFlags.None), new TypeProperty("connectionIdentifier", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("errorMessage", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            BgpSession = new NamedObjectType("BgpSession", new ITypeProperty[]{new TypeProperty("sessionPrefixV4", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("sessionPrefixV6", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("microsoftSessionIPv4Address", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("microsoftSessionIPv6Address", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("peerSessionIPv4Address", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("peerSessionIPv6Address", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("sessionStateV4", UnionType.Create(new StringLiteralType("'None'"), new StringLiteralType("'Idle'"), new StringLiteralType("'Connect'"), new StringLiteralType("'Active'"), new StringLiteralType("'OpenSent'"), new StringLiteralType("'OpenConfirm'"), new StringLiteralType("'OpenReceived'"), new StringLiteralType("'Established'"), new StringLiteralType("'PendingAdd'"), new StringLiteralType("'PendingUpdate'"), new StringLiteralType("'PendingRemove'")), TypePropertyFlags.ReadOnly), new TypeProperty("sessionStateV6", UnionType.Create(new StringLiteralType("'None'"), new StringLiteralType("'Idle'"), new StringLiteralType("'Connect'"), new StringLiteralType("'Active'"), new StringLiteralType("'OpenSent'"), new StringLiteralType("'OpenConfirm'"), new StringLiteralType("'OpenReceived'"), new StringLiteralType("'Established'"), new StringLiteralType("'PendingAdd'"), new StringLiteralType("'PendingUpdate'"), new StringLiteralType("'PendingRemove'")), TypePropertyFlags.ReadOnly), new TypeProperty("maxPrefixesAdvertisedV4", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("maxPrefixesAdvertisedV6", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("md5AuthenticationKey", LanguageConstants.String, TypePropertyFlags.None)}, null);
            SubResource = new NamedObjectType("SubResource", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.None)}, null);
            PeeringPropertiesExchange = new NamedObjectType("PeeringPropertiesExchange", new ITypeProperty[]{new LazyTypeProperty("connections", () => new TypedArrayType(ExchangeConnection), TypePropertyFlags.None), new LazyTypeProperty("peerAsn", () => SubResource, TypePropertyFlags.None)}, null);
            ExchangeConnection = new NamedObjectType("ExchangeConnection", new ITypeProperty[]{new TypeProperty("peeringDBFacilityId", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("connectionState", UnionType.Create(new StringLiteralType("'None'"), new StringLiteralType("'PendingApproval'"), new StringLiteralType("'Approved'"), new StringLiteralType("'ProvisioningStarted'"), new StringLiteralType("'ProvisioningFailed'"), new StringLiteralType("'ProvisioningCompleted'"), new StringLiteralType("'Validating'"), new StringLiteralType("'Active'")), TypePropertyFlags.ReadOnly), new LazyTypeProperty("bgpSession", () => BgpSession, TypePropertyFlags.None), new TypeProperty("connectionIdentifier", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("errorMessage", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            PeeringServicePrefixProperties = new NamedObjectType("PeeringServicePrefixProperties", new ITypeProperty[]{new TypeProperty("prefix", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("prefixValidationState", UnionType.Create(new StringLiteralType("'None'"), new StringLiteralType("'Invalid'"), new StringLiteralType("'Verified'"), new StringLiteralType("'Failed'"), new StringLiteralType("'Pending'"), new StringLiteralType("'Warning'"), new StringLiteralType("'Unknown'")), TypePropertyFlags.ReadOnly), new TypeProperty("learnedType", UnionType.Create(new StringLiteralType("'None'"), new StringLiteralType("'ViaServiceProvider'"), new StringLiteralType("'ViaSession'")), TypePropertyFlags.ReadOnly), new TypeProperty("errorMessage", LanguageConstants.String, TypePropertyFlags.ReadOnly), new LazyTypeProperty("events", () => new TypedArrayType(PeeringServicePrefixEvent), TypePropertyFlags.ReadOnly), new TypeProperty("peeringServicePrefixKey", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("provisioningState", UnionType.Create(new StringLiteralType("'Succeeded'"), new StringLiteralType("'Updating'"), new StringLiteralType("'Deleting'"), new StringLiteralType("'Failed'")), TypePropertyFlags.ReadOnly)}, null);
            PeeringServicePrefixEvent = new NamedObjectType("PeeringServicePrefixEvent", new ITypeProperty[]{new TypeProperty("eventTimestamp", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("eventType", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("eventSummary", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("eventLevel", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("eventDescription", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            PeeringServiceSku = new NamedObjectType("PeeringServiceSku", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None)}, null);
            PeeringServiceProperties = new NamedObjectType("PeeringServiceProperties", new ITypeProperty[]{new TypeProperty("peeringServiceLocation", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("peeringServiceProvider", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("provisioningState", UnionType.Create(new StringLiteralType("'Succeeded'"), new StringLiteralType("'Updating'"), new StringLiteralType("'Deleting'"), new StringLiteralType("'Failed'")), TypePropertyFlags.ReadOnly)}, null);
            ResourceType_peerings = new ResourceType("Microsoft.Peering/peerings", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("type", new StringLiteralType("'Microsoft.Peering/peerings'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new LazyTypeProperty("sku", () => PeeringSku, TypePropertyFlags.Required), new TypeProperty("kind", UnionType.Create(new StringLiteralType("'Direct'"), new StringLiteralType("'Exchange'")), TypePropertyFlags.Required), new LazyTypeProperty("properties", () => PeeringProperties, TypePropertyFlags.Required), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("apiVersion", new StringLiteralType("'2020-04-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_peerings);
            ResourceType_peeringServices = new ResourceType("Microsoft.Peering/peeringServices", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("type", new StringLiteralType("'Microsoft.Peering/peeringServices'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new LazyTypeProperty("sku", () => PeeringServiceSku, TypePropertyFlags.None), new LazyTypeProperty("properties", () => PeeringServiceProperties, TypePropertyFlags.Required), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("apiVersion", new StringLiteralType("'2020-04-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_peeringServices);
            ResourceType_peerings_registeredAsns = new ResourceType("Microsoft.Peering/peerings/registeredAsns", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("type", new StringLiteralType("'Microsoft.Peering/peerings/registeredAsns'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new LazyTypeProperty("properties", () => PeeringRegisteredAsnProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2020-04-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_peerings_registeredAsns);
            ResourceType_peerings_registeredPrefixes = new ResourceType("Microsoft.Peering/peerings/registeredPrefixes", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("type", new StringLiteralType("'Microsoft.Peering/peerings/registeredPrefixes'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new LazyTypeProperty("properties", () => PeeringRegisteredPrefixProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2020-04-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_peerings_registeredPrefixes);
            ResourceType_peeringServices_prefixes = new ResourceType("Microsoft.Peering/peeringServices/prefixes", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("type", new StringLiteralType("'Microsoft.Peering/peeringServices/prefixes'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new LazyTypeProperty("properties", () => PeeringServicePrefixProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2020-04-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_peeringServices_prefixes);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_peerings, () => InstanceLazy.Value.ResourceType_peerings);
            registrar.RegisterType(ResourceTypeReference_peeringServices, () => InstanceLazy.Value.ResourceType_peeringServices);
            registrar.RegisterType(ResourceTypeReference_peerings_registeredAsns, () => InstanceLazy.Value.ResourceType_peerings_registeredAsns);
            registrar.RegisterType(ResourceTypeReference_peerings_registeredPrefixes, () => InstanceLazy.Value.ResourceType_peerings_registeredPrefixes);
            registrar.RegisterType(ResourceTypeReference_peeringServices_prefixes, () => InstanceLazy.Value.ResourceType_peeringServices_prefixes);
        }
        private readonly ResourceType ResourceType_peerings;
        private readonly ResourceType ResourceType_peeringServices;
        private readonly ResourceType ResourceType_peerings_registeredAsns;
        private readonly ResourceType ResourceType_peerings_registeredPrefixes;
        private readonly ResourceType ResourceType_peeringServices_prefixes;
        private readonly TypeSymbol PeerAsnProperties;
        private readonly TypeSymbol ContactDetail;
        private readonly TypeSymbol PeeringRegisteredAsnProperties;
        private readonly TypeSymbol PeeringRegisteredPrefixProperties;
        private readonly TypeSymbol PeeringSku;
        private readonly TypeSymbol PeeringProperties;
        private readonly TypeSymbol PeeringPropertiesDirect;
        private readonly TypeSymbol DirectConnection;
        private readonly TypeSymbol BgpSession;
        private readonly TypeSymbol SubResource;
        private readonly TypeSymbol PeeringPropertiesExchange;
        private readonly TypeSymbol ExchangeConnection;
        private readonly TypeSymbol PeeringServicePrefixProperties;
        private readonly TypeSymbol PeeringServicePrefixEvent;
        private readonly TypeSymbol PeeringServiceSku;
        private readonly TypeSymbol PeeringServiceProperties;
    }
}
