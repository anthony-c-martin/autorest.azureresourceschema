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
            ActionRuleProperties = new DiscriminatedObjectType("ActionRuleProperties", "type", new ITypeProperty[]{new LazyTypeProperty("ActionRuleProperties", () => Diagnostics, TypePropertyFlags.None)});
            Scope = new NamedObjectType("Scope", new ITypeProperty[]{new TypeProperty("scopeType", UnionType.Create(new StringLiteralType("'ResourceGroup'"), new StringLiteralType("'Resource'"), new StringLiteralType("'Subscription'")), TypePropertyFlags.None), new TypeProperty("values", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None)}, null);
            Conditions = new NamedObjectType("Conditions", new ITypeProperty[]{new LazyTypeProperty("severity", () => Condition, TypePropertyFlags.None), new LazyTypeProperty("monitorService", () => Condition, TypePropertyFlags.None), new LazyTypeProperty("monitorCondition", () => Condition, TypePropertyFlags.None), new LazyTypeProperty("targetResourceType", () => Condition, TypePropertyFlags.None), new LazyTypeProperty("alertRuleId", () => Condition, TypePropertyFlags.None), new LazyTypeProperty("description", () => Condition, TypePropertyFlags.None), new LazyTypeProperty("alertContext", () => Condition, TypePropertyFlags.None)}, null);
            Condition = new NamedObjectType("Condition", new ITypeProperty[]{new TypeProperty("operator", UnionType.Create(new StringLiteralType("'Equals'"), new StringLiteralType("'NotEquals'"), new StringLiteralType("'Contains'"), new StringLiteralType("'DoesNotContain'")), TypePropertyFlags.None), new TypeProperty("values", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None)}, null);
            Diagnostics = new NamedObjectType("Diagnostics", new ITypeProperty[]{new TypeProperty("type", new StringLiteralType("'Diagnostics'"), TypePropertyFlags.Required), new LazyTypeProperty("scope", () => Scope, TypePropertyFlags.None), new LazyTypeProperty("conditions", () => Conditions, TypePropertyFlags.None), new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("createdAt", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("lastModifiedAt", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("createdBy", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("lastModifiedBy", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("status", UnionType.Create(new StringLiteralType("'Enabled'"), new StringLiteralType("'Disabled'")), TypePropertyFlags.None)}, null);
            ResourceType_actionRules = new ResourceType("Microsoft.AlertsManagement/actionRules", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("type", new StringLiteralType("'Microsoft.AlertsManagement/actionRules'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("properties", () => ActionRuleProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2019-05-05-preview'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_actionRules);
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
