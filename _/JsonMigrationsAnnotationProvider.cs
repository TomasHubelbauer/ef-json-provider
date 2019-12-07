using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ef_core_json_provider
{
  internal class JsonMigrationsAnnotationProvider : MigrationsAnnotationProvider
  {
    public JsonMigrationsAnnotationProvider([NotNullAttribute] MigrationsAnnotationProviderDependencies dependencies) : base(dependencies)
    {
    }
  }
}
