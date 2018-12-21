using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class BrokerageAgentAudience
    {
        public int BrokerageAgentAudienceId { get; set; }
        public int? BrokerageId { get; set; }
        public string SitescoutAudienceId { get; set; }
        public string SitescoutAudienceTag { get; set; }
        public byte SubscriptionEnabled { get; set; }
        public DateTime? Created { get; set; }
        public byte DisplayAds { get; set; }
        public int? UserId { get; set; }
    }
}
