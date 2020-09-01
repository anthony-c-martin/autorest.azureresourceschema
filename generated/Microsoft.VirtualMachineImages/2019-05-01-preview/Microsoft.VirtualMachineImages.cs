// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_VirtualMachineImages_2019_05_01_preview
    {
        private const string ProviderNamespace = "Microsoft.VirtualMachineImages";
        private const string ApiVersion = "2019-05-01-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_imageTemplates = new ResourceTypeReference(ProviderNamespace, new[]{"imageTemplates"}, ApiVersion);
        private static Lazy<Microsoft_VirtualMachineImages_2019_05_01_preview> InstanceLazy = new Lazy<Microsoft_VirtualMachineImages_2019_05_01_preview>(() => new Microsoft_VirtualMachineImages_2019_05_01_preview());
        private Microsoft_VirtualMachineImages_2019_05_01_preview()
        {
            ImageTemplateProperties = new NamedObjectType("ImageTemplateProperties", new ITypeProperty[]{new LazyTypeProperty("source", () => ImageTemplateSource, TypePropertyFlags.Required), new TypeProperty("customize", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("distribute", LanguageConstants.Array, TypePropertyFlags.Required), new TypeProperty("buildTimeoutInMinutes", LanguageConstants.Int, TypePropertyFlags.None), new LazyTypeProperty("vmProfile", () => ImageTemplateVmProfile, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ImageTemplateSource = new NamedObjectType("ImageTemplateSource", new ITypeProperty[]{}, null, TypePropertyFlags.None);
            ImageTemplateIsoSource = new NamedObjectType("ImageTemplateIsoSource", new ITypeProperty[]{new TypeProperty("sourceUri", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("sha256Checksum", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ImageTemplatePlatformImageSource = new NamedObjectType("ImageTemplatePlatformImageSource", new ITypeProperty[]{new TypeProperty("publisher", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("offer", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("sku", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("version", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ImageTemplateManagedImageSource = new NamedObjectType("ImageTemplateManagedImageSource", new ITypeProperty[]{new TypeProperty("imageId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ImageTemplateSharedImageVersionSource = new NamedObjectType("ImageTemplateSharedImageVersionSource", new ITypeProperty[]{new TypeProperty("imageVersionId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ImageTemplateCustomizer = new NamedObjectType("ImageTemplateCustomizer", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ImageTemplateShellCustomizer = new NamedObjectType("ImageTemplateShellCustomizer", new ITypeProperty[]{new TypeProperty("scriptUri", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("sha256Checksum", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("inline", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ImageTemplateRestartCustomizer = new NamedObjectType("ImageTemplateRestartCustomizer", new ITypeProperty[]{new TypeProperty("restartCommand", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("restartCheckCommand", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("restartTimeout", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ImageTemplatePowerShellCustomizer = new NamedObjectType("ImageTemplatePowerShellCustomizer", new ITypeProperty[]{new TypeProperty("scriptUri", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("sha256Checksum", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("inline", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("runElevated", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("validExitCodes", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ImageTemplateFileCustomizer = new NamedObjectType("ImageTemplateFileCustomizer", new ITypeProperty[]{new TypeProperty("sourceUri", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("sha256Checksum", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("destination", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ImageTemplateDistributor = new NamedObjectType("ImageTemplateDistributor", new ITypeProperty[]{new TypeProperty("runOutputName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("artifactTags", LanguageConstants.Any, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ImageTemplateManagedImageDistributor = new NamedObjectType("ImageTemplateManagedImageDistributor", new ITypeProperty[]{new TypeProperty("imageId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ImageTemplateSharedImageDistributor = new NamedObjectType("ImageTemplateSharedImageDistributor", new ITypeProperty[]{new TypeProperty("galleryImageId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("replicationRegions", LanguageConstants.Array, TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ImageTemplateVhdDistributor = new NamedObjectType("ImageTemplateVhdDistributor", new ITypeProperty[]{new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ImageTemplateVmProfile = new NamedObjectType("ImageTemplateVmProfile", new ITypeProperty[]{new TypeProperty("vmSize", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ImageTemplateIdentity = new NamedObjectType("ImageTemplateIdentity", new ITypeProperty[]{new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("userAssignedIdentities", LanguageConstants.Any, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            Componentsvrq145schemasimagetemplateidentitypropertiesuserassignedidentitiesadditionalproperties = new NamedObjectType("Componentsvrq145schemasimagetemplateidentitypropertiesuserassignedidentitiesadditionalproperties", new ITypeProperty[]{}, null, TypePropertyFlags.None);
            ResourceType_imageTemplates = new ResourceType("Microsoft.VirtualMachineImages/imageTemplates", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("properties", () => ImageTemplateProperties, TypePropertyFlags.Required), new LazyTypeProperty("identity", () => ImageTemplateIdentity, TypePropertyFlags.None), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_imageTemplates);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_imageTemplates, () => InstanceLazy.Value.ResourceType_imageTemplates);
        }
        private readonly ResourceType ResourceType_imageTemplates;
        private readonly TypeSymbol ImageTemplateProperties;
        private readonly TypeSymbol ImageTemplateSource;
        private readonly TypeSymbol ImageTemplateIsoSource;
        private readonly TypeSymbol ImageTemplatePlatformImageSource;
        private readonly TypeSymbol ImageTemplateManagedImageSource;
        private readonly TypeSymbol ImageTemplateSharedImageVersionSource;
        private readonly TypeSymbol ImageTemplateCustomizer;
        private readonly TypeSymbol ImageTemplateShellCustomizer;
        private readonly TypeSymbol ImageTemplateRestartCustomizer;
        private readonly TypeSymbol ImageTemplatePowerShellCustomizer;
        private readonly TypeSymbol ImageTemplateFileCustomizer;
        private readonly TypeSymbol ImageTemplateDistributor;
        private readonly TypeSymbol ImageTemplateManagedImageDistributor;
        private readonly TypeSymbol ImageTemplateSharedImageDistributor;
        private readonly TypeSymbol ImageTemplateVhdDistributor;
        private readonly TypeSymbol ImageTemplateVmProfile;
        private readonly TypeSymbol ImageTemplateIdentity;
        private readonly TypeSymbol Componentsvrq145schemasimagetemplateidentitypropertiesuserassignedidentitiesadditionalproperties;
    }
}
