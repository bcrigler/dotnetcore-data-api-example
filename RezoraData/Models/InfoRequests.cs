using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class InfoRequests
    {
        public int RequestId { get; set; }
        public DateTimeOffset RequestTimestamp { get; set; }
        public string RequestMessage { get; set; }
        public int ContactId { get; set; }
        public int NewsletterId { get; set; }
        public int UserId { get; set; }
        public int BrokerageId { get; set; }
        public int TemplateId { get; set; }
    }
}
