using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class Campaigns
    {
        public int CampaignId { get; set; }
        public int BrokerageId { get; set; }
        public string CampaignTitle { get; set; }
        public string CampaignDescription { get; set; }
        public string CampaignDetails { get; set; }
        public string CampaignPhoto { get; set; }
        public DateTimeOffset CampaignTimestamp { get; set; }
        public DateTime? CampaignStartdate { get; set; }
        public DateTime? CampaignStopdate { get; set; }
        public int CampaignRestricted { get; set; }
        public int MasterId { get; set; }
    }
}
