// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_DomainRegistration_2018_02_01
    {
        private const string ProviderNamespace = "Microsoft.DomainRegistration";
        private const string ApiVersion = "2018-02-01";
        private static readonly ResourceTypeReference ResourceTypeReference_domains = new ResourceTypeReference(ProviderNamespace, new[]{"domains"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_domains_domainOwnershipIdentifiers = new ResourceTypeReference(ProviderNamespace, new[]{"domains", "domainOwnershipIdentifiers"}, ApiVersion);
        private static Lazy<Microsoft_DomainRegistration_2018_02_01> InstanceLazy = new Lazy<Microsoft_DomainRegistration_2018_02_01>(() => new Microsoft_DomainRegistration_2018_02_01());
        private Microsoft_DomainRegistration_2018_02_01()
        {
            DomainProperties = new NamedObjectType("DomainProperties", new ITypeProperty[]{new LazyTypeProperty("contactAdmin", () => Contact, TypePropertyFlags.Required), new LazyTypeProperty("contactBilling", () => Contact, TypePropertyFlags.Required), new LazyTypeProperty("contactRegistrant", () => Contact, TypePropertyFlags.Required), new LazyTypeProperty("contactTech", () => Contact, TypePropertyFlags.Required), new TypeProperty("privacy", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("autoRenew", LanguageConstants.Bool, TypePropertyFlags.None), new LazyTypeProperty("consent", () => DomainPurchaseConsent, TypePropertyFlags.Required), new TypeProperty("dnsType", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("dnsZoneId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("targetDnsType", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("authCode", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            Contact = new NamedObjectType("Contact", new ITypeProperty[]{new LazyTypeProperty("addressMailing", () => Address, TypePropertyFlags.None), new TypeProperty("email", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("fax", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("jobTitle", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("nameFirst", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("nameLast", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("nameMiddle", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("organization", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("phone", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            Address = new NamedObjectType("Address", new ITypeProperty[]{new TypeProperty("address1", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("address2", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("city", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("country", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("postalCode", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("state", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            DomainPurchaseConsent = new NamedObjectType("DomainPurchaseConsent", new ITypeProperty[]{new TypeProperty("agreementKeys", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("agreedBy", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("agreedAt", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            DomainOwnershipIdentifierProperties = new NamedObjectType("DomainOwnershipIdentifierProperties", new ITypeProperty[]{new TypeProperty("ownershipId", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_domains = new ResourceType("Microsoft.DomainRegistration/domains", new ITypeProperty[]{new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("properties", () => DomainProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_domains);
            ResourceType_domains_domainOwnershipIdentifiers = new ResourceType("Microsoft.DomainRegistration/domains/domainOwnershipIdentifiers", new ITypeProperty[]{new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("properties", () => DomainOwnershipIdentifierProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_domains_domainOwnershipIdentifiers);
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
        private readonly TypeSymbol DomainPurchaseConsent;
        private readonly TypeSymbol DomainOwnershipIdentifierProperties;
    }
}
