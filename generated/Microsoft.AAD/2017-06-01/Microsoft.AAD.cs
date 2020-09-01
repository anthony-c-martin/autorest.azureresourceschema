// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_AAD_2017_06_01
    {
        private const string ProviderNamespace = "Microsoft.AAD";
        private const string ApiVersion = "2017-06-01";
        private static readonly ResourceTypeReference ResourceTypeReference_domainServices = new ResourceTypeReference(ProviderNamespace, new[]{"domainServices"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_domainServices_ouContainer = new ResourceTypeReference(ProviderNamespace, new[]{"domainServices", "ouContainer"}, ApiVersion);
        private static Lazy<Microsoft_AAD_2017_06_01> InstanceLazy = new Lazy<Microsoft_AAD_2017_06_01>(() => new Microsoft_AAD_2017_06_01());
        private Microsoft_AAD_2017_06_01()
        {
            DomainServiceProperties = new NamedObjectType("DomainServiceProperties", new ITypeProperty[]{new TypeProperty("domainName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("subnetId", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("ldapsSettings", () => LdapsSettings, TypePropertyFlags.None), new LazyTypeProperty("notificationSettings", () => NotificationSettings, TypePropertyFlags.None), new LazyTypeProperty("domainSecuritySettings", () => DomainSecuritySettings, TypePropertyFlags.None), new TypeProperty("filteredSync", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            LdapsSettings = new NamedObjectType("LdapsSettings", new ITypeProperty[]{new TypeProperty("ldaps", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("pfxCertificate", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("pfxCertificatePassword", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("externalAccess", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            NotificationSettings = new NamedObjectType("NotificationSettings", new ITypeProperty[]{new TypeProperty("notifyGlobalAdmins", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("notifyDcAdmins", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("additionalRecipients", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            DomainSecuritySettings = new NamedObjectType("DomainSecuritySettings", new ITypeProperty[]{new TypeProperty("ntlmV1", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tlsV1", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("syncNtlmPasswords", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_domainServices = new ResourceType("Microsoft.AAD/domainServices", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new TypeProperty("etag", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("properties", () => DomainServiceProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_domainServices);
            ResourceType_domainServices_ouContainer = new ResourceType("Microsoft.Aad/domainServices/ouContainer", new ITypeProperty[]{new TypeProperty("accountName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("spn", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("password", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_domainServices_ouContainer);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_domainServices, () => InstanceLazy.Value.ResourceType_domainServices);
            registrar.RegisterType(ResourceTypeReference_domainServices_ouContainer, () => InstanceLazy.Value.ResourceType_domainServices_ouContainer);
        }
        private readonly ResourceType ResourceType_domainServices;
        private readonly ResourceType ResourceType_domainServices_ouContainer;
        private readonly TypeSymbol DomainServiceProperties;
        private readonly TypeSymbol LdapsSettings;
        private readonly TypeSymbol NotificationSettings;
        private readonly TypeSymbol DomainSecuritySettings;
    }
}
