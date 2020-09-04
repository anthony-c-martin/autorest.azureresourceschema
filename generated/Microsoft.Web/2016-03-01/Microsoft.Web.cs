// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_Web_2016_03_01
    {
        private const string ProviderNamespace = "Microsoft.Web";
        private const string ApiVersion = "2016-03-01";
        private static readonly ResourceTypeReference ResourceTypeReference_certificates = new ResourceTypeReference(ProviderNamespace, new[]{"certificates"}, ApiVersion);
        private static Lazy<Microsoft_Web_2016_03_01> InstanceLazy = new Lazy<Microsoft_Web_2016_03_01>(() => new Microsoft_Web_2016_03_01());
        private Microsoft_Web_2016_03_01()
        {
            CertificateProperties = new NamedObjectType("CertificateProperties", new ITypeProperty[]{new TypeProperty("friendlyName", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("subjectName", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("hostNames", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new TypeProperty("pfxBlob", new TypedArrayType(LanguageConstants.Int), TypePropertyFlags.None), new TypeProperty("siteName", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("selfLink", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("issuer", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("issueDate", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("expirationDate", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("password", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("thumbprint", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("valid", LanguageConstants.Bool, TypePropertyFlags.ReadOnly), new TypeProperty("cerBlob", new TypedArrayType(LanguageConstants.Int), TypePropertyFlags.ReadOnly), new TypeProperty("publicKeyHash", LanguageConstants.String, TypePropertyFlags.ReadOnly), new LazyTypeProperty("hostingEnvironmentProfile", () => HostingEnvironmentProfile, TypePropertyFlags.ReadOnly), new TypeProperty("keyVaultId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("keyVaultSecretName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("keyVaultSecretStatus", UnionType.Create(new StringLiteralType("'Initialized'"), new StringLiteralType("'WaitingOnCertificateOrder'"), new StringLiteralType("'Succeeded'"), new StringLiteralType("'CertificateOrderFailed'"), new StringLiteralType("'OperationNotPermittedOnKeyVault'"), new StringLiteralType("'AzureServiceUnauthorizedToAccessKeyVault'"), new StringLiteralType("'KeyVaultDoesNotExist'"), new StringLiteralType("'KeyVaultSecretDoesNotExist'"), new StringLiteralType("'UnknownError'"), new StringLiteralType("'ExternalPrivateKey'"), new StringLiteralType("'Unknown'")), TypePropertyFlags.ReadOnly), new TypeProperty("geoRegion", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("serverFarmId", LanguageConstants.String, TypePropertyFlags.None)}, null);
            HostingEnvironmentProfile = new NamedObjectType("HostingEnvironmentProfile", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            UserProperties = new NamedObjectType("UserProperties", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("publishingUserName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("publishingPassword", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("publishingPasswordHash", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("publishingPasswordHashSalt", LanguageConstants.String, TypePropertyFlags.None)}, null);
            SourceControlProperties = new NamedObjectType("SourceControlProperties", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("token", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tokenSecret", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("refreshToken", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("expirationTime", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ResourceType_certificates = new ResourceType("Microsoft.Web/certificates", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.Web/certificates'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("properties", () => CertificateProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2016-03-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_certificates);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_certificates, () => InstanceLazy.Value.ResourceType_certificates);
        }
        private readonly ResourceType ResourceType_certificates;
        private readonly TypeSymbol CertificateProperties;
        private readonly TypeSymbol HostingEnvironmentProfile;
        private readonly TypeSymbol UserProperties;
        private readonly TypeSymbol SourceControlProperties;
    }
}
