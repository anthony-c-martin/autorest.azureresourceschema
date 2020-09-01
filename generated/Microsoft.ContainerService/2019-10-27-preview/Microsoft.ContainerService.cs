// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_ContainerService_2019_10_27_preview
    {
        private const string ProviderNamespace = "Microsoft.ContainerService";
        private const string ApiVersion = "2019-10-27-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_openShiftManagedClusters = new ResourceTypeReference(ProviderNamespace, new[]{"openShiftManagedClusters"}, ApiVersion);
        private static Lazy<Microsoft_ContainerService_2019_10_27_preview> InstanceLazy = new Lazy<Microsoft_ContainerService_2019_10_27_preview>(() => new Microsoft_ContainerService_2019_10_27_preview());
        private Microsoft_ContainerService_2019_10_27_preview()
        {
            PurchasePlan = new NamedObjectType("PurchasePlan", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("product", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("promotionCode", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("publisher", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            OpenShiftManagedClusterProperties = new NamedObjectType("OpenShiftManagedClusterProperties", new ITypeProperty[]{new TypeProperty("openShiftVersion", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("networkProfile", () => NetworkProfile, TypePropertyFlags.None), new TypeProperty("routerProfiles", new TypedArrayType(new NamedObjectType("routerProfiles", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("masterPoolProfile", () => OpenShiftManagedClusterMasterPoolProfile, TypePropertyFlags.None), new TypeProperty("agentPoolProfiles", new TypedArrayType(new NamedObjectType("agentPoolProfiles", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("authProfile", () => OpenShiftManagedClusterAuthProfile, TypePropertyFlags.None), new LazyTypeProperty("monitorProfile", () => OpenShiftManagedClusterMonitorProfile, TypePropertyFlags.None), new TypeProperty("refreshCluster", LanguageConstants.Bool, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            NetworkProfile = new NamedObjectType("NetworkProfile", new ITypeProperty[]{new TypeProperty("vnetCidr", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("managementSubnetCidr", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("vnetId", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            OpenShiftRouterProfile = new NamedObjectType("OpenShiftRouterProfile", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            OpenShiftManagedClusterMasterPoolProfile = new NamedObjectType("OpenShiftManagedClusterMasterPoolProfile", new ITypeProperty[]{new TypeProperty("count", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("vmSize", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("subnetCidr", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("apiProperties", () => OpenShiftAPIProperties, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            OpenShiftAPIProperties = new NamedObjectType("OpenShiftAPIProperties", new ITypeProperty[]{new TypeProperty("privateApiServer", LanguageConstants.Bool, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            OpenShiftManagedClusterAgentPoolProfile = new NamedObjectType("OpenShiftManagedClusterAgentPoolProfile", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("count", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("vmSize", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("subnetCidr", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("osType", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("role", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            OpenShiftManagedClusterAuthProfile = new NamedObjectType("OpenShiftManagedClusterAuthProfile", new ITypeProperty[]{new TypeProperty("identityProviders", new TypedArrayType(new NamedObjectType("identityProviders", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            OpenShiftManagedClusterIdentityProvider = new NamedObjectType("OpenShiftManagedClusterIdentityProvider", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("provider", () => OpenShiftManagedClusterBaseIdentityProvider, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            OpenShiftManagedClusterBaseIdentityProvider = new NamedObjectType("OpenShiftManagedClusterBaseIdentityProvider", new ITypeProperty[]{}, null, TypePropertyFlags.None);
            OpenShiftManagedClusterAADIdentityProvider = new NamedObjectType("OpenShiftManagedClusterAADIdentityProvider", new ITypeProperty[]{new TypeProperty("clientId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("secret", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tenantId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("customerAdminGroupId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            OpenShiftManagedClusterMonitorProfile = new NamedObjectType("OpenShiftManagedClusterMonitorProfile", new ITypeProperty[]{new TypeProperty("workspaceResourceID", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("enabled", LanguageConstants.Bool, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_openShiftManagedClusters = new ResourceType("Microsoft.ContainerService/openShiftManagedClusters", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new LazyTypeProperty("plan", () => PurchasePlan, TypePropertyFlags.None), new LazyTypeProperty("properties", () => OpenShiftManagedClusterProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_openShiftManagedClusters);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_openShiftManagedClusters, () => InstanceLazy.Value.ResourceType_openShiftManagedClusters);
        }
        private readonly ResourceType ResourceType_openShiftManagedClusters;
        private readonly TypeSymbol PurchasePlan;
        private readonly TypeSymbol OpenShiftManagedClusterProperties;
        private readonly TypeSymbol NetworkProfile;
        private readonly TypeSymbol OpenShiftRouterProfile;
        private readonly TypeSymbol OpenShiftManagedClusterMasterPoolProfile;
        private readonly TypeSymbol OpenShiftAPIProperties;
        private readonly TypeSymbol OpenShiftManagedClusterAgentPoolProfile;
        private readonly TypeSymbol OpenShiftManagedClusterAuthProfile;
        private readonly TypeSymbol OpenShiftManagedClusterIdentityProvider;
        private readonly TypeSymbol OpenShiftManagedClusterBaseIdentityProvider;
        private readonly TypeSymbol OpenShiftManagedClusterAADIdentityProvider;
        private readonly TypeSymbol OpenShiftManagedClusterMonitorProfile;
    }
}
