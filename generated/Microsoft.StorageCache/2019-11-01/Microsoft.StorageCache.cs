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
            CacheProperties = new NamedObjectType("CacheProperties", new ITypeProperty[]{new TypeProperty("cacheSizeGB", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("provisioningState", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("subnet", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("upgradeStatus", () => CacheUpgradeStatus, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            CacheUpgradeStatus = new NamedObjectType("CacheUpgradeStatus", new ITypeProperty[]{}, null, TypePropertyFlags.None);
            CacheSku = new NamedObjectType("CacheSku", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            StorageTargetProperties = new NamedObjectType("StorageTargetProperties", new ITypeProperty[]{new TypeProperty("junctions", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("targetType", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("provisioningState", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("nfs3", () => Nfs3Target, TypePropertyFlags.None), new LazyTypeProperty("clfs", () => ClfsTarget, TypePropertyFlags.None), new LazyTypeProperty("unknown", () => UnknownTarget, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            NamespaceJunction = new NamedObjectType("NamespaceJunction", new ITypeProperty[]{new TypeProperty("namespacePath", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("targetPath", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("nfsExport", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            Nfs3Target = new NamedObjectType("Nfs3Target", new ITypeProperty[]{new TypeProperty("target", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("usageModel", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ClfsTarget = new NamedObjectType("ClfsTarget", new ITypeProperty[]{new TypeProperty("target", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            UnknownTarget = new NamedObjectType("UnknownTarget", new ITypeProperty[]{new TypeProperty("unknownMap", LanguageConstants.Any, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_caches = new ResourceType("Microsoft.StorageCache/caches", new ITypeProperty[]{new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("properties", () => CacheProperties, TypePropertyFlags.Required), new LazyTypeProperty("sku", () => CacheSku, TypePropertyFlags.None), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_caches);
            ResourceType_caches_storageTargets = new ResourceType("Microsoft.StorageCache/caches/storageTargets", new ITypeProperty[]{new LazyTypeProperty("properties", () => StorageTargetProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_caches_storageTargets);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_caches, () => InstanceLazy.Value.ResourceType_caches);
            registrar.RegisterType(ResourceTypeReference_caches_storageTargets, () => InstanceLazy.Value.ResourceType_caches_storageTargets);
        }
        private readonly ResourceType ResourceType_caches;
        private readonly ResourceType ResourceType_caches_storageTargets;
        private readonly TypeSymbol CacheProperties;
        private readonly TypeSymbol CacheUpgradeStatus;
        private readonly TypeSymbol CacheSku;
        private readonly TypeSymbol StorageTargetProperties;
        private readonly TypeSymbol NamespaceJunction;
        private readonly TypeSymbol Nfs3Target;
        private readonly TypeSymbol ClfsTarget;
        private readonly TypeSymbol UnknownTarget;
    }
}
