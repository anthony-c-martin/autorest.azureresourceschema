// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_ServiceFabricMesh_2018_09_01_preview
    {
        private const string ProviderNamespace = "Microsoft.ServiceFabricMesh";
        private const string ApiVersion = "2018-09-01-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_secrets = new ResourceTypeReference(ProviderNamespace, new[]{"secrets"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_volumes = new ResourceTypeReference(ProviderNamespace, new[]{"volumes"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_networks = new ResourceTypeReference(ProviderNamespace, new[]{"networks"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_gateways = new ResourceTypeReference(ProviderNamespace, new[]{"gateways"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_applications = new ResourceTypeReference(ProviderNamespace, new[]{"applications"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_secrets_values = new ResourceTypeReference(ProviderNamespace, new[]{"secrets", "values"}, ApiVersion);
        private static Lazy<Microsoft_ServiceFabricMesh_2018_09_01_preview> InstanceLazy = new Lazy<Microsoft_ServiceFabricMesh_2018_09_01_preview>(() => new Microsoft_ServiceFabricMesh_2018_09_01_preview());
        private Microsoft_ServiceFabricMesh_2018_09_01_preview()
        {
            SecretResourceProperties = new NamedObjectType("SecretResourceProperties", new ITypeProperty[]{new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("contentType", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            InlinedValueSecretResourceProperties = new NamedObjectType("InlinedValueSecretResourceProperties", new ITypeProperty[]{new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            SecretValueResourceProperties = new NamedObjectType("SecretValueResourceProperties", new ITypeProperty[]{new TypeProperty("value", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            VolumeResourceProperties = new NamedObjectType("VolumeResourceProperties", new ITypeProperty[]{new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("provider", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("azureFileParameters", () => VolumeProviderParametersAzureFile, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            VolumeProviderParametersAzureFile = new NamedObjectType("VolumeProviderParametersAzureFile", new ITypeProperty[]{new TypeProperty("accountName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("accountKey", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("shareName", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            NetworkResourceProperties = new NamedObjectType("NetworkResourceProperties", new ITypeProperty[]{new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            LocalNetworkResourceProperties = new NamedObjectType("LocalNetworkResourceProperties", new ITypeProperty[]{new TypeProperty("networkAddressPrefix", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            GatewayResourceProperties = new NamedObjectType("GatewayResourceProperties", new ITypeProperty[]{new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("sourceNetwork", () => NetworkRef, TypePropertyFlags.Required), new LazyTypeProperty("destinationNetwork", () => NetworkRef, TypePropertyFlags.Required), new TypeProperty("tcp", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("http", LanguageConstants.Array, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            NetworkRef = new NamedObjectType("NetworkRef", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("endpointRefs", LanguageConstants.Array, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            EndpointRef = new NamedObjectType("EndpointRef", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            TcpConfig = new NamedObjectType("TcpConfig", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("port", LanguageConstants.Int, TypePropertyFlags.Required), new LazyTypeProperty("destination", () => GatewayDestination, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            GatewayDestination = new NamedObjectType("GatewayDestination", new ITypeProperty[]{new TypeProperty("applicationName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("serviceName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("endpointName", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            HttpConfig = new NamedObjectType("HttpConfig", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("port", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("hosts", LanguageConstants.Array, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            HttpHostConfig = new NamedObjectType("HttpHostConfig", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("routes", LanguageConstants.Array, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            HttpRouteConfig = new NamedObjectType("HttpRouteConfig", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("match", () => HttpRouteMatchRule, TypePropertyFlags.Required), new LazyTypeProperty("destination", () => GatewayDestination, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            HttpRouteMatchRule = new NamedObjectType("HttpRouteMatchRule", new ITypeProperty[]{new LazyTypeProperty("path", () => HttpRouteMatchPath, TypePropertyFlags.Required), new TypeProperty("headers", LanguageConstants.Array, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            HttpRouteMatchPath = new NamedObjectType("HttpRouteMatchPath", new ITypeProperty[]{new TypeProperty("value", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("rewrite", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            HttpRouteMatchHeader = new NamedObjectType("HttpRouteMatchHeader", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("value", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ApplicationResourceProperties = new NamedObjectType("ApplicationResourceProperties", new ITypeProperty[]{new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("services", LanguageConstants.Array, TypePropertyFlags.None), new LazyTypeProperty("diagnostics", () => DiagnosticsDescription, TypePropertyFlags.None), new TypeProperty("debugParams", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ServiceResourceDescription = new NamedObjectType("ServiceResourceDescription", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("properties", () => ServiceResourceProperties, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ServiceResourceProperties = new NamedObjectType("ServiceResourceProperties", new ITypeProperty[]{new TypeProperty("osType", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("codePackages", LanguageConstants.Array, TypePropertyFlags.Required), new TypeProperty("networkRefs", LanguageConstants.Array, TypePropertyFlags.None), new LazyTypeProperty("diagnostics", () => DiagnosticsRef, TypePropertyFlags.None), new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("replicaCount", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("autoScalingPolicies", LanguageConstants.Array, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ContainerCodePackageProperties = new NamedObjectType("ContainerCodePackageProperties", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("image", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("imageRegistryCredential", () => ImageRegistryCredential, TypePropertyFlags.None), new TypeProperty("entrypoint", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("commands", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("environmentVariables", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("settings", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("labels", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("endpoints", LanguageConstants.Array, TypePropertyFlags.None), new LazyTypeProperty("resources", () => ResourceRequirements, TypePropertyFlags.Required), new TypeProperty("volumeRefs", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("volumes", LanguageConstants.Array, TypePropertyFlags.None), new LazyTypeProperty("diagnostics", () => DiagnosticsRef, TypePropertyFlags.None), new TypeProperty("reliableCollectionsRefs", LanguageConstants.Array, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ImageRegistryCredential = new NamedObjectType("ImageRegistryCredential", new ITypeProperty[]{new TypeProperty("server", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("username", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("password", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            EnvironmentVariable = new NamedObjectType("EnvironmentVariable", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("value", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            Setting = new NamedObjectType("Setting", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("value", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ContainerLabel = new NamedObjectType("ContainerLabel", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("value", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            EndpointProperties = new NamedObjectType("EndpointProperties", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("port", LanguageConstants.Int, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceRequirements = new NamedObjectType("ResourceRequirements", new ITypeProperty[]{new LazyTypeProperty("requests", () => ResourceRequests, TypePropertyFlags.Required), new LazyTypeProperty("limits", () => ResourceLimits, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceRequests = new NamedObjectType("ResourceRequests", new ITypeProperty[]{new TypeProperty("memoryInGB", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("cpu", LanguageConstants.Int, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ResourceLimits = new NamedObjectType("ResourceLimits", new ITypeProperty[]{new TypeProperty("memoryInGB", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("cpu", LanguageConstants.Int, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            VolumeReference = new NamedObjectType("VolumeReference", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("readOnly", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("destinationPath", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ApplicationScopedVolume = new NamedObjectType("ApplicationScopedVolume", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("readOnly", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("destinationPath", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("creationParameters", () => ApplicationScopedVolumeCreationParameters, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ApplicationScopedVolumeCreationParameters = new NamedObjectType("ApplicationScopedVolumeCreationParameters", new ITypeProperty[]{new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ApplicationScopedVolumeCreationParametersServiceFabricVolumeDisk = new NamedObjectType("ApplicationScopedVolumeCreationParametersServiceFabricVolumeDisk", new ITypeProperty[]{new TypeProperty("sizeDisk", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            DiagnosticsRef = new NamedObjectType("DiagnosticsRef", new ITypeProperty[]{new TypeProperty("enabled", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("sinkRefs", LanguageConstants.Array, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ReliableCollectionsRef = new NamedObjectType("ReliableCollectionsRef", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("doNotPersistState", LanguageConstants.Bool, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            AutoScalingPolicy = new NamedObjectType("AutoScalingPolicy", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("trigger", () => AutoScalingTrigger, TypePropertyFlags.Required), new LazyTypeProperty("mechanism", () => AutoScalingMechanism, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            AutoScalingTrigger = new NamedObjectType("AutoScalingTrigger", new ITypeProperty[]{}, null, TypePropertyFlags.None);
            AutoScalingMechanism = new NamedObjectType("AutoScalingMechanism", new ITypeProperty[]{}, null, TypePropertyFlags.None);
            DiagnosticsDescription = new NamedObjectType("DiagnosticsDescription", new ITypeProperty[]{new TypeProperty("sinks", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("enabled", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("defaultSinkRefs", LanguageConstants.Array, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            DiagnosticsSinkProperties = new NamedObjectType("DiagnosticsSinkProperties", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            AzureInternalMonitoringPipelineSinkDescription = new NamedObjectType("AzureInternalMonitoringPipelineSinkDescription", new ITypeProperty[]{new TypeProperty("accountName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("namespace", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("maConfigUrl", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("fluentdConfigUrl", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("autoKeyConfigUrl", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ResourceType_secrets = new ResourceType("Microsoft.ServiceFabricMesh/secrets", new ITypeProperty[]{new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => SecretResourceProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_secrets);
            ResourceType_volumes = new ResourceType("Microsoft.ServiceFabricMesh/volumes", new ITypeProperty[]{new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => VolumeResourceProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_volumes);
            ResourceType_networks = new ResourceType("Microsoft.ServiceFabricMesh/networks", new ITypeProperty[]{new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => NetworkResourceProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_networks);
            ResourceType_gateways = new ResourceType("Microsoft.ServiceFabricMesh/gateways", new ITypeProperty[]{new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => GatewayResourceProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_gateways);
            ResourceType_applications = new ResourceType("Microsoft.ServiceFabricMesh/applications", new ITypeProperty[]{new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => ApplicationResourceProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_applications);
            ResourceType_secrets_values = new ResourceType("Microsoft.ServiceFabricMesh/secrets/values", new ITypeProperty[]{new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => SecretValueResourceProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_secrets_values);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_secrets, () => InstanceLazy.Value.ResourceType_secrets);
            registrar.RegisterType(ResourceTypeReference_volumes, () => InstanceLazy.Value.ResourceType_volumes);
            registrar.RegisterType(ResourceTypeReference_networks, () => InstanceLazy.Value.ResourceType_networks);
            registrar.RegisterType(ResourceTypeReference_gateways, () => InstanceLazy.Value.ResourceType_gateways);
            registrar.RegisterType(ResourceTypeReference_applications, () => InstanceLazy.Value.ResourceType_applications);
            registrar.RegisterType(ResourceTypeReference_secrets_values, () => InstanceLazy.Value.ResourceType_secrets_values);
        }
        private readonly ResourceType ResourceType_secrets;
        private readonly ResourceType ResourceType_volumes;
        private readonly ResourceType ResourceType_networks;
        private readonly ResourceType ResourceType_gateways;
        private readonly ResourceType ResourceType_applications;
        private readonly ResourceType ResourceType_secrets_values;
        private readonly TypeSymbol SecretResourceProperties;
        private readonly TypeSymbol InlinedValueSecretResourceProperties;
        private readonly TypeSymbol SecretValueResourceProperties;
        private readonly TypeSymbol VolumeResourceProperties;
        private readonly TypeSymbol VolumeProviderParametersAzureFile;
        private readonly TypeSymbol NetworkResourceProperties;
        private readonly TypeSymbol LocalNetworkResourceProperties;
        private readonly TypeSymbol GatewayResourceProperties;
        private readonly TypeSymbol NetworkRef;
        private readonly TypeSymbol EndpointRef;
        private readonly TypeSymbol TcpConfig;
        private readonly TypeSymbol GatewayDestination;
        private readonly TypeSymbol HttpConfig;
        private readonly TypeSymbol HttpHostConfig;
        private readonly TypeSymbol HttpRouteConfig;
        private readonly TypeSymbol HttpRouteMatchRule;
        private readonly TypeSymbol HttpRouteMatchPath;
        private readonly TypeSymbol HttpRouteMatchHeader;
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
        private readonly TypeSymbol VolumeReference;
        private readonly TypeSymbol ApplicationScopedVolume;
        private readonly TypeSymbol ApplicationScopedVolumeCreationParameters;
        private readonly TypeSymbol ApplicationScopedVolumeCreationParametersServiceFabricVolumeDisk;
        private readonly TypeSymbol DiagnosticsRef;
        private readonly TypeSymbol ReliableCollectionsRef;
        private readonly TypeSymbol AutoScalingPolicy;
        private readonly TypeSymbol AutoScalingTrigger;
        private readonly TypeSymbol AutoScalingMechanism;
        private readonly TypeSymbol DiagnosticsDescription;
        private readonly TypeSymbol DiagnosticsSinkProperties;
        private readonly TypeSymbol AzureInternalMonitoringPipelineSinkDescription;
    }
}
