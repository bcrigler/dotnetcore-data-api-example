using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class CloudelementsContacts
    {
        public string CeContactName { get; set; }
        public string CeContactEmail { get; set; }
        public string CeContactTitle { get; set; }
        public string CeContactCompany { get; set; }
        public string CeContactPhoneHome { get; set; }
        public string CeContactPhoneWork { get; set; }
        public string CeContactPhoneMobile { get; set; }
        public string CeContactPhoneFax { get; set; }
        public string CeContactBusinessStreet { get; set; }
        public string CeContactBusinessStreet2 { get; set; }
        public string CeContactBusinessCity { get; set; }
        public string CeContactBusinessState { get; set; }
        public string CeContactBusinessZip { get; set; }
        public string CeContactHomeStreet { get; set; }
        public string CeContactHomeStreet2 { get; set; }
        public string CeContactHomeCity { get; set; }
        public string CeContactHomeState { get; set; }
        public string CeContactHomeZip { get; set; }
        public string CeContactCrmType { get; set; }
        public string CeContactCrmId { get; set; }
        public string CeContactCrmOwnerId { get; set; }
        public string CeContactCrmAccountId { get; set; }
        public int? CeContactUnsubscribe { get; set; }
        public int CeContactBrokeragestoelements { get; set; }
        public int CeContactStatus { get; set; }
        public DateTimeOffset? CeContactDate { get; set; }
    }
}
