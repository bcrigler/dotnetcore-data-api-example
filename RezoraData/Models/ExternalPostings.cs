using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class ExternalPostings
    {
        public ExternalPostings()
        {
            ExternalPostingsLog = new HashSet<ExternalPostingsLog>();
        }

        public int PostingId { get; set; }
        public DateTimeOffset PostingTimestamp { get; set; }
        public string PostingService { get; set; }
        public string PostingMessage { get; set; }
        public int UserId { get; set; }
        public string OrgId { get; set; }
        public string ListingId { get; set; }
        public int ListingTypeId { get; set; }
        public string ServicePostingId { get; set; }

        public ICollection<ExternalPostingsLog> ExternalPostingsLog { get; set; }
    }
}
