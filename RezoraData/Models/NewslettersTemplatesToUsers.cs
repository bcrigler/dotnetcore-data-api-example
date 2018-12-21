using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class NewslettersTemplatesToUsers
    {
        public int TemplatetouserId { get; set; }
        public DateTimeOffset TemplatetouserTimestamp { get; set; }
        public int TemplateId { get; set; }
        public int UserId { get; set; }
    }
}
