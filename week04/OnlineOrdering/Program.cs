
using System;

class Program
{
    static void Main(string[] args)
    {
        // First customer (USA)
        Address address1 = new Address(
            "123 Main Street",
            "New York",
            "NY",
            "USA");

        Customer customer1 = new Customer("John Smith", address1);

        // Create first order
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "P001", 800, 1));
        order1.AddProduct(new Product("Mouse", "P002", 25, 2));
        order1.AddProduct(new Product("Keyboard", "P003", 50, 1));


        // Second customer (South Africa)
        Address address2 = new Address(
            "45 Main Road",
            "Johannesburg",
            "Gauteng",
            "South Africa");

        Customer customer2 = new Customer("Peter Johnson", address2);

        // Create second order
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Headphones", "P004", 60, 1));
        order2.AddProduct(new Product("Phone Case", "P005", 15, 2));
        order2.AddProduct(new Product("Charger", "P006", 20, 1));


        // Display first order
        Console.WriteLine("========== ORDER 1 ==========");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():F2}");

        Console.WriteLine();


        // Display second order
        Console.WriteLine("========== ORDER 2 ==========");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():F2}");
    }
}
