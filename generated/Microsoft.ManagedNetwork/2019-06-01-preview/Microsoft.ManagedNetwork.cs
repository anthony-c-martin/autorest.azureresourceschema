// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_ManagedNetwork_2019_06_01_preview
    {
        private const string ProviderNamespace = "Microsoft.ManagedNetwork";
        private const string ApiVersion = "2019-06-01-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_managedNetworks = new ResourceTypeReference(ProviderNamespace, new[]{"managedNetworks"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_managedNetworks_managedNetworkGroups = new ResourceTypeReference(ProviderNamespace, new[]{"managedNetworks", "managedNetworkGroups"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_managedNetworks_managedNetworkPeeringPolicies = new ResourceTypeReference(ProviderNamespace, new[]{"managedNetworks", "managedNetworkPeeringPolicies"}, ApiVersion);
        private static Lazy<Microsoft_ManagedNetwork_2019_06_01_preview> InstanceLazy = new Lazy<Microsoft_ManagedNetwork_2019_06_01_preview>(() => new Microsoft_ManagedNetwork_2019_06_01_preview());
        private Microsoft_ManagedNetwork_2019_06_01_preview()
        {
            ManagedNetworkProperties = new NamedObjectType("ManagedNetworkProperties", new ITypeProperty[]{new LazyTypeProperty("scope", () => Scope, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            Scope = new NamedObjectType("Scope", new ITypeProperty[]{new TypeProperty("managementGroups", new TypedArrayType(new NamedObjectType("managementGroups", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("subscriptions", new TypedArrayType(new NamedObjectType("subscriptions", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("virtualNetworks", new TypedArrayType(new NamedObjectType("virtualNetworks", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("subnets", new TypedArrayType(new NamedObjectType("subnets", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceId = new NamedObjectType("ResourceId", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ScopeAssignmentProperties = new NamedObjectType("ScopeAssignmentProperties", new ITypeProperty[]{new TypeProperty("assignedManagedNetwork", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ManagedNetworkGroupProperties = new NamedObjectType("ManagedNetworkGroupProperties", new ITypeProperty[]{new TypeProperty("managementGroups", new TypedArrayType(new NamedObjectType("managementGroups", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("subscriptions", new TypedArrayType(new NamedObjectType("subscriptions", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("virtualNetworks", new TypedArrayType(new NamedObjectType("virtualNetworks", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("subnets", new TypedArrayType(new NamedObjectType("subnets", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ManagedNetworkPeeringPolicyProperties = new NamedObjectType("ManagedNetworkPeeringPolicyProperties", new ITypeProperty[]{new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("hub", () => ResourceId, TypePropertyFlags.None), new TypeProperty("spokes", new TypedArrayType(new NamedObjectType("spokes", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("mesh", new TypedArrayType(new NamedObjectType("mesh", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_managedNetworks = new ResourceType("Microsoft.ManagedNetwork/managedNetworks", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new LazyTypeProperty("properties", () => ManagedNetworkProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_managedNetworks);
            ResourceType_managedNetworks_managedNetworkGroups = new ResourceType("Microsoft.ManagedNetwork/managedNetworks/managedNetworkGroups", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("properties", () => ManagedNetworkGroupProperties, TypePropertyFlags.Required), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_managedNetworks_managedNetworkGroups);
            ResourceType_managedNetworks_managedNetworkPeeringPolicies = new ResourceType("Microsoft.ManagedNetwork/managedNetworks/managedNetworkPeeringPolicies", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("properties", () => ManagedNetworkPeeringPolicyProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_managedNetworks_managedNetworkPeeringPolicies);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_managedNetworks, () => InstanceLazy.Value.ResourceType_managedNetworks);
            registrar.RegisterType(ResourceTypeReference_managedNetworks_managedNetworkGroups, () => InstanceLazy.Value.ResourceType_managedNetworks_managedNetworkGroups);
            registrar.RegisterType(ResourceTypeReference_managedNetworks_managedNetworkPeeringPolicies, () => InstanceLazy.Value.ResourceType_managedNetworks_managedNetworkPeeringPolicies);
        }
        private readonly ResourceType ResourceType_managedNetworks;
        private readonly ResourceType ResourceType_managedNetworks_managedNetworkGroups;
        private readonly ResourceType ResourceType_managedNetworks_managedNetworkPeeringPolicies;
        private readonly TypeSymbol ManagedNetworkProperties;
        private readonly TypeSymbol Scope;
        private readonly TypeSymbol ResourceId;
        private readonly TypeSymbol ScopeAssignmentProperties;
        private readonly TypeSymbol ManagedNetworkGroupProperties;
        private readonly TypeSymbol ManagedNetworkPeeringPolicyProperties;
    }
}
