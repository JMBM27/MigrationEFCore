# This is an example project to create Migrations and Seeds With ASP.NET Core 6 API

> This project was made to learn the goods practices about make database migrations using Entity Framework Core with the code first aproach also includes seeders to create defaults values into the database, repository pattern and the Clean Architecture.


# Structure folder (Clean architecture)
Each project has clear responsibilities, the UI Layer should interact with the ApplicationCore and the the ApplicationCore with the Insfrastructure layer.

    1. ApplicationCore
        This layer hold the business layer (entities, services, interfaces, dtos and others).

    2. Infastructure
        This layer is includes the data access implementations (database context, migrations, repositories and others).

    3. UI Layer
        This layer is the entry point of the application includes (controllers, filters, middlewares, views, views models and others)



# Steps before run the migrations command
1. Need select to default project of the startup project in this case is MigrationsAndSeeds project.
2. If you're using the Nugget Console need to select the project where is located thee Database Context in this case is the Infrastructure project.
3. Save in the appsettings.json the database connection string
    >"ConnectionStrings": {
        "MigrationAndSeedsConnection": "Server=XXXXXXX;Database=XXXXX;Integrated Security=true;"
    },


# Migration with the .NET Core CLI
    dotnet ef migrations add CreateTables -v -p Infrastructure/Infrastructure.csproj -s MigrationAndSeeds/MigrationAndSeeds.csproj
    
    -v (Show verbose output)
    -p (Relative path to the project folder who has the database context)
    -s (Relative path to the startup project)
    
Run the command and it will create in the Infrastructure project and inside the Migrations folder two files

1.  A Snapshot of the currently context state of the model
2.  The migration file which includes all the methods of the migration

After created those two files everything is setup to run the update command and will save the changes into database

>dotnet ef database update  -v -p Infrastructure/Infrastructure.csproj -s MigrationAndSeeds/MigrationAndSeeds.csproj