// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_Automation_2020_01_13_preview
    {
        private const string ProviderNamespace = "Microsoft.Automation";
        private const string ApiVersion = "2020-01-13-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_automationAccounts_privateEndpointConnections = new ResourceTypeReference(ProviderNamespace, new[]{"automationAccounts", "privateEndpointConnections"}, ApiVersion);
        private static Lazy<Microsoft_Automation_2020_01_13_preview> InstanceLazy = new Lazy<Microsoft_Automation_2020_01_13_preview>(() => new Microsoft_Automation_2020_01_13_preview());
        private Microsoft_Automation_2020_01_13_preview()
        {
            PrivateEndpointConnectionProperties = new NamedObjectType("PrivateEndpointConnectionProperties", new ITypeProperty[]{new LazyTypeProperty("privateEndpoint", () => PrivateEndpointProperty, TypePropertyFlags.None), new LazyTypeProperty("privateLinkServiceConnectionState", () => PrivateLinkServiceConnectionStateProperty, TypePropertyFlags.None)}, null);
            PrivateEndpointProperty = new NamedObjectType("PrivateEndpointProperty", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.None)}, null);
            PrivateLinkServiceConnectionStateProperty = new NamedObjectType("PrivateLinkServiceConnectionStateProperty", new ITypeProperty[]{new TypeProperty("status", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("actionsRequired", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            ResourceType_automationAccounts_privateEndpointConnections = new ResourceType("Microsoft.Automation/automationAccounts/privateEndpointConnections", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.Automation/automationAccounts/privateEndpointConnections'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new LazyTypeProperty("properties", () => PrivateEndpointConnectionProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2020-01-13-preview'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_automationAccounts_privateEndpointConnections);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_automationAccounts_privateEndpointConnections, () => InstanceLazy.Value.ResourceType_automationAccounts_privateEndpointConnections);
        }
        private readonly ResourceType ResourceType_automationAccounts_privateEndpointConnections;
        private readonly TypeSymbol PrivateEndpointConnectionProperties;
        private readonly TypeSymbol PrivateEndpointProperty;
        private readonly TypeSymbol PrivateLinkServiceConnectionStateProperty;
    }
}
