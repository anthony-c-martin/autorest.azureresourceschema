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
            RemediationProperties = new NamedObjectType("RemediationProperties", new ITypeProperty[]{new TypeProperty("policyAssignmentId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("policyDefinitionReferenceId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("resourceDiscoveryMode", UnionType.Create(new StringLiteralType("'ExistingNonCompliant'"), new StringLiteralType("'ReEvaluateCompliance'")), TypePropertyFlags.None), new TypeProperty("provisioningState", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("createdOn", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("lastUpdatedOn", LanguageConstants.String, TypePropertyFlags.ReadOnly), new LazyTypeProperty("filters", () => RemediationFilters, TypePropertyFlags.None), new LazyTypeProperty("deploymentStatus", () => RemediationDeploymentSummary, TypePropertyFlags.ReadOnly)}, null);
            RemediationFilters = new NamedObjectType("RemediationFilters", new ITypeProperty[]{new TypeProperty("locations", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None)}, null);
            RemediationDeploymentSummary = new NamedObjectType("RemediationDeploymentSummary", new ITypeProperty[]{new TypeProperty("totalDeployments", LanguageConstants.Int, TypePropertyFlags.ReadOnly), new TypeProperty("successfulDeployments", LanguageConstants.Int, TypePropertyFlags.ReadOnly), new TypeProperty("failedDeployments", LanguageConstants.Int, TypePropertyFlags.ReadOnly)}, null);
            ResourceType_remediations = new ResourceType("Microsoft.PolicyInsights/remediations", new ITypeProperty[]{new LazyTypeProperty("properties", () => RemediationProperties, TypePropertyFlags.Required), new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("type", new StringLiteralType("'Microsoft.PolicyInsights/remediations'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2019-07-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_remediations);
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
