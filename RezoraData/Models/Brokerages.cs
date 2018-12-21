using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class Brokerages
    {
        public Brokerages()
        {
            BrokerageFonts = new HashSet<BrokerageFonts>();
            BrokeragesFeaturedListings = new HashSet<BrokeragesFeaturedListings>();
            BrokeragesLocations = new HashSet<BrokeragesLocations>();
            NewslettersTemplatesToBrokerages = new HashSet<NewslettersTemplatesToBrokerages>();
        }

        public int BrokerageId { get; set; }
        public string BrokerageName { get; set; }
        public int BrokerageType { get; set; }
        public int BrokerageIndustry { get; set; }
        public string BrokerageTheme { get; set; }
        public int BrokerageThemeUseDefaults { get; set; }
        public byte BrokerageThemeUseCustomLogo { get; set; }
        public string BrokerageMattColors { get; set; }
        public string BrokerageUrl { get; set; }
        public string BrokerageUserLogoPath { get; set; }
        public DateTimeOffset BrokerageTimestamp { get; set; }
        public int BrandId { get; set; }
        public string BrokerageAddressCanspam { get; set; }
        public string BrokerageDisclaimer { get; set; }
        public int BrokerageTimezoneOffset { get; set; }
        public string BrokerageTimezoneName { get; set; }
        public int BrokerageDaylightsavings { get; set; }
        public string BrokerageLanguage { get; set; }
        public int BrokerageRestrictNewsletters { get; set; }
        public byte BrokerageAllowProducts { get; set; }
        public string BrokerageFacebookKey { get; set; }
        public string BrokerageFacebookAppId { get; set; }
        public string BrokerageVimeoAlbum { get; set; }
        public int BrokerageZendeskOrgid { get; set; }
        public string BrokerageCloudspongeKey { get; set; }
        public int BrokeragePhoneSupport { get; set; }
        public int BrokerageExternalWebsite { get; set; }
        public string BrokerageCompanyId { get; set; }
        public string BrokerageListingLink { get; set; }
        public string BrokerageProdLink { get; set; }
        public int BrokerageAllowCobrand { get; set; }
        public int BrokerageAllowServiceProviders { get; set; }
        public int? BrokerageAllowCampaigns { get; set; }
        public int BrokerageAllowEnhancedContacts { get; set; }
        public byte BrokerageUseObservers { get; set; }
        public float BrokerageAdminPrice { get; set; }
        public float BrokerageAdminPriceDiscount { get; set; }
        public DateTime BrokerageAdminPriceDiscountExpires { get; set; }
        public float BrokerageUserPrice { get; set; }
        public float BrokerageUserPriceDiscount { get; set; }
        public DateTime BrokerageUserPriceDiscountExpires { get; set; }
        public float BrokerageBasePrice { get; set; }
        public float BrokerageEmailPrice { get; set; }
        public float BrokerageMlsPrice { get; set; }
        public float BrokerageCountyPrice { get; set; }
        public float BrokerageHiresPrice { get; set; }
        public int BrokerageMinimumUsers { get; set; }
        public DateTimeOffset BrokerageEffectiveDate { get; set; }
        public DateTime BrokerageStartBilling { get; set; }
        public int BrokeragePaySupport { get; set; }
        public int BrokeragePayCommission { get; set; }
        public int BrokerageRequireGroups { get; set; }
        public int BrokerageReportsAdvertise { get; set; }
        public int BrokerageReportsOption { get; set; }
        public int BrokerageHiresImages { get; set; }
        public byte BrokerageSsoRequired { get; set; }
        public string BrokerageSsoType { get; set; }
        public string BrokerageSsoRequestUrl { get; set; }
        public string BrokerageSsoCertificate { get; set; }
        public byte BrokerageUseDre { get; set; }
        public byte BrokerageWhiteLabel { get; set; }
        public byte BrokerageWhiteLabelDisplayads { get; set; }
        public byte BrokerageAllowPrint { get; set; }
        public byte BrokerageUseCustomListingLinks { get; set; }
        public byte BrokerageUseCustomListingLinksAlt { get; set; }
        public int StatusId { get; set; }
        public int ManagerId { get; set; }
        public int PaymentModel { get; set; }
        public int CcOnFile { get; set; }
        public int BillCc { get; set; }
        public int TrialProductId { get; set; }
        public int FullProductId { get; set; }
        public int AnnualProductId { get; set; }
        public string SendgridUsername { get; set; }
        public string SendgridPassword { get; set; }
        public byte UseAltCompLogoPath { get; set; }
        public byte OnlyAgentsOwnListings { get; set; }
        public string BrokerageAltSignupUrl { get; set; }
        public byte RequireSubscriptionAssignment { get; set; }
        public string BillingPeriod { get; set; }
        public string BillingPlan { get; set; }
        public int BillingTermDiscount { get; set; }
        public string BillingContactEmail { get; set; }
        public byte BrokerageRetargetingEnabled { get; set; }

        public Brands Brand { get; set; }
        public ICollection<BrokerageFonts> BrokerageFonts { get; set; }
        public ICollection<BrokeragesFeaturedListings> BrokeragesFeaturedListings { get; set; }
        public ICollection<BrokeragesLocations> BrokeragesLocations { get; set; }
        public ICollection<NewslettersTemplatesToBrokerages> NewslettersTemplatesToBrokerages { get; set; }
    }
}
