using System;

class Program
{
    static void Main(string[] args)
    {
        Address dallasAdd = new Address("123 Main St", "Laketown", "Idaho", "USA");
        Customer dallas = new Customer("Dallas McCool", dallasAdd);
        Order order1 = new Order(dallas);
        Product product1 = new Product("Basketball", "DB4592", 24.99f, 1);
        Product product2 = new Product("Basketball Hoop", "DB4630", 210.99f, 2);
        order1.addProduct(product1);
        order1.addProduct(product2);

        Address davidAdd = new Address("11902 Banner Ln", "London", "England", "UK");
        Customer david = new Customer("David Brentford", davidAdd);
        Order order2 = new Order(david);
        Product product3 = new Product("Football", "ST2030", 22.50f, 3);
        Product product4 = new Product("Football Goal", "ST2013", 99.99f, 4);
        order2.addProduct(product3);
        order2.addProduct(product4);

        List<Order> orders = new List<Order>();
        orders.Add(order1);
        orders.Add(order2);

        Console.WriteLine("\nOrders:\n");
        foreach (Order ord in orders)
        {
            Console.WriteLine(ord.getPackingLabel());
            Console.WriteLine(ord.getShippingLabel());
            Console.WriteLine($"Total Cost: ${ord.getTotalCost():0.00}");
            Console.WriteLine();
        }
    }
}