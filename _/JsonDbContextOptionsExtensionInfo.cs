using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace ef_core_json_provider
{
  public sealed class JsonDbContextOptionsExtensionInfo : DbContextOptionsExtensionInfo
  {
    public JsonDbContextOptionsExtensionInfo(IDbContextOptionsExtension extension) : base(extension)
    {
    }

    public override bool IsDatabaseProvider => true;

    public override string LogFragment => throw new System.NotImplementedException();

    public override IDbContextOptionsExtension Extension => base.Extension;

    public override bool Equals(object obj)
    {
      return base.Equals(obj);
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }

    public override long GetServiceProviderHashCode() => this.GetHashCode();

    public override void PopulateDebugInfo([NotNullAttribute] IDictionary<string, string> debugInfo)
    {
      Console.WriteLine("PopulateDebugInfo");
    }

    public override string ToString() => base.ToString();
  }
}
