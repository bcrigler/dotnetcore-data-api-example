using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class ContactsHolder
    {
        public int ContactId { get; set; }
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
        public string ContactCrmType { get; set; }
        public string ContactCrmId { get; set; }
        public string ContactCrmOwnerId { get; set; }
        public string ContactCrmAccountId { get; set; }
        public int ElementId { get; set; }
        public int UserId { get; set; }
        public int ContactUnsubscribe { get; set; }
        public string SessionId { get; set; }
        public DateTimeOffset ContactTimestamp { get; set; }
    }
}
