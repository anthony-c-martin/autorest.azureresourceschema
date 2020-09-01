// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_Peering_2019_09_01_preview
    {
        private const string ProviderNamespace = "Microsoft.Peering";
        private const string ApiVersion = "2019-09-01-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_peerings = new ResourceTypeReference(ProviderNamespace, new[]{"peerings"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_peeringServices = new ResourceTypeReference(ProviderNamespace, new[]{"peeringServices"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_peeringServices_prefixes = new ResourceTypeReference(ProviderNamespace, new[]{"peeringServices", "prefixes"}, ApiVersion);
        private static Lazy<Microsoft_Peering_2019_09_01_preview> InstanceLazy = new Lazy<Microsoft_Peering_2019_09_01_preview>(() => new Microsoft_Peering_2019_09_01_preview());
        private Microsoft_Peering_2019_09_01_preview()
        {
            PeerAsnProperties = new NamedObjectType("PeerAsnProperties", new ITypeProperty[]{new TypeProperty("peerAsn", LanguageConstants.Int, TypePropertyFlags.None), new LazyTypeProperty("peerContactInfo", () => ContactInfo, TypePropertyFlags.None), new TypeProperty("peerName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("validationState", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ContactInfo = new NamedObjectType("ContactInfo", new ITypeProperty[]{new TypeProperty("emails", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("phone", LanguageConstants.Array, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            PeeringSku = new NamedObjectType("PeeringSku", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tier", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("family", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("size", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            PeeringProperties = new NamedObjectType("PeeringProperties", new ITypeProperty[]{new LazyTypeProperty("direct", () => PeeringPropertiesDirect, TypePropertyFlags.None), new LazyTypeProperty("exchange", () => PeeringPropertiesExchange, TypePropertyFlags.None), new TypeProperty("peeringLocation", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            PeeringPropertiesDirect = new NamedObjectType("PeeringPropertiesDirect", new ITypeProperty[]{new TypeProperty("connections", LanguageConstants.Array, TypePropertyFlags.None), new LazyTypeProperty("peerAsn", () => SubResource, TypePropertyFlags.None), new TypeProperty("directPeeringType", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            DirectConnection = new NamedObjectType("DirectConnection", new ITypeProperty[]{new TypeProperty("bandwidthInMbps", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("sessionAddressProvider", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("useForPeeringService", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("peeringDBFacilityId", LanguageConstants.Int, TypePropertyFlags.None), new LazyTypeProperty("bgpSession", () => BgpSession, TypePropertyFlags.None), new TypeProperty("connectionIdentifier", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            BgpSession = new NamedObjectType("BgpSession", new ITypeProperty[]{new TypeProperty("sessionPrefixV4", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("sessionPrefixV6", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("peerSessionIPv4Address", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("peerSessionIPv6Address", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("maxPrefixesAdvertisedV4", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("maxPrefixesAdvertisedV6", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("md5AuthenticationKey", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            SubResource = new NamedObjectType("SubResource", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            PeeringPropertiesExchange = new NamedObjectType("PeeringPropertiesExchange", new ITypeProperty[]{new TypeProperty("connections", LanguageConstants.Array, TypePropertyFlags.None), new LazyTypeProperty("peerAsn", () => SubResource, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ExchangeConnection = new NamedObjectType("ExchangeConnection", new ITypeProperty[]{new TypeProperty("peeringDBFacilityId", LanguageConstants.Int, TypePropertyFlags.None), new LazyTypeProperty("bgpSession", () => BgpSession, TypePropertyFlags.None), new TypeProperty("connectionIdentifier", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            PeeringServicePrefixProperties = new NamedObjectType("PeeringServicePrefixProperties", new ITypeProperty[]{new TypeProperty("prefix", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            PeeringServiceProperties = new NamedObjectType("PeeringServiceProperties", new ITypeProperty[]{new TypeProperty("peeringServiceLocation", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("peeringServiceProvider", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_peerings = new ResourceType("Microsoft.Peering/peerings", new ITypeProperty[]{new LazyTypeProperty("sku", () => PeeringSku, TypePropertyFlags.Required), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => PeeringProperties, TypePropertyFlags.Required), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_peerings);
            ResourceType_peeringServices = new ResourceType("Microsoft.Peering/peeringServices", new ITypeProperty[]{new LazyTypeProperty("properties", () => PeeringServiceProperties, TypePropertyFlags.Required), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_peeringServices);
            ResourceType_peeringServices_prefixes = new ResourceType("Microsoft.Peering/peeringServices/prefixes", new ITypeProperty[]{new LazyTypeProperty("properties", () => PeeringServicePrefixProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_peeringServices_prefixes);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_peerings, () => InstanceLazy.Value.ResourceType_peerings);
            registrar.RegisterType(ResourceTypeReference_peeringServices, () => InstanceLazy.Value.ResourceType_peeringServices);
            registrar.RegisterType(ResourceTypeReference_peeringServices_prefixes, () => InstanceLazy.Value.ResourceType_peeringServices_prefixes);
        }
        private readonly ResourceType ResourceType_peerings;
        private readonly ResourceType ResourceType_peeringServices;
        private readonly ResourceType ResourceType_peeringServices_prefixes;
        private readonly TypeSymbol PeerAsnProperties;
        private readonly TypeSymbol ContactInfo;
        private readonly TypeSymbol PeeringSku;
        private readonly TypeSymbol PeeringProperties;
        private readonly TypeSymbol PeeringPropertiesDirect;
        private readonly TypeSymbol DirectConnection;
        private readonly TypeSymbol BgpSession;
        private readonly TypeSymbol SubResource;
        private readonly TypeSymbol PeeringPropertiesExchange;
        private readonly TypeSymbol ExchangeConnection;
        private readonly TypeSymbol PeeringServicePrefixProperties;
        private readonly TypeSymbol PeeringServiceProperties;
    }
}
