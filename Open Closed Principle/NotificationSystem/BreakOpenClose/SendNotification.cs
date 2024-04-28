using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.NotificationSystem.BreakOpenClose
{
    public class SendNotification
    {
        public void EmailNotification()
        {
            Console.WriteLine("The notification will send by Email");
        }
        public void SMSNotification()
        {
            Console.WriteLine("The notification will send by SMS");
        }
        public void PUSHNotification()
        {
            Console.WriteLine("The notification will send by PUSH notification");
        }
    }
}
