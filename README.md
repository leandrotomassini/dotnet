# .NET Projects Repository

A personal repository for .NET projects.

Signature: ltomassini

---

## Projects

This repository contains the following projects:

1.  **`ApiEcommerce`**: A RESTful API for an e-commerce platform using ASP.NET Core 8.
2.  **`CsBases`**: A project with C# examples covering fundamental concepts.

---

## 1. ApiEcommerce

This is the backend for an e-commerce application. It handles products, categories, and users.

### Technologies Used

*   .NET 8 / ASP.NET Core 8
*   Entity Framework Core 8
*   SQL Server
*   AutoMapper
*   BCrypt.Net for password hashing
*   Docker

### API Endpoints

The API provides CRUD operations for products and categories. You can explore and test the endpoints using the Swagger UI at `/swagger`.

**Product Endpoints:**
*   `GET /api/Products`
*   `GET /api/Products/{productId}`
*   `POST /api/Products`
*   `PUT /api/Products/{productId}`
*   `DELETE /api/Products/{productId}`

**Category Endpoints:**
*   `GET /api/Categories`
*   `GET /api/Categories/{id}`
*   `POST /api/Categories`
*   `PATCH /api/Categories/{id}`
*   `DELETE /api/Categories/{id}`

### How to Run

1.  Configure the database connection in `ApiEcommerce/ApiEcommerce/appsettings.json`.
2.  Apply Entity Framework migrations:
    ```bash
    dotnet ef database update --project ApiEcommerce/ApiEcommerce
    ```
3.  Run the application:
    ```bash
    dotnet run --project ApiEcommerce/ApiEcommerce
    ```

---

## 2. CsBases

This project contains examples of C# features and design patterns.

### Topics

*   Data Types
*   Inheritance
*   Adapter Pattern
*   Dependency Injection
*   Async Methods
*   Attributes

### How to Run
```bash
dotnet run --project CsBases
```
