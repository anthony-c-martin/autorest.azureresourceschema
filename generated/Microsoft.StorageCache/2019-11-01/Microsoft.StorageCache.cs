// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_StorageCache_2019_11_01
    {
        private const string ProviderNamespace = "Microsoft.StorageCache";
        private const string ApiVersion = "2019-11-01";
        private static readonly ResourceTypeReference ResourceTypeReference_caches = new ResourceTypeReference(ProviderNamespace, new[]{"caches"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_caches_storageTargets = new ResourceTypeReference(ProviderNamespace, new[]{"caches", "storageTargets"}, ApiVersion);
        private static Lazy<Microsoft_StorageCache_2019_11_01> InstanceLazy = new Lazy<Microsoft_StorageCache_2019_11_01>(() => new Microsoft_StorageCache_2019_11_01());
        private Microsoft_StorageCache_2019_11_01()
        {
            CacheProperties = new NamedObjectType("CacheProperties", new ITypeProperty[]{new TypeProperty("cacheSizeGB", LanguageConstants.Int, TypePropertyFlags.None), new LazyTypeProperty("health", () => CacheHealth, TypePropertyFlags.ReadOnly), new TypeProperty("mountAddresses", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.ReadOnly), new TypeProperty("provisioningState", UnionType.Create(new StringLiteralType("'Succeeded'"), new StringLiteralType("'Failed'"), new StringLiteralType("'Cancelled'"), new StringLiteralType("'Creating'"), new StringLiteralType("'Deleting'"), new StringLiteralType("'Updating'")), TypePropertyFlags.None), new TypeProperty("subnet", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("upgradeStatus", () => CacheUpgradeStatus, TypePropertyFlags.None)}, null);
            CacheHealth = new NamedObjectType("CacheHealth", new ITypeProperty[]{new TypeProperty("state", UnionType.Create(new StringLiteralType("'Unknown'"), new StringLiteralType("'Healthy'"), new StringLiteralType("'Degraded'"), new StringLiteralType("'Down'"), new StringLiteralType("'Transitioning'"), new StringLiteralType("'Stopping'"), new StringLiteralType("'Stopped'"), new StringLiteralType("'Upgrading'"), new StringLiteralType("'Flushing'")), TypePropertyFlags.None), new TypeProperty("statusDescription", LanguageConstants.String, TypePropertyFlags.None)}, null);
            CacheUpgradeStatus = new NamedObjectType("CacheUpgradeStatus", new ITypeProperty[]{new TypeProperty("currentFirmwareVersion", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("firmwareUpdateStatus", UnionType.Create(new StringLiteralType("'available'"), new StringLiteralType("'unavailable'")), TypePropertyFlags.ReadOnly), new TypeProperty("firmwareUpdateDeadline", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("lastFirmwareUpdate", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("pendingFirmwareVersion", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            CacheSku = new NamedObjectType("CacheSku", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None)}, null);
            StorageTargetProperties = new NamedObjectType("StorageTargetProperties", new ITypeProperty[]{new LazyTypeProperty("junctions", () => new TypedArrayType(NamespaceJunction), TypePropertyFlags.None), new TypeProperty("targetType", UnionType.Create(new StringLiteralType("'nfs3'"), new StringLiteralType("'clfs'"), new StringLiteralType("'unknown'")), TypePropertyFlags.None), new TypeProperty("provisioningState", UnionType.Create(new StringLiteralType("'Succeeded'"), new StringLiteralType("'Failed'"), new StringLiteralType("'Cancelled'"), new StringLiteralType("'Creating'"), new StringLiteralType("'Deleting'"), new StringLiteralType("'Updating'")), TypePropertyFlags.None), new LazyTypeProperty("nfs3", () => Nfs3Target, TypePropertyFlags.None), new LazyTypeProperty("clfs", () => ClfsTarget, TypePropertyFlags.None), new LazyTypeProperty("unknown", () => UnknownTarget, TypePropertyFlags.None)}, null);
            NamespaceJunction = new NamedObjectType("NamespaceJunction", new ITypeProperty[]{new TypeProperty("namespacePath", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("targetPath", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("nfsExport", LanguageConstants.String, TypePropertyFlags.None)}, null);
            Nfs3Target = new NamedObjectType("Nfs3Target", new ITypeProperty[]{new TypeProperty("target", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("usageModel", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ClfsTarget = new NamedObjectType("ClfsTarget", new ITypeProperty[]{new TypeProperty("target", LanguageConstants.String, TypePropertyFlags.None)}, null);
            UnknownTarget = new NamedObjectType("UnknownTarget", new ITypeProperty[]{new TypeProperty("unknownMap", new NamedObjectType("unknownMap", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None)}, null);
            ResourceType_caches = new ResourceType("Microsoft.StorageCache/caches", new ITypeProperty[]{new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.StorageCache/caches'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new LazyTypeProperty("properties", () => CacheProperties, TypePropertyFlags.Required), new LazyTypeProperty("sku", () => CacheSku, TypePropertyFlags.None), new TypeProperty("apiVersion", new StringLiteralType("'2019-11-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_caches);
            ResourceType_caches_storageTargets = new ResourceType("Microsoft.StorageCache/caches/storageTargets", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("type", new StringLiteralType("'Microsoft.StorageCache/caches/storageTargets'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new LazyTypeProperty("properties", () => StorageTargetProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2019-11-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_caches_storageTargets);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_caches, () => InstanceLazy.Value.ResourceType_caches);
            registrar.RegisterType(ResourceTypeReference_caches_storageTargets, () => InstanceLazy.Value.ResourceType_caches_storageTargets);
        }
        private readonly ResourceType ResourceType_caches;
        private readonly ResourceType ResourceType_caches_storageTargets;
        private readonly TypeSymbol CacheProperties;
        private readonly TypeSymbol CacheHealth;
        private readonly TypeSymbol CacheUpgradeStatus;
        private readonly TypeSymbol CacheSku;
        private readonly TypeSymbol StorageTargetProperties;
        private readonly TypeSymbol NamespaceJunction;
        private readonly TypeSymbol Nfs3Target;
        private readonly TypeSymbol ClfsTarget;
        private readonly TypeSymbol UnknownTarget;
    }
}
