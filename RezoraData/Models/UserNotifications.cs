using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class UserNotifications
    {
        public int NotificationId { get; set; }
        public string NotificationType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
