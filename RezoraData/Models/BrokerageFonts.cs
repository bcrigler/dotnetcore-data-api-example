using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class BrokerageFonts
    {
        public int Id { get; set; }
        public int? BrokerageId { get; set; }
        public string Font { get; set; }

        public Brokerages Brokerage { get; set; }
    }
}
