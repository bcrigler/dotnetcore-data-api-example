using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class ContactsToNewsletters
    {
        public long ContacttonewsletterId { get; set; }
        public int ContactId { get; set; }
        public int NewsletterId { get; set; }
        public DateTimeOffset ContacttonewsletterDate { get; set; }

        public Contacts Contact { get; set; }
        public Newsletters Newsletter { get; set; }
    }
}
