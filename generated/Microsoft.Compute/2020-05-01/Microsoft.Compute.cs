// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_Compute_2020_05_01
    {
        private const string ProviderNamespace = "Microsoft.Compute";
        private const string ApiVersion = "2020-05-01";
        private static readonly ResourceTypeReference ResourceTypeReference_disks = new ResourceTypeReference(ProviderNamespace, new[]{"disks"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_snapshots = new ResourceTypeReference(ProviderNamespace, new[]{"snapshots"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_diskEncryptionSets = new ResourceTypeReference(ProviderNamespace, new[]{"diskEncryptionSets"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_diskAccesses = new ResourceTypeReference(ProviderNamespace, new[]{"diskAccesses"}, ApiVersion);
        private static Lazy<Microsoft_Compute_2020_05_01> InstanceLazy = new Lazy<Microsoft_Compute_2020_05_01>(() => new Microsoft_Compute_2020_05_01());
        private Microsoft_Compute_2020_05_01()
        {
            DiskSku = new NamedObjectType("DiskSku", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            DiskProperties = new NamedObjectType("DiskProperties", new ITypeProperty[]{new TypeProperty("osType", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("hyperVGeneration", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("creationData", () => CreationData, TypePropertyFlags.Required), new TypeProperty("diskSizeGB", LanguageConstants.Int, TypePropertyFlags.None), new LazyTypeProperty("encryptionSettingsCollection", () => EncryptionSettingsCollection, TypePropertyFlags.None), new TypeProperty("diskIOPSReadWrite", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("diskMBpsReadWrite", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("diskIOPSReadOnly", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("diskMBpsReadOnly", LanguageConstants.Int, TypePropertyFlags.None), new LazyTypeProperty("encryption", () => Encryption, TypePropertyFlags.None), new TypeProperty("maxShares", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("networkAccessPolicy", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("diskAccessId", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            CreationData = new NamedObjectType("CreationData", new ITypeProperty[]{new TypeProperty("createOption", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("storageAccountId", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("imageReference", () => ImageDiskReference, TypePropertyFlags.None), new LazyTypeProperty("galleryImageReference", () => ImageDiskReference, TypePropertyFlags.None), new TypeProperty("sourceUri", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("sourceResourceId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("uploadSizeBytes", LanguageConstants.Int, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ImageDiskReference = new NamedObjectType("ImageDiskReference", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("lun", LanguageConstants.Int, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            EncryptionSettingsCollection = new NamedObjectType("EncryptionSettingsCollection", new ITypeProperty[]{new TypeProperty("enabled", LanguageConstants.Bool, TypePropertyFlags.Required), new TypeProperty("encryptionSettings", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("encryptionSettingsVersion", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            EncryptionSettingsElement = new NamedObjectType("EncryptionSettingsElement", new ITypeProperty[]{new LazyTypeProperty("diskEncryptionKey", () => KeyVaultAndSecretReference, TypePropertyFlags.None), new LazyTypeProperty("keyEncryptionKey", () => KeyVaultAndKeyReference, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            KeyVaultAndSecretReference = new NamedObjectType("KeyVaultAndSecretReference", new ITypeProperty[]{new LazyTypeProperty("sourceVault", () => SourceVault, TypePropertyFlags.Required), new TypeProperty("secretUrl", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            SourceVault = new NamedObjectType("SourceVault", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            KeyVaultAndKeyReference = new NamedObjectType("KeyVaultAndKeyReference", new ITypeProperty[]{new LazyTypeProperty("sourceVault", () => SourceVault, TypePropertyFlags.Required), new TypeProperty("keyUrl", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            Encryption = new NamedObjectType("Encryption", new ITypeProperty[]{new TypeProperty("diskEncryptionSetId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            SnapshotSku = new NamedObjectType("SnapshotSku", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            SnapshotProperties = new NamedObjectType("SnapshotProperties", new ITypeProperty[]{new TypeProperty("osType", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("hyperVGeneration", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("creationData", () => CreationData, TypePropertyFlags.Required), new TypeProperty("diskSizeGB", LanguageConstants.Int, TypePropertyFlags.None), new LazyTypeProperty("encryptionSettingsCollection", () => EncryptionSettingsCollection, TypePropertyFlags.None), new TypeProperty("incremental", LanguageConstants.Bool, TypePropertyFlags.None), new LazyTypeProperty("encryption", () => Encryption, TypePropertyFlags.None), new TypeProperty("networkAccessPolicy", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("diskAccessId", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            EncryptionSetIdentity = new NamedObjectType("EncryptionSetIdentity", new ITypeProperty[]{new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            EncryptionSetProperties = new NamedObjectType("EncryptionSetProperties", new ITypeProperty[]{new TypeProperty("encryptionType", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("activeKey", () => KeyVaultAndKeyReference, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            DiskAccessProperties = new NamedObjectType("DiskAccessProperties", new ITypeProperty[]{}, null, TypePropertyFlags.None);
            ResourceType_disks = new ResourceType("Microsoft.Compute/disks", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("sku", () => DiskSku, TypePropertyFlags.None), new TypeProperty("zones", LanguageConstants.Array, TypePropertyFlags.None), new LazyTypeProperty("properties", () => DiskProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_disks);
            ResourceType_snapshots = new ResourceType("Microsoft.Compute/snapshots", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("sku", () => SnapshotSku, TypePropertyFlags.None), new LazyTypeProperty("properties", () => SnapshotProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_snapshots);
            ResourceType_diskEncryptionSets = new ResourceType("Microsoft.Compute/diskEncryptionSets", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("identity", () => EncryptionSetIdentity, TypePropertyFlags.None), new LazyTypeProperty("properties", () => EncryptionSetProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_diskEncryptionSets);
            ResourceType_diskAccesses = new ResourceType("Microsoft.Compute/diskAccesses", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("properties", () => DiskAccessProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_diskAccesses);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_disks, () => InstanceLazy.Value.ResourceType_disks);
            registrar.RegisterType(ResourceTypeReference_snapshots, () => InstanceLazy.Value.ResourceType_snapshots);
            registrar.RegisterType(ResourceTypeReference_diskEncryptionSets, () => InstanceLazy.Value.ResourceType_diskEncryptionSets);
            registrar.RegisterType(ResourceTypeReference_diskAccesses, () => InstanceLazy.Value.ResourceType_diskAccesses);
        }
        private readonly ResourceType ResourceType_disks;
        private readonly ResourceType ResourceType_snapshots;
        private readonly ResourceType ResourceType_diskEncryptionSets;
        private readonly ResourceType ResourceType_diskAccesses;
        private readonly TypeSymbol DiskSku;
        private readonly TypeSymbol DiskProperties;
        private readonly TypeSymbol CreationData;
        private readonly TypeSymbol ImageDiskReference;
        private readonly TypeSymbol EncryptionSettingsCollection;
        private readonly TypeSymbol EncryptionSettingsElement;
        private readonly TypeSymbol KeyVaultAndSecretReference;
        private readonly TypeSymbol SourceVault;
        private readonly TypeSymbol KeyVaultAndKeyReference;
        private readonly TypeSymbol Encryption;
        private readonly TypeSymbol SnapshotSku;
        private readonly TypeSymbol SnapshotProperties;
        private readonly TypeSymbol EncryptionSetIdentity;
        private readonly TypeSymbol EncryptionSetProperties;
        private readonly TypeSymbol DiskAccessProperties;
    }
}
