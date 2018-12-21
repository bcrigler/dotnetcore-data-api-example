using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class MlsMedia
    {
        public string MediaId { get; set; }
        public string OrgId { get; set; }
        public string ListingId { get; set; }
        public string MediaFormat { get; set; }
        public string MediaType { get; set; }
        public string MediaUrl { get; set; }
        public int MediaOrder { get; set; }
        public int PublishStatus { get; set; }
        public DateTimeOffset LastUpdate { get; set; }
        public int? LastProcessed { get; set; }
    }
}
