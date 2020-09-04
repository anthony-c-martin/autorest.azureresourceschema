// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_Consumption_2018_03_31
    {
        private const string ProviderNamespace = "Microsoft.Consumption";
        private const string ApiVersion = "2018-03-31";
        private static readonly ResourceTypeReference ResourceTypeReference_budgets = new ResourceTypeReference(ProviderNamespace, new[]{"budgets"}, ApiVersion);
        private static Lazy<Microsoft_Consumption_2018_03_31> InstanceLazy = new Lazy<Microsoft_Consumption_2018_03_31>(() => new Microsoft_Consumption_2018_03_31());
        private Microsoft_Consumption_2018_03_31()
        {
            BudgetProperties = new NamedObjectType("BudgetProperties", new ITypeProperty[]{new TypeProperty("category", UnionType.Create(new StringLiteralType("'Cost'"), new StringLiteralType("'Usage'")), TypePropertyFlags.Required), new TypeProperty("amount", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("timeGrain", UnionType.Create(new StringLiteralType("'Monthly'"), new StringLiteralType("'Quarterly'"), new StringLiteralType("'Annually'")), TypePropertyFlags.Required), new LazyTypeProperty("timePeriod", () => BudgetTimePeriod, TypePropertyFlags.Required), new LazyTypeProperty("filters", () => Filters, TypePropertyFlags.None), new LazyTypeProperty("currentSpend", () => CurrentSpend, TypePropertyFlags.ReadOnly), new TypeProperty("notifications", new NamedObjectType("notifications", new ITypeProperty[]{}, new LazyTypeProperty("additionalProperties", () => Notification, TypePropertyFlags.None)), TypePropertyFlags.None)}, null);
            BudgetTimePeriod = new NamedObjectType("BudgetTimePeriod", new ITypeProperty[]{new TypeProperty("startDate", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("endDate", LanguageConstants.String, TypePropertyFlags.None)}, null);
            Filters = new NamedObjectType("Filters", new ITypeProperty[]{new TypeProperty("resourceGroups", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new TypeProperty("resources", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new TypeProperty("meters", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None)), TypePropertyFlags.None)}, null);
            CurrentSpend = new NamedObjectType("CurrentSpend", new ITypeProperty[]{new TypeProperty("amount", LanguageConstants.Int, TypePropertyFlags.ReadOnly), new TypeProperty("unit", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            Notification = new NamedObjectType("Notification", new ITypeProperty[]{new TypeProperty("enabled", LanguageConstants.Bool, TypePropertyFlags.Required), new TypeProperty("operator", UnionType.Create(new StringLiteralType("'EqualTo'"), new StringLiteralType("'GreaterThan'"), new StringLiteralType("'GreaterThanOrEqualTo'")), TypePropertyFlags.Required), new TypeProperty("threshold", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("contactEmails", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.Required), new TypeProperty("contactRoles", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new TypeProperty("contactGroups", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None)}, null);
            CostTagProperties = new NamedObjectType("CostTagProperties", new ITypeProperty[]{new LazyTypeProperty("costTags", () => new TypedArrayType(CostTag), TypePropertyFlags.None)}, null);
            CostTag = new NamedObjectType("CostTag", new ITypeProperty[]{new TypeProperty("key", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ResourceType_budgets = new ResourceType("Microsoft.Consumption/budgets", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.Consumption/budgets'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("eTag", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("properties", () => BudgetProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2018-03-31'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_budgets);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_budgets, () => InstanceLazy.Value.ResourceType_budgets);
        }
        private readonly ResourceType ResourceType_budgets;
        private readonly TypeSymbol BudgetProperties;
        private readonly TypeSymbol BudgetTimePeriod;
        private readonly TypeSymbol Filters;
        private readonly TypeSymbol CurrentSpend;
        private readonly TypeSymbol Notification;
        private readonly TypeSymbol CostTagProperties;
        private readonly TypeSymbol CostTag;
    }
}
