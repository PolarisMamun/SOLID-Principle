using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle.FollowLSP
{
    public interface IEnginePowered
    {
        void StartEngine();
        void StopEngine();
    }
}
