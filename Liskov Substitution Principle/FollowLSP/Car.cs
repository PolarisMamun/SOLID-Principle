using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle.FollowLSP
{
    public class Car : Vehicle,IEnginePowered
    {
        public override void HeadLight()
        {
            Console.WriteLine("The car need head light");
        }

        public void StartEngine()
        {
            Console.WriteLine("Starting the car engine.");
        }

        public void StopEngine()
        {
            Console.WriteLine("Stopping the car engine.");
        }
    }
}
