// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_ServiceFabricMesh_2018_07_01_preview
    {
        private const string ProviderNamespace = "Microsoft.ServiceFabricMesh";
        private const string ApiVersion = "2018-07-01-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_applications = new ResourceTypeReference(ProviderNamespace, new[]{"applications"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_networks = new ResourceTypeReference(ProviderNamespace, new[]{"networks"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_volumes = new ResourceTypeReference(ProviderNamespace, new[]{"volumes"}, ApiVersion);
        private static Lazy<Microsoft_ServiceFabricMesh_2018_07_01_preview> InstanceLazy = new Lazy<Microsoft_ServiceFabricMesh_2018_07_01_preview>(() => new Microsoft_ServiceFabricMesh_2018_07_01_preview());
        private Microsoft_ServiceFabricMesh_2018_07_01_preview()
        {
            ApplicationResourceProperties = new NamedObjectType("ApplicationResourceProperties", new ITypeProperty[]{new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("debugParams", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("services", LanguageConstants.Array, TypePropertyFlags.None), new LazyTypeProperty("diagnostics", () => DiagnosticsDescription, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ServiceResourceDescription = new NamedObjectType("ServiceResourceDescription", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("properties", () => ServiceResourceProperties, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ServiceResourceProperties = new NamedObjectType("ServiceResourceProperties", new ITypeProperty[]{new TypeProperty("osType", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("codePackages", LanguageConstants.Array, TypePropertyFlags.Required), new TypeProperty("networkRefs", LanguageConstants.Array, TypePropertyFlags.None), new LazyTypeProperty("diagnostics", () => DiagnosticsRef, TypePropertyFlags.None), new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("replicaCount", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("healthState", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ContainerCodePackageProperties = new NamedObjectType("ContainerCodePackageProperties", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("image", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("imageRegistryCredential", () => ImageRegistryCredential, TypePropertyFlags.None), new TypeProperty("entrypoint", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("commands", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("environmentVariables", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("settings", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("labels", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("endpoints", LanguageConstants.Array, TypePropertyFlags.None), new LazyTypeProperty("resources", () => ResourceRequirements, TypePropertyFlags.Required), new TypeProperty("volumeRefs", LanguageConstants.Array, TypePropertyFlags.None), new LazyTypeProperty("diagnostics", () => DiagnosticsRef, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ImageRegistryCredential = new NamedObjectType("ImageRegistryCredential", new ITypeProperty[]{new TypeProperty("server", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("username", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("password", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            EnvironmentVariable = new NamedObjectType("EnvironmentVariable", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("value", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            Setting = new NamedObjectType("Setting", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("value", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ContainerLabel = new NamedObjectType("ContainerLabel", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("value", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            EndpointProperties = new NamedObjectType("EndpointProperties", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("port", LanguageConstants.Int, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceRequirements = new NamedObjectType("ResourceRequirements", new ITypeProperty[]{new LazyTypeProperty("requests", () => ResourceRequests, TypePropertyFlags.Required), new LazyTypeProperty("limits", () => ResourceLimits, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceRequests = new NamedObjectType("ResourceRequests", new ITypeProperty[]{new TypeProperty("memoryInGB", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("cpu", LanguageConstants.Int, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ResourceLimits = new NamedObjectType("ResourceLimits", new ITypeProperty[]{new TypeProperty("memoryInGB", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("cpu", LanguageConstants.Int, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ContainerVolume = new NamedObjectType("ContainerVolume", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("readOnly", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("destinationPath", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            DiagnosticsRef = new NamedObjectType("DiagnosticsRef", new ITypeProperty[]{new TypeProperty("enabled", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("sinkRefs", LanguageConstants.Array, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            NetworkRef = new NamedObjectType("NetworkRef", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            DiagnosticsDescription = new NamedObjectType("DiagnosticsDescription", new ITypeProperty[]{new TypeProperty("sinks", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("enabled", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("defaultSinkRefs", LanguageConstants.Array, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            DiagnosticsSinkProperties = new NamedObjectType("DiagnosticsSinkProperties", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            AzureInternalMonitoringPipelineSinkDescription = new NamedObjectType("AzureInternalMonitoringPipelineSinkDescription", new ITypeProperty[]{new TypeProperty("accountName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("namespace", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("maConfigUrl", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("fluentdConfigUrl", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("autoKeyConfigUrl", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            NetworkResourceProperties = new NamedObjectType("NetworkResourceProperties", new ITypeProperty[]{new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("addressPrefix", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("ingressConfig", () => IngressConfig, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            IngressConfig = new NamedObjectType("IngressConfig", new ITypeProperty[]{new TypeProperty("qosLevel", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("layer4", LanguageConstants.Array, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            Layer4IngressConfig = new NamedObjectType("Layer4IngressConfig", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("publicPort", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("applicationName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("serviceName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("endpointName", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            VolumeResourceProperties = new NamedObjectType("VolumeResourceProperties", new ITypeProperty[]{new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("provider", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("azureFileParameters", () => VolumeProviderParametersAzureFile, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            VolumeProviderParametersAzureFile = new NamedObjectType("VolumeProviderParametersAzureFile", new ITypeProperty[]{new TypeProperty("accountName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("accountKey", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("shareName", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ResourceType_applications = new ResourceType("Microsoft.ServiceFabricMesh/applications", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("properties", () => ApplicationResourceProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_applications);
            ResourceType_networks = new ResourceType("Microsoft.ServiceFabricMesh/networks", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("properties", () => NetworkResourceProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_networks);
            ResourceType_volumes = new ResourceType("Microsoft.ServiceFabricMesh/volumes", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("properties", () => VolumeResourceProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_volumes);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_applications, () => InstanceLazy.Value.ResourceType_applications);
            registrar.RegisterType(ResourceTypeReference_networks, () => InstanceLazy.Value.ResourceType_networks);
            registrar.RegisterType(ResourceTypeReference_volumes, () => InstanceLazy.Value.ResourceType_volumes);
        }
        private readonly ResourceType ResourceType_applications;
        private readonly ResourceType ResourceType_networks;
        private readonly ResourceType ResourceType_volumes;
        private readonly TypeSymbol ApplicationResourceProperties;
        private readonly TypeSymbol ServiceResourceDescription;
        private readonly TypeSymbol ServiceResourceProperties;
        private readonly TypeSymbol ContainerCodePackageProperties;
        private readonly TypeSymbol ImageRegistryCredential;
        private readonly TypeSymbol EnvironmentVariable;
        private readonly TypeSymbol Setting;
        private readonly TypeSymbol ContainerLabel;
        private readonly TypeSymbol EndpointProperties;
        private readonly TypeSymbol ResourceRequirements;
        private readonly TypeSymbol ResourceRequests;
        private readonly TypeSymbol ResourceLimits;
        private readonly TypeSymbol ContainerVolume;
        private readonly TypeSymbol DiagnosticsRef;
        private readonly TypeSymbol NetworkRef;
        private readonly TypeSymbol DiagnosticsDescription;
        private readonly TypeSymbol DiagnosticsSinkProperties;
        private readonly TypeSymbol AzureInternalMonitoringPipelineSinkDescription;
        private readonly TypeSymbol NetworkResourceProperties;
        private readonly TypeSymbol IngressConfig;
        private readonly TypeSymbol Layer4IngressConfig;
        private readonly TypeSymbol VolumeResourceProperties;
        private readonly TypeSymbol VolumeProviderParametersAzureFile;
    }
}
