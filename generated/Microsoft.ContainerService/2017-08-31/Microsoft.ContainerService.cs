// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_ContainerService_2017_08_31
    {
        private const string ProviderNamespace = "Microsoft.ContainerService";
        private const string ApiVersion = "2017-08-31";
        private static readonly ResourceTypeReference ResourceTypeReference_managedClusters = new ResourceTypeReference(ProviderNamespace, new[]{"managedClusters"}, ApiVersion);
        private static Lazy<Microsoft_ContainerService_2017_08_31> InstanceLazy = new Lazy<Microsoft_ContainerService_2017_08_31>(() => new Microsoft_ContainerService_2017_08_31());
        private Microsoft_ContainerService_2017_08_31()
        {
            ManagedClusterProperties = new NamedObjectType("ManagedClusterProperties", new ITypeProperty[]{new TypeProperty("dnsPrefix", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("kubernetesVersion", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("agentPoolProfiles", new TypedArrayType(new NamedObjectType("agentPoolProfiles", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("linuxProfile", () => ContainerServiceLinuxProfile, TypePropertyFlags.None), new LazyTypeProperty("servicePrincipalProfile", () => ContainerServiceServicePrincipalProfile, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ContainerServiceAgentPoolProfile = new NamedObjectType("ContainerServiceAgentPoolProfile", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("count", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("vmSize", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("osDiskSizeGB", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("dnsPrefix", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("ports", new TypedArrayType(LanguageConstants.Int), TypePropertyFlags.None), new TypeProperty("storageProfile", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("vnetSubnetID", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("osType", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ContainerServiceLinuxProfile = new NamedObjectType("ContainerServiceLinuxProfile", new ITypeProperty[]{new TypeProperty("adminUsername", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("ssh", () => ContainerServiceSshConfiguration, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ContainerServiceSshConfiguration = new NamedObjectType("ContainerServiceSshConfiguration", new ITypeProperty[]{new TypeProperty("publicKeys", new TypedArrayType(new NamedObjectType("publicKeys", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ContainerServiceSshPublicKey = new NamedObjectType("ContainerServiceSshPublicKey", new ITypeProperty[]{new TypeProperty("keyData", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ContainerServiceServicePrincipalProfile = new NamedObjectType("ContainerServiceServicePrincipalProfile", new ITypeProperty[]{new TypeProperty("clientId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("secret", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("keyVaultSecretRef", () => KeyVaultSecretRef, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            KeyVaultSecretRef = new NamedObjectType("KeyVaultSecretRef", new ITypeProperty[]{new TypeProperty("vaultID", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("secretName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("version", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_managedClusters = new ResourceType("Microsoft.ContainerService/managedClusters", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new LazyTypeProperty("properties", () => ManagedClusterProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_managedClusters);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_managedClusters, () => InstanceLazy.Value.ResourceType_managedClusters);
        }
        private readonly ResourceType ResourceType_managedClusters;
        private readonly TypeSymbol ManagedClusterProperties;
        private readonly TypeSymbol ContainerServiceAgentPoolProfile;
        private readonly TypeSymbol ContainerServiceLinuxProfile;
        private readonly TypeSymbol ContainerServiceSshConfiguration;
        private readonly TypeSymbol ContainerServiceSshPublicKey;
        private readonly TypeSymbol ContainerServiceServicePrincipalProfile;
        private readonly TypeSymbol KeyVaultSecretRef;
    }
}
