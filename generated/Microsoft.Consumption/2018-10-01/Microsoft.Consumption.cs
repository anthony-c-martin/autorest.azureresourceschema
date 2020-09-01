// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_Consumption_2018_10_01
    {
        private const string ProviderNamespace = "Microsoft.Consumption";
        private const string ApiVersion = "2018-10-01";
        private static readonly ResourceTypeReference ResourceTypeReference_budgets = new ResourceTypeReference(ProviderNamespace, new[]{"budgets"}, ApiVersion);
        private static Lazy<Microsoft_Consumption_2018_10_01> InstanceLazy = new Lazy<Microsoft_Consumption_2018_10_01>(() => new Microsoft_Consumption_2018_10_01());
        private Microsoft_Consumption_2018_10_01()
        {
            BudgetProperties = new NamedObjectType("BudgetProperties", new ITypeProperty[]{new TypeProperty("category", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("amount", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("timeGrain", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("timePeriod", () => BudgetTimePeriod, TypePropertyFlags.Required), new LazyTypeProperty("filters", () => Filters, TypePropertyFlags.None), new TypeProperty("notifications", new NamedObjectType("notifications", new ITypeProperty[]{}, new NamedObjectType("additionalProperties", new ITypeProperty[]{}, null, TypePropertyFlags.None), TypePropertyFlags.None), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            BudgetTimePeriod = new NamedObjectType("BudgetTimePeriod", new ITypeProperty[]{new TypeProperty("startDate", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("endDate", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            Filters = new NamedObjectType("Filters", new ITypeProperty[]{new TypeProperty("resourceGroups", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new TypeProperty("resources", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new TypeProperty("meters", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            Notification = new NamedObjectType("Notification", new ITypeProperty[]{new TypeProperty("enabled", LanguageConstants.Bool, TypePropertyFlags.Required), new TypeProperty("operator", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("threshold", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("contactEmails", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.Required), new TypeProperty("contactRoles", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new TypeProperty("contactGroups", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_budgets = new ResourceType("Microsoft.Consumption/budgets", new ITypeProperty[]{new TypeProperty("eTag", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("properties", () => BudgetProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_budgets);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_budgets, () => InstanceLazy.Value.ResourceType_budgets);
        }
        private readonly ResourceType ResourceType_budgets;
        private readonly TypeSymbol BudgetProperties;
        private readonly TypeSymbol BudgetTimePeriod;
        private readonly TypeSymbol Filters;
        private readonly TypeSymbol Notification;
    }
}
