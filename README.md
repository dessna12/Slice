# Slice Restaurant

A C# project developed with Entity Framework, featuring a REST API, two views, and an admin interface.

## Overview

This project is built using C# and Entity Framework to create a dynamic web application. It includes a REST API for communication, provides two views to display data, and has an **admin interface** for managing content.
![App preview](./snippet-slice.png)


## Features

- **Entity Framework**: Used for ORM to interact with the database.
- **REST API**: Exposes endpoints for CRUD operations (Create, Read, Update, Delete).
- **Two Views**: Display the application’s data in a clean and intuitive interface.
- **Admin Interface**: Accessible via `/Admin` for administrative management of the content.

## Prerequisites

To run this project locally, make sure you have the following installed:

- **.NET Core SDK**: [Download here](https://dotnet.microsoft.com/download/dotnet)
- **SQL Server**: (if using SQL Server as the database)
- **Visual Studio** (or another C# compatible IDE)

## Installation

1. Clone the repository to your local machine:
   ```bash
   git clone <repository-url>
   ```
2. Navigate to the project directory:
   ```bash
   cd <project-directory>
   ```
3. Restore the project dependencies:
   ```bash
   dotnet restore
   ```
4. Run the application:
   ```bash
   dotnet run
   ```

The app will be available locally at `http://localhost:5000`.

## Views

- **View 1**: Displays a list of items from the database, allowing users to interact with the items (e.g., delete or update them).
- **View 2**: Provides a form to create new items and display them in a user-friendly format.

## Admin Interface

- The admin interface is available at `/admin` and allows administrators to manage the content within the application.
- It provides functionalities like managing items, adding or updating content, and controlling user access.

## Database

The project uses **Entity Framework** for database management. It connects to a SQL Server database where the application’s data is stored. The database schema is managed through migrations.

## Contributing

If you'd like to contribute to this project, feel free to fork the repository, make your changes, and submit a pull request. Be sure to write tests for your contributions.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

