// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_Maintenance_2018_06_01_preview
    {
        private const string ProviderNamespace = "Microsoft.Maintenance";
        private const string ApiVersion = "2018-06-01-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_maintenanceConfigurations = new ResourceTypeReference(ProviderNamespace, new[]{"maintenanceConfigurations"}, ApiVersion);
        private static Lazy<Microsoft_Maintenance_2018_06_01_preview> InstanceLazy = new Lazy<Microsoft_Maintenance_2018_06_01_preview>(() => new Microsoft_Maintenance_2018_06_01_preview());
        private Microsoft_Maintenance_2018_06_01_preview()
        {
            ConfigurationAssignmentProperties = new NamedObjectType("ConfigurationAssignmentProperties", new ITypeProperty[]{new TypeProperty("maintenanceConfigurationId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("resourceId", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            MaintenanceConfigurationProperties = new NamedObjectType("MaintenanceConfigurationProperties", new ITypeProperty[]{new TypeProperty("namespace", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("extensionProperties", new NamedObjectType("extensionProperties", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new TypeProperty("maintenanceScope", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_maintenanceConfigurations = new ResourceType("Microsoft.Maintenance/maintenanceConfigurations", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new LazyTypeProperty("properties", () => MaintenanceConfigurationProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_maintenanceConfigurations);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_maintenanceConfigurations, () => InstanceLazy.Value.ResourceType_maintenanceConfigurations);
        }
        private readonly ResourceType ResourceType_maintenanceConfigurations;
        private readonly TypeSymbol ConfigurationAssignmentProperties;
        private readonly TypeSymbol MaintenanceConfigurationProperties;
    }
}
