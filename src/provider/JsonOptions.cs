using System;
using Microsoft.EntityFrameworkCore.Infrastructure;

public class JsonOptions : ISingletonOptions
{
  public virtual void Initialize(IDbContextOptions options)
  {
  }

  public virtual void Validate(IDbContextOptions options)
  {
  }
}
