// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_HanaOnAzure_2020_02_07_preview
    {
        private const string ProviderNamespace = "Microsoft.HanaOnAzure";
        private const string ApiVersion = "2020-02-07-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_sapMonitors = new ResourceTypeReference(ProviderNamespace, new[]{"sapMonitors"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_sapMonitors_providerInstances = new ResourceTypeReference(ProviderNamespace, new[]{"sapMonitors", "providerInstances"}, ApiVersion);
        private static Lazy<Microsoft_HanaOnAzure_2020_02_07_preview> InstanceLazy = new Lazy<Microsoft_HanaOnAzure_2020_02_07_preview>(() => new Microsoft_HanaOnAzure_2020_02_07_preview());
        private Microsoft_HanaOnAzure_2020_02_07_preview()
        {
            SapMonitorProperties = new NamedObjectType("SapMonitorProperties", new ITypeProperty[]{new TypeProperty("provisioningState", UnionType.Create(new StringLiteralType("'Accepted'"), new StringLiteralType("'Creating'"), new StringLiteralType("'Updating'"), new StringLiteralType("'Failed'"), new StringLiteralType("'Succeeded'"), new StringLiteralType("'Deleting'"), new StringLiteralType("'Migrating'")), TypePropertyFlags.ReadOnly), new TypeProperty("managedResourceGroupName", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("logAnalyticsWorkspaceArmId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("enableCustomerAnalytics", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("logAnalyticsWorkspaceId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("logAnalyticsWorkspaceSharedKey", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("sapMonitorCollectorVersion", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("monitorSubnet", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ProviderInstanceProperties = new NamedObjectType("ProviderInstanceProperties", new ITypeProperty[]{new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("properties", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("metadata", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("provisioningState", UnionType.Create(new StringLiteralType("'Accepted'"), new StringLiteralType("'Creating'"), new StringLiteralType("'Updating'"), new StringLiteralType("'Failed'"), new StringLiteralType("'Succeeded'"), new StringLiteralType("'Deleting'"), new StringLiteralType("'Migrating'")), TypePropertyFlags.ReadOnly)}, null);
            ResourceType_sapMonitors = new ResourceType("Microsoft.HanaOnAzure/sapMonitors", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.HanaOnAzure/sapMonitors'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => SapMonitorProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2020-02-07-preview'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_sapMonitors);
            ResourceType_sapMonitors_providerInstances = new ResourceType("Microsoft.HanaOnAzure/sapMonitors/providerInstances", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.HanaOnAzure/sapMonitors/providerInstances'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new LazyTypeProperty("properties", () => ProviderInstanceProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2020-02-07-preview'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_sapMonitors_providerInstances);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_sapMonitors, () => InstanceLazy.Value.ResourceType_sapMonitors);
            registrar.RegisterType(ResourceTypeReference_sapMonitors_providerInstances, () => InstanceLazy.Value.ResourceType_sapMonitors_providerInstances);
        }
        private readonly ResourceType ResourceType_sapMonitors;
        private readonly ResourceType ResourceType_sapMonitors_providerInstances;
        private readonly TypeSymbol SapMonitorProperties;
        private readonly TypeSymbol ProviderInstanceProperties;
    }
}
