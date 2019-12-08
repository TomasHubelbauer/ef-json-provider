using System;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Update;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;

public static class JsonServiceCollectionExtensions
{
  public static IServiceCollection AddEntityFrameworkJson(this IServiceCollection serviceCollection)
  {
    var builder = new EntityFrameworkRelationalServicesBuilder(serviceCollection)
    .TryAdd<IDatabaseProvider, DatabaseProvider<JsonOptionsExtension>>()
    .TryAdd<LoggingDefinitions, JsonLoggingDefinitions>()
    .TryAdd<IRelationalConnection, JsonRelationalConnection>()
    .TryAdd<IRelationalTypeMappingSource, JsonTypeMappingSource>()
    .TryAdd<ISqlGenerationHelper, JsonSqlGenerationHelper>()
    .TryAdd<IModificationCommandBatchFactory, JsonModificationCommandBatchFactory>()
    .TryAdd<ISingletonOptions, JsonOptions>()
    .TryAdd<IModelValidator, JsonModelValidator>()
    .TryAdd<IProviderConventionSetBuilder, JsonConventionSetBuilder>()
    .TryAdd<IRelationalDatabaseCreator, JsonDatabaseCreator>()
    // .TryAdd<IRelationalTransactionFactory, MySqlRelationalTransactionFactory>()
    // .TryAdd<IMigrationsAnnotationProvider, MySqlMigrationsAnnotationProvider>()
    // .TryAdd<IProviderConventionSetBuilder, MySqlConventionSetBuilder>()
    // .TryAdd<IModelValidator, MySqlModelValidator>()
    // .TryAdd<IUpdateSqlGenerator, MySqlUpdateSqlGenerator>()
    // .TryAdd<IValueGeneratorSelector, MySqlValueGeneratorSelector>()
    // .TryAdd<IMigrationsSqlGenerator, MySqlMigrationsSqlGenerator>()
    // 
    // .TryAdd<IHistoryRepository, MySqlHistoryRepository>()
    // .TryAdd<ICompiledQueryCacheKeyGenerator, MySqlCompiledQueryCacheKeyGenerator>()
    // .TryAdd<IExecutionStrategyFactory, MySqlExecutionStrategyFactory>()
    // .TryAdd<IMigrator, MySqlMigrator>()
    // .TryAdd<IMethodCallTranslatorProvider, MySqlMethodCallTranslatorProvider>()
    // .TryAdd<IMemberTranslatorProvider, MySqlMemberTranslatorProvider>()
    // .TryAdd<IQuerySqlGeneratorFactory, MySqlQuerySqlGeneratorFactory>()
    // .TryAdd<ISqlExpressionFactory, MySqlSqlExpressionFactory>()
    // .TryAdd<IRelationalSqlTranslatingExpressionVisitorFactory, MySqlSqlTranslatingExpressionVisitorFactory>()
    // .TryAdd<IQueryTranslationPostprocessorFactory, MySqlQueryTranslationPostprocessorFactory>()
    // .TryAdd<IMigrationsModelDiffer, MySqlMigrationsModelDiffer>()
    // .TryAddProviderSpecificServices(m => m
    //     .TryAddSingleton<IMySqlOptions, MySqlOptions>()
    //     .TryAddScoped<IMySqlRelationalConnection, MySqlRelationalConnection>()
    //     .TryAddScoped<IMySqlUpdateSqlGenerator, MySqlUpdateSqlGenerator>())
    ;

    builder.TryAddCoreServices();

    return serviceCollection;
  }
}
