using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class NewslettersReports
    {
        public int ReportId { get; set; }
        public int NewsletterId { get; set; }
        public int CityId { get; set; }
        public string ZipId { get; set; }
        public string ResidenceType { get; set; }
        public string ReportStats { get; set; }
        public string ReportCharts { get; set; }
    }
}
