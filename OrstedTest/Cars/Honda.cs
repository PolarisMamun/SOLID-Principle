using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrstedTest.Cars
{
    public class Honda : BaseCar
    {
        public override void StartEngine()
        {
            Console.WriteLine("Start Engine Honda");
        }
    }
}
