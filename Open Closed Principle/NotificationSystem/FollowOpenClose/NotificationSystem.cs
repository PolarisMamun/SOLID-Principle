using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.NotificationSystem.FollowOpenClose
{
    public abstract class NotificationSystem
    {
        public abstract void SendNotification(string notificationSystem);
    }
}
