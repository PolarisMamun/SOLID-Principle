using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle.FollowLSP
{
    public class ElectricCar : Vehicle
    {
        public override void HeadLight()
        {
            Console.WriteLine("This car must need to include head light");
        }
    }
}
