using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class BrokeragesToRssNational
    {
        public int BrokeragetorssId { get; set; }
        public DateTimeOffset BrokeragetorssTimestamp { get; set; }
        public int BrokerageId { get; set; }
        public int RssId { get; set; }
    }
}
