using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class ContactImportRequest
    {
        public int RequestId { get; set; }
        public string ImportType { get; set; }
        public int UserId { get; set; }
        public int? TotalToDeliver { get; set; }
        public int? TotalDelivered { get; set; }
        public int? TotalFailed { get; set; }
        public DateTime? RequestedOn { get; set; }
        public DateTime? CompletedOn { get; set; }
        public string RequestMeta { get; set; }
        public byte? Overwrite { get; set; }
        public int? BouncesFailed { get; set; }
        public int? SpamreportFailed { get; set; }
        public int? SyntaxFailed { get; set; }
        public int? PurgeFailed { get; set; }
        public int? ContactExists { get; set; }
        public int? UnsubFailed { get; set; }
        public int? MissingEmail { get; set; }
        public DateTimeOffset? ContactsVerified { get; set; }
        public int? ContactsTested { get; set; }
        public byte? AutoSync { get; set; }
    }
}
