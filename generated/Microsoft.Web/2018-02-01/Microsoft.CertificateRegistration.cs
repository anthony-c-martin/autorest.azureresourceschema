// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_CertificateRegistration_2018_02_01
    {
        private const string ProviderNamespace = "Microsoft.CertificateRegistration";
        private const string ApiVersion = "2018-02-01";
        private static readonly ResourceTypeReference ResourceTypeReference_certificateOrders = new ResourceTypeReference(ProviderNamespace, new[]{"certificateOrders"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_certificateOrders_certificates = new ResourceTypeReference(ProviderNamespace, new[]{"certificateOrders", "certificates"}, ApiVersion);
        private static Lazy<Microsoft_CertificateRegistration_2018_02_01> InstanceLazy = new Lazy<Microsoft_CertificateRegistration_2018_02_01>(() => new Microsoft_CertificateRegistration_2018_02_01());
        private Microsoft_CertificateRegistration_2018_02_01()
        {
            AppServiceCertificateOrderProperties = new NamedObjectType("AppServiceCertificateOrderProperties", new ITypeProperty[]{new TypeProperty("certificates", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("distinguishedName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("validityInYears", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("keySize", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("productType", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("autoRenew", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("csr", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            AppServiceCertificate = new NamedObjectType("AppServiceCertificate", new ITypeProperty[]{new TypeProperty("keyVaultId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("keyVaultSecretName", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_certificateOrders = new ResourceType("Microsoft.CertificateRegistration/certificateOrders", new ITypeProperty[]{new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("properties", () => AppServiceCertificateOrderProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_certificateOrders);
            ResourceType_certificateOrders_certificates = new ResourceType("Microsoft.CertificateRegistration/certificateOrders/certificates", new ITypeProperty[]{new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("properties", () => AppServiceCertificate, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_certificateOrders_certificates);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_certificateOrders, () => InstanceLazy.Value.ResourceType_certificateOrders);
            registrar.RegisterType(ResourceTypeReference_certificateOrders_certificates, () => InstanceLazy.Value.ResourceType_certificateOrders_certificates);
        }
        private readonly ResourceType ResourceType_certificateOrders;
        private readonly ResourceType ResourceType_certificateOrders_certificates;
        private readonly TypeSymbol AppServiceCertificateOrderProperties;
        private readonly TypeSymbol AppServiceCertificate;
    }
}
