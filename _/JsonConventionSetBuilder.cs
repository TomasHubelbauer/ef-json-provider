using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;

namespace ef_core_json_provider
{
  internal class JsonConventionSetBuilder : RelationalConventionSetBuilder, IConventionSetBuilder
  {
    public JsonConventionSetBuilder([NotNullAttribute] ProviderConventionSetBuilderDependencies dependencies, [NotNullAttribute] RelationalConventionSetBuilderDependencies relationalDependencies) : base(dependencies, relationalDependencies)
    {
    }
  }
}
