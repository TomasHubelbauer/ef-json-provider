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

## To-Do

### Trace out all the calls to the Pomelo provider EF Core makes

Do this for the initialization routine, the initial migration, classic CRUD
operations etc. Get the infrastructure in place and make it easy to map new
scenarios.

### Replicate the Pomelo provider in my own codebase and use JSON files instead
