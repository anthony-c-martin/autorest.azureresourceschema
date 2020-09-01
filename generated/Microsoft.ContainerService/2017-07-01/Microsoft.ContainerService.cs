// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_ContainerService_2017_07_01
    {
        private const string ProviderNamespace = "Microsoft.ContainerService";
        private const string ApiVersion = "2017-07-01";
        private static readonly ResourceTypeReference ResourceTypeReference_containerServices = new ResourceTypeReference(ProviderNamespace, new[]{"containerServices"}, ApiVersion);
        private static Lazy<Microsoft_ContainerService_2017_07_01> InstanceLazy = new Lazy<Microsoft_ContainerService_2017_07_01>(() => new Microsoft_ContainerService_2017_07_01());
        private Microsoft_ContainerService_2017_07_01()
        {
            ContainerServiceProperties = new NamedObjectType("ContainerServiceProperties", new ITypeProperty[]{new LazyTypeProperty("orchestratorProfile", () => ContainerServiceOrchestratorProfile, TypePropertyFlags.Required), new LazyTypeProperty("customProfile", () => ContainerServiceCustomProfile, TypePropertyFlags.None), new LazyTypeProperty("servicePrincipalProfile", () => ContainerServiceServicePrincipalProfile, TypePropertyFlags.None), new LazyTypeProperty("masterProfile", () => ContainerServiceMasterProfile, TypePropertyFlags.Required), new TypeProperty("agentPoolProfiles", new TypedArrayType(new NamedObjectType("agentPoolProfiles", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("windowsProfile", () => ContainerServiceWindowsProfile, TypePropertyFlags.None), new LazyTypeProperty("linuxProfile", () => ContainerServiceLinuxProfile, TypePropertyFlags.Required), new LazyTypeProperty("diagnosticsProfile", () => ContainerServiceDiagnosticsProfile, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ContainerServiceOrchestratorProfile = new NamedObjectType("ContainerServiceOrchestratorProfile", new ITypeProperty[]{new TypeProperty("orchestratorType", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("orchestratorVersion", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ContainerServiceCustomProfile = new NamedObjectType("ContainerServiceCustomProfile", new ITypeProperty[]{new TypeProperty("orchestrator", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ContainerServiceServicePrincipalProfile = new NamedObjectType("ContainerServiceServicePrincipalProfile", new ITypeProperty[]{new TypeProperty("clientId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("secret", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("keyVaultSecretRef", () => KeyVaultSecretRef, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            KeyVaultSecretRef = new NamedObjectType("KeyVaultSecretRef", new ITypeProperty[]{new TypeProperty("vaultID", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("secretName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("version", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ContainerServiceMasterProfile = new NamedObjectType("ContainerServiceMasterProfile", new ITypeProperty[]{new TypeProperty("count", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("dnsPrefix", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("vmSize", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("osDiskSizeGB", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("vnetSubnetID", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("firstConsecutiveStaticIP", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("storageProfile", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ContainerServiceAgentPoolProfile = new NamedObjectType("ContainerServiceAgentPoolProfile", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("count", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("vmSize", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("osDiskSizeGB", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("dnsPrefix", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("ports", new TypedArrayType(LanguageConstants.Int), TypePropertyFlags.None), new TypeProperty("storageProfile", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("vnetSubnetID", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("osType", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ContainerServiceWindowsProfile = new NamedObjectType("ContainerServiceWindowsProfile", new ITypeProperty[]{new TypeProperty("adminUsername", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("adminPassword", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ContainerServiceLinuxProfile = new NamedObjectType("ContainerServiceLinuxProfile", new ITypeProperty[]{new TypeProperty("adminUsername", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("ssh", () => ContainerServiceSshConfiguration, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ContainerServiceSshConfiguration = new NamedObjectType("ContainerServiceSshConfiguration", new ITypeProperty[]{new TypeProperty("publicKeys", new TypedArrayType(new NamedObjectType("publicKeys", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ContainerServiceSshPublicKey = new NamedObjectType("ContainerServiceSshPublicKey", new ITypeProperty[]{new TypeProperty("keyData", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ContainerServiceDiagnosticsProfile = new NamedObjectType("ContainerServiceDiagnosticsProfile", new ITypeProperty[]{new LazyTypeProperty("vmDiagnostics", () => ContainerServiceVMDiagnostics, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ContainerServiceVMDiagnostics = new NamedObjectType("ContainerServiceVMDiagnostics", new ITypeProperty[]{new TypeProperty("enabled", LanguageConstants.Bool, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ResourceType_containerServices = new ResourceType("Microsoft.ContainerService/containerServices", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new LazyTypeProperty("properties", () => ContainerServiceProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_containerServices);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_containerServices, () => InstanceLazy.Value.ResourceType_containerServices);
        }
        private readonly ResourceType ResourceType_containerServices;
        private readonly TypeSymbol ContainerServiceProperties;
        private readonly TypeSymbol ContainerServiceOrchestratorProfile;
        private readonly TypeSymbol ContainerServiceCustomProfile;
        private readonly TypeSymbol ContainerServiceServicePrincipalProfile;
        private readonly TypeSymbol KeyVaultSecretRef;
        private readonly TypeSymbol ContainerServiceMasterProfile;
        private readonly TypeSymbol ContainerServiceAgentPoolProfile;
        private readonly TypeSymbol ContainerServiceWindowsProfile;
        private readonly TypeSymbol ContainerServiceLinuxProfile;
        private readonly TypeSymbol ContainerServiceSshConfiguration;
        private readonly TypeSymbol ContainerServiceSshPublicKey;
        private readonly TypeSymbol ContainerServiceDiagnosticsProfile;
        private readonly TypeSymbol ContainerServiceVMDiagnostics;
    }
}
