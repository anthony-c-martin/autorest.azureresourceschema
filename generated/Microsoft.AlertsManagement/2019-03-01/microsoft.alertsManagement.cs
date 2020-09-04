// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_alertsManagement_2019_03_01
    {
        private const string ProviderNamespace = "microsoft.alertsManagement";
        private const string ApiVersion = "2019-03-01";
        private static readonly ResourceTypeReference ResourceTypeReference_smartDetectorAlertRules = new ResourceTypeReference(ProviderNamespace, new[]{"smartDetectorAlertRules"}, ApiVersion);
        private static Lazy<Microsoft_alertsManagement_2019_03_01> InstanceLazy = new Lazy<Microsoft_alertsManagement_2019_03_01>(() => new Microsoft_alertsManagement_2019_03_01());
        private Microsoft_alertsManagement_2019_03_01()
        {
            AlertRuleProperties = new NamedObjectType("AlertRuleProperties", new ITypeProperty[]{new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("state", UnionType.Create(new StringLiteralType("'Enabled'"), new StringLiteralType("'Disabled'")), TypePropertyFlags.Required), new TypeProperty("severity", UnionType.Create(new StringLiteralType("'Sev0'"), new StringLiteralType("'Sev1'"), new StringLiteralType("'Sev2'"), new StringLiteralType("'Sev3'"), new StringLiteralType("'Sev4'")), TypePropertyFlags.Required), new TypeProperty("frequency", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("detector", () => Detector, TypePropertyFlags.Required), new TypeProperty("scope", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.Required), new LazyTypeProperty("actionGroups", () => ActionGroupsInformation, TypePropertyFlags.Required), new LazyTypeProperty("throttling", () => ThrottlingInformation, TypePropertyFlags.None)}, null);
            Detector = new NamedObjectType("Detector", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("parameters", new NamedObjectType("parameters", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.Any, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("supportedResourceTypes", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new TypeProperty("imagePaths", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None)}, null);
            ActionGroupsInformation = new NamedObjectType("ActionGroupsInformation", new ITypeProperty[]{new TypeProperty("customEmailSubject", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("customWebhookPayload", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("groupIds", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.Required)}, null);
            ThrottlingInformation = new NamedObjectType("ThrottlingInformation", new ITypeProperty[]{new TypeProperty("duration", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ResourceType_smartDetectorAlertRules = new ResourceType("microsoft.alertsManagement/smartDetectorAlertRules", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("type", new StringLiteralType("'microsoft.alertsManagement/smartDetectorAlertRules'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new LazyTypeProperty("properties", () => AlertRuleProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2019-03-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_smartDetectorAlertRules);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_smartDetectorAlertRules, () => InstanceLazy.Value.ResourceType_smartDetectorAlertRules);
        }
        private readonly ResourceType ResourceType_smartDetectorAlertRules;
        private readonly TypeSymbol AlertRuleProperties;
        private readonly TypeSymbol Detector;
        private readonly TypeSymbol ActionGroupsInformation;
        private readonly TypeSymbol ThrottlingInformation;
    }
}
