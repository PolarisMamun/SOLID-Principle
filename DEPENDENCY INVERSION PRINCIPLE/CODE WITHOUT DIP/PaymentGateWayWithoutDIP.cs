using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPENDENCY_INVERSION_PRINCIPLE.CODE_WITHOUT_DIP
{
    //Without DIP
    //High-level directly depends on low-level modules
/*    public class PaymentGateWayWithoutDIP
    {*/
        //Low - Level modules
        class PayPalGateway
        {
            public void processPayment(double amount)
            {
                //Logic to process payment via Paypal
            }
        }
        class StripeGateway
        {
            public void processPayment(double amount)
            {
                //Logic to process payment via Paypal
            }
        }
        class SquareGateway
        {
            public void processPayment(double amount)
            {
                //Logic to process payment via Paypal
            }
        }
    }
/*}*/
