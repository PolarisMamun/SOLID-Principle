using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPENDENCY_INVERSION_PRINCIPLE.CODE_WITH_DIP
{
    //Client
    /*
     * BENEFITS WITH DIP IMPLEMENTATION
     *  In this implementation, the PaymentProcessor
        class depends on the PaymentGateway
        interface, adhering to DIP. This enables the
        system to seamlessly switch between different
        payment gateways without altering the core
        payment processing logic.

        By applying DIP in this payment system,
        software engineers ensure flexibility, testability,
        and maintainability, making it easier to adapt
        to evolving payment methods and
        requirements.
     */
    public class PaymentProcessor
    {
        private readonly IPaymentGateway _gateway;

        public PaymentProcessor(IPaymentGateway gateway)
        {
            this._gateway = gateway;
        }
        public void initiatePayment(double amount)
        {
            //Business Logic
            _gateway.processPayment(amount);
        }
    }
}
