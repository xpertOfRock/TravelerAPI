<h1>Traveler API</h1>
Project Overview

Traveler API is a RESTful web application built with .NET 9, ASP.NET Core, Entity Framework Core, and PostgreSQL.
It provides functionality for managing travel plans and their associated locations.
Each plan contains an ordered list of locations with budgets, notes, and version tracking to prevent concurrency conflicts during updates.

<h1>Key Features</h1>

Full CRUD operations for Travel Plans and Locations

Automatic ordering of locations within a travel plan

Optimistic concurrency handling to prevent version conflicts

Data validation and centralized exception handling

Integration tests using xUnit and Testcontainers

Containerized environment with Docker Compose

<h1>Technologies Used</h1>

.NET 9

ASP.NET Core Web API

Entity Framework Core (PostgreSQL)

Docker / Docker Compose

xUnit + FluentAssertions

Testcontainers for .NET

Npgsql (PostgreSQL driver)
