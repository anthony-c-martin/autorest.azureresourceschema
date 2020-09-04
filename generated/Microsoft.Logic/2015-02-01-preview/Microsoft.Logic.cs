// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_Logic_2015_02_01_preview
    {
        private const string ProviderNamespace = "Microsoft.Logic";
        private const string ApiVersion = "2015-02-01-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_workflows = new ResourceTypeReference(ProviderNamespace, new[]{"workflows"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_workflows_accessKeys = new ResourceTypeReference(ProviderNamespace, new[]{"workflows", "accessKeys"}, ApiVersion);
        private static Lazy<Microsoft_Logic_2015_02_01_preview> InstanceLazy = new Lazy<Microsoft_Logic_2015_02_01_preview>(() => new Microsoft_Logic_2015_02_01_preview());
        private Microsoft_Logic_2015_02_01_preview()
        {
            WorkflowProperties = new NamedObjectType("WorkflowProperties", new ITypeProperty[]{new TypeProperty("provisioningState", UnionType.Create(new StringLiteralType("'NotSpecified'"), new StringLiteralType("'Moving'"), new StringLiteralType("'Succeeded'")), TypePropertyFlags.ReadOnly), new TypeProperty("createdTime", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("changedTime", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("state", UnionType.Create(new StringLiteralType("'NotSpecified'"), new StringLiteralType("'Enabled'"), new StringLiteralType("'Disabled'"), new StringLiteralType("'Deleted'"), new StringLiteralType("'Suspended'")), TypePropertyFlags.None), new TypeProperty("version", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("accessEndpoint", LanguageConstants.String, TypePropertyFlags.ReadOnly), new LazyTypeProperty("sku", () => Sku, TypePropertyFlags.None), new LazyTypeProperty("definitionLink", () => ContentLink, TypePropertyFlags.None), new TypeProperty("definition", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("parametersLink", () => ContentLink, TypePropertyFlags.None), new TypeProperty("parameters", new NamedObjectType("parameters", new ITypeProperty[]{}, new LazyTypeProperty("additionalProperties", () => WorkflowParameter, TypePropertyFlags.None)), TypePropertyFlags.None)}, null);
            Sku = new NamedObjectType("Sku", new ITypeProperty[]{new TypeProperty("name", UnionType.Create(new StringLiteralType("'NotSpecified'"), new StringLiteralType("'Free'"), new StringLiteralType("'Shared'"), new StringLiteralType("'Basic'"), new StringLiteralType("'Standard'"), new StringLiteralType("'Premium'")), TypePropertyFlags.None), new LazyTypeProperty("plan", () => ResourceReference, TypePropertyFlags.None)}, null);
            ResourceReference = new NamedObjectType("ResourceReference", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.ReadOnly)}, null);
            ContentLink = new NamedObjectType("ContentLink", new ITypeProperty[]{new TypeProperty("uri", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("contentVersion", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("contentSize", LanguageConstants.Int, TypePropertyFlags.None), new LazyTypeProperty("contentHash", () => ContentHash, TypePropertyFlags.None), new TypeProperty("metadata", LanguageConstants.Any, TypePropertyFlags.None)}, null);
            ContentHash = new NamedObjectType("ContentHash", new ITypeProperty[]{new TypeProperty("algorithm", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("value", LanguageConstants.String, TypePropertyFlags.None)}, null);
            WorkflowParameter = new NamedObjectType("WorkflowParameter", new ITypeProperty[]{new TypeProperty("type", UnionType.Create(new StringLiteralType("'NotSpecified'"), new StringLiteralType("'String'"), new StringLiteralType("'SecureString'"), new StringLiteralType("'Int'"), new StringLiteralType("'Float'"), new StringLiteralType("'Bool'"), new StringLiteralType("'Array'"), new StringLiteralType("'Object'"), new StringLiteralType("'SecureObject'")), TypePropertyFlags.None), new TypeProperty("value", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("metadata", LanguageConstants.Any, TypePropertyFlags.None)}, null);
            WorkflowAccessKeyProperties = new NamedObjectType("WorkflowAccessKeyProperties", new ITypeProperty[]{new TypeProperty("notBefore", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("notAfter", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ResourceType_workflows = new ResourceType("Microsoft.Logic/workflows", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.Logic/workflows'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("properties", () => WorkflowProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2015-02-01-preview'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_workflows);
            ResourceType_workflows_accessKeys = new ResourceType("Microsoft.Logic/workflows/accessKeys", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new LazyTypeProperty("properties", () => WorkflowAccessKeyProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.Logic/workflows/accessKeys'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", new StringLiteralType("'2015-02-01-preview'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_workflows_accessKeys);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_workflows, () => InstanceLazy.Value.ResourceType_workflows);
            registrar.RegisterType(ResourceTypeReference_workflows_accessKeys, () => InstanceLazy.Value.ResourceType_workflows_accessKeys);
        }
        private readonly ResourceType ResourceType_workflows;
        private readonly ResourceType ResourceType_workflows_accessKeys;
        private readonly TypeSymbol WorkflowProperties;
        private readonly TypeSymbol Sku;
        private readonly TypeSymbol ResourceReference;
        private readonly TypeSymbol ContentLink;
        private readonly TypeSymbol ContentHash;
        private readonly TypeSymbol WorkflowParameter;
        private readonly TypeSymbol WorkflowAccessKeyProperties;
    }
}
