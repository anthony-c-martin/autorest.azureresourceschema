// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_Blockchain_2018_06_01_preview
    {
        private const string ProviderNamespace = "Microsoft.Blockchain";
        private const string ApiVersion = "2018-06-01-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_blockchainMembers = new ResourceTypeReference(ProviderNamespace, new[]{"blockchainMembers"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_blockchainMembers_transactionNodes = new ResourceTypeReference(ProviderNamespace, new[]{"blockchainMembers", "transactionNodes"}, ApiVersion);
        private static Lazy<Microsoft_Blockchain_2018_06_01_preview> InstanceLazy = new Lazy<Microsoft_Blockchain_2018_06_01_preview>(() => new Microsoft_Blockchain_2018_06_01_preview());
        private Microsoft_Blockchain_2018_06_01_preview()
        {
            BlockchainMemberProperties = new NamedObjectType("BlockchainMemberProperties", new ITypeProperty[]{new TypeProperty("protocol", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("validatorNodesSku", () => BlockchainMemberNodesSku, TypePropertyFlags.None), new TypeProperty("password", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("consortium", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("consortiumManagementAccountPassword", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("consortiumRole", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("consortiumMemberDisplayName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("firewallRules", new TypedArrayType(new NamedObjectType("firewallRules", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            BlockchainMemberNodesSku = new NamedObjectType("BlockchainMemberNodesSku", new ITypeProperty[]{new TypeProperty("capacity", LanguageConstants.Int, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            FirewallRule = new NamedObjectType("FirewallRule", new ITypeProperty[]{new TypeProperty("ruleName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("startIpAddress", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("endIpAddress", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            Sku = new NamedObjectType("Sku", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tier", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            TransactionNodeProperties = new NamedObjectType("TransactionNodeProperties", new ITypeProperty[]{new TypeProperty("password", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("firewallRules", new TypedArrayType(new NamedObjectType("firewallRules", new ITypeProperty[]{}, null, TypePropertyFlags.None)), TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_blockchainMembers = new ResourceType("Microsoft.Blockchain/blockchainMembers", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, LanguageConstants.String, TypePropertyFlags.None), TypePropertyFlags.None), new LazyTypeProperty("properties", () => BlockchainMemberProperties, TypePropertyFlags.Required), new LazyTypeProperty("sku", () => Sku, TypePropertyFlags.None), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_blockchainMembers);
            ResourceType_blockchainMembers_transactionNodes = new ResourceType("Microsoft.Blockchain/blockchainMembers/transactionNodes", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("properties", () => TransactionNodeProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_blockchainMembers_transactionNodes);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_blockchainMembers, () => InstanceLazy.Value.ResourceType_blockchainMembers);
            registrar.RegisterType(ResourceTypeReference_blockchainMembers_transactionNodes, () => InstanceLazy.Value.ResourceType_blockchainMembers_transactionNodes);
        }
        private readonly ResourceType ResourceType_blockchainMembers;
        private readonly ResourceType ResourceType_blockchainMembers_transactionNodes;
        private readonly TypeSymbol BlockchainMemberProperties;
        private readonly TypeSymbol BlockchainMemberNodesSku;
        private readonly TypeSymbol FirewallRule;
        private readonly TypeSymbol Sku;
        private readonly TypeSymbol TransactionNodeProperties;
    }
}
