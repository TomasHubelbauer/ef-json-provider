using System;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Internal;

namespace ef_core_json_provider
{
  internal class JsonSingletonOptionsInitializer : ISingletonOptionsInitializer
  {
    public JsonSingletonOptionsInitializer()
    {
      Console.WriteLine(nameof(JsonSingletonOptionsInitializer) + ".ctor");
    }

    public void EnsureInitialized(IServiceProvider serviceProvider, IDbContextOptions options)
    {
      Console.WriteLine(nameof(JsonSingletonOptionsInitializer) + '.' + nameof(EnsureInitialized));
    }
  }
}
