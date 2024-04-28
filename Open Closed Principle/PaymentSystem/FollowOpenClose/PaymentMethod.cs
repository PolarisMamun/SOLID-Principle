using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.PaymentSystem.FollowOpenClose
{
    public abstract class PaymentMethod
    {
        public abstract void ProcessPayment(double amount);
    }
}
