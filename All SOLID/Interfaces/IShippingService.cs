using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_SOLID.Interfaces
{
    //ISP: The IShippingService interface defines only the method necessary for shipping a product (ShipProduct).
    public interface IShippingService
    {
        void ShipProduct(IProduct product);
    }
}
