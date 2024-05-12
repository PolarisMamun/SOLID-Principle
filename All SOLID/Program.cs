using All_SOLID.Classes;
using All_SOLID.Interfaces;
using System;

namespace All_SOLID
{
    public class Program
    {
        static void Main(string[] args)
        {
            IProduct product1 = new Product("Laptop", 999.99m);
            IProduct product2 = new Product("Mouse", 29.99m);

            ShippingCart cart = new ShippingCart();
            cart.AddProduct(product1);
            cart.AddProduct(product2);

            IShippingService shippingService = new ShippingService();
            cart.Checkout(shippingService);
        }
    }
}
