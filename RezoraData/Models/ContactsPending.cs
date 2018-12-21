using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class ContactsPending
    {
        public int ContactpendingId { get; set; }
        public int UserId { get; set; }
        public int ListId { get; set; }
        public int SourceId { get; set; }
        public DateTimeOffset OptinFirst { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactTitle { get; set; }
        public string ContactCompany { get; set; }
        public string ContactPhoneHome { get; set; }
        public string ContactPhoneWork { get; set; }
        public string ContactPhoneMobile { get; set; }
        public string ContactPhoneFax { get; set; }
        public string ContactBusinessStreet { get; set; }
        public string ContactBusinessStreet2 { get; set; }
        public string ContactBusinessCity { get; set; }
        public string ContactBusinessState { get; set; }
        public string ContactBusinessZip { get; set; }
        public string ContactHomeStreet { get; set; }
        public string ContactHomeStreet2 { get; set; }
        public string ContactHomeCity { get; set; }
        public string ContactHomeState { get; set; }
        public string ContactHomeZip { get; set; }

        public Users User { get; set; }
    }
}
