using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class NewslettersMessages
    {
        public int MessageId { get; set; }
        public int NewsletterId { get; set; }
        public int MessageOrder { get; set; }
        public DateTimeOffset MessageDate { get; set; }
        public string MessageText { get; set; }

        public Newsletters Newsletter { get; set; }
    }
}
