using System;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;

namespace ef_core_json_provider
{
  public static class JsonServiceCollectionExtensions
  {
    public static IServiceCollection AddEntityFrameworkJson(this IServiceCollection serviceCollection)
    {
      Console.WriteLine(nameof(JsonServiceCollectionExtensions) + '.' + nameof(AddEntityFrameworkJson));
      var builder = new EntityFrameworkRelationalServicesBuilder(serviceCollection)
        // 1.
        .TryAdd<ISingletonOptionsInitializer, SingletonOptionsInitializer>()
        // 2.
        .TryAdd<IDbSetInitializer, DbSetInitializer>()
        // 3.
        .TryAdd<IDbSetFinder, DbSetFinder>()
        // 4.
        .TryAdd<IDbSetSource, DbSetSource>()

      //.TryAdd<IDatabaseProvider, DatabaseProvider<JsonOptionsExtension>>()
      //.TryAdd<IRelationalDatabaseCreator, JsonDatabaseCreator>()
      //.TryAdd<IRelationalTypeMappingSource, JsonTypeMappingSource>()
      //.TryAdd<ISqlGenerationHelper, JsonSqlGenerationHelper>()
      //.TryAdd<IMigrationsAnnotationProvider, JsonMigrationsAnnotationProvider>()
      //.TryAdd<IConventionSetBuilder, JsonConventionSetBuilder>()
      //.TryAdd<IUpdateSqlGenerator>(p => p.GetService<IJsonUpdateSqlGenerator>())
      //.TryAdd<IModificationCommandBatchFactory, JsonModificationCommandBatchFactory>()
      //.TryAdd<IRelationalConnection>(p => p.GetService<IJsonRelationalConnection>())
      //.TryAdd<IMigrationsSqlGenerator, JsonMigrationsSqlGenerator>()
      //.TryAdd<IHistoryRepository, JsonHistoryRepository>()
      //.TryAdd<IQueryCompilationContextFactory, JsonQueryCompilationContextFactory>()
      //.TryAdd<ICompositeMethodCallTranslator, JsonCompositeMethodCallTranslator>()
      //.TryAdd<IQuerySqlGeneratorFactory, JsonQuerySqlGeneratorFactory>()
      //.TryAdd<ISingletonOptions, IJsonOptions>(p => p.GetService<IJsonOptions>())
      //.TryAddProviderSpecificServices(b =>
      //{
      //b
      //.TryAddSingleton<IJsonOptions, JsonOptions>()
      //.TryAddSingleton<IJsonMigrationSqlGeneratorBehavior, JsonMigrationSqlGeneratorBehavior>()
      //.TryAddSingleton<IJsonUpdateSqlGenerator, JsonUpdateSqlGenerator>()
      //.TryAddScoped<IJsonRelationalConnection, JsonRelationalConnection>()
      //});
      ;
      return serviceCollection;
    }
  }

}
