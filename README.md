
# SecondTask

## Overview

SecondTask is a C# .NET console application that demonstrates a simple database management system. The application is designed to manage and query data related to products, orders, categories, and order details. It follows the repository design pattern for handling data operations and uses Dapper for database interaction.

## Features

- **Repository Pattern**: Implements the repository design pattern for data access.
- **Dapper Integration**: Utilizes Dapper, an object-relational mapping (ORM) library, for efficient database access.
- **Sorting and Aggregation Queries**: Provides functionality to list orders by date, products by most sold, and categories with the most sold products.
- **Data Seeding**: Includes functionality to seed the database with initial data (currently commented out).

## Prerequisites

- An appropriate connection string set in the environment variable "MY_DATABASE_CONNECTION"

## Usage

After running the application, it will execute a series of predefined queries demonstrating its functionality:
- Adding any of the classes by using the commented out code.
- Listing all orders by date.
- Listing all products sorted by most sold.
- Listing categories with the most sold product.

The results of these queries will be displayed in the console.

## Project Structure

The project is divided into several key namespaces and classes:
- `Models`: Contains POCO classes like `Product`, `Order`, `Category`, and `OrderDetails`.
- `Interfaces`: Defines interfaces like `IProductRepository`, `IOrderRepository`, etc.
- `Repository`: Contains repository implementations for handling database operations.
- `Helper`: Includes helper classes like `ConnectionFactory` for database connection management.

