using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.PaymentSystem.FollowOpenClose
{
    public class CreditCardPayment : PaymentMethod
    {
        public override void ProcessPayment(double amount)
        {
            Console.WriteLine($"This Payment Made By Credit Card and the amount is: {amount} ");
        }
    }
}
