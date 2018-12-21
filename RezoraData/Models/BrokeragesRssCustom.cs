using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class BrokeragesRssCustom
    {
        public int FeedId { get; set; }
        public DateTimeOffset FeedTimestamp { get; set; }
        public string FeedUrl { get; set; }
        public string FeedTitle { get; set; }
        public int BrokerageId { get; set; }
    }
}
