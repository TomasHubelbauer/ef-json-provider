# EF Core JSON Provider

I'm planning on building an Entity Framework Core database provider backed by
JSON files. There are no good up-to-date resources on how to build such a
provider, so I'm going to use the Pomelo provider for MySQL to trace what it
does and replicate that in my own provider, which will not talk to a database,
but will read from and write to JSON files instead.

## To-Do

### Build a project which uses the Pomelo provider from the submodule

`Pomelo.EntityFrameworkCore.MySql\artifacts\bin\EFCore.MySql\Debug\netstandard2.0\Pomelo.EntityFrameworkCore.MySql.dll`

Make changes to the Pomelo provider and restart the demo app to pick up the new
DLL.

### Run MySQL in WSB or WSL and connect to it

Isolated so that I can easily delete it later on without it dirtying up my own
computer.

### Trace out all the calls to the Pomelo provider EF Core makes

Do this for the initialization routine, the initial migration, classic CRUD
operations etc. Get the infrastructure in place and make it easy to map new
scenarios.

### Replicate the Pomelo provider in my own codebase and use JSON files instead
