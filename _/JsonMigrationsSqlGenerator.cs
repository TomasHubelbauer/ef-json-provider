using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace ef_core_json_provider
{
  internal class JsonMigrationsSqlGenerator : IMigrationsSqlGenerator
  {
    public JsonMigrationsSqlGenerator()
    {
    }

    public IReadOnlyList<MigrationCommand> Generate(IReadOnlyList<MigrationOperation> operations, IModel model = null)
    {
      throw new System.NotImplementedException();
    }
  }
}
