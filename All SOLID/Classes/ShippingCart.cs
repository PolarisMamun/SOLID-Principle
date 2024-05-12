using System;
using System.Collections.Generic;

namespace All_SOLID.Classes
{
    public class ShippingCart
    {
        //SRP: ShoppingCart class: Responsible for managing a collection of products and handling the checkout process. It encapsulates the logic related to shopping cart operations.
        //LSP: The LSP states that subtypes should be substitutable for their base types without affecting the program's correctness. 
        //Any class implementing IProduct can be used interchangeably with the Product class in the ShoppingCart.
        //Any class implementing IShippingService can be used interchangeably with the ShippingService class in the ShoppingCart.

        //DIP: The DIP states that high-level modules should not depend on low-level modules. Both should depend on abstractions. 
        // The ShoppingCart class depends on abstractions (IProduct and IShippingService) rather than concrete implementations (Product and ShippingService). This allows for flexibility and decoupling.
        //Concrete implementations (Product and ShippingService) are passed to the ShoppingCart through interfaces, allowing for easy substitution with other implementations.

        private List<IProduct> _products = new List<IProduct>();
        public void AddProduct(IProduct product)
        {
            _products.Add(product);
        }
        public void Checkout(IShippingService shippingService)
        {
            foreach(var product in _products)
            {
                Console.WriteLine($"Adding {product.Name} to order....");
            }

            Console.WriteLine("Checking out....");
            foreach(var product in _products)
            {
                shippingService.ShipProduct(product);
            }

            Console.WriteLine("Order placed successfully");
        }
    }
}
