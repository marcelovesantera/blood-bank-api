# Blood Donation Management System

This is a backend API built with ASP.NET Core and Entity Framework Core to manage blood donors, donations, blood inventory, and reports. The project was created as part of a practical .NET learning program.

## Features

- Donor registration with data validation
- Address lookup using external CEP API
- Blood donation registration
- Inventory control with minimum stock alerts
- Donation history per donor
- Reports:
  - Total blood quantity by blood type
  - Donations from the last 30 days with donor details

## Business Rules

- A donor cannot be registered with an existing email
- Minors can be registered but cannot donate
- Minimum weight to donate is 50 kg
- Women can donate every 90 days
- Men can donate every 60 days
- Blood donations must be between 420ml and 470ml

## Technologies

- ASP.NET Core
- Entity Framework Core
- SQL Server or InMemory Database
- FluentValidation
- Repository Pattern
- Middleware for exception handling
- Swagger for API documentation
- xUnit for unit testing

## How to Run

1. Clone the repository:
```
git clone https://github.com/marcelovesantera/blood-donation-api.git
```
   
3. Configure the database connection string in `appsettings.json`
4. Run the application:
```
dotnet build
dotnet run
```

4. Open Swagger at:
```
http://localhost:{port}/swagger
```


## Running Tests
```
dotnet test
```
