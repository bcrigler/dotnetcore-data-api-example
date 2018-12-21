using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class BrokeragesSubscriptionsLog
    {
        public int LogId { get; set; }
        public DateTimeOffset? LogTimestamp { get; set; }
        public string LogType { get; set; }
        public int? BrokerageId { get; set; }
        public int? Subscriptions { get; set; }
        public int? UserId { get; set; }
    }
}
