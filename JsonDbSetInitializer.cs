using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace ef_core_json_provider
{
  internal class JsonDbSetInitializer : IDbSetInitializer
  {
    public JsonDbSetInitializer()
    {
    }

    public void InitializeSets(DbContext context)
    {
      Console.WriteLine(nameof(InitializeSets));
    }
  }
}
