using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle.ViolatedLSP
{
    //Even here in electric car do not have engine in this example , but we need to froce fully use StartEngine and 
    //StopEngine that break LSP(Liskov Substitution Principle) 

    //LSP rule is asserts that objects of the base class must be interchangeable with objects of any of
    //its derived classes,
    //without impacting the accuracy of the program.
    /*
     * Issue when we introduce a new type of vehicle, such as an ElectricCar, which doesn’t have an engine, 
     * we encounter a violation of the LSP. In this case, attempting to call the StartEngine() or StopEngine() 
     * methods on an ElectricCar object would result in 
     * exceptions because electric cars do not have engines.
     */
    public class ElectricCar : Vehicle
    {
        public override void StartEngine()
        {
            throw new InvalidOperationException("Electric cars do not have engines.");
        }

        public override void StopEngine()
        {
            throw new InvalidOperationException("Electric cars do have engins.");
        }
    }
}
