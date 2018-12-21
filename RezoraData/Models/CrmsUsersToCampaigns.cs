using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class CrmsUsersToCampaigns
    {
        public int CrmUsertocampaignId { get; set; }
        public int? UserId { get; set; }
        public string CrmCamId { get; set; }
        public string CrmCamName { get; set; }
        public int? CrmId { get; set; }
        public DateTimeOffset? CrmUsertocampaignTimestamp { get; set; }
    }
}
