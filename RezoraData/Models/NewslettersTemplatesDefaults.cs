using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class NewslettersTemplatesDefaults
    {
        public int DefaultId { get; set; }
        public DateTimeOffset DefaultTimestamp { get; set; }
        public int TypeId { get; set; }
        public int TemplateId { get; set; }
        public int BrokerageId { get; set; }
    }
}
