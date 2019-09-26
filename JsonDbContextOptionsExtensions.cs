using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace ef_core_json_provider
{
  public static class JsonDbContextOptionsExtensions
  {
    public static DbContextOptionsBuilder UseJson(this DbContextOptionsBuilder optionsBuilder)
    {
      Console.WriteLine(nameof(JsonDbContextOptionsExtensions) + '.' + nameof(UseJson));
      ((IDbContextOptionsBuilderInfrastructure)optionsBuilder).AddOrUpdateExtension(new JsonOptionsExtension());
      return optionsBuilder;
    }
  }

}
