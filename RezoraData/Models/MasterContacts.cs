using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class MasterContacts
    {
        public int ContactId { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactType { get; set; }
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
        public DateTimeOffset ContactDate { get; set; }
        public DateTimeOffset? ContactEditedDate { get; set; }
        public int UserId { get; set; }
        public int ElementId { get; set; }
        public string ContactCrmId { get; set; }
        public string ContactCrmOwnerId { get; set; }
        public string ContactCrmAccountId { get; set; }
        public byte ContactDeleted { get; set; }
        public int ContactUpdating { get; set; }
        public int ContactSelf { get; set; }
        public int ContactUnsubscribe { get; set; }
        public DateTimeOffset? ContactVerifiedTimestamp { get; set; }
        public float OpenScore { get; set; }
        public float ClickScore { get; set; }
        public float BounceScore { get; set; }
        public float UnsubscribeScore { get; set; }
        public float SpamScore { get; set; }
        public float DetailsScore { get; set; }
        public float SearchScore { get; set; }
        public int LastScored { get; set; }
        public int EmailCount { get; set; }
        public int SourceId { get; set; }
        public DateTimeOffset? OptinFirst { get; set; }
        public DateTimeOffset? OptinSecond { get; set; }
    }
}
