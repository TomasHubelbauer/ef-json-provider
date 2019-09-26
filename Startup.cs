using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ef_core_json_provider
{
  public class Startup
  {
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddDbContext<AppDbContext>(options =>
      {
        Console.WriteLine("AddDbContext options");
        options.UseJson();
      });
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env, AppDbContext db)
    {
      // Reset the database
      db.Database.EnsureDeleted();
      db.Database.EnsureCreated();

      // TODO: Replace the reset with migrations

      db.Things.Add(new Thing { Name = "Something" });
      db.SaveChanges();
    }
  }

  public class AppDbContext : DbContext
  {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Thing> Things { get; set; }
  }

  public class Thing
  {
    public int Id { get; set; }
    public string Name { get; set; }
  }
}
