using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Main Street", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm Street", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create products
        Product product1 = new Product("Widget", "W123", 10.99, 2);
        Product product2 = new Product("Gadget", "G456", 15.49, 1);
        Product product3 = new Product("Thingamajig", "T789", 7.99, 3);

        Product product4 = new Product("Doohickey", "D321", 12.49, 4);
        Product product5 = new Product("Contraption", "C654", 20.00, 1);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Display order details
        Console.WriteLine("Order 1 Details:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost():F2}");
        Console.WriteLine();

        Console.WriteLine("Order 2 Details:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost():F2}");
    }
}