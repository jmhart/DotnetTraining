# Entity Framework

Entity Framework (EF) is an open-source object-relational mapping (ORM) framework for .NET. Here are the key concepts:

* **DbContext**: This is the primary class that is responsible for interacting with the database. It's a bridge between your domain or entity classes and the database.

* **DbSet**: The DbSet class represents a collection for a given type within the model. You can perform CRUD operations on a DbSet.

* **Migration**: Migrations are a way to apply incremental changes to the database to keep it in sync with the application's data model while preserving existing data in the database.

* **LINQ Queries**: Language Integrated Query (LINQ) is a powerful feature in .NET that allows you to write type-safe queries in C#. EF fully supports LINQ to Entities.

* **Change Tracking**: EF keeps track of changes that have been made to all retrieved entities during the life of a context. When SaveChanges is called, EF generates SQL statements to propagate these changes back to the database.

* **Lazy Loading**: Lazy loading is a concept where you load the data whenever it's required. EF supports lazy loading of related data.

* **Eager Loading**: Eager loading is the process whereby a query for one type of entity also loads related entities as part of the query, so that we don't need to execute a separate query for related entities.

* **Explicit Loading**: Explicit loading is a method of loading the related entities from the database at a time other than when the parent entity was initially retrieved.

* **Concurrency Control**: EF uses optimistic concurrency control to protect overwriting changes made by another user since data was fetched from the database.

* **Transactions**: EF performs automatic transaction management. It automatically opens a transaction when you call SaveChanges and commits it when the save is successful.

* **Data Seeding**: Data seeding is the process of populating a database with an initial set of data.
