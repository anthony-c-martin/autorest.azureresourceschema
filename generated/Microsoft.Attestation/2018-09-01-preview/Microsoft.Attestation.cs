// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_Attestation_2018_09_01_preview
    {
        private const string ProviderNamespace = "Microsoft.Attestation";
        private const string ApiVersion = "2018-09-01-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_attestationProviders = new ResourceTypeReference(ProviderNamespace, new[]{"attestationProviders"}, ApiVersion);
        private static Lazy<Microsoft_Attestation_2018_09_01_preview> InstanceLazy = new Lazy<Microsoft_Attestation_2018_09_01_preview>(() => new Microsoft_Attestation_2018_09_01_preview());
        private Microsoft_Attestation_2018_09_01_preview()
        {
            AttestationServiceCreationSpecificParams = new NamedObjectType("AttestationServiceCreationSpecificParams", new ITypeProperty[]{new TypeProperty("attestationPolicy", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("policySigningCertificates", () => JSONWebKeySet, TypePropertyFlags.None)}, null);
            JSONWebKeySet = new NamedObjectType("JSONWebKeySet", new ITypeProperty[]{new LazyTypeProperty("keys", () => new TypedArrayType(JSONWebKey), TypePropertyFlags.None)}, null);
            JSONWebKey = new NamedObjectType("JSONWebKey", new ITypeProperty[]{new TypeProperty("alg", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("crv", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("d", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("dp", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("dq", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("e", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("k", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("kid", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("kty", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("n", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("p", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("q", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("qi", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("use", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("x", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("x5c", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new TypeProperty("y", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ResourceType_attestationProviders = new ResourceType("Microsoft.Attestation/attestationProviders", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("properties", () => AttestationServiceCreationSpecificParams, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.Attestation/attestationProviders'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", new StringLiteralType("'2018-09-01-preview'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_attestationProviders);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_attestationProviders, () => InstanceLazy.Value.ResourceType_attestationProviders);
        }
        private readonly ResourceType ResourceType_attestationProviders;
        private readonly TypeSymbol AttestationServiceCreationSpecificParams;
        private readonly TypeSymbol JSONWebKeySet;
        private readonly TypeSymbol JSONWebKey;
    }
}
