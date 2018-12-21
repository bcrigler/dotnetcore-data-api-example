using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class UsersRanks
    {
        public int UserId { get; set; }
        public float OpenRate { get; set; }
        public float ClickRate { get; set; }
        public float BounceRate { get; set; }
        public float SpamRate { get; set; }
        public float LoginRate { get; set; }
        public float NewsletterRate { get; set; }
        public float PostcardRate { get; set; }
        public float EmailRate { get; set; }
        public int EmailCount { get; set; }
        public int ContactCount { get; set; }
        public float RankNumber { get; set; }
        public float RankPercentile { get; set; }
        public DateTimeOffset RankTimestamp { get; set; }
    }
}
