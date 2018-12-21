using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class NewslettersToListingsImage
    {
        public int NliId { get; set; }
        public int NewsletterId { get; set; }
        public int ListingNumber { get; set; }
        public int ImagePosition { get; set; }
        public int UseImagePosition { get; set; }
        public string ListingId { get; set; }
        public string OrgId { get; set; }
    }
}
