# .NET Projects Repository

A personal repository for .NET projects by ltomassini.

## Projects Overview

This repository is organized into two main projects:

1.  **`ApiEcommerce`**: A comprehensive RESTful API for an e-commerce platform built with ASP.NET Core 8.
2.  **`CsBases`**: A collection of C# examples covering fundamental concepts and design patterns.

---

## 1. ApiEcommerce

This project provides the backend services for a typical e-commerce application, featuring product management, categories, and user registration.

### Core Technologies
*   **.NET 8** / **ASP.NET Core 8**
*   **Entity Framework Core 8**: For data access and object-relational mapping (ORM).
*   **SQL Server**: As the database provider for EF Core.
*   **AutoMapper**: For object-to-object mapping (e.g., entities to DTOs).
*   **Swashbuckle (Swagger)**: For API documentation and testing.
*   **BCrypt.Net**: For password hashing and security.
*   **Docker**: For containerization and simplified deployment.

### API Endpoints

The API features a full set of CRUD operations for `Products` and `Categories`. All endpoints can be tested interactively via the Swagger UI at `/swagger`.

#### Product Endpoints
*   `GET /api/Products`: Retrieves a list of all products.
*   `GET /api/Products/{productId}`: Retrieves a specific product by its ID.
*   `POST /api/Products`: Creates a new product.
*   `PUT /api/Products/{productId}`: Updates an existing product.
*   `DELETE /api/Products/{productId}`: Deletes a product.
*   `GET /api/Products/searchProductByCategory/{categoryId}`: Gets all products for a given category.
*   `GET /api/Products/searchProductByNameDescription/{searchTerm}`: Searches for products by name or description.
*   `PATCH /api/Products/buyProduct/{name}/{quantity}`: Simulates buying a product, reducing its stock.

#### Category Endpoints
*   `GET /api/Categories`: Retrieves a list of all categories.
*   `GET /api/Categories/{id}`: Retrieves a specific category by its ID.
*   `POST /api/Categories`: Creates a new category.
*   `PATCH /api/Categories/{id}`: Updates an existing category.
*   `DELETE /api/Categories/{id}`: Deletes a category.

#### User Management (Work in Progress)
The underlying logic and repository for user registration (`Register`, `Login`, password hashing) have been implemented. However, these features are not yet exposed via API controllers.

### Configuration

The database connection string must be configured in `ApiEcommerce/ApiEcommerce/appsettings.json`.

**Example `appsettings.json`:**
```json
{
  "ConnectionStrings": {
    "ConexionSql": "Server=localhost;Database=ApiEcommerceNET8;User ID=SA;Password=MyStrongPass123;TrustServerCertificate=true;MultipleActiveResultSets=true"
  }
}
```

### Getting Started

#### Prerequisites
*   .NET 8 SDK
*   Docker Desktop (optional)
*   A SQL Server instance (if not using Docker)

#### Running Locally
1.  Ensure you have a SQL Server instance accessible.
2.  Update the `ConexionSql` connection string in `ApiEcommerce/ApiEcommerce/appsettings.json`.
3.  Apply the database migrations to create/update the schema.
    ```bash
    # Navigate to the directory containing the .sln file: ApiEcommerce/
    dotnet ef database update --project ApiEcommerce/ApiEcommerce
    ```
4.  Run the application.
    ```bash
    # Navigate to ApiEcommerce/ApiEcommerce
    dotnet run
    ```

---

## 2. CsBases

A curated collection of code snippets demonstrating key C# concepts.

### Topics Covered
*   `02-Tipos-Basicos`: Fundamental C# data types.
*   `04-Herencia`: Class inheritance and interfaces.
*   `05-Patron-adaptador`: Adapter design pattern.
*   `06-Inyeccion-de-dependencias`: Dependency Injection (DI).
*   `07-Metodos-Asyncronos`: `async` and `await`.
*   `08-Atributos`: Custom attributes.

### How to Use
```bash
# Navigate to the CsBases directory
dotnet run
```

---
*ltomassini*