using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class NewslettersTemplatesToCampaigns
    {
        public int TemplatetocampaignId { get; set; }
        public DateTimeOffset TemplatetocampaignTimestamp { get; set; }
        public int TemplateId { get; set; }
        public int CampaignId { get; set; }
    }
}
