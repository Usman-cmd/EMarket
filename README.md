EMarket

EMarket is a full-featured N-tier architecture e-commerce web application built with ASP.NET Core.
It supports multiple user roles, a rich admin panel, and a complete tech products store.

Features
1. Multi-Tier Architecture

Presentation Layer (UI / Views)

Business Layer: Handles core application logic.

Data Access Layer: Entity Framework Core for database operations.

2. User Management & Authorization

Roles: Admin, Employee, Customer.

Authorization: Role-based access to admin panel and sensitive features.

Authentication: ASP.NET Core Identity for login and registration.

3. Admin Panel

Manage Companies: Add, edit, delete tech companies.

Manage Categories: Organize products into categories.

Manage Products: Add, edit, delete products with pricing and stock info.

View Orders and manage system users.

4. Customer Features

Browse products by category and company.

Add products to cart and place orders.

View order history.

5. Tech Products Focus

Products include electronics, gadgets, and other tech items.

Supports product details, pricing, and availability.

6. Security

Role-based authorization ensures users can only access permitted features.

Secure handling of sensitive data (passwords, Stripe keys, etc.) via appsettings.Development.json.

Technologies Used

ASP.NET Core MVC

Entity Framework Core

ASP.NET Core Identity

SQL Server

Stripe (Payment integration)

Razor Views
