using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

public class JsonOptionsExtension : RelationalOptionsExtension
{
  public override DbContextOptionsExtensionInfo Info
  {
    get
    {
      Console.WriteLine("JsonOptionsExtension.Info");
      return new ExtensionInfo(this);
    }
  }


  private sealed class ExtensionInfo : RelationalExtensionInfo
  {
    public ExtensionInfo(IDbContextOptionsExtension extension) : base(extension)
    {
    }

    public override bool IsDatabaseProvider
    {
      get
      {
        return true;
      }
    }

    public override string LogFragment
    {
      get
      {
        throw new Exception();
      }
    }

    public override long GetServiceProviderHashCode()
    {
      return base.GetServiceProviderHashCode();
    }

    public override void PopulateDebugInfo(IDictionary<string, string> debugInfo)
    {
      Console.WriteLine("ExtensionInfo.PopulateDebugInfo");
    }
  }

  protected override RelationalOptionsExtension Clone()
  {
    Console.WriteLine("JsonOptionsExtension.Clone");
    return this;
  }

  public override void ApplyServices(IServiceCollection services)
  {
    Console.WriteLine("JsonOptionsExtension.ApplyServices");
    services.AddEntityFrameworkJson();
  }
}
