// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_DBforMySQL_2018_06_01
    {
        private const string ProviderNamespace = "Microsoft.DBforMySQL";
        private const string ApiVersion = "2018-06-01";
        private static readonly ResourceTypeReference ResourceTypeReference_servers_privateEndpointConnections = new ResourceTypeReference(ProviderNamespace, new[]{"servers", "privateEndpointConnections"}, ApiVersion);
        private static Lazy<Microsoft_DBforMySQL_2018_06_01> InstanceLazy = new Lazy<Microsoft_DBforMySQL_2018_06_01>(() => new Microsoft_DBforMySQL_2018_06_01());
        private Microsoft_DBforMySQL_2018_06_01()
        {
            PrivateEndpointConnectionProperties = new NamedObjectType("PrivateEndpointConnectionProperties", new ITypeProperty[]{new LazyTypeProperty("privateEndpoint", () => PrivateEndpointProperty, TypePropertyFlags.None), new LazyTypeProperty("privateLinkServiceConnectionState", () => PrivateLinkServiceConnectionStateProperty, TypePropertyFlags.None), new TypeProperty("provisioningState", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            PrivateEndpointProperty = new NamedObjectType("PrivateEndpointProperty", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.None)}, null);
            PrivateLinkServiceConnectionStateProperty = new NamedObjectType("PrivateLinkServiceConnectionStateProperty", new ITypeProperty[]{new TypeProperty("status", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("actionsRequired", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            ResourceType_servers_privateEndpointConnections = new ResourceType("Microsoft.DBforMySQL/servers/privateEndpointConnections", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.DBforMySQL/servers/privateEndpointConnections'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new LazyTypeProperty("properties", () => PrivateEndpointConnectionProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2018-06-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_servers_privateEndpointConnections);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_servers_privateEndpointConnections, () => InstanceLazy.Value.ResourceType_servers_privateEndpointConnections);
        }
        private readonly ResourceType ResourceType_servers_privateEndpointConnections;
        private readonly TypeSymbol PrivateEndpointConnectionProperties;
        private readonly TypeSymbol PrivateEndpointProperty;
        private readonly TypeSymbol PrivateLinkServiceConnectionStateProperty;
    }
}
