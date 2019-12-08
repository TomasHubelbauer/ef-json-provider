using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;

public class JsonRelationalConnection : RelationalConnection
{
  public JsonRelationalConnection(RelationalConnectionDependencies dependencies) : base(dependencies)
  {
    Console.WriteLine("JsonRelationalConnection");
  }

  public override string ConnectionString
  {
    get
    {
      Console.WriteLine("TODO");
      throw new Exception();
    }
  }

  public override IDbContextTransaction BeginTransaction()
  {
    throw new Exception();
  }

  public override IDbContextTransaction BeginTransaction(System.Data.IsolationLevel isolationLevel)
  {
    throw new Exception();
  }

  public override Task<IDbContextTransaction> BeginTransactionAsync(System.Data.IsolationLevel isolationLevel, CancellationToken cancellationToken = default)
  {
    throw new Exception();
  }

  public override Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default)
  {
    throw new Exception();
  }

  public override bool Close()
  {
    throw new Exception();
  }

  public override Task<bool> CloseAsync()
  {
    throw new Exception();
  }

  public override void CommitTransaction()
  {
    throw new Exception();
  }

  // public override void Dispose()
  // {
  //   throw new Exception();
  // }

  public override ValueTask DisposeAsync()
  {
    throw new Exception();
  }

  public override void EnlistTransaction(Transaction transaction)
  {
    throw new Exception();
  }

  public override bool Open(bool errorsExpected = false)
  {
    throw new Exception();
  }

  public override Task<bool> OpenAsync(CancellationToken cancellationToken, bool errorsExpected = false)
  {
    throw new Exception();
  }

  public override void RollbackTransaction()
  {
    throw new Exception();
  }

  public override IDbContextTransaction UseTransaction(DbTransaction transaction)
  {
    throw new Exception();
  }

  public override Task<IDbContextTransaction> UseTransactionAsync(DbTransaction transaction, CancellationToken cancellationToken = default)
  {
    throw new Exception();
  }

  protected override DbConnection CreateDbConnection()
  {
    throw new Exception();
  }
}
