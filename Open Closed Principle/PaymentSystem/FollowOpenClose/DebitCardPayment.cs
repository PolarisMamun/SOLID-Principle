using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.PaymentSystem.FollowOpenClose
{
    public class DebitCardPayment : PaymentMethod
    {
        public override void ProcessPayment(double amount)
        {
            Console.WriteLine($"This payment made by Debit Card and The amount is : {amount}");
        }
    }
}
