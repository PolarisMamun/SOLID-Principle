using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle.ViolatedLSP
{
    public abstract class Vehicle
    {
        public abstract void StartEngine();
        public abstract void StopEngine();
    }
}
