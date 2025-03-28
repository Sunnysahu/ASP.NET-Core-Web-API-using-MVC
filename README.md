# README

## Install from NuGet

At the moment, we're using **.NET 8.0**, so the installed packages are version **8.0.4**:

### Required NuGet Packages:

- `Microsoft.EntityFrameworkCore.SqlServer` <button onclick="navigator.clipboard.writeText('Microsoft.EntityFrameworkCore.SqlServer')">Copy</button>
- `Microsoft.EntityFrameworkCore.Tools` <button onclick="navigator.clipboard.writeText('Microsoft.EntityFrameworkCore.Tools')">Copy</button>

## Code-First Approach

This project follows the **Code-First** approach using Entity Framework Core.

## Running SQL Commands

To execute SQL queries and apply migrations, follow these steps:

### Migration Script

#### Create a Migration Script:

```powershell
add-migration "InitialMigration"
```

<button onclick="navigator.clipboard.writeText('add-migration \"InitialMigration\"')">Copy</button>

#### Apply Migration to Database:

```powershell
update-database
```

<button onclick="navigator.clipboard.writeText('update-database')">Copy</button>

This will generate the necessary database tables and apply any pending schema changes.

---

### Notes:

- Ensure that your **connection string** in `appsettings.json` is correctly configured for SQL Server.
- Run these commands in the **Package Manager Console** in Visual Studio.
- If you encounter errors, check for pending changes in your models and ensure that the correct **database context** is set.

---

**Happy Coding! 🚀**
