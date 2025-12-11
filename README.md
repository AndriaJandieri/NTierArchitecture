# N-Tier Architecture Practice Project

This project is a simple learning-oriented implementation of **N-Tier Architecture**, created to understand how enterprise applications are structured and how responsibilities are separated between layers.
The main goal of this project is to practice clean architecture principles, improve code organization, and get comfortable working with layered backend systems.

##  Purpose
- Learn layer separation  
- Practice clean architecture basics  
- Understand service & repository patterns  
- Improve backend structure for future projects  

##  Tech Stack
- ASP.NET Core Web API  
- Entity Framework Core  
- PostgreSQL / SQL Server  
- Dependency Injection
  
##  Features
- Basic CRUD  
- DTO mapping  
- Repository + Service layers  
- EF Core persistence  

This project is for **learning and practice only**, not production use.

##########################################################################

# N-Tier Architecture Summary by Layers

## 1. Web (Presentation Layer)

  - Controllers

  - Razor views

  - ViewModels (not entities!)

  - Connecting UI → Services/Repositories

## 2. DataAccess (Repository / EF Core Layer)


  - AppDbContext

  - EF Core configurations

  - Repository pattern

  - Unit of Work

  - Migrations

  - Seed data

  - This layer talks directly to the database.

## 3. Models (Domain Layer)


  - Entities (Product, Category, etc.)

  - No EF logic besides simple annotations

  - Pure data structures used across layers

## 4. Utility (Helper Layer) Often includes:

  - Constants (SD.cs)

  - Config classes (Stripe, Email settings)

  - Email or SMS sender

  - Extensions

  - Notifications

  - Misc helpers
