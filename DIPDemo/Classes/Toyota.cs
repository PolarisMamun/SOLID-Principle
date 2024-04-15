using DIPDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPDemo.Classes
{
    public class Toyota : ICar
    {       
        public void StartEngine()
        {
            Console.WriteLine("Starting Toyota engine...");
        }
    }
}
