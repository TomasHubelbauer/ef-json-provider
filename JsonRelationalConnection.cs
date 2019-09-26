using System;
using System.Data;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace ef_core_json_provider
{
  internal class JsonRelationalConnection : RelationalConnection, IJsonRelationalConnection
  {
    public JsonRelationalConnection([NotNull] RelationalConnectionDependencies dependencies) : base(dependencies)
    {
    }

    public override Guid ConnectionId => base.ConnectionId;

    public override DbContext Context => base.Context;

    public override string ConnectionString => base.ConnectionString;

    public override DbConnection DbConnection => base.DbConnection;

    public override IDbContextTransaction CurrentTransaction { get => base.CurrentTransaction; protected set => base.CurrentTransaction = value; }
    public override Transaction EnlistedTransaction { get => base.EnlistedTransaction; protected set => base.EnlistedTransaction = value; }
    public override int? CommandTimeout { get => base.CommandTimeout; set => base.CommandTimeout = value; }

    public override bool IsMultipleActiveResultSetsEnabled => base.IsMultipleActiveResultSetsEnabled;

    public override SemaphoreSlim Semaphore => base.Semaphore;

    protected override RelationalConnectionDependencies Dependencies => base.Dependencies;

    protected override bool SupportsAmbientTransactions => base.SupportsAmbientTransactions;

    public override IDbContextTransaction BeginTransaction()
    {
      return base.BeginTransaction();
    }

    public override IDbContextTransaction BeginTransaction(System.Data.IsolationLevel isolationLevel)
    {
      return base.BeginTransaction(isolationLevel);
    }

    public override Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default)
    {
      return base.BeginTransactionAsync(cancellationToken);
    }

    public override Task<IDbContextTransaction> BeginTransactionAsync(System.Data.IsolationLevel isolationLevel, CancellationToken cancellationToken = default)
    {
      return base.BeginTransactionAsync(isolationLevel, cancellationToken);
    }

    public override bool Close()
    {
      return base.Close();
    }

    public override Task<bool> CloseAsync()
    {
      return base.CloseAsync();
    }

    public override void CommitTransaction()
    {
      base.CommitTransaction();
    }

    public override void Dispose()
    {
      base.Dispose();
    }

    public override ValueTask DisposeAsync()
    {
      return base.DisposeAsync();
    }

    public override void EnlistTransaction(Transaction transaction)
    {
      base.EnlistTransaction(transaction);
    }

    public override bool Equals(object obj)
    {
      return base.Equals(obj);
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }

    public override bool Open(bool errorsExpected = false)
    {
      return base.Open(errorsExpected);
    }

    public override Task<bool> OpenAsync(CancellationToken cancellationToken, bool errorsExpected = false)
    {
      return base.OpenAsync(cancellationToken, errorsExpected);
    }

    public override void RollbackTransaction()
    {
      base.RollbackTransaction();
    }

    public override string ToString()
    {
      return base.ToString();
    }

    public override IDbContextTransaction UseTransaction(DbTransaction transaction)
    {
      return base.UseTransaction(transaction);
    }

    public override Task<IDbContextTransaction> UseTransactionAsync(DbTransaction transaction, CancellationToken cancellationToken = default)
    {
      return base.UseTransactionAsync(transaction, cancellationToken);
    }

    protected override DbConnection CreateDbConnection()
    {
      throw new System.NotImplementedException();
    }
  }
}
