using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class MarketreportsCounties
    {
        public int CountyId { get; set; }
        public string CountyName { get; set; }
        public string CountyNameencoded { get; set; }
        public string CountyDisplayname { get; set; }
        public int MarketId { get; set; }
    }
}
