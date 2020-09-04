// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_VirtualMachineImages_2020_02_14
    {
        private const string ProviderNamespace = "Microsoft.VirtualMachineImages";
        private const string ApiVersion = "2020-02-14";
        private static readonly ResourceTypeReference ResourceTypeReference_imageTemplates = new ResourceTypeReference(ProviderNamespace, new[]{"imageTemplates"}, ApiVersion);
        private static Lazy<Microsoft_VirtualMachineImages_2020_02_14> InstanceLazy = new Lazy<Microsoft_VirtualMachineImages_2020_02_14>(() => new Microsoft_VirtualMachineImages_2020_02_14());
        private Microsoft_VirtualMachineImages_2020_02_14()
        {
            ImageTemplateProperties = new NamedObjectType("ImageTemplateProperties", new ITypeProperty[]{new LazyTypeProperty("source", () => ImageTemplateSource, TypePropertyFlags.Required), new LazyTypeProperty("customize", () => new TypedArrayType(ImageTemplateCustomizer), TypePropertyFlags.None), new LazyTypeProperty("distribute", () => new TypedArrayType(ImageTemplateDistributor), TypePropertyFlags.Required), new TypeProperty("provisioningState", UnionType.Create(new StringLiteralType("'Creating'"), new StringLiteralType("'Updating'"), new StringLiteralType("'Succeeded'"), new StringLiteralType("'Failed'"), new StringLiteralType("'Deleting'")), TypePropertyFlags.ReadOnly), new LazyTypeProperty("provisioningError", () => ProvisioningError, TypePropertyFlags.ReadOnly), new LazyTypeProperty("lastRunStatus", () => ImageTemplateLastRunStatus, TypePropertyFlags.ReadOnly), new TypeProperty("buildTimeoutInMinutes", LanguageConstants.Int, TypePropertyFlags.None), new LazyTypeProperty("vmProfile", () => ImageTemplateVmProfile, TypePropertyFlags.None)}, null);
            ImageTemplateSource = LanguageConstants.Any;
            ImageTemplatePlatformImageSource = new NamedObjectType("ImageTemplatePlatformImageSource", new ITypeProperty[]{new TypeProperty("publisher", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("offer", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("sku", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("version", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("planInfo", () => PlatformImagePurchasePlan, TypePropertyFlags.None), new TypeProperty("type", new StringLiteralType("'PlatformImage'"), TypePropertyFlags.Required)}, null);
            PlatformImagePurchasePlan = new NamedObjectType("PlatformImagePurchasePlan", new ITypeProperty[]{new TypeProperty("planName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("planProduct", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("planPublisher", LanguageConstants.String, TypePropertyFlags.Required)}, null);
            ImageTemplateManagedImageSource = new NamedObjectType("ImageTemplateManagedImageSource", new ITypeProperty[]{new TypeProperty("imageId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'ManagedImage'"), TypePropertyFlags.Required)}, null);
            ImageTemplateSharedImageVersionSource = new NamedObjectType("ImageTemplateSharedImageVersionSource", new ITypeProperty[]{new TypeProperty("imageVersionId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'SharedImageVersion'"), TypePropertyFlags.Required)}, null);
            ImageTemplateCustomizer = new DiscriminatedObjectType("ImageTemplateCustomizer", "type", new ITypeProperty[]{new LazyTypeProperty("ImageTemplateCustomizer", () => ImageTemplateShellCustomizer, TypePropertyFlags.None), new LazyTypeProperty("ImageTemplateCustomizer", () => ImageTemplateRestartCustomizer, TypePropertyFlags.None), new LazyTypeProperty("ImageTemplateCustomizer", () => ImageTemplateWindowsUpdateCustomizer, TypePropertyFlags.None), new LazyTypeProperty("ImageTemplateCustomizer", () => ImageTemplatePowerShellCustomizer, TypePropertyFlags.None), new LazyTypeProperty("ImageTemplateCustomizer", () => ImageTemplateFileCustomizer, TypePropertyFlags.None)});
            ImageTemplateShellCustomizer = new NamedObjectType("ImageTemplateShellCustomizer", new ITypeProperty[]{new TypeProperty("scriptUri", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("sha256Checksum", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("inline", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new TypeProperty("type", new StringLiteralType("'Shell'"), TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ImageTemplateRestartCustomizer = new NamedObjectType("ImageTemplateRestartCustomizer", new ITypeProperty[]{new TypeProperty("restartCommand", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("restartCheckCommand", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("restartTimeout", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("type", new StringLiteralType("'WindowsRestart'"), TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ImageTemplateWindowsUpdateCustomizer = new NamedObjectType("ImageTemplateWindowsUpdateCustomizer", new ITypeProperty[]{new TypeProperty("searchCriteria", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("filters", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new TypeProperty("updateLimit", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("type", new StringLiteralType("'WindowsUpdate'"), TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ImageTemplatePowerShellCustomizer = new NamedObjectType("ImageTemplatePowerShellCustomizer", new ITypeProperty[]{new TypeProperty("scriptUri", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("sha256Checksum", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("inline", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new TypeProperty("runElevated", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("validExitCodes", new TypedArrayType(LanguageConstants.Int), TypePropertyFlags.None), new TypeProperty("type", new StringLiteralType("'PowerShell'"), TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ImageTemplateFileCustomizer = new NamedObjectType("ImageTemplateFileCustomizer", new ITypeProperty[]{new TypeProperty("sourceUri", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("sha256Checksum", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("destination", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("type", new StringLiteralType("'File'"), TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ImageTemplateDistributor = new DiscriminatedObjectType("ImageTemplateDistributor", "type", new ITypeProperty[]{new LazyTypeProperty("ImageTemplateDistributor", () => ImageTemplateManagedImageDistributor, TypePropertyFlags.None), new LazyTypeProperty("ImageTemplateDistributor", () => ImageTemplateSharedImageDistributor, TypePropertyFlags.None), new LazyTypeProperty("ImageTemplateDistributor", () => ImageTemplateVhdDistributor, TypePropertyFlags.None)});
            ImageTemplateManagedImageDistributor = new NamedObjectType("ImageTemplateManagedImageDistributor", new ITypeProperty[]{new TypeProperty("imageId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'ManagedImage'"), TypePropertyFlags.Required), new TypeProperty("runOutputName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("artifactTags", new NamedObjectType("artifactTags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None)}, null);
            ImageTemplateSharedImageDistributor = new NamedObjectType("ImageTemplateSharedImageDistributor", new ITypeProperty[]{new TypeProperty("galleryImageId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("replicationRegions", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.Required), new TypeProperty("excludeFromLatest", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("storageAccountType", UnionType.Create(new StringLiteralType("'Standard_LRS'"), new StringLiteralType("'Standard_ZRS'")), TypePropertyFlags.None), new TypeProperty("type", new StringLiteralType("'SharedImage'"), TypePropertyFlags.Required), new TypeProperty("runOutputName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("artifactTags", new NamedObjectType("artifactTags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None)}, null);
            ImageTemplateVhdDistributor = new NamedObjectType("ImageTemplateVhdDistributor", new ITypeProperty[]{new TypeProperty("type", new StringLiteralType("'VHD'"), TypePropertyFlags.Required), new TypeProperty("runOutputName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("artifactTags", new NamedObjectType("artifactTags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None)}, null);
            ProvisioningError = new NamedObjectType("ProvisioningError", new ITypeProperty[]{new TypeProperty("provisioningErrorCode", UnionType.Create(new StringLiteralType("'BadSourceType'"), new StringLiteralType("'BadPIRSource'"), new StringLiteralType("'BadManagedImageSource'"), new StringLiteralType("'BadSharedImageVersionSource'"), new StringLiteralType("'BadCustomizerType'"), new StringLiteralType("'UnsupportedCustomizerType'"), new StringLiteralType("'NoCustomizerScript'"), new StringLiteralType("'BadDistributeType'"), new StringLiteralType("'BadSharedImageDistribute'"), new StringLiteralType("'ServerError'"), new StringLiteralType("'Other'")), TypePropertyFlags.None), new TypeProperty("message", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ImageTemplateLastRunStatus = new NamedObjectType("ImageTemplateLastRunStatus", new ITypeProperty[]{new TypeProperty("startTime", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("endTime", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("runState", UnionType.Create(new StringLiteralType("'Running'"), new StringLiteralType("'Canceling'"), new StringLiteralType("'Succeeded'"), new StringLiteralType("'PartiallySucceeded'"), new StringLiteralType("'Failed'"), new StringLiteralType("'Canceled'")), TypePropertyFlags.None), new TypeProperty("runSubState", UnionType.Create(new StringLiteralType("'Queued'"), new StringLiteralType("'Building'"), new StringLiteralType("'Customizing'"), new StringLiteralType("'Distributing'")), TypePropertyFlags.None), new TypeProperty("message", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ImageTemplateVmProfile = new NamedObjectType("ImageTemplateVmProfile", new ITypeProperty[]{new TypeProperty("vmSize", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("osDiskSizeGB", LanguageConstants.Int, TypePropertyFlags.None), new LazyTypeProperty("vnetConfig", () => VirtualNetworkConfig, TypePropertyFlags.None)}, null);
            VirtualNetworkConfig = new NamedObjectType("VirtualNetworkConfig", new ITypeProperty[]{new TypeProperty("subnetId", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ImageTemplateIdentity = new NamedObjectType("ImageTemplateIdentity", new ITypeProperty[]{new TypeProperty("type", UnionType.Create(new StringLiteralType("'UserAssigned'"), new StringLiteralType("'None'")), TypePropertyFlags.None), new TypeProperty("userAssignedIdentities", new NamedObjectType("userAssignedIdentities", new ITypeProperty[]{}, new LazyTypeProperty("additionalProperties", () => Componentsvrq145schemasimagetemplateidentitypropertiesuserassignedidentitiesadditionalproperties, TypePropertyFlags.None)), TypePropertyFlags.None)}, null);
            Componentsvrq145schemasimagetemplateidentitypropertiesuserassignedidentitiesadditionalproperties = new NamedObjectType("Componentsvrq145schemasimagetemplateidentitypropertiesuserassignedidentitiesadditionalproperties", new ITypeProperty[]{new TypeProperty("principalId", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("clientId", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            ResourceType_imageTemplates = new ResourceType("Microsoft.VirtualMachineImages/imageTemplates", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.VirtualMachineImages/imageTemplates'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("properties", () => ImageTemplateProperties, TypePropertyFlags.Required), new LazyTypeProperty("identity", () => ImageTemplateIdentity, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2020-02-14'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_imageTemplates);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_imageTemplates, () => InstanceLazy.Value.ResourceType_imageTemplates);
        }
        private readonly ResourceType ResourceType_imageTemplates;
        private readonly TypeSymbol ImageTemplateProperties;
        private readonly TypeSymbol ImageTemplateSource;
        private readonly TypeSymbol ImageTemplatePlatformImageSource;
        private readonly TypeSymbol PlatformImagePurchasePlan;
        private readonly TypeSymbol ImageTemplateManagedImageSource;
        private readonly TypeSymbol ImageTemplateSharedImageVersionSource;
        private readonly TypeSymbol ImageTemplateCustomizer;
        private readonly TypeSymbol ImageTemplateShellCustomizer;
        private readonly TypeSymbol ImageTemplateRestartCustomizer;
        private readonly TypeSymbol ImageTemplateWindowsUpdateCustomizer;
        private readonly TypeSymbol ImageTemplatePowerShellCustomizer;
        private readonly TypeSymbol ImageTemplateFileCustomizer;
        private readonly TypeSymbol ImageTemplateDistributor;
        private readonly TypeSymbol ImageTemplateManagedImageDistributor;
        private readonly TypeSymbol ImageTemplateSharedImageDistributor;
        private readonly TypeSymbol ImageTemplateVhdDistributor;
        private readonly TypeSymbol ProvisioningError;
        private readonly TypeSymbol ImageTemplateLastRunStatus;
        private readonly TypeSymbol ImageTemplateVmProfile;
        private readonly TypeSymbol VirtualNetworkConfig;
        private readonly TypeSymbol ImageTemplateIdentity;
        private readonly TypeSymbol Componentsvrq145schemasimagetemplateidentitypropertiesuserassignedidentitiesadditionalproperties;
    }
}
