using System;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace ef_core_json_provider
{
  public class JsonOptionsExtension : RelationalOptionsExtension
  {
    public override DbContextOptionsExtensionInfo Info => new JsonDbContextOptionsExtensionInfo(this);

    public override void ApplyServices(IServiceCollection services)
    {
      Console.WriteLine(nameof(JsonOptionsExtension) + '.' + nameof(ApplyServices));
      services.AddEntityFrameworkJson();
    }

    protected override RelationalOptionsExtension Clone()
    {
      throw new NotImplementedException();
    }
  }

}
