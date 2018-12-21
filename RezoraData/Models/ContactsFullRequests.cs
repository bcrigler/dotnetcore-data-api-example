using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class ContactsFullRequests
    {
        public string RequestHash { get; set; }
        public int? UserId { get; set; }
        public int? ContactId { get; set; }
        public int? RequestStatus { get; set; }
        public DateTimeOffset RequestTimeResponse { get; set; }
        public DateTimeOffset RequestTimeRequest { get; set; }
    }
}
