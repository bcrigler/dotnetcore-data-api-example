using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class BrokeragesLocations
    {
        public int LocationId { get; set; }
        public string LocationCity { get; set; }
        public string LocationState { get; set; }
        public DateTimeOffset LocationTimestamp { get; set; }
        public int BrokerageId { get; set; }

        public Brokerages Brokerage { get; set; }
    }
}
