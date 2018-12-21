using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class PinterestLog
    {
        public int RzPostId { get; set; }
        public string PPostId { get; set; }
        public int ItemId { get; set; }
        public string ItemType { get; set; }
        public string PTitle { get; set; }
        public string PDescription { get; set; }
        public string PImage { get; set; }
        public DateTimeOffset RequestTimestamp { get; set; }
        public int? OpenCount { get; set; }
        public int? ClickCount { get; set; }
        public int? PotentialReach { get; set; }
    }
}
