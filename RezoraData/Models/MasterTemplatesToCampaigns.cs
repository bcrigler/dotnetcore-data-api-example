using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class MasterTemplatesToCampaigns
    {
        public int MastertemplatetocampaignId { get; set; }
        public DateTimeOffset MastertemplatetocampaignTimestamp { get; set; }
        public int TemplateId { get; set; }
        public int CampaignId { get; set; }
    }
}
