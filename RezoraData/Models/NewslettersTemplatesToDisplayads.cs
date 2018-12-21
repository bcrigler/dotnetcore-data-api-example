using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class NewslettersTemplatesToDisplayads
    {
        public int TemplatetodisplayadId { get; set; }
        public int TemplateId { get; set; }
        public int DisplayadImageLeft { get; set; }
        public int DisplayadImageTop { get; set; }
        public int DisplayadImageWidth { get; set; }
        public string DisplayadImageFormat { get; set; }
        public string SitescoutCreativeType { get; set; }
    }
}
