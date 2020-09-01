// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_Automation_2018_06_30
    {
        private const string ProviderNamespace = "Microsoft.Automation";
        private const string ApiVersion = "2018-06-30";
        private static readonly ResourceTypeReference ResourceTypeReference_automationAccounts_runbooks = new ResourceTypeReference(ProviderNamespace, new[]{"automationAccounts", "runbooks"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_automationAccounts_python2Packages = new ResourceTypeReference(ProviderNamespace, new[]{"automationAccounts", "python2Packages"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_automationAccounts_runbooks_draft = new ResourceTypeReference(ProviderNamespace, new[]{"automationAccounts", "runbooks", "draft"}, ApiVersion);
        private static Lazy<Microsoft_Automation_2018_06_30> InstanceLazy = new Lazy<Microsoft_Automation_2018_06_30>(() => new Microsoft_Automation_2018_06_30());
        private Microsoft_Automation_2018_06_30()
        {
            RunbookCreateOrUpdateProperties = new NamedObjectType("RunbookCreateOrUpdateProperties", new ITypeProperty[]{new TypeProperty("logVerbose", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("logProgress", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("runbookType", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("draft", () => RunbookDraft, TypePropertyFlags.None), new LazyTypeProperty("publishContentLink", () => ContentLink, TypePropertyFlags.None), new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("logActivityTrace", LanguageConstants.Int, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            RunbookDraft = new NamedObjectType("RunbookDraft", new ITypeProperty[]{new TypeProperty("inEdit", LanguageConstants.Bool, TypePropertyFlags.None), new LazyTypeProperty("draftContentLink", () => ContentLink, TypePropertyFlags.None), new TypeProperty("creationTime", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("lastModifiedTime", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("parameters", new NamedObjectType("parameters", new ITypeProperty[]{}, new NamedObjectType("additionalProperties", new ITypeProperty[]{}, null, TypePropertyFlags.None), TypePropertyFlags.None), TypePropertyFlags.None), new TypeProperty("outputTypes", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ContentLink = new NamedObjectType("ContentLink", new ITypeProperty[]{new TypeProperty("uri", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("contentHash", () => ContentHash, TypePropertyFlags.None), new TypeProperty("version", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ContentHash = new NamedObjectType("ContentHash", new ITypeProperty[]{new TypeProperty("algorithm", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("value", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            RunbookParameter = new NamedObjectType("RunbookParameter", new ITypeProperty[]{new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("isMandatory", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("position", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("defaultValue", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            PythonPackageCreateProperties = new NamedObjectType("PythonPackageCreateProperties", new ITypeProperty[]{new LazyTypeProperty("contentLink", () => ContentLink, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ResourceType_automationAccounts_runbooks = new ResourceType("Microsoft.Automation/automationAccounts/runbooks", new ITypeProperty[]{new LazyTypeProperty("properties", () => RunbookCreateOrUpdateProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_automationAccounts_runbooks);
            ResourceType_automationAccounts_python2Packages = new ResourceType("Microsoft.Automation/automationAccounts/python2Packages", new ITypeProperty[]{new LazyTypeProperty("properties", () => PythonPackageCreateProperties, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_automationAccounts_python2Packages);
            ResourceType_automationAccounts_runbooks_draft = new ResourceType("Microsoft.Automation/automationAccounts/runbooks/draft", new ITypeProperty[]{new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_automationAccounts_runbooks_draft);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_automationAccounts_runbooks, () => InstanceLazy.Value.ResourceType_automationAccounts_runbooks);
            registrar.RegisterType(ResourceTypeReference_automationAccounts_python2Packages, () => InstanceLazy.Value.ResourceType_automationAccounts_python2Packages);
            registrar.RegisterType(ResourceTypeReference_automationAccounts_runbooks_draft, () => InstanceLazy.Value.ResourceType_automationAccounts_runbooks_draft);
        }
        private readonly ResourceType ResourceType_automationAccounts_runbooks;
        private readonly ResourceType ResourceType_automationAccounts_python2Packages;
        private readonly ResourceType ResourceType_automationAccounts_runbooks_draft;
        private readonly TypeSymbol RunbookCreateOrUpdateProperties;
        private readonly TypeSymbol RunbookDraft;
        private readonly TypeSymbol ContentLink;
        private readonly TypeSymbol ContentHash;
        private readonly TypeSymbol RunbookParameter;
        private readonly TypeSymbol PythonPackageCreateProperties;
    }
}
