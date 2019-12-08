# EF Core JSON Provider

I'm planning on building an Entity Framework Core database provider backed by
JSON files. There are no good up-to-date resources on how to build such a
provider, so I'm going to use the Pomelo provider for MySQL to trace what it
does and replicate that in my own provider, which will not talk to a database,
but will read from and write to JSON files instead.

## Development

- Run MySQL
- Open Pomelo in VS - make changes and rebuild each time
- `cd src` and `dotnet run` - depends on the built DLL from Pomelo

## Findings

The entry point is for the user to configure the provider in some way. There are
multiple ways to do this, in this case, a `OnConfiguring` override on the
`DbContext` (`AppDbContext`) class is used. The `UseX` call comes from the
provider library and is an entry point to it.

Nothing will get called by EF Core until we do some EF operation. The first op
we have here is a call to `EnsureDeletedAsync` followed by `EnsureCreatedAsync`
to reset the database.

`OnConfiguring` is called immediately after calling any EF functionality as per
the above. In there, the `DbContext` gets initialized and the `UseX` provider
method called.

The provider registers itself by calling
`DbContextOptionsBuilder.AddOrUpdateExtension` passing in an instance of its own
`RelationalOptionsExtension` implementation.

On it, EF will access its `Info` property first. An implementation of
`RelationalExtensionInfo` is to be returned.

`GetServiceProviderHashCode` is accessed next, where it should suffice to return
the base implementation as long as the `RelationalOptionsExtension` override
doesn't have any extra configuration properties of its own.

`PopulateDebugInfo` is called next and then `ApplyServices`. I don't think it is
neccessary to add anything to the dictionary passed to `PopulateDebugInfo`.

`ApplyServices` is being passed an instance of `IServiceCollection` where we can
register our provider's own implementations of the services that EF will request
using the .NET Core DI mechanism.

After calling `ApplyServices`, EF Core will once again return to the extension
and read `IsDatabaseProvider`, where we seem to have to return true to let EF
know to treat this extension as one such.

After registering the services, they get pulled in this order:

- `IDatabaseProvider`
- `LoggingDefinitions`
- `IRelationalConnection`
- `IRelationalTypeMappingSource`
- `ISqlGenerationHelper`
- `IModificationCommandBatchFactory`

An empty implementation of these is the bare minimum that needs to be provided
before we get rid of errors to the tune of failing to pull a DI service.

After this point, the application will run, but will fail saying it is unable to
map model's properties.

To fix this, it seems it is necessary to implement `ISingletonOptions`. If it is
implemented, EF Core will pull this service, instantiate it and call its
`Initialize` method, then its `Validate` method. I'm not sure what these do and
maybe it is even possible to skip them or the whole service?

The key to the propert mapping problem seems to be the
`RelationalTypeMappingSource` service. It has several ovverides, which get
called in this order:

- `CoreTypeMapping FindMapping(MemberInfo member)`
- `RelationalTypeMapping FindMapping(in RelationalTypeMappingInfo mappingInfo)`

Implementing the latter to return `IntTypeMapping` and `StringTypeMapping` to
cover the most basic combo of ID+Name entity properties allows us to move on to
EF consuming those and then calling the remaining overrides in this order:

- `CoreTypeMapping FindMapping(IProperty property)`
- `string ParseStoreTypeName(string storeTypeName, out bool? unicode, out int? size, out int? precision, out int? scale)`

The others seemingly left uncalled until on. At this point, a value cannot be
null - parameter `relationalConnection` to
`Microsoft.EntityFrameworkCore.Query.RelationalQueryContextDependencies..ctor`
exception is being thrown.

## To-Do

### Trace out more of the calls to the Pomelo provider EF Core makes

### Replicate the Pomelo provider in my own codebase and use JSON files instead

### Figure out how to build and link EF Core from the submodule

### Instrument the source-built EF Core dependency as well as Pomelo

See the other side of the coin when it comes to how Pomelo and my provider are
called, maybe trace the SQL Server and in memory providers as well to capture
the differences between relational and non-relational providers.
