export interface TypeBase {
}

export interface TypeReference {
  index: number;
}

export enum BuiltInTypeKind {
  Any = 1,
  Null = 2,
  Bool = 3,
  Int = 4,
  String = 5,
  Object = 6,
  Array = 7,
  ResourceRef = 8,
}

export enum ScopeType {
  Unknown = 0,
  Tenant = 1 << 0,
  ManagementGroup = 1 << 1,
  Subscription = 1 << 2,
  ResourceGroup = 1 << 3,
  Extension = 1 << 4,
}

export interface BuiltInType extends TypeBase {
  kind: BuiltInTypeKind;
}

export interface UnionType extends TypeBase {
  elements: TypeReference[];
}

export interface StringLiteralType extends TypeBase {
  value: string;
}

export interface ResourceType extends TypeBase {
  name: string;
  scopeType: ScopeType;
  body: TypeReference;
}

export enum ObjectPropertyFlags {
  None = 0,
  Required = 1 << 0,
  ReadOnly = 1 << 1,
  WriteOnly = 1 << 2,
  DeployTimeConstant = 1 << 3,
}

export interface ObjectProperty {
  type: TypeReference;
  flags: ObjectPropertyFlags;
}

export interface ObjectType extends TypeBase {
  name: string;
  properties: Record<string, ObjectProperty>;
  additionalProperties: TypeReference;
}

export interface DiscriminatedObjectType extends TypeBase {
  name: string;
  discriminator: string;
  baseProperties: Record<string, ObjectProperty>;
  elements: Record<string, TypeReference>;
}

export interface ArrayType extends TypeBase {
  itemType: TypeReference;
}

export class TypeFactory {
  readonly types: TypeBase[];
  readonly builtInTypes: Record<BuiltInTypeKind, TypeReference>;

  constructor() {
    this.types = [];
    this.builtInTypes = {
      [BuiltInTypeKind.Any]: this.addType({ kind: BuiltInTypeKind.Any }),
      [BuiltInTypeKind.Null]: this.addType({ kind: BuiltInTypeKind.Null }),
      [BuiltInTypeKind.Bool]: this.addType({ kind: BuiltInTypeKind.Bool }),
      [BuiltInTypeKind.Int]: this.addType({ kind: BuiltInTypeKind.Int }),
      [BuiltInTypeKind.String]: this.addType({ kind: BuiltInTypeKind.String }),
      [BuiltInTypeKind.Object]: this.addType({ kind: BuiltInTypeKind.Object }),
      [BuiltInTypeKind.Array]: this.addType({ kind: BuiltInTypeKind.Array }),
      [BuiltInTypeKind.ResourceRef]: this.addType({ kind: BuiltInTypeKind.ResourceRef }),
    };
  }

  public addType<TType extends TypeBase>(type: TType): TypeReference {
    const index = this.types.length;
    this.types[index] = type;

    return { index };
  }

  public lookupType<TType extends TypeBase>(reference: TypeReference): TType {
    return this.types[reference.index] as TType;
  }

  public lookupBuiltInType(kind: BuiltInTypeKind): TypeReference {
    return this.builtInTypes[kind];
  }
}