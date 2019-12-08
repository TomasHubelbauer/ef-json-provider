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
    static async Task Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      using (var appDbContext = new AppDbContext())
      {
        await appDbContext.Database.EnsureDeletedAsync();
        await appDbContext.Database.EnsureCreatedAsync();
        await appDbContext.Items.AddAsync(new Item { Name = "Test" });
        await appDbContext.SaveChangesAsync();
        var items = appDbContext.Items.ToArray();
        foreach (var item in items)
        {
          Console.WriteLine(item.Id + ": " + item.Name);
        }
      }
    }
  }

  public class AppDbContext : DbContext
  {
    public DbSet<Item> Items { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseMySql($@"Server=localhost;Database=ef;User=root;Password=password");
      optionsBuilder.EnableDetailedErrors();
      optionsBuilder.EnableSensitiveDataLogging();
    }
  }

  public sealed class Item
  {
    public int Id { get; set; }
    public string Name { get; set; }
  }
}
