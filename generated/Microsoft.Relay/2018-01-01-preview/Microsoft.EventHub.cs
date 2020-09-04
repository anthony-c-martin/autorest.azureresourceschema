// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_EventHub_2018_01_01_preview
    {
        private const string ProviderNamespace = "Microsoft.EventHub";
        private const string ApiVersion = "2018-01-01-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_namespaces_networkRuleSets = new ResourceTypeReference(ProviderNamespace, new[]{"namespaces", "networkRuleSets"}, ApiVersion);
        private static Lazy<Microsoft_EventHub_2018_01_01_preview> InstanceLazy = new Lazy<Microsoft_EventHub_2018_01_01_preview>(() => new Microsoft_EventHub_2018_01_01_preview());
        private Microsoft_EventHub_2018_01_01_preview()
        {
            NetworkRuleSetProperties = new NamedObjectType("NetworkRuleSetProperties", new ITypeProperty[]{new TypeProperty("defaultAction", UnionType.Create(new StringLiteralType("'Allow'"), new StringLiteralType("'Deny'")), TypePropertyFlags.None), new LazyTypeProperty("ipRules", () => new TypedArrayType(NWRuleSetIpRules), TypePropertyFlags.None)}, null);
            NWRuleSetIpRules = new NamedObjectType("NWRuleSetIpRules", new ITypeProperty[]{new TypeProperty("ipMask", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("action", new StringLiteralType("'Allow'"), TypePropertyFlags.None)}, null);
            ResourceType_namespaces_networkRuleSets = new ResourceType("Microsoft.EventHub/namespaces/networkRuleSets", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.EventHub/namespaces/networkRuleSets'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new LazyTypeProperty("properties", () => NetworkRuleSetProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2018-01-01-preview'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_namespaces_networkRuleSets);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_namespaces_networkRuleSets, () => InstanceLazy.Value.ResourceType_namespaces_networkRuleSets);
        }
        private readonly ResourceType ResourceType_namespaces_networkRuleSets;
        private readonly TypeSymbol NetworkRuleSetProperties;
        private readonly TypeSymbol NWRuleSetIpRules;
    }
}
