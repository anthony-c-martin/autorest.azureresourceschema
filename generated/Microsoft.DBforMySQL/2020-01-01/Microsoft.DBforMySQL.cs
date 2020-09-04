// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_DBforMySQL_2020_01_01
    {
        private const string ProviderNamespace = "Microsoft.DBforMySQL";
        private const string ApiVersion = "2020-01-01";
        private static readonly ResourceTypeReference ResourceTypeReference_servers_keys = new ResourceTypeReference(ProviderNamespace, new[]{"servers", "keys"}, ApiVersion);
        private static Lazy<Microsoft_DBforMySQL_2020_01_01> InstanceLazy = new Lazy<Microsoft_DBforMySQL_2020_01_01>(() => new Microsoft_DBforMySQL_2020_01_01());
        private Microsoft_DBforMySQL_2020_01_01()
        {
            ServerKeyProperties = new NamedObjectType("ServerKeyProperties", new ITypeProperty[]{new TypeProperty("serverKeyType", new StringLiteralType("'AzureKeyVault'"), TypePropertyFlags.Required), new TypeProperty("uri", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("creationDate", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            ResourceType_servers_keys = new ResourceType("Microsoft.DBforMySQL/servers/keys", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.DBforMySQL/servers/keys'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("properties", () => ServerKeyProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2020-01-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_servers_keys);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_servers_keys, () => InstanceLazy.Value.ResourceType_servers_keys);
        }
        private readonly ResourceType ResourceType_servers_keys;
        private readonly TypeSymbol ServerKeyProperties;
    }
}
