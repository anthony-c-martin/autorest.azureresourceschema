// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_AAD_2017_01_01
    {
        private const string ProviderNamespace = "Microsoft.AAD";
        private const string ApiVersion = "2017-01-01";
        private static readonly ResourceTypeReference ResourceTypeReference_domainServices = new ResourceTypeReference(ProviderNamespace, new[]{"domainServices"}, ApiVersion);
        private static Lazy<Microsoft_AAD_2017_01_01> InstanceLazy = new Lazy<Microsoft_AAD_2017_01_01>(() => new Microsoft_AAD_2017_01_01());
        private Microsoft_AAD_2017_01_01()
        {
            DomainServiceProperties = new NamedObjectType("DomainServiceProperties", new ITypeProperty[]{new TypeProperty("tenantId", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("domainName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("vnetSiteId", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("subnetId", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("ldapsSettings", () => LdapsSettings, TypePropertyFlags.None), new TypeProperty("healthLastEvaluated", LanguageConstants.String, TypePropertyFlags.ReadOnly), new LazyTypeProperty("healthMonitors", () => new TypedArrayType(HealthMonitor), TypePropertyFlags.ReadOnly), new LazyTypeProperty("healthAlerts", () => new TypedArrayType(HealthAlert), TypePropertyFlags.ReadOnly), new LazyTypeProperty("notificationSettings", () => NotificationSettings, TypePropertyFlags.None), new LazyTypeProperty("domainSecuritySettings", () => DomainSecuritySettings, TypePropertyFlags.None), new TypeProperty("filteredSync", UnionType.Create(new StringLiteralType("'Enabled'"), new StringLiteralType("'Disabled'")), TypePropertyFlags.None), new TypeProperty("domainControllerIpAddress", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.ReadOnly), new TypeProperty("serviceStatus", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("provisioningState", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            LdapsSettings = new NamedObjectType("LdapsSettings", new ITypeProperty[]{new TypeProperty("ldaps", UnionType.Create(new StringLiteralType("'Enabled'"), new StringLiteralType("'Disabled'")), TypePropertyFlags.None), new TypeProperty("pfxCertificate", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("pfxCertificatePassword", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("publicCertificate", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("certificateThumbprint", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("certificateNotAfter", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("externalAccess", UnionType.Create(new StringLiteralType("'Enabled'"), new StringLiteralType("'Disabled'")), TypePropertyFlags.None), new TypeProperty("externalAccessIpAddress", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            HealthMonitor = new NamedObjectType("HealthMonitor", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("details", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            HealthAlert = new NamedObjectType("HealthAlert", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("issue", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("severity", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("raised", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("lastDetected", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("resolutionUri", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            NotificationSettings = new NamedObjectType("NotificationSettings", new ITypeProperty[]{new TypeProperty("notifyGlobalAdmins", UnionType.Create(new StringLiteralType("'Enabled'"), new StringLiteralType("'Disabled'")), TypePropertyFlags.None), new TypeProperty("notifyDcAdmins", UnionType.Create(new StringLiteralType("'Enabled'"), new StringLiteralType("'Disabled'")), TypePropertyFlags.None), new TypeProperty("additionalRecipients", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None)}, null);
            DomainSecuritySettings = new NamedObjectType("DomainSecuritySettings", new ITypeProperty[]{new TypeProperty("ntlmV1", UnionType.Create(new StringLiteralType("'Enabled'"), new StringLiteralType("'Disabled'")), TypePropertyFlags.None), new TypeProperty("tlsV1", UnionType.Create(new StringLiteralType("'Enabled'"), new StringLiteralType("'Disabled'")), TypePropertyFlags.None), new TypeProperty("syncNtlmPasswords", UnionType.Create(new StringLiteralType("'Enabled'"), new StringLiteralType("'Disabled'")), TypePropertyFlags.None)}, null);
            ResourceType_domainServices = new ResourceType("Microsoft.AAD/domainServices", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.AAD/domainServices'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("etag", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("properties", () => DomainServiceProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2017-01-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_domainServices);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_domainServices, () => InstanceLazy.Value.ResourceType_domainServices);
        }
        private readonly ResourceType ResourceType_domainServices;
        private readonly TypeSymbol DomainServiceProperties;
        private readonly TypeSymbol LdapsSettings;
        private readonly TypeSymbol HealthMonitor;
        private readonly TypeSymbol HealthAlert;
        private readonly TypeSymbol NotificationSettings;
        private readonly TypeSymbol DomainSecuritySettings;
    }
}
