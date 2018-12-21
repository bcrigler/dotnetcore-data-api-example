using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class NewslettersTemplates
    {
        public NewslettersTemplates()
        {
            Newsletters = new HashSet<Newsletters>();
            NewslettersSchedules = new HashSet<NewslettersSchedules>();
            NewslettersTemplatesToBrokerages = new HashSet<NewslettersTemplatesToBrokerages>();
        }

        public int TemplateId { get; set; }
        public string TemplateName { get; set; }
        public DateTimeOffset TemplateDate { get; set; }
        public string TemplateTitle { get; set; }
        public string TemplateDefaultSubject { get; set; }
        public string TemplateDefaultMessage { get; set; }
        public string TemplateCampaignName { get; set; }
        public string TemplateHead { get; set; }
        public string TemplateJson { get; set; }
        public string TemplateJsonDraft { get; set; }
        public DateTimeOffset? TemplateHtmlTimestamp { get; set; }
        public double TemplateVersion { get; set; }
        public int? TemplateStatus { get; set; }
        public int TemplateTypeId { get; set; }
        public int TemplateCampaignId { get; set; }
        public string TemplatePath { get; set; }
        public string TemplateThumbnailPath { get; set; }
        public DateTimeOffset? ThumbnailTimestamp { get; set; }
        public int TemplateHeadlines { get; set; }
        public int TemplateMessages { get; set; }
        public int TemplateListings { get; set; }
        public int TemplateArticles { get; set; }
        public int TemplatePchefprods { get; set; }
        public int TemplateProds { get; set; }
        public int TemplateClass { get; set; }
        public int TemplateMessageMax { get; set; }
        public int TemplateWidth { get; set; }
        public int TemplateHeight { get; set; }
        public int TemplateRestricted { get; set; }
        public float TemplatePrice { get; set; }
        public string TemplateNotes { get; set; }
        public string TemplatePreviewId { get; set; }
        public string RequestUrl { get; set; }
        public string RequestMessage { get; set; }
        public int? RequestContactUserId { get; set; }
        public byte TemplateRsvp { get; set; }
        public string ReportStats { get; set; }
        public string ReportCharts { get; set; }
        public byte AllowEmail { get; set; }
        public byte AllowPrint { get; set; }
        public byte AllowOnline { get; set; }
        public byte IsResponsive { get; set; }
        public byte IsDisplayAd { get; set; }
        public byte IsWellcomemat { get; set; }
        public int OpenCount { get; set; }
        public int ClickCount { get; set; }
        public int BounceCount { get; set; }
        public int SpamCount { get; set; }
        public int EmailCount { get; set; }
        public int TotalOpenCount { get; set; }
        public int TotalClickCount { get; set; }
        public int MasterId { get; set; }
        public int MasterEnabled { get; set; }
        public byte TemplateArchived { get; set; }
        public int? ReachCount { get; set; }

        public NewslettersTemplatesTypes TemplateType { get; set; }
        public ICollection<Newsletters> Newsletters { get; set; }
        public ICollection<NewslettersSchedules> NewslettersSchedules { get; set; }
        public ICollection<NewslettersTemplatesToBrokerages> NewslettersTemplatesToBrokerages { get; set; }
    }
}
