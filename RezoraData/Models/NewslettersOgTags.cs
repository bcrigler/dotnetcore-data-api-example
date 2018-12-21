using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class NewslettersOgTags
    {
        public int NewslettersOgTagsId { get; set; }
        public int NewsletterId { get; set; }
        public string OgTagName { get; set; }
        public string OgTagValue { get; set; }
    }
}
