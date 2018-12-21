using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class ContactsRanks
    {
        public int ContactId { get; set; }
        public int UserId { get; set; }
        public float OpenScore { get; set; }
        public float ClickScore { get; set; }
        public float BounceScore { get; set; }
        public float UnsubscribeScore { get; set; }
        public float SpamScore { get; set; }
        public float DetailsScore { get; set; }
        public float SearchScore { get; set; }
        public int EmailCount { get; set; }
        public float RankNumber { get; set; }
        public float RankPercentile { get; set; }
        public DateTimeOffset RankTimestamp { get; set; }
    }
}
