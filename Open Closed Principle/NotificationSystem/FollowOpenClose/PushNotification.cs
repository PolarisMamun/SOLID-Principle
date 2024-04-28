using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.NotificationSystem.FollowOpenClose
{
    public class PushNotification : NotificationSystem
    {
        public override void SendNotification(string notificationSystem)
        {
            Console.WriteLine($"The notification will send by: {notificationSystem}");
        }
    }
}
