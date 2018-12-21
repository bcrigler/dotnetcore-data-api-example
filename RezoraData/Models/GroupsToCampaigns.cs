using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class GroupsToCampaigns
    {
        public int GrouptocampaignId { get; set; }
        public DateTimeOffset GrouptocampaignTimestamp { get; set; }
        public int GroupId { get; set; }
        public int CampaignId { get; set; }
    }
}
