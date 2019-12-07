using System.Collections.Generic;
using System.Text;
using ef_core_json_provider;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Update;

namespace ef_core_json_provider
{
  public class JsonUpdateSqlGenerator : UpdateSqlGenerator, IJsonUpdateSqlGenerator
  {
    public JsonUpdateSqlGenerator([NotNull] UpdateSqlGeneratorDependencies dependencies) : base(dependencies)
    {
    }

    protected override UpdateSqlGeneratorDependencies Dependencies => base.Dependencies;

    protected override ISqlGenerationHelper SqlGenerationHelper => base.SqlGenerationHelper;

    public override void AppendBatchHeader(StringBuilder commandStringBuilder)
    {
      base.AppendBatchHeader(commandStringBuilder);
    }

    public override ResultSetMapping AppendDeleteOperation(StringBuilder commandStringBuilder, ModificationCommand command, int commandPosition)
    {
      return base.AppendDeleteOperation(commandStringBuilder, command, commandPosition);
    }

    public override ResultSetMapping AppendInsertOperation(StringBuilder commandStringBuilder, ModificationCommand command, int commandPosition)
    {
      return base.AppendInsertOperation(commandStringBuilder, command, commandPosition);
    }

    public override void AppendNextSequenceValueOperation(StringBuilder commandStringBuilder, string name, string schema)
    {
      base.AppendNextSequenceValueOperation(commandStringBuilder, name, schema);
    }

    public override ResultSetMapping AppendUpdateOperation(StringBuilder commandStringBuilder, ModificationCommand command, int commandPosition)
    {
      return base.AppendUpdateOperation(commandStringBuilder, command, commandPosition);
    }

    public override bool Equals(object obj)
    {
      return base.Equals(obj);
    }

    public override string GenerateNextSequenceValueOperation(string name, string schema)
    {
      return base.GenerateNextSequenceValueOperation(name, schema);
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }

    public override string ToString()
    {
      return base.ToString();
    }

    protected override void AppendDeleteCommand(StringBuilder commandStringBuilder, string name, string schema, IReadOnlyList<ColumnModification> conditionOperations)
    {
      base.AppendDeleteCommand(commandStringBuilder, name, schema, conditionOperations);
    }

    protected override void AppendDeleteCommandHeader(StringBuilder commandStringBuilder, string name, string schema)
    {
      base.AppendDeleteCommandHeader(commandStringBuilder, name, schema);
    }

    protected override void AppendFromClause(StringBuilder commandStringBuilder, string name, string schema)
    {
      base.AppendFromClause(commandStringBuilder, name, schema);
    }

    protected override void AppendIdentityWhereCondition([NotNull] StringBuilder commandStringBuilder, [NotNull] ColumnModification columnModification)
    {
      throw new System.NotImplementedException();
    }

    protected override void AppendInsertCommand(StringBuilder commandStringBuilder, string name, string schema, IReadOnlyList<ColumnModification> writeOperations)
    {
      base.AppendInsertCommand(commandStringBuilder, name, schema, writeOperations);
    }

    protected override void AppendInsertCommandHeader(StringBuilder commandStringBuilder, string name, string schema, IReadOnlyList<ColumnModification> operations)
    {
      base.AppendInsertCommandHeader(commandStringBuilder, name, schema, operations);
    }

    protected override void AppendRowsAffectedWhereCondition([NotNull] StringBuilder commandStringBuilder, int expectedRowsAffected)
    {
      throw new System.NotImplementedException();
    }

    protected override ResultSetMapping AppendSelectAffectedCommand(StringBuilder commandStringBuilder, string name, string schema, IReadOnlyList<ColumnModification> readOperations, IReadOnlyList<ColumnModification> conditionOperations, int commandPosition)
    {
      return base.AppendSelectAffectedCommand(commandStringBuilder, name, schema, readOperations, conditionOperations, commandPosition);
    }

    protected override ResultSetMapping AppendSelectAffectedCountCommand(StringBuilder commandStringBuilder, string name, string schema, int commandPosition)
    {
      return base.AppendSelectAffectedCountCommand(commandStringBuilder, name, schema, commandPosition);
    }

    protected override void AppendSelectCommandHeader(StringBuilder commandStringBuilder, IReadOnlyList<ColumnModification> operations)
    {
      base.AppendSelectCommandHeader(commandStringBuilder, operations);
    }

    protected override void AppendUpdateCommand(StringBuilder commandStringBuilder, string name, string schema, IReadOnlyList<ColumnModification> writeOperations, IReadOnlyList<ColumnModification> conditionOperations)
    {
      base.AppendUpdateCommand(commandStringBuilder, name, schema, writeOperations, conditionOperations);
    }

    protected override void AppendUpdateCommandHeader(StringBuilder commandStringBuilder, string name, string schema, IReadOnlyList<ColumnModification> operations)
    {
      base.AppendUpdateCommandHeader(commandStringBuilder, name, schema, operations);
    }

    protected override void AppendValues(StringBuilder commandStringBuilder, IReadOnlyList<ColumnModification> operations)
    {
      base.AppendValues(commandStringBuilder, operations);
    }

    protected override void AppendValuesHeader(StringBuilder commandStringBuilder, IReadOnlyList<ColumnModification> operations)
    {
      base.AppendValuesHeader(commandStringBuilder, operations);
    }

    protected override void AppendWhereAffectedClause(StringBuilder commandStringBuilder, IReadOnlyList<ColumnModification> operations)
    {
      base.AppendWhereAffectedClause(commandStringBuilder, operations);
    }

    protected override void AppendWhereClause(StringBuilder commandStringBuilder, IReadOnlyList<ColumnModification> operations)
    {
      base.AppendWhereClause(commandStringBuilder, operations);
    }

    protected override void AppendWhereCondition(StringBuilder commandStringBuilder, ColumnModification columnModification, bool useOriginalValue)
    {
      base.AppendWhereCondition(commandStringBuilder, columnModification, useOriginalValue);
    }
  }
}
