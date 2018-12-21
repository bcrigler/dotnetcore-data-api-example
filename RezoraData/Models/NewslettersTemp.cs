using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class NewslettersTemp
    {
        public int NewsletterId { get; set; }
        public DateTime NewsletterDate { get; set; }
        public int UserId { get; set; }
        public int TemplateId { get; set; }
        public string NewsletterSubject { get; set; }
        public string NewsletterHeadline { get; set; }
        public string NewsletterHeadline2 { get; set; }
        public string NewsletterHeadline3 { get; set; }
        public string NewsletterMessage { get; set; }
        public DateTimeOffset? NewsletterSentDate { get; set; }
        public DateTimeOffset NewsletterEditedDate { get; set; }
        public int NewsletterAutomated { get; set; }
        public int NewsletterAuthorized { get; set; }
        public string NewsletterPreviewId { get; set; }
        public string EmsEmailId { get; set; }
        public int OpenCount { get; set; }
        public int ClickCount { get; set; }
        public int BounceCount { get; set; }
        public int SpamCount { get; set; }
        public int EmailCount { get; set; }
    }
}
