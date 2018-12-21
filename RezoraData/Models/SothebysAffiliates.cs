using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class SothebysAffiliates
    {
        public int AffiliateId { get; set; }
        public string AffiliateName { get; set; }
        public int BrokerageId { get; set; }
        public int GroupId { get; set; }
        public string AffiliateTheme { get; set; }
    }
}
