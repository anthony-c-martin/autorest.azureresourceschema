// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_ContainerInstance_2019_12_01
    {
        private const string ProviderNamespace = "Microsoft.ContainerInstance";
        private const string ApiVersion = "2019-12-01";
        private static readonly ResourceTypeReference ResourceTypeReference_containerGroups = new ResourceTypeReference(ProviderNamespace, new[]{"containerGroups"}, ApiVersion);
        private static Lazy<Microsoft_ContainerInstance_2019_12_01> InstanceLazy = new Lazy<Microsoft_ContainerInstance_2019_12_01>(() => new Microsoft_ContainerInstance_2019_12_01());
        private Microsoft_ContainerInstance_2019_12_01()
        {
            ContainerGroupIdentity = new NamedObjectType("ContainerGroupIdentity", new ITypeProperty[]{new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("userAssignedIdentities", new NamedObjectType("userAssignedIdentities", new ITypeProperty[]{}, new NamedObjectType("additionalProperties", new ITypeProperty[]{}, null, TypePropertyFlags.None), TypePropertyFlags.None), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            Components10wh5udschemascontainergroupidentitypropertiesuserassignedidentitiesadditionalproperties = new NamedObjectType("Components10wh5udschemascontainergroupidentitypropertiesuserassignedidentitiesadditionalproperties", new ITypeProperty[]{}, null, TypePropertyFlags.None);
            ContainerGroupProperties = new NamedObjectType("ContainerGroupProperties", new ITypeProperty[]{new TypeProperty("containers", new TypedArrayType(new NamedObjectType("containers", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.Required), new TypeProperty("imageRegistryCredentials", new TypedArrayType(new NamedObjectType("imageRegistryCredentials", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("restartPolicy", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("ipAddress", () => IpAddress, TypePropertyFlags.None), new TypeProperty("osType", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("volumes", new TypedArrayType(new NamedObjectType("volumes", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("diagnostics", () => ContainerGroupDiagnostics, TypePropertyFlags.None), new LazyTypeProperty("networkProfile", () => ContainerGroupNetworkProfile, TypePropertyFlags.None), new LazyTypeProperty("dnsConfig", () => DnsConfiguration, TypePropertyFlags.None), new TypeProperty("sku", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("encryptionProperties", () => EncryptionProperties, TypePropertyFlags.None), new TypeProperty("initContainers", new TypedArrayType(new NamedObjectType("initContainers", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            Container = new NamedObjectType("Container", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => ContainerProperties, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ContainerProperties = new NamedObjectType("ContainerProperties", new ITypeProperty[]{new TypeProperty("image", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("command", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new TypeProperty("ports", new TypedArrayType(new NamedObjectType("ports", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("environmentVariables", new TypedArrayType(new NamedObjectType("environmentVariables", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("resources", () => ResourceRequirements, TypePropertyFlags.Required), new TypeProperty("volumeMounts", new TypedArrayType(new NamedObjectType("volumeMounts", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("livenessProbe", () => ContainerProbe, TypePropertyFlags.None), new LazyTypeProperty("readinessProbe", () => ContainerProbe, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ContainerPort = new NamedObjectType("ContainerPort", new ITypeProperty[]{new TypeProperty("protocol", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("port", LanguageConstants.Int, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            EnvironmentVariable = new NamedObjectType("EnvironmentVariable", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("value", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("secureValue", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceRequirements = new NamedObjectType("ResourceRequirements", new ITypeProperty[]{new LazyTypeProperty("requests", () => ResourceRequests, TypePropertyFlags.Required), new LazyTypeProperty("limits", () => ResourceLimits, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceRequests = new NamedObjectType("ResourceRequests", new ITypeProperty[]{new TypeProperty("memoryInGB", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("cpu", LanguageConstants.Int, TypePropertyFlags.Required), new LazyTypeProperty("gpu", () => GpuResource, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            GpuResource = new NamedObjectType("GpuResource", new ITypeProperty[]{new TypeProperty("count", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("sku", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ResourceLimits = new NamedObjectType("ResourceLimits", new ITypeProperty[]{new TypeProperty("memoryInGB", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("cpu", LanguageConstants.Int, TypePropertyFlags.None), new LazyTypeProperty("gpu", () => GpuResource, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            VolumeMount = new NamedObjectType("VolumeMount", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("mountPath", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("readOnly", LanguageConstants.Bool, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ContainerProbe = new NamedObjectType("ContainerProbe", new ITypeProperty[]{new LazyTypeProperty("exec", () => ContainerExec, TypePropertyFlags.None), new LazyTypeProperty("httpGet", () => ContainerHttpGet, TypePropertyFlags.None), new TypeProperty("initialDelaySeconds", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("periodSeconds", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("failureThreshold", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("successThreshold", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("timeoutSeconds", LanguageConstants.Int, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ContainerExec = new NamedObjectType("ContainerExec", new ITypeProperty[]{new TypeProperty("command", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ContainerHttpGet = new NamedObjectType("ContainerHttpGet", new ITypeProperty[]{new TypeProperty("path", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("port", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("scheme", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ImageRegistryCredential = new NamedObjectType("ImageRegistryCredential", new ITypeProperty[]{new TypeProperty("server", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("username", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("password", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            IpAddress = new NamedObjectType("IpAddress", new ITypeProperty[]{new TypeProperty("ports", new TypedArrayType(new NamedObjectType("ports", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("ip", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("dnsNameLabel", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            Port = new NamedObjectType("Port", new ITypeProperty[]{new TypeProperty("protocol", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("port", LanguageConstants.Int, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            Volume = new NamedObjectType("Volume", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("azureFile", () => AzureFileVolume, TypePropertyFlags.None), new TypeProperty("emptyDir", new NamedObjectType("emptyDir", new ITypeProperty[]{}, null, TypePropertyFlags.None), TypePropertyFlags.None), new TypeProperty("secret", new NamedObjectType("secret", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new LazyTypeProperty("gitRepo", () => GitRepoVolume, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            AzureFileVolume = new NamedObjectType("AzureFileVolume", new ITypeProperty[]{new TypeProperty("shareName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("readOnly", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("storageAccountName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("storageAccountKey", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            GitRepoVolume = new NamedObjectType("GitRepoVolume", new ITypeProperty[]{new TypeProperty("directory", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("repository", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("revision", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ContainerGroupDiagnostics = new NamedObjectType("ContainerGroupDiagnostics", new ITypeProperty[]{new LazyTypeProperty("logAnalytics", () => LogAnalytics, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            LogAnalytics = new NamedObjectType("LogAnalytics", new ITypeProperty[]{new TypeProperty("workspaceId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("workspaceKey", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("logType", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("metadata", new NamedObjectType("metadata", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ContainerGroupNetworkProfile = new NamedObjectType("ContainerGroupNetworkProfile", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            DnsConfiguration = new NamedObjectType("DnsConfiguration", new ITypeProperty[]{new TypeProperty("nameServers", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.Required), new TypeProperty("searchDomains", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("options", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            EncryptionProperties = new NamedObjectType("EncryptionProperties", new ITypeProperty[]{new TypeProperty("vaultBaseUrl", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("keyName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("keyVersion", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            InitContainerDefinition = new NamedObjectType("InitContainerDefinition", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => InitContainerPropertiesDefinition, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            InitContainerPropertiesDefinition = new NamedObjectType("InitContainerPropertiesDefinition", new ITypeProperty[]{new TypeProperty("image", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("command", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new TypeProperty("environmentVariables", new TypedArrayType(new NamedObjectType("environmentVariables", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("volumeMounts", new TypedArrayType(new NamedObjectType("volumeMounts", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_containerGroups = new ResourceType("Microsoft.ContainerInstance/containerGroups", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new LazyTypeProperty("identity", () => ContainerGroupIdentity, TypePropertyFlags.None), new LazyTypeProperty("properties", () => ContainerGroupProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_containerGroups);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_containerGroups, () => InstanceLazy.Value.ResourceType_containerGroups);
        }
        private readonly ResourceType ResourceType_containerGroups;
        private readonly TypeSymbol ContainerGroupIdentity;
        private readonly TypeSymbol Components10wh5udschemascontainergroupidentitypropertiesuserassignedidentitiesadditionalproperties;
        private readonly TypeSymbol ContainerGroupProperties;
        private readonly TypeSymbol Container;
        private readonly TypeSymbol ContainerProperties;
        private readonly TypeSymbol ContainerPort;
        private readonly TypeSymbol EnvironmentVariable;
        private readonly TypeSymbol ResourceRequirements;
        private readonly TypeSymbol ResourceRequests;
        private readonly TypeSymbol GpuResource;
        private readonly TypeSymbol ResourceLimits;
        private readonly TypeSymbol VolumeMount;
        private readonly TypeSymbol ContainerProbe;
        private readonly TypeSymbol ContainerExec;
        private readonly TypeSymbol ContainerHttpGet;
        private readonly TypeSymbol ImageRegistryCredential;
        private readonly TypeSymbol IpAddress;
        private readonly TypeSymbol Port;
        private readonly TypeSymbol Volume;
        private readonly TypeSymbol AzureFileVolume;
        private readonly TypeSymbol GitRepoVolume;
        private readonly TypeSymbol ContainerGroupDiagnostics;
        private readonly TypeSymbol LogAnalytics;
        private readonly TypeSymbol ContainerGroupNetworkProfile;
        private readonly TypeSymbol DnsConfiguration;
        private readonly TypeSymbol EncryptionProperties;
        private readonly TypeSymbol InitContainerDefinition;
        private readonly TypeSymbol InitContainerPropertiesDefinition;
    }
}