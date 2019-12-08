using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace src
{
  class Program
  {
    static async Task Main()
    {
      if (false)
      {
        using (var appDbContext = new AppDbContext(true))
        {
          Console.WriteLine("EnsureDeletedAsync");
          await appDbContext.Database.EnsureDeletedAsync();
          Console.WriteLine("EnsureCreatedAsync");
          await appDbContext.Database.EnsureCreatedAsync();
          Console.WriteLine("AddAsync");
          await appDbContext.Items.AddAsync(new Item { Name = "Test" });
          Console.WriteLine("SaveChangesAsync");
          await appDbContext.SaveChangesAsync();
          Console.WriteLine("ToArray");
          var items = appDbContext.Items.ToArray();
          if (items.Length != 1 || items[0].Name != "Test")
          {
            throw new Exception("Uh-oh.");
          }
        }
      }
      else
      {
        using (var appDbContext = new AppDbContext())
        {
          Console.WriteLine("EnsureDeletedAsync");
          await appDbContext.Database.EnsureDeletedAsync();
          Console.WriteLine("EnsureCreatedAsync");
          await appDbContext.Database.EnsureCreatedAsync();
          Console.WriteLine("AddAsync");
          await appDbContext.Items.AddAsync(new Item { Name = "Test" });
          Console.WriteLine("SaveChangesAsync");
          await appDbContext.SaveChangesAsync();
          Console.WriteLine("ToArray");
          var items = appDbContext.Items.ToArray();
          if (items.Length != 1 || items[0].Name != "Test")
          {
            throw new Exception("Uh-oh.");
          }
        }
      }
    }
  }

  public class AppDbContext : DbContext
  {
    private readonly bool useJson = false;

    public AppDbContext(bool useJson = false)
    {
      this.useJson = useJson;
    }

    public DbSet<Item> Items { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (useJson)
      {
        optionsBuilder.UseJson();
      }
      else
      {
        optionsBuilder.UseMySql($@"Server=localhost;Database=ef;User=root;Password=password");
      }

      optionsBuilder.EnableDetailedErrors();
      optionsBuilder.EnableSensitiveDataLogging();
    }

    // TODO: Log OnModelCreating
  }

  public sealed class Item
  {
    public int Id { get; set; }
    public string Name { get; set; }
  }
}
