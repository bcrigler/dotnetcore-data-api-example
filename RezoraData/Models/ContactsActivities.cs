using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class ContactsActivities
    {
        public int ActivityId { get; set; }
        public DateTimeOffset ActivityTimestamp { get; set; }
        public int ContactId { get; set; }
        public int? NewsletterId { get; set; }
        public string ActivityType { get; set; }
        public string ActivityOrgId { get; set; }
        public string ActivityListingId { get; set; }
        public int? ListingTypeId { get; set; }
        public string ActivitySearchListingid { get; set; }
        public int? ActivitySearchListingTypeId { get; set; }
        public string ActivitySearchLocation { get; set; }
        public int? ActivitySearchPriceMin { get; set; }
        public int? ActivitySearchPriceMax { get; set; }
        public int? ActivitySearchBedsMin { get; set; }
        public int? ActivitySearchBathsMin { get; set; }
        public int? ActivitySearchPage { get; set; }
        public string ActivitySource { get; set; }
        public int? ProdId { get; set; }

        public Contacts Contact { get; set; }
        public Newsletters Newsletter { get; set; }
    }
}
