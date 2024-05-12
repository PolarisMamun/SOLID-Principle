using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle.ViolatedLSP
{
    public class NormalCar : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Starting the car engine.");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Stopping the car engine.");
        }
    }
}
