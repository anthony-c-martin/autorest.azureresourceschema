// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_PolicyInsights_2019_07_01
    {
        private const string ProviderNamespace = "Microsoft.PolicyInsights";
        private const string ApiVersion = "2019-07-01";
        private static readonly ResourceTypeReference ResourceTypeReference_remediations = new ResourceTypeReference(ProviderNamespace, new[]{"remediations"}, ApiVersion);
        private static Lazy<Microsoft_PolicyInsights_2019_07_01> InstanceLazy = new Lazy<Microsoft_PolicyInsights_2019_07_01>(() => new Microsoft_PolicyInsights_2019_07_01());
        private Microsoft_PolicyInsights_2019_07_01()
        {
            RemediationProperties = new NamedObjectType("RemediationProperties", new ITypeProperty[]{new TypeProperty("policyAssignmentId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("policyDefinitionReferenceId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("resourceDiscoveryMode", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("filters", () => RemediationFilters, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            RemediationFilters = new NamedObjectType("RemediationFilters", new ITypeProperty[]{new TypeProperty("locations", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_remediations = new ResourceType("Microsoft.PolicyInsights/remediations", new ITypeProperty[]{new LazyTypeProperty("properties", () => RemediationProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_remediations);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_remediations, () => InstanceLazy.Value.ResourceType_remediations);
        }
        private readonly ResourceType ResourceType_remediations;
        private readonly TypeSymbol RemediationProperties;
        private readonly TypeSymbol RemediationFilters;
    }
}
