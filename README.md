# Webshop Backend

[![Lines of Code](https://img.shields.io/tokei/lines/github/ZakariaHogeschoolR/webshop-fullstack)](https://github.com/ZakariaHogeschoolR/webshop-fullstack)
[![Commits](https://img.shields.io/github/commit-activity/m/ZakariaHogeschoolR/webshop-fullstack)](https://github.com/ZakariaHogeschoolR/webshop-fullstack/commits/main)
[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)

## Description
This is a production-style Webshop backend built with ASP.NET Core 9, PostgreSQL, and Entity Framework Core. It follows clean architecture principles with layered Controllers, Services, Repositories, and DbContext, and uses DTOs for request/response validation.

## Tech Stack
- ASP.NET Core 9
- PostgreSQL
- Entity Framework Core
- AutoMapper for DTO mapping
- FluentValidation for request validation
- Git & GitHub

## Features
- CRUD operations for Users, Products, Orders, etc.
- DTO-based request and response handling
- Layered service and repository architecture
- PostgreSQL database integration with EF Core
- Structured for authentication, filtering, and pagination
- Ready for future unit testing and scalability

## Architecture Overview
HTTP Request → Controller → Service → Repository → DbContext → PostgreSQL Database

- Controllers orchestrate requests and return DTOs
- Services encapsulate business logic
- Repositories handle data access
- DTOs decouple database models from API contracts

## Getting Started
1. Clone the repository from GitHub and navigate to the project folder.
2. Configure the database connection in `appsettings.Development.json` with your PostgreSQL credentials.
3. Apply EF Core migrations to create the database schema.
4. Run the project. The API will be available on your configured localhost port. Swagger may be enabled for endpoint documentation.

## Contributing
- Fork the repository
- Create a feature branch
- Commit your changes with clear messages
- Push and submit a pull request

## License
This project is licensed under the MIT License.
