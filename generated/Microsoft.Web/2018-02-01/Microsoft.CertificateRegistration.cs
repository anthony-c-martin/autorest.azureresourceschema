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
            AppServiceCertificateOrderProperties = new NamedObjectType("AppServiceCertificateOrderProperties", new ITypeProperty[]{new TypeProperty("certificates", new NamedObjectType("certificates", new ITypeProperty[]{}, new LazyTypeProperty("additionalProperties", () => AppServiceCertificate, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("distinguishedName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("domainVerificationToken", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("validityInYears", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("keySize", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("productType", UnionType.Create(new StringLiteralType("'StandardDomainValidatedSsl'"), new StringLiteralType("'StandardDomainValidatedWildCardSsl'")), TypePropertyFlags.Required), new TypeProperty("autoRenew", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("provisioningState", UnionType.Create(new StringLiteralType("'Succeeded'"), new StringLiteralType("'Failed'"), new StringLiteralType("'Canceled'"), new StringLiteralType("'InProgress'"), new StringLiteralType("'Deleting'")), TypePropertyFlags.ReadOnly), new TypeProperty("status", UnionType.Create(new StringLiteralType("'Pendingissuance'"), new StringLiteralType("'Issued'"), new StringLiteralType("'Revoked'"), new StringLiteralType("'Canceled'"), new StringLiteralType("'Denied'"), new StringLiteralType("'Pendingrevocation'"), new StringLiteralType("'PendingRekey'"), new StringLiteralType("'Unused'"), new StringLiteralType("'Expired'"), new StringLiteralType("'NotSubmitted'")), TypePropertyFlags.ReadOnly), new LazyTypeProperty("signedCertificate", () => CertificateDetails, TypePropertyFlags.ReadOnly), new TypeProperty("csr", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("intermediate", () => CertificateDetails, TypePropertyFlags.ReadOnly), new LazyTypeProperty("root", () => CertificateDetails, TypePropertyFlags.ReadOnly), new TypeProperty("serialNumber", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("lastCertificateIssuanceTime", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("expirationTime", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("isPrivateKeyExternal", LanguageConstants.Bool, TypePropertyFlags.ReadOnly), new TypeProperty("appServiceCertificateNotRenewableReasons", new TypedArrayType(UnionType.Create(new StringLiteralType("'RegistrationStatusNotSupportedForRenewal'"), new StringLiteralType("'ExpirationNotInRenewalTimeRange'"), new StringLiteralType("'SubscriptionNotActive'"))), TypePropertyFlags.ReadOnly), new TypeProperty("nextAutoRenewalTimeStamp", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            AppServiceCertificate = new NamedObjectType("AppServiceCertificate", new ITypeProperty[]{new TypeProperty("keyVaultId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("keyVaultSecretName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("provisioningState", UnionType.Create(new StringLiteralType("'Initialized'"), new StringLiteralType("'WaitingOnCertificateOrder'"), new StringLiteralType("'Succeeded'"), new StringLiteralType("'CertificateOrderFailed'"), new StringLiteralType("'OperationNotPermittedOnKeyVault'"), new StringLiteralType("'AzureServiceUnauthorizedToAccessKeyVault'"), new StringLiteralType("'KeyVaultDoesNotExist'"), new StringLiteralType("'KeyVaultSecretDoesNotExist'"), new StringLiteralType("'UnknownError'"), new StringLiteralType("'ExternalPrivateKey'"), new StringLiteralType("'Unknown'")), TypePropertyFlags.ReadOnly)}, null);
            CertificateDetails = new NamedObjectType("CertificateDetails", new ITypeProperty[]{new TypeProperty("version", LanguageConstants.Int, TypePropertyFlags.ReadOnly), new TypeProperty("serialNumber", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("thumbprint", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("subject", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("notBefore", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("notAfter", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("signatureAlgorithm", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("issuer", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("rawData", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            ResourceType_certificateOrders = new ResourceType("Microsoft.CertificateRegistration/certificateOrders", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.CertificateRegistration/certificateOrders'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("properties", () => AppServiceCertificateOrderProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2018-02-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_certificateOrders);
            ResourceType_certificateOrders_certificates = new ResourceType("Microsoft.CertificateRegistration/certificateOrders/certificates", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.CertificateRegistration/certificateOrders/certificates'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("properties", () => AppServiceCertificate, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2018-02-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_certificateOrders_certificates);
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
        private readonly TypeSymbol CertificateDetails;
    }
}
