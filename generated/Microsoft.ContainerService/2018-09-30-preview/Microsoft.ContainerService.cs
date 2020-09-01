// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_ContainerService_2018_09_30_preview
    {
        private const string ProviderNamespace = "Microsoft.ContainerService";
        private const string ApiVersion = "2018-09-30-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_openShiftManagedClusters = new ResourceTypeReference(ProviderNamespace, new[]{"openShiftManagedClusters"}, ApiVersion);
        private static Lazy<Microsoft_ContainerService_2018_09_30_preview> InstanceLazy = new Lazy<Microsoft_ContainerService_2018_09_30_preview>(() => new Microsoft_ContainerService_2018_09_30_preview());
        private Microsoft_ContainerService_2018_09_30_preview()
        {
            PurchasePlan = new NamedObjectType("PurchasePlan", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("product", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("promotionCode", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("publisher", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            OpenShiftManagedClusterProperties = new NamedObjectType("OpenShiftManagedClusterProperties", new ITypeProperty[]{new TypeProperty("openShiftVersion", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("publicHostname", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("fqdn", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("networkProfile", () => NetworkProfile, TypePropertyFlags.None), new TypeProperty("routerProfiles", new TypedArrayType(new NamedObjectType("routerProfiles", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("masterPoolProfile", () => OpenShiftManagedClusterMasterPoolProfile, TypePropertyFlags.None), new TypeProperty("agentPoolProfiles", new TypedArrayType(new NamedObjectType("agentPoolProfiles", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("authProfile", () => OpenShiftManagedClusterAuthProfile, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            NetworkProfile = new NamedObjectType("NetworkProfile", new ITypeProperty[]{new TypeProperty("vnetCidr", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("peerVnetId", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            OpenShiftRouterProfile = new NamedObjectType("OpenShiftRouterProfile", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("publicSubdomain", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            OpenShiftManagedClusterMasterPoolProfile = new NamedObjectType("OpenShiftManagedClusterMasterPoolProfile", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("count", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("vmSize", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("subnetCidr", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("osType", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            OpenShiftManagedClusterAgentPoolProfile = new NamedObjectType("OpenShiftManagedClusterAgentPoolProfile", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("count", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("vmSize", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("subnetCidr", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("osType", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("role", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            OpenShiftManagedClusterAuthProfile = new NamedObjectType("OpenShiftManagedClusterAuthProfile", new ITypeProperty[]{new TypeProperty("identityProviders", new TypedArrayType(new NamedObjectType("identityProviders", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            OpenShiftManagedClusterIdentityProvider = new NamedObjectType("OpenShiftManagedClusterIdentityProvider", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("provider", () => OpenShiftManagedClusterBaseIdentityProvider, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            OpenShiftManagedClusterBaseIdentityProvider = new NamedObjectType("OpenShiftManagedClusterBaseIdentityProvider", new ITypeProperty[]{}, null, TypePropertyFlags.None);
            OpenShiftManagedClusterAADIdentityProvider = new NamedObjectType("OpenShiftManagedClusterAADIdentityProvider", new ITypeProperty[]{new TypeProperty("clientId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("secret", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tenantId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("customerAdminGroupId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
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
        private readonly TypeSymbol OpenShiftManagedClusterAgentPoolProfile;
        private readonly TypeSymbol OpenShiftManagedClusterAuthProfile;
        private readonly TypeSymbol OpenShiftManagedClusterIdentityProvider;
        private readonly TypeSymbol OpenShiftManagedClusterBaseIdentityProvider;
        private readonly TypeSymbol OpenShiftManagedClusterAADIdentityProvider;
    }
}
