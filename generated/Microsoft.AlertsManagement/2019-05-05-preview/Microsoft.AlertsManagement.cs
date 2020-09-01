// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_AlertsManagement_2019_05_05_preview
    {
        private const string ProviderNamespace = "Microsoft.AlertsManagement";
        private const string ApiVersion = "2019-05-05-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_actionRules = new ResourceTypeReference(ProviderNamespace, new[]{"actionRules"}, ApiVersion);
        private static Lazy<Microsoft_AlertsManagement_2019_05_05_preview> InstanceLazy = new Lazy<Microsoft_AlertsManagement_2019_05_05_preview>(() => new Microsoft_AlertsManagement_2019_05_05_preview());
        private Microsoft_AlertsManagement_2019_05_05_preview()
        {
            ActionRuleProperties = new NamedObjectType("ActionRuleProperties", new ITypeProperty[]{new LazyTypeProperty("scope", () => Scope, TypePropertyFlags.None), new LazyTypeProperty("conditions", () => Conditions, TypePropertyFlags.None), new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("status", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            Scope = new NamedObjectType("Scope", new ITypeProperty[]{new TypeProperty("scopeType", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("values", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            Conditions = new NamedObjectType("Conditions", new ITypeProperty[]{new LazyTypeProperty("severity", () => Condition, TypePropertyFlags.None), new LazyTypeProperty("monitorService", () => Condition, TypePropertyFlags.None), new LazyTypeProperty("monitorCondition", () => Condition, TypePropertyFlags.None), new LazyTypeProperty("targetResourceType", () => Condition, TypePropertyFlags.None), new LazyTypeProperty("alertRuleId", () => Condition, TypePropertyFlags.None), new LazyTypeProperty("description", () => Condition, TypePropertyFlags.None), new LazyTypeProperty("alertContext", () => Condition, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            Condition = new NamedObjectType("Condition", new ITypeProperty[]{new TypeProperty("operator", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("values", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            Diagnostics = new NamedObjectType("Diagnostics", new ITypeProperty[]{new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ResourceType_actionRules = new ResourceType("Microsoft.AlertsManagement/actionRules", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new LazyTypeProperty("properties", () => ActionRuleProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_actionRules);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_actionRules, () => InstanceLazy.Value.ResourceType_actionRules);
        }
        private readonly ResourceType ResourceType_actionRules;
        private readonly TypeSymbol ActionRuleProperties;
        private readonly TypeSymbol Scope;
        private readonly TypeSymbol Conditions;
        private readonly TypeSymbol Condition;
        private readonly TypeSymbol Diagnostics;
    }
}
