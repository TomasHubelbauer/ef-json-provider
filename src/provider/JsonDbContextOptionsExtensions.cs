using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

public static class JsonDbContextOptionsExtensions
{
  public static DbContextOptionsBuilder UseJson(this DbContextOptionsBuilder optionsBuilder)
  {
    var extension = new JsonOptionsExtension().WithConnectionString("json");
    ((IDbContextOptionsBuilderInfrastructure)optionsBuilder).AddOrUpdateExtension(extension);
    return optionsBuilder;
  }
}
