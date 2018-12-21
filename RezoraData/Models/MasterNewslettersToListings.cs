using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class MasterNewslettersToListings
    {
        public int MasternewslettertolistingId { get; set; }
        public string OrgId { get; set; }
        public string ListingId { get; set; }
        public int ListingTypeId { get; set; }
        public int NewsletterId { get; set; }
        public int NewslettertolistingOrder { get; set; }
        public DateTimeOffset NewslettertolistingDate { get; set; }
        public string NewslettertolistingMessage { get; set; }
        public string NewslettertolistingHeadline { get; set; }
    }
}
