# EF Core

## CLI

### migration
dotnet ef --startup-project **startup.csproj** migrations add "**name**" --project **migration.csproj**

### update
dotnet ef --startup-project **startup.csproj** database update "**name**" --project **migration.csproj**

    migration add
    database update

``` csharp
dotnet ef --startup-project .\src\Presentation\Server\ migrations add "context" --project .\src\Infrastructure\ --output-dir "Persistence/Migrations"
```

``` csharp
dotnet ef --startup-project .\src\Presentation\Server\ database update "context" --project .\src\Infrastructure\
```

### UserDbContext
``` csharp
dotnet ef --startup-project .\src\Presentation\Server\ migrations add "init_identity" --project .\src\Infrastructure\ --context UserDbContext --output-dir "Persistence/Migrations"

dotnet ef --startup-project .\src\Presentation\Server\ database update "init_identity" --project .\src\Infrastructure\ --context UserDbContext
```

### ApplicationDbContext
``` csharp
dotnet ef --startup-project .\src\Presentation\Server\ migrations add "initApp" --project .\src\Infrastructure\ --context ApplicationDbContext --output-dir "Persistence/Migrations"

dotnet ef --startup-project .\src\Presentation\Server\ database update "initApp" --project .\src\Infrastructure\ --context ApplicationDbContext
```



## DbContext

ApplicationDbContext
- extend:
    - DbContext
    - IApplicationDbContext, an Application layer abstraction used to abstract DbSet.

- depend:
    - Configuration (IEntityTypeConfiguration), in override OnCreateModel. This prevent the use of data annotation within the enitity class itself.

