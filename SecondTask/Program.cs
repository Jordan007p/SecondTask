
using SecondTask.Helper;
using SecondTask.Models;
using SecondTask.Repository;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            var connectionFactory = new ConnectionFactory();

            var categoryRepository = new CategoryRepository(connectionFactory);
            var productRepository = new ProductRepository(connectionFactory);
            var orderRepository = new OrderRepository(connectionFactory);
            var orderDetailsRepository = new OrderDetailsRepository(connectionFactory);
            /*
            var categories = new List<Category>
            {
                new Category { CategoryName = "Electronics", Description = "Electronic Items" },
                new Category { CategoryName = "Books", Description = "All kinds of books" },
                new Category { CategoryName = "Clothing", Description = "Men and Women's Clothing" },
                new Category { CategoryName = "Home Appliances", Description = "Appliances for home use" },
                new Category { CategoryName = "Toys", Description = "Toys for children" },
                new Category { CategoryName = "Groceries", Description = "Everyday groceries" },
                new Category { CategoryName = "Sports", Description = "Sports equipment" },
                new Category { CategoryName = "Gardening", Description = "Gardening tools and supplies" },
                new Category { CategoryName = "Automotive", Description = "Automotive parts and accessories" },
                new Category { CategoryName = "Furniture", Description = "Furniture for home and office" }
            };
            var products = new List<Product>
            {
                new Product { ProductName = "Laptop", SupplierId = 1, CategoryId = 1, QuantityPerUnit = 10, UnitPrice = 1000, UnitsInStock = 5, UnitsOnOrder = 2, ReorderLevel = 1, Discontinued = false, LastUserId = 1, LastDateUpdated = DateTime.Now },
                new Product { ProductName = "Smartphone", SupplierId = 2, CategoryId = 1, QuantityPerUnit = 20, UnitPrice = 500, UnitsInStock = 10, UnitsOnOrder = 5, ReorderLevel = 2, Discontinued = false, LastUserId = 2, LastDateUpdated = DateTime.Now },
                new Product { ProductName = "Book - 'The Great Gatsby'", SupplierId = 3, CategoryId = 2, QuantityPerUnit = 100, UnitPrice = 20, UnitsInStock = 40, UnitsOnOrder = 10, ReorderLevel = 5, Discontinued = false, LastUserId = 3, LastDateUpdated = DateTime.Now },
                new Product { ProductName = "Men's T-Shirt", SupplierId = 4, CategoryId = 3, QuantityPerUnit = 50, UnitPrice = 15, UnitsInStock = 30, UnitsOnOrder = 20, ReorderLevel = 5, Discontinued = false, LastUserId = 4, LastDateUpdated = DateTime.Now },
                new Product { ProductName = "Blender", SupplierId = 5, CategoryId = 4, QuantityPerUnit = 15, UnitPrice = 35, UnitsInStock = 10, UnitsOnOrder = 5, ReorderLevel = 2, Discontinued = false, LastUserId = 5, LastDateUpdated = DateTime.Now },
                new Product { ProductName = "Teddy Bear", SupplierId = 6, CategoryId = 5, QuantityPerUnit = 30, UnitPrice = 25, UnitsInStock = 20, UnitsOnOrder = 10, ReorderLevel = 3, Discontinued = false, LastUserId = 6, LastDateUpdated = DateTime.Now },
                new Product { ProductName = "Organic Apples", SupplierId = 7, CategoryId = 6, QuantityPerUnit = 100, UnitPrice = 2, UnitsInStock = 50, UnitsOnOrder = 30, ReorderLevel = 10, Discontinued = false, LastUserId = 7, LastDateUpdated = DateTime.Now },
                new Product { ProductName = "Football", SupplierId = 8, CategoryId = 7, QuantityPerUnit = 20, UnitPrice = 22, UnitsInStock = 15, UnitsOnOrder = 8, ReorderLevel = 4, Discontinued = false, LastUserId = 8, LastDateUpdated = DateTime.Now },
                new Product { ProductName = "Gardening Shovel", SupplierId = 9, CategoryId = 8, QuantityPerUnit = 25, UnitPrice = 17, UnitsInStock = 12, UnitsOnOrder = 7, ReorderLevel = 3, Discontinued = false, LastUserId = 9, LastDateUpdated = DateTime.Now },
                new Product { ProductName = "Car Seat Covers", SupplierId = 10, CategoryId = 9, QuantityPerUnit = 10, UnitPrice = 45, UnitsInStock = 5, UnitsOnOrder = 3, ReorderLevel = 2, Discontinued = false, LastUserId = 10, LastDateUpdated = DateTime.Now }
            };
            var orders = new List<Order>
            {
                new Order { CustomerId = 1, EmployeeId = 1, OrderDate = new DateTime(2023, 1, 1), RequiredDate = new DateTime(2023, 1, 5), ShippedDate = new DateTime(2023, 1, 3), ShipVia = "UPS", Freight = "10.00", ShipName = "John Doe", ShipAddress = "123 Street", ShipCity = "City1", ShipRegion = "Region1", ShipPostalCode = "12345", ShipCountry = "Country1" },
                new Order { CustomerId = 2, EmployeeId = 2, OrderDate = new DateTime(2023, 1, 2), RequiredDate = new DateTime(2023, 1, 6), ShippedDate = new DateTime(2023, 1, 4), ShipVia = "FedEx", Freight = "15.00", ShipName = "Jane Smith", ShipAddress = "456 Avenue", ShipCity = "City2", ShipRegion = "Region2", ShipPostalCode = "23456", ShipCountry = "Country2" },
                new Order { CustomerId = 3, EmployeeId = 3, OrderDate = new DateTime(2023, 1, 3), RequiredDate = new DateTime(2023, 1, 7), ShippedDate = new DateTime(2023, 1, 5), ShipVia = "DHL", Freight = "12.00", ShipName = "Alice Johnson", ShipAddress = "789 Boulevard", ShipCity = "City3", ShipRegion = "Region3", ShipPostalCode = "34567", ShipCountry = "Country3" },
                new Order { CustomerId = 4, EmployeeId = 4, OrderDate = new DateTime(2023, 1, 4), RequiredDate = new DateTime(2023, 1, 8), ShippedDate = new DateTime(2023, 1, 6), ShipVia = "UPS", Freight = "8.00", ShipName = "Bob Brown", ShipAddress = "1010 Lane", ShipCity = "City4", ShipRegion = "Region4", ShipPostalCode = "45678", ShipCountry = "Country4" },
                new Order { CustomerId = 5, EmployeeId = 5, OrderDate = new DateTime(2023, 1, 5), RequiredDate = new DateTime(2023, 1, 9), ShippedDate = new DateTime(2023, 1, 7), ShipVia = "FedEx", Freight = "20.00", ShipName = "Carol White", ShipAddress = "1212 Drive", ShipCity = "City5", ShipRegion = "Region5", ShipPostalCode = "56789", ShipCountry = "Country5" },
                new Order { CustomerId = 6, EmployeeId = 1, OrderDate = new DateTime(2023, 1, 6), RequiredDate = new DateTime(2023, 1, 10), ShippedDate = new DateTime(2023, 1, 8), ShipVia = "DHL", Freight = "18.00", ShipName = "David Green", ShipAddress = "1313 Road", ShipCity = "City6", ShipRegion = "Region6", ShipPostalCode = "67890", ShipCountry = "Country6" },
                new Order { CustomerId = 7, EmployeeId = 2, OrderDate = new DateTime(2023, 1, 7), RequiredDate = new DateTime(2023, 1, 11), ShippedDate = new DateTime(2023, 1, 9), ShipVia = "UPS", Freight = "22.00", ShipName = "Evelyn King", ShipAddress = "1414 Street", ShipCity = "City7", ShipRegion = "Region7", ShipPostalCode = "78901", ShipCountry = "Country7" },
                new Order { CustomerId = 8, EmployeeId = 3, OrderDate = new DateTime(2023, 1, 8), RequiredDate = new DateTime(2023, 1, 12), ShippedDate = new DateTime(2023, 1, 10), ShipVia = "FedEx", Freight = "16.00", ShipName = "Frank Thompson", ShipAddress = "1515 Avenue", ShipCity = "City8", ShipRegion = "Region8", ShipPostalCode = "89012", ShipCountry = "Country8" },
                new Order { CustomerId = 9, EmployeeId = 4, OrderDate = new DateTime(2023, 1, 9), RequiredDate = new DateTime(2023, 1, 13), ShippedDate = new DateTime(2023, 1, 11), ShipVia = "DHL", Freight = "11.00", ShipName = "Grace Lee", ShipAddress = "1616 Boulevard", ShipCity = "City9", ShipRegion = "Region9", ShipPostalCode = "90123", ShipCountry = "Country9" },
                new Order { CustomerId = 10, EmployeeId = 5, OrderDate = new DateTime(2023, 1, 10), RequiredDate = new DateTime(2023, 1, 14), ShippedDate = new DateTime(2023, 1, 12), ShipVia = "UPS", Freight = "9.00", ShipName = "Henry Davis", ShipAddress = "1717 Lane", ShipCity = "City10", ShipRegion = "Region10", ShipPostalCode = "01234", ShipCountry = "Country10" }
            };
            var orderDetailsList = new List<OrderDetails>
            {
                new OrderDetails { OrderId = 1, ProductId = 1, UnitPrice = 50, Quantity = 2, Discount = 10 },
                new OrderDetails { OrderId = 1, ProductId = 2, UnitPrice = 60, Quantity = 1, Discount = 20 },
                new OrderDetails { OrderId = 2, ProductId = 3, UnitPrice = 30, Quantity = 3, Discount = 30 },
                new OrderDetails { OrderId = 2, ProductId = 4, UnitPrice = 20, Quantity = 4, Discount = 0 },
                new OrderDetails { OrderId = 3, ProductId = 5, UnitPrice = 80, Quantity = 1, Discount = 10 },
                new OrderDetails { OrderId = 3, ProductId = 6, UnitPrice = 90, Quantity = 2, Discount = 20 },
                new OrderDetails { OrderId = 4, ProductId = 7, UnitPrice = 100, Quantity = 1, Discount = 0 },
                new OrderDetails { OrderId = 4, ProductId = 8, UnitPrice = 40, Quantity = 2, Discount = 30 },
                new OrderDetails { OrderId = 5, ProductId = 9, UnitPrice = 110, Quantity = 3, Discount = 40 },
                new OrderDetails { OrderId = 5, ProductId = 10, UnitPrice = 70, Quantity = 2, Discount = 0 }
            };

            foreach (var category in categories)
            {
                categoryRepository.AddCategory(category);
            }

            foreach (var product in products)
            {
                productRepository.AddProduct(product);
            }

            foreach (var order in orders)
            {
                orderRepository.AddOrder(order);
            }

            foreach (var orderDetail in orderDetailsList)
            {
                orderDetailsRepository.AddOrderDetails(orderDetail);
            }


            Console.WriteLine("Data seeding completed successfully.");
            */

            //This is the Function to list all orders by date.
            Console.WriteLine("This is just a test for listing all orders by date");
            List<Order> ordersList = orderRepository.GetAllOrdersOrderedByDate().ToList(); ;
            ordersList.ForEach(p=>Console.WriteLine(p.OrderId+" "+p.OrderDate));
            Console.WriteLine();

            //This is the list of all products sorted by most sold.
            Console.WriteLine("This is just a test for listing all products sorted by most sold");
            List<Product> productsList =productRepository.GetAllProductsOrderedByMostSold().ToList(); ;
            productsList.ForEach(p => Console.WriteLine(p.ProductName));
            Console.WriteLine();

            //This is the List of categories with the most sold product.
            Console.WriteLine("This is just a test for listing the categories with the most sold product");
            List<Category> categoriesList= categoryRepository.GetAllCategoriesOrderedByMostSold().ToList();
            categoriesList.ForEach(p => Console.WriteLine(p.CategoryName));
            Console.WriteLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
