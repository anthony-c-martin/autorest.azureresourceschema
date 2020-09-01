// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_CognitiveServices_2016_02_01_preview
    {
        private const string ProviderNamespace = "Microsoft.CognitiveServices";
        private const string ApiVersion = "2016-02-01-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_accounts = new ResourceTypeReference(ProviderNamespace, new[]{"accounts"}, ApiVersion);
        private static Lazy<Microsoft_CognitiveServices_2016_02_01_preview> InstanceLazy = new Lazy<Microsoft_CognitiveServices_2016_02_01_preview>(() => new Microsoft_CognitiveServices_2016_02_01_preview());
        private Microsoft_CognitiveServices_2016_02_01_preview()
        {
            Sku = new NamedObjectType("Sku", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ResourceType_accounts = new ResourceType("Microsoft.CognitiveServices/accounts", new ITypeProperty[]{new LazyTypeProperty("sku", () => Sku, TypePropertyFlags.Required), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new TypeProperty("properties", new NamedObjectType("properties", new ITypeProperty[]{}, null, TypePropertyFlags.None), TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_accounts);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_accounts, () => InstanceLazy.Value.ResourceType_accounts);
        }
        private readonly ResourceType ResourceType_accounts;
        private readonly TypeSymbol Sku;
    }
}
