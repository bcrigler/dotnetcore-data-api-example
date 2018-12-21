using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class EmsBounceFull
    {
        public int EventId { get; set; }
        public DateTimeOffset EventTimestamp { get; set; }
        public string Email { get; set; }
        public string Category { get; set; }
        public string EmailId { get; set; }
        public int UserId { get; set; }
        public int NewsletterId { get; set; }
        public int ContactId { get; set; }
        public string Status { get; set; }
        public string Reason { get; set; }
        public string Type { get; set; }
    }
}
