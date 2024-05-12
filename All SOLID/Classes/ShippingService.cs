using All_SOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_SOLID.Classes
{
    //SRP: ShippingService class: Responsible for shipping products. It encapsulates the logic for shipping a product, isolating it from other concerns.
    //OCP: You can introduce new shipping methods (e.g., ExpressShippingService) without changing the existing ShippingService class. Just create new classes implementing IShippingService.
    /*public class ShippingService : IShippingService
    {
        public void ShipProduct(IProduct product)
        {
            Console.WriteLine($"Shipping {product.Name}");
        }
    }*/
}
