// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_PolicyInsights_2018_07_01_preview
    {
        private const string ProviderNamespace = "Microsoft.PolicyInsights";
        private const string ApiVersion = "2018-07-01-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_remediations = new ResourceTypeReference(ProviderNamespace, new[]{"remediations"}, ApiVersion);
        private static Lazy<Microsoft_PolicyInsights_2018_07_01_preview> InstanceLazy = new Lazy<Microsoft_PolicyInsights_2018_07_01_preview>(() => new Microsoft_PolicyInsights_2018_07_01_preview());
        private Microsoft_PolicyInsights_2018_07_01_preview()
        {
            RemediationProperties = new NamedObjectType("RemediationProperties", new ITypeProperty[]{new TypeProperty("policyAssignmentId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("policyDefinitionReferenceId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("provisioningState", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("createdOn", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("lastUpdatedOn", LanguageConstants.String, TypePropertyFlags.ReadOnly), new LazyTypeProperty("filters", () => RemediationFilters, TypePropertyFlags.None), new LazyTypeProperty("deploymentStatus", () => RemediationDeploymentSummary, TypePropertyFlags.None)}, null);
            RemediationFilters = new NamedObjectType("RemediationFilters", new ITypeProperty[]{new TypeProperty("locations", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None)}, null);
            RemediationDeploymentSummary = new NamedObjectType("RemediationDeploymentSummary", new ITypeProperty[]{new TypeProperty("totalDeployments", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("successfulDeployments", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("failedDeployments", LanguageConstants.Int, TypePropertyFlags.None)}, null);
            ResourceType_remediations = new ResourceType("Microsoft.PolicyInsights/remediations", new ITypeProperty[]{new LazyTypeProperty("properties", () => RemediationProperties, TypePropertyFlags.Required), new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("type", new StringLiteralType("'Microsoft.PolicyInsights/remediations'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2018-07-01-preview'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_remediations);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_remediations, () => InstanceLazy.Value.ResourceType_remediations);
        }
        private readonly ResourceType ResourceType_remediations;
        private readonly TypeSymbol RemediationProperties;
        private readonly TypeSymbol RemediationFilters;
        private readonly TypeSymbol RemediationDeploymentSummary;
    }
}
