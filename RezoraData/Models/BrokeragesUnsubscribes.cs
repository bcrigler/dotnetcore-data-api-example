using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class BrokeragesUnsubscribes
    {
        public int BrokeragesUnsubscribesId { get; set; }
        public int BrokerageId { get; set; }
        public string ContactEmail { get; set; }
        public DateTimeOffset BrokeragesUnsubscribesTime { get; set; }
    }
}
