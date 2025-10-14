# .NET Projects Repository

A personal repository for .NET projects by ltomassini.

## Projects Overview

This repository is organized into two main projects:

1.  **`ApiEcommerce`**: A comprehensive RESTful API for an e-commerce platform built with ASP.NET Core 8.
2.  **`CsBases`**: A collection of C# examples covering fundamental concepts and design patterns.

---

## 1. ApiEcommerce

This project provides the backend services for a typical e-commerce application.

### Core Technologies
*   **.NET 8** / **ASP.NET Core 8**
*   **Entity Framework Core 8**: For data access and object-relational mapping (ORM).
*   **SQL Server**: As the database provider for EF Core.
*   **AutoMapper**: For object-to-object mapping (e.g., entities to DTOs).
*   **Swashbuckle (Swagger)**: For API documentation and testing.
*   **Docker**: For containerization and simplified deployment.

### API Endpoints

The API features a full set of CRUD operations for `Categories`. The `Products` controller is a work in progress. All endpoints can be tested interactively via the Swagger UI at `/swagger`.

#### Category Endpoints
*   `GET /api/Categories` - Retrieves a list of all categories.
*   `GET /api/Categories/{id}` - Retrieves a specific category by its ID.
*   `POST /api/Categories` - Creates a new category.
*   `PATCH /api/Categories/{id}` - Updates an existing category.
*   `DELETE /api/Categories/{id}` - Deletes a category.

### Configuration

The database connection string must be configured in `ApiEcommerce/ApiEcommerce/appsettings.json`. The application is configured to use a SQL Server instance.

**Example `appsettings.json`:**
```json
{
  "ConnectionStrings": {
    "ConexionSql": "Server=localhost;Database=ApiEcommerceNET8;User ID=SA;Password=MyStrongPass123;TrustServerCertificate=true;MultipleActiveResultSets=true"
  }
}
```

### Data Transfer Objects (DTOs)

The API uses DTOs to shape the data sent to and from clients. This decouples the API's public contract from the internal database entities.

**Example `CategoryDto.cs`:**
```csharp
using System;

namespace ApiEcommerce.Models.Dtos;

public class CategoryDto
{
  public int Id { get; set; }

  public string name { get; set; } = string.Empty;

  public DateTime CreationDate { get; set; }
}
```

### Getting Started

#### Prerequisites
*   .NET 8 SDK
*   Docker Desktop (optional, for containerized approach)
*   A SQL Server instance (if not using Docker)

#### Running with Docker
The easiest way to get the application and a database running is with Docker Compose.

```bash
# From the ApiEcommerce directory
docker-compose up --build -d
```

#### Running Locally
1.  Ensure you have a SQL Server instance accessible.
2.  Update the `ConexionSql` connection string in `ApiEcommerce/ApiEcommerce/appsettings.json`.
3.  Apply the database migrations to create the schema.
    ```bash
    # Navigate to the directory containing the .sln file: ApiEcommerce/
    dotnet ef database update --project ApiEcommerce/ApiEcommerce
    ```
4.  Run the application.
    ```bash
    # Navigate to ApiEcommerce/ApiEcommerce
    dotnet run
    ```
The API will be available at the URLs specified in `Properties/launchSettings.json` (e.g., `https://localhost:7181`).

---

## 2. CsBases

A curated collection of code snippets and small projects demonstrating key C# and .NET concepts. This project is intended for educational and reference purposes.

### Topics Covered
*   **`02-Tipos-Basicos`**: Overview of fundamental C# data types.
*   **`04-Herencia`**: Example of class inheritance and interfaces.
*   **`05-Patron-adaptador`**: Implementation of the Adapter design pattern.
*   **`06-Inyeccion-de-dependencias`**: Demonstration of Dependency Injection (DI).
*   **`07-Metodos-Asyncronos`**: Working with `async` and `await` for asynchronous operations..
*   **`08-Atributos`**: Creating and using custom attributes.

### How to Use
Each folder contains a self-contained example. To run the project and see potential output from the examples, navigate to the `CsBases` directory and use the .NET CLI.

```bash
# Navigate to the CsBases directory
dotnet run
```

---
*ltomassini*
