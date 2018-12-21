using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class NewslettersTemplatesToJson
    {
        public int TemplateToJsonId { get; set; }
        public DateTimeOffset TemplateToJsonTimestamp { get; set; }
        public int TemplateId { get; set; }
        public string TemplateJson { get; set; }
    }
}
