using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class LinkedinLog
    {
        public int RzPostId { get; set; }
        public string LiPostId { get; set; }
        public int ItemId { get; set; }
        public string ItemType { get; set; }
        public string LiTitle { get; set; }
        public string LiDescription { get; set; }
        public string LiImage { get; set; }
        public DateTimeOffset RequestTimestamp { get; set; }
        public int? OpenCount { get; set; }
        public int? ClickCount { get; set; }
        public int? PotentialReach { get; set; }
    }
}
