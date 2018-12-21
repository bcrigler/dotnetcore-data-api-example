using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class Newsletters
    {
        public Newsletters()
        {
            ContactsActivities = new HashSet<ContactsActivities>();
            ContactsToNewsletters = new HashSet<ContactsToNewsletters>();
            NewslettersArticles = new HashSet<NewslettersArticles>();
            NewslettersMessages = new HashSet<NewslettersMessages>();
            NewslettersToListings = new HashSet<NewslettersToListings>();
            NewslettersToPchefprods = new HashSet<NewslettersToPchefprods>();
            NewslettersToProds = new HashSet<NewslettersToProds>();
        }

        public int NewsletterId { get; set; }
        public DateTime NewsletterDate { get; set; }
        public int UserId { get; set; }
        public int TemplateId { get; set; }
        public string NewsletterCampaignName { get; set; }
        public string NewsletterTitle { get; set; }
        public string NewsletterSubject { get; set; }
        public string NewsletterHeadline { get; set; }
        public string NewsletterHeadline2 { get; set; }
        public string NewsletterHeadline3 { get; set; }
        public string NewsletterHeadline4 { get; set; }
        public string NewsletterHeadline5 { get; set; }
        public string NewsletterMessage { get; set; }
        public string NewsletterJson { get; set; }
        public string NewsletterJsonDraft { get; set; }
        public DateTimeOffset? NewsletterHtmlTimestamp { get; set; }
        public double NewsletterVersion { get; set; }
        public DateTimeOffset? ThumbnailTimestamp { get; set; }
        public int NewsletterArticles { get; set; }
        public int NewsletterListings { get; set; }
        public int NewsletterProds { get; set; }
        public int NewsletterWidth { get; set; }
        public int NewsletterHeight { get; set; }
        public int NewsletterRsvp { get; set; }
        public string NewsletterReportStats { get; set; }
        public string NewsletterReportCharts { get; set; }
        public DateTimeOffset? NewsletterSentDate { get; set; }
        public DateTimeOffset NewsletterEditedDate { get; set; }
        public DateTimeOffset? NewsletterAdminPublished { get; set; }
        public int NewsletterAutomated { get; set; }
        public int NewsletterAuthorized { get; set; }
        public byte NewsletterAllowOnline { get; set; }
        public string NewsletterPreviewId { get; set; }
        public string EmsEmailId { get; set; }
        public int OpenCount { get; set; }
        public int ClickCount { get; set; }
        public int BounceCount { get; set; }
        public int SpamCount { get; set; }
        public int EmailCount { get; set; }
        public int? ReachCount { get; set; }
        public int TotalOpenCount { get; set; }
        public int TotalClickCount { get; set; }

        public NewslettersTemplates Template { get; set; }
        public Users User { get; set; }
        public ICollection<ContactsActivities> ContactsActivities { get; set; }
        public ICollection<ContactsToNewsletters> ContactsToNewsletters { get; set; }
        public ICollection<NewslettersArticles> NewslettersArticles { get; set; }
        public ICollection<NewslettersMessages> NewslettersMessages { get; set; }
        public ICollection<NewslettersToListings> NewslettersToListings { get; set; }
        public ICollection<NewslettersToPchefprods> NewslettersToPchefprods { get; set; }
        public ICollection<NewslettersToProds> NewslettersToProds { get; set; }
    }
}
