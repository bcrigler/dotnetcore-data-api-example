using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class UsersToCampaigns
    {
        public int UsertocampaignId { get; set; }
        public int UserId { get; set; }
        public int CampaignId { get; set; }
        public int Ignored { get; set; }
        public DateTimeOffset UsertocampaignTimestamp { get; set; }
    }
}
