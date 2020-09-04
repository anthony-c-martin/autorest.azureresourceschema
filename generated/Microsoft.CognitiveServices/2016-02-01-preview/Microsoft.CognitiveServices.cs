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
            Sku = new NamedObjectType("Sku", new ITypeProperty[]{new TypeProperty("name", UnionType.Create(new StringLiteralType("'F0'"), new StringLiteralType("'P0'"), new StringLiteralType("'P1'"), new StringLiteralType("'P2'"), new StringLiteralType("'S0'"), new StringLiteralType("'S1'"), new StringLiteralType("'S2'"), new StringLiteralType("'S3'"), new StringLiteralType("'S4'"), new StringLiteralType("'S5'"), new StringLiteralType("'S6'")), TypePropertyFlags.Required), new TypeProperty("tier", UnionType.Create(new StringLiteralType("'Free'"), new StringLiteralType("'Standard'"), new StringLiteralType("'Premium'")), TypePropertyFlags.ReadOnly)}, null);
            ResourceType_accounts = new ResourceType("Microsoft.CognitiveServices/accounts", new ITypeProperty[]{new LazyTypeProperty("sku", () => Sku, TypePropertyFlags.Required), new TypeProperty("kind", UnionType.Create(new StringLiteralType("'Academic'"), new StringLiteralType("'Bing.Autosuggest'"), new StringLiteralType("'Bing.Search'"), new StringLiteralType("'Bing.Speech'"), new StringLiteralType("'Bing.SpellCheck'"), new StringLiteralType("'ComputerVision'"), new StringLiteralType("'ContentModerator'"), new StringLiteralType("'Emotion'"), new StringLiteralType("'Face'"), new StringLiteralType("'LUIS'"), new StringLiteralType("'Recommendations'"), new StringLiteralType("'SpeakerRecognition'"), new StringLiteralType("'Speech'"), new StringLiteralType("'SpeechTranslation'"), new StringLiteralType("'TextAnalytics'"), new StringLiteralType("'TextTranslation'"), new StringLiteralType("'WebLM'")), TypePropertyFlags.Required), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("properties", LanguageConstants.Any, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.CognitiveServices/accounts'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", new StringLiteralType("'2016-02-01-preview'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_accounts);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_accounts, () => InstanceLazy.Value.ResourceType_accounts);
        }
        private readonly ResourceType ResourceType_accounts;
        private readonly TypeSymbol Sku;
    }
}
