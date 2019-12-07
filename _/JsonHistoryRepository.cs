using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;

namespace ef_core_json_provider
{
  internal class JsonHistoryRepository : HistoryRepository
  {
    public JsonHistoryRepository([NotNull] HistoryRepositoryDependencies dependencies) : base(dependencies)
    {
    }

    protected override string ExistsSql => throw new System.NotImplementedException();

    protected override HistoryRepositoryDependencies Dependencies => base.Dependencies;

    protected override ISqlGenerationHelper SqlGenerationHelper => base.SqlGenerationHelper;

    protected override string TableName => base.TableName;

    protected override string TableSchema => base.TableSchema;

    protected override string MigrationIdColumnName => base.MigrationIdColumnName;

    protected override string ProductVersionColumnName => base.ProductVersionColumnName;

    protected override string GetAppliedMigrationsSql => base.GetAppliedMigrationsSql;

    public override bool Equals(object obj)
    {
      return base.Equals(obj);
    }

    public override bool Exists()
    {
      return base.Exists();
    }

    public override Task<bool> ExistsAsync(CancellationToken cancellationToken = default)
    {
      return base.ExistsAsync(cancellationToken);
    }

    public override IReadOnlyList<HistoryRow> GetAppliedMigrations()
    {
      return base.GetAppliedMigrations();
    }

    public override Task<IReadOnlyList<HistoryRow>> GetAppliedMigrationsAsync(CancellationToken cancellationToken = default)
    {
      return base.GetAppliedMigrationsAsync(cancellationToken);
    }

    public override string GetBeginIfExistsScript(string migrationId)
    {
      throw new System.NotImplementedException();
    }

    public override string GetBeginIfNotExistsScript(string migrationId)
    {
      throw new System.NotImplementedException();
    }

    public override string GetCreateIfNotExistsScript()
    {
      throw new System.NotImplementedException();
    }

    public override string GetCreateScript()
    {
      return base.GetCreateScript();
    }

    public override string GetDeleteScript(string migrationId)
    {
      return base.GetDeleteScript(migrationId);
    }

    public override string GetEndIfScript()
    {
      throw new System.NotImplementedException();
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }

    public override string GetInsertScript(HistoryRow row)
    {
      return base.GetInsertScript(row);
    }

    public override string ToString()
    {
      return base.ToString();
    }

    protected override void ConfigureTable(EntityTypeBuilder<HistoryRow> history)
    {
      base.ConfigureTable(history);
    }

    protected override bool InterpretExistsResult([NotNull] object value)
    {
      throw new System.NotImplementedException();
    }
  }
}
