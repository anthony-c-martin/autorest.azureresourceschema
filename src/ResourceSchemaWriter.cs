// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AutoRest.AzureResourceSchema.Models;
using Newtonsoft.Json;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;
using System.Text.RegularExpressions;

namespace AutoRest.AzureResourceSchema
{
    public static class ResourceSchemaWriter
    {
        private static IDictionary<string, JsonSchema> GetResourceDefinitions(ResourceSchema resourceSchema, ScopeType scopeType)
            => resourceSchema.ResourceDefinitions
                .Where(kvp => kvp.Key.ScopeType == scopeType)
                .ToDictionary(kvp => ResourceSchema.FormatResourceSchemaKey(kvp.Key.ResourceTypeSegments), kvp => kvp.Value);

        private static string FormatResourceTypeGetterName(ResourceDescriptor descriptor)
            => $"ResourceType_{string.Join('_', descriptor.ResourceTypeSegments)}";

        private static MemberDeclarationSyntax GetRegisterMethod(IEnumerable<(ResourceDescriptor descriptor, JsonSchema schema)> resources)
        {
            var firstDescriptor = resources.First().descriptor;

            var registerMethodStatements = new List<StatementSyntax>();

            registerMethodStatements.Add(LocalDeclarationStatement(
                VariableDeclaration(
                    PredefinedType(
                        Token(SyntaxKind.StringKeyword)))
                .WithVariables(
                    SingletonSeparatedList<VariableDeclaratorSyntax>(
                        VariableDeclarator(
                            Identifier("providerNamespace"))
                        .WithInitializer(
                            EqualsValueClause(
                                LiteralExpression(
                                    SyntaxKind.StringLiteralExpression,
                                    Literal(firstDescriptor.ProviderNamespace)))))))
                    .WithModifiers(
                        TokenList(
                            Token(SyntaxKind.ConstKeyword))));

            registerMethodStatements.Add(LocalDeclarationStatement(
                VariableDeclaration(
                    PredefinedType(
                        Token(SyntaxKind.StringKeyword)))
                .WithVariables(
                    SingletonSeparatedList<VariableDeclaratorSyntax>(
                        VariableDeclarator(
                            Identifier("apiVersion"))
                        .WithInitializer(
                            EqualsValueClause(
                                LiteralExpression(
                                    SyntaxKind.StringLiteralExpression,
                                    Literal(firstDescriptor.ApiVersion)))))))
                    .WithModifiers(
                        TokenList(
                            Token(SyntaxKind.ConstKeyword))));

            foreach (var (descriptor, schema) in resources)
            {
                registerMethodStatements.Add(
                    GetResourceTypeRegistrationSyntax(descriptor, schema));
            }

            return MethodDeclaration(
                PredefinedType(
                    Token(SyntaxKind.VoidKeyword)),
                Identifier("Register"))
            .WithModifiers(
                TokenList(
                    new []{
                        Token(SyntaxKind.PublicKeyword),
                        Token(SyntaxKind.StaticKeyword)}))
            .WithParameterList(
                ParameterList(
                    SingletonSeparatedList<ParameterSyntax>(
                        Parameter(
                            Identifier("registrar"))
                        .WithType(
                            IdentifierName("ITypeRegistrar")))))
            .WithBody(
                Block(registerMethodStatements));
        }

        private static ExpressionSyntax GetResourceTypeReferenceSyntax(ResourceDescriptor descriptor)
        {
            var providerNamespaceArg = Argument(
                IdentifierName("providerNamespace"));

            var typeSegments = descriptor.ResourceTypeSegments
                .Select(segment => 
                    LiteralExpression(
                        SyntaxKind.StringLiteralExpression,
                        Literal(segment)))
                .ToArray();

            var typeSegmentsArg = Argument(
                ImplicitArrayCreationExpression(
                    InitializerExpression(
                        SyntaxKind.ArrayInitializerExpression,
                        SeparatedList<ExpressionSyntax>(
                            typeSegments,
                            Enumerable.Repeat(Token(SyntaxKind.CommaToken), typeSegments.Length - 1)))));
                
            var apiVersionArg = Argument(
                IdentifierName("apiVersion"));

            return ObjectCreationExpression(
                IdentifierName("ResourceTypeReference"))
            .WithArgumentList(
                ArgumentList(
                    SeparatedList<ArgumentSyntax>(
                        new SyntaxNodeOrToken[]{
                            providerNamespaceArg,
                            Token(SyntaxKind.CommaToken),
                            typeSegmentsArg,
                            Token(SyntaxKind.CommaToken),
                            apiVersionArg})));
        }

        private static ExpressionStatementSyntax GetResourceTypeRegistrationSyntax(ResourceDescriptor descriptor, JsonSchema schema)
        {
            var resourceTypeReference = GetResourceTypeReferenceSyntax(descriptor);

            var properties = new List<ExpressionSyntax>();
            foreach (var kvp in schema.Properties)
            {
                properties.Add(GetTypePropertyCreationSyntax(kvp.Key, kvp.Value));
            }

            var additionalPropertiesType = (schema.AdditionalProperties != null) ?
                GetTypePropertyCreationSyntax("AdditionalProperties", schema.AdditionalProperties) :
                LiteralExpression(SyntaxKind.NullLiteralExpression);

            var resourceArg = Argument(
                ObjectCreationExpression(
                    IdentifierName("ResourceType"))
                .WithArgumentList(
                    ArgumentList(
                        SeparatedList<ArgumentSyntax>(
                            new SyntaxNodeOrToken[]{
                                Argument(
                                    LiteralExpression(
                                        SyntaxKind.StringLiteralExpression,
                                        Literal(descriptor.FullyQualifiedType))),
                                Token(SyntaxKind.CommaToken),
                                Argument(
                                    ArrayCreationExpression(
                                        ArrayType(
                                            IdentifierName("TypeProperty"))
                                        .WithRankSpecifiers(
                                            SingletonList<ArrayRankSpecifierSyntax>(
                                                ArrayRankSpecifier(
                                                    SingletonSeparatedList<ExpressionSyntax>(
                                                        OmittedArraySizeExpression())))))
                                    .WithInitializer(
                                        InitializerExpression(
                                            SyntaxKind.ArrayInitializerExpression,
                                            SeparatedList<ExpressionSyntax>(
                                                properties)))),
                                Token(SyntaxKind.CommaToken),
                                Argument(additionalPropertiesType),
                                Token(SyntaxKind.CommaToken),
                                Argument(resourceTypeReference)}))));

            return ExpressionStatement(
                InvocationExpression(
                    MemberAccessExpression(
                        SyntaxKind.SimpleMemberAccessExpression,
                        IdentifierName("registrar"),
                        IdentifierName("RegisterType")))
                .WithArgumentList(
                    ArgumentList(
                        SeparatedList<ArgumentSyntax>(
                            new SyntaxNodeOrToken[]{
                                resourceArg}))));
        }

        private static ClassDeclarationSyntax GetClassDeclaration(ResourceSchema resourceSchema)
        {
            var classMembers = new List<MemberDeclarationSyntax>();

            var resourcePairs = resourceSchema.ResourceDefinitions
                .Where(kvp => kvp.Key.ScopeType == ScopeType.ResourceGroup);

            classMembers.Add(GetRegisterMethod(resourcePairs.Select(kvp => (kvp.Key, kvp.Value))));
            
            foreach (var kvp in resourceSchema.Definitions)
            {
                if (kvp.Key.EndsWith("_childResource"))
                {
                    // we don't need this at all
                    continue;
                }

                classMembers.Add(GetDeclarationSyntax(kvp.Key, kvp.Key, kvp.Value));
            }

            var firstDescriptor = resourcePairs.First().Key;
            var className = Regex.Replace($"{firstDescriptor.ProviderNamespace}_{firstDescriptor.ApiVersion}", "[^a-zA-Z0-9_]", "_");

            return ClassDeclaration(className)
                .WithModifiers(
                    TokenList(
                        new []{
                            Token(SyntaxKind.PublicKeyword),
                            Token(SyntaxKind.StaticKeyword)}))
                .WithMembers(
                    List<MemberDeclarationSyntax>(classMembers));
        }

        public static MemberDeclarationSyntax GetDeclarationSyntax(string propertyName, string bicepTypeName, JsonSchema schema)
        {
            switch (schema.JsonType)
            {
                case "object":
                    return GetObjectDeclarationSyntax(propertyName, bicepTypeName, schema);
            }

            throw new NotImplementedException();
        }

        private static string GetLanguageConstantForType(JsonSchema schema)
        {
            switch (schema.JsonType)
            {
                case "object":
                    return "Any";
                case "array":
                    return "Array";
                case "string":
                    return "String";
                case "number":
                case "integer":
                    return "Int";
                case "boolean":
                    return "Bool";
            }

            throw new NotImplementedException($"Unrecognized type {schema.JsonType}");
        }

        private static ExpressionSyntax GetTypePropertyCreationSyntax(string name, JsonSchema schema)
        {
            ExpressionSyntax type;
            if (schema.Ref == null)
            {
                var namedType = GetLanguageConstantForType(schema);

                type = MemberAccessExpression(
                    SyntaxKind.SimpleMemberAccessExpression,
                    IdentifierName("LanguageConstants"),
                    IdentifierName(namedType));
            }
            else
            {
                var definitionName = schema.Ref.Substring("#/definitions/".Length);
                
                type = IdentifierName(definitionName);
            }

            if (schema.Required?.Any() == true)
            {
                throw new ArgumentException(JsonConvert.SerializeObject(schema.Required));
            }

            var isRequired = schema.Required?.Contains(name) ?? false;
            var flags = isRequired ? "Required" : "None";

            return ObjectCreationExpression(
                IdentifierName("TypeProperty"))
            .WithArgumentList(
                ArgumentList(
                    SeparatedList<ArgumentSyntax>(
                        new SyntaxNodeOrToken[]{
                            Argument(
                                LiteralExpression(
                                    SyntaxKind.StringLiteralExpression,
                                    Literal(name))),
                            Token(SyntaxKind.CommaToken),
                            Argument(type),
                            Token(SyntaxKind.CommaToken),
                            Argument(
                                MemberAccessExpression(
                                    SyntaxKind.SimpleMemberAccessExpression,
                                    IdentifierName("TypePropertyFlags"),
                                    IdentifierName(flags)))})));
        }

        private static MemberDeclarationSyntax GetObjectDeclarationSyntax(string propertyName, string bicepTypeName, JsonSchema schema)
        {
            var properties = new List<ExpressionSyntax>();
            if (schema.Properties != null)
            {
                foreach (var kvp in schema.Properties)
                {
                    properties.Add(GetTypePropertyCreationSyntax(kvp.Key, kvp.Value));
                }
            }

            var additionalPropertiesType = (schema.AdditionalProperties != null) ?
                GetTypePropertyCreationSyntax("AdditionalProperties", schema.AdditionalProperties) :
                LiteralExpression(SyntaxKind.NullLiteralExpression);

            if (schema.Properties == null && additionalPropertiesType == null)
            {
                var namedType = GetLanguageConstantForType(schema);

                return FieldDeclaration(
                    VariableDeclaration(
                        IdentifierName("TypeSymbol"))
                    .WithVariables(
                        SingletonSeparatedList<VariableDeclaratorSyntax>(
                            VariableDeclarator(
                                Identifier(propertyName))
                            .WithInitializer(
                                EqualsValueClause(
                                    MemberAccessExpression(
                                        SyntaxKind.SimpleMemberAccessExpression,
                                        IdentifierName("LanguageConstants"),
                                        IdentifierName(namedType)))))));
            }

            return FieldDeclaration(
                VariableDeclaration(
                    IdentifierName("TypeSymbol"))
                .WithVariables(
                    SingletonSeparatedList<VariableDeclaratorSyntax>(
                        VariableDeclarator(
                            Identifier(propertyName))
                        .WithInitializer(
                            EqualsValueClause(
                                ObjectCreationExpression(
                                    IdentifierName("NamedObjectType"))
                                .WithArgumentList(
                                    ArgumentList(
                                        SeparatedList<ArgumentSyntax>(
                                            new SyntaxNodeOrToken[]{
                                                Argument(
                                                    LiteralExpression(
                                                        SyntaxKind.StringLiteralExpression,
                                                        Literal(bicepTypeName))),
                                                Token(SyntaxKind.CommaToken),
                                                Argument(
                                                    ArrayCreationExpression(
                                                        ArrayType(
                                                            IdentifierName("TypeProperty"))
                                                        .WithRankSpecifiers(
                                                            SingletonList<ArrayRankSpecifierSyntax>(
                                                                ArrayRankSpecifier(
                                                                    SingletonSeparatedList<ExpressionSyntax>(
                                                                        OmittedArraySizeExpression())))))
                                                    .WithInitializer(
                                                        InitializerExpression(
                                                            SyntaxKind.ArrayInitializerExpression,
                                                            SeparatedList<ExpressionSyntax>(
                                                                properties)))),
                                                Token(SyntaxKind.CommaToken),
                                                Argument(additionalPropertiesType),
                                                Token(SyntaxKind.CommaToken),
                                                Argument(
                                                    MemberAccessExpression(
                                                        SyntaxKind.SimpleMemberAccessExpression,
                                                        IdentifierName("TypePropertyFlags"),
                                                        IdentifierName("None")))}))))))))
                .WithModifiers(
                    TokenList(
                        new []{
                            Token(SyntaxKind.PrivateKeyword),
                            Token(SyntaxKind.StaticKeyword),
                            Token(SyntaxKind.ReadOnlyKeyword)}));
        }

        public static void Write(TextWriter writer, ResourceSchema resourceSchema)
        {
            var resources = resourceSchema.ResourceDefinitions
                .Where(kvp => kvp.Key.ScopeType == ScopeType.ResourceGroup);

            CompilationUnit()
                .WithUsings(
                    List<UsingDirectiveSyntax>(
                        new UsingDirectiveSyntax[]{
                            UsingDirective(
                                QualifiedName(
                                    IdentifierName("Bicep"),
                                    IdentifierName("Core")))
                            .WithUsingKeyword(
                                Token(
                                    TriviaList(
                                        new []{
                                            Comment("// Copyright (c) Microsoft Corporation."),
                                            Comment("// Licensed under the MIT License.")}),
                                    SyntaxKind.UsingKeyword,
                                    TriviaList())),
                            UsingDirective(
                                QualifiedName(
                                    QualifiedName(
                                        IdentifierName("Bicep"),
                                        IdentifierName("Core")),
                                    IdentifierName("Resources"))),
                            UsingDirective(
                                QualifiedName(
                                    QualifiedName(
                                        IdentifierName("Bicep"),
                                        IdentifierName("Core")),
                                    IdentifierName("TypeSystem")))
                        }))
                .WithMembers(
                    List<MemberDeclarationSyntax>(
                        new MemberDeclarationSyntax[]{
                            NamespaceDeclaration(
                                QualifiedName(
                                    QualifiedName(
                                        IdentifierName("Bicep"),
                                        IdentifierName("Resources")),
                                    IdentifierName("Types")))
                            .WithMembers(
                                SingletonList<MemberDeclarationSyntax>(
                                    GetClassDeclaration(resourceSchema)))}))
                .NormalizeWhitespace()
                .WriteTo(writer);
        }
    }
}

/*
        public static void Write(TextWriter writer, ResourceSchema resourceSchema)
        {
            if (writer == null)
            {
                throw new ArgumentNullException("writer");
            }
            if (resourceSchema == null)
            {
                throw new ArgumentNullException("resourceSchema");
            }

            var rgDefinitions = GetResourceDefinitions(resourceSchema, ScopeType.ResourceGroup);

            var compilationUnit = CompilationUnit();



            
                .WithMembers(GetResourceDefinitions(resourceSchema, ScopeType.ResourceGroup))
                .WriteTo(writer);

            compilationUnit.WriteTo(writer);

            writer.WriteStartObject();

            WriteProperty(writer, "id", resourceSchema.Id);
            WriteProperty(writer, "$schema", resourceSchema.Schema);
            WriteProperty(writer, "title", resourceSchema.Title);
            WriteProperty(writer, "description", resourceSchema.Description);

            var rgDefinitions = GetResourceDefinitions(resourceSchema, ScopeType.ResourceGroup);
            WriteDefinitionMap(writer, "resourceDefinitions", rgDefinitions, sortDefinitions: true, addExpressionReferences: false);

            var subDefinitions = GetResourceDefinitions(resourceSchema, ScopeType.Subcription);
            if (subDefinitions.Any())
            {
                WriteDefinitionMap(writer, "subscription_resourceDefinitions", subDefinitions, sortDefinitions: true, addExpressionReferences: false);
            }

            var mgDefinitions = GetResourceDefinitions(resourceSchema, ScopeType.ManagementGroup);
            if (mgDefinitions.Any())
            {
                WriteDefinitionMap(writer, "managementGroup_resourceDefinitions", mgDefinitions, sortDefinitions: true, addExpressionReferences: false);
            }

            var tenantDefinitions = GetResourceDefinitions(resourceSchema, ScopeType.Tenant);
            if (tenantDefinitions.Any())
            {
                WriteDefinitionMap(writer, "tenant_resourceDefinitions", tenantDefinitions, sortDefinitions: true, addExpressionReferences: false);
            }

            var extDefinitions = GetResourceDefinitions(resourceSchema, ScopeType.Extension);
            if (extDefinitions.Any())
            {
                WriteDefinitionMap(writer, "extension_resourceDefinitions", extDefinitions, sortDefinitions: true, addExpressionReferences: false);
            }

            var unknownDefinitions = GetResourceDefinitions(resourceSchema, ScopeType.Unknown);
            if (unknownDefinitions.Any())
            {
                WriteDefinitionMap(writer, "unknown_resourceDefinitions", unknownDefinitions, sortDefinitions: true, addExpressionReferences: false);
            }

            WriteDefinitionMap(writer, "definitions", resourceSchema.Definitions, sortDefinitions: true, addExpressionReferences: false);

            writer.WriteEndObject();
        }

        private static void WriteDefinitionMap(JsonWriter writer, string definitionMapName, IDictionary<string, JsonSchema> definitionMap, bool sortDefinitions = false, bool addExpressionReferences = false)
        {
            writer.WritePropertyName(definitionMapName);
            writer.WriteStartObject();

            var definitionNames = definitionMap?.Keys ?? Enumerable.Empty<string>();
            if (sortDefinitions)
            {
                definitionNames = definitionNames.OrderBy(key => key, StringComparer.OrdinalIgnoreCase);
            }

            foreach (var definitionName in definitionNames)
            {
                var definition = definitionMap[definitionName];

                var shouldAddExpressionReference = addExpressionReferences && !definition.Configuration.HasFlag(SchemaConfiguration.OmitExpressionRef);
                switch (definition.JsonType)
                {
                    case "object":
                        shouldAddExpressionReference &= !definition.IsEmpty();
                        break;

                    case "string":
                        shouldAddExpressionReference &= (definition.Enum?.Any() == true) || (definition.Pattern != null);
                        break;

                    case "array":
                        shouldAddExpressionReference &= definitionName != "resources";
                        break;

                    default:
                        break;
                }

                if (!shouldAddExpressionReference)
                {
                    WriteDefinition(writer, definitionName, definition);
                }
                else
                {
                    string definitionDescription = null;

                    writer.WritePropertyName(definitionName);
                    writer.WriteStartObject();

                    writer.WritePropertyName(definition.JsonType == "object" && definition.IsEmpty() ? "anyOf" : "oneOf"); // hack, until MultiType thing is enforced across the specs repo!
                    writer.WriteStartArray();

                    if (definition.Description != null)
                    {
                        definitionDescription = definition.Description;

                        definition = definition.Clone();
                        definition.Description = null;
                    }
                    WriteDefinition(writer, definition);

                    WriteDefinition(writer, new JsonSchema()
                    {
                        Ref = "https://schema.management.azure.com/schemas/common/definitions.json#/definitions/expression"
                    });

                    writer.WriteEndArray();

                    WriteProperty(writer, "description", definitionDescription);
                    writer.WriteEndObject();
                }
            }
            writer.WriteEndObject();
        }

        public static void WriteDefinition(JsonWriter writer, string resourceName, JsonSchema definition)
        {
            if (writer == null)
            {
                throw new ArgumentNullException("writer");
            }

            if (definition != null)
            {
                writer.WritePropertyName(resourceName);
                WriteDefinition(writer, definition);
            }
        }

        private static object ConvertDefaultValue(string defaultValue, string type)
        {
            switch (type)
            {
                case "boolean":
                    return bool.Parse(defaultValue.ToLowerInvariant());
                case "number":
                    return double.Parse(defaultValue.ToLowerInvariant());
                default:
                    return defaultValue;
            }
        }

        private static void WriteDefinition(JsonWriter writer, JsonSchema definition)
        {
            if (definition == null)
            {
                throw new ArgumentNullException("definition");
            }

            writer.WriteStartObject();

            WriteProperty(writer, "type", definition.JsonType); // move out once MultiType is here
            WriteProperty(writer, "multipleOf", definition.MultipleOf);
            WriteProperty(writer, "minimum", definition.Minimum);
            WriteProperty(writer, "maximum", definition.Maximum);
            WriteProperty(writer, "pattern", definition.Pattern);
            WriteProperty(writer, "minLength", definition.MinLength);
            WriteProperty(writer, "maxLength", definition.MaxLength);
            if (definition.Default != null)
            {
                WritePropertyRaw(writer, "default", ConvertDefaultValue(definition.Default, definition.JsonType));
            }
            WriteStringArray(writer, "enum", definition.Enum, sortDefinitions: false);
            WriteDefinitionArray(writer, "oneOf", definition.OneOf);
            WriteDefinitionArray(writer, "anyOf", definition.AnyOf);
            WriteDefinitionArray(writer, "allOf", definition.AllOf);

            // uuid in format on schemas makes VS cry. just leave it as a string with the pattern.
            if (definition.Format != "uuid")
            {
                WriteProperty(writer, "format", definition.Format);
            }

            WriteProperty(writer, "$ref", definition.Ref);
            WriteDefinition(writer, "items", definition.Items);
            WriteDefinition(writer, "additionalProperties", definition.AdditionalProperties);
            if (definition.JsonType == "object")
            {
                WriteDefinitionMap(writer, "properties", definition.Properties, sortDefinitions: true, addExpressionReferences: true);
            }
            WriteStringArray(writer, "required", definition.Required, sortDefinitions: true);

            WriteProperty(writer, "description", definition.Description);

            writer.WriteEndObject();
        }

        private static void WriteStringArray(JsonWriter writer, string arrayName, IEnumerable<string> arrayValues, bool sortDefinitions = false)
        {
            if (arrayValues == null || !arrayValues.Any())
            {
                return;
            }

            if (sortDefinitions)
            {
                arrayValues = arrayValues.OrderBy(x => x, StringComparer.OrdinalIgnoreCase);
            }

            writer.WritePropertyName(arrayName);
            writer.WriteStartArray();
            foreach (string arrayValue in arrayValues)
            {
                writer.WriteValue(arrayValue);
            }
            writer.WriteEndArray();
        }

        private static void WriteDefinitionArray(JsonWriter writer, string arrayName, IEnumerable<JsonSchema> arrayDefinitions)
        {
            if (arrayDefinitions != null && arrayDefinitions.Count() > 0)
            {
                writer.WritePropertyName(arrayName);

                writer.WriteStartArray();
                foreach (JsonSchema definition in arrayDefinitions)
                {
                    WriteDefinition(writer, definition);
                }
                writer.WriteEndArray();
            }
        }

        public static void WriteProperty(JsonWriter writer, string propertyName, string propertyValue)
        {
            if (writer == null)
            {
                throw new ArgumentNullException("writer");
            }
            if (string.IsNullOrWhiteSpace(propertyName))
            {
                throw new ArgumentException("propertyName cannot be null or whitespace", "propertyName");
            }

            if (!string.IsNullOrWhiteSpace(propertyValue))
            {
                writer.WritePropertyName(propertyName);
                writer.WriteValue(propertyValue);
            }
        }

        public static void WritePropertyRaw(JsonWriter writer, string propertyName, object propertyValue)
        {
            if (writer == null)
            {
                throw new ArgumentNullException("writer");
            }
            if (string.IsNullOrWhiteSpace(propertyName))
            {
                throw new ArgumentException("propertyName cannot be null or whitespace", "propertyName");
            }

            writer.WritePropertyName(propertyName);
            writer.WriteValue(propertyValue);
        }

        public static void WriteProperty(JsonWriter writer, string propertyName, double? propertyValue)
        {
            if (writer == null)
            {
                throw new ArgumentNullException("writer");
            }
            if (string.IsNullOrWhiteSpace(propertyName))
            {
                throw new ArgumentException("propertyName cannot be null or whitespace", "propertyName");
            }

            if (propertyValue != null)
            {
                writer.WritePropertyName(propertyName);

                double doubleValue = propertyValue.Value;
                long longValue = (long)doubleValue;
                if (doubleValue == longValue)
                {
                    writer.WriteValue(longValue);
                }
                else
                {
                    writer.WriteValue(doubleValue);
                }
            }
        }
    }
}
*/