using System;
using System.Reflection;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage;

namespace ef_core_json_provider
{

  public class JsonTypeMappingSource : RelationalTypeMappingSource
  {
    public JsonTypeMappingSource([NotNullAttribute] TypeMappingSourceDependencies dependencies, [NotNullAttribute] RelationalTypeMappingSourceDependencies relationalDependencies) : base(dependencies, relationalDependencies)
    {
    }

    protected override TypeMappingSourceDependencies Dependencies => base.Dependencies;

    protected override RelationalTypeMappingSourceDependencies RelationalDependencies => base.RelationalDependencies;

    public override bool Equals(object obj)
    {
      return base.Equals(obj);
    }

    public override CoreTypeMapping FindMapping(IProperty property)
    {
      return base.FindMapping(property);
    }

    public override CoreTypeMapping FindMapping(Type type)
    {
      return base.FindMapping(type);
    }

    public override CoreTypeMapping FindMapping(MemberInfo member)
    {
      return base.FindMapping(member);
    }

    public override RelationalTypeMapping FindMapping(string storeTypeName)
    {
      return base.FindMapping(storeTypeName);
    }

    public override RelationalTypeMapping FindMapping(Type type, string storeTypeName, bool keyOrIndex = false, bool? unicode = null, int? size = null, bool? rowVersion = null, bool? fixedLength = null, int? precision = null, int? scale = null)
    {
      return base.FindMapping(type, storeTypeName, keyOrIndex, unicode, size, rowVersion, fixedLength, precision, scale);
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }

    public override string ToString()
    {
      return base.ToString();
    }

    protected override RelationalTypeMapping FindMapping(in RelationalTypeMappingInfo mappingInfo)
    {
      return base.FindMapping(mappingInfo);
    }

    protected override CoreTypeMapping FindMapping(in TypeMappingInfo mappingInfo)
    {
      return base.FindMapping(mappingInfo);
    }

    protected override string ParseStoreTypeName(string storeTypeName, out bool? unicode, out int? size, out int? precision, out int? scale)
    {
      return base.ParseStoreTypeName(storeTypeName, out unicode, out size, out precision, out scale);
    }

    protected override void ValidateMapping(CoreTypeMapping mapping, IProperty property)
    {
      base.ValidateMapping(mapping, property);
    }
  }

}
