using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class NewslettersCrmDataAgents
    {
        public int CrmdataId { get; set; }
        public string CrmType { get; set; }
        public string CrmEvent { get; set; }
        public int? UserId { get; set; }
        public int? NewsletterId { get; set; }
        public string CrmEventSubject { get; set; }
        public DateTimeOffset? EventTimestamp { get; set; }
    }
}
