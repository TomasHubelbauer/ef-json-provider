using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Storage;

namespace ef_core_json_provider
{
  public class JsonDatabaseCreator : RelationalDatabaseCreator
  {
    public JsonDatabaseCreator([NotNullAttribute] RelationalDatabaseCreatorDependencies dependencies) : base(dependencies)
    {
    }

    public override void Create()
    {
      throw new System.NotImplementedException();
    }

    public override void Delete()
    {
      throw new System.NotImplementedException();
    }

    public override bool Exists()
    {
      throw new System.NotImplementedException();
    }

    public override bool HasTables()
    {
      throw new System.NotImplementedException();
    }
  }
}
