using DIPDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPDemo.Classes
{
    public class CarEngineStarter
    {
        private readonly ICar _car;

        public CarEngineStarter(ICar car)
        {
            _car = car;
        }
        public void StartYourEngine()
        {
            _car.StartEngine();
        }
    }
}
