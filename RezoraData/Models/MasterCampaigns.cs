using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class MasterCampaigns
    {
        public int CampaignId { get; set; }
        public int BrandId { get; set; }
        public string CampaignTitle { get; set; }
        public string CampaignDescription { get; set; }
        public string CampaignDetails { get; set; }
        public string CampaignPhoto { get; set; }
        public DateTimeOffset CampaignTimestamp { get; set; }
        public DateTime? CampaignStartdate { get; set; }
        public DateTime? CampaignStopdate { get; set; }
        public int CampaignRestricted { get; set; }
        public byte? MasterPropagated { get; set; }
    }
}
