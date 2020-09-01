// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_MachineLearningCompute_2017_08_01_preview
    {
        private const string ProviderNamespace = "Microsoft.MachineLearningCompute";
        private const string ApiVersion = "2017-08-01-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_operationalizationClusters = new ResourceTypeReference(ProviderNamespace, new[]{"operationalizationClusters"}, ApiVersion);
        private static Lazy<Microsoft_MachineLearningCompute_2017_08_01_preview> InstanceLazy = new Lazy<Microsoft_MachineLearningCompute_2017_08_01_preview>(() => new Microsoft_MachineLearningCompute_2017_08_01_preview());
        private Microsoft_MachineLearningCompute_2017_08_01_preview()
        {
            OperationalizationClusterProperties = new NamedObjectType("OperationalizationClusterProperties", new ITypeProperty[]{new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("clusterType", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("storageAccount", () => StorageAccountProperties, TypePropertyFlags.None), new LazyTypeProperty("containerRegistry", () => ContainerRegistryProperties, TypePropertyFlags.None), new LazyTypeProperty("containerService", () => AcsClusterProperties, TypePropertyFlags.None), new LazyTypeProperty("appInsights", () => AppInsightsProperties, TypePropertyFlags.None), new LazyTypeProperty("globalServiceConfiguration", () => GlobalServiceConfiguration, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            StorageAccountProperties = new NamedObjectType("StorageAccountProperties", new ITypeProperty[]{new TypeProperty("resourceId", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ContainerRegistryProperties = new NamedObjectType("ContainerRegistryProperties", new ITypeProperty[]{new TypeProperty("resourceId", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            AcsClusterProperties = new NamedObjectType("AcsClusterProperties", new ITypeProperty[]{new TypeProperty("orchestratorType", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("orchestratorProperties", () => KubernetesClusterProperties, TypePropertyFlags.None), new TypeProperty("systemServices", new TypedArrayType(new NamedObjectType("systemServices", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("masterCount", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("agentCount", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("agentVmSize", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            KubernetesClusterProperties = new NamedObjectType("KubernetesClusterProperties", new ITypeProperty[]{new LazyTypeProperty("servicePrincipal", () => ServicePrincipalProperties, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ServicePrincipalProperties = new NamedObjectType("ServicePrincipalProperties", new ITypeProperty[]{new TypeProperty("clientId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("secret", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            SystemService = new NamedObjectType("SystemService", new ITypeProperty[]{new TypeProperty("systemServiceType", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            AppInsightsProperties = new NamedObjectType("AppInsightsProperties", new ITypeProperty[]{new TypeProperty("resourceId", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            GlobalServiceConfiguration = new NamedObjectType("GlobalServiceConfiguration", new ITypeProperty[]{new TypeProperty("additionalProperties", new NamedObjectType("additionalProperties", new ITypeProperty[]{}, new NamedObjectType("additionalProperties", new ITypeProperty[]{}, null, TypePropertyFlags.None), TypePropertyFlags.None), TypePropertyFlags.None), new TypeProperty("etag", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("ssl", () => SslConfiguration, TypePropertyFlags.None), new LazyTypeProperty("serviceAuth", () => ServiceAuthConfiguration, TypePropertyFlags.None), new LazyTypeProperty("autoScale", () => AutoScaleConfiguration, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            SslConfiguration = new NamedObjectType("SslConfiguration", new ITypeProperty[]{new TypeProperty("status", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("cert", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("key", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("cname", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ServiceAuthConfiguration = new NamedObjectType("ServiceAuthConfiguration", new ITypeProperty[]{new TypeProperty("primaryAuthKeyHash", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("secondaryAuthKeyHash", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            AutoScaleConfiguration = new NamedObjectType("AutoScaleConfiguration", new ITypeProperty[]{new TypeProperty("status", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("minReplicas", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("maxReplicas", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("targetUtilization", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("refreshPeriodInSeconds", LanguageConstants.Int, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_operationalizationClusters = new ResourceType("Microsoft.MachineLearningCompute/operationalizationClusters", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new LazyTypeProperty("properties", () => OperationalizationClusterProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_operationalizationClusters);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_operationalizationClusters, () => InstanceLazy.Value.ResourceType_operationalizationClusters);
        }
        private readonly ResourceType ResourceType_operationalizationClusters;
        private readonly TypeSymbol OperationalizationClusterProperties;
        private readonly TypeSymbol StorageAccountProperties;
        private readonly TypeSymbol ContainerRegistryProperties;
        private readonly TypeSymbol AcsClusterProperties;
        private readonly TypeSymbol KubernetesClusterProperties;
        private readonly TypeSymbol ServicePrincipalProperties;
        private readonly TypeSymbol SystemService;
        private readonly TypeSymbol AppInsightsProperties;
        private readonly TypeSymbol GlobalServiceConfiguration;
        private readonly TypeSymbol SslConfiguration;
        private readonly TypeSymbol ServiceAuthConfiguration;
        private readonly TypeSymbol AutoScaleConfiguration;
    }
}
