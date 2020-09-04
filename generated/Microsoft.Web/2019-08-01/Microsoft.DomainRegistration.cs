// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_DomainRegistration_2019_08_01
    {
        private const string ProviderNamespace = "Microsoft.DomainRegistration";
        private const string ApiVersion = "2019-08-01";
        private static readonly ResourceTypeReference ResourceTypeReference_domains = new ResourceTypeReference(ProviderNamespace, new[]{"domains"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_domains_domainOwnershipIdentifiers = new ResourceTypeReference(ProviderNamespace, new[]{"domains", "domainOwnershipIdentifiers"}, ApiVersion);
        private static Lazy<Microsoft_DomainRegistration_2019_08_01> InstanceLazy = new Lazy<Microsoft_DomainRegistration_2019_08_01>(() => new Microsoft_DomainRegistration_2019_08_01());
        private Microsoft_DomainRegistration_2019_08_01()
        {
            DomainProperties = new NamedObjectType("DomainProperties", new ITypeProperty[]{new LazyTypeProperty("contactAdmin", () => Contact, TypePropertyFlags.Required), new LazyTypeProperty("contactBilling", () => Contact, TypePropertyFlags.Required), new LazyTypeProperty("contactRegistrant", () => Contact, TypePropertyFlags.Required), new LazyTypeProperty("contactTech", () => Contact, TypePropertyFlags.Required), new TypeProperty("registrationStatus", UnionType.Create(new StringLiteralType("'Active'"), new StringLiteralType("'Awaiting'"), new StringLiteralType("'Cancelled'"), new StringLiteralType("'Confiscated'"), new StringLiteralType("'Disabled'"), new StringLiteralType("'Excluded'"), new StringLiteralType("'Expired'"), new StringLiteralType("'Failed'"), new StringLiteralType("'Held'"), new StringLiteralType("'Locked'"), new StringLiteralType("'Parked'"), new StringLiteralType("'Pending'"), new StringLiteralType("'Reserved'"), new StringLiteralType("'Reverted'"), new StringLiteralType("'Suspended'"), new StringLiteralType("'Transferred'"), new StringLiteralType("'Unknown'"), new StringLiteralType("'Unlocked'"), new StringLiteralType("'Unparked'"), new StringLiteralType("'Updated'"), new StringLiteralType("'JsonConverterFailed'")), TypePropertyFlags.ReadOnly), new TypeProperty("provisioningState", UnionType.Create(new StringLiteralType("'Succeeded'"), new StringLiteralType("'Failed'"), new StringLiteralType("'Canceled'"), new StringLiteralType("'InProgress'"), new StringLiteralType("'Deleting'")), TypePropertyFlags.ReadOnly), new TypeProperty("nameServers", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.ReadOnly), new TypeProperty("privacy", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("createdTime", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("expirationTime", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("lastRenewedTime", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("autoRenew", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("readyForDnsRecordManagement", LanguageConstants.Bool, TypePropertyFlags.ReadOnly), new LazyTypeProperty("managedHostNames", () => new TypedArrayType(HostName), TypePropertyFlags.ReadOnly), new LazyTypeProperty("consent", () => DomainPurchaseConsent, TypePropertyFlags.Required), new TypeProperty("domainNotRenewableReasons", new TypedArrayType(UnionType.Create(new StringLiteralType("'RegistrationStatusNotSupportedForRenewal'"), new StringLiteralType("'ExpirationNotInRenewalTimeRange'"), new StringLiteralType("'SubscriptionNotActive'"))), TypePropertyFlags.ReadOnly), new TypeProperty("dnsType", UnionType.Create(new StringLiteralType("'AzureDns'"), new StringLiteralType("'DefaultDomainRegistrarDns'")), TypePropertyFlags.None), new TypeProperty("dnsZoneId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("targetDnsType", UnionType.Create(new StringLiteralType("'AzureDns'"), new StringLiteralType("'DefaultDomainRegistrarDns'")), TypePropertyFlags.None), new TypeProperty("authCode", LanguageConstants.String, TypePropertyFlags.None)}, null);
            Contact = new NamedObjectType("Contact", new ITypeProperty[]{new LazyTypeProperty("addressMailing", () => Address, TypePropertyFlags.None), new TypeProperty("email", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("fax", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("jobTitle", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("nameFirst", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("nameLast", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("nameMiddle", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("organization", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("phone", LanguageConstants.String, TypePropertyFlags.Required)}, null);
            Address = new NamedObjectType("Address", new ITypeProperty[]{new TypeProperty("address1", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("address2", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("city", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("country", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("postalCode", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("state", LanguageConstants.String, TypePropertyFlags.Required)}, null);
            HostName = new NamedObjectType("HostName", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("siteNames", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new TypeProperty("azureResourceName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("azureResourceType", UnionType.Create(new StringLiteralType("'Website'"), new StringLiteralType("'TrafficManager'")), TypePropertyFlags.None), new TypeProperty("customHostNameDnsRecordType", UnionType.Create(new StringLiteralType("'CName'"), new StringLiteralType("'A'")), TypePropertyFlags.None), new TypeProperty("hostNameType", UnionType.Create(new StringLiteralType("'Verified'"), new StringLiteralType("'Managed'")), TypePropertyFlags.None)}, null);
            DomainPurchaseConsent = new NamedObjectType("DomainPurchaseConsent", new ITypeProperty[]{new TypeProperty("agreementKeys", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new TypeProperty("agreedBy", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("agreedAt", LanguageConstants.String, TypePropertyFlags.None)}, null);
            DomainOwnershipIdentifierProperties = new NamedObjectType("DomainOwnershipIdentifierProperties", new ITypeProperty[]{new TypeProperty("ownershipId", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ResourceType_domains = new ResourceType("Microsoft.DomainRegistration/domains", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.DomainRegistration/domains'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("properties", () => DomainProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2019-08-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_domains);
            ResourceType_domains_domainOwnershipIdentifiers = new ResourceType("Microsoft.DomainRegistration/domains/domainOwnershipIdentifiers", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("type", new StringLiteralType("'Microsoft.DomainRegistration/domains/domainOwnershipIdentifiers'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new LazyTypeProperty("properties", () => DomainOwnershipIdentifierProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2019-08-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_domains_domainOwnershipIdentifiers);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_domains, () => InstanceLazy.Value.ResourceType_domains);
            registrar.RegisterType(ResourceTypeReference_domains_domainOwnershipIdentifiers, () => InstanceLazy.Value.ResourceType_domains_domainOwnershipIdentifiers);
        }
        private readonly ResourceType ResourceType_domains;
        private readonly ResourceType ResourceType_domains_domainOwnershipIdentifiers;
        private readonly TypeSymbol DomainProperties;
        private readonly TypeSymbol Contact;
        private readonly TypeSymbol Address;
        private readonly TypeSymbol HostName;
        private readonly TypeSymbol DomainPurchaseConsent;
        private readonly TypeSymbol DomainOwnershipIdentifierProperties;
    }
}
