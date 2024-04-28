using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.PaymentSystem.BreakOpenClose
{
    public class PaymentProcessor
    {
        public void ProcessCreditCardPayment(double amount)
        {
            Console.WriteLine($"This Payment Made By Credit Card and the amount is: {amount} ");
        }
        public void ProcessDebitCardPayment(double amount)
        {
            Console.WriteLine($"This payment made by Debit Card and The amount is : {amount}");
        }
        public void ProcessPayPalPayment(double amount)
        {
            Console.WriteLine($"This payment made by PayPal and The amount is : {amount}");
        }
    }
}
