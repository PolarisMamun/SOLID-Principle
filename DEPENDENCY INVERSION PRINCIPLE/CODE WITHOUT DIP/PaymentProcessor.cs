using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPENDENCY_INVERSION_PRINCIPLE.CODE_WITHOUT_DIP
{
    //Here breaking DIP
    //Client

    /*
     * PROBLEM WITH CURRENT IMPLEMENTATION

    In this implementation without DIP, the
    PaymentProcessor class directly depends on
    concrete implementations of payment
    gateways (PayPalGateway, StripeGateway,
    SquareGateway). This tight coupling makes
    the system less flexible and harder to maintain,
    as any changes to the payment gateways
    would require modifications to the PaymentProcessor class
     */
    public class PaymentProcessor
    {
        private PayPalGateway payPalGateway;
        private StripeGateway stripeGateway;
        private SquareGateway squareGateway;

        public PaymentProcessor()
        {
            this.payPalGateway = new PayPalGateway();
            this.stripeGateway = new StripeGateway();
            this.squareGateway = new SquareGateway();
        }
        public void initiatePayPalPayment(double amount)
        {
            payPalGateway.processPayment(amount);
        }
        public void initiateStripePayment(double amount)
        {
            stripeGateway.processPayment(amount);
        }
        public void initiateSquarePayment(double amount)
        {
            squareGateway.processPayment(amount);
        }
    }
}
