using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class NewslettersArticles
    {
        public int ArticleId { get; set; }
        public int NewsletterId { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticleSummary { get; set; }
        public string ArticleLink { get; set; }
        public string ArticleDate { get; set; }
        public string ArticleSource { get; set; }
        public int ArticleOrder { get; set; }
        public DateTimeOffset ArticleTimestamp { get; set; }

        public Newsletters Newsletter { get; set; }
    }
}
