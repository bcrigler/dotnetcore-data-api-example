using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class TwitterLog
    {
        public int RzPostId { get; set; }
        public string TwPostId { get; set; }
        public int ItemId { get; set; }
        public string ItemType { get; set; }
        public string TwTitle { get; set; }
        public string TwDescription { get; set; }
        public string TwImage { get; set; }
        public DateTimeOffset RequestTimestamp { get; set; }
        public int? OpenCount { get; set; }
        public int? ClickCount { get; set; }
        public int? PotentialReach { get; set; }
    }
}
