using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class AgentsFeaturedListings
    {
        public int FeatureId { get; set; }
        public int FeatureOrder { get; set; }
        public DateTimeOffset FeatureTimestamp { get; set; }
        public int UserId { get; set; }
        public string OrgId { get; set; }
        public string ListingId { get; set; }
        public int ListingTypeId { get; set; }
    }
}
