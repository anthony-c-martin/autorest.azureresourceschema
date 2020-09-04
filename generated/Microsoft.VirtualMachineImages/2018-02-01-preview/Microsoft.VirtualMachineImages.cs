// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_VirtualMachineImages_2018_02_01_preview
    {
        private const string ProviderNamespace = "Microsoft.VirtualMachineImages";
        private const string ApiVersion = "2018-02-01-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_imageTemplates = new ResourceTypeReference(ProviderNamespace, new[]{"imageTemplates"}, ApiVersion);
        private static Lazy<Microsoft_VirtualMachineImages_2018_02_01_preview> InstanceLazy = new Lazy<Microsoft_VirtualMachineImages_2018_02_01_preview>(() => new Microsoft_VirtualMachineImages_2018_02_01_preview());
        private Microsoft_VirtualMachineImages_2018_02_01_preview()
        {
            ImageTemplateProperties = new NamedObjectType("ImageTemplateProperties", new ITypeProperty[]{new LazyTypeProperty("source", () => ImageTemplateSource, TypePropertyFlags.Required), new LazyTypeProperty("customize", () => new TypedArrayType(ImageTemplateCustomizer), TypePropertyFlags.None), new LazyTypeProperty("distribute", () => new TypedArrayType(ImageTemplateDistributor), TypePropertyFlags.Required), new TypeProperty("provisioningState", UnionType.Create(new StringLiteralType("'Creating'"), new StringLiteralType("'Succeeded'"), new StringLiteralType("'Failed'"), new StringLiteralType("'Deleting'")), TypePropertyFlags.ReadOnly), new LazyTypeProperty("provisioningError", () => ProvisioningError, TypePropertyFlags.ReadOnly), new LazyTypeProperty("lastRunStatus", () => ImageTemplateLastRunStatus, TypePropertyFlags.ReadOnly)}, null);
            ImageTemplateSource = LanguageConstants.Any;
            ImageTemplateIsoSource = new NamedObjectType("ImageTemplateIsoSource", new ITypeProperty[]{new TypeProperty("sourceURI", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("sha256Checksum", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'ISO'"), TypePropertyFlags.Required)}, null);
            ImageTemplatePlatformImageSource = new NamedObjectType("ImageTemplatePlatformImageSource", new ITypeProperty[]{new TypeProperty("publisher", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("offer", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("sku", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("version", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("type", new StringLiteralType("'PlatformImage'"), TypePropertyFlags.Required)}, null);
            ImageTemplateCustomizer = new DiscriminatedObjectType("ImageTemplateCustomizer", "type", new ITypeProperty[]{new LazyTypeProperty("ImageTemplateCustomizer", () => ImageTemplateShellCustomizer, TypePropertyFlags.None)});
            ImageTemplateShellCustomizer = new NamedObjectType("ImageTemplateShellCustomizer", new ITypeProperty[]{new TypeProperty("script", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("type", new StringLiteralType("'shell'"), TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ImageTemplateDistributor = new DiscriminatedObjectType("ImageTemplateDistributor", "type", new ITypeProperty[]{new LazyTypeProperty("ImageTemplateDistributor", () => ImageTemplateManagedImageDistributor, TypePropertyFlags.None), new LazyTypeProperty("ImageTemplateDistributor", () => ImageTemplateSharedImageDistributor, TypePropertyFlags.None)});
            ImageTemplateManagedImageDistributor = new NamedObjectType("ImageTemplateManagedImageDistributor", new ITypeProperty[]{new TypeProperty("imageId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'managedImage'"), TypePropertyFlags.Required), new TypeProperty("runOutputName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("artifactTags", new NamedObjectType("artifactTags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None)}, null);
            ImageTemplateSharedImageDistributor = new NamedObjectType("ImageTemplateSharedImageDistributor", new ITypeProperty[]{new TypeProperty("galleryImageId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("replicationRegions", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'sharedImage'"), TypePropertyFlags.Required), new TypeProperty("runOutputName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("artifactTags", new NamedObjectType("artifactTags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None)}, null);
            ProvisioningError = new NamedObjectType("ProvisioningError", new ITypeProperty[]{new TypeProperty("provisioningErrorCode", UnionType.Create(new StringLiteralType("'BadSourceType'"), new StringLiteralType("'BadPIRSource'"), new StringLiteralType("'BadISOSource'"), new StringLiteralType("'BadCustomizerType'"), new StringLiteralType("'NoCustomizerShellScript'"), new StringLiteralType("'ServerError'"), new StringLiteralType("'Other'")), TypePropertyFlags.None), new TypeProperty("message", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ImageTemplateLastRunStatus = new NamedObjectType("ImageTemplateLastRunStatus", new ITypeProperty[]{new TypeProperty("startTime", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("endTime", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("runState", UnionType.Create(new StringLiteralType("'ready'"), new StringLiteralType("'running'"), new StringLiteralType("'succeeded'"), new StringLiteralType("'partiallySucceeded'"), new StringLiteralType("'failed'")), TypePropertyFlags.None), new TypeProperty("runSubState", UnionType.Create(new StringLiteralType("'queued'"), new StringLiteralType("'building'"), new StringLiteralType("'customizing'"), new StringLiteralType("'distributing'")), TypePropertyFlags.None), new TypeProperty("message", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ResourceType_imageTemplates = new ResourceType("Microsoft.VirtualMachineImages/imageTemplates", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.VirtualMachineImages/imageTemplates'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("properties", () => ImageTemplateProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2018-02-01-preview'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_imageTemplates);
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
        private readonly TypeSymbol ImageTemplateCustomizer;
        private readonly TypeSymbol ImageTemplateShellCustomizer;
        private readonly TypeSymbol ImageTemplateDistributor;
        private readonly TypeSymbol ImageTemplateManagedImageDistributor;
        private readonly TypeSymbol ImageTemplateSharedImageDistributor;
        private readonly TypeSymbol ProvisioningError;
        private readonly TypeSymbol ImageTemplateLastRunStatus;
    }
}
