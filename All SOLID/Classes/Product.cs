using System;
namespace All_SOLID.Classes
{
    //SRP: Product class: Responsible for representing a product with properties like name and price. It encapsulates the data related to a product.
    //OCP: You can add new types of products (e.g., DigitalProduct, PhysicalProduct) without modifying the existing Product class. Just create new classes implementing IProduct.
    public class Product : IProduct
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
    //SRP: ShippingService class: Responsible for shipping products. It encapsulates the logic for shipping a product, isolating it from other concerns.
    //OCP: You can introduce new shipping methods (e.g., ExpressShippingService) without changing the existing ShippingService class. Just create new classes implementing IShippingService.
    public class ShippingService : IShippingService
    {
        public void ShipProduct(IProduct product)
        {
            Console.WriteLine($"Shipping {product.Name}");
        }
    }
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
