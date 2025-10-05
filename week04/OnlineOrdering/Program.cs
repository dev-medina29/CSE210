using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer("Alice Smith", "123 Main St", "Springfield", "IL", "USA");
        Customer customer2 = new Customer("Bob Jones", "456 Elm St", "Toronto", "ON", "Canada");

        // Create products

        Product productA = new Product("Laptop", 800, "A123", 1);
        Product productB = new Product("Mouse", 20, "B456", 2);
        Product productC = new Product("Desk", 150, "C789", 1);
        Product productD = new Product("Chair", 85, "D012", 4);

        // Create orders
        
        Order order1 = new Order(customer1, new List<Product> { productA, productB, productC, productD });
        Order order2 = new Order(customer2, new List<Product> { productA, productC, productD });

        // get the the packing label, the shipping label, and the total price of the order

        List<Order> orders = new List<Order> { order1, order2};
        foreach (Order order in orders)
        {
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.PackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.ShippingLabel());
            Console.WriteLine($"Total Price: ${order.TotalPrice():0.00}");
            Console.WriteLine();
        }
    }
}