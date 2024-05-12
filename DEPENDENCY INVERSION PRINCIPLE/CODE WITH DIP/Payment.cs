using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPENDENCY_INVERSION_PRINCIPLE.CODE_WITH_DIP
{
    //High-Level module
    public interface IPaymentGateway
    {
        void processPayment(double amount);
    }

    //Low-level modules
    public class PayPalGateway : IPaymentGateway
    {
        public void processPayment(double amount)
        {
            //Logic to process payment via PayPal
        }
    }
    public class StripeGateway : IPaymentGateway
    {
        public void processPayment(double amount)
        {
            //Logic to process payment via Stripe
        }
    }
    public class SquareGateway : IPaymentGateway
    {
        public void processPayment(double amount)
        {
            //Logic to process payment via Square
        }
    }
}
