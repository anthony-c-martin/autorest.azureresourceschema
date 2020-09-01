// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_DocumentDB_2019_08_01_preview
    {
        private const string ProviderNamespace = "Microsoft.DocumentDB";
        private const string ApiVersion = "2019-08-01-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_databaseAccounts_privateEndpointConnections = new ResourceTypeReference(ProviderNamespace, new[]{"databaseAccounts", "privateEndpointConnections"}, ApiVersion);
        private static Lazy<Microsoft_DocumentDB_2019_08_01_preview> InstanceLazy = new Lazy<Microsoft_DocumentDB_2019_08_01_preview>(() => new Microsoft_DocumentDB_2019_08_01_preview());
        private Microsoft_DocumentDB_2019_08_01_preview()
        {
            PrivateEndpointConnectionProperties = new NamedObjectType("PrivateEndpointConnectionProperties", new ITypeProperty[]{new LazyTypeProperty("privateEndpoint", () => PrivateEndpointProperty, TypePropertyFlags.None), new LazyTypeProperty("privateLinkServiceConnectionState", () => PrivateLinkServiceConnectionStateProperty, TypePropertyFlags.None), new TypeProperty("groupId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("provisioningState", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            PrivateEndpointProperty = new NamedObjectType("PrivateEndpointProperty", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            PrivateLinkServiceConnectionStateProperty = new NamedObjectType("PrivateLinkServiceConnectionStateProperty", new ITypeProperty[]{new TypeProperty("status", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_databaseAccounts_privateEndpointConnections = new ResourceType("Microsoft.DocumentDB/databaseAccounts/privateEndpointConnections", new ITypeProperty[]{new LazyTypeProperty("properties", () => PrivateEndpointConnectionProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_databaseAccounts_privateEndpointConnections);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_databaseAccounts_privateEndpointConnections, () => InstanceLazy.Value.ResourceType_databaseAccounts_privateEndpointConnections);
        }
        private readonly ResourceType ResourceType_databaseAccounts_privateEndpointConnections;
        private readonly TypeSymbol PrivateEndpointConnectionProperties;
        private readonly TypeSymbol PrivateEndpointProperty;
        private readonly TypeSymbol PrivateLinkServiceConnectionStateProperty;
    }
}
