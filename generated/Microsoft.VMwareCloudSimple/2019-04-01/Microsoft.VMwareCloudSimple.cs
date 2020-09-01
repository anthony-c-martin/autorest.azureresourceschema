// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_VMwareCloudSimple_2019_04_01
    {
        private const string ProviderNamespace = "Microsoft.VMwareCloudSimple";
        private const string ApiVersion = "2019-04-01";
        private static readonly ResourceTypeReference ResourceTypeReference_dedicatedCloudNodes = new ResourceTypeReference(ProviderNamespace, new[]{"dedicatedCloudNodes"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_dedicatedCloudServices = new ResourceTypeReference(ProviderNamespace, new[]{"dedicatedCloudServices"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_virtualMachines = new ResourceTypeReference(ProviderNamespace, new[]{"virtualMachines"}, ApiVersion);
        private static Lazy<Microsoft_VMwareCloudSimple_2019_04_01> InstanceLazy = new Lazy<Microsoft_VMwareCloudSimple_2019_04_01>(() => new Microsoft_VMwareCloudSimple_2019_04_01());
        private Microsoft_VMwareCloudSimple_2019_04_01()
        {
            DedicatedCloudNodeProperties = new NamedObjectType("DedicatedCloudNodeProperties", new ITypeProperty[]{new TypeProperty("availabilityZoneId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("nodesCount", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("placementGroupId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("purchaseId", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("skuDescription", () => SkuDescription, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            SkuDescription = new NamedObjectType("SkuDescription", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            Sku = new NamedObjectType("Sku", new ITypeProperty[]{new TypeProperty("capacity", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("family", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tier", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            DedicatedCloudServiceProperties = new NamedObjectType("DedicatedCloudServiceProperties", new ITypeProperty[]{new TypeProperty("gatewaySubnet", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            VirtualMachineProperties = new NamedObjectType("VirtualMachineProperties", new ITypeProperty[]{new TypeProperty("amountOfRam", LanguageConstants.Int, TypePropertyFlags.Required), new LazyTypeProperty("customization", () => GuestOSCustomization, TypePropertyFlags.None), new TypeProperty("disks", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("exposeToGuestVM", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("nics", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("numberOfCores", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("password", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("privateCloudId", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("resourcePool", () => ResourcePool, TypePropertyFlags.None), new TypeProperty("templateId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("username", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("vSphereNetworks", LanguageConstants.Array, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            GuestOSCustomization = new NamedObjectType("GuestOSCustomization", new ITypeProperty[]{new TypeProperty("dnsServers", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("hostName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("password", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("policyId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("username", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            VirtualDisk = new NamedObjectType("VirtualDisk", new ITypeProperty[]{new TypeProperty("controllerId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("independenceMode", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("totalSize", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("virtualDiskId", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            VirtualNic = new NamedObjectType("VirtualNic", new ITypeProperty[]{new LazyTypeProperty("customization", () => GuestOSNICCustomization, TypePropertyFlags.None), new TypeProperty("ipAddresses", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("macAddress", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("network", () => VirtualNetwork, TypePropertyFlags.Required), new TypeProperty("nicType", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("powerOnBoot", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("virtualNicId", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            GuestOSNICCustomization = new NamedObjectType("GuestOSNICCustomization", new ITypeProperty[]{new TypeProperty("allocation", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("dnsServers", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("gateway", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("ipAddress", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("mask", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("primaryWinsServer", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("secondaryWinsServer", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            VirtualNetwork = new NamedObjectType("VirtualNetwork", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => VirtualNetworkProperties, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            VirtualNetworkProperties = new NamedObjectType("VirtualNetworkProperties", new ITypeProperty[]{}, null, TypePropertyFlags.None);
            ResourcePool = new NamedObjectType("ResourcePool", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => ResourcePoolProperties, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourcePoolProperties = new NamedObjectType("ResourcePoolProperties", new ITypeProperty[]{}, null, TypePropertyFlags.None);
            ResourceType_dedicatedCloudNodes = new ResourceType("Microsoft.VMwareCloudSimple/dedicatedCloudNodes", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => DedicatedCloudNodeProperties, TypePropertyFlags.Required), new LazyTypeProperty("sku", () => Sku, TypePropertyFlags.None), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_dedicatedCloudNodes);
            ResourceType_dedicatedCloudServices = new ResourceType("Microsoft.VMwareCloudSimple/dedicatedCloudServices", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => DedicatedCloudServiceProperties, TypePropertyFlags.Required), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_dedicatedCloudServices);
            ResourceType_virtualMachines = new ResourceType("Microsoft.VMwareCloudSimple/virtualMachines", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => VirtualMachineProperties, TypePropertyFlags.Required), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_virtualMachines);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_dedicatedCloudNodes, () => InstanceLazy.Value.ResourceType_dedicatedCloudNodes);
            registrar.RegisterType(ResourceTypeReference_dedicatedCloudServices, () => InstanceLazy.Value.ResourceType_dedicatedCloudServices);
            registrar.RegisterType(ResourceTypeReference_virtualMachines, () => InstanceLazy.Value.ResourceType_virtualMachines);
        }
        private readonly ResourceType ResourceType_dedicatedCloudNodes;
        private readonly ResourceType ResourceType_dedicatedCloudServices;
        private readonly ResourceType ResourceType_virtualMachines;
        private readonly TypeSymbol DedicatedCloudNodeProperties;
        private readonly TypeSymbol SkuDescription;
        private readonly TypeSymbol Sku;
        private readonly TypeSymbol DedicatedCloudServiceProperties;
        private readonly TypeSymbol VirtualMachineProperties;
        private readonly TypeSymbol GuestOSCustomization;
        private readonly TypeSymbol VirtualDisk;
        private readonly TypeSymbol VirtualNic;
        private readonly TypeSymbol GuestOSNICCustomization;
        private readonly TypeSymbol VirtualNetwork;
        private readonly TypeSymbol VirtualNetworkProperties;
        private readonly TypeSymbol ResourcePool;
        private readonly TypeSymbol ResourcePoolProperties;
    }
}
