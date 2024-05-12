using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_SOLID
{
    //ISP: The IProduct interface defines only the properties necessary for representing a product (Name and Price).
    public interface IProduct
    {
        string Name { get; set; }
        decimal Price { get; set; }
    }

    //ISP: The IShippingService interface defines only the method necessary for shipping a product (ShipProduct).
    public interface IShippingService
    {
        void ShipProduct(IProduct product);
    }
}
