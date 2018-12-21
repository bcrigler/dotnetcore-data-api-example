using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class MattTemplatestarters
    {
        public int TemplatestarterId { get; set; }
        public string TemplatestarterTitle { get; set; }
        public string TemplateDefaultMessage { get; set; }
        public string TemplateDefaultSubject { get; set; }
        public int? TemplatestarterOwnerId { get; set; }
        public int? TemplatestarterOwnerTypeId { get; set; }
        public string TemplatestarterJson { get; set; }
        public int TemplateHeadlines { get; set; }
        public int TemplateMessages { get; set; }
        public int TemplateListings { get; set; }
        public int TemplateArticles { get; set; }
        public int TemplatePchefprods { get; set; }
        public int TemplateProds { get; set; }
        public int TemplateRsvp { get; set; }
        public byte AllowEmail { get; set; }
        public byte AllowPrint { get; set; }
        public byte IsWellcomemat { get; set; }
        public byte IsDisplayAd { get; set; }
        public int TemplateWidth { get; set; }
        public int TemplateHeight { get; set; }
    }
}
