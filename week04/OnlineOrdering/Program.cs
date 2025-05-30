using System;

class Program
{
    static void Main(string[] args)
    {
        // USA Customer
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "A123", 1200.00m, 1));
        order1.AddProduct(new Product("Mouse", "B456", 25.50m, 2));

        // Non-USA Customer
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Camera", "C789", 850.00m, 1));
        order2.AddProduct(new Product("Tripod", "D012", 49.99m, 1));

        // Display Order 1
        Console.WriteLine("Order 1 - Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Order 1 - Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Order 1 - Total Cost: ${order1.GetTotalCost():F2}");
        Console.WriteLine(new string('-', 40));

        // Display Order 2
        Console.WriteLine("Order 2 - Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Order 2 - Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Order 2 - Total Cost: ${order2.GetTotalCost():F2}");
    }
}