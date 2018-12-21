using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class UsersNotificationPrefs
    {
        public int NotificationPrefId { get; set; }
        public int UserId { get; set; }
        public int NotificationTypeId { get; set; }
        public int NotificationId { get; set; }
        public DateTime EnabledDate { get; set; }
        public byte Enabled { get; set; }
    }
}
