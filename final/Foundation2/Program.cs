using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("13698 Godzilla Ln", "Chandler", "AZ", "USA");
        Customer customer1 = new Customer("Simon Taunima", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Mac Laptop", "R704", 999.99, 1));
        order1.AddProduct(new Product("Apple Mouse", "A104", 25.99, 2));

        Address address2 = new Address("378 Deeps Rd", "Dublin", "D02", "Ireland");
        Customer customer2 = new Customer("Alicent Hightower", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Swords", "T201", 399.99, 1));
        order2.AddProduct(new Product("Vegtables", "V202", 39.99, 1));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():0.00}");
        Console.WriteLine(new string('-', 40));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():0.00}");
        Console.WriteLine(new string('-', 40));
    }
}