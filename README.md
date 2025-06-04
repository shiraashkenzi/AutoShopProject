AutoShop – User and Vehicle Management System

Project Description

This project includes an ASP.NET Core 6 API and a React 18 frontend for managing users and vehicles. Data is stored in either SQL Server or SQLite, and the code follows Clean Code and Best Practices principles.

Technologies Used

Backend:

ASP.NET Core 6

Entity Framework Core

SQL Server / SQLite

Dependency Injection

Auto Migration (Database.Migrate)

Automatic Seed Data

Console Logging

Frontend:

React 18

Axios

React Router DOM

Bootstrap or CSS

Installation and Running

Prerequisites:

.NET 6 SDK

Node.js + NPM

SQL Server installed (or Docker)

Run Backend:

cd AutoShop.API
# Restore dependencies
dotnet restore
# Apply database migrations and start server
dotnet ef database update
dotnet run

Default URL: http://localhost:5041

Run Frontend:

cd auto-shop-frontend
npm install
npm run dev

Accessible at: http://localhost:5173

Backend Architecture

Controllers – Expose HTTP endpoints and forward requests to services

Services – Contain business logic and interact with the DbContext

Models – Entity Framework classes representing database tables

DTOs – API-facing data transfer objects without exposing internal models

DbContext – Manages database connection, migrations, and seed data
![Screen Shot 2025-06-04 at 22 58 16](https://github.com/user-attachments/assets/c908c95d-bb5d-4e3e-8266-818e44cc37a0)
![Screen Shot 2025-06-04 at 22 58 06](https://github.com/user-attachments/assets/0f98523f-4431-40ef-bac3-838a61e51cec)
![Screen Shot 2025-06-04 at 22 59 02](https://github.com/user-attachments/assets/ccf3d8a6-50b9-4bfe-877a-d523fcbeefca)
![Screen Shot 2025-06-04 at 22 58 53](https://github.com/user-attachments/assets/2025e74b-e0da-4c7f-af30-e702adacffb5)
![Screen Shot 2025-06-04 at 22 58 34](https://github.com/user-attachments/assets/3bfb1bcb-6560-4ddd-9432-695b34ea7153)

![Screen Shot 2025-06-04 at 22 57 52](https://github.com/user-attachments/assets/10ddf3c7-1de0-45ed-80e6-e1318abac13d)
![Screen Shot 2025-06-04 at 22 57 32](https://github.com/user-attachments/assets/9061b392-fa07-4926-b38e-e4009d973999)



