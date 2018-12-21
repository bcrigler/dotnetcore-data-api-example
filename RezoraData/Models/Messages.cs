using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class Messages
    {
        public int MessageId { get; set; }
        public string MessageTitle { get; set; }
        public string MessageText { get; set; }
        public string MessageType { get; set; }
        public DateTime? MessageStartdate { get; set; }
        public DateTime? MessageStopdate { get; set; }
        public int MessageWeight { get; set; }
        public int MessageReport { get; set; }
        public int MessageDashboard { get; set; }
        public int MessageHome { get; set; }
        public int MessageMarketing { get; set; }
        public DateTimeOffset MessageTimestamp { get; set; }
        public int UserTypeId { get; set; }
        public int BrokerageId { get; set; }
    }
}
