using Microsoft.EntityFrameworkCore.Storage;

public class JsonSqlGenerationHelper : RelationalSqlGenerationHelper
{
  public JsonSqlGenerationHelper(RelationalSqlGenerationHelperDependencies dependencies) : base(dependencies)
  {
  }
}
