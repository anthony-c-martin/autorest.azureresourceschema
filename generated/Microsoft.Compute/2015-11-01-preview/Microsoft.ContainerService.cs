// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_ContainerService_2015_11_01_preview
    {
        private const string ProviderNamespace = "Microsoft.ContainerService";
        private const string ApiVersion = "2015-11-01-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_containerServices = new ResourceTypeReference(ProviderNamespace, new[]{"containerServices"}, ApiVersion);
        private static Lazy<Microsoft_ContainerService_2015_11_01_preview> InstanceLazy = new Lazy<Microsoft_ContainerService_2015_11_01_preview>(() => new Microsoft_ContainerService_2015_11_01_preview());
        private Microsoft_ContainerService_2015_11_01_preview()
        {
            ContainerServiceProperties = new NamedObjectType("ContainerServiceProperties", new ITypeProperty[]{new TypeProperty("provisioningState", LanguageConstants.String, TypePropertyFlags.ReadOnly), new LazyTypeProperty("orchestratorProfile", () => ContainerServiceOrchestratorProfile, TypePropertyFlags.None), new LazyTypeProperty("masterProfile", () => ContainerServiceMasterProfile, TypePropertyFlags.Required), new LazyTypeProperty("agentPoolProfiles", () => new TypedArrayType(ContainerServiceAgentPoolProfile), TypePropertyFlags.Required), new LazyTypeProperty("windowsProfile", () => ContainerServiceWindowsProfile, TypePropertyFlags.None), new LazyTypeProperty("linuxProfile", () => ContainerServiceLinuxProfile, TypePropertyFlags.Required), new LazyTypeProperty("diagnosticsProfile", () => ContainerServiceDiagnosticsProfile, TypePropertyFlags.None)}, null);
            ContainerServiceOrchestratorProfile = new NamedObjectType("ContainerServiceOrchestratorProfile", new ITypeProperty[]{new TypeProperty("orchestratorType", UnionType.Create(new StringLiteralType("'Mesos'"), new StringLiteralType("'SwarmPreview'"), new StringLiteralType("'DCOS'")), TypePropertyFlags.None)}, null);
            ContainerServiceMasterProfile = new NamedObjectType("ContainerServiceMasterProfile", new ITypeProperty[]{new TypeProperty("count", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("dnsPrefix", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("fqdn", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            ContainerServiceAgentPoolProfile = new NamedObjectType("ContainerServiceAgentPoolProfile", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("count", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("vmSize", UnionType.Create(new StringLiteralType("'Standard_A0'"), new StringLiteralType("'Standard_A1'"), new StringLiteralType("'Standard_A2'"), new StringLiteralType("'Standard_A3'"), new StringLiteralType("'Standard_A4'"), new StringLiteralType("'Standard_A5'"), new StringLiteralType("'Standard_A6'"), new StringLiteralType("'Standard_A7'"), new StringLiteralType("'Standard_A8'"), new StringLiteralType("'Standard_A9'"), new StringLiteralType("'Standard_A10'"), new StringLiteralType("'Standard_A11'"), new StringLiteralType("'Standard_D1'"), new StringLiteralType("'Standard_D2'"), new StringLiteralType("'Standard_D3'"), new StringLiteralType("'Standard_D4'"), new StringLiteralType("'Standard_D11'"), new StringLiteralType("'Standard_D12'"), new StringLiteralType("'Standard_D13'"), new StringLiteralType("'Standard_D14'"), new StringLiteralType("'Standard_D1_v2'"), new StringLiteralType("'Standard_D2_v2'"), new StringLiteralType("'Standard_D3_v2'"), new StringLiteralType("'Standard_D4_v2'"), new StringLiteralType("'Standard_D5_v2'"), new StringLiteralType("'Standard_D11_v2'"), new StringLiteralType("'Standard_D12_v2'"), new StringLiteralType("'Standard_D13_v2'"), new StringLiteralType("'Standard_D14_v2'"), new StringLiteralType("'Standard_G1'"), new StringLiteralType("'Standard_G2'"), new StringLiteralType("'Standard_G3'"), new StringLiteralType("'Standard_G4'"), new StringLiteralType("'Standard_G5'"), new StringLiteralType("'Standard_DS1'"), new StringLiteralType("'Standard_DS2'"), new StringLiteralType("'Standard_DS3'"), new StringLiteralType("'Standard_DS4'"), new StringLiteralType("'Standard_DS11'"), new StringLiteralType("'Standard_DS12'"), new StringLiteralType("'Standard_DS13'"), new StringLiteralType("'Standard_DS14'"), new StringLiteralType("'Standard_GS1'"), new StringLiteralType("'Standard_GS2'"), new StringLiteralType("'Standard_GS3'"), new StringLiteralType("'Standard_GS4'"), new StringLiteralType("'Standard_GS5'")), TypePropertyFlags.None), new TypeProperty("dnsPrefix", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("fqdn", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            ContainerServiceWindowsProfile = new NamedObjectType("ContainerServiceWindowsProfile", new ITypeProperty[]{new TypeProperty("adminUsername", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("adminPassword", LanguageConstants.String, TypePropertyFlags.Required)}, null);
            ContainerServiceLinuxProfile = new NamedObjectType("ContainerServiceLinuxProfile", new ITypeProperty[]{new TypeProperty("adminUsername", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("ssh", () => ContainerServiceSshConfiguration, TypePropertyFlags.Required)}, null);
            ContainerServiceSshConfiguration = new NamedObjectType("ContainerServiceSshConfiguration", new ITypeProperty[]{new LazyTypeProperty("publicKeys", () => new TypedArrayType(ContainerServiceSshPublicKey), TypePropertyFlags.None)}, null);
            ContainerServiceSshPublicKey = new NamedObjectType("ContainerServiceSshPublicKey", new ITypeProperty[]{new TypeProperty("keyData", LanguageConstants.String, TypePropertyFlags.Required)}, null);
            ContainerServiceDiagnosticsProfile = new NamedObjectType("ContainerServiceDiagnosticsProfile", new ITypeProperty[]{new LazyTypeProperty("vmDiagnostics", () => ContainerServiceVMDiagnostics, TypePropertyFlags.None)}, null);
            ContainerServiceVMDiagnostics = new NamedObjectType("ContainerServiceVMDiagnostics", new ITypeProperty[]{new TypeProperty("enabled", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("storageUri", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            ResourceType_containerServices = new ResourceType("Microsoft.ContainerService/containerServices", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.ContainerService/containerServices'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("properties", () => ContainerServiceProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2015-11-01-preview'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_containerServices);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_containerServices, () => InstanceLazy.Value.ResourceType_containerServices);
        }
        private readonly ResourceType ResourceType_containerServices;
        private readonly TypeSymbol ContainerServiceProperties;
        private readonly TypeSymbol ContainerServiceOrchestratorProfile;
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