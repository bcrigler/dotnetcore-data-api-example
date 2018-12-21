using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class MarketreportsCities
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public string CityStatename { get; set; }
        public string CityNameencoded { get; set; }
        public string CityDisplayname { get; set; }
        public int CountyId { get; set; }
    }
}
