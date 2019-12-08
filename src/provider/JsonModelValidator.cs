using Microsoft.EntityFrameworkCore.Infrastructure;

public class JsonModelValidator : RelationalModelValidator
{
  public JsonModelValidator(ModelValidatorDependencies dependencies, RelationalModelValidatorDependencies relationalDependencies) : base(dependencies, relationalDependencies)
  {
  }
}
