// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AutoRest.AzureResourceSchema.Models;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis;
using System.Text.RegularExpressions;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace AutoRest.AzureResourceSchema
{
    [Flags]
    public enum TypePropertyFlags
    {
        None = 0,

        Required = 1 << 0,

        Constant = 1 << 1,

        ReadOnly = 1 << 2,

        WriteOnly = 1 << 3,

        SkipInlining = 1 << 4,
    }

    public static class ResourceSchemaWriter
    {
        private static IDictionary<string, JsonSchema> GetResourceDefinitions(ResourceSchema resourceSchema, ScopeType scopeType)
            => resourceSchema.ResourceDefinitions
                .Where(kvp => kvp.Key.ScopeType == scopeType)
                .ToDictionary(kvp => ResourceSchema.FormatResourceSchemaKey(kvp.Key.ResourceTypeSegments), kvp => kvp.Value);

        private static string FormatResourceTypePropertyName(ResourceDescriptor descriptor)
            => $"ResourceType_{string.Join('_', descriptor.ResourceTypeSegments)}";

        private static string FormatResourceTypeReferencePropertyName(ResourceDescriptor descriptor)
            => $"ResourceTypeReference_{string.Join('_', descriptor.ResourceTypeSegments)}";

        private static string FormatClassName(ResourceDescriptor descriptor)
        {
            // upper-case the first char
            var providerNamespace = descriptor.ProviderNamespace.Substring(0, 1).ToUpperInvariant()
                + descriptor.ProviderNamespace.Substring(1);

            return Regex.Replace($"{providerNamespace}_{descriptor.ApiVersion}", "[^a-zA-Z0-9_]", "_");
        }

        private static string FormatBicepStringLiteral(string value)
        {
            var escaped = value
                .Replace("\\", "\\\\") // must do this first!
                .Replace("\r", "\\r")
                .Replace("\n", "\\n")
                .Replace("\t", "\\t")
                .Replace("${", "\\${")
                .Replace("'", "\\'");

            return $"'{escaped}'";
        }

        static IEnumerable<TypePropertyFlags> GetIndividualFlags(TypePropertyFlags flags)
        {
            if (flags == TypePropertyFlags.None)
            {
                yield return flags;
                yield break;
            }

            foreach (TypePropertyFlags value in Enum.GetValues(typeof(TypePropertyFlags)))
            {
                if (flags.HasFlag(value) && value != TypePropertyFlags.None)
                {
                    yield return value;
                }
            }
        }

        private static ExpressionSyntax BuildFlagsExpression(TypePropertyFlags flags)
        {
            var individualFlags = new Stack<TypePropertyFlags>(GetIndividualFlags(flags));

            var currentFlag = individualFlags.Pop();
            ExpressionSyntax expression = MemberAccessExpression(
                SyntaxKind.SimpleMemberAccessExpression,
                IdentifierName("TypePropertyFlags"),
                IdentifierName(currentFlag.ToString()));

            while (individualFlags.Any())
            {
                currentFlag = individualFlags.Pop();
                
                expression = BinaryExpression(
                    SyntaxKind.BitwiseOrExpression,
                    expression,
                    MemberAccessExpression(
                        SyntaxKind.SimpleMemberAccessExpression,
                        IdentifierName("TypePropertyFlags"),
                        IdentifierName(currentFlag.ToString())));
            }

            return expression;
        }

        private static string FormatLanguageConstantForType(JsonSchema schema)
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

        private static MemberDeclarationSyntax GetClassConstructor(string className, IEnumerable<(ResourceDescriptor descriptor, JsonSchema schema)> resources, IEnumerable<(string name, JsonSchema schema)> definitions)
        {
            var constructorStatements = new List<StatementSyntax>();
            
            foreach (var (typeName, schema) in definitions)
            {
                constructorStatements.Add(ExpressionStatement(
                    AssignmentExpression(
                        SyntaxKind.SimpleAssignmentExpression,
                        IdentifierName(typeName),
                        GetTypeCreationSyntax(typeName, schema, out var containsReference))));

                if (containsReference)
                {
                    throw new ArgumentException($"Unsupported $ref directly inside top-level definition {typeName}");
                }
            }
            
            foreach (var (descriptor, schema) in resources)
            {
                constructorStatements.Add(ExpressionStatement(
                    AssignmentExpression(
                        SyntaxKind.SimpleAssignmentExpression,
                        IdentifierName(FormatResourceTypePropertyName(descriptor)),
                        GetResourceTypeCreationSyntax(descriptor, schema))));
            }

            return ConstructorDeclaration(
                Identifier(className))
            .WithModifiers(
                TokenList(
                    Token(SyntaxKind.PrivateKeyword)))
            .WithBody(
                Block(constructorStatements));
        }

        private static MemberDeclarationSyntax GetLazyInstanceField(string className)
        {
            return FieldDeclaration(
                VariableDeclaration(
                    GenericName(
                        Identifier("Lazy"))
                    .WithTypeArgumentList(
                        TypeArgumentList(
                            SingletonSeparatedList<TypeSyntax>(
                                IdentifierName(className)))))
                .WithVariables(
                    SingletonSeparatedList<VariableDeclaratorSyntax>(
                        VariableDeclarator(
                            Identifier("InstanceLazy"))
                        .WithInitializer(
                            EqualsValueClause(
                                ObjectCreationExpression(
                                    GenericName(
                                        Identifier("Lazy"))
                                    .WithTypeArgumentList(
                                        TypeArgumentList(
                                            SingletonSeparatedList<TypeSyntax>(
                                                IdentifierName(className)))))
                                .WithArgumentList(
                                    ArgumentList(
                                        SingletonSeparatedList<ArgumentSyntax>(
                                            Argument(
                                                ParenthesizedLambdaExpression(
                                                    ObjectCreationExpression(
                                                        IdentifierName(className))
                                                    .WithArgumentList(
                                                        ArgumentList())))))))))))
            .WithModifiers(
                TokenList(
                    new []{
                        Token(SyntaxKind.PrivateKeyword),
                        Token(SyntaxKind.StaticKeyword)}));
        }

        private static MemberDeclarationSyntax GetRegisterMethod(IEnumerable<(ResourceDescriptor descriptor, JsonSchema schema)> resources)
        {
            var firstDescriptor = resources.First().descriptor;

            var registerMethodStatements = new List<StatementSyntax>();

            foreach (var (descriptor, _) in resources)
            {
                registerMethodStatements.Add(GetResourceTypeRegistrationSyntax(descriptor));
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
                            IdentifierName("IResourceTypeRegistrar")))))
            .WithBody(
                Block(registerMethodStatements));
        }

        private static ExpressionStatementSyntax GetResourceTypeRegistrationSyntax(ResourceDescriptor descriptor)
        {
            var resourceTypeReferenceProperty = FormatResourceTypeReferencePropertyName(descriptor);
            var resourceTypeProperty = FormatResourceTypePropertyName(descriptor);
    
            var lazyAccessor = ParenthesizedLambdaExpression(
                MemberAccessExpression(
                    SyntaxKind.SimpleMemberAccessExpression,
                    MemberAccessExpression(
                        SyntaxKind.SimpleMemberAccessExpression,
                        IdentifierName("InstanceLazy"),
                        IdentifierName("Value")),
                    IdentifierName(resourceTypeProperty)));

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
                                Argument(IdentifierName(resourceTypeReferenceProperty)),
                                Token(SyntaxKind.CommaToken),
                                Argument(lazyAccessor)}))));
        }

        private static ExpressionSyntax GetResourceTypeReferenceCreationSyntax(ResourceDescriptor descriptor)
        {
            var providerNamespaceArg = Argument(
                IdentifierName("ProviderNamespace"));

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
                            typeSegments.Skip(1).Select(x => Token(SyntaxKind.CommaToken))))));
                
            var apiVersionArg = Argument(
                IdentifierName("ApiVersion"));

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

        private static ExpressionSyntax GetResourceTypeCreationSyntax(ResourceDescriptor descriptor, JsonSchema schema)
        {
            var resourceTypeReferenceProperty = FormatResourceTypeReferencePropertyName(descriptor);

            var properties = new List<ExpressionSyntax>();
            foreach (var kvp in schema.Properties)
            {
                if (kvp.Key == "resources")
                {
                    // remove in-line child resources
                    continue;
                }

                var flags = TypePropertyFlags.None;
                switch (kvp.Key)
                {
                    case "id":
                    case "type":
                    case "apiVersion":
                        flags |= TypePropertyFlags.ReadOnly | TypePropertyFlags.SkipInlining;
                        break;
                    case "name":
                        flags |= TypePropertyFlags.Required | TypePropertyFlags.SkipInlining;
                        break;
                    default:
                        if (schema.Required?.Contains(kvp.Key) == true)
                        {
                            flags |= TypePropertyFlags.Required;
                        }
                        break;
                }

                properties.Add(GetTypePropertyCreationSyntax(kvp.Key, kvp.Value, flags));
            }

            var additionalPropertiesType = (schema.AdditionalProperties != null) ?
                GetTypePropertyCreationSyntax("additionalProperties", schema.AdditionalProperties, TypePropertyFlags.None) :
                LiteralExpression(SyntaxKind.NullLiteralExpression);

            return ObjectCreationExpression(
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
                                        IdentifierName("ITypeProperty"))
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
                            Argument(IdentifierName(resourceTypeReferenceProperty))})));
        }

        private static ClassDeclarationSyntax GetClassDeclaration(ResourceSchema resourceSchema)
        {
            var classMembers = new List<MemberDeclarationSyntax>();

            var firstDescriptor = resourceSchema.ResourceDefinitions.First().Key;
            var className = FormatClassName(firstDescriptor);

            var resourcePairs = resourceSchema.ResourceDefinitions
                .Where(kvp => kvp.Key.ScopeType == ScopeType.ResourceGroup)
                .Select(kvp => (descriptor: kvp.Key, schema: kvp.Value))
                .ToArray();

            var definitionPairs = resourceSchema.Definitions
                .Where(kvp => !kvp.Key.EndsWith("_childResource")) // remove in-line child resources
                .Select(kvp => (name: kvp.Key, schema: kvp.Value))
                .ToArray();

            classMembers.Add(GetConstStringDeclarationSyntax("ProviderNamespace", firstDescriptor.ProviderNamespace));
            classMembers.Add(GetConstStringDeclarationSyntax("ApiVersion", firstDescriptor.ApiVersion));

            foreach (var (descriptor, _) in resourcePairs)
            {
                classMembers.Add(
                    GetStaticReadOnlyFieldDeclarationAndAssignment(
                        "ResourceTypeReference",
                        FormatResourceTypeReferencePropertyName(descriptor),
                        GetResourceTypeReferenceCreationSyntax(descriptor)));
            }

            classMembers.Add(GetLazyInstanceField(className));

            classMembers.Add(GetClassConstructor(className, resourcePairs, definitionPairs));

            classMembers.Add(GetRegisterMethod(resourcePairs));

            foreach (var (descriptor, _) in resourcePairs)
            {
                classMembers.Add(GetReadOnlyFieldDeclarationSyntax(
                    "ResourceType",
                    FormatResourceTypePropertyName(descriptor)));
            }
            
            foreach (var (typeName, _) in definitionPairs)
            {
                classMembers.Add(GetReadOnlyFieldDeclarationSyntax(
                    "TypeSymbol",
                    typeName));
            }

            return ClassDeclaration(className)
                .WithModifiers(
                    TokenList(
                        new []{
                            Token(SyntaxKind.PublicKeyword)}))
                .WithMembers(
                    List<MemberDeclarationSyntax>(classMembers));
        }

        private static MemberDeclarationSyntax GetStaticReadOnlyFieldDeclarationAndAssignment(string propertyType, string propertyName, ExpressionSyntax value)
        {
            return FieldDeclaration(
                VariableDeclaration(
                    IdentifierName(propertyType))
                .WithVariables(
                    SingletonSeparatedList<VariableDeclaratorSyntax>(
                        VariableDeclarator(
                            Identifier(propertyName))
                        .WithInitializer(
                            EqualsValueClause(
                                value)))))
            .WithModifiers(
                TokenList(
                    new []{
                        Token(SyntaxKind.PrivateKeyword),
                        Token(SyntaxKind.StaticKeyword),
                        Token(SyntaxKind.ReadOnlyKeyword)}));
        }

        private static MemberDeclarationSyntax GetReadOnlyFieldDeclarationSyntax(string propertyType, string propertyName)
        {
            return FieldDeclaration(
                VariableDeclaration(
                    IdentifierName(propertyType))
                .WithVariables(
                    SingletonSeparatedList<VariableDeclaratorSyntax>(
                        VariableDeclarator(
                            Identifier(propertyName)))))
            .WithModifiers(
                TokenList(
                    new []{
                        Token(SyntaxKind.PrivateKeyword),
                        Token(SyntaxKind.ReadOnlyKeyword)}));
        }

        private static MemberDeclarationSyntax GetConstStringDeclarationSyntax(string propertyName, string propertyValue)
        {
            return FieldDeclaration(
                VariableDeclaration(
                    PredefinedType(
                        Token(SyntaxKind.StringKeyword)))
                .WithVariables(
                    SingletonSeparatedList<VariableDeclaratorSyntax>(
                        VariableDeclarator(
                            Identifier(propertyName))
                        .WithInitializer(
                            EqualsValueClause(
                                LiteralExpression(
                                    SyntaxKind.StringLiteralExpression,
                                    Literal(propertyValue)))))))
            .WithModifiers(
                TokenList(
                    new []{
                        Token(SyntaxKind.PrivateKeyword),
                        Token(SyntaxKind.ConstKeyword)}));
        }

        private static ExpressionSyntax GetTypeCreationSyntax(string typeName, JsonSchema schema, out bool containsReference)
        {
            containsReference = false;

            switch (schema.JsonType)
            {
                case "object":
                case null: // assume object if not specified
                    return GetObjectTypeCreationSyntax(typeName, schema, out containsReference);
                case "array":
                    return GetArrayTypeCreationSyntax(typeName, schema, out containsReference);
                case "string":
                    return GetStringTypeCreationSyntax(typeName, schema);
                case "number":
                case "integer":
                    return MemberAccessExpression(
                        SyntaxKind.SimpleMemberAccessExpression,
                        IdentifierName("LanguageConstants"),
                        IdentifierName("Int"));
                case "boolean":
                    return MemberAccessExpression(
                        SyntaxKind.SimpleMemberAccessExpression,
                        IdentifierName("LanguageConstants"),
                        IdentifierName("Bool"));
            }

            throw new NotImplementedException($"Unrecognized type '{schema.JsonType}'");
        }

        private static ExpressionSyntax GetStringTypeCreationSyntax(string typeName, JsonSchema schema)
        {
            if (schema.Enum != null)
            {
                var enumExpressions = new List<ExpressionSyntax>();
                foreach (var enumVal in schema.Enum)
                {
                    var literalValue = FormatBicepStringLiteral(enumVal);

                    enumExpressions.Add(ObjectCreationExpression(
                        IdentifierName("StringLiteralType"))
                    .WithArgumentList(
                        ArgumentList(
                            SingletonSeparatedList<ArgumentSyntax>(
                                Argument(
                                    LiteralExpression(
                                        SyntaxKind.StringLiteralExpression,
                                        Literal(literalValue)))))));
                }

                return InvocationExpression(
                    MemberAccessExpression(
                        SyntaxKind.SimpleMemberAccessExpression,
                        IdentifierName("UnionType"),
                        IdentifierName("Create")))
                .WithArgumentList(
                    ArgumentList(
                        SeparatedList<ArgumentSyntax>(
                            enumExpressions.Select(Argument),
                            enumExpressions.Skip(1).Select(x => Token(SyntaxKind.CommaToken)))));
            }

            return MemberAccessExpression(
                SyntaxKind.SimpleMemberAccessExpression,
                IdentifierName("LanguageConstants"),
                IdentifierName("String"));
        }

        private static ExpressionSyntax GetArrayTypeCreationSyntax(string typeName, JsonSchema schema, out bool containsReference)
        {
            containsReference = false;

            if (schema.Items == null)
            {
                return MemberAccessExpression(
                    SyntaxKind.SimpleMemberAccessExpression,
                    IdentifierName("LanguageConstants"),
                    IdentifierName("Array"));
            }

            containsReference = schema.Items.Ref != null;

            var itemType = containsReference ? 
                GetReferenceSyntax(schema.Items) : 
                GetTypeCreationSyntax(typeName, schema.Items, out containsReference);

            return ObjectCreationExpression(
                IdentifierName("TypedArrayType"))
            .WithArgumentList(
                ArgumentList(
                    SingletonSeparatedList<ArgumentSyntax>(
                        Argument(itemType))));
        }

        private static ExpressionSyntax GetReferenceSyntax(JsonSchema schema)
        {
            // TODO improve this
            var definitionName = schema.Ref.Substring("#/definitions/".Length);

            return IdentifierName(definitionName);
        }

        private static ExpressionSyntax GetObjectTypeCreationSyntax(string typeName, JsonSchema schema, out bool containsReference)
        {
            containsReference = schema.Ref != null;
            if (containsReference)
            {
                return GetReferenceSyntax(schema);
            }

            var properties = new List<ExpressionSyntax>();
            if (schema.Properties != null)
            {
                foreach (var kvp in schema.Properties)
                {
                    var flags = TypePropertyFlags.None;
                    if (schema.Required?.Contains(kvp.Key) == true)
                    {
                        flags |= TypePropertyFlags.Required;
                    }

                    properties.Add(GetTypePropertyCreationSyntax(kvp.Key, kvp.Value, flags));
                }
            }

            if (schema.Properties == null && schema.AdditionalProperties == null)
            {
                return MemberAccessExpression(
                    SyntaxKind.SimpleMemberAccessExpression,
                    IdentifierName("LanguageConstants"),
                    IdentifierName("Object"));
            }

            var additionalPropertiesType = (schema.AdditionalProperties != null) ?
                GetTypePropertyCreationSyntax("additionalProperties", schema.AdditionalProperties, TypePropertyFlags.None) :
                LiteralExpression(SyntaxKind.NullLiteralExpression);

            return ObjectCreationExpression(
                IdentifierName("NamedObjectType"))
            .WithArgumentList(
                ArgumentList(
                    SeparatedList<ArgumentSyntax>(
                        new SyntaxNodeOrToken[]{
                            Argument(
                                LiteralExpression(
                                    SyntaxKind.StringLiteralExpression,
                                    Literal(typeName))),
                            Token(SyntaxKind.CommaToken),
                            Argument(
                                ArrayCreationExpression(
                                    ArrayType(
                                        IdentifierName("ITypeProperty"))
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
                            Argument(additionalPropertiesType)})));
        }

        private static ExpressionSyntax GetTypePropertyCreationSyntax(string typeName, JsonSchema schema, TypePropertyFlags flags)
        {
            var type = GetTypeCreationSyntax(typeName, schema, out var containsReference);

            var className = containsReference ? "LazyTypeProperty" : "TypeProperty";
            ExpressionSyntax typeArgument = containsReference ? ParenthesizedLambdaExpression(type) : type;

            return ObjectCreationExpression(
                IdentifierName(className))
            .WithArgumentList(
                ArgumentList(
                    SeparatedList<ArgumentSyntax>(
                        new SyntaxNodeOrToken[]{
                            Argument(
                                LiteralExpression(
                                    SyntaxKind.StringLiteralExpression,
                                    Literal(typeName))),
                            Token(SyntaxKind.CommaToken),
                            Argument(typeArgument),
                            Token(SyntaxKind.CommaToken),
                            Argument(BuildFlagsExpression(flags))})));
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
                                IdentifierName("System"))
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
                                    IdentifierName("Bicep"),
                                    IdentifierName("Core"))),
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
                                    GetClassDeclaration(resourceSchema)
                                    .WithAttributeLists(
                                        SingletonList<AttributeListSyntax>(
                                            AttributeList(
                                                SingletonSeparatedList<AttributeSyntax>(
                                                    Attribute(
                                                        IdentifierName("ResourceTypeRegisterableAttribute"))))))))}))
                .NormalizeWhitespace()
                .WriteTo(writer);
        }
    }
}