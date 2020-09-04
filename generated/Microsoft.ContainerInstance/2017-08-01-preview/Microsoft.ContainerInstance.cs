// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_ContainerInstance_2017_08_01_preview
    {
        private const string ProviderNamespace = "Microsoft.ContainerInstance";
        private const string ApiVersion = "2017-08-01-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_containerGroups = new ResourceTypeReference(ProviderNamespace, new[]{"containerGroups"}, ApiVersion);
        private static Lazy<Microsoft_ContainerInstance_2017_08_01_preview> InstanceLazy = new Lazy<Microsoft_ContainerInstance_2017_08_01_preview>(() => new Microsoft_ContainerInstance_2017_08_01_preview());
        private Microsoft_ContainerInstance_2017_08_01_preview()
        {
            ContainerGroupProperties = new NamedObjectType("ContainerGroupProperties", new ITypeProperty[]{new TypeProperty("provisioningState", LanguageConstants.String, TypePropertyFlags.ReadOnly), new LazyTypeProperty("containers", () => new TypedArrayType(Container), TypePropertyFlags.Required), new LazyTypeProperty("imageRegistryCredentials", () => new TypedArrayType(ImageRegistryCredential), TypePropertyFlags.None), new TypeProperty("restartPolicy", new StringLiteralType("'always'"), TypePropertyFlags.None), new LazyTypeProperty("ipAddress", () => IpAddress, TypePropertyFlags.None), new TypeProperty("osType", UnionType.Create(new StringLiteralType("'Windows'"), new StringLiteralType("'Linux'")), TypePropertyFlags.Required), new TypeProperty("state", LanguageConstants.String, TypePropertyFlags.ReadOnly), new LazyTypeProperty("volumes", () => new TypedArrayType(Volume), TypePropertyFlags.None)}, null);
            Container = new NamedObjectType("Container", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => ContainerProperties, TypePropertyFlags.Required)}, null);
            ContainerProperties = new NamedObjectType("ContainerProperties", new ITypeProperty[]{new TypeProperty("image", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("command", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new LazyTypeProperty("ports", () => new TypedArrayType(ContainerPort), TypePropertyFlags.None), new LazyTypeProperty("environmentVariables", () => new TypedArrayType(EnvironmentVariable), TypePropertyFlags.None), new LazyTypeProperty("instanceView", () => ContainerPropertiesInstanceView, TypePropertyFlags.ReadOnly), new LazyTypeProperty("resources", () => ResourceRequirements, TypePropertyFlags.Required), new LazyTypeProperty("volumeMounts", () => new TypedArrayType(VolumeMount), TypePropertyFlags.None)}, null);
            ContainerPort = new NamedObjectType("ContainerPort", new ITypeProperty[]{new TypeProperty("port", LanguageConstants.Int, TypePropertyFlags.Required)}, null);
            EnvironmentVariable = new NamedObjectType("EnvironmentVariable", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("value", LanguageConstants.String, TypePropertyFlags.Required)}, null);
            ContainerPropertiesInstanceView = new NamedObjectType("ContainerPropertiesInstanceView", new ITypeProperty[]{new TypeProperty("restartCount", LanguageConstants.Int, TypePropertyFlags.None), new LazyTypeProperty("currentState", () => ContainerState, TypePropertyFlags.None), new LazyTypeProperty("previousState", () => ContainerState, TypePropertyFlags.None), new LazyTypeProperty("events", () => new TypedArrayType(ContainerEvent), TypePropertyFlags.None)}, null);
            ContainerState = new NamedObjectType("ContainerState", new ITypeProperty[]{new TypeProperty("state", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("startTime", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("exitCode", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("finishTime", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("detailStatus", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ContainerEvent = new NamedObjectType("ContainerEvent", new ITypeProperty[]{new TypeProperty("count", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("firstTimestamp", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("lastTimestamp", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("message", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ResourceRequirements = new NamedObjectType("ResourceRequirements", new ITypeProperty[]{new LazyTypeProperty("requests", () => ResourceRequests, TypePropertyFlags.Required), new LazyTypeProperty("limits", () => ResourceLimits, TypePropertyFlags.None)}, null);
            ResourceRequests = new NamedObjectType("ResourceRequests", new ITypeProperty[]{new TypeProperty("memoryInGB", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("cpu", LanguageConstants.Int, TypePropertyFlags.Required)}, null);
            ResourceLimits = new NamedObjectType("ResourceLimits", new ITypeProperty[]{new TypeProperty("memoryInGB", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("cpu", LanguageConstants.Int, TypePropertyFlags.None)}, null);
            VolumeMount = new NamedObjectType("VolumeMount", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("mountPath", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("readOnly", LanguageConstants.Bool, TypePropertyFlags.None)}, null);
            ImageRegistryCredential = new NamedObjectType("ImageRegistryCredential", new ITypeProperty[]{new TypeProperty("server", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("username", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("password", LanguageConstants.String, TypePropertyFlags.None)}, null);
            IpAddress = new NamedObjectType("IpAddress", new ITypeProperty[]{new LazyTypeProperty("ports", () => new TypedArrayType(Port), TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Public'"), TypePropertyFlags.Required), new TypeProperty("ip", LanguageConstants.String, TypePropertyFlags.None)}, null);
            Port = new NamedObjectType("Port", new ITypeProperty[]{new TypeProperty("protocol", UnionType.Create(new StringLiteralType("'TCP'"), new StringLiteralType("'UDP'")), TypePropertyFlags.None), new TypeProperty("port", LanguageConstants.Int, TypePropertyFlags.Required)}, null);
            Volume = new NamedObjectType("Volume", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("azureFile", () => AzureFileVolume, TypePropertyFlags.Required)}, null);
            AzureFileVolume = new NamedObjectType("AzureFileVolume", new ITypeProperty[]{new TypeProperty("shareName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("readOnly", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("storageAccountName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("storageAccountKey", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ResourceType_containerGroups = new ResourceType("Microsoft.ContainerInstance/containerGroups", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.ContainerInstance/containerGroups'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("properties", () => ContainerGroupProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2017-08-01-preview'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_containerGroups);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_containerGroups, () => InstanceLazy.Value.ResourceType_containerGroups);
        }
        private readonly ResourceType ResourceType_containerGroups;
        private readonly TypeSymbol ContainerGroupProperties;
        private readonly TypeSymbol Container;
        private readonly TypeSymbol ContainerProperties;
        private readonly TypeSymbol ContainerPort;
        private readonly TypeSymbol EnvironmentVariable;
        private readonly TypeSymbol ContainerPropertiesInstanceView;
        private readonly TypeSymbol ContainerState;
        private readonly TypeSymbol ContainerEvent;
        private readonly TypeSymbol ResourceRequirements;
        private readonly TypeSymbol ResourceRequests;
        private readonly TypeSymbol ResourceLimits;
        private readonly TypeSymbol VolumeMount;
        private readonly TypeSymbol ImageRegistryCredential;
        private readonly TypeSymbol IpAddress;
        private readonly TypeSymbol Port;
        private readonly TypeSymbol Volume;
        private readonly TypeSymbol AzureFileVolume;
    }
}
