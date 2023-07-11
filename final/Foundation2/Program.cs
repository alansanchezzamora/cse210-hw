using System;

class Program
{
    static void Main(string[] args)
    {
        List<Product> products1 = new List<Product>();
        Address address1 = new Address("Playa Zihuatanejo 123", "Monterrey", "Nuevo León", "MX");
        Customer customer1 = new Customer("Alan Sánchez", address1);
        Product prod1 = new Product("Super Couch", "SCCH1", 10, 1);
        Product prod2 = new Product("Dinning Table Standar", "DTS", 20, 1);
        Product prod3 = new Product("Dell Laptop", "DELLPC", 30, 1);
        products1.Add(prod1);
        products1.Add(prod2);
        products1.Add(prod3);

        Order order1 = new Order(products1, customer1);
        Console.WriteLine("Order 1");

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Sub-total price: $ {order1.CalculateTotal()}");
        Console.WriteLine($"Shipping: ${order1.ShippingFee()}");
        Console.WriteLine($"Total: ${order1.CalculateTotal() + order1.ShippingFee()}");


        List<Product> products2 = new List<Product>();
        Address address2 = new Address("Laredo St", "Laredo", "Texas", "USA");
        Customer customer2 = new Customer("Karina Treviño", address2);
        Product prod21 = new Product("Sneakers", "SNK", 10, 2); 
        Product prod22 = new Product("Hat", "HAT", 20, 1);
        Product prod23 = new Product("Pants", "PNT", 30, 1);
        products2.Add(prod21);
        products2.Add(prod22);
        products2.Add(prod23);

        Order order2 = new Order(products2, customer2);
        Console.WriteLine("\nOrder 2");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Sub-total price: $ {order2.CalculateTotal()}");
        Console.WriteLine($"Shipping: ${order2.ShippingFee()}");
        Console.WriteLine($"Total: ${order2.CalculateTotal() + order2.ShippingFee()}");
    }
}