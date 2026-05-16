# CrudMvcApp_DockerTest

A simple ASP.NET Core MVC CRUD application using:

- ASP.NET Core MVC
- Entity Framework Core
- PostgreSQL
- Docker & Docker Compose

---

# 📦 Required Packages

Install the following NuGet packages:

```bash
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
```

---

# 🛠 EF Core Migration Setup

Install Entity Framework CLI Tool:

```bash
dotnet tool install --global dotnet-ef
```

Create Migration:

```bash
dotnet ef migrations add InitialCreate
```

Update Database:

```bash
dotnet ef database update
```

---

# 🐳 Docker Setup

## Step 1 - Create Dockerfile

Create a `Dockerfile` in the project root.

---

## Step 2 - Create docker-compose.yml

Create a `docker-compose.yml` file with:

- ASP.NET Core application container
- PostgreSQL database container
- Database connection configuration

---

## Step 3 - Add Auto Migration in Program.cs

Add auto migration code before `app.Run();`

```csharp
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();

    db.Database.Migrate();
}
```

This automatically creates database tables when the container starts.

---

# 🚀 Run Docker Project

Open terminal and run:

Stop existing containers:

```bash
docker compose down
```

Build and start containers:

```bash
docker compose up --build
```

---

# 🌐 Application URL

```txt
http://localhost:5001
```

---

# 🗄 Database Configuration

Connection String Example:

```json
"ConnectionStrings": {
  "DefaultConnection": "Host=db;Port=5432;Database=cruddb;Username=postgres;Password=system"
}
```

> Use `Host=db` because Docker containers communicate using service names.

---

# 📚 Features

- CRUD Operations
- PostgreSQL Integration
- Entity Framework Core
- Dockerized Application
- Auto Database Migration
- Container-to-Container Communication
