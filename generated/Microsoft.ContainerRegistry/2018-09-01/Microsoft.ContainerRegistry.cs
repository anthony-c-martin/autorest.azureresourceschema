// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_ContainerRegistry_2018_09_01
    {
        private const string ProviderNamespace = "Microsoft.ContainerRegistry";
        private const string ApiVersion = "2018-09-01";
        private static readonly ResourceTypeReference ResourceTypeReference_registries_tasks = new ResourceTypeReference(ProviderNamespace, new[]{"registries", "tasks"}, ApiVersion);
        private static Lazy<Microsoft_ContainerRegistry_2018_09_01> InstanceLazy = new Lazy<Microsoft_ContainerRegistry_2018_09_01>(() => new Microsoft_ContainerRegistry_2018_09_01());
        private Microsoft_ContainerRegistry_2018_09_01()
        {
            TaskProperties = new NamedObjectType("TaskProperties", new ITypeProperty[]{new TypeProperty("status", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("platform", () => PlatformProperties, TypePropertyFlags.Required), new LazyTypeProperty("agentConfiguration", () => AgentProperties, TypePropertyFlags.None), new TypeProperty("timeout", LanguageConstants.Int, TypePropertyFlags.None), new LazyTypeProperty("step", () => TaskStepProperties, TypePropertyFlags.Required), new LazyTypeProperty("trigger", () => TriggerProperties, TypePropertyFlags.None), new LazyTypeProperty("credentials", () => Credentials, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            PlatformProperties = new NamedObjectType("PlatformProperties", new ITypeProperty[]{new TypeProperty("os", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("architecture", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("variant", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            AgentProperties = new NamedObjectType("AgentProperties", new ITypeProperty[]{new TypeProperty("cpu", LanguageConstants.Int, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            TaskStepProperties = new NamedObjectType("TaskStepProperties", new ITypeProperty[]{new TypeProperty("contextPath", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("contextAccessToken", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            DockerBuildStep = new NamedObjectType("DockerBuildStep", new ITypeProperty[]{new TypeProperty("imageNames", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new TypeProperty("isPushEnabled", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("noCache", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("dockerFilePath", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("target", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("arguments", new TypedArrayType(new NamedObjectType("arguments", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            Argument = new NamedObjectType("Argument", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("value", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("isSecret", LanguageConstants.Bool, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            FileTaskStep = new NamedObjectType("FileTaskStep", new ITypeProperty[]{new TypeProperty("taskFilePath", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("valuesFilePath", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("values", new TypedArrayType(new NamedObjectType("values", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            SetValue = new NamedObjectType("SetValue", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("value", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("isSecret", LanguageConstants.Bool, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            EncodedTaskStep = new NamedObjectType("EncodedTaskStep", new ITypeProperty[]{new TypeProperty("encodedTaskContent", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("encodedValuesContent", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("values", new TypedArrayType(new NamedObjectType("values", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            TriggerProperties = new NamedObjectType("TriggerProperties", new ITypeProperty[]{new TypeProperty("sourceTriggers", new TypedArrayType(new NamedObjectType("sourceTriggers", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("baseImageTrigger", () => BaseImageTrigger, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            SourceTrigger = new NamedObjectType("SourceTrigger", new ITypeProperty[]{new LazyTypeProperty("sourceRepository", () => SourceProperties, TypePropertyFlags.Required), new TypeProperty("sourceTriggerEvents", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.Required), new TypeProperty("status", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            SourceProperties = new NamedObjectType("SourceProperties", new ITypeProperty[]{new TypeProperty("sourceControlType", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("repositoryUrl", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("branch", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("sourceControlAuthProperties", () => AuthInfo, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            AuthInfo = new NamedObjectType("AuthInfo", new ITypeProperty[]{new TypeProperty("tokenType", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("token", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("refreshToken", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("scope", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("expiresIn", LanguageConstants.Int, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            BaseImageTrigger = new NamedObjectType("BaseImageTrigger", new ITypeProperty[]{new TypeProperty("baseImageTriggerType", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("status", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            Credentials = new NamedObjectType("Credentials", new ITypeProperty[]{new LazyTypeProperty("sourceRegistry", () => SourceRegistryCredentials, TypePropertyFlags.None), new TypeProperty("customRegistries", new NamedObjectType("customRegistries", new ITypeProperty[]{}, new NamedObjectType("additionalProperties", new ITypeProperty[]{}, null, TypePropertyFlags.None), TypePropertyFlags.None), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            SourceRegistryCredentials = new NamedObjectType("SourceRegistryCredentials", new ITypeProperty[]{new TypeProperty("loginMode", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            CustomRegistryCredentials = new NamedObjectType("CustomRegistryCredentials", new ITypeProperty[]{new LazyTypeProperty("userName", () => SecretObject, TypePropertyFlags.None), new LazyTypeProperty("password", () => SecretObject, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            SecretObject = new NamedObjectType("SecretObject", new ITypeProperty[]{new TypeProperty("value", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_registries_tasks = new ResourceType("Microsoft.ContainerRegistry/registries/tasks", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new LazyTypeProperty("properties", () => TaskProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_registries_tasks);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_registries_tasks, () => InstanceLazy.Value.ResourceType_registries_tasks);
        }
        private readonly ResourceType ResourceType_registries_tasks;
        private readonly TypeSymbol TaskProperties;
        private readonly TypeSymbol PlatformProperties;
        private readonly TypeSymbol AgentProperties;
        private readonly TypeSymbol TaskStepProperties;
        private readonly TypeSymbol DockerBuildStep;
        private readonly TypeSymbol Argument;
        private readonly TypeSymbol FileTaskStep;
        private readonly TypeSymbol SetValue;
        private readonly TypeSymbol EncodedTaskStep;
        private readonly TypeSymbol TriggerProperties;
        private readonly TypeSymbol SourceTrigger;
        private readonly TypeSymbol SourceProperties;
        private readonly TypeSymbol AuthInfo;
        private readonly TypeSymbol BaseImageTrigger;
        private readonly TypeSymbol Credentials;
        private readonly TypeSymbol SourceRegistryCredentials;
        private readonly TypeSymbol CustomRegistryCredentials;
        private readonly TypeSymbol SecretObject;
    }
}
