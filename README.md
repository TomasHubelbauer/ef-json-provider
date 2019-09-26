# EF Core JSON Database Provider

This might be a cool experiment.

The rational is that when looking for an in-process provider (because for many,
many small projects, the hassle of managing a database server alongside of an
application server is just unnecessary), we only find SQLite and in-memory.

In-memory does not act as a relational database, which I don't like, and it
doesn't allow numerical IDs which is fine by me, but still, weird limitation.

The SQLite EF Core provider does not support many migration change types and
the table-rebuilding mechanism which can be used as a workaround has not yet
been adopted by the EF Core team.

There are old docs for this:
https://docs.microsoft.com/en-us/ef/core/providers/writing-a-provider

And a log of things which might affect these docs:
https://docs.microsoft.com/en-us/ef/core/providers/provider-log

For the "test harness" (really, a demo app), I'll use an empty web application:
`dotnet new web`.

I was gonna use a console application, but I want the DI setup to be done
for me based on the template.

`dotnet add package Microsoft.EntityFrameworkCore`

For relational provider abstract classes we need also

`dotnet add package Microsoft.EntityFrameworkCore.Relational`

I'm ripping off the Firebase provider developed by Jiri Cincura,
starting from `UseFirebase` on.

`dotnet package add JetBrains.Annotations`

The order in which things are called:

- Startup - AddDbContext options => callback
- options.UseJson()
- `((IDbContextOptionsBuilderInfrastructure)optionsBuilder).AddOrUpdateExtension(new JsonOptionsExtension())`
- `JsonOptionsExtension.ApplyServices`
- `services.AddEntityFrameworkJson`
- `Microsoft.EntityFrameworkCore.Internal.ISingletonOptionsInitializer` is resolved in DI
  - `JsonSingletonOptionsInitializer` constructor
  - `JsonSingletonOptionsInitializer.EnsureInitialized`
  - You can use `SingletonOptionsInitializer` from EF Core
- `Microsoft.EntityFrameworkCore.Internal.IDbSetInitializer` is resolved in DI
  - You can use `DbSetInitializer` from EF Core
- IDbSetFinder, DbSetFinder initialized and available from EF Core
- Microsoft.EntityFrameworkCore.Internal.IDbSetSource same
- At this point I'm getting a NPE

Maybe it will be better to try and get EF Core to run, then instrument the in memory provider
and try to clone that.
