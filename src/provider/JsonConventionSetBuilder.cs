using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;

public class JsonConventionSetBuilder : RelationalConventionSetBuilder
{
  public JsonConventionSetBuilder(ProviderConventionSetBuilderDependencies dependencies, RelationalConventionSetBuilderDependencies relationalDependencies) : base(dependencies, relationalDependencies)
  {
  }
}
