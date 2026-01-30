using System;

class Program
{
    static void Main(string[] args)
    {
        Address addr1 = new Address("789 Maple St", "Rexburg", "ID", "USA");
        Customer cust1 = new Customer("Juan Perez", addr1);

        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Laptop", "L404", 800.00m, 1));
        order1.AddProduct(new Product("Mouse", "M101", 25.50m, 2));


        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Order Cost: ${order1.CalculateTotal()}\n");
    }
}