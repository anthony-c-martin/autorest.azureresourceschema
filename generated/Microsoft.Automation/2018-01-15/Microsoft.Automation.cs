// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_Automation_2018_01_15
    {
        private const string ProviderNamespace = "Microsoft.Automation";
        private const string ApiVersion = "2018-01-15";
        private static readonly ResourceTypeReference ResourceTypeReference_automationAccounts_compilationjobs = new ResourceTypeReference(ProviderNamespace, new[]{"automationAccounts", "compilationjobs"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_automationAccounts_nodeConfigurations = new ResourceTypeReference(ProviderNamespace, new[]{"automationAccounts", "nodeConfigurations"}, ApiVersion);
        private static Lazy<Microsoft_Automation_2018_01_15> InstanceLazy = new Lazy<Microsoft_Automation_2018_01_15>(() => new Microsoft_Automation_2018_01_15());
        private Microsoft_Automation_2018_01_15()
        {
            DscCompilationJobCreateProperties = new NamedObjectType("DscCompilationJobCreateProperties", new ITypeProperty[]{new LazyTypeProperty("configuration", () => DscConfigurationAssociationProperty, TypePropertyFlags.Required), new TypeProperty("parameters", new NamedObjectType("parameters", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new TypeProperty("incrementNodeConfigurationBuild", LanguageConstants.Bool, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            DscConfigurationAssociationProperty = new NamedObjectType("DscConfigurationAssociationProperty", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            DscNodeConfigurationCreateOrUpdateParametersProperties = new NamedObjectType("DscNodeConfigurationCreateOrUpdateParametersProperties", new ITypeProperty[]{new LazyTypeProperty("source", () => ContentSource, TypePropertyFlags.Required), new LazyTypeProperty("configuration", () => DscConfigurationAssociationProperty, TypePropertyFlags.Required), new TypeProperty("incrementNodeConfigurationBuild", LanguageConstants.Bool, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ContentSource = new NamedObjectType("ContentSource", new ITypeProperty[]{new LazyTypeProperty("hash", () => ContentHash, TypePropertyFlags.None), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("value", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("version", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ContentHash = new NamedObjectType("ContentHash", new ITypeProperty[]{new TypeProperty("algorithm", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("value", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ResourceType_automationAccounts_compilationjobs = new ResourceType("Microsoft.Automation/automationAccounts/compilationjobs", new ITypeProperty[]{new LazyTypeProperty("properties", () => DscCompilationJobCreateProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_automationAccounts_compilationjobs);
            ResourceType_automationAccounts_nodeConfigurations = new ResourceType("Microsoft.Automation/automationAccounts/nodeConfigurations", new ITypeProperty[]{new LazyTypeProperty("properties", () => DscNodeConfigurationCreateOrUpdateParametersProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_automationAccounts_nodeConfigurations);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_automationAccounts_compilationjobs, () => InstanceLazy.Value.ResourceType_automationAccounts_compilationjobs);
            registrar.RegisterType(ResourceTypeReference_automationAccounts_nodeConfigurations, () => InstanceLazy.Value.ResourceType_automationAccounts_nodeConfigurations);
        }
        private readonly ResourceType ResourceType_automationAccounts_compilationjobs;
        private readonly ResourceType ResourceType_automationAccounts_nodeConfigurations;
        private readonly TypeSymbol DscCompilationJobCreateProperties;
        private readonly TypeSymbol DscConfigurationAssociationProperty;
        private readonly TypeSymbol DscNodeConfigurationCreateOrUpdateParametersProperties;
        private readonly TypeSymbol ContentSource;
        private readonly TypeSymbol ContentHash;
    }
}
