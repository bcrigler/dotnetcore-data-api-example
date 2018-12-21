using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class NewslettersToProds
    {
        public int NewslettertoprodId { get; set; }
        public string ProdId { get; set; }
        public int NewsletterId { get; set; }
        public int NewslettertoprodOrder { get; set; }
        public DateTimeOffset NewslettertoprodDate { get; set; }
        public string NewslettertoprodMessage { get; set; }
        public string NewslettertoprodHeadline { get; set; }

        public Newsletters Newsletter { get; set; }
    }
}
