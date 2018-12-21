using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class CloudelementsUsersToCampaigns
    {
        public int ElementUsertocampaignId { get; set; }
        public int UserId { get; set; }
        public string ElementCrmCamId { get; set; }
        public string ElementCrmCamName { get; set; }
        public int ElementId { get; set; }
        public DateTimeOffset ElementUsertocampaignTimestamp { get; set; }
    }
}
