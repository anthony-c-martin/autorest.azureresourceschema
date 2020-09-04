// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_Relay_2018_01_01_preview
    {
        private const string ProviderNamespace = "Microsoft.Relay";
        private const string ApiVersion = "2018-01-01-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_namespaces = new ResourceTypeReference(ProviderNamespace, new[]{"namespaces"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_namespaces_privateEndpointConnections = new ResourceTypeReference(ProviderNamespace, new[]{"namespaces", "privateEndpointConnections"}, ApiVersion);
        private static Lazy<Microsoft_Relay_2018_01_01_preview> InstanceLazy = new Lazy<Microsoft_Relay_2018_01_01_preview>(() => new Microsoft_Relay_2018_01_01_preview());
        private Microsoft_Relay_2018_01_01_preview()
        {
            Sku = new NamedObjectType("Sku", new ITypeProperty[]{new TypeProperty("name", new StringLiteralType("'Standard'"), TypePropertyFlags.Required), new TypeProperty("tier", new StringLiteralType("'Standard'"), TypePropertyFlags.None)}, null);
            RelayNamespaceProperties = new NamedObjectType("RelayNamespaceProperties", new ITypeProperty[]{new TypeProperty("provisioningState", UnionType.Create(new StringLiteralType("'Created'"), new StringLiteralType("'Succeeded'"), new StringLiteralType("'Deleted'"), new StringLiteralType("'Failed'"), new StringLiteralType("'Updating'"), new StringLiteralType("'Unknown'")), TypePropertyFlags.ReadOnly), new TypeProperty("createdAt", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("updatedAt", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("serviceBusEndpoint", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("metricId", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            PrivateEndpointConnectionProperties = new NamedObjectType("PrivateEndpointConnectionProperties", new ITypeProperty[]{new LazyTypeProperty("privateEndpoint", () => PrivateEndpoint, TypePropertyFlags.None), new LazyTypeProperty("privateLinkServiceConnectionState", () => PrivateLinkServiceConnectionState, TypePropertyFlags.None), new TypeProperty("provisioningState", UnionType.Create(new StringLiteralType("'Unknown'"), new StringLiteralType("'Succeeded'"), new StringLiteralType("'Creating'"), new StringLiteralType("'Updating'"), new StringLiteralType("'UpdatingByProxy'"), new StringLiteralType("'Deleting'"), new StringLiteralType("'DeletingByProxy'")), TypePropertyFlags.None)}, null);
            PrivateEndpoint = new NamedObjectType("PrivateEndpoint", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.None)}, null);
            PrivateLinkServiceConnectionState = new NamedObjectType("PrivateLinkServiceConnectionState", new ITypeProperty[]{new TypeProperty("status", UnionType.Create(new StringLiteralType("'Pending'"), new StringLiteralType("'Approved'"), new StringLiteralType("'Rejected'"), new StringLiteralType("'Disconnected'")), TypePropertyFlags.None), new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("actionRequired", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ResourceType_namespaces = new ResourceType("Microsoft.Relay/namespaces", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.Relay/namespaces'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("sku", () => Sku, TypePropertyFlags.None), new LazyTypeProperty("properties", () => RelayNamespaceProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2018-01-01-preview'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_namespaces);
            ResourceType_namespaces_privateEndpointConnections = new ResourceType("Microsoft.Relay/namespaces/privateEndpointConnections", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.Relay/namespaces/privateEndpointConnections'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("properties", () => PrivateEndpointConnectionProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2018-01-01-preview'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_namespaces_privateEndpointConnections);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_namespaces, () => InstanceLazy.Value.ResourceType_namespaces);
            registrar.RegisterType(ResourceTypeReference_namespaces_privateEndpointConnections, () => InstanceLazy.Value.ResourceType_namespaces_privateEndpointConnections);
        }
        private readonly ResourceType ResourceType_namespaces;
        private readonly ResourceType ResourceType_namespaces_privateEndpointConnections;
        private readonly TypeSymbol Sku;
        private readonly TypeSymbol RelayNamespaceProperties;
        private readonly TypeSymbol PrivateEndpointConnectionProperties;
        private readonly TypeSymbol PrivateEndpoint;
        private readonly TypeSymbol PrivateLinkServiceConnectionState;
    }
}
