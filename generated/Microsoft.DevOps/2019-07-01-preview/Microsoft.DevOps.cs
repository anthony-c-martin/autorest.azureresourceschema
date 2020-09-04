// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_DevOps_2019_07_01_preview
    {
        private const string ProviderNamespace = "Microsoft.DevOps";
        private const string ApiVersion = "2019-07-01-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_pipelines = new ResourceTypeReference(ProviderNamespace, new[]{"pipelines"}, ApiVersion);
        private static Lazy<Microsoft_DevOps_2019_07_01_preview> InstanceLazy = new Lazy<Microsoft_DevOps_2019_07_01_preview>(() => new Microsoft_DevOps_2019_07_01_preview());
        private Microsoft_DevOps_2019_07_01_preview()
        {
            PipelineProperties = new NamedObjectType("PipelineProperties", new ITypeProperty[]{new TypeProperty("pipelineId", LanguageConstants.Int, TypePropertyFlags.ReadOnly), new LazyTypeProperty("organization", () => OrganizationReference, TypePropertyFlags.Required), new LazyTypeProperty("project", () => ProjectReference, TypePropertyFlags.Required), new LazyTypeProperty("bootstrapConfiguration", () => BootstrapConfiguration, TypePropertyFlags.Required)}, null);
            OrganizationReference = new NamedObjectType("OrganizationReference", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required)}, null);
            ProjectReference = new NamedObjectType("ProjectReference", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required)}, null);
            BootstrapConfiguration = new NamedObjectType("BootstrapConfiguration", new ITypeProperty[]{new LazyTypeProperty("repository", () => CodeRepository, TypePropertyFlags.None), new LazyTypeProperty("template", () => PipelineTemplate, TypePropertyFlags.Required)}, null);
            CodeRepository = new NamedObjectType("CodeRepository", new ITypeProperty[]{new TypeProperty("repositoryType", UnionType.Create(new StringLiteralType("'gitHub'"), new StringLiteralType("'vstsGit'")), TypePropertyFlags.Required), new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("defaultBranch", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("authorization", () => Authorization, TypePropertyFlags.None), new TypeProperty("properties", new NamedObjectType("properties", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None)}, null);
            Authorization = new NamedObjectType("Authorization", new ITypeProperty[]{new TypeProperty("authorizationType", new StringLiteralType("'personalAccessToken'"), TypePropertyFlags.Required), new TypeProperty("parameters", new NamedObjectType("parameters", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None)}, null);
            PipelineTemplate = new NamedObjectType("PipelineTemplate", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("parameters", new NamedObjectType("parameters", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None)}, null);
            ResourceType_pipelines = new ResourceType("Microsoft.DevOps/pipelines", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("type", new StringLiteralType("'Microsoft.DevOps/pipelines'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new LazyTypeProperty("properties", () => PipelineProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2019-07-01-preview'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_pipelines);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_pipelines, () => InstanceLazy.Value.ResourceType_pipelines);
        }
        private readonly ResourceType ResourceType_pipelines;
        private readonly TypeSymbol PipelineProperties;
        private readonly TypeSymbol OrganizationReference;
        private readonly TypeSymbol ProjectReference;
        private readonly TypeSymbol BootstrapConfiguration;
        private readonly TypeSymbol CodeRepository;
        private readonly TypeSymbol Authorization;
        private readonly TypeSymbol PipelineTemplate;
    }
}
