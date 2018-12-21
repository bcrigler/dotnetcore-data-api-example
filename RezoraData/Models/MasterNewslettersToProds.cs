using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class MasterNewslettersToProds
    {
        public int MasternewslettertoprodId { get; set; }
        public int ProdId { get; set; }
        public int NewsletterId { get; set; }
        public int NewslettertoprodOrder { get; set; }
        public DateTimeOffset NewslettertoprodDate { get; set; }
        public string NewslettertoprodMessage { get; set; }
        public string NewslettertoprodHeadline { get; set; }
    }
}
