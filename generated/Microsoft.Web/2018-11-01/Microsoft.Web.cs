// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_Web_2018_11_01
    {
        private const string ProviderNamespace = "Microsoft.Web";
        private const string ApiVersion = "2018-11-01";
        private static readonly ResourceTypeReference ResourceTypeReference_certificates = new ResourceTypeReference(ProviderNamespace, new[]{"certificates"}, ApiVersion);
        private static Lazy<Microsoft_Web_2018_11_01> InstanceLazy = new Lazy<Microsoft_Web_2018_11_01>(() => new Microsoft_Web_2018_11_01());
        private Microsoft_Web_2018_11_01()
        {
            CertificateProperties = new NamedObjectType("CertificateProperties", new ITypeProperty[]{new TypeProperty("hostNames", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("pfxBlob", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("password", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("keyVaultId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("keyVaultSecretName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("serverFarmId", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_certificates = new ResourceType("Microsoft.Web/certificates", new ITypeProperty[]{new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("properties", () => CertificateProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_certificates);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_certificates, () => InstanceLazy.Value.ResourceType_certificates);
        }
        private readonly ResourceType ResourceType_certificates;
        private readonly TypeSymbol CertificateProperties;
    }
}
