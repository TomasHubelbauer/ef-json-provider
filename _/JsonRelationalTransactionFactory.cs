using System;
using System.Data.Common;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Storage;

namespace ef_core_json_provider
{
  public class JsonRelationalTransactionFactory : RelationalTransactionFactory
  {
    public JsonRelationalTransactionFactory([NotNullAttribute] RelationalTransactionFactoryDependencies dependencies) : base(dependencies)
    {
    }

    protected override RelationalTransactionFactoryDependencies Dependencies => base.Dependencies;

    public override RelationalTransaction Create(IRelationalConnection connection, DbTransaction transaction, Guid transactionId, IDiagnosticsLogger<DbLoggerCategory.Database.Transaction> logger, bool transactionOwned)
    {
      return base.Create(connection, transaction, transactionId, logger, transactionOwned);
    }

    public override bool Equals(object obj)
    {
      return base.Equals(obj);
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }

    public override string ToString()
    {
      return base.ToString();
    }
  }
}
