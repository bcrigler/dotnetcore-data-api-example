using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class MlsStats
    {
        public string OrgId { get; set; }
        public int ListingTypeId { get; set; }
        public DateTimeOffset StatsTimestamp { get; set; }
        public int ActiveListings { get; set; }
        public int ImageListings { get; set; }
        public int ActiveGeocodes { get; set; }
        public DateTime Imported { get; set; }
    }
}
