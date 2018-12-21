using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class NewslettersTemplatesToBrokerages
    {
        public int TemplatetobrokerageId { get; set; }
        public DateTimeOffset TemplatetobrokerageTimestamp { get; set; }
        public int TemplateId { get; set; }
        public int BrokerageId { get; set; }

        public Brokerages Brokerage { get; set; }
        public NewslettersTemplates Template { get; set; }
    }
}
