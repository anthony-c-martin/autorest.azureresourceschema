// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_Compute_2018_09_30
    {
        private const string ProviderNamespace = "Microsoft.Compute";
        private const string ApiVersion = "2018-09-30";
        private static readonly ResourceTypeReference ResourceTypeReference_disks = new ResourceTypeReference(ProviderNamespace, new[]{"disks"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_snapshots = new ResourceTypeReference(ProviderNamespace, new[]{"snapshots"}, ApiVersion);
        private static Lazy<Microsoft_Compute_2018_09_30> InstanceLazy = new Lazy<Microsoft_Compute_2018_09_30>(() => new Microsoft_Compute_2018_09_30());
        private Microsoft_Compute_2018_09_30()
        {
            DiskSku = new NamedObjectType("DiskSku", new ITypeProperty[]{new TypeProperty("name", UnionType.Create(new StringLiteralType("'Standard_LRS'"), new StringLiteralType("'Premium_LRS'"), new StringLiteralType("'StandardSSD_LRS'"), new StringLiteralType("'UltraSSD_LRS'")), TypePropertyFlags.None), new TypeProperty("tier", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            DiskProperties = new NamedObjectType("DiskProperties", new ITypeProperty[]{new TypeProperty("timeCreated", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("osType", UnionType.Create(new StringLiteralType("'Windows'"), new StringLiteralType("'Linux'")), TypePropertyFlags.None), new TypeProperty("hyperVGeneration", UnionType.Create(new StringLiteralType("'V1'"), new StringLiteralType("'V2'")), TypePropertyFlags.None), new LazyTypeProperty("creationData", () => CreationData, TypePropertyFlags.Required), new TypeProperty("diskSizeGB", LanguageConstants.Int, TypePropertyFlags.None), new LazyTypeProperty("encryptionSettingsCollection", () => EncryptionSettingsCollection, TypePropertyFlags.None), new TypeProperty("provisioningState", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("diskIOPSReadWrite", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("diskMBpsReadWrite", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("diskState", UnionType.Create(new StringLiteralType("'Unattached'"), new StringLiteralType("'Attached'"), new StringLiteralType("'Reserved'"), new StringLiteralType("'ActiveSAS'"), new StringLiteralType("'ReadyToUpload'"), new StringLiteralType("'ActiveUpload'")), TypePropertyFlags.ReadOnly)}, null);
            CreationData = new NamedObjectType("CreationData", new ITypeProperty[]{new TypeProperty("createOption", UnionType.Create(new StringLiteralType("'Empty'"), new StringLiteralType("'Attach'"), new StringLiteralType("'FromImage'"), new StringLiteralType("'Import'"), new StringLiteralType("'Copy'"), new StringLiteralType("'Restore'"), new StringLiteralType("'Upload'")), TypePropertyFlags.Required), new TypeProperty("storageAccountId", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("imageReference", () => ImageDiskReference, TypePropertyFlags.None), new TypeProperty("sourceUri", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("sourceResourceId", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ImageDiskReference = new NamedObjectType("ImageDiskReference", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("lun", LanguageConstants.Int, TypePropertyFlags.None)}, null);
            EncryptionSettingsCollection = new NamedObjectType("EncryptionSettingsCollection", new ITypeProperty[]{new TypeProperty("enabled", LanguageConstants.Bool, TypePropertyFlags.Required), new LazyTypeProperty("encryptionSettings", () => new TypedArrayType(EncryptionSettingsElement), TypePropertyFlags.None)}, null);
            EncryptionSettingsElement = new NamedObjectType("EncryptionSettingsElement", new ITypeProperty[]{new LazyTypeProperty("diskEncryptionKey", () => KeyVaultAndSecretReference, TypePropertyFlags.None), new LazyTypeProperty("keyEncryptionKey", () => KeyVaultAndKeyReference, TypePropertyFlags.None)}, null);
            KeyVaultAndSecretReference = new NamedObjectType("KeyVaultAndSecretReference", new ITypeProperty[]{new LazyTypeProperty("sourceVault", () => SourceVault, TypePropertyFlags.Required), new TypeProperty("secretUrl", LanguageConstants.String, TypePropertyFlags.Required)}, null);
            SourceVault = new NamedObjectType("SourceVault", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.None)}, null);
            KeyVaultAndKeyReference = new NamedObjectType("KeyVaultAndKeyReference", new ITypeProperty[]{new LazyTypeProperty("sourceVault", () => SourceVault, TypePropertyFlags.Required), new TypeProperty("keyUrl", LanguageConstants.String, TypePropertyFlags.Required)}, null);
            SnapshotSku = new NamedObjectType("SnapshotSku", new ITypeProperty[]{new TypeProperty("name", UnionType.Create(new StringLiteralType("'Standard_LRS'"), new StringLiteralType("'Premium_LRS'"), new StringLiteralType("'Standard_ZRS'")), TypePropertyFlags.None), new TypeProperty("tier", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            SnapshotProperties = new NamedObjectType("SnapshotProperties", new ITypeProperty[]{new TypeProperty("timeCreated", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("osType", UnionType.Create(new StringLiteralType("'Windows'"), new StringLiteralType("'Linux'")), TypePropertyFlags.None), new TypeProperty("hyperVGeneration", UnionType.Create(new StringLiteralType("'V1'"), new StringLiteralType("'V2'")), TypePropertyFlags.None), new LazyTypeProperty("creationData", () => CreationData, TypePropertyFlags.Required), new TypeProperty("diskSizeGB", LanguageConstants.Int, TypePropertyFlags.None), new LazyTypeProperty("encryptionSettingsCollection", () => EncryptionSettingsCollection, TypePropertyFlags.None), new TypeProperty("provisioningState", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            ResourceType_disks = new ResourceType("Microsoft.Compute/disks", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.Compute/disks'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("managedBy", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("sku", () => DiskSku, TypePropertyFlags.None), new TypeProperty("zones", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new LazyTypeProperty("properties", () => DiskProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2018-09-30'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_disks);
            ResourceType_snapshots = new ResourceType("Microsoft.Compute/snapshots", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.Compute/snapshots'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("managedBy", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("sku", () => SnapshotSku, TypePropertyFlags.None), new LazyTypeProperty("properties", () => SnapshotProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2018-09-30'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_snapshots);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_disks, () => InstanceLazy.Value.ResourceType_disks);
            registrar.RegisterType(ResourceTypeReference_snapshots, () => InstanceLazy.Value.ResourceType_snapshots);
        }
        private readonly ResourceType ResourceType_disks;
        private readonly ResourceType ResourceType_snapshots;
        private readonly TypeSymbol DiskSku;
        private readonly TypeSymbol DiskProperties;
        private readonly TypeSymbol CreationData;
        private readonly TypeSymbol ImageDiskReference;
        private readonly TypeSymbol EncryptionSettingsCollection;
        private readonly TypeSymbol EncryptionSettingsElement;
        private readonly TypeSymbol KeyVaultAndSecretReference;
        private readonly TypeSymbol SourceVault;
        private readonly TypeSymbol KeyVaultAndKeyReference;
        private readonly TypeSymbol SnapshotSku;
        private readonly TypeSymbol SnapshotProperties;
    }
}
