using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class NewslettersTemplatesDefaultsTypes
    {
        public int TypeId { get; set; }
        public DateTimeOffset TypeTimestamp { get; set; }
        public string TypeChannel { get; set; }
        public string TypeName { get; set; }
    }
}
