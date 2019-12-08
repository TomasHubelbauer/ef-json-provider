using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Data;
using System.Reflection;

public class JsonTypeMappingSource : RelationalTypeMappingSource
{
  public JsonTypeMappingSource(TypeMappingSourceDependencies dependencies, RelationalTypeMappingSourceDependencies relationalDependencies) : base(dependencies, relationalDependencies)
  {
  }

  // public override CoreTypeMapping FindMapping(IProperty property)
  // {
  //   Console.WriteLine(property.Name);
  //   throw new Exception();
  // }

  public override CoreTypeMapping FindMapping(Type type)
  {
    switch (type.FullName)
    {
      case "System.Boolean":
        {
          return new IntTypeMapping("number");
        }
      default:
        {
          Console.WriteLine(type.FullName);
          throw new Exception();
        }
    }
  }

  // public override CoreTypeMapping FindMapping(MemberInfo member)
  // {
  //   Console.WriteLine(member.Name);
  //   //throw new Exception();
  //   return null;
  // }

  public override RelationalTypeMapping FindMapping(string storeTypeName)
  {
    throw new Exception();
  }

  public override RelationalTypeMapping FindMapping(Type type, string storeTypeName, bool keyOrIndex = false, bool? unicode = null, int? size = null, bool? rowVersion = null, bool? fixedLength = null, int? precision = null, int? scale = null)
  {
    throw new Exception();
  }

  protected override RelationalTypeMapping FindMapping(in RelationalTypeMappingInfo mappingInfo)
  {
    if (mappingInfo.ClrType != null)
    {
      switch (mappingInfo.ClrType.FullName)
      {
        case "System.Int32":
          {
            return new IntTypeMapping("number");
          }
        case "System.String":
          {
            return new StringTypeMapping("string");
          }
        default:
          {
            Console.WriteLine(mappingInfo.ClrType.FullName);
            throw new Exception();
          }
      }
    }

    Console.WriteLine(mappingInfo.StoreTypeName);
    Console.WriteLine(mappingInfo.StoreTypeNameBase);
    throw new Exception();
  }

  protected override CoreTypeMapping FindMapping(in TypeMappingInfo mappingInfo)
  {
    throw new Exception();
  }

  // protected override string ParseStoreTypeName(string storeTypeName, out bool? unicode, out int? size, out int? precision, out int? scale)
  // {
  //   Console.WriteLine(storeTypeName);
  //   throw new Exception();
  // }
}
