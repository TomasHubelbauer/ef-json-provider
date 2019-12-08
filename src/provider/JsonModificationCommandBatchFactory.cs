using Microsoft.EntityFrameworkCore.Update;
using System;

public class JsonModificationCommandBatchFactory : IModificationCommandBatchFactory
{
  public virtual ModificationCommandBatch Create()
  {
    throw new Exception();
  }
}
