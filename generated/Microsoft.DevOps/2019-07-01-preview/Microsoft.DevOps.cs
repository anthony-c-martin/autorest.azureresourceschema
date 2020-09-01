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
            PipelineProperties = new NamedObjectType("PipelineProperties", new ITypeProperty[]{new LazyTypeProperty("organization", () => OrganizationReference, TypePropertyFlags.Required), new LazyTypeProperty("project", () => ProjectReference, TypePropertyFlags.Required), new LazyTypeProperty("bootstrapConfiguration", () => BootstrapConfiguration, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            OrganizationReference = new NamedObjectType("OrganizationReference", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ProjectReference = new NamedObjectType("ProjectReference", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            BootstrapConfiguration = new NamedObjectType("BootstrapConfiguration", new ITypeProperty[]{new LazyTypeProperty("repository", () => CodeRepository, TypePropertyFlags.None), new LazyTypeProperty("template", () => PipelineTemplate, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            CodeRepository = new NamedObjectType("CodeRepository", new ITypeProperty[]{new TypeProperty("repositoryType", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("defaultBranch", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("authorization", () => Authorization, TypePropertyFlags.None), new TypeProperty("properties", new NamedObjectType("properties", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            Authorization = new NamedObjectType("Authorization", new ITypeProperty[]{new TypeProperty("authorizationType", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("parameters", new NamedObjectType("parameters", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            PipelineTemplate = new NamedObjectType("PipelineTemplate", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("parameters", new NamedObjectType("parameters", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_pipelines = new ResourceType("Microsoft.DevOps/pipelines", new ITypeProperty[]{new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("properties", () => PipelineProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_pipelines);
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
