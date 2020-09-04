// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_Maintenance_2020_07_01_preview
    {
        private const string ProviderNamespace = "Microsoft.Maintenance";
        private const string ApiVersion = "2020-07-01-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_maintenanceConfigurations = new ResourceTypeReference(ProviderNamespace, new[]{"maintenanceConfigurations"}, ApiVersion);
        private static Lazy<Microsoft_Maintenance_2020_07_01_preview> InstanceLazy = new Lazy<Microsoft_Maintenance_2020_07_01_preview>(() => new Microsoft_Maintenance_2020_07_01_preview());
        private Microsoft_Maintenance_2020_07_01_preview()
        {
            ConfigurationAssignmentProperties = new NamedObjectType("ConfigurationAssignmentProperties", new ITypeProperty[]{new TypeProperty("maintenanceConfigurationId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("resourceId", LanguageConstants.String, TypePropertyFlags.None)}, null);
            MaintenanceConfigurationProperties = new NamedObjectType("MaintenanceConfigurationProperties", new ITypeProperty[]{new TypeProperty("namespace", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("extensionProperties", new NamedObjectType("extensionProperties", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("maintenanceScope", UnionType.Create(new StringLiteralType("'All'"), new StringLiteralType("'Host'"), new StringLiteralType("'Resource'"), new StringLiteralType("'InResource'"), new StringLiteralType("'OSImage'"), new StringLiteralType("'Extension'"), new StringLiteralType("'InGuestPatch'"), new StringLiteralType("'SQLDB'"), new StringLiteralType("'SQLManagedInstance'")), TypePropertyFlags.None), new LazyTypeProperty("maintenanceWindow", () => MaintenanceWindow, TypePropertyFlags.None), new TypeProperty("visibility", UnionType.Create(new StringLiteralType("'Custom'"), new StringLiteralType("'Public'")), TypePropertyFlags.None)}, null);
            MaintenanceWindow = new NamedObjectType("MaintenanceWindow", new ITypeProperty[]{new TypeProperty("startDateTime", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("expirationDateTime", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("duration", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("timeZone", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("recurEvery", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ResourceType_maintenanceConfigurations = new ResourceType("Microsoft.Maintenance/maintenanceConfigurations", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.Maintenance/maintenanceConfigurations'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("properties", () => MaintenanceConfigurationProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2020-07-01-preview'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_maintenanceConfigurations);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_maintenanceConfigurations, () => InstanceLazy.Value.ResourceType_maintenanceConfigurations);
        }
        private readonly ResourceType ResourceType_maintenanceConfigurations;
        private readonly TypeSymbol ConfigurationAssignmentProperties;
        private readonly TypeSymbol MaintenanceConfigurationProperties;
        private readonly TypeSymbol MaintenanceWindow;
    }
}
