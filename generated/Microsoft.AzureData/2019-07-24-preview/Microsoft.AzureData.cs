// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_AzureData_2019_07_24_preview
    {
        private const string ProviderNamespace = "Microsoft.AzureData";
        private const string ApiVersion = "2019-07-24-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_sqlServerRegistrations = new ResourceTypeReference(ProviderNamespace, new[]{"sqlServerRegistrations"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_sqlManagedInstances = new ResourceTypeReference(ProviderNamespace, new[]{"sqlManagedInstances"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_sqlServerInstances = new ResourceTypeReference(ProviderNamespace, new[]{"sqlServerInstances"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_postgresInstances = new ResourceTypeReference(ProviderNamespace, new[]{"postgresInstances"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_dataControllers = new ResourceTypeReference(ProviderNamespace, new[]{"dataControllers"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_sqlServerRegistrations_sqlServers = new ResourceTypeReference(ProviderNamespace, new[]{"sqlServerRegistrations", "sqlServers"}, ApiVersion);
        private static Lazy<Microsoft_AzureData_2019_07_24_preview> InstanceLazy = new Lazy<Microsoft_AzureData_2019_07_24_preview>(() => new Microsoft_AzureData_2019_07_24_preview());
        private Microsoft_AzureData_2019_07_24_preview()
        {
            SqlServerRegistrationProperties = new NamedObjectType("SqlServerRegistrationProperties", new ITypeProperty[]{new TypeProperty("subscriptionId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("resourceGroup", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("propertyBag", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            SqlServerProperties = new NamedObjectType("SqlServerProperties", new ITypeProperty[]{new TypeProperty("cores", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("version", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("edition", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("registrationID", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("propertyBag", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            SqlManagedInstanceProperties = new NamedObjectType("SqlManagedInstanceProperties", new ITypeProperty[]{new TypeProperty("dataControllerId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("instanceEndpoint", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("admin", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("startTime", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("endTime", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("vCore", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            SqlServerInstanceProperties = new NamedObjectType("SqlServerInstanceProperties", new ITypeProperty[]{new TypeProperty("version", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("edition", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("containerResourceId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("vCore", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("status", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            DataControllerProperties = new NamedObjectType("DataControllerProperties", new ITypeProperty[]{new LazyTypeProperty("onPremiseProperty", () => OnPremiseProperty, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            OnPremiseProperty = new NamedObjectType("OnPremiseProperty", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("publicSigningKey", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("signingCertificateThumbprint", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_sqlServerRegistrations = new ResourceType("Microsoft.AzureData/sqlServerRegistrations", new ITypeProperty[]{new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => SqlServerRegistrationProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_sqlServerRegistrations);
            ResourceType_sqlManagedInstances = new ResourceType("Microsoft.AzureData/sqlManagedInstances", new ITypeProperty[]{new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => SqlManagedInstanceProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_sqlManagedInstances);
            ResourceType_sqlServerInstances = new ResourceType("Microsoft.AzureData/sqlServerInstances", new ITypeProperty[]{new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => SqlServerInstanceProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_sqlServerInstances);
            ResourceType_postgresInstances = new ResourceType("Microsoft.AzureData/postgresInstances", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_postgresInstances);
            ResourceType_dataControllers = new ResourceType("Microsoft.AzureData/dataControllers", new ITypeProperty[]{new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => DataControllerProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_dataControllers);
            ResourceType_sqlServerRegistrations_sqlServers = new ResourceType("Microsoft.AzureData/sqlServerRegistrations/sqlServers", new ITypeProperty[]{new LazyTypeProperty("properties", () => SqlServerProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_sqlServerRegistrations_sqlServers);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_sqlServerRegistrations, () => InstanceLazy.Value.ResourceType_sqlServerRegistrations);
            registrar.RegisterType(ResourceTypeReference_sqlManagedInstances, () => InstanceLazy.Value.ResourceType_sqlManagedInstances);
            registrar.RegisterType(ResourceTypeReference_sqlServerInstances, () => InstanceLazy.Value.ResourceType_sqlServerInstances);
            registrar.RegisterType(ResourceTypeReference_postgresInstances, () => InstanceLazy.Value.ResourceType_postgresInstances);
            registrar.RegisterType(ResourceTypeReference_dataControllers, () => InstanceLazy.Value.ResourceType_dataControllers);
            registrar.RegisterType(ResourceTypeReference_sqlServerRegistrations_sqlServers, () => InstanceLazy.Value.ResourceType_sqlServerRegistrations_sqlServers);
        }
        private readonly ResourceType ResourceType_sqlServerRegistrations;
        private readonly ResourceType ResourceType_sqlManagedInstances;
        private readonly ResourceType ResourceType_sqlServerInstances;
        private readonly ResourceType ResourceType_postgresInstances;
        private readonly ResourceType ResourceType_dataControllers;
        private readonly ResourceType ResourceType_sqlServerRegistrations_sqlServers;
        private readonly TypeSymbol SqlServerRegistrationProperties;
        private readonly TypeSymbol SqlServerProperties;
        private readonly TypeSymbol SqlManagedInstanceProperties;
        private readonly TypeSymbol SqlServerInstanceProperties;
        private readonly TypeSymbol DataControllerProperties;
        private readonly TypeSymbol OnPremiseProperty;
    }
}
