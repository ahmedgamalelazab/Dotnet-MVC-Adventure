# Application Setup : 

* dotnet new globaljson --sdk-version 3.1.101 --output SportsSln/SportsStore

* dotnet new web --output SportsSln/SportsStore --framework netcoreapp3.1
 
* dotnet new sln -o SportsSln
 
* dotnet sln SportsSln add SportsSln/SportsStore

# Testing Setup : 

* dotnet new xunit -o SportsSln/SportsStore.Tests --framework netcoreapp3.1

* dotnet sln SportsSln add SportsSln/SportsStore.Tests
 
* dotnet add SportsSln/SportsStore.Tests reference SportsSln/SportsStore

# adding the moq library : 

* dotnet add SportsSln/SportsStore.Tests package Moq --version 4.13.1

# Installing the Entity Framework Core Packages : 

* dotnet add package Microsoft.EntityFrameworkCore.Design --version 3.1.1

* dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 3.1.1

* dotnet tool uninstall --global dotnet-ef

* dotnet tool install --global dotnet-ef --version 3.1.1

# Defining a connection string : 

```
"ConnectionStrings": {
 "SportsStoreConnection": "Server=(localdb)\\MSSQLLocalDB;Database=SportsStore;MultipleActiveResultSets=true"
 }
```

# how to use external tools to connect to the local db : 

* simple use the connections string as (localdb)\MSSQLLocalDB

# Ef commands : 

* dotnet-ef migrations add Initial

* dotnet-ef database update 

# force drop the database : 

* dotnet-ef database drop --force --context StoreDbContext
