using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class ContactsToNewslettersBg
    {
        public long ContacttonewsletterId { get; set; }
        public int ContactId { get; set; }
        public int NewsletterId { get; set; }
        public DateTimeOffset ContacttonewsletterDate { get; set; }
    }
}
