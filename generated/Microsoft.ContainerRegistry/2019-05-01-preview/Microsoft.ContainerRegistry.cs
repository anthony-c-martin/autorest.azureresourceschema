// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_ContainerRegistry_2019_05_01_preview
    {
        private const string ProviderNamespace = "Microsoft.ContainerRegistry";
        private const string ApiVersion = "2019-05-01-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_registries_scopeMaps = new ResourceTypeReference(ProviderNamespace, new[]{"registries", "scopeMaps"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_registries_tokens = new ResourceTypeReference(ProviderNamespace, new[]{"registries", "tokens"}, ApiVersion);
        private static Lazy<Microsoft_ContainerRegistry_2019_05_01_preview> InstanceLazy = new Lazy<Microsoft_ContainerRegistry_2019_05_01_preview>(() => new Microsoft_ContainerRegistry_2019_05_01_preview());
        private Microsoft_ContainerRegistry_2019_05_01_preview()
        {
            ScopeMapProperties = new NamedObjectType("ScopeMapProperties", new ITypeProperty[]{new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("actions", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            TokenProperties = new NamedObjectType("TokenProperties", new ITypeProperty[]{new TypeProperty("scopeMapId", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("credentials", () => TokenCredentialsProperties, TypePropertyFlags.None), new TypeProperty("status", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            TokenCredentialsProperties = new NamedObjectType("TokenCredentialsProperties", new ITypeProperty[]{new LazyTypeProperty("activeDirectoryObject", () => ActiveDirectoryObject, TypePropertyFlags.None), new TypeProperty("certificates", new TypedArrayType(new NamedObjectType("certificates", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("passwords", new TypedArrayType(new NamedObjectType("passwords", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ActiveDirectoryObject = new NamedObjectType("ActiveDirectoryObject", new ITypeProperty[]{new TypeProperty("objectId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tenantId", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            TokenCertificate = new NamedObjectType("TokenCertificate", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("expiry", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("thumbprint", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("encodedPemCertificate", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            TokenPassword = new NamedObjectType("TokenPassword", new ITypeProperty[]{new TypeProperty("creationTime", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("expiry", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_registries_scopeMaps = new ResourceType("Microsoft.ContainerRegistry/registries/scopeMaps", new ITypeProperty[]{new LazyTypeProperty("properties", () => ScopeMapProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_registries_scopeMaps);
            ResourceType_registries_tokens = new ResourceType("Microsoft.ContainerRegistry/registries/tokens", new ITypeProperty[]{new LazyTypeProperty("properties", () => TokenProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_registries_tokens);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_registries_scopeMaps, () => InstanceLazy.Value.ResourceType_registries_scopeMaps);
            registrar.RegisterType(ResourceTypeReference_registries_tokens, () => InstanceLazy.Value.ResourceType_registries_tokens);
        }
        private readonly ResourceType ResourceType_registries_scopeMaps;
        private readonly ResourceType ResourceType_registries_tokens;
        private readonly TypeSymbol ScopeMapProperties;
        private readonly TypeSymbol TokenProperties;
        private readonly TypeSymbol TokenCredentialsProperties;
        private readonly TypeSymbol ActiveDirectoryObject;
        private readonly TypeSymbol TokenCertificate;
        private readonly TypeSymbol TokenPassword;
    }
}
