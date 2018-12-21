using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class FacebookLog
    {
        public int RzPostId { get; set; }
        public string FbPostId { get; set; }
        public int ItemId { get; set; }
        public string ItemType { get; set; }
        public DateTimeOffset RequestTimestamp { get; set; }
        public int? OpenCount { get; set; }
        public int? ClickCount { get; set; }
        public int? PotentialReach { get; set; }
    }
}
