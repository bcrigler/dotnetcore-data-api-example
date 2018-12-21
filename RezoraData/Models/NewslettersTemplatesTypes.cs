using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class NewslettersTemplatesTypes
    {
        public NewslettersTemplatesTypes()
        {
            MasterTemplates = new HashSet<MasterTemplates>();
            NewslettersTemplates = new HashSet<NewslettersTemplates>();
        }

        public int TypeId { get; set; }
        public int TypeOrder { get; set; }
        public DateTimeOffset TypeDate { get; set; }
        public string TypeTitle { get; set; }

        public ICollection<MasterTemplates> MasterTemplates { get; set; }
        public ICollection<NewslettersTemplates> NewslettersTemplates { get; set; }
    }
}
