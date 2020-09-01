// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_ContainerRegistry_2018_02_01_preview
    {
        private const string ProviderNamespace = "Microsoft.ContainerRegistry";
        private const string ApiVersion = "2018-02-01-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_registries_buildTasks = new ResourceTypeReference(ProviderNamespace, new[]{"registries", "buildTasks"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_registries_buildTasks_steps = new ResourceTypeReference(ProviderNamespace, new[]{"registries", "buildTasks", "steps"}, ApiVersion);
        private static Lazy<Microsoft_ContainerRegistry_2018_02_01_preview> InstanceLazy = new Lazy<Microsoft_ContainerRegistry_2018_02_01_preview>(() => new Microsoft_ContainerRegistry_2018_02_01_preview());
        private Microsoft_ContainerRegistry_2018_02_01_preview()
        {
            BuildStepProperties = new NamedObjectType("BuildStepProperties", new ITypeProperty[]{}, null, TypePropertyFlags.None);
            DockerBuildStep = new NamedObjectType("DockerBuildStep", new ITypeProperty[]{new TypeProperty("branch", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("imageNames", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new TypeProperty("isPushEnabled", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("noCache", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("dockerFilePath", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("contextPath", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("buildArguments", new TypedArrayType(new NamedObjectType("buildArguments", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("baseImageTrigger", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            BuildArgument = new NamedObjectType("BuildArgument", new ITypeProperty[]{new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("value", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("isSecret", LanguageConstants.Bool, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            BuildTaskProperties = new NamedObjectType("BuildTaskProperties", new ITypeProperty[]{new TypeProperty("alias", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("status", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("sourceRepository", () => SourceRepositoryProperties, TypePropertyFlags.Required), new LazyTypeProperty("platform", () => PlatformProperties, TypePropertyFlags.Required), new TypeProperty("timeout", LanguageConstants.Int, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            SourceRepositoryProperties = new NamedObjectType("SourceRepositoryProperties", new ITypeProperty[]{new TypeProperty("sourceControlType", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("repositoryUrl", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("isCommitTriggerEnabled", LanguageConstants.Bool, TypePropertyFlags.None), new LazyTypeProperty("sourceControlAuthProperties", () => SourceControlAuthInfo, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            SourceControlAuthInfo = new NamedObjectType("SourceControlAuthInfo", new ITypeProperty[]{new TypeProperty("tokenType", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("token", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("refreshToken", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("scope", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("expiresIn", LanguageConstants.Int, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            PlatformProperties = new NamedObjectType("PlatformProperties", new ITypeProperty[]{new TypeProperty("osType", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("cpu", LanguageConstants.Int, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_registries_buildTasks = new ResourceType("Microsoft.ContainerRegistry/registries/buildTasks", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new LazyTypeProperty("properties", () => BuildTaskProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_registries_buildTasks);
            ResourceType_registries_buildTasks_steps = new ResourceType("Microsoft.ContainerRegistry/registries/buildTasks/steps", new ITypeProperty[]{new LazyTypeProperty("properties", () => BuildStepProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_registries_buildTasks_steps);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_registries_buildTasks, () => InstanceLazy.Value.ResourceType_registries_buildTasks);
            registrar.RegisterType(ResourceTypeReference_registries_buildTasks_steps, () => InstanceLazy.Value.ResourceType_registries_buildTasks_steps);
        }
        private readonly ResourceType ResourceType_registries_buildTasks;
        private readonly ResourceType ResourceType_registries_buildTasks_steps;
        private readonly TypeSymbol BuildStepProperties;
        private readonly TypeSymbol DockerBuildStep;
        private readonly TypeSymbol BuildArgument;
        private readonly TypeSymbol BuildTaskProperties;
        private readonly TypeSymbol SourceRepositoryProperties;
        private readonly TypeSymbol SourceControlAuthInfo;
        private readonly TypeSymbol PlatformProperties;
    }
}
