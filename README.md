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
