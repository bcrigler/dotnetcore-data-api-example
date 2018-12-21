using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class BrokerageCampaign
    {
        public int Id { get; set; }
        public int BrokerageId { get; set; }
        public int? UserId { get; set; }
        public int CampaignEnabled { get; set; }
        public string CampaignName { get; set; }
        public string CampaignUrl { get; set; }
        public byte DefaultCampaign { get; set; }
        public byte Deleted { get; set; }
        public string DisplayAds { get; set; }
        public byte[] Agents { get; set; }
        public int TotalCampaigns { get; set; }
        public int ProcessedCampaigns { get; set; }
    }
}
