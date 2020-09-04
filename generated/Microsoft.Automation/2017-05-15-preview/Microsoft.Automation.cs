// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_Automation_2017_05_15_preview
    {
        private const string ProviderNamespace = "Microsoft.Automation";
        private const string ApiVersion = "2017-05-15-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_automationAccounts_softwareUpdateConfigurations = new ResourceTypeReference(ProviderNamespace, new[]{"automationAccounts", "softwareUpdateConfigurations"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_automationAccounts_sourceControls = new ResourceTypeReference(ProviderNamespace, new[]{"automationAccounts", "sourceControls"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_automationAccounts_jobs = new ResourceTypeReference(ProviderNamespace, new[]{"automationAccounts", "jobs"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_automationAccounts_sourceControls_sourceControlSyncJobs = new ResourceTypeReference(ProviderNamespace, new[]{"automationAccounts", "sourceControls", "sourceControlSyncJobs"}, ApiVersion);
        private static Lazy<Microsoft_Automation_2017_05_15_preview> InstanceLazy = new Lazy<Microsoft_Automation_2017_05_15_preview>(() => new Microsoft_Automation_2017_05_15_preview());
        private Microsoft_Automation_2017_05_15_preview()
        {
            SoftwareUpdateConfigurationProperties = new NamedObjectType("SoftwareUpdateConfigurationProperties", new ITypeProperty[]{new LazyTypeProperty("updateConfiguration", () => UpdateConfiguration, TypePropertyFlags.Required), new LazyTypeProperty("scheduleInfo", () => ScheduleProperties, TypePropertyFlags.Required), new TypeProperty("provisioningState", LanguageConstants.String, TypePropertyFlags.ReadOnly), new LazyTypeProperty("error", () => ErrorResponse, TypePropertyFlags.None), new TypeProperty("creationTime", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("createdBy", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("lastModifiedTime", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("lastModifiedBy", LanguageConstants.String, TypePropertyFlags.ReadOnly), new LazyTypeProperty("tasks", () => SoftwareUpdateConfigurationTasks, TypePropertyFlags.None)}, null);
            UpdateConfiguration = new NamedObjectType("UpdateConfiguration", new ITypeProperty[]{new TypeProperty("operatingSystem", UnionType.Create(new StringLiteralType("'Windows'"), new StringLiteralType("'Linux'")), TypePropertyFlags.Required), new LazyTypeProperty("windows", () => WindowsProperties, TypePropertyFlags.None), new LazyTypeProperty("linux", () => LinuxProperties, TypePropertyFlags.None), new TypeProperty("duration", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("azureVirtualMachines", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new TypeProperty("nonAzureComputerNames", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new LazyTypeProperty("targets", () => TargetProperties, TypePropertyFlags.None)}, null);
            WindowsProperties = new NamedObjectType("WindowsProperties", new ITypeProperty[]{new TypeProperty("includedUpdateClassifications", UnionType.Create(new StringLiteralType("'Unclassified'"), new StringLiteralType("'Critical'"), new StringLiteralType("'Security'"), new StringLiteralType("'UpdateRollup'"), new StringLiteralType("'FeaturePack'"), new StringLiteralType("'ServicePack'"), new StringLiteralType("'Definition'"), new StringLiteralType("'Tools'"), new StringLiteralType("'Updates'")), TypePropertyFlags.None), new TypeProperty("excludedKbNumbers", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new TypeProperty("includedKbNumbers", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new TypeProperty("rebootSetting", LanguageConstants.String, TypePropertyFlags.None)}, null);
            LinuxProperties = new NamedObjectType("LinuxProperties", new ITypeProperty[]{new TypeProperty("includedPackageClassifications", UnionType.Create(new StringLiteralType("'Unclassified'"), new StringLiteralType("'Critical'"), new StringLiteralType("'Security'"), new StringLiteralType("'Other'")), TypePropertyFlags.None), new TypeProperty("excludedPackageNameMasks", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new TypeProperty("includedPackageNameMasks", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new TypeProperty("rebootSetting", LanguageConstants.String, TypePropertyFlags.None)}, null);
            TargetProperties = new NamedObjectType("TargetProperties", new ITypeProperty[]{new LazyTypeProperty("azureQueries", () => new TypedArrayType(AzureQueryProperties), TypePropertyFlags.None), new LazyTypeProperty("nonAzureQueries", () => new TypedArrayType(NonAzureQueryProperties), TypePropertyFlags.None)}, null);
            AzureQueryProperties = new NamedObjectType("AzureQueryProperties", new ITypeProperty[]{new TypeProperty("scope", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new TypeProperty("locations", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new LazyTypeProperty("tagSettings", () => TagSettingsProperties, TypePropertyFlags.None)}, null);
            TagSettingsProperties = new NamedObjectType("TagSettingsProperties", new ITypeProperty[]{new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("filterOperator", UnionType.Create(new StringLiteralType("'All'"), new StringLiteralType("'Any'")), TypePropertyFlags.None)}, null);
            NonAzureQueryProperties = new NamedObjectType("NonAzureQueryProperties", new ITypeProperty[]{new TypeProperty("functionAlias", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("workspaceId", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ScheduleProperties = new NamedObjectType("ScheduleProperties", new ITypeProperty[]{new TypeProperty("startTime", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("startTimeOffsetMinutes", LanguageConstants.Int, TypePropertyFlags.ReadOnly), new TypeProperty("expiryTime", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("expiryTimeOffsetMinutes", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("isEnabled", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("nextRun", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("nextRunOffsetMinutes", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("interval", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("frequency", UnionType.Create(new StringLiteralType("'OneTime'"), new StringLiteralType("'Day'"), new StringLiteralType("'Hour'"), new StringLiteralType("'Week'"), new StringLiteralType("'Month'"), new StringLiteralType("'Minute'")), TypePropertyFlags.None), new TypeProperty("timeZone", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("advancedSchedule", () => AdvancedSchedule, TypePropertyFlags.None), new TypeProperty("creationTime", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("lastModifiedTime", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None)}, null);
            AdvancedSchedule = new NamedObjectType("AdvancedSchedule", new ITypeProperty[]{new TypeProperty("weekDays", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new TypeProperty("monthDays", new TypedArrayType(LanguageConstants.Int), TypePropertyFlags.None), new LazyTypeProperty("monthlyOccurrences", () => new TypedArrayType(AdvancedScheduleMonthlyOccurrence), TypePropertyFlags.None)}, null);
            AdvancedScheduleMonthlyOccurrence = new NamedObjectType("AdvancedScheduleMonthlyOccurrence", new ITypeProperty[]{new TypeProperty("occurrence", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("day", UnionType.Create(new StringLiteralType("'Monday'"), new StringLiteralType("'Tuesday'"), new StringLiteralType("'Wednesday'"), new StringLiteralType("'Thursday'"), new StringLiteralType("'Friday'"), new StringLiteralType("'Saturday'"), new StringLiteralType("'Sunday'")), TypePropertyFlags.None)}, null);
            ErrorResponse = new NamedObjectType("ErrorResponse", new ITypeProperty[]{new TypeProperty("code", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("message", LanguageConstants.String, TypePropertyFlags.None)}, null);
            SoftwareUpdateConfigurationTasks = new NamedObjectType("SoftwareUpdateConfigurationTasks", new ITypeProperty[]{new LazyTypeProperty("preTask", () => TaskProperties, TypePropertyFlags.None), new LazyTypeProperty("postTask", () => TaskProperties, TypePropertyFlags.None)}, null);
            TaskProperties = new NamedObjectType("TaskProperties", new ITypeProperty[]{new TypeProperty("parameters", new NamedObjectType("parameters", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("source", LanguageConstants.String, TypePropertyFlags.None)}, null);
            SourceControlCreateOrUpdateProperties = new NamedObjectType("SourceControlCreateOrUpdateProperties", new ITypeProperty[]{new TypeProperty("repoUrl", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("branch", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("folderPath", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("autoSync", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("publishRunbook", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("sourceType", UnionType.Create(new StringLiteralType("'VsoGit'"), new StringLiteralType("'VsoTfvc'"), new StringLiteralType("'GitHub'")), TypePropertyFlags.None), new LazyTypeProperty("securityToken", () => SourceControlSecurityTokenProperties, TypePropertyFlags.None), new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None)}, null);
            SourceControlSecurityTokenProperties = new NamedObjectType("SourceControlSecurityTokenProperties", new ITypeProperty[]{new TypeProperty("accessToken", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("refreshToken", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tokenType", UnionType.Create(new StringLiteralType("'PersonalAccessToken'"), new StringLiteralType("'Oauth'")), TypePropertyFlags.None)}, null);
            SourceControlSyncJobCreateProperties = new NamedObjectType("SourceControlSyncJobCreateProperties", new ITypeProperty[]{new TypeProperty("commitId", LanguageConstants.String, TypePropertyFlags.Required)}, null);
            JobCreateProperties = new NamedObjectType("JobCreateProperties", new ITypeProperty[]{new LazyTypeProperty("runbook", () => RunbookAssociationProperty, TypePropertyFlags.None), new TypeProperty("parameters", new NamedObjectType("parameters", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("runOn", LanguageConstants.String, TypePropertyFlags.None)}, null);
            RunbookAssociationProperty = new NamedObjectType("RunbookAssociationProperty", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ResourceType_automationAccounts_softwareUpdateConfigurations = new ResourceType("Microsoft.Automation/automationAccounts/softwareUpdateConfigurations", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("type", new StringLiteralType("'Microsoft.Automation/automationAccounts/softwareUpdateConfigurations'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new LazyTypeProperty("properties", () => SoftwareUpdateConfigurationProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2017-05-15-preview'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_automationAccounts_softwareUpdateConfigurations);
            ResourceType_automationAccounts_sourceControls = new ResourceType("Microsoft.Automation/automationAccounts/sourceControls", new ITypeProperty[]{new LazyTypeProperty("properties", () => SourceControlCreateOrUpdateProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.Automation/automationAccounts/sourceControls'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", new StringLiteralType("'2017-05-15-preview'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_automationAccounts_sourceControls);
            ResourceType_automationAccounts_jobs = new ResourceType("Microsoft.Automation/automationAccounts/jobs", new ITypeProperty[]{new LazyTypeProperty("properties", () => JobCreateProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.Automation/automationAccounts/jobs'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", new StringLiteralType("'2017-05-15-preview'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_automationAccounts_jobs);
            ResourceType_automationAccounts_sourceControls_sourceControlSyncJobs = new ResourceType("Microsoft.Automation/automationAccounts/sourceControls/sourceControlSyncJobs", new ITypeProperty[]{new LazyTypeProperty("properties", () => SourceControlSyncJobCreateProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.Automation/automationAccounts/sourceControls/sourceControlSyncJobs'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", new StringLiteralType("'2017-05-15-preview'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_automationAccounts_sourceControls_sourceControlSyncJobs);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_automationAccounts_softwareUpdateConfigurations, () => InstanceLazy.Value.ResourceType_automationAccounts_softwareUpdateConfigurations);
            registrar.RegisterType(ResourceTypeReference_automationAccounts_sourceControls, () => InstanceLazy.Value.ResourceType_automationAccounts_sourceControls);
            registrar.RegisterType(ResourceTypeReference_automationAccounts_jobs, () => InstanceLazy.Value.ResourceType_automationAccounts_jobs);
            registrar.RegisterType(ResourceTypeReference_automationAccounts_sourceControls_sourceControlSyncJobs, () => InstanceLazy.Value.ResourceType_automationAccounts_sourceControls_sourceControlSyncJobs);
        }
        private readonly ResourceType ResourceType_automationAccounts_softwareUpdateConfigurations;
        private readonly ResourceType ResourceType_automationAccounts_sourceControls;
        private readonly ResourceType ResourceType_automationAccounts_jobs;
        private readonly ResourceType ResourceType_automationAccounts_sourceControls_sourceControlSyncJobs;
        private readonly TypeSymbol SoftwareUpdateConfigurationProperties;
        private readonly TypeSymbol UpdateConfiguration;
        private readonly TypeSymbol WindowsProperties;
        private readonly TypeSymbol LinuxProperties;
        private readonly TypeSymbol TargetProperties;
        private readonly TypeSymbol AzureQueryProperties;
        private readonly TypeSymbol TagSettingsProperties;
        private readonly TypeSymbol NonAzureQueryProperties;
        private readonly TypeSymbol ScheduleProperties;
        private readonly TypeSymbol AdvancedSchedule;
        private readonly TypeSymbol AdvancedScheduleMonthlyOccurrence;
        private readonly TypeSymbol ErrorResponse;
        private readonly TypeSymbol SoftwareUpdateConfigurationTasks;
        private readonly TypeSymbol TaskProperties;
        private readonly TypeSymbol SourceControlCreateOrUpdateProperties;
        private readonly TypeSymbol SourceControlSecurityTokenProperties;
        private readonly TypeSymbol SourceControlSyncJobCreateProperties;
        private readonly TypeSymbol JobCreateProperties;
        private readonly TypeSymbol RunbookAssociationProperty;
    }
}