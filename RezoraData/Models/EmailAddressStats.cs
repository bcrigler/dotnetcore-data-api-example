using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class EmailAddressStats
    {
        public string Email { get; set; }
        public int? Contacts { get; set; }
        public int? Delivered { get; set; }
        public int? Opens { get; set; }
        public int? DistinctOpens { get; set; }
        public int? Clicks { get; set; }
        public int? DistinctClicks { get; set; }
        public float? RawOpenRate { get; set; }
        public float? CleanOpenRate { get; set; }
        public float? RawClickRate { get; set; }
        public float? CleanClickRate { get; set; }
        public float? OtcRate { get; set; }
    }
}
