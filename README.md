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

### Project Structure
*   `Controllers/`: Contains the API endpoints for `Products` and `Categories`.
*   `Data/`: Includes the `ApplicationDbContext` for database interaction.
*   `Models/`: Defines the core domain entities (`Product`, `Category`) and Data Transfer Objects (DTOs).
*   `Repository/`: Implements the repository pattern to decouple the business logic from the data access layer.
*   `Mapping/`: Contains AutoMapper profiles for DTO transformations.
*   `Migrations/`: EF Core database migration files.

### API Endpoints

The API exposes standard CRUD endpoints for `Products` and `Categories`. These can be explored in detail via the Swagger UI, typically available at `/swagger` when the application is running.

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
2.  Configure the database connection string in `ApiEcommerce/ApiEcommerce/appsettings.json`.
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
*   **`07-Metodos-Asyncronos`**: Working with `async` and `await` for asynchronous operations.
*   **`08-Atributos`**: Creating and using custom attributes.

### How to Use
Each folder is a self-contained example. You can explore the code in each directory to understand the specific concept. The `Program.cs` in the root of `CsBases` may contain entry points to run or test some of these examples.

---
*ltomassini*