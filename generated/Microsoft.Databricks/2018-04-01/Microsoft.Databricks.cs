// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_Databricks_2018_04_01
    {
        private const string ProviderNamespace = "Microsoft.Databricks";
        private const string ApiVersion = "2018-04-01";
        private static readonly ResourceTypeReference ResourceTypeReference_workspaces = new ResourceTypeReference(ProviderNamespace, new[]{"workspaces"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_workspaces_virtualNetworkPeerings = new ResourceTypeReference(ProviderNamespace, new[]{"workspaces", "virtualNetworkPeerings"}, ApiVersion);
        private static Lazy<Microsoft_Databricks_2018_04_01> InstanceLazy = new Lazy<Microsoft_Databricks_2018_04_01>(() => new Microsoft_Databricks_2018_04_01());
        private Microsoft_Databricks_2018_04_01()
        {
            WorkspaceProperties = new NamedObjectType("WorkspaceProperties", new ITypeProperty[]{new TypeProperty("managedResourceGroupId", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("parameters", () => WorkspaceCustomParameters, TypePropertyFlags.None), new TypeProperty("uiDefinitionUri", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("authorizations", new TypedArrayType(new NamedObjectType("authorizations", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("createdBy", () => CreatedBy, TypePropertyFlags.None), new LazyTypeProperty("updatedBy", () => CreatedBy, TypePropertyFlags.None), new TypeProperty("createdDateTime", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("storageAccountIdentity", () => ManagedIdentityConfiguration, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            WorkspaceCustomParameters = new NamedObjectType("WorkspaceCustomParameters", new ITypeProperty[]{new LazyTypeProperty("amlWorkspaceId", () => WorkspaceCustomStringParameter, TypePropertyFlags.None), new LazyTypeProperty("customVirtualNetworkId", () => WorkspaceCustomStringParameter, TypePropertyFlags.None), new LazyTypeProperty("customPublicSubnetName", () => WorkspaceCustomStringParameter, TypePropertyFlags.None), new LazyTypeProperty("customPrivateSubnetName", () => WorkspaceCustomStringParameter, TypePropertyFlags.None), new LazyTypeProperty("enableNoPublicIp", () => WorkspaceCustomBooleanParameter, TypePropertyFlags.None), new LazyTypeProperty("prepareEncryption", () => WorkspaceCustomBooleanParameter, TypePropertyFlags.None), new LazyTypeProperty("encryption", () => WorkspaceEncryptionParameter, TypePropertyFlags.None), new LazyTypeProperty("requireInfrastructureEncryption", () => WorkspaceCustomBooleanParameter, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            WorkspaceCustomStringParameter = new NamedObjectType("WorkspaceCustomStringParameter", new ITypeProperty[]{new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("value", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            WorkspaceCustomBooleanParameter = new NamedObjectType("WorkspaceCustomBooleanParameter", new ITypeProperty[]{new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("value", LanguageConstants.Bool, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            WorkspaceEncryptionParameter = new NamedObjectType("WorkspaceEncryptionParameter", new ITypeProperty[]{new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("value", () => Encryption, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            Encryption = new NamedObjectType("Encryption", new ITypeProperty[]{new TypeProperty("keySource", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("KeyName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("keyversion", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("keyvaulturi", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            WorkspaceProviderAuthorization = new NamedObjectType("WorkspaceProviderAuthorization", new ITypeProperty[]{new TypeProperty("principalId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("roleDefinitionId", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            CreatedBy = new NamedObjectType("CreatedBy", new ITypeProperty[]{}, null, TypePropertyFlags.None);
            ManagedIdentityConfiguration = new NamedObjectType("ManagedIdentityConfiguration", new ITypeProperty[]{}, null, TypePropertyFlags.None);
            Sku = new NamedObjectType("Sku", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tier", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            VirtualNetworkPeeringPropertiesFormat = new NamedObjectType("VirtualNetworkPeeringPropertiesFormat", new ITypeProperty[]{new TypeProperty("allowVirtualNetworkAccess", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("allowForwardedTraffic", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("allowGatewayTransit", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("useRemoteGateways", LanguageConstants.Bool, TypePropertyFlags.None), new LazyTypeProperty("databricksVirtualNetwork", () => VirtualNetworkPeeringPropertiesFormatDatabricksVirtualNetwork, TypePropertyFlags.None), new LazyTypeProperty("databricksAddressSpace", () => AddressSpace, TypePropertyFlags.None), new LazyTypeProperty("remoteVirtualNetwork", () => VirtualNetworkPeeringPropertiesFormatRemoteVirtualNetwork, TypePropertyFlags.Required), new LazyTypeProperty("remoteAddressSpace", () => AddressSpace, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            VirtualNetworkPeeringPropertiesFormatDatabricksVirtualNetwork = new NamedObjectType("VirtualNetworkPeeringPropertiesFormatDatabricksVirtualNetwork", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            AddressSpace = new NamedObjectType("AddressSpace", new ITypeProperty[]{new TypeProperty("addressPrefixes", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            VirtualNetworkPeeringPropertiesFormatRemoteVirtualNetwork = new NamedObjectType("VirtualNetworkPeeringPropertiesFormatRemoteVirtualNetwork", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_workspaces = new ResourceType("Microsoft.Databricks/workspaces", new ITypeProperty[]{new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => WorkspaceProperties, TypePropertyFlags.Required), new LazyTypeProperty("sku", () => Sku, TypePropertyFlags.None), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_workspaces);
            ResourceType_workspaces_virtualNetworkPeerings = new ResourceType("Microsoft.Databricks/workspaces/virtualNetworkPeerings", new ITypeProperty[]{new LazyTypeProperty("properties", () => VirtualNetworkPeeringPropertiesFormat, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_workspaces_virtualNetworkPeerings);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_workspaces, () => InstanceLazy.Value.ResourceType_workspaces);
            registrar.RegisterType(ResourceTypeReference_workspaces_virtualNetworkPeerings, () => InstanceLazy.Value.ResourceType_workspaces_virtualNetworkPeerings);
        }
        private readonly ResourceType ResourceType_workspaces;
        private readonly ResourceType ResourceType_workspaces_virtualNetworkPeerings;
        private readonly TypeSymbol WorkspaceProperties;
        private readonly TypeSymbol WorkspaceCustomParameters;
        private readonly TypeSymbol WorkspaceCustomStringParameter;
        private readonly TypeSymbol WorkspaceCustomBooleanParameter;
        private readonly TypeSymbol WorkspaceEncryptionParameter;
        private readonly TypeSymbol Encryption;
        private readonly TypeSymbol WorkspaceProviderAuthorization;
        private readonly TypeSymbol CreatedBy;
        private readonly TypeSymbol ManagedIdentityConfiguration;
        private readonly TypeSymbol Sku;
        private readonly TypeSymbol VirtualNetworkPeeringPropertiesFormat;
        private readonly TypeSymbol VirtualNetworkPeeringPropertiesFormatDatabricksVirtualNetwork;
        private readonly TypeSymbol AddressSpace;
        private readonly TypeSymbol VirtualNetworkPeeringPropertiesFormatRemoteVirtualNetwork;
    }
}
