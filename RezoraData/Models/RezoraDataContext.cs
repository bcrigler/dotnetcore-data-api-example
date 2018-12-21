using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RezoraData.Models
{
    public partial class RezoraDataContext : DbContext
    {
        public RezoraDataContext()
        {
        }

        public RezoraDataContext(DbContextOptions<RezoraDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdminCommandHash> AdminCommandHash { get; set; }
        public virtual DbSet<AdminKeyValue> AdminKeyValue { get; set; }
        public virtual DbSet<AdminStats> AdminStats { get; set; }
        public virtual DbSet<AgentsFeaturedListings> AgentsFeaturedListings { get; set; }
        public virtual DbSet<ApiKeys> ApiKeys { get; set; }
        public virtual DbSet<ApiLog> ApiLog { get; set; }
        public virtual DbSet<BetaFeatures> BetaFeatures { get; set; }
        public virtual DbSet<BetaFeaturesDesc> BetaFeaturesDesc { get; set; }
        public virtual DbSet<BrandFonts> BrandFonts { get; set; }
        public virtual DbSet<Brands> Brands { get; set; }
        public virtual DbSet<BrokerageAgentAudience> BrokerageAgentAudience { get; set; }
        public virtual DbSet<BrokerageAgentCampaigns> BrokerageAgentCampaigns { get; set; }
        public virtual DbSet<BrokerageCampaign> BrokerageCampaign { get; set; }
        public virtual DbSet<BrokerageFonts> BrokerageFonts { get; set; }
        public virtual DbSet<Brokerages> Brokerages { get; set; }
        public virtual DbSet<BrokeragesFeaturedListings> BrokeragesFeaturedListings { get; set; }
        public virtual DbSet<BrokeragesIndustry> BrokeragesIndustry { get; set; }
        public virtual DbSet<BrokeragesLocations> BrokeragesLocations { get; set; }
        public virtual DbSet<BrokeragesRssCustom> BrokeragesRssCustom { get; set; }
        public virtual DbSet<BrokeragesRssNational> BrokeragesRssNational { get; set; }
        public virtual DbSet<BrokeragesSchedulePermissionLog> BrokeragesSchedulePermissionLog { get; set; }
        public virtual DbSet<BrokeragesStatuses> BrokeragesStatuses { get; set; }
        public virtual DbSet<BrokeragesSubscriptionsLog> BrokeragesSubscriptionsLog { get; set; }
        public virtual DbSet<BrokeragesToElements> BrokeragesToElements { get; set; }
        public virtual DbSet<BrokeragesToRssNational> BrokeragesToRssNational { get; set; }
        public virtual DbSet<BrokeragesTypes> BrokeragesTypes { get; set; }
        public virtual DbSet<BrokeragesUnsubscribes> BrokeragesUnsubscribes { get; set; }
        public virtual DbSet<Campaigns> Campaigns { get; set; }
        public virtual DbSet<CampaignsToUsers> CampaignsToUsers { get; set; }
        public virtual DbSet<CloudelementsContacts> CloudelementsContacts { get; set; }
        public virtual DbSet<CloudelementsLog> CloudelementsLog { get; set; }
        public virtual DbSet<CloudelementsUsersToAccounts> CloudelementsUsersToAccounts { get; set; }
        public virtual DbSet<CloudelementsUsersToCampaigns> CloudelementsUsersToCampaigns { get; set; }
        public virtual DbSet<ContactImportRequest> ContactImportRequest { get; set; }
        public virtual DbSet<Contacts> Contacts { get; set; }
        public virtual DbSet<ContactsActivities> ContactsActivities { get; set; }
        public virtual DbSet<ContactsEnhanced> ContactsEnhanced { get; set; }
        public virtual DbSet<ContactsFull> ContactsFull { get; set; }
        public virtual DbSet<ContactsFullRequests> ContactsFullRequests { get; set; }
        public virtual DbSet<ContactsHolder> ContactsHolder { get; set; }
        public virtual DbSet<ContactsImports> ContactsImports { get; set; }
        public virtual DbSet<ContactsImportsHolder> ContactsImportsHolder { get; set; }
        public virtual DbSet<ContactsLists> ContactsLists { get; set; }
        public virtual DbSet<ContactsMeta> ContactsMeta { get; set; }
        public virtual DbSet<ContactsMetaTypes> ContactsMetaTypes { get; set; }
        public virtual DbSet<ContactsNotes> ContactsNotes { get; set; }
        public virtual DbSet<ContactsPending> ContactsPending { get; set; }
        public virtual DbSet<ContactsRanks> ContactsRanks { get; set; }
        public virtual DbSet<ContactsSources> ContactsSources { get; set; }
        public virtual DbSet<ContactsToElementListHolder> ContactsToElementListHolder { get; set; }
        public virtual DbSet<ContactsToLists> ContactsToLists { get; set; }
        public virtual DbSet<ContactsToNewsletters> ContactsToNewsletters { get; set; }
        public virtual DbSet<ContactsToNewslettersBg> ContactsToNewslettersBg { get; set; }
        public virtual DbSet<CrmContactsImports> CrmContactsImports { get; set; }
        public virtual DbSet<CrmsType> CrmsType { get; set; }
        public virtual DbSet<CrmsUsersToAccounts> CrmsUsersToAccounts { get; set; }
        public virtual DbSet<CrmsUsersToCampaigns> CrmsUsersToCampaigns { get; set; }
        public virtual DbSet<ElementsType> ElementsType { get; set; }
        public virtual DbSet<EmailAddressStats> EmailAddressStats { get; set; }
        public virtual DbSet<EmailBlock> EmailBlock { get; set; }
        public virtual DbSet<EmailBlockType> EmailBlockType { get; set; }
        public virtual DbSet<EmsBounceFull> EmsBounceFull { get; set; }
        public virtual DbSet<EmsBounces> EmsBounces { get; set; }
        public virtual DbSet<EmsClick> EmsClick { get; set; }
        public virtual DbSet<EmsCompositeMetrics> EmsCompositeMetrics { get; set; }
        public virtual DbSet<EmsDeferred> EmsDeferred { get; set; }
        public virtual DbSet<EmsDelivered> EmsDelivered { get; set; }
        public virtual DbSet<EmsDropped> EmsDropped { get; set; }
        public virtual DbSet<EmsOpen> EmsOpen { get; set; }
        public virtual DbSet<EmsProcessed> EmsProcessed { get; set; }
        public virtual DbSet<EmsSources> EmsSources { get; set; }
        public virtual DbSet<EmsSpamreport> EmsSpamreport { get; set; }
        public virtual DbSet<EmsUnsubscribe> EmsUnsubscribe { get; set; }
        public virtual DbSet<EmsUserAgent> EmsUserAgent { get; set; }
        public virtual DbSet<ExternalPostings> ExternalPostings { get; set; }
        public virtual DbSet<ExternalPostingsLog> ExternalPostingsLog { get; set; }
        public virtual DbSet<FacebookLog> FacebookLog { get; set; }
        public virtual DbSet<Favorites> Favorites { get; set; }
        public virtual DbSet<GallBrandsToCollections> GallBrandsToCollections { get; set; }
        public virtual DbSet<GallBrokeragesToCollections> GallBrokeragesToCollections { get; set; }
        public virtual DbSet<GallCategories> GallCategories { get; set; }
        public virtual DbSet<GallCollections> GallCollections { get; set; }
        public virtual DbSet<Gallery> Gallery { get; set; }
        public virtual DbSet<GalleryOrders> GalleryOrders { get; set; }
        public virtual DbSet<GalleryOrdersStatuses> GalleryOrdersStatuses { get; set; }
        public virtual DbSet<GalleryTimeframes> GalleryTimeframes { get; set; }
        public virtual DbSet<GalleryToBrokerage> GalleryToBrokerage { get; set; }
        public virtual DbSet<GalleryToTemplate> GalleryToTemplate { get; set; }
        public virtual DbSet<GallProducts> GallProducts { get; set; }
        public virtual DbSet<GallProductsToCategories> GallProductsToCategories { get; set; }
        public virtual DbSet<GallProductsToCollections> GallProductsToCollections { get; set; }
        public virtual DbSet<GaSettingsBrands> GaSettingsBrands { get; set; }
        public virtual DbSet<GaSettingsBrokerages> GaSettingsBrokerages { get; set; }
        public virtual DbSet<GaSettingsUsers> GaSettingsUsers { get; set; }
        public virtual DbSet<GeocodesRequests> GeocodesRequests { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<GroupsToAdmins> GroupsToAdmins { get; set; }
        public virtual DbSet<GroupsToCampaigns> GroupsToCampaigns { get; set; }
        public virtual DbSet<GroupsToCrms> GroupsToCrms { get; set; }
        public virtual DbSet<GroupsToElements> GroupsToElements { get; set; }
        public virtual DbSet<GroupsToMasterContactsLists> GroupsToMasterContactsLists { get; set; }
        public virtual DbSet<GroupsToTemplates> GroupsToTemplates { get; set; }
        public virtual DbSet<InfoRequests> InfoRequests { get; set; }
        public virtual DbSet<LinkedinLog> LinkedinLog { get; set; }
        public virtual DbSet<MarketreportsCities> MarketreportsCities { get; set; }
        public virtual DbSet<MarketreportsCitiesToCounties> MarketreportsCitiesToCounties { get; set; }
        public virtual DbSet<MarketreportsCounties> MarketreportsCounties { get; set; }
        public virtual DbSet<MarketreportsCountiesToBrokerages> MarketreportsCountiesToBrokerages { get; set; }
        public virtual DbSet<MarketreportsCountiesToMarkets> MarketreportsCountiesToMarkets { get; set; }
        public virtual DbSet<MarketreportsMarkets> MarketreportsMarkets { get; set; }
        public virtual DbSet<MarketreportsZips> MarketreportsZips { get; set; }
        public virtual DbSet<MarketreportsZipsToCities> MarketreportsZipsToCities { get; set; }
        public virtual DbSet<MasterCampaigns> MasterCampaigns { get; set; }
        public virtual DbSet<MasterCampaignsToBrokerages> MasterCampaignsToBrokerages { get; set; }
        public virtual DbSet<MasterContacts> MasterContacts { get; set; }
        public virtual DbSet<MasterContactsImports> MasterContactsImports { get; set; }
        public virtual DbSet<MasterContactsImportsHolder> MasterContactsImportsHolder { get; set; }
        public virtual DbSet<MasterContactsLists> MasterContactsLists { get; set; }
        public virtual DbSet<MasterContactsToLists> MasterContactsToLists { get; set; }
        public virtual DbSet<MasterListsToUsers> MasterListsToUsers { get; set; }
        public virtual DbSet<MasterNewsletters> MasterNewsletters { get; set; }
        public virtual DbSet<MasterNewslettersArticles> MasterNewslettersArticles { get; set; }
        public virtual DbSet<MasterNewslettersToListings> MasterNewslettersToListings { get; set; }
        public virtual DbSet<MasterNewslettersToProds> MasterNewslettersToProds { get; set; }
        public virtual DbSet<MasterNewslettersToRsvpevent> MasterNewslettersToRsvpevent { get; set; }
        public virtual DbSet<MasterSchedules> MasterSchedules { get; set; }
        public virtual DbSet<MasterTemplates> MasterTemplates { get; set; }
        public virtual DbSet<MasterTemplatesCats> MasterTemplatesCats { get; set; }
        public virtual DbSet<MasterTemplatesToBrokerages> MasterTemplatesToBrokerages { get; set; }
        public virtual DbSet<MasterTemplatesToCampaigns> MasterTemplatesToCampaigns { get; set; }
        public virtual DbSet<MasterTemplatesToCats> MasterTemplatesToCats { get; set; }
        public virtual DbSet<MasterTemplatesToDisplayads> MasterTemplatesToDisplayads { get; set; }
        public virtual DbSet<MasterTemplatesToJson> MasterTemplatesToJson { get; set; }
        public virtual DbSet<MattContent> MattContent { get; set; }
        public virtual DbSet<MattContentClass> MattContentClass { get; set; }
        public virtual DbSet<MattContentHidden> MattContentHidden { get; set; }
        public virtual DbSet<MattContentToJson> MattContentToJson { get; set; }
        public virtual DbSet<MattOwnerType> MattOwnerType { get; set; }
        public virtual DbSet<MattSectionClass> MattSectionClass { get; set; }
        public virtual DbSet<MattSections> MattSections { get; set; }
        public virtual DbSet<MattSectionsHidden> MattSectionsHidden { get; set; }
        public virtual DbSet<MattSectionToJson> MattSectionToJson { get; set; }
        public virtual DbSet<MattTemplatestarters> MattTemplatestarters { get; set; }
        public virtual DbSet<Messages> Messages { get; set; }
        public virtual DbSet<MlsAgents> MlsAgents { get; set; }
        public virtual DbSet<MlsBusListings> MlsBusListings { get; set; }
        public virtual DbSet<MlsComListings> MlsComListings { get; set; }
        public virtual DbSet<MlsFeatures> MlsFeatures { get; set; }
        public virtual DbSet<MlsImportEntryHash0> MlsImportEntryHash0 { get; set; }
        public virtual DbSet<MlsImportEntryHash1> MlsImportEntryHash1 { get; set; }
        public virtual DbSet<MlsImportEntryHash2> MlsImportEntryHash2 { get; set; }
        public virtual DbSet<MlsImportEntryHashDev> MlsImportEntryHashDev { get; set; }
        public virtual DbSet<MlsImportFailures> MlsImportFailures { get; set; }
        public virtual DbSet<MlsImportFiles> MlsImportFiles { get; set; }
        public virtual DbSet<MlsIncomeListings> MlsIncomeListings { get; set; }
        public virtual DbSet<MlsLandListings> MlsLandListings { get; set; }
        public virtual DbSet<MlsLeaseListings> MlsLeaseListings { get; set; }
        public virtual DbSet<MlsLegal> MlsLegal { get; set; }
        public virtual DbSet<MlsListingTypes> MlsListingTypes { get; set; }
        public virtual DbSet<MlsMedia> MlsMedia { get; set; }
        public virtual DbSet<MlsMeta0> MlsMeta0 { get; set; }
        public virtual DbSet<MlsMeta1> MlsMeta1 { get; set; }
        public virtual DbSet<MlsMeta2> MlsMeta2 { get; set; }
        public virtual DbSet<MlsOffices> MlsOffices { get; set; }
        public virtual DbSet<MlsOrganizations> MlsOrganizations { get; set; }
        public virtual DbSet<MlsPhotos> MlsPhotos { get; set; }
        public virtual DbSet<MlsPrivateListings> MlsPrivateListings { get; set; }
        public virtual DbSet<MlsResListings> MlsResListings { get; set; }
        public virtual DbSet<MlsStats> MlsStats { get; set; }
        public virtual DbSet<MlsUsedListings> MlsUsedListings { get; set; }
        public virtual DbSet<Newsletters> Newsletters { get; set; }
        public virtual DbSet<NewslettersArticles> NewslettersArticles { get; set; }
        public virtual DbSet<NewslettersCrmDataAdmins> NewslettersCrmDataAdmins { get; set; }
        public virtual DbSet<NewslettersCrmDataAgents> NewslettersCrmDataAgents { get; set; }
        public virtual DbSet<NewslettersListingsClicktoplayImages> NewslettersListingsClicktoplayImages { get; set; }
        public virtual DbSet<NewslettersListingsTemplates> NewslettersListingsTemplates { get; set; }
        public virtual DbSet<NewslettersMessages> NewslettersMessages { get; set; }
        public virtual DbSet<NewslettersOgTags> NewslettersOgTags { get; set; }
        public virtual DbSet<NewslettersReports> NewslettersReports { get; set; }
        public virtual DbSet<NewslettersSchedules> NewslettersSchedules { get; set; }
        public virtual DbSet<NewslettersSchedulesOptouts> NewslettersSchedulesOptouts { get; set; }
        public virtual DbSet<NewslettersTemp> NewslettersTemp { get; set; }
        public virtual DbSet<NewslettersTemplates> NewslettersTemplates { get; set; }
        public virtual DbSet<NewslettersTemplatesCats> NewslettersTemplatesCats { get; set; }
        public virtual DbSet<NewslettersTemplatesClasses> NewslettersTemplatesClasses { get; set; }
        public virtual DbSet<NewslettersTemplatesDefaults> NewslettersTemplatesDefaults { get; set; }
        public virtual DbSet<NewslettersTemplatesDefaultsTypes> NewslettersTemplatesDefaultsTypes { get; set; }
        public virtual DbSet<NewslettersTemplatesToBrokerages> NewslettersTemplatesToBrokerages { get; set; }
        public virtual DbSet<NewslettersTemplatesToCampaigns> NewslettersTemplatesToCampaigns { get; set; }
        public virtual DbSet<NewslettersTemplatesToCats> NewslettersTemplatesToCats { get; set; }
        public virtual DbSet<NewslettersTemplatesToDisplayads> NewslettersTemplatesToDisplayads { get; set; }
        public virtual DbSet<NewslettersTemplatesToJson> NewslettersTemplatesToJson { get; set; }
        public virtual DbSet<NewslettersTemplatesToUsers> NewslettersTemplatesToUsers { get; set; }
        public virtual DbSet<NewslettersTemplatesTypes> NewslettersTemplatesTypes { get; set; }
        public virtual DbSet<NewslettersToDisplayads> NewslettersToDisplayads { get; set; }
        public virtual DbSet<NewslettersToListings> NewslettersToListings { get; set; }
        public virtual DbSet<NewslettersToListingsImage> NewslettersToListingsImage { get; set; }
        public virtual DbSet<NewslettersToPchefprods> NewslettersToPchefprods { get; set; }
        public virtual DbSet<NewslettersToProds> NewslettersToProds { get; set; }
        public virtual DbSet<NewslettersToRsvpevent> NewslettersToRsvpevent { get; set; }
        public virtual DbSet<NewslettersUsersSchedules> NewslettersUsersSchedules { get; set; }
        public virtual DbSet<PinterestLog> PinterestLog { get; set; }
        public virtual DbSet<ProductsLifevantage> ProductsLifevantage { get; set; }
        public virtual DbSet<ProductsMiche> ProductsMiche { get; set; }
        public virtual DbSet<ProductsPchef> ProductsPchef { get; set; }
        public virtual DbSet<ProductsPosh> ProductsPosh { get; set; }
        public virtual DbSet<ProductsSchein> ProductsSchein { get; set; }
        public virtual DbSet<ProductsSwift> ProductsSwift { get; set; }
        public virtual DbSet<PurgeRequest> PurgeRequest { get; set; }
        public virtual DbSet<PurgeType> PurgeType { get; set; }
        public virtual DbSet<Siragents> Siragents { get; set; }
        public virtual DbSet<SircommercialListings> SircommercialListings { get; set; }
        public virtual DbSet<SircorpStaff> SircorpStaff { get; set; }
        public virtual DbSet<Sirmeta0> Sirmeta0 { get; set; }
        public virtual DbSet<Sirmeta1> Sirmeta1 { get; set; }
        public virtual DbSet<Sirmeta2> Sirmeta2 { get; set; }
        public virtual DbSet<SirnonSales> SirnonSales { get; set; }
        public virtual DbSet<Siroffice> Siroffice { get; set; }
        public virtual DbSet<SirotherFiles> SirotherFiles { get; set; }
        public virtual DbSet<SirresidentialListings> SirresidentialListings { get; set; }
        public virtual DbSet<SirstaticCodes> SirstaticCodes { get; set; }
        public virtual DbSet<Sirteam> Sirteam { get; set; }
        public virtual DbSet<SothebysAffiliates> SothebysAffiliates { get; set; }
        public virtual DbSet<ThumbnailsLog> ThumbnailsLog { get; set; }
        public virtual DbSet<TwitterLog> TwitterLog { get; set; }
        public virtual DbSet<UserActions> UserActions { get; set; }
        public virtual DbSet<UserLoginNonce> UserLoginNonce { get; set; }
        public virtual DbSet<UserNotifications> UserNotifications { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersAssumptions> UsersAssumptions { get; set; }
        public virtual DbSet<UsersCrmsAccess> UsersCrmsAccess { get; set; }
        public virtual DbSet<UsersExitsurveyOptions> UsersExitsurveyOptions { get; set; }
        public virtual DbSet<UsersExitsurveyResponses> UsersExitsurveyResponses { get; set; }
        public virtual DbSet<UsersFbpages> UsersFbpages { get; set; }
        public virtual DbSet<UsersLog> UsersLog { get; set; }
        public virtual DbSet<UsersNotificationPrefs> UsersNotificationPrefs { get; set; }
        public virtual DbSet<UsersRanks> UsersRanks { get; set; }
        public virtual DbSet<UsersStatuses> UsersStatuses { get; set; }
        public virtual DbSet<UsersToActions> UsersToActions { get; set; }
        public virtual DbSet<UsersToAmember> UsersToAmember { get; set; }
        public virtual DbSet<UsersToCampaigns> UsersToCampaigns { get; set; }
        public virtual DbSet<UsersToContacts> UsersToContacts { get; set; }
        public virtual DbSet<UsersToCrms> UsersToCrms { get; set; }
        public virtual DbSet<UsersToElements> UsersToElements { get; set; }
        public virtual DbSet<UsersToGroups> UsersToGroups { get; set; }
        public virtual DbSet<UsersToMlsAgents> UsersToMlsAgents { get; set; }
        public virtual DbSet<UsersToMlsOffices> UsersToMlsOffices { get; set; }
        public virtual DbSet<UsersToSitescoutAudiences> UsersToSitescoutAudiences { get; set; }
        public virtual DbSet<UsersToSitescoutCampaigns> UsersToSitescoutCampaigns { get; set; }
        public virtual DbSet<UsersTypes> UsersTypes { get; set; }
        public virtual DbSet<UserToAmemberSub> UserToAmemberSub { get; set; }
        public virtual DbSet<UserToSms> UserToSms { get; set; }
        public virtual DbSet<WellcomematImportLog> WellcomematImportLog { get; set; }
        public virtual DbSet<WellcomematMedia> WellcomematMedia { get; set; }
        public virtual DbSet<Workflows> Workflows { get; set; }
        public virtual DbSet<WorkflowSteps> WorkflowSteps { get; set; }
        public virtual DbSet<WorkflowTemplates> WorkflowTemplates { get; set; }
        public virtual DbSet<WorkflowTypes> WorkflowTypes { get; set; }

        // Unable to generate entity type for table 'rezoradata.bb_amember_ids'. Please see the warning messages.
        // Unable to generate entity type for table 'rezoradata.bb_amember_user_payments'. Please see the warning messages.
        // Unable to generate entity type for table 'rezoradata.contacts_import_hash_0'. Please see the warning messages.
        // Unable to generate entity type for table 'rezoradata.contacts_import_hash_1'. Please see the warning messages.
        // Unable to generate entity type for table 'rezoradata.contacts_import_hash_2'. Please see the warning messages.
        // Unable to generate entity type for table 'rezoradata.contacts_import_hash_3'. Please see the warning messages.
        // Unable to generate entity type for table 'rezoradata.mls_restrictions_exceptions_brokerages'. Please see the warning messages.
        // Unable to generate entity type for table 'rezoradata.planomatic_feeds'. Please see the warning messages.
        // Unable to generate entity type for table 'rezoradata.pr_listings'. Please see the warning messages.
        // Unable to generate entity type for table 'rezoradata.rez_storage_stats'. Please see the warning messages.
        // Unable to generate entity type for table 'rezoradata.user_notification_enabled'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("Name=Rezora");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminCommandHash>(entity =>
            {
                entity.HasKey(e => e.CommandHashId);

                entity.ToTable("admin_command_hash", "rezoradata");

                entity.HasIndex(e => e.CommandHash)
                    .HasName("idx_command_hash");

                entity.Property(e => e.CommandHashId)
                    .HasColumnName("command_hash_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CommandData)
                    .IsRequired()
                    .HasColumnName("command_data")
                    .HasColumnType("blob");

                entity.Property(e => e.CommandHash)
                    .IsRequired()
                    .HasColumnName("command_hash")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CompletedDate).HasColumnName("completed_date");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ExpireDate)
                    .HasColumnName("expire_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<AdminKeyValue>(entity =>
            {
                entity.HasKey(e => new { e.Class, e.Key });

                entity.ToTable("admin_key_value", "rezoradata");

                entity.Property(e => e.Class)
                    .HasColumnName("class")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Contents)
                    .HasColumnName("contents")
                    .IsUnicode(false);

                entity.Property(e => e.Expires)
                    .HasColumnName("expires")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("enum('raw','json')")
                    .HasDefaultValueSql("raw");
            });

            modelBuilder.Entity<AdminStats>(entity =>
            {
                entity.HasKey(e => e.StatsId);

                entity.ToTable("admin_stats", "rezoradata");

                entity.HasIndex(e => e.StatsTimestamp)
                    .HasName("stats_timestamp");

                entity.Property(e => e.StatsId)
                    .HasColumnName("stats_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StatsAgentsActivation)
                    .HasColumnName("stats_agents_activation")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StatsAgentsActive)
                    .HasColumnName("stats_agents_active")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StatsAgentsComplimentary)
                    .HasColumnName("stats_agents_complimentary")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StatsAgentsInactive)
                    .HasColumnName("stats_agents_inactive")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StatsAgentsTotal)
                    .HasColumnName("stats_agents_total")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StatsAgentsTrial)
                    .HasColumnName("stats_agents_trial")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StatsBrokersTotal)
                    .HasColumnName("stats_brokers_total")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StatsClicks)
                    .HasColumnName("stats_clicks")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StatsConsumersTotal)
                    .HasColumnName("stats_consumers_total")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StatsEmails)
                    .HasColumnName("stats_emails")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StatsOpens)
                    .HasColumnName("stats_opens")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StatsTimestamp)
                    .HasColumnName("stats_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.StatsUsersTotal)
                    .HasColumnName("stats_users_total")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<AgentsFeaturedListings>(entity =>
            {
                entity.HasKey(e => e.FeatureId);

                entity.ToTable("agents_featured_listings", "rezoradata");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.FeatureId)
                    .HasColumnName("feature_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FeatureOrder)
                    .HasColumnName("feature_order")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FeatureTimestamp)
                    .HasColumnName("feature_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ListingId)
                    .IsRequired()
                    .HasColumnName("listing_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ListingTypeId)
                    .HasColumnName("listing_type_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("6");

                entity.Property(e => e.OrgId)
                    .IsRequired()
                    .HasColumnName("org_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ApiKeys>(entity =>
            {
                entity.HasKey(e => e.KeyId);

                entity.ToTable("api_keys", "rezoradata");

                entity.HasIndex(e => e.KeyUsername)
                    .HasName("key_username")
                    .IsUnique();

                entity.HasIndex(e => e.KeyValue)
                    .HasName("key_value");

                entity.HasIndex(e => e.RequesterId)
                    .HasName("requester_id");

                entity.HasIndex(e => e.RequesterType)
                    .HasName("requester_type");

                entity.Property(e => e.KeyId)
                    .HasColumnName("key_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.KeyUsername)
                    .IsRequired()
                    .HasColumnName("key_username")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.KeyValue)
                    .IsRequired()
                    .HasColumnName("key_value")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RequesterId)
                    .HasColumnName("requester_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RequesterType)
                    .IsRequired()
                    .HasColumnName("requester_type")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ApiLog>(entity =>
            {
                entity.HasKey(e => e.RequestId);

                entity.ToTable("api_log", "rezoradata");

                entity.HasIndex(e => e.RequesterId)
                    .HasName("brokerage_id");

                entity.Property(e => e.RequestId)
                    .HasColumnName("request_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RequestMethod)
                    .IsRequired()
                    .HasColumnName("request_method")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RequestTimestamp)
                    .HasColumnName("request_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.RequestType)
                    .IsRequired()
                    .HasColumnName("request_type")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RequesterId)
                    .HasColumnName("requester_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RequesterType)
                    .IsRequired()
                    .HasColumnName("requester_type")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseFormat)
                    .IsRequired()
                    .HasColumnName("response_format")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseStatus)
                    .HasColumnName("response_status")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<BetaFeatures>(entity =>
            {
                entity.HasKey(e => e.BetaFeatureId);

                entity.ToTable("beta_features", "rezoradata");

                entity.Property(e => e.BetaFeatureId)
                    .HasColumnName("beta_feature_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.BrokerageId)
                    .HasColumnName("brokerage_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FeatureId)
                    .HasColumnName("feature_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<BetaFeaturesDesc>(entity =>
            {
                entity.ToTable("beta_features_desc", "rezoradata");

                entity.HasIndex(e => e.Description)
                    .HasName("idx_description")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BrandFonts>(entity =>
            {
                entity.ToTable("brand_fonts", "rezoradata");

                entity.HasIndex(e => e.BrandId)
                    .HasName("brand_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.BrandId)
                    .HasColumnName("brand_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Font)
                    .IsRequired()
                    .HasColumnName("font")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.BrandFonts)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("brand_id");
            });

            modelBuilder.Entity<Brands>(entity =>
            {
                entity.HasKey(e => e.BrandId);

                entity.ToTable("brands", "rezoradata");

                entity.Property(e => e.BrandId)
                    .HasColumnName("brand_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BrandIsXd)
                    .HasColumnName("brand_is_xd")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BrandName)
                    .IsRequired()
                    .HasColumnName("brand_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BrandTimestamp)
                    .HasColumnName("brand_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<BrokerageAgentAudience>(entity =>
            {
                entity.ToTable("brokerage_agent_audience", "rezoradata");

                entity.Property(e => e.BrokerageAgentAudienceId)
                    .HasColumnName("brokerage_agent_audience_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.BrokerageId)
                    .HasColumnName("brokerage_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.DisplayAds)
                    .HasColumnName("display_ads")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SitescoutAudienceId)
                    .HasColumnName("sitescout_audience_id")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.SitescoutAudienceTag)
                    .HasColumnName("sitescout_audience_tag")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubscriptionEnabled)
                    .HasColumnName("subscription_enabled")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<BrokerageAgentCampaigns>(entity =>
            {
                entity.HasKey(e => e.BrokerageSitescoutCampaignId);

                entity.ToTable("brokerage_agent_campaigns", "rezoradata");

                entity.HasIndex(e => e.BrokerageId)
                    .HasName("user_id_2");

                entity.Property(e => e.BrokerageSitescoutCampaignId)
                    .HasColumnName("brokerage_sitescout_campaign_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.BrokerageId)
                    .HasColumnName("brokerage_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CampaignEnabled)
                    .HasColumnName("campaign_enabled")
                    .HasColumnType("int(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CampaignName)
                    .HasColumnName("campaign_name")
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasDefaultValueSql("Campaign");

                entity.Property(e => e.CampaignUrl)
                    .HasColumnName("campaign_url")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultCampaign)
                    .HasColumnName("default_campaign")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DisplayAds)
                    .IsRequired()
                    .HasColumnName("display_ads")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SitescoutCampaignId)
                    .HasColumnName("sitescout_campaign_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<BrokerageCampaign>(entity =>
            {
                entity.ToTable("brokerage_campaign", "rezoradata");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Agents)
                    .HasColumnName("agents")
                    .HasColumnType("blob");

                entity.Property(e => e.BrokerageId)
                    .HasColumnName("brokerage_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CampaignEnabled)
                    .HasColumnName("campaign_enabled")
                    .HasColumnType("int(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CampaignName)
                    .HasColumnName("campaign_name")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignUrl)
                    .HasColumnName("campaign_url")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultCampaign)
                    .HasColumnName("default_campaign")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DisplayAds)
                    .HasColumnName("display_ads")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessedCampaigns)
                    .HasColumnName("processed_campaigns")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TotalCampaigns)
                    .HasColumnName("total_campaigns")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<BrokerageFonts>(entity =>
            {
                entity.ToTable("brokerage_fonts", "rezoradata");

                entity.HasIndex(e => e.BrokerageId)
                    .HasName("brokerage_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.BrokerageId)
                    .HasColumnName("brokerage_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Font)
                    .HasColumnName("font")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.HasOne(d => d.Brokerage)
                    .WithMany(p => p.BrokerageFonts)
                    .HasForeignKey(d => d.BrokerageId)
                    .HasConstraintName("brokerage_id");
            });

            modelBuilder.Entity<Brokerages>(entity =>
            {
                entity.HasKey(e => e.BrokerageId);

                entity.ToTable("brokerages", "rezoradata");

                entity.HasIndex(e => e.BrandId)
                    .HasName("brand_id");

                entity.HasIndex(e => e.BrokerageRestrictNewsletters)
                    .HasName("brokerage_restrict_newsletters");

                entity.HasIndex(e => e.BrokerageUrl)
                    .HasName("brokerage_url");

                entity.HasIndex(e => e.FullProductId)
                    .HasName("full_product_id");

                entity.HasIndex(e => e.ManagerId)
                    .HasName("manager_id");

                entity.HasIndex(e => e.StatusId)
                    .HasName("status_id");

                entity.Property(e => e.BrokerageId)
                    .HasColumnName("brokerage_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AnnualProductId)
                    .HasColumnName("annual_product_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BillCc)
                    .HasColumnName("bill_cc")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BillingContactEmail)
                    .HasColumnName("billing_contact_email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillingPeriod)
                    .IsRequired()
                    .HasColumnName("billing_period")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("Quarterly");

                entity.Property(e => e.BillingPlan)
                    .IsRequired()
                    .HasColumnName("billing_plan")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("Enhanced");

                entity.Property(e => e.BillingTermDiscount)
                    .HasColumnName("billing_term_discount")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BrandId)
                    .HasColumnName("brand_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BrokerageAddressCanspam)
                    .IsRequired()
                    .HasColumnName("brokerage_address_canspam")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.BrokerageAdminPrice).HasColumnName("brokerage_admin_price");

                entity.Property(e => e.BrokerageAdminPriceDiscount)
                    .HasColumnName("brokerage_admin_price_discount")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BrokerageAdminPriceDiscountExpires).HasColumnName("brokerage_admin_price_discount_expires");

                entity.Property(e => e.BrokerageAllowCampaigns)
                    .HasColumnName("brokerage_allow_campaigns")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.BrokerageAllowCobrand)
                    .HasColumnName("brokerage_allow_cobrand")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BrokerageAllowEnhancedContacts)
                    .HasColumnName("brokerage_allow_enhanced_contacts")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BrokerageAllowPrint)
                    .HasColumnName("brokerage_allow_print")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.BrokerageAllowProducts)
                    .HasColumnName("brokerage_allow_products")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BrokerageAllowServiceProviders)
                    .HasColumnName("brokerage_allow_service_providers")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BrokerageAltSignupUrl)
                    .IsRequired()
                    .HasColumnName("brokerage_alt_signup_url")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.BrokerageBasePrice)
                    .HasColumnName("brokerage_base_price")
                    .HasDefaultValueSql("12.5");

                entity.Property(e => e.BrokerageCloudspongeKey)
                    .IsRequired()
                    .HasColumnName("brokerage_cloudsponge_key")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("4888UXVEBEPP2ZS83MCE");

                entity.Property(e => e.BrokerageCompanyId)
                    .IsRequired()
                    .HasColumnName("brokerage_company_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BrokerageCountyPrice)
                    .HasColumnName("brokerage_county_price")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BrokerageDaylightsavings)
                    .HasColumnName("brokerage_daylightsavings")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.BrokerageDisclaimer)
                    .IsRequired()
                    .HasColumnName("brokerage_disclaimer")
                    .IsUnicode(false);

                entity.Property(e => e.BrokerageEffectiveDate)
                    .HasColumnName("brokerage_effective_date")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.BrokerageEmailPrice)
                    .HasColumnName("brokerage_email_price")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BrokerageExternalWebsite)
                    .HasColumnName("brokerage_external_website")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BrokerageFacebookAppId)
                    .IsRequired()
                    .HasColumnName("brokerage_facebook_app_id")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("506300836184540");

                entity.Property(e => e.BrokerageFacebookKey)
                    .IsRequired()
                    .HasColumnName("brokerage_facebook_key")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BrokerageHiresImages)
                    .HasColumnName("brokerage_hires_images")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BrokerageHiresPrice)
                    .HasColumnName("brokerage_hires_price")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BrokerageIndustry)
                    .HasColumnName("brokerage_industry")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("66");

                entity.Property(e => e.BrokerageLanguage)
                    .IsRequired()
                    .HasColumnName("brokerage_language")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("eng");

                entity.Property(e => e.BrokerageListingLink)
                    .IsRequired()
                    .HasColumnName("brokerage_listing_link")
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasDefaultValueSql("##BASEPATH##/listingsearch_details.php?nid=##NEWSLETTERID##&cid=##CONTACTID##&oid=##ORGID##&lid=##LISTINGID##&tid=##LISTINGTYPE##");

                entity.Property(e => e.BrokerageMattColors)
                    .IsRequired()
                    .HasColumnName("brokerage_matt_colors")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("#000000,#666666,#999999,#CCCCCC,#FFFFFF");

                entity.Property(e => e.BrokerageMinimumUsers)
                    .HasColumnName("brokerage_minimum_users")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BrokerageMlsPrice)
                    .HasColumnName("brokerage_mls_price")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BrokerageName)
                    .IsRequired()
                    .HasColumnName("brokerage_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BrokeragePayCommission)
                    .HasColumnName("brokerage_pay_commission")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.BrokeragePaySupport)
                    .HasColumnName("brokerage_pay_support")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.BrokeragePhoneSupport)
                    .HasColumnName("brokerage_phone_support")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BrokerageProdLink)
                    .IsRequired()
                    .HasColumnName("brokerage_prod_link")
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasDefaultValueSql("##BASEPATH##/prodsearch_details.php?nid=##NEWSLETTERID##&cid=##CONTACTID##&prid=##PRODID##");

                entity.Property(e => e.BrokerageReportsAdvertise)
                    .HasColumnName("brokerage_reports_advertise")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BrokerageReportsOption)
                    .HasColumnName("brokerage_reports_option")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BrokerageRequireGroups)
                    .HasColumnName("brokerage_require_groups")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BrokerageRestrictNewsletters)
                    .HasColumnName("brokerage_restrict_newsletters")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BrokerageRetargetingEnabled)
                    .HasColumnName("brokerage_retargeting_enabled")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BrokerageSsoCertificate)
                    .IsRequired()
                    .HasColumnName("brokerage_sso_certificate")
                    .IsUnicode(false);

                entity.Property(e => e.BrokerageSsoRequestUrl)
                    .IsRequired()
                    .HasColumnName("brokerage_sso_request_url")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.BrokerageSsoRequired)
                    .HasColumnName("brokerage_sso_required")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.BrokerageSsoType)
                    .IsRequired()
                    .HasColumnName("brokerage_sso_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BrokerageStartBilling)
                    .HasColumnName("brokerage_start_billing")
                    .HasColumnType("date");

                entity.Property(e => e.BrokerageTheme)
                    .IsRequired()
                    .HasColumnName("brokerage_theme")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BrokerageThemeUseCustomLogo)
                    .HasColumnName("brokerage_theme_use_custom_logo")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BrokerageThemeUseDefaults)
                    .HasColumnName("brokerage_theme_use_defaults")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.BrokerageTimestamp)
                    .HasColumnName("brokerage_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.BrokerageTimezoneName)
                    .HasColumnName("brokerage_timezone_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BrokerageTimezoneOffset)
                    .HasColumnName("brokerage_timezone_offset")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BrokerageType)
                    .HasColumnName("brokerage_type")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.BrokerageUrl)
                    .IsRequired()
                    .HasColumnName("brokerage_url")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BrokerageUseCustomListingLinks)
                    .HasColumnName("brokerage_use_custom_listing_links")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.BrokerageUseCustomListingLinksAlt)
                    .HasColumnName("brokerage_use_custom_listing_links_alt")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.BrokerageUseDre)
                    .HasColumnName("brokerage_use_dre")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.BrokerageUseObservers)
                    .HasColumnName("brokerage_use_observers")
                    .HasColumnType("tinyint(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BrokerageUserLogoPath)
                    .IsRequired()
                    .HasColumnName("brokerage_user_logo_path")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BrokerageUserPrice).HasColumnName("brokerage_user_price");

                entity.Property(e => e.BrokerageUserPriceDiscount)
                    .HasColumnName("brokerage_user_price_discount")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BrokerageUserPriceDiscountExpires).HasColumnName("brokerage_user_price_discount_expires");

                entity.Property(e => e.BrokerageVimeoAlbum)
                    .IsRequired()
                    .HasColumnName("brokerage_vimeo_album")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("194722");

                entity.Property(e => e.BrokerageWhiteLabel)
                    .HasColumnName("brokerage_white_label")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.BrokerageWhiteLabelDisplayads)
                    .HasColumnName("brokerage_white_label_displayads")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BrokerageZendeskOrgid)
                    .HasColumnName("brokerage_zendesk_orgid")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("90991");

                entity.Property(e => e.CcOnFile)
                    .HasColumnName("cc_on_file")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FullProductId)
                    .HasColumnName("full_product_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ManagerId)
                    .HasColumnName("manager_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OnlyAgentsOwnListings)
                    .HasColumnName("only_agents_own_listings")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.PaymentModel)
                    .HasColumnName("payment_model")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.RequireSubscriptionAssignment)
                    .HasColumnName("require_subscription_assignment")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.SendgridPassword)
                    .IsRequired()
                    .HasColumnName("sendgrid_password")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("r3z0r45MTP");

                entity.Property(e => e.SendgridUsername)
                    .IsRequired()
                    .HasColumnName("sendgrid_username")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("sendgrid@rezora.com");

                entity.Property(e => e.StatusId)
                    .HasColumnName("status_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TrialProductId)
                    .HasColumnName("trial_product_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UseAltCompLogoPath)
                    .HasColumnName("use_alt_comp_logo_path")
                    .HasColumnType("tinyint(4)");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Brokerages)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("brokerages_ibfk_1");
            });

            modelBuilder.Entity<BrokeragesFeaturedListings>(entity =>
            {
                entity.HasKey(e => e.FeatureId);

                entity.ToTable("brokerages_featured_listings", "rezoradata");

                entity.HasIndex(e => e.BrokerageId)
                    .HasName("brokerage_id");

                entity.Property(e => e.FeatureId)
                    .HasColumnName("feature_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BrokerageId)
                    .HasColumnName("brokerage_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FeatureOrder)
                    .HasColumnName("feature_order")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FeatureTimestamp)
                    .HasColumnName("feature_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ListingId)
                    .IsRequired()
                    .HasColumnName("listing_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ListingTypeId)
                    .HasColumnName("listing_type_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("6");

                entity.Property(e => e.OrgId)
                    .IsRequired()
                    .HasColumnName("org_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Brokerage)
                    .WithMany(p => p.BrokeragesFeaturedListings)
                    .HasForeignKey(d => d.BrokerageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("brokerages_featured_listings_ibfk_1");
            });

            modelBuilder.Entity<BrokeragesIndustry>(entity =>
            {
                entity.HasKey(e => e.IndustryId);

                entity.ToTable("brokerages_industry", "rezoradata");

                entity.Property(e => e.IndustryId)
                    .HasColumnName("industry_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IndustryName)
                    .IsRequired()
                    .HasColumnName("industry_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BrokeragesLocations>(entity =>
            {
                entity.HasKey(e => e.LocationId);

                entity.ToTable("brokerages_locations", "rezoradata");

                entity.HasIndex(e => e.BrokerageId)
                    .HasName("brokerage_id");

                entity.Property(e => e.LocationId)
                    .HasColumnName("location_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BrokerageId)
                    .HasColumnName("brokerage_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LocationCity)
                    .IsRequired()
                    .HasColumnName("location_city")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LocationState)
                    .IsRequired()
                    .HasColumnName("location_state")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LocationTimestamp)
                    .HasColumnName("location_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.HasOne(d => d.Brokerage)
                    .WithMany(p => p.BrokeragesLocations)
                    .HasForeignKey(d => d.BrokerageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("brokerages_locations_ibfk_1");
            });

            modelBuilder.Entity<BrokeragesRssCustom>(entity =>
            {
                entity.HasKey(e => e.FeedId);

                entity.ToTable("brokerages_rss_custom", "rezoradata");

                entity.Property(e => e.FeedId)
                    .HasColumnName("feed_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BrokerageId)
                    .HasColumnName("brokerage_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FeedTimestamp)
                    .HasColumnName("feed_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.FeedTitle)
                    .IsRequired()
                    .HasColumnName("feed_title")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FeedUrl)
                    .IsRequired()
                    .HasColumnName("feed_url")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BrokeragesRssNational>(entity =>
            {
                entity.HasKey(e => e.RssId);

                entity.ToTable("brokerages_rss_national", "rezoradata");

                entity.Property(e => e.RssId)
                    .HasColumnName("rss_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RssSource)
                    .IsRequired()
                    .HasColumnName("rss_source")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RssTitle)
                    .IsRequired()
                    .HasColumnName("rss_title")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RssUrl)
                    .IsRequired()
                    .HasColumnName("rss_url")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BrokeragesSchedulePermissionLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("brokerages_schedule_permission_log", "rezoradata");

                entity.HasIndex(e => e.BrokerageId)
                    .HasName("brokerage_id");

                entity.Property(e => e.LogId)
                    .HasColumnName("log_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.BrokerageId)
                    .HasColumnName("brokerage_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LogTimestamp)
                    .HasColumnName("log_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ScheduleAllowed)
                    .HasColumnName("schedule_allowed")
                    .HasColumnType("int(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<BrokeragesStatuses>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("brokerages_statuses", "rezoradata");

                entity.Property(e => e.StatusId)
                    .HasColumnName("status_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasColumnName("status_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BrokeragesSubscriptionsLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("brokerages_subscriptions_log", "rezoradata");

                entity.Property(e => e.LogId)
                    .HasColumnName("log_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.BrokerageId)
                    .HasColumnName("brokerage_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LogTimestamp)
                    .HasColumnName("log_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.LogType)
                    .IsRequired()
                    .HasColumnName("log_type")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Subscriptions)
                    .HasColumnName("subscriptions")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<BrokeragesToElements>(entity =>
            {
                entity.HasKey(e => e.Brokeragestoelements1);

                entity.ToTable("brokerages_to_elements", "rezoradata");

                entity.HasIndex(e => e.ElementTypeId)
                    .HasName("idx_element_type_id");

                entity.HasIndex(e => new { e.BrokerageId, e.ElementActive })
                    .HasName("idx_brokerage_id_element_active");

                entity.Property(e => e.Brokeragestoelements1)
                    .HasColumnName("brokeragestoelements")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BrokerageId)
                    .HasColumnName("brokerage_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ElementActive)
                    .HasColumnName("element_active")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ElementLastImport).HasColumnName("element_last_import");

                entity.Property(e => e.ElementRestricted)
                    .HasColumnName("element_restricted")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ElementTypeId)
                    .HasColumnName("element_type_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasColumnName("token")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BrokeragesToRssNational>(entity =>
            {
                entity.HasKey(e => e.BrokeragetorssId);

                entity.ToTable("brokerages_to_rss_national", "rezoradata");

                entity.Property(e => e.BrokeragetorssId)
                    .HasColumnName("brokeragetorss_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BrokerageId)
                    .HasColumnName("brokerage_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BrokeragetorssTimestamp)
                    .HasColumnName("brokeragetorss_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.RssId)
                    .HasColumnName("rss_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<BrokeragesTypes>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.ToTable("brokerages_types", "rezoradata");

                entity.Property(e => e.TypeId)
                    .HasColumnName("type_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasColumnName("type_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BrokeragesUnsubscribes>(entity =>
            {
                entity.ToTable("brokerages_unsubscribes", "rezoradata");

                entity.Property(e => e.BrokeragesUnsubscribesId)
                    .HasColumnName("brokerages_unsubscribes_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.BrokerageId)
                    .HasColumnName("brokerage_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BrokeragesUnsubscribesTime)
                    .HasColumnName("brokerages_unsubscribes_time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ContactEmail)
                    .IsRequired()
                    .HasColumnName("contact_email")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Campaigns>(entity =>
            {
                entity.HasKey(e => e.CampaignId);

                entity.ToTable("campaigns", "rezoradata");

                entity.HasIndex(e => e.BrokerageId)
                    .HasName("brokerage_id");

                entity.HasIndex(e => e.CampaignRestricted)
                    .HasName("campaign_restricted");

                entity.HasIndex(e => e.CampaignStartdate)
                    .HasName("campaign_startdate");

                entity.HasIndex(e => e.CampaignStopdate)
                    .HasName("campaign_stopdate");

                entity.HasIndex(e => e.MasterId)
                    .HasName("master_id");

                entity.Property(e => e.CampaignId)
                    .HasColumnName("campaign_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BrokerageId)
                    .HasColumnName("brokerage_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CampaignDescription)
                    .IsRequired()
                    .HasColumnName("campaign_description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignDetails)
                    .IsRequired()
                    .HasColumnName("campaign_details")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignPhoto)
                    .IsRequired()
                    .HasColumnName("campaign_photo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignRestricted)
                    .HasColumnName("campaign_restricted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CampaignStartdate).HasColumnName("campaign_startdate");

                entity.Property(e => e.CampaignStopdate).HasColumnName("campaign_stopdate");

                entity.Property(e => e.CampaignTimestamp)
                    .HasColumnName("campaign_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CampaignTitle)
                    .IsRequired()
                    .HasColumnName("campaign_title")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MasterId)
                    .HasColumnName("master_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CampaignsToUsers>(entity =>
            {
                entity.HasKey(e => e.CampaigntouserId);

                entity.ToTable("campaigns_to_users", "rezoradata");

                entity.HasIndex(e => new { e.CampaignId, e.UserId })
                    .HasName("campaign_id")
                    .IsUnique();

                entity.Property(e => e.CampaigntouserId)
                    .HasColumnName("campaigntouser_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CampaignId)
                    .HasColumnName("campaign_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CampaigntouserTimestamp)
                    .HasColumnName("campaigntouser_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<CloudelementsContacts>(entity =>
            {
                entity.HasKey(e => new { e.CeContactEmail, e.CeContactBrokeragestoelements, e.CeContactStatus });

                entity.ToTable("cloudelements_contacts", "rezoradata");

                entity.HasIndex(e => e.CeContactBrokeragestoelements)
                    .HasName("ce_contact_brokeragestoelements");

                entity.HasIndex(e => e.CeContactCrmId)
                    .HasName("ce_contact_crm_id");

                entity.HasIndex(e => e.CeContactEmail)
                    .HasName("ce_contact_email");

                entity.Property(e => e.CeContactEmail)
                    .HasColumnName("ce_contact_email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CeContactBrokeragestoelements)
                    .HasColumnName("ce_contact_brokeragestoelements")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CeContactStatus)
                    .HasColumnName("ce_contact_status")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CeContactBusinessCity)
                    .HasColumnName("ce_contact_business_city")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CeContactBusinessState)
                    .HasColumnName("ce_contact_business_state")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CeContactBusinessStreet)
                    .HasColumnName("ce_contact_business_street")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CeContactBusinessStreet2)
                    .HasColumnName("ce_contact_business_street2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CeContactBusinessZip)
                    .HasColumnName("ce_contact_business_zip")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CeContactCompany)
                    .HasColumnName("ce_contact_company")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CeContactCrmAccountId)
                    .HasColumnName("ce_contact_crm_account_id")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CeContactCrmId)
                    .IsRequired()
                    .HasColumnName("ce_contact_crm_id")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CeContactCrmOwnerId)
                    .HasColumnName("ce_contact_crm_owner_id")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CeContactCrmType)
                    .HasColumnName("ce_contact_crm_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CeContactDate)
                    .HasColumnName("ce_contact_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CeContactHomeCity)
                    .HasColumnName("ce_contact_home_city")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CeContactHomeState)
                    .HasColumnName("ce_contact_home_state")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CeContactHomeStreet)
                    .HasColumnName("ce_contact_home_street")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CeContactHomeStreet2)
                    .HasColumnName("ce_contact_home_street2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CeContactHomeZip)
                    .HasColumnName("ce_contact_home_zip")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CeContactName)
                    .HasColumnName("ce_contact_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CeContactPhoneFax)
                    .HasColumnName("ce_contact_phone_fax")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CeContactPhoneHome)
                    .HasColumnName("ce_contact_phone_home")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CeContactPhoneMobile)
                    .HasColumnName("ce_contact_phone_mobile")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CeContactPhoneWork)
                    .HasColumnName("ce_contact_phone_work")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CeContactTitle)
                    .HasColumnName("ce_contact_title")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CeContactUnsubscribe)
                    .HasColumnName("ce_contact_unsubscribe")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CloudelementsLog>(entity =>
            {
                entity.HasKey(e => e.RequestId);

                entity.ToTable("cloudelements_log", "rezoradata");

                entity.Property(e => e.RequestId)
                    .HasColumnName("request_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RequestMethod)
                    .IsRequired()
                    .HasColumnName("request_method")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RequestTimestamp)
                    .HasColumnName("request_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.RequestType)
                    .IsRequired()
                    .HasColumnName("request_type")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.RequesterId)
                    .HasColumnName("requester_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ResponseFormat)
                    .IsRequired()
                    .HasColumnName("response_format")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseStatus)
                    .IsRequired()
                    .HasColumnName("response_status")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CloudelementsUsersToAccounts>(entity =>
            {
                entity.HasKey(e => e.ElementUsertoaccountId);

                entity.ToTable("cloudelements_users_to_accounts", "rezoradata");

                entity.HasIndex(e => new { e.UserId, e.ElementCrmAccId })
                    .HasName("user_id");

                entity.Property(e => e.ElementUsertoaccountId)
                    .HasColumnName("element_usertoaccount_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.ElementCrmAccId)
                    .IsRequired()
                    .HasColumnName("element_crm_acc_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ElementCrmAccName)
                    .HasColumnName("element_crm_acc_name")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.ElementId)
                    .HasColumnName("element_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ElementUsertoaccountTimestamp)
                    .HasColumnName("element_usertoaccount_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<CloudelementsUsersToCampaigns>(entity =>
            {
                entity.HasKey(e => e.ElementUsertocampaignId);

                entity.ToTable("cloudelements_users_to_campaigns", "rezoradata");

                entity.HasIndex(e => new { e.UserId, e.ElementCrmCamId })
                    .HasName("user_id");

                entity.Property(e => e.ElementUsertocampaignId)
                    .HasColumnName("element_usertocampaign_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.ElementCrmCamId)
                    .IsRequired()
                    .HasColumnName("element_crm_cam_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ElementCrmCamName)
                    .HasColumnName("element_crm_cam_name")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.ElementId)
                    .HasColumnName("element_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ElementUsertocampaignTimestamp)
                    .HasColumnName("element_usertocampaign_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ContactImportRequest>(entity =>
            {
                entity.HasKey(e => e.RequestId);

                entity.ToTable("contact_import_request", "rezoradata");

                entity.Property(e => e.RequestId)
                    .HasColumnName("request_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AutoSync)
                    .HasColumnName("auto_sync")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BouncesFailed)
                    .HasColumnName("bounces_failed")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CompletedOn).HasColumnName("completed_on");

                entity.Property(e => e.ContactExists)
                    .HasColumnName("contact_exists")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContactsTested)
                    .HasColumnName("contacts_tested")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContactsVerified).HasColumnName("contacts_verified");

                entity.Property(e => e.ImportType)
                    .HasColumnName("import_type")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MissingEmail)
                    .HasColumnName("missing_email")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Overwrite)
                    .HasColumnName("overwrite")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PurgeFailed)
                    .HasColumnName("purge_failed")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RequestMeta)
                    .HasColumnName("request_meta")
                    .IsUnicode(false);

                entity.Property(e => e.RequestedOn)
                    .HasColumnName("requested_on")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.SpamreportFailed)
                    .HasColumnName("spamreport_failed")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SyntaxFailed)
                    .HasColumnName("syntax_failed")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TotalDelivered)
                    .HasColumnName("total_delivered")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TotalFailed)
                    .HasColumnName("total_failed")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TotalToDeliver)
                    .HasColumnName("total_to_deliver")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UnsubFailed)
                    .HasColumnName("unsub_failed")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Contacts>(entity =>
            {
                entity.HasKey(e => e.ContactId);

                entity.ToTable("contacts", "rezoradata");

                entity.HasIndex(e => e.ContactCrmAccountId)
                    .HasName("contact_crm_account_id");

                entity.HasIndex(e => e.ContactEmail)
                    .HasName("contact_email");

                entity.HasIndex(e => e.ContactSelf)
                    .HasName("contact_self");

                entity.HasIndex(e => e.ContactUnsubscribe)
                    .HasName("contact_unsubscribe");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.HasIndex(e => new { e.MclId, e.ContactCrmId })
                    .HasName("mcl_id");

                entity.HasIndex(e => new { e.UserId, e.ContactDeleted, e.ContactUnsubscribe })
                    .HasName("user_id_2");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BounceScore).HasColumnName("bounce_score");

                entity.Property(e => e.ClickScore).HasColumnName("click_score");

                entity.Property(e => e.ContactBusinessCity)
                    .HasColumnName("contact_business_city")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactBusinessState)
                    .HasColumnName("contact_business_state")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactBusinessStreet)
                    .HasColumnName("contact_business_street")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactBusinessStreet2)
                    .HasColumnName("contact_business_street2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactBusinessZip)
                    .HasColumnName("contact_business_zip")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ContactCompany)
                    .HasColumnName("contact_company")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactCrmAccountId)
                    .IsRequired()
                    .HasColumnName("contact_crm_account_id")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactCrmId)
                    .IsRequired()
                    .HasColumnName("contact_crm_id")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactCrmOwnerId)
                    .IsRequired()
                    .HasColumnName("contact_crm_owner_id")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactDate)
                    .HasColumnName("contact_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ContactDeleted)
                    .HasColumnName("contact_deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContactEditedDate)
                    .HasColumnName("contact_edited_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ContactEmail)
                    .IsRequired()
                    .HasColumnName("contact_email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactHomeCity)
                    .HasColumnName("contact_home_city")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactHomeState)
                    .HasColumnName("contact_home_state")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactHomeStreet)
                    .HasColumnName("contact_home_street")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactHomeStreet2)
                    .HasColumnName("contact_home_street2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactHomeZip)
                    .HasColumnName("contact_home_zip")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPhoneFax)
                    .HasColumnName("contact_phone_fax")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPhoneHome)
                    .HasColumnName("contact_phone_home")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPhoneMobile)
                    .HasColumnName("contact_phone_mobile")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPhoneWork)
                    .HasColumnName("contact_phone_work")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ContactSelf)
                    .HasColumnName("contact_self")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContactTitle)
                    .HasColumnName("contact_title")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactType)
                    .IsRequired()
                    .HasColumnName("contact_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ContactUnsubscribe)
                    .HasColumnName("contact_unsubscribe")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContactUpdating)
                    .HasColumnName("contact_updating")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContactVerifiedTimestamp).HasColumnName("contact_verified_timestamp");

                entity.Property(e => e.DetailsScore).HasColumnName("details_score");

                entity.Property(e => e.ElementId)
                    .HasColumnName("element_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EmailCount)
                    .HasColumnName("email_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LastScored)
                    .HasColumnName("last_scored")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MclId)
                    .HasColumnName("mcl_id")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OpenScore).HasColumnName("open_score");

                entity.Property(e => e.OptinFirst).HasColumnName("optin_first");

                entity.Property(e => e.OptinSecond).HasColumnName("optin_second");

                entity.Property(e => e.SearchScore).HasColumnName("search_score");

                entity.Property(e => e.SourceId)
                    .HasColumnName("source_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.SpamScore).HasColumnName("spam_score");

                entity.Property(e => e.UnsubscribeScore).HasColumnName("unsubscribe_score");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("contacts_ibfk_1");
            });

            modelBuilder.Entity<ContactsActivities>(entity =>
            {
                entity.HasKey(e => e.ActivityId);

                entity.ToTable("contacts_activities", "rezoradata");

                entity.HasIndex(e => e.ActivityListingId)
                    .HasName("activity_listing_id");

                entity.HasIndex(e => e.ActivityOrgId)
                    .HasName("activity_org_id");

                entity.HasIndex(e => e.ActivityTimestamp)
                    .HasName("activity_timestamp");

                entity.HasIndex(e => e.ActivityType)
                    .HasName("activity_type");

                entity.HasIndex(e => e.ContactId)
                    .HasName("contact_id");

                entity.HasIndex(e => e.ListingTypeId)
                    .HasName("listing_type_id");

                entity.HasIndex(e => e.NewsletterId)
                    .HasName("newsletter_id");

                entity.HasIndex(e => new { e.ActivityOrgId, e.ActivityListingId, e.ActivityType, e.ActivityTimestamp })
                    .HasName("activity_type_2");

                entity.Property(e => e.ActivityId)
                    .HasColumnName("activity_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActivityListingId)
                    .HasColumnName("activity_listing_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.ActivityOrgId)
                    .HasColumnName("activity_org_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ActivitySearchBathsMin)
                    .HasColumnName("activity_search_baths_min")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActivitySearchBedsMin)
                    .HasColumnName("activity_search_beds_min")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActivitySearchListingTypeId)
                    .HasColumnName("activity_search_listing_type_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActivitySearchListingid)
                    .HasColumnName("activity_search_listingid")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.ActivitySearchLocation)
                    .HasColumnName("activity_search_location")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ActivitySearchPage)
                    .HasColumnName("activity_search_page")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActivitySearchPriceMax)
                    .HasColumnName("activity_search_price_max")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActivitySearchPriceMin)
                    .HasColumnName("activity_search_price_min")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActivitySource)
                    .HasColumnName("activity_source")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ActivityTimestamp)
                    .HasColumnName("activity_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ActivityType)
                    .IsRequired()
                    .HasColumnName("activity_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ListingTypeId)
                    .HasColumnName("listing_type_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NewsletterId)
                    .HasColumnName("newsletter_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProdId)
                    .HasColumnName("prod_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.ContactsActivities)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("contacts_activities_ibfk_1");

                entity.HasOne(d => d.Newsletter)
                    .WithMany(p => p.ContactsActivities)
                    .HasForeignKey(d => d.NewsletterId)
                    .HasConstraintName("contacts_activities_ibfk_2");
            });

            modelBuilder.Entity<ContactsEnhanced>(entity =>
            {
                entity.HasKey(e => e.ContactEmail);

                entity.ToTable("contacts_enhanced", "rezoradata");

                entity.HasIndex(e => new { e.ResultsPremium, e.LastUpdated })
                    .HasName("results_premium");

                entity.Property(e => e.ContactEmail)
                    .HasColumnName("contact_email")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Age)
                    .HasColumnName("age")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Children)
                    .HasColumnName("children")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Education)
                    .HasColumnName("education")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ErrorMessage)
                    .HasColumnName("error_message")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.HighNetWorth)
                    .HasColumnName("high_net_worth")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.HomeMarketValue)
                    .HasColumnName("home_market_value")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.HomeOwnerStatus)
                    .HasColumnName("home_owner_status")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.HouseholdIncome)
                    .HasColumnName("household_income")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdated)
                    .HasColumnName("last_updated")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.LengthOfResidence)
                    .HasColumnName("length_of_residence")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MaritalStatus)
                    .HasColumnName("marital_status")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Occupation)
                    .HasColumnName("occupation")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ResultsPremium)
                    .HasColumnName("results_premium")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ContactsFull>(entity =>
            {
                entity.HasKey(e => e.ContactId);

                entity.ToTable("contacts_full", "rezoradata");

                entity.HasIndex(e => new { e.UserId, e.FullTimestamp })
                    .HasName("user_id");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.FullData)
                    .IsRequired()
                    .HasColumnName("full_data")
                    .IsUnicode(false);

                entity.Property(e => e.FullTimestamp)
                    .HasColumnName("full_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ContactsFullRequests>(entity =>
            {
                entity.HasKey(e => e.RequestHash);

                entity.ToTable("contacts_full_requests", "rezoradata");

                entity.Property(e => e.RequestHash)
                    .HasColumnName("request_hash")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RequestStatus)
                    .HasColumnName("request_status")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RequestTimeRequest)
                    .HasColumnName("request_time_request")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.RequestTimeResponse)
                    .HasColumnName("request_time_response")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ContactsHolder>(entity =>
            {
                entity.HasKey(e => e.ContactId);

                entity.ToTable("contacts_holder", "rezoradata");

                entity.HasIndex(e => e.ContactCrmId)
                    .HasName("contact_crm_id");

                entity.HasIndex(e => e.ContactEmail)
                    .HasName("contact_email");

                entity.HasIndex(e => e.ContactTimestamp)
                    .HasName("contact_timestamp");

                entity.HasIndex(e => e.SessionId)
                    .HasName("session_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContactBusinessCity)
                    .HasColumnName("contact_business_city")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactBusinessState)
                    .HasColumnName("contact_business_state")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactBusinessStreet)
                    .HasColumnName("contact_business_street")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactBusinessStreet2)
                    .HasColumnName("contact_business_street2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactBusinessZip)
                    .HasColumnName("contact_business_zip")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ContactCompany)
                    .HasColumnName("contact_company")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactCrmAccountId)
                    .IsRequired()
                    .HasColumnName("contact_crm_account_id")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactCrmId)
                    .IsRequired()
                    .HasColumnName("contact_crm_id")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactCrmOwnerId)
                    .IsRequired()
                    .HasColumnName("contact_crm_owner_id")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactCrmType)
                    .IsRequired()
                    .HasColumnName("contact_crm_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ContactEmail)
                    .IsRequired()
                    .HasColumnName("contact_email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactHomeCity)
                    .HasColumnName("contact_home_city")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactHomeState)
                    .HasColumnName("contact_home_state")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactHomeStreet)
                    .HasColumnName("contact_home_street")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactHomeStreet2)
                    .HasColumnName("contact_home_street2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactHomeZip)
                    .HasColumnName("contact_home_zip")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPhoneFax)
                    .HasColumnName("contact_phone_fax")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPhoneHome)
                    .HasColumnName("contact_phone_home")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPhoneMobile)
                    .HasColumnName("contact_phone_mobile")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPhoneWork)
                    .HasColumnName("contact_phone_work")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTimestamp)
                    .HasColumnName("contact_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ContactTitle)
                    .HasColumnName("contact_title")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactUnsubscribe)
                    .HasColumnName("contact_unsubscribe")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ElementId)
                    .HasColumnName("element_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SessionId)
                    .IsRequired()
                    .HasColumnName("session_id")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ContactsImports>(entity =>
            {
                entity.HasKey(e => e.ImportId);

                entity.ToTable("contacts_imports", "rezoradata");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.ImportId)
                    .HasColumnName("import_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CompletedTimestamp).HasColumnName("completed_timestamp");

                entity.Property(e => e.HeaderType)
                    .IsRequired()
                    .HasColumnName("header_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ImportError)
                    .HasColumnName("import_error")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.ImportPath)
                    .IsRequired()
                    .HasColumnName("import_path")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ImportStatus)
                    .HasColumnName("import_status")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ListId)
                    .HasColumnName("list_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MergedCount)
                    .HasColumnName("merged_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Overwrite)
                    .HasColumnName("overwrite")
                    .HasColumnType("tinyint(11)");

                entity.Property(e => e.SubmittedCount)
                    .HasColumnName("submitted_count")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SubmittedTimestamp)
                    .HasColumnName("submitted_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TestBouncesResult)
                    .HasColumnName("test_bounces_result")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TestBouncesTimestamp).HasColumnName("test_bounces_timestamp");

                entity.Property(e => e.TestDeliveredResult)
                    .HasColumnName("test_delivered_result")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TestDeliveredTimestamp).HasColumnName("test_delivered_timestamp");

                entity.Property(e => e.TestDuplicatesResult)
                    .HasColumnName("test_duplicates_result")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TestDuplicatesTimestamp).HasColumnName("test_duplicates_timestamp");

                entity.Property(e => e.TestExistsResult)
                    .HasColumnName("test_exists_result")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TestExistsTimestamp).HasColumnName("test_exists_timestamp");

                entity.Property(e => e.TestGdprResult)
                    .HasColumnName("test_GDPR_result")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TestGdprTimestamp).HasColumnName("test_GDPR_timestamp");

                entity.Property(e => e.TestHeadersResult)
                    .HasColumnName("test_headers_result")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TestHeadersTimestamp).HasColumnName("test_headers_timestamp");

                entity.Property(e => e.TestSmtpResult)
                    .HasColumnName("test_SMTP_result")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TestSmtpTimestamp).HasColumnName("test_SMTP_timestamp");

                entity.Property(e => e.TestSpamResult)
                    .HasColumnName("test_spam_result")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TestSpamTimestamp).HasColumnName("test_spam_timestamp");

                entity.Property(e => e.TestSyntaxResult)
                    .HasColumnName("test_syntax_result")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TestSyntaxTimestamp).HasColumnName("test_syntax_timestamp");

                entity.Property(e => e.TestUnsubscribesResult)
                    .HasColumnName("test_unsubscribes_result")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TestUnsubscribesTimestamp).HasColumnName("test_unsubscribes_timestamp");

                entity.Property(e => e.TestVerifiedResult)
                    .HasColumnName("test_verified_result")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TestVerifiedTimestamp).HasColumnName("test_verified_timestamp");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ContactsImportsHolder>(entity =>
            {
                entity.HasKey(e => e.ContactId);

                entity.ToTable("contacts_imports_holder", "rezoradata");

                entity.HasIndex(e => e.ContactEmail)
                    .HasName("contact_email");

                entity.HasIndex(e => e.ImportId)
                    .HasName("import_id");

                entity.HasIndex(e => e.TestStatus)
                    .HasName("test_status");

                entity.HasIndex(e => new { e.ImportId, e.TestStatus, e.ContactEmail })
                    .HasName("import_id_2");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContactBusinessCity)
                    .HasColumnName("contact_business_city")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactBusinessState)
                    .HasColumnName("contact_business_state")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactBusinessStreet)
                    .HasColumnName("contact_business_street")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactBusinessStreet2)
                    .HasColumnName("contact_business_street2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactBusinessZip)
                    .HasColumnName("contact_business_zip")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ContactCompany)
                    .HasColumnName("contact_company")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactCrmAccountId)
                    .HasColumnName("contact_crm_account_id")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactEmail)
                    .IsRequired()
                    .HasColumnName("contact_email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactHomeCity)
                    .HasColumnName("contact_home_city")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactHomeState)
                    .HasColumnName("contact_home_state")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactHomeStreet)
                    .HasColumnName("contact_home_street")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactHomeStreet2)
                    .HasColumnName("contact_home_street2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactHomeZip)
                    .HasColumnName("contact_home_zip")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPhoneFax)
                    .HasColumnName("contact_phone_fax")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPhoneHome)
                    .HasColumnName("contact_phone_home")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPhoneMobile)
                    .HasColumnName("contact_phone_mobile")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPhoneWork)
                    .HasColumnName("contact_phone_work")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTimestamp)
                    .HasColumnName("contact_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ContactTitle)
                    .HasColumnName("contact_title")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactUnsubscribe)
                    .HasColumnName("contact_unsubscribe")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ImportId)
                    .HasColumnName("import_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MclId)
                    .HasColumnName("mcl_id")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MclListId)
                    .HasColumnName("mcl_list_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TestStatus)
                    .HasColumnName("test_status")
                    .HasColumnType("int(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ContactsLists>(entity =>
            {
                entity.HasKey(e => e.ListId);

                entity.ToTable("contacts_lists", "rezoradata");

                entity.HasIndex(e => e.ElementCrmId)
                    .HasName("element_crm_id");

                entity.HasIndex(e => e.ListType)
                    .HasName("list_type");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.ListId)
                    .HasColumnName("list_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ElementCrmId)
                    .IsRequired()
                    .HasColumnName("element_crm_id")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ElementId)
                    .HasColumnName("element_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ListDate)
                    .HasColumnName("list_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ListName)
                    .IsRequired()
                    .HasColumnName("list_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ListRemoved)
                    .HasColumnName("list_removed")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ListType)
                    .HasColumnName("list_type")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ListUpdating)
                    .HasColumnName("list_updating")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MclListId)
                    .HasColumnName("mcl_list_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ContactsLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("contacts_lists_ibfk_1");
            });

            modelBuilder.Entity<ContactsMeta>(entity =>
            {
                entity.HasKey(e => e.ContactMetaId);

                entity.ToTable("contacts_meta", "rezoradata");

                entity.HasIndex(e => e.ContactId)
                    .HasName("contact_id");

                entity.HasIndex(e => new { e.ContactMetaTypeId, e.ContactId })
                    .HasName("contact_meta_type_id")
                    .IsUnique();

                entity.Property(e => e.ContactMetaId)
                    .HasColumnName("contact_meta_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.ContactMetaTypeId)
                    .HasColumnName("contact_meta_type_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.MetaValue)
                    .IsRequired()
                    .HasColumnName("meta_value")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11) unsigned");
            });

            modelBuilder.Entity<ContactsMetaTypes>(entity =>
            {
                entity.HasKey(e => e.ContactMetaTypeId);

                entity.ToTable("contacts_meta_types", "rezoradata");

                entity.Property(e => e.ContactMetaTypeId)
                    .HasColumnName("contact_meta_type_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasColumnName("type_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ContactsNotes>(entity =>
            {
                entity.HasKey(e => e.NoteId);

                entity.ToTable("contacts_notes", "rezoradata");

                entity.HasIndex(e => e.ContactId)
                    .HasName("contact_id");

                entity.HasIndex(e => e.NoteDate)
                    .HasName("note_date");

                entity.Property(e => e.NoteId)
                    .HasColumnName("note_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NoteDate)
                    .HasColumnName("note_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.NoteText)
                    .IsRequired()
                    .HasColumnName("note_text")
                    .IsUnicode(false);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.ContactsNotes)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("contacts_notes_ibfk_1");
            });

            modelBuilder.Entity<ContactsPending>(entity =>
            {
                entity.HasKey(e => e.ContactpendingId);

                entity.ToTable("contacts_pending", "rezoradata");

                entity.HasIndex(e => e.ContactEmail)
                    .HasName("contact_email");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.ContactpendingId)
                    .HasColumnName("contactpending_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContactBusinessCity)
                    .HasColumnName("contact_business_city")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactBusinessState)
                    .HasColumnName("contact_business_state")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactBusinessStreet)
                    .HasColumnName("contact_business_street")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactBusinessStreet2)
                    .HasColumnName("contact_business_street2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactBusinessZip)
                    .HasColumnName("contact_business_zip")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ContactCompany)
                    .HasColumnName("contact_company")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactEmail)
                    .IsRequired()
                    .HasColumnName("contact_email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactHomeCity)
                    .HasColumnName("contact_home_city")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactHomeState)
                    .HasColumnName("contact_home_state")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactHomeStreet)
                    .HasColumnName("contact_home_street")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactHomeStreet2)
                    .HasColumnName("contact_home_street2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactHomeZip)
                    .HasColumnName("contact_home_zip")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPhoneFax)
                    .HasColumnName("contact_phone_fax")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPhoneHome)
                    .HasColumnName("contact_phone_home")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPhoneMobile)
                    .HasColumnName("contact_phone_mobile")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPhoneWork)
                    .HasColumnName("contact_phone_work")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTitle)
                    .HasColumnName("contact_title")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ListId)
                    .HasColumnName("list_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OptinFirst)
                    .HasColumnName("optin_first")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.SourceId)
                    .HasColumnName("source_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ContactsPending)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("contactspending_ibfk_1");
            });

            modelBuilder.Entity<ContactsRanks>(entity =>
            {
                entity.HasKey(e => e.ContactId);

                entity.ToTable("contacts_ranks", "rezoradata");

                entity.HasIndex(e => e.RankNumber)
                    .HasName("rank_number");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.BounceScore).HasColumnName("bounce_score");

                entity.Property(e => e.ClickScore).HasColumnName("click_score");

                entity.Property(e => e.DetailsScore).HasColumnName("details_score");

                entity.Property(e => e.EmailCount)
                    .HasColumnName("email_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OpenScore).HasColumnName("open_score");

                entity.Property(e => e.RankNumber).HasColumnName("rank_number");

                entity.Property(e => e.RankPercentile).HasColumnName("rank_percentile");

                entity.Property(e => e.RankTimestamp)
                    .HasColumnName("rank_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.SearchScore).HasColumnName("search_score");

                entity.Property(e => e.SpamScore).HasColumnName("spam_score");

                entity.Property(e => e.UnsubscribeScore).HasColumnName("unsubscribe_score");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ContactsSources>(entity =>
            {
                entity.HasKey(e => e.SourceId);

                entity.ToTable("contacts_sources", "rezoradata");

                entity.Property(e => e.SourceId)
                    .HasColumnName("source_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.SourceName)
                    .HasColumnName("source_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ContactsToElementListHolder>(entity =>
            {
                entity.HasKey(e => new { e.ContactCrmId, e.ContactCrmListId, e.Brokeragestoelements });

                entity.ToTable("contacts_to_element_list_holder", "rezoradata");

                entity.Property(e => e.ContactCrmId)
                    .HasColumnName("contact_crm_id")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactCrmListId)
                    .HasColumnName("contact_crm_list_id")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Brokeragestoelements)
                    .HasColumnName("brokeragestoelements")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ContactsToLists>(entity =>
            {
                entity.HasKey(e => e.ContacttolistId);

                entity.ToTable("contacts_to_lists", "rezoradata");

                entity.HasIndex(e => e.ContactId)
                    .HasName("contact_id");

                entity.HasIndex(e => e.ListId)
                    .HasName("list_id");

                entity.HasIndex(e => new { e.ContactId, e.ListId })
                    .HasName("contact_id_2")
                    .IsUnique();

                entity.Property(e => e.ContacttolistId)
                    .HasColumnName("contacttolist_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContacttolistDate)
                    .HasColumnName("contacttolist_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ContacttolistUpdating)
                    .HasColumnName("contacttolist_updating")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ListId)
                    .HasColumnName("list_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.ContactsToLists)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("contacts_to_lists_ibfk_5");

                entity.HasOne(d => d.List)
                    .WithMany(p => p.ContactsToLists)
                    .HasForeignKey(d => d.ListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("contacts_to_lists_ibfk_4");
            });

            modelBuilder.Entity<ContactsToNewsletters>(entity =>
            {
                entity.HasKey(e => e.ContacttonewsletterId);

                entity.ToTable("contacts_to_newsletters", "rezoradata");

                entity.HasIndex(e => e.ContactId)
                    .HasName("contact_id");

                entity.HasIndex(e => e.NewsletterId)
                    .HasName("newsletter_id");

                entity.HasIndex(e => new { e.ContactId, e.NewsletterId })
                    .HasName("contact_id_2")
                    .IsUnique();

                entity.Property(e => e.ContacttonewsletterId)
                    .HasColumnName("contacttonewsletter_id")
                    .HasColumnType("bigint(11)");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContacttonewsletterDate)
                    .HasColumnName("contacttonewsletter_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.NewsletterId)
                    .HasColumnName("newsletter_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.ContactsToNewsletters)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("contacts_to_newsletters_ibfk_1");

                entity.HasOne(d => d.Newsletter)
                    .WithMany(p => p.ContactsToNewsletters)
                    .HasForeignKey(d => d.NewsletterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("contacts_to_newsletters_ibfk_2");
            });

            modelBuilder.Entity<ContactsToNewslettersBg>(entity =>
            {
                entity.HasKey(e => e.ContacttonewsletterId);

                entity.ToTable("contacts_to_newsletters_bg", "rezoradata");

                entity.HasIndex(e => e.ContactId)
                    .HasName("contact_id");

                entity.HasIndex(e => e.NewsletterId)
                    .HasName("newsletter_id");

                entity.HasIndex(e => new { e.ContactId, e.NewsletterId })
                    .HasName("contact_id_2")
                    .IsUnique();

                entity.Property(e => e.ContacttonewsletterId)
                    .HasColumnName("contacttonewsletter_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContacttonewsletterDate)
                    .HasColumnName("contacttonewsletter_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.NewsletterId)
                    .HasColumnName("newsletter_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<CrmContactsImports>(entity =>
            {
                entity.HasKey(e => e.ImportId);

                entity.ToTable("crm_contacts_imports", "rezoradata");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.ImportId)
                    .HasColumnName("import_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CompletedTimestamp).HasColumnName("completed_timestamp");

                entity.Property(e => e.HolderImportCompletedOn).HasColumnName("holder_import_completed_on");

                entity.Property(e => e.ImportError)
                    .HasColumnName("import_error")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.ImportPath)
                    .IsRequired()
                    .HasColumnName("import_path")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ImportStatus)
                    .HasColumnName("import_status")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MergedCount)
                    .HasColumnName("merged_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NullEmailsCount)
                    .HasColumnName("null_emails_count")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Overwrite)
                    .HasColumnName("overwrite")
                    .HasColumnType("tinyint(11)");

                entity.Property(e => e.SubmittedCount)
                    .HasColumnName("submitted_count")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SubmittedTimestamp)
                    .HasColumnName("submitted_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TestBouncesResult)
                    .HasColumnName("test_bounces_result")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TestBouncesTimestamp).HasColumnName("test_bounces_timestamp");

                entity.Property(e => e.TestDeliveredResult)
                    .HasColumnName("test_delivered_result")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TestDeliveredTimestamp).HasColumnName("test_delivered_timestamp");

                entity.Property(e => e.TestDuplicatesResult)
                    .HasColumnName("test_duplicates_result")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TestDuplicatesTimestamp).HasColumnName("test_duplicates_timestamp");

                entity.Property(e => e.TestExistsResult)
                    .HasColumnName("test_exists_result")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TestExistsTimestamp).HasColumnName("test_exists_timestamp");

                entity.Property(e => e.TestPurgedResult)
                    .HasColumnName("test_purged_result")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TestPurgedTimestamp).HasColumnName("test_purged_timestamp");

                entity.Property(e => e.TestSmtpResult)
                    .HasColumnName("test_SMTP_result")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TestSmtpTimestamp).HasColumnName("test_SMTP_timestamp");

                entity.Property(e => e.TestSpamResult)
                    .HasColumnName("test_spam_result")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TestSpamTimestamp).HasColumnName("test_spam_timestamp");

                entity.Property(e => e.TestSyntaxResult)
                    .HasColumnName("test_syntax_result")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TestSyntaxTimestamp).HasColumnName("test_syntax_timestamp");

                entity.Property(e => e.TestUnsubscribesResult)
                    .HasColumnName("test_unsubscribes_result")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TestUnsubscribesTimestamp).HasColumnName("test_unsubscribes_timestamp");

                entity.Property(e => e.TestVerifiedResult)
                    .HasColumnName("test_verified_result")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TestVerifiedTimestamp).HasColumnName("test_verified_timestamp");

                entity.Property(e => e.TotalHolderFailure)
                    .HasColumnName("total_holder_failure")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TotalHolderSuccess)
                    .HasColumnName("total_holder_success")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<CrmsType>(entity =>
            {
                entity.HasKey(e => e.CrmId);

                entity.ToTable("crms_type", "rezoradata");

                entity.Property(e => e.CrmId)
                    .HasColumnName("crm_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ApplicationId)
                    .HasColumnName("application_id")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientSecret)
                    .HasColumnName("client_secret")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CrmName)
                    .HasColumnName("crm_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IconPath)
                    .HasColumnName("icon_path")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CrmsUsersToAccounts>(entity =>
            {
                entity.HasKey(e => e.CrmUsertoaccountId);

                entity.ToTable("crms_users_to_accounts", "rezoradata");

                entity.Property(e => e.CrmUsertoaccountId)
                    .HasColumnName("crm_usertoaccount_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.CrmAccId)
                    .HasColumnName("crm_acc_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CrmAccName)
                    .HasColumnName("crm_acc_name")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.CrmId)
                    .HasColumnName("crm_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CrmUsertoaccountTimestamp).HasColumnName("crm_usertoaccount_timestamp");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<CrmsUsersToCampaigns>(entity =>
            {
                entity.HasKey(e => e.CrmUsertocampaignId);

                entity.ToTable("crms_users_to_campaigns", "rezoradata");

                entity.Property(e => e.CrmUsertocampaignId)
                    .HasColumnName("crm_usertocampaign_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.CrmCamId)
                    .HasColumnName("crm_cam_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CrmCamName)
                    .HasColumnName("crm_cam_name")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.CrmId)
                    .HasColumnName("crm_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CrmUsertocampaignTimestamp).HasColumnName("crm_usertocampaign_timestamp");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ElementsType>(entity =>
            {
                entity.HasKey(e => e.ElementId);

                entity.ToTable("elements_type", "rezoradata");

                entity.Property(e => e.ElementId)
                    .HasColumnName("element_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ElementName)
                    .IsRequired()
                    .HasColumnName("element_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IconPath)
                    .IsRequired()
                    .HasColumnName("icon_path")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmailAddressStats>(entity =>
            {
                entity.HasKey(e => e.Email);

                entity.ToTable("email_address_stats", "rezoradata");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CleanClickRate)
                    .HasColumnName("clean_click_rate")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CleanOpenRate)
                    .HasColumnName("clean_open_rate")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Clicks)
                    .HasColumnName("clicks")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Contacts)
                    .HasColumnName("contacts")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Delivered)
                    .HasColumnName("delivered")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DistinctClicks)
                    .HasColumnName("distinct_clicks")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DistinctOpens)
                    .HasColumnName("distinct_opens")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Opens)
                    .HasColumnName("opens")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OtcRate)
                    .HasColumnName("otc_rate")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RawClickRate)
                    .HasColumnName("raw_click_rate")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RawOpenRate)
                    .HasColumnName("raw_open_rate")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EmailBlock>(entity =>
            {
                entity.HasKey(e => e.BlockId);

                entity.ToTable("email_block", "rezoradata");

                entity.HasIndex(e => new { e.BlockedAddress, e.BlockedUser })
                    .HasName("idx_blocked_address_blocked_user");

                entity.Property(e => e.BlockId)
                    .HasColumnName("block_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BlockType)
                    .HasColumnName("block_type")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BlockedAddress)
                    .IsRequired()
                    .HasColumnName("blocked_address")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.BlockedUser)
                    .HasColumnName("blocked_user")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PurgeRequestId)
                    .HasColumnName("purge_request_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EmailBlockType>(entity =>
            {
                entity.HasKey(e => e.BlockTypeId);

                entity.ToTable("email_block_type", "rezoradata");

                entity.Property(e => e.BlockTypeId)
                    .HasColumnName("block_type_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BlockTypeName)
                    .HasColumnName("block_type_name")
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmsBounceFull>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.ToTable("ems_bounce_full", "rezoradata");

                entity.HasIndex(e => e.Email)
                    .HasName("email");

                entity.HasIndex(e => e.NewsletterId)
                    .HasName("newsletter_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.HasIndex(e => new { e.ContactId, e.NewsletterId })
                    .HasName("contact_id");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasColumnName("email_id")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.EventTimestamp)
                    .HasColumnName("event_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.NewsletterId)
                    .HasColumnName("newsletter_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasColumnName("reason")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<EmsBounces>(entity =>
            {
                entity.HasKey(e => e.Email);

                entity.ToTable("ems_bounces", "rezoradata");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<EmsClick>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.ToTable("ems_click", "rezoradata");

                entity.HasIndex(e => e.Email)
                    .HasName("email");

                entity.HasIndex(e => e.NewsletterId)
                    .HasName("newsletter_id");

                entity.HasIndex(e => e.Url)
                    .HasName("url");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.HasIndex(e => new { e.ContactId, e.NewsletterId })
                    .HasName("contact_id");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasColumnName("email_id")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.EmsSourceId)
                    .HasColumnName("ems_source_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.EventTimestamp)
                    .HasColumnName("event_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.NewsletterId)
                    .HasColumnName("newsletter_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<EmsCompositeMetrics>(entity =>
            {
                entity.HasKey(e => e.ContactId);

                entity.ToTable("ems_composite_metrics", "rezoradata");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AciHours)
                    .HasColumnName("aci_hours")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsSunset)
                    .HasColumnName("is_sunset")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastActivty)
                    .HasColumnName("last_activty")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.LastCalculated).HasColumnName("last_calculated");

                entity.Property(e => e.LastClicked).HasColumnName("last_clicked");

                entity.Property(e => e.LastClickedNewsletter)
                    .HasColumnName("last_clicked_newsletter")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastDelivered)
                    .HasColumnName("last_delivered")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.LastDeliveredNewsletter)
                    .HasColumnName("last_delivered_newsletter")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastOpened).HasColumnName("last_opened");

                entity.Property(e => e.LastOpenedNewsletter)
                    .HasColumnName("last_opened_newsletter")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastProcessed).HasColumnName("last_processed");

                entity.Property(e => e.LastProcessedNewsletter)
                    .HasColumnName("last_processed_newsletter")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SunriseDate).HasColumnName("sunrise_date");

                entity.Property(e => e.SunsetDate).HasColumnName("sunset_date");

                entity.Property(e => e.TotalClicked)
                    .HasColumnName("total_clicked")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TotalDelivered)
                    .HasColumnName("total_delivered")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TotalOpened)
                    .HasColumnName("total_opened")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TotalProcessed)
                    .HasColumnName("total_processed")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TotalSunsets)
                    .HasColumnName("total_sunsets")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EmsDeferred>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.ToTable("ems_deferred", "rezoradata");

                entity.HasIndex(e => e.Email)
                    .HasName("email");

                entity.HasIndex(e => e.NewsletterId)
                    .HasName("newsletter_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.HasIndex(e => new { e.ContactId, e.NewsletterId })
                    .HasName("contact_id");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Attempt)
                    .HasColumnName("attempt")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasColumnName("email_id")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.EventTimestamp)
                    .HasColumnName("event_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.NewsletterId)
                    .HasColumnName("newsletter_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Response)
                    .IsRequired()
                    .HasColumnName("response")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<EmsDelivered>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.ToTable("ems_delivered", "rezoradata");

                entity.HasIndex(e => e.Email)
                    .HasName("email");

                entity.HasIndex(e => e.EventTimestamp)
                    .HasName("idx_event_timestamp");

                entity.HasIndex(e => e.NewsletterId)
                    .HasName("newsletter_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.HasIndex(e => new { e.ContactId, e.NewsletterId })
                    .HasName("contact_id");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasColumnName("email_id")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.EventTimestamp)
                    .HasColumnName("event_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.NewsletterId)
                    .HasColumnName("newsletter_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Response)
                    .IsRequired()
                    .HasColumnName("response")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<EmsDropped>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.ToTable("ems_dropped", "rezoradata");

                entity.HasIndex(e => e.Email)
                    .HasName("email");

                entity.HasIndex(e => e.NewsletterId)
                    .HasName("newsletter_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.HasIndex(e => new { e.ContactId, e.NewsletterId })
                    .HasName("contact_id");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasColumnName("email_id")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.EventTimestamp)
                    .HasColumnName("event_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.NewsletterId)
                    .HasColumnName("newsletter_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasColumnName("reason")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<EmsOpen>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.ToTable("ems_open", "rezoradata");

                entity.HasIndex(e => e.Email)
                    .HasName("email");

                entity.HasIndex(e => e.NewsletterId)
                    .HasName("newsletter_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.HasIndex(e => new { e.ContactId, e.NewsletterId })
                    .HasName("contact_id");

                entity.HasIndex(e => new { e.UserId, e.EventTimestamp })
                    .HasName("user_id_2");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasColumnName("email_id")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.EmsSourceId)
                    .HasColumnName("ems_source_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.EventTimestamp)
                    .HasColumnName("event_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.NewsletterId)
                    .HasColumnName("newsletter_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<EmsProcessed>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.ToTable("ems_processed", "rezoradata");

                entity.HasIndex(e => e.Email)
                    .HasName("email");

                entity.HasIndex(e => e.EventTimestamp)
                    .HasName("idx_event_timestamp");

                entity.HasIndex(e => e.NewsletterId)
                    .HasName("newsletter_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.HasIndex(e => new { e.ContactId, e.NewsletterId })
                    .HasName("contact_id");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasColumnName("email_id")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.EventTimestamp)
                    .HasColumnName("event_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.NewsletterId)
                    .HasColumnName("newsletter_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<EmsSources>(entity =>
            {
                entity.HasKey(e => e.EmsSourceId);

                entity.ToTable("ems_sources", "rezoradata");

                entity.Property(e => e.EmsSourceId)
                    .HasColumnName("ems_source_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Source)
                    .HasColumnName("source")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmsSpamreport>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.ToTable("ems_spamreport", "rezoradata");

                entity.HasIndex(e => e.Email)
                    .HasName("email");

                entity.HasIndex(e => e.NewsletterId)
                    .HasName("newsletter_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.HasIndex(e => new { e.ContactId, e.NewsletterId })
                    .HasName("contact_id");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasColumnName("email_id")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.EventTimestamp)
                    .HasColumnName("event_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.NewsletterId)
                    .HasColumnName("newsletter_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<EmsUnsubscribe>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.ToTable("ems_unsubscribe", "rezoradata");

                entity.HasIndex(e => e.Email)
                    .HasName("email");

                entity.HasIndex(e => e.NewsletterId)
                    .HasName("newsletter_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.HasIndex(e => new { e.ContactId, e.NewsletterId })
                    .HasName("contact_id");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasColumnName("email_id")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.EventTimestamp)
                    .HasColumnName("event_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.NewsletterId)
                    .HasColumnName("newsletter_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<EmsUserAgent>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.ToTable("ems_user_agent", "rezoradata");

                entity.HasIndex(e => e.BrokerageId)
                    .HasName("brokerage_id");

                entity.HasIndex(e => e.ContactId)
                    .HasName("contact_id");

                entity.HasIndex(e => e.EventTimestamp)
                    .HasName("idx_event_timestamp");

                entity.HasIndex(e => new { e.UserId, e.BrokerageId })
                    .HasName("user_brokerage_id");

                entity.HasIndex(e => new { e.UserId, e.EventTimestamp })
                    .HasName("user_id");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BrokerageId)
                    .HasColumnName("brokerage_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DesktopChrome)
                    .HasColumnName("desktop_chrome")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DesktopLinux)
                    .HasColumnName("desktop_linux")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DesktopMac)
                    .HasColumnName("desktop_mac")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DesktopWindows)
                    .HasColumnName("desktop_windows")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EmsSourceId)
                    .HasColumnName("ems_source_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.EventDatetime).HasColumnName("event_datetime");

                entity.Property(e => e.EventReferer)
                    .IsRequired()
                    .HasColumnName("event_referer")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.EventRemoteAddr)
                    .IsRequired()
                    .HasColumnName("event_remote_addr")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EventTimestamp)
                    .HasColumnName("event_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.EventUserAgent)
                    .IsRequired()
                    .HasColumnName("event_user_agent")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.MobileAndroid)
                    .HasColumnName("mobile_android")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MobileBlackberry)
                    .HasColumnName("mobile_blackberry")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MobileIphone)
                    .HasColumnName("mobile_iphone")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MobileIpod)
                    .HasColumnName("mobile_ipod")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MobileWebos)
                    .HasColumnName("mobile_webos")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MobileWindows)
                    .HasColumnName("mobile_windows")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NewsletterId)
                    .HasColumnName("newsletter_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Other)
                    .HasColumnName("other")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TabletAndroid)
                    .HasColumnName("tablet_android")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TabletIpad)
                    .HasColumnName("tablet_ipad")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ExternalPostings>(entity =>
            {
                entity.HasKey(e => e.PostingId);

                entity.ToTable("external_postings", "rezoradata");

                entity.Property(e => e.PostingId)
                    .HasColumnName("posting_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ListingId)
                    .IsRequired()
                    .HasColumnName("listing_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.ListingTypeId)
                    .HasColumnName("listing_type_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("6");

                entity.Property(e => e.OrgId)
                    .IsRequired()
                    .HasColumnName("org_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostingMessage)
                    .IsRequired()
                    .HasColumnName("posting_message")
                    .IsUnicode(false);

                entity.Property(e => e.PostingService)
                    .IsRequired()
                    .HasColumnName("posting_service")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostingTimestamp)
                    .HasColumnName("posting_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ServicePostingId)
                    .HasColumnName("service_posting_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ExternalPostingsLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("external_postings_log", "rezoradata");

                entity.HasIndex(e => e.PostingId)
                    .HasName("posting_id");

                entity.Property(e => e.LogId)
                    .HasColumnName("log_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LogTimestamp)
                    .HasColumnName("log_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.PostingId)
                    .HasColumnName("posting_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Posting)
                    .WithMany(p => p.ExternalPostingsLog)
                    .HasForeignKey(d => d.PostingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("external_postings_log_ibfk_1");
            });

            modelBuilder.Entity<FacebookLog>(entity =>
            {
                entity.HasKey(e => e.RzPostId);

                entity.ToTable("facebook_log", "rezoradata");

                entity.HasIndex(e => e.FbPostId)
                    .HasName("fb_post_id");

                entity.HasIndex(e => e.ItemId)
                    .HasName("newsletter_id");

                entity.Property(e => e.RzPostId)
                    .HasColumnName("rz_post_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClickCount)
                    .HasColumnName("click_count")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FbPostId)
                    .HasColumnName("fb_post_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemId)
                    .HasColumnName("item_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OpenCount)
                    .HasColumnName("open_count")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PotentialReach)
                    .HasColumnName("potential_reach")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RequestTimestamp)
                    .HasColumnName("request_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Favorites>(entity =>
            {
                entity.HasKey(e => e.FavoriteId);

                entity.ToTable("favorites", "rezoradata");

                entity.HasIndex(e => e.FavoriteTimestamp)
                    .HasName("favorite_timestamp");

                entity.HasIndex(e => e.ListingId)
                    .HasName("listing_id");

                entity.HasIndex(e => e.OrgId)
                    .HasName("org_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.FavoriteId)
                    .HasColumnName("favorite_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FavoriteNotes)
                    .IsRequired()
                    .HasColumnName("favorite_notes")
                    .IsUnicode(false);

                entity.Property(e => e.FavoriteTimestamp)
                    .HasColumnName("favorite_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ListingId)
                    .IsRequired()
                    .HasColumnName("listing_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.ListingTypeId)
                    .HasColumnName("listing_type_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("6");

                entity.Property(e => e.OrgId)
                    .IsRequired()
                    .HasColumnName("org_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Favorites)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("favorites_ibfk_1");
            });

            modelBuilder.Entity<GallBrandsToCollections>(entity =>
            {
                entity.HasKey(e => new { e.CollectionId, e.BrandId });

                entity.ToTable("gall_brands_to_collections", "rezoradata");

                entity.HasIndex(e => e.BrandId)
                    .HasName("brand_id");

                entity.Property(e => e.CollectionId)
                    .HasColumnName("collection_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BrandId)
                    .HasColumnName("brand_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<GallBrokeragesToCollections>(entity =>
            {
                entity.HasKey(e => new { e.CollectionId, e.BrokerageId });

                entity.ToTable("gall_brokerages_to_collections", "rezoradata");

                entity.HasIndex(e => e.BrokerageId)
                    .HasName("brokerage_id");

                entity.Property(e => e.CollectionId)
                    .HasColumnName("collection_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BrokerageId)
                    .HasColumnName("brokerage_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<GallCategories>(entity =>
            {
                entity.HasKey(e => e.CatId);

                entity.ToTable("gall_categories", "rezoradata");

                entity.Property(e => e.CatId)
                    .HasColumnName("cat_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CatCreated)
                    .HasColumnName("cat_created")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CatName)
                    .IsRequired()
                    .HasColumnName("cat_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GallCollections>(entity =>
            {
                entity.HasKey(e => e.CollectionId);

                entity.ToTable("gall_collections", "rezoradata");

                entity.Property(e => e.CollectionId)
                    .HasColumnName("collection_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CollectionCreated)
                    .HasColumnName("collection_created")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CollectionName)
                    .IsRequired()
                    .HasColumnName("collection_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CollectionPriceDefault)
                    .HasColumnName("collection_price_default")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CollectionRestricted)
                    .HasColumnName("collection_restricted")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CollectionStatus)
                    .HasColumnName("collection_status")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<Gallery>(entity =>
            {
                entity.ToTable("gallery", "rezoradata");

                entity.HasIndex(e => e.GalleryAllowPublish)
                    .HasName("gallery_allow_publish");

                entity.HasIndex(e => e.GalleryGlobalAccess)
                    .HasName("gallery_global_access");

                entity.Property(e => e.GalleryId)
                    .HasColumnName("gallery_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GalleryAllowPublish)
                    .HasColumnName("gallery_allow_publish")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GalleryDescription)
                    .IsRequired()
                    .HasColumnName("gallery_description")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.GalleryGlobalAccess)
                    .HasColumnName("gallery_global_access")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GalleryName)
                    .IsRequired()
                    .HasColumnName("gallery_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GalleryPrivate)
                    .HasColumnName("gallery_private")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<GalleryOrders>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("gallery_orders", "rezoradata");

                entity.Property(e => e.OrderId)
                    .HasColumnName("order_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BrokerageId)
                    .HasColumnName("brokerage_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClassId)
                    .HasColumnName("class_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NewTemplateId)
                    .HasColumnName("new_template_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OrderAssigneeId)
                    .HasColumnName("order_assignee_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OrderComments)
                    .IsRequired()
                    .HasColumnName("order_comments")
                    .IsUnicode(false);

                entity.Property(e => e.OrderContactEmail)
                    .IsRequired()
                    .HasColumnName("order_contact_email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderContactName)
                    .IsRequired()
                    .HasColumnName("order_contact_name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OrderContactPhone)
                    .IsRequired()
                    .HasColumnName("order_contact_phone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderGallery)
                    .HasColumnName("order_gallery")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OrderGroups)
                    .IsRequired()
                    .HasColumnName("order_groups")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrderMessage)
                    .IsRequired()
                    .HasColumnName("order_message")
                    .IsUnicode(false);

                entity.Property(e => e.OrderPrice).HasColumnName("order_price");

                entity.Property(e => e.OrderStatusId)
                    .HasColumnName("order_status_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("2");

                entity.Property(e => e.OrderTimeframeId)
                    .HasColumnName("order_timeframe_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("2");

                entity.Property(e => e.OrderTimestamp)
                    .HasColumnName("order_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.OrderZendeskId)
                    .HasColumnName("order_zendesk_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("template_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplateTitle)
                    .IsRequired()
                    .HasColumnName("template_title")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GalleryOrdersStatuses>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("gallery_orders_statuses", "rezoradata");

                entity.Property(e => e.StatusId)
                    .HasColumnName("status_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasColumnName("status_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusOrder)
                    .HasColumnName("status_order")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<GalleryTimeframes>(entity =>
            {
                entity.HasKey(e => e.TimeframeId);

                entity.ToTable("gallery_timeframes", "rezoradata");

                entity.Property(e => e.TimeframeId)
                    .HasColumnName("timeframe_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TimeframeDescription)
                    .IsRequired()
                    .HasColumnName("timeframe_description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeframeName)
                    .IsRequired()
                    .HasColumnName("timeframe_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TimeframeOrder)
                    .HasColumnName("timeframe_order")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TimeframePublic)
                    .HasColumnName("timeframe_public")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<GalleryToBrokerage>(entity =>
            {
                entity.ToTable("gallery_to_brokerage", "rezoradata");

                entity.HasIndex(e => new { e.GalleryId, e.BrokerageId })
                    .HasName("gallery_id")
                    .IsUnique();

                entity.Property(e => e.GallerytobrokerageId)
                    .HasColumnName("gallerytobrokerage_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BrokerageId)
                    .HasColumnName("brokerage_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GalleryId)
                    .HasColumnName("gallery_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<GalleryToTemplate>(entity =>
            {
                entity.ToTable("gallery_to_template", "rezoradata");

                entity.HasIndex(e => new { e.TemplateId, e.GalleryId })
                    .HasName("template_id");

                entity.Property(e => e.GallerytotemplateId)
                    .HasColumnName("gallerytotemplate_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GalleryId)
                    .HasColumnName("gallery_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GallerytotemplateTimestamp)
                    .HasColumnName("gallerytotemplate_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("template_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplateTitle)
                    .IsRequired()
                    .HasColumnName("template_title")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateTypeId)
                    .HasColumnName("template_type_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<GallProducts>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("gall_products", "rezoradata");

                entity.HasIndex(e => e.TemplateId)
                    .HasName("template_id");

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProductCreated)
                    .HasColumnName("product_created")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasColumnName("product_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductPrice)
                    .HasColumnName("product_price")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("template_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<GallProductsToCategories>(entity =>
            {
                entity.HasKey(e => new { e.CatId, e.ProductId });

                entity.ToTable("gall_products_to_categories", "rezoradata");

                entity.HasIndex(e => e.ProductId)
                    .HasName("product_id");

                entity.Property(e => e.CatId)
                    .HasColumnName("cat_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<GallProductsToCollections>(entity =>
            {
                entity.HasKey(e => new { e.CollectionId, e.ProductId });

                entity.ToTable("gall_products_to_collections", "rezoradata");

                entity.HasIndex(e => e.ProductId)
                    .HasName("product_id");

                entity.Property(e => e.CollectionId)
                    .HasColumnName("collection_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<GaSettingsBrands>(entity =>
            {
                entity.HasKey(e => e.BrandId);

                entity.ToTable("ga_settings_brands", "rezoradata");

                entity.Property(e => e.BrandId)
                    .HasColumnName("brand_id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.GaOn)
                    .HasColumnName("ga_on")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Sites)
                    .HasColumnName("sites")
                    .HasColumnType("longtext");
            });

            modelBuilder.Entity<GaSettingsBrokerages>(entity =>
            {
                entity.HasKey(e => e.BrokerageId);

                entity.ToTable("ga_settings_brokerages", "rezoradata");

                entity.Property(e => e.BrokerageId)
                    .HasColumnName("brokerage_id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.GaOn)
                    .HasColumnName("ga_on")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Sites)
                    .HasColumnName("sites")
                    .HasColumnType("longtext");
            });

            modelBuilder.Entity<GaSettingsUsers>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("ga_settings_users", "rezoradata");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.GaOn)
                    .HasColumnName("ga_on")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Sites)
                    .HasColumnName("sites")
                    .HasColumnType("longtext");
            });

            modelBuilder.Entity<GeocodesRequests>(entity =>
            {
                entity.HasKey(e => e.RequestId);

                entity.ToTable("geocodes_requests", "rezoradata");

                entity.Property(e => e.RequestId)
                    .HasColumnName("request_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.JobCompleted).HasColumnName("job_completed");

                entity.Property(e => e.JobCreated).HasColumnName("job_created");

                entity.Property(e => e.JobDescription)
                    .IsRequired()
                    .HasColumnName("job_description")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobEntitiesFailed)
                    .HasColumnName("job_entities_failed")
                    .HasColumnType("int(11)");

                entity.Property(e => e.JobEntitiesProcessed)
                    .HasColumnName("job_entities_processed")
                    .HasColumnType("int(11)");

                entity.Property(e => e.JobEntitiesTotal)
                    .HasColumnName("job_entities_total")
                    .HasColumnType("int(11)");

                entity.Property(e => e.JobErrorMessage)
                    .HasColumnName("job_error_message")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JobId)
                    .IsRequired()
                    .HasColumnName("job_id")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JobStatus)
                    .IsRequired()
                    .HasColumnName("job_status")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RequestTimestamp)
                    .HasColumnName("request_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Groups>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.ToTable("groups", "rezoradata");

                entity.HasIndex(e => e.BrokerageId)
                    .HasName("brokerage_id");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BrokerageId)
                    .HasColumnName("brokerage_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GroupDescription)
                    .IsRequired()
                    .HasColumnName("group_description")
                    .IsUnicode(false);

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasColumnName("group_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GroupRestricted)
                    .HasColumnName("group_restricted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GroupTimestamp)
                    .HasColumnName("group_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<GroupsToAdmins>(entity =>
            {
                entity.HasKey(e => e.GrouptoadminId);

                entity.ToTable("groups_to_admins", "rezoradata");

                entity.Property(e => e.GrouptoadminId)
                    .HasColumnName("grouptoadmin_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GrouptoadmindTimestamp)
                    .HasColumnName("grouptoadmind_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<GroupsToCampaigns>(entity =>
            {
                entity.HasKey(e => e.GrouptocampaignId);

                entity.ToTable("groups_to_campaigns", "rezoradata");

                entity.HasIndex(e => new { e.GroupId, e.CampaignId })
                    .HasName("group_id")
                    .IsUnique();

                entity.Property(e => e.GrouptocampaignId)
                    .HasColumnName("grouptocampaign_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CampaignId)
                    .HasColumnName("campaign_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GrouptocampaignTimestamp)
                    .HasColumnName("grouptocampaign_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<GroupsToCrms>(entity =>
            {
                entity.HasKey(e => e.GtcrmId);

                entity.ToTable("groups_to_crms", "rezoradata");

                entity.Property(e => e.GtcrmId)
                    .HasColumnName("gtcrm_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BtcrmId)
                    .HasColumnName("btcrm_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GtcrmTimestamp).HasColumnName("gtcrm_timestamp");
            });

            modelBuilder.Entity<GroupsToElements>(entity =>
            {
                entity.HasKey(e => e.GteId);

                entity.ToTable("groups_to_elements", "rezoradata");

                entity.HasIndex(e => new { e.GroupId, e.BteId })
                    .HasName("group_id");

                entity.Property(e => e.GteId)
                    .HasColumnName("gte_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.BteId)
                    .HasColumnName("bte_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GteTimestamp)
                    .HasColumnName("gte_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<GroupsToMasterContactsLists>(entity =>
            {
                entity.HasKey(e => e.GrouptomastercontactslistsId);

                entity.ToTable("groups_to_master_contacts_lists", "rezoradata");

                entity.HasIndex(e => e.GrouptomastercontactslistsTimestamp)
                    .HasName("idx_timestamp");

                entity.HasIndex(e => new { e.ListId, e.GroupId })
                    .HasName("idx_list_group");

                entity.Property(e => e.GrouptomastercontactslistsId)
                    .HasColumnName("grouptomastercontactslists_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GrouptomastercontactslistsTimestamp).HasColumnName("grouptomastercontactslists_timestamp");

                entity.Property(e => e.ListId)
                    .HasColumnName("list_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<GroupsToTemplates>(entity =>
            {
                entity.HasKey(e => e.GrouptotemplateId);

                entity.ToTable("groups_to_templates", "rezoradata");

                entity.HasIndex(e => e.TemplateId)
                    .HasName("template_id");

                entity.HasIndex(e => new { e.GroupId, e.TemplateId })
                    .HasName("group_id")
                    .IsUnique();

                entity.Property(e => e.GrouptotemplateId)
                    .HasColumnName("grouptotemplate_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GrouptotemplateTimestamp)
                    .HasColumnName("grouptotemplate_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("template_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<InfoRequests>(entity =>
            {
                entity.HasKey(e => e.RequestId);

                entity.ToTable("info_requests", "rezoradata");

                entity.Property(e => e.RequestId)
                    .HasColumnName("request_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BrokerageId)
                    .HasColumnName("brokerage_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NewsletterId)
                    .HasColumnName("newsletter_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RequestMessage)
                    .IsRequired()
                    .HasColumnName("request_message")
                    .IsUnicode(false);

                entity.Property(e => e.RequestTimestamp)
                    .HasColumnName("request_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("template_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<LinkedinLog>(entity =>
            {
                entity.HasKey(e => e.RzPostId);

                entity.ToTable("linkedin_log", "rezoradata");

                entity.HasIndex(e => e.ItemId)
                    .HasName("newsletter_id");

                entity.HasIndex(e => e.LiPostId)
                    .HasName("li_post_id");

                entity.Property(e => e.RzPostId)
                    .HasColumnName("rz_post_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClickCount)
                    .HasColumnName("click_count")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId)
                    .HasColumnName("item_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LiDescription)
                    .IsRequired()
                    .HasColumnName("li_description")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.LiImage)
                    .IsRequired()
                    .HasColumnName("li_image")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.LiPostId)
                    .HasColumnName("li_post_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LiTitle)
                    .IsRequired()
                    .HasColumnName("li_title")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OpenCount)
                    .HasColumnName("open_count")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PotentialReach)
                    .HasColumnName("potential_reach")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RequestTimestamp)
                    .HasColumnName("request_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<MarketreportsCities>(entity =>
            {
                entity.HasKey(e => e.CityId);

                entity.ToTable("marketreports_cities", "rezoradata");

                entity.HasIndex(e => e.CountyId)
                    .HasName("county_id");

                entity.Property(e => e.CityId)
                    .HasColumnName("city_id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CityDisplayname)
                    .IsRequired()
                    .HasColumnName("city_displayname")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasColumnName("city_name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CityNameencoded)
                    .IsRequired()
                    .HasColumnName("city_nameencoded")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CityStatename)
                    .IsRequired()
                    .HasColumnName("city_statename")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CountyId)
                    .HasColumnName("county_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<MarketreportsCitiesToCounties>(entity =>
            {
                entity.HasKey(e => new { e.CountyId, e.CityId });

                entity.ToTable("marketreports_cities_to_counties", "rezoradata");

                entity.Property(e => e.CountyId)
                    .HasColumnName("county_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CityId)
                    .HasColumnName("city_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<MarketreportsCounties>(entity =>
            {
                entity.HasKey(e => e.CountyId);

                entity.ToTable("marketreports_counties", "rezoradata");

                entity.HasIndex(e => e.MarketId)
                    .HasName("market_id");

                entity.Property(e => e.CountyId)
                    .HasColumnName("county_id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CountyDisplayname)
                    .IsRequired()
                    .HasColumnName("county_displayname")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CountyName)
                    .IsRequired()
                    .HasColumnName("county_name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CountyNameencoded)
                    .IsRequired()
                    .HasColumnName("county_nameencoded")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MarketId)
                    .HasColumnName("market_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<MarketreportsCountiesToBrokerages>(entity =>
            {
                entity.HasKey(e => new { e.CountyId, e.BrokerageId });

                entity.ToTable("marketreports_counties_to_brokerages", "rezoradata");

                entity.Property(e => e.CountyId)
                    .HasColumnName("county_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BrokerageId)
                    .HasColumnName("brokerage_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<MarketreportsCountiesToMarkets>(entity =>
            {
                entity.HasKey(e => new { e.MarketId, e.CountyId });

                entity.ToTable("marketreports_counties_to_markets", "rezoradata");

                entity.Property(e => e.MarketId)
                    .HasColumnName("market_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CountyId)
                    .HasColumnName("county_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<MarketreportsMarkets>(entity =>
            {
                entity.HasKey(e => e.MarketId);

                entity.ToTable("marketreports_markets", "rezoradata");

                entity.Property(e => e.MarketId)
                    .HasColumnName("market_id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.MarketDisplayname)
                    .IsRequired()
                    .HasColumnName("market_displayname")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MarketName)
                    .IsRequired()
                    .HasColumnName("market_name")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MarketreportsZips>(entity =>
            {
                entity.HasKey(e => e.ZipId);

                entity.ToTable("marketreports_zips", "rezoradata");

                entity.HasIndex(e => e.CityId)
                    .HasName("city_id");

                entity.Property(e => e.ZipId)
                    .HasColumnName("zip_id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CityId)
                    .HasColumnName("city_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ZipDisplayname)
                    .IsRequired()
                    .HasColumnName("zip_displayname")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ZipName)
                    .IsRequired()
                    .HasColumnName("zip_name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ZipZip)
                    .IsRequired()
                    .HasColumnName("zip_zip")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MarketreportsZipsToCities>(entity =>
            {
                entity.HasKey(e => new { e.CityId, e.ZipId });

                entity.ToTable("marketreports_zips_to_cities", "rezoradata");

                entity.Property(e => e.CityId)
                    .HasColumnName("city_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ZipId)
                    .HasColumnName("zip_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<MasterCampaigns>(entity =>
            {
                entity.HasKey(e => e.CampaignId);

                entity.ToTable("master_campaigns", "rezoradata");

                entity.HasIndex(e => e.BrandId)
                    .HasName("brand_id");

                entity.HasIndex(e => e.CampaignRestricted)
                    .HasName("campaign_restricted");

                entity.HasIndex(e => e.CampaignStartdate)
                    .HasName("campaign_startdate");

                entity.HasIndex(e => e.CampaignStopdate)
                    .HasName("campaign_stopdate");

                entity.Property(e => e.CampaignId)
                    .HasColumnName("campaign_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BrandId)
                    .HasColumnName("brand_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CampaignDescription)
                    .IsRequired()
                    .HasColumnName("campaign_description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignDetails)
                    .IsRequired()
                    .HasColumnName("campaign_details")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignPhoto)
                    .IsRequired()
                    .HasColumnName("campaign_photo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignRestricted)
                    .HasColumnName("campaign_restricted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CampaignStartdate).HasColumnName("campaign_startdate");

                entity.Property(e => e.CampaignStopdate).HasColumnName("campaign_stopdate");

                entity.Property(e => e.CampaignTimestamp)
                    .HasColumnName("campaign_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CampaignTitle)
                    .IsRequired()
                    .HasColumnName("campaign_title")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MasterPropagated)
                    .HasColumnName("master_propagated")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<MasterCampaignsToBrokerages>(entity =>
            {
                entity.HasKey(e => e.MastercampaigntobrokerageId);

                entity.ToTable("master_campaigns_to_brokerages", "rezoradata");

                entity.HasIndex(e => new { e.CampaignId, e.BrokerageId })
                    .HasName("campaign_id")
                    .IsUnique();

                entity.Property(e => e.MastercampaigntobrokerageId)
                    .HasColumnName("mastercampaigntobrokerage_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BrokerageId)
                    .HasColumnName("brokerage_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CampaignId)
                    .HasColumnName("campaign_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MastercampaigntobrokerageTimestamp)
                    .HasColumnName("mastercampaigntobrokerage_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<MasterContacts>(entity =>
            {
                entity.HasKey(e => e.ContactId);

                entity.ToTable("master_contacts", "rezoradata");

                entity.HasIndex(e => e.ContactEmail)
                    .HasName("contact_email");

                entity.HasIndex(e => e.ContactSelf)
                    .HasName("contact_self");

                entity.HasIndex(e => e.ContactUnsubscribe)
                    .HasName("contact_unsubscribe");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.HasIndex(e => new { e.UserId, e.ContactDeleted, e.ContactUnsubscribe })
                    .HasName("user_id_2");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BounceScore).HasColumnName("bounce_score");

                entity.Property(e => e.ClickScore).HasColumnName("click_score");

                entity.Property(e => e.ContactBusinessCity)
                    .IsRequired()
                    .HasColumnName("contact_business_city")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactBusinessState)
                    .IsRequired()
                    .HasColumnName("contact_business_state")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactBusinessStreet)
                    .IsRequired()
                    .HasColumnName("contact_business_street")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactBusinessStreet2)
                    .IsRequired()
                    .HasColumnName("contact_business_street2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactBusinessZip)
                    .IsRequired()
                    .HasColumnName("contact_business_zip")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ContactCompany)
                    .IsRequired()
                    .HasColumnName("contact_company")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactCrmAccountId)
                    .IsRequired()
                    .HasColumnName("contact_crm_account_id")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactCrmId)
                    .IsRequired()
                    .HasColumnName("contact_crm_id")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactCrmOwnerId)
                    .IsRequired()
                    .HasColumnName("contact_crm_owner_id")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactDate)
                    .HasColumnName("contact_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ContactDeleted)
                    .HasColumnName("contact_deleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContactEditedDate)
                    .HasColumnName("contact_edited_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ContactEmail)
                    .IsRequired()
                    .HasColumnName("contact_email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactHomeCity)
                    .IsRequired()
                    .HasColumnName("contact_home_city")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactHomeState)
                    .IsRequired()
                    .HasColumnName("contact_home_state")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactHomeStreet)
                    .IsRequired()
                    .HasColumnName("contact_home_street")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactHomeStreet2)
                    .IsRequired()
                    .HasColumnName("contact_home_street2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactHomeZip)
                    .IsRequired()
                    .HasColumnName("contact_home_zip")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasColumnName("contact_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPhoneFax)
                    .IsRequired()
                    .HasColumnName("contact_phone_fax")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPhoneHome)
                    .IsRequired()
                    .HasColumnName("contact_phone_home")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPhoneMobile)
                    .IsRequired()
                    .HasColumnName("contact_phone_mobile")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPhoneWork)
                    .IsRequired()
                    .HasColumnName("contact_phone_work")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ContactSelf)
                    .HasColumnName("contact_self")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContactTitle)
                    .IsRequired()
                    .HasColumnName("contact_title")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactType)
                    .IsRequired()
                    .HasColumnName("contact_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ContactUnsubscribe)
                    .HasColumnName("contact_unsubscribe")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContactUpdating)
                    .HasColumnName("contact_updating")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContactVerifiedTimestamp).HasColumnName("contact_verified_timestamp");

                entity.Property(e => e.DetailsScore).HasColumnName("details_score");

                entity.Property(e => e.ElementId)
                    .HasColumnName("element_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EmailCount)
                    .HasColumnName("email_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LastScored)
                    .HasColumnName("last_scored")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OpenScore).HasColumnName("open_score");

                entity.Property(e => e.OptinFirst).HasColumnName("optin_first");

                entity.Property(e => e.OptinSecond).HasColumnName("optin_second");

                entity.Property(e => e.SearchScore).HasColumnName("search_score");

                entity.Property(e => e.SourceId)
                    .HasColumnName("source_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.SpamScore).HasColumnName("spam_score");

                entity.Property(e => e.UnsubscribeScore).HasColumnName("unsubscribe_score");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<MasterContactsImports>(entity =>
            {
                entity.HasKey(e => e.ImportId);

                entity.ToTable("master_contacts_imports", "rezoradata");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.ImportId)
                    .HasColumnName("import_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CompletedTimestamp).HasColumnName("completed_timestamp");

                entity.Property(e => e.HeaderType)
                    .IsRequired()
                    .HasColumnName("header_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ImportError)
                    .HasColumnName("import_error")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.ImportPath)
                    .IsRequired()
                    .HasColumnName("import_path")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ImportStatus)
                    .HasColumnName("import_status")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ListId)
                    .HasColumnName("list_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MergedCount)
                    .HasColumnName("merged_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Overwrite)
                    .HasColumnName("overwrite")
                    .HasColumnType("tinyint(11)");

                entity.Property(e => e.SubmittedCount)
                    .HasColumnName("submitted_count")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SubmittedTimestamp)
                    .HasColumnName("submitted_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TestBouncesResult)
                    .HasColumnName("test_bounces_result")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TestBouncesTimestamp).HasColumnName("test_bounces_timestamp");

                entity.Property(e => e.TestDeliveredResult)
                    .HasColumnName("test_delivered_result")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TestDeliveredTimestamp).HasColumnName("test_delivered_timestamp");

                entity.Property(e => e.TestDuplicatesResult)
                    .HasColumnName("test_duplicates_result")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TestDuplicatesTimestamp).HasColumnName("test_duplicates_timestamp");

                entity.Property(e => e.TestExistsResult)
                    .HasColumnName("test_exists_result")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TestExistsTimestamp).HasColumnName("test_exists_timestamp");

                entity.Property(e => e.TestHeadersResult)
                    .HasColumnName("test_headers_result")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TestHeadersTimestamp).HasColumnName("test_headers_timestamp");

                entity.Property(e => e.TestSmtpResult)
                    .HasColumnName("test_SMTP_result")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TestSmtpTimestamp).HasColumnName("test_SMTP_timestamp");

                entity.Property(e => e.TestSpamResult)
                    .HasColumnName("test_spam_result")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TestSpamTimestamp).HasColumnName("test_spam_timestamp");

                entity.Property(e => e.TestSyntaxResult)
                    .HasColumnName("test_syntax_result")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TestSyntaxTimestamp).HasColumnName("test_syntax_timestamp");

                entity.Property(e => e.TestUnsubscribesResult)
                    .HasColumnName("test_unsubscribes_result")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TestUnsubscribesTimestamp).HasColumnName("test_unsubscribes_timestamp");

                entity.Property(e => e.TestVerifiedResult)
                    .HasColumnName("test_verified_result")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TestVerifiedTimestamp).HasColumnName("test_verified_timestamp");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<MasterContactsImportsHolder>(entity =>
            {
                entity.HasKey(e => e.ContactId);

                entity.ToTable("master_contacts_imports_holder", "rezoradata");

                entity.HasIndex(e => e.ContactEmail)
                    .HasName("contact_email");

                entity.HasIndex(e => e.ImportId)
                    .HasName("import_id");

                entity.HasIndex(e => e.TestStatus)
                    .HasName("test_status");

                entity.HasIndex(e => new { e.ImportId, e.TestStatus, e.ContactEmail })
                    .HasName("import_id_2");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContactBusinessCity)
                    .IsRequired()
                    .HasColumnName("contact_business_city")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactBusinessState)
                    .IsRequired()
                    .HasColumnName("contact_business_state")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactBusinessStreet)
                    .IsRequired()
                    .HasColumnName("contact_business_street")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactBusinessStreet2)
                    .IsRequired()
                    .HasColumnName("contact_business_street2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactBusinessZip)
                    .IsRequired()
                    .HasColumnName("contact_business_zip")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ContactCompany)
                    .IsRequired()
                    .HasColumnName("contact_company")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactEmail)
                    .IsRequired()
                    .HasColumnName("contact_email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactHomeCity)
                    .IsRequired()
                    .HasColumnName("contact_home_city")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactHomeState)
                    .IsRequired()
                    .HasColumnName("contact_home_state")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactHomeStreet)
                    .IsRequired()
                    .HasColumnName("contact_home_street")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactHomeStreet2)
                    .IsRequired()
                    .HasColumnName("contact_home_street2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactHomeZip)
                    .IsRequired()
                    .HasColumnName("contact_home_zip")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasColumnName("contact_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPhoneFax)
                    .IsRequired()
                    .HasColumnName("contact_phone_fax")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPhoneHome)
                    .IsRequired()
                    .HasColumnName("contact_phone_home")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPhoneMobile)
                    .IsRequired()
                    .HasColumnName("contact_phone_mobile")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPhoneWork)
                    .IsRequired()
                    .HasColumnName("contact_phone_work")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTimestamp)
                    .HasColumnName("contact_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ContactTitle)
                    .IsRequired()
                    .HasColumnName("contact_title")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactUnsubscribe)
                    .HasColumnName("contact_unsubscribe")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ImportId)
                    .HasColumnName("import_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TestStatus)
                    .HasColumnName("test_status")
                    .HasColumnType("int(4)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<MasterContactsLists>(entity =>
            {
                entity.HasKey(e => e.ListId);

                entity.ToTable("master_contacts_lists", "rezoradata");

                entity.HasIndex(e => e.ListType)
                    .HasName("list_type");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.ListId)
                    .HasColumnName("list_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BrokerageId)
                    .HasColumnName("brokerage_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ListDate)
                    .HasColumnName("list_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ListName)
                    .IsRequired()
                    .HasColumnName("list_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ListRestricted)
                    .HasColumnName("list_restricted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ListType)
                    .HasColumnName("list_type")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ListUpdating)
                    .HasColumnName("list_updating")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<MasterContactsToLists>(entity =>
            {
                entity.HasKey(e => e.ContacttolistId);

                entity.ToTable("master_contacts_to_lists", "rezoradata");

                entity.HasIndex(e => e.ContactId)
                    .HasName("contact_id");

                entity.HasIndex(e => e.ListId)
                    .HasName("list_id");

                entity.HasIndex(e => new { e.ContactId, e.ListId })
                    .HasName("contact_id_2")
                    .IsUnique();

                entity.Property(e => e.ContacttolistId)
                    .HasColumnName("contacttolist_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContacttolistDate)
                    .HasColumnName("contacttolist_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ContacttolistUpdating)
                    .HasColumnName("contacttolist_updating")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ListId)
                    .HasColumnName("list_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<MasterListsToUsers>(entity =>
            {
                entity.HasKey(e => e.MasterlisttouserId);

                entity.ToTable("master_lists_to_users", "rezoradata");

                entity.HasIndex(e => e.FromGroup)
                    .HasName("idx_from_group");

                entity.HasIndex(e => e.ListId)
                    .HasName("idx_list_id");

                entity.HasIndex(e => new { e.FromGroup, e.ListId })
                    .HasName("idx_from_group_list_id");

                entity.HasIndex(e => new { e.ListId, e.UserId, e.FromGroup })
                    .HasName("idx_list_id_user_id_from_group");

                entity.Property(e => e.MasterlisttouserId)
                    .HasColumnName("masterlisttouser_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FromGroup)
                    .HasColumnName("from_group")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ListAccepted)
                    .HasColumnName("list_accepted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ListId)
                    .HasColumnName("list_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ListIgnored)
                    .HasColumnName("list_ignored")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MasterlisttouserTimestamp).HasColumnName("masterlisttouser_timestamp");

                entity.Property(e => e.Revoking)
                    .HasColumnName("revoking")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<MasterNewsletters>(entity =>
            {
                entity.HasKey(e => e.NewsletterId);

                entity.ToTable("master_newsletters", "rezoradata");

                entity.HasIndex(e => e.TemplateId)
                    .HasName("template_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.NewsletterId)
                    .HasColumnName("newsletter_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BounceCount)
                    .HasColumnName("bounce_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClickCount)
                    .HasColumnName("click_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EmailCount)
                    .HasColumnName("email_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EmsEmailId)
                    .IsRequired()
                    .HasColumnName("ems_email_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewsletterAdminPublished).HasColumnName("newsletter_admin_published");

                entity.Property(e => e.NewsletterAllowOnline)
                    .HasColumnName("newsletter_allow_online")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NewsletterArticles)
                    .HasColumnName("newsletter_articles")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NewsletterAuthorized)
                    .HasColumnName("newsletter_authorized")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.NewsletterAutomated)
                    .HasColumnName("newsletter_automated")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NewsletterCampaignName)
                    .IsRequired()
                    .HasColumnName("newsletter_campaign_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NewsletterDate).HasColumnName("newsletter_date");

                entity.Property(e => e.NewsletterEditedDate)
                    .HasColumnName("newsletter_edited_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.NewsletterHeadline)
                    .IsRequired()
                    .HasColumnName("newsletter_headline")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NewsletterHeadline2)
                    .IsRequired()
                    .HasColumnName("newsletter_headline2")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NewsletterHeadline3)
                    .IsRequired()
                    .HasColumnName("newsletter_headline3")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NewsletterHeadline4)
                    .IsRequired()
                    .HasColumnName("newsletter_headline4")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NewsletterHeadline5)
                    .IsRequired()
                    .HasColumnName("newsletter_headline5")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NewsletterHeight)
                    .HasColumnName("newsletter_height")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NewsletterHtmlTimestamp).HasColumnName("newsletter_html_timestamp");

                entity.Property(e => e.NewsletterJson)
                    .IsRequired()
                    .HasColumnName("newsletter_json")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.NewsletterJsonDraft)
                    .IsRequired()
                    .HasColumnName("newsletter_json_draft")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.NewsletterListings)
                    .HasColumnName("newsletter_listings")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NewsletterMessage)
                    .IsRequired()
                    .HasColumnName("newsletter_message")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.NewsletterPreviewId)
                    .IsRequired()
                    .HasColumnName("newsletter_preview_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewsletterProds)
                    .HasColumnName("newsletter_prods")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NewsletterReportCharts)
                    .IsRequired()
                    .HasColumnName("newsletter_report_charts")
                    .IsUnicode(false);

                entity.Property(e => e.NewsletterReportStats)
                    .IsRequired()
                    .HasColumnName("newsletter_report_stats")
                    .IsUnicode(false);

                entity.Property(e => e.NewsletterRsvp)
                    .HasColumnName("newsletter_rsvp")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NewsletterSentDate).HasColumnName("newsletter_sent_date");

                entity.Property(e => e.NewsletterSubject)
                    .IsRequired()
                    .HasColumnName("newsletter_subject")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NewsletterTitle)
                    .IsRequired()
                    .HasColumnName("newsletter_title")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NewsletterVersion)
                    .HasColumnName("newsletter_version")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.NewsletterWidth)
                    .HasColumnName("newsletter_width")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OpenCount)
                    .HasColumnName("open_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ReachCount)
                    .HasColumnName("reach_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SpamCount)
                    .HasColumnName("spam_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("template_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ThumbnailTimestamp).HasColumnName("thumbnail_timestamp");

                entity.Property(e => e.TotalClickCount)
                    .HasColumnName("total_click_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TotalOpenCount)
                    .HasColumnName("total_open_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<MasterNewslettersArticles>(entity =>
            {
                entity.HasKey(e => e.MasterarticleId);

                entity.ToTable("master_newsletters_articles", "rezoradata");

                entity.HasIndex(e => e.ArticleOrder)
                    .HasName("article_order");

                entity.HasIndex(e => e.NewsletterId)
                    .HasName("newsletter_id");

                entity.HasIndex(e => new { e.NewsletterId, e.ArticleOrder })
                    .HasName("newsletter_id_2")
                    .IsUnique();

                entity.Property(e => e.MasterarticleId)
                    .HasColumnName("masterarticle_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArticleDate)
                    .IsRequired()
                    .HasColumnName("article_date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ArticleLink)
                    .IsRequired()
                    .HasColumnName("article_link")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ArticleOrder)
                    .HasColumnName("article_order")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArticleSource)
                    .IsRequired()
                    .HasColumnName("article_source")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ArticleSummary)
                    .IsRequired()
                    .HasColumnName("article_summary")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ArticleTimestamp)
                    .HasColumnName("article_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ArticleTitle)
                    .IsRequired()
                    .HasColumnName("article_title")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NewsletterId)
                    .HasColumnName("newsletter_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<MasterNewslettersToListings>(entity =>
            {
                entity.HasKey(e => e.MasternewslettertolistingId);

                entity.ToTable("master_newsletters_to_listings", "rezoradata");

                entity.HasIndex(e => e.ListingId)
                    .HasName("property_id");

                entity.HasIndex(e => e.NewsletterId)
                    .HasName("newsletter_id");

                entity.HasIndex(e => new { e.NewsletterId, e.NewslettertolistingOrder })
                    .HasName("newsletter_id_2")
                    .IsUnique();

                entity.Property(e => e.MasternewslettertolistingId)
                    .HasColumnName("masternewslettertolisting_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ListingId)
                    .IsRequired()
                    .HasColumnName("listing_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.ListingTypeId)
                    .HasColumnName("listing_type_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("6");

                entity.Property(e => e.NewsletterId)
                    .HasColumnName("newsletter_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NewslettertolistingDate)
                    .HasColumnName("newslettertolisting_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.NewslettertolistingHeadline)
                    .HasColumnName("newslettertolisting_headline")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NewslettertolistingMessage)
                    .HasColumnName("newslettertolisting_message")
                    .IsUnicode(false);

                entity.Property(e => e.NewslettertolistingOrder)
                    .HasColumnName("newslettertolisting_order")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OrgId)
                    .IsRequired()
                    .HasColumnName("org_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterNewslettersToProds>(entity =>
            {
                entity.HasKey(e => e.MasternewslettertoprodId);

                entity.ToTable("master_newsletters_to_prods", "rezoradata");

                entity.HasIndex(e => e.NewsletterId)
                    .HasName("newsletter_id");

                entity.HasIndex(e => e.NewslettertoprodOrder)
                    .HasName("newslettertoprod_order");

                entity.HasIndex(e => e.ProdId)
                    .HasName("product_id");

                entity.HasIndex(e => new { e.NewsletterId, e.NewslettertoprodOrder })
                    .HasName("newsletter_id_2")
                    .IsUnique();

                entity.Property(e => e.MasternewslettertoprodId)
                    .HasColumnName("masternewslettertoprod_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NewsletterId)
                    .HasColumnName("newsletter_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NewslettertoprodDate)
                    .HasColumnName("newslettertoprod_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.NewslettertoprodHeadline)
                    .HasColumnName("newslettertoprod_headline")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NewslettertoprodMessage)
                    .HasColumnName("newslettertoprod_message")
                    .IsUnicode(false);

                entity.Property(e => e.NewslettertoprodOrder)
                    .HasColumnName("newslettertoprod_order")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProdId)
                    .HasColumnName("prod_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<MasterNewslettersToRsvpevent>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.ToTable("master_newsletters_to_rsvpevent", "rezoradata");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EventCapacity)
                    .HasColumnName("event_capacity")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EventChangeddate)
                    .HasColumnName("event_changeddate")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.EventCreateddate)
                    .HasColumnName("event_createddate")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.EventCurrency)
                    .IsRequired()
                    .HasColumnName("event_currency")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EventDescription)
                    .IsRequired()
                    .HasColumnName("event_description")
                    .IsUnicode(false);

                entity.Property(e => e.EventEnddate)
                    .HasColumnName("event_enddate")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.EventLogoUrl)
                    .HasColumnName("event_logo_url")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EventName)
                    .IsRequired()
                    .HasColumnName("event_name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EventOnline)
                    .HasColumnName("event_online")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EventStartdate)
                    .HasColumnName("event_startdate")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.EventStatus)
                    .IsRequired()
                    .HasColumnName("event_status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EventUrl)
                    .IsRequired()
                    .HasColumnName("event_url")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EventVenueAddr)
                    .IsRequired()
                    .HasColumnName("event_venue_addr")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EventVenueLat)
                    .IsRequired()
                    .HasColumnName("event_venue_lat")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EventVenueLon)
                    .IsRequired()
                    .HasColumnName("event_venue_lon")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EventVenueName)
                    .IsRequired()
                    .HasColumnName("event_venue_name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NewsletterId)
                    .HasColumnName("newsletter_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<MasterSchedules>(entity =>
            {
                entity.HasKey(e => e.ScheduleId);

                entity.ToTable("master_schedules", "rezoradata");

                entity.Property(e => e.ScheduleId)
                    .HasColumnName("schedule_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BounceCount)
                    .HasColumnName("bounce_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BrandId)
                    .HasColumnName("brand_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClickCount)
                    .HasColumnName("click_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EmailCount)
                    .HasColumnName("email_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OpenCount)
                    .HasColumnName("open_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ScheduleDatetime).HasColumnName("schedule_datetime");

                entity.Property(e => e.ScheduleExpiration).HasColumnName("schedule_expiration");

                entity.Property(e => e.ScheduleFinishdate).HasColumnName("schedule_finishdate");

                entity.Property(e => e.ScheduleMessage)
                    .IsRequired()
                    .HasColumnName("schedule_message")
                    .IsUnicode(false);

                entity.Property(e => e.ScheduleSentdate).HasColumnName("schedule_sentdate");

                entity.Property(e => e.ScheduleStartdate).HasColumnName("schedule_startdate");

                entity.Property(e => e.ScheduleSubject)
                    .IsRequired()
                    .HasColumnName("schedule_subject")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ScheduleTimestamp)
                    .HasColumnName("schedule_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ScheduleUseLocal)
                    .HasColumnName("schedule_use_local")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ScheduleUseLocalTimezone)
                    .HasColumnName("schedule_use_local_timezone")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.SpamCount)
                    .HasColumnName("spam_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("template_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<MasterTemplates>(entity =>
            {
                entity.HasKey(e => e.TemplateId);

                entity.ToTable("master_templates", "rezoradata");

                entity.HasIndex(e => e.BrandId)
                    .HasName("brand_id");

                entity.HasIndex(e => e.RequestContactUserId)
                    .HasName("request_contact_user_id");

                entity.HasIndex(e => e.TemplateClass)
                    .HasName("template_class");

                entity.HasIndex(e => e.TemplateRestricted)
                    .HasName("template_restricted");

                entity.HasIndex(e => e.TemplateTitle)
                    .HasName("template_title");

                entity.HasIndex(e => e.TemplateTypeId)
                    .HasName("template_type_id");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("template_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AllowEmail)
                    .HasColumnName("allow_email")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.AllowOnline)
                    .HasColumnName("allow_online")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.AllowPrint)
                    .HasColumnName("allow_print")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BounceCount)
                    .HasColumnName("bounce_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BrandId)
                    .HasColumnName("brand_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClickCount)
                    .HasColumnName("click_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EmailCount)
                    .HasColumnName("email_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsDisplayAd)
                    .HasColumnName("is_display_ad")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsResponsive)
                    .HasColumnName("is_responsive")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsWellcomemat)
                    .HasColumnName("is_wellcomemat")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MasterEnabled)
                    .HasColumnName("master_enabled")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MasterPropagated)
                    .HasColumnName("master_propagated")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.OpenCount)
                    .HasColumnName("open_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ReachCount)
                    .HasColumnName("reach_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ReportCharts)
                    .IsRequired()
                    .HasColumnName("report_charts")
                    .IsUnicode(false);

                entity.Property(e => e.ReportStats)
                    .IsRequired()
                    .HasColumnName("report_stats")
                    .IsUnicode(false);

                entity.Property(e => e.RequestContactUserId)
                    .HasColumnName("request_contact_user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RequestMessage)
                    .IsRequired()
                    .HasColumnName("request_message")
                    .IsUnicode(false);

                entity.Property(e => e.RequestUrl)
                    .IsRequired()
                    .HasColumnName("request_url")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SpamCount)
                    .HasColumnName("spam_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplateArchived)
                    .HasColumnName("template_archived")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TemplateArticles)
                    .HasColumnName("template_articles")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplateCampaignId)
                    .HasColumnName("template_campaign_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TemplateCampaignName)
                    .IsRequired()
                    .HasColumnName("template_campaign_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateClass)
                    .HasColumnName("template_class")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.TemplateDate)
                    .HasColumnName("template_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TemplateDefaultMessage)
                    .IsRequired()
                    .HasColumnName("template_default_message")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.TemplateDefaultSubject)
                    .IsRequired()
                    .HasColumnName("template_default_subject")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateHead)
                    .IsRequired()
                    .HasColumnName("template_head")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.TemplateHeadlines)
                    .HasColumnName("template_headlines")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplateHeight)
                    .HasColumnName("template_height")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TemplateHtmlTimestamp).HasColumnName("template_html_timestamp");

                entity.Property(e => e.TemplateJson)
                    .IsRequired()
                    .HasColumnName("template_json")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.TemplateJsonDraft)
                    .IsRequired()
                    .HasColumnName("template_json_draft")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.TemplateListings)
                    .HasColumnName("template_listings")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplateMessageMax)
                    .HasColumnName("template_message_max")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplateMessages)
                    .HasColumnName("template_messages")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplateName)
                    .IsRequired()
                    .HasColumnName("template_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateNotes)
                    .IsRequired()
                    .HasColumnName("template_notes")
                    .IsUnicode(false);

                entity.Property(e => e.TemplatePath)
                    .IsRequired()
                    .HasColumnName("template_path")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TemplatePchefprods)
                    .HasColumnName("template_pchefprods")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TemplatePreviewId)
                    .IsRequired()
                    .HasColumnName("template_preview_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TemplatePrice).HasColumnName("template_price");

                entity.Property(e => e.TemplateProds)
                    .HasColumnName("template_prods")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TemplateRestricted)
                    .HasColumnName("template_restricted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplateRsvp)
                    .HasColumnName("template_rsvp")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TemplateStatus)
                    .HasColumnName("template_status")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.TemplateThumbnailPath)
                    .IsRequired()
                    .HasColumnName("template_thumbnail_path")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateTitle)
                    .IsRequired()
                    .HasColumnName("template_title")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateTypeId)
                    .HasColumnName("template_type_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("33");

                entity.Property(e => e.TemplateVersion)
                    .HasColumnName("template_version")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.TemplateWidth)
                    .HasColumnName("template_width")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ThumbnailTimestamp).HasColumnName("thumbnail_timestamp");

                entity.Property(e => e.TotalClickCount)
                    .HasColumnName("total_click_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TotalOpenCount)
                    .HasColumnName("total_open_count")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.TemplateType)
                    .WithMany(p => p.MasterTemplates)
                    .HasForeignKey(d => d.TemplateTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("master_templates_ibfk_1");
            });

            modelBuilder.Entity<MasterTemplatesCats>(entity =>
            {
                entity.HasKey(e => e.CatId);

                entity.ToTable("master_templates_cats", "rezoradata");

                entity.HasIndex(e => e.BrandId)
                    .HasName("brand_id");

                entity.HasIndex(e => e.CatTitle)
                    .HasName("type_title");

                entity.Property(e => e.CatId)
                    .HasColumnName("cat_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BrandId)
                    .HasColumnName("brand_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CatDate)
                    .HasColumnName("cat_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CatTitle)
                    .IsRequired()
                    .HasColumnName("cat_title")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterTemplatesToBrokerages>(entity =>
            {
                entity.HasKey(e => e.TemplatetobrokerageId);

                entity.ToTable("master_templates_to_brokerages", "rezoradata");

                entity.HasIndex(e => new { e.TemplateId, e.BrokerageId })
                    .HasName("template_id")
                    .IsUnique();

                entity.Property(e => e.TemplatetobrokerageId)
                    .HasColumnName("templatetobrokerage_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BrokerageId)
                    .HasColumnName("brokerage_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("template_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplatetobrokerageTimestamp)
                    .HasColumnName("templatetobrokerage_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<MasterTemplatesToCampaigns>(entity =>
            {
                entity.HasKey(e => e.MastertemplatetocampaignId);

                entity.ToTable("master_templates_to_campaigns", "rezoradata");

                entity.HasIndex(e => new { e.TemplateId, e.CampaignId })
                    .HasName("template_id")
                    .IsUnique();

                entity.Property(e => e.MastertemplatetocampaignId)
                    .HasColumnName("mastertemplatetocampaign_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CampaignId)
                    .HasColumnName("campaign_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MastertemplatetocampaignTimestamp)
                    .HasColumnName("mastertemplatetocampaign_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("template_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<MasterTemplatesToCats>(entity =>
            {
                entity.HasKey(e => new { e.CatId, e.TemplateId });

                entity.ToTable("master_templates_to_cats", "rezoradata");

                entity.Property(e => e.CatId)
                    .HasColumnName("cat_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("template_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<MasterTemplatesToDisplayads>(entity =>
            {
                entity.HasKey(e => e.TemplatetodisplayadId);

                entity.ToTable("master_templates_to_displayads", "rezoradata");

                entity.HasIndex(e => e.TemplateId)
                    .HasName("template_id");

                entity.Property(e => e.TemplatetodisplayadId)
                    .HasColumnName("templatetodisplayad_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DisplayadImageFormat)
                    .IsRequired()
                    .HasColumnName("displayad_image_format")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("png");

                entity.Property(e => e.DisplayadImageLeft)
                    .HasColumnName("displayad_image_left")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DisplayadImageTop)
                    .HasColumnName("displayad_image_top")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DisplayadImageWidth)
                    .HasColumnName("displayad_image_width")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("400");

                entity.Property(e => e.SitescoutCreativeType)
                    .IsRequired()
                    .HasColumnName("sitescout_creative_type")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("banner");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("template_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<MasterTemplatesToJson>(entity =>
            {
                entity.HasKey(e => e.TemplateToJsonId);

                entity.ToTable("master_templates_to_json", "rezoradata");

                entity.HasIndex(e => e.TemplateId)
                    .HasName("template_id");

                entity.Property(e => e.TemplateToJsonId)
                    .HasColumnName("template_to_json_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("template_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplateJson)
                    .IsRequired()
                    .HasColumnName("template_json")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.TemplateToJsonTimestamp)
                    .HasColumnName("template_to_json_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<MattContent>(entity =>
            {
                entity.HasKey(e => e.ContentId);

                entity.ToTable("matt_content", "rezoradata");

                entity.HasIndex(e => e.ContentClassId)
                    .HasName("content_class_id");

                entity.HasIndex(e => e.ContentOwnerId)
                    .HasName("content_owner_id");

                entity.HasIndex(e => e.ContentOwnerTypeId)
                    .HasName("content_owner_type_id");

                entity.HasIndex(e => new { e.ContentOwnerTypeId, e.ContentOwnerId })
                    .HasName("idx_content_user");

                entity.Property(e => e.ContentId)
                    .HasColumnName("content_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.AllowPrint)
                    .HasColumnName("allow_print")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContentClassId)
                    .HasColumnName("content_class_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContentHeight)
                    .HasColumnName("content_height")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContentJson)
                    .IsRequired()
                    .HasColumnName("content_json")
                    .HasColumnType("longtext");

                entity.Property(e => e.ContentJsonDraft)
                    .HasColumnName("content_json_draft")
                    .HasColumnType("longtext");

                entity.Property(e => e.ContentOwnerId)
                    .HasColumnName("content_owner_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContentOwnerTypeId)
                    .HasColumnName("content_owner_type_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContentRestricted)
                    .HasColumnName("content_restricted")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContentTimestamp).HasColumnName("content_timestamp");

                entity.Property(e => e.ContentTitle)
                    .IsRequired()
                    .HasColumnName("content_title")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContentWidth)
                    .HasColumnName("content_width")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsDisplayAd)
                    .HasColumnName("is_display_ad")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<MattContentClass>(entity =>
            {
                entity.HasKey(e => e.ContentClassId);

                entity.ToTable("matt_content_class", "rezoradata");

                entity.Property(e => e.ContentClassId)
                    .HasColumnName("content_class_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.ContentClassName)
                    .IsRequired()
                    .HasColumnName("content_class_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContentClassNameVisible)
                    .HasColumnName("content_class_name_visible")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MattContentHidden>(entity =>
            {
                entity.ToTable("matt_content_hidden", "rezoradata");

                entity.HasIndex(e => e.ContentId)
                    .HasName("content_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.HasIndex(e => new { e.ContentId, e.UserId })
                    .HasName("idx_content_user");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.ContentId)
                    .HasColumnName("content_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<MattContentToJson>(entity =>
            {
                entity.HasKey(e => e.ContentToJsonId);

                entity.ToTable("matt_content_to_json", "rezoradata");

                entity.HasIndex(e => e.ContentId)
                    .HasName("content_id");

                entity.Property(e => e.ContentToJsonId)
                    .HasColumnName("content_to_json_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContentId)
                    .HasColumnName("content_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContentJson)
                    .IsRequired()
                    .HasColumnName("content_json")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.ContentToJsonTimestamp)
                    .HasColumnName("content_to_json_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<MattOwnerType>(entity =>
            {
                entity.HasKey(e => e.OwnerTypeId);

                entity.ToTable("matt_owner_type", "rezoradata");

                entity.Property(e => e.OwnerTypeId)
                    .HasColumnName("Owner_type_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.OwnerTypeName)
                    .IsRequired()
                    .HasColumnName("Owner_type_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MattSectionClass>(entity =>
            {
                entity.HasKey(e => e.SectionClassId);

                entity.ToTable("matt_section_class", "rezoradata");

                entity.Property(e => e.SectionClassId)
                    .HasColumnName("section_class_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.SectionClassName)
                    .IsRequired()
                    .HasColumnName("section_class_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MattSections>(entity =>
            {
                entity.HasKey(e => e.SectionId);

                entity.ToTable("matt_sections", "rezoradata");

                entity.Property(e => e.SectionId)
                    .HasColumnName("section_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.SectionClassId)
                    .HasColumnName("section_class_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SectionDistributeMethod)
                    .HasColumnName("section_distribute_method")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SectionJson)
                    .IsRequired()
                    .HasColumnName("section_json")
                    .HasColumnType("longtext");

                entity.Property(e => e.SectionJsonDraft)
                    .HasColumnName("section_json_draft")
                    .HasColumnType("longtext");

                entity.Property(e => e.SectionOwnerId)
                    .HasColumnName("section_owner_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SectionOwnerTypeId)
                    .HasColumnName("section_owner_type_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SectionRestricted)
                    .HasColumnName("section_restricted")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SectionTimestamp).HasColumnName("section_timestamp");

                entity.Property(e => e.SectionTitle)
                    .IsRequired()
                    .HasColumnName("section_title")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MattSectionsHidden>(entity =>
            {
                entity.ToTable("matt_sections_hidden", "rezoradata");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.SectionId)
                    .HasColumnName("section_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<MattSectionToJson>(entity =>
            {
                entity.HasKey(e => e.SectionToJsonId);

                entity.ToTable("matt_section_to_json", "rezoradata");

                entity.HasIndex(e => e.SectionId)
                    .HasName("section_id");

                entity.Property(e => e.SectionToJsonId)
                    .HasColumnName("section_to_json_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SectionId)
                    .HasColumnName("section_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SectionJson)
                    .IsRequired()
                    .HasColumnName("section_json")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.SectionToJsonTimestamp)
                    .HasColumnName("section_to_json_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<MattTemplatestarters>(entity =>
            {
                entity.HasKey(e => e.TemplatestarterId);

                entity.ToTable("matt_templatestarters", "rezoradata");

                entity.Property(e => e.TemplatestarterId)
                    .HasColumnName("templatestarter_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.AllowEmail)
                    .HasColumnName("allow_email")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.AllowPrint)
                    .HasColumnName("allow_print")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsDisplayAd)
                    .HasColumnName("is_display_ad")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsWellcomemat)
                    .HasColumnName("is_wellcomemat")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TemplateArticles)
                    .HasColumnName("template_articles")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplateDefaultMessage)
                    .IsRequired()
                    .HasColumnName("template_default_message")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.TemplateDefaultSubject)
                    .IsRequired()
                    .HasColumnName("template_default_subject")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateHeadlines)
                    .HasColumnName("template_headlines")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplateHeight)
                    .HasColumnName("template_height")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TemplateListings)
                    .HasColumnName("template_listings")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplateMessages)
                    .HasColumnName("template_messages")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplatePchefprods)
                    .HasColumnName("template_pchefprods")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TemplateProds)
                    .HasColumnName("template_prods")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TemplateRsvp)
                    .HasColumnName("template_rsvp")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplateWidth)
                    .HasColumnName("template_width")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TemplatestarterJson)
                    .HasColumnName("templatestarter_json")
                    .HasColumnType("longtext");

                entity.Property(e => e.TemplatestarterOwnerId)
                    .HasColumnName("templatestarter_owner_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplatestarterOwnerTypeId)
                    .HasColumnName("templatestarter_owner_type_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplatestarterTitle)
                    .HasColumnName("templatestarter_title")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Messages>(entity =>
            {
                entity.HasKey(e => e.MessageId);

                entity.ToTable("messages", "rezoradata");

                entity.HasIndex(e => e.BrokerageId)
                    .HasName("brokerage_id");

                entity.HasIndex(e => e.MessageDashboard)
                    .HasName("message_dashboard");

                entity.HasIndex(e => e.MessageHome)
                    .HasName("message_home");

                entity.HasIndex(e => e.MessageMarketing)
                    .HasName("message_marketing");

                entity.HasIndex(e => e.MessageReport)
                    .HasName("message_report");

                entity.HasIndex(e => e.MessageWeight)
                    .HasName("message_weight");

                entity.HasIndex(e => e.UserTypeId)
                    .HasName("user_type_id");

                entity.Property(e => e.MessageId)
                    .HasColumnName("message_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BrokerageId)
                    .HasColumnName("brokerage_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MessageDashboard)
                    .HasColumnName("message_dashboard")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MessageHome)
                    .HasColumnName("message_home")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MessageMarketing)
                    .HasColumnName("message_marketing")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MessageReport)
                    .HasColumnName("message_report")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MessageStartdate).HasColumnName("message_startdate");

                entity.Property(e => e.MessageStopdate).HasColumnName("message_stopdate");

                entity.Property(e => e.MessageText)
                    .IsRequired()
                    .HasColumnName("message_text")
                    .IsUnicode(false);

                entity.Property(e => e.MessageTimestamp)
                    .HasColumnName("message_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.MessageTitle)
                    .IsRequired()
                    .HasColumnName("message_title")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MessageType)
                    .IsRequired()
                    .HasColumnName("message_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MessageWeight)
                    .HasColumnName("message_weight")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserTypeId)
                    .HasColumnName("user_type_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<MlsAgents>(entity =>
            {
                entity.HasKey(e => new { e.OrgId, e.AgId });

                entity.ToTable("mls_agents", "rezoradata");

                entity.HasIndex(e => e.LastImport)
                    .HasName("last_import");

                entity.Property(e => e.OrgId)
                    .HasColumnName("org_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AgId)
                    .HasColumnName("ag_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.AdAddress)
                    .HasColumnName("ad_address")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdCityName)
                    .HasColumnName("ad_city_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdState)
                    .HasColumnName("ad_state")
                    .HasColumnType("char(2)");

                entity.Property(e => e.AdZipCode)
                    .HasColumnName("ad_zip_code")
                    .HasColumnType("char(5)");

                entity.Property(e => e.AgEmail)
                    .HasColumnName("ag_email")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.AgMemberSecondaryId)
                    .HasColumnName("ag_member_secondary_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.AgNameFirst)
                    .HasColumnName("ag_name_first")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AgNameLast)
                    .IsRequired()
                    .HasColumnName("ag_name_last")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AgNameMiddle)
                    .HasColumnName("ag_name_middle")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AgOfficeId)
                    .IsRequired()
                    .HasColumnName("ag_office_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.AgOfficeMobile)
                    .HasColumnName("ag_office_mobile")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.AgOfficePhone)
                    .HasColumnName("ag_office_phone")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.AgOfficePhoneExt)
                    .HasColumnName("ag_office_phone_ext")
                    .HasColumnType("char(5)");

                entity.Property(e => e.AgPassword)
                    .HasColumnName("ag_password")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.AgPhone)
                    .HasColumnName("ag_phone")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.AgPhoneFax)
                    .HasColumnName("ag_phone_fax")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.AgPhonePager)
                    .HasColumnName("ag_phone_pager")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.AgPhoneVoiceMail)
                    .HasColumnName("ag_phone_voice_mail")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.AgRealEstateLicenseNumber)
                    .HasColumnName("ag_real_estate_license_number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgStatus)
                    .HasColumnName("ag_status")
                    .HasColumnType("char(1)");

                entity.Property(e => e.AgType)
                    .HasColumnName("ag_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgWebsite)
                    .HasColumnName("ag_website")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IddAccessYn)
                    .HasColumnName("idd_access_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.IddParticipateYn)
                    .HasColumnName("idd_participate_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InKeepDataCurrentFromMlsYn)
                    .HasColumnName("in_keep_data_current_from_mls_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InLoadDate).HasColumnName("in_load_date");

                entity.Property(e => e.InTransactDate).HasColumnName("in_transact_date");

                entity.Property(e => e.LastImport)
                    .HasColumnName("last_import")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.PublishStatus)
                    .HasColumnName("publish_status")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<MlsBusListings>(entity =>
            {
                entity.HasKey(e => new { e.OrgId, e.ListingId });

                entity.ToTable("mls_bus_listings", "rezoradata");

                entity.HasIndex(e => e.LastImport)
                    .HasName("last_import");

                entity.HasIndex(e => new { e.LastImport, e.OrgId })
                    .HasName("updatefilter");

                entity.HasIndex(e => new { e.InLatitude, e.InLongitude, e.ListOnInternetYn, e.PublishStatus })
                    .HasName("geocoded");

                entity.Property(e => e.OrgId)
                    .HasColumnName("org_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ListingId)
                    .HasColumnName("listing_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.AdArea)
                    .HasColumnName("ad_area")
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.AdBlockNumber)
                    .HasColumnName("ad_block_number")
                    .HasColumnType("char(4)");

                entity.Property(e => e.AdCityName)
                    .HasColumnName("ad_city_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AdCountyCode)
                    .HasColumnName("ad_county_code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AdCountyFips)
                    .HasColumnName("ad_county_fips")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AdCrossStreets)
                    .HasColumnName("ad_cross_streets")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AdDirections)
                    .HasColumnName("ad_directions")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoCityName)
                    .HasColumnName("ad_geo_city_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoState)
                    .HasColumnName("ad_geo_state")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoStreetDesignator)
                    .HasColumnName("ad_geo_street_designator")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoStreetDirection)
                    .HasColumnName("ad_geo_street_direction")
                    .HasColumnType("char(2)");

                entity.Property(e => e.AdGeoStreetName)
                    .HasColumnName("ad_geo_street_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoStreetNumber)
                    .HasColumnName("ad_geo_street_number")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoStreetPostDir)
                    .HasColumnName("ad_geo_street_post_dir")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoStreetPreType)
                    .HasColumnName("ad_geo_street_pre_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoStreetUnitType)
                    .HasColumnName("ad_geo_street_unit_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoStreetZip4)
                    .HasColumnName("ad_geo_street_zip4")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoUnit)
                    .HasColumnName("ad_geo_unit")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoZipCode)
                    .HasColumnName("ad_geo_zip_code")
                    .HasColumnType("char(5)");

                entity.Property(e => e.AdLotNumber)
                    .HasColumnName("ad_lot_number")
                    .HasColumnType("char(3)");

                entity.Property(e => e.AdMapCode)
                    .HasColumnName("ad_map_code")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AdMapPrecision)
                    .HasColumnName("ad_map_precision")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.AdMarketingArea)
                    .HasColumnName("ad_marketing_area")
                    .HasColumnType("char(4)");

                entity.Property(e => e.AdNeighborhood)
                    .HasColumnName("ad_neighborhood")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AdParcelNumber)
                    .HasColumnName("ad_parcel_number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AdPostalCode)
                    .HasColumnName("ad_postal_code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.AdState)
                    .HasColumnName("ad_state")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.AdStreetDesignator)
                    .HasColumnName("ad_street_designator")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdStreetDirection)
                    .HasColumnName("ad_street_direction")
                    .HasColumnType("char(2)");

                entity.Property(e => e.AdStreetName)
                    .HasColumnName("ad_street_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdStreetNumber)
                    .HasColumnName("ad_street_number")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AdStreetPostDir)
                    .HasColumnName("ad_street_post_dir")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdStreetPreType)
                    .HasColumnName("ad_street_pre_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdStreetUnitType)
                    .HasColumnName("ad_street_unit_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdStreetZip4)
                    .HasColumnName("ad_street_zip4")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdTractNumber)
                    .HasColumnName("ad_tract_number")
                    .HasColumnType("char(5)");

                entity.Property(e => e.AdUnit)
                    .HasColumnName("ad_unit")
                    .HasColumnType("char(8)");

                entity.Property(e => e.AdZipCode)
                    .HasColumnName("ad_zip_code")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AdZoneFeatures)
                    .HasColumnName("ad_zone_features")
                    .HasMaxLength(59)
                    .IsUnicode(false);

                entity.Property(e => e.AgCoagentId)
                    .HasColumnName("ag_coagent_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.AgCoagentName)
                    .HasColumnName("ag_coagent_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgCoagentPhone)
                    .HasColumnName("ag_coagent_phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgEmail)
                    .HasColumnName("ag_email")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.AgFax)
                    .HasColumnName("ag_fax")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgId)
                    .HasColumnName("ag_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.AgMayRepresentSellerAndBuyer)
                    .HasColumnName("ag_may_represent_seller_and_buyer")
                    .HasColumnType("char(2)");

                entity.Property(e => e.AgMobilePhone)
                    .HasColumnName("ag_mobile_phone")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.AgName)
                    .HasColumnName("ag_name")
                    .HasMaxLength(61)
                    .IsUnicode(false);

                entity.Property(e => e.AgOfficeEmail)
                    .HasColumnName("ag_office_email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgOfficeId)
                    .HasColumnName("ag_office_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.AgOfficeName)
                    .HasColumnName("ag_office_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AgOfficePhone)
                    .HasColumnName("ag_office_phone")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.AgPager)
                    .HasColumnName("ag_pager")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgPhone)
                    .HasColumnName("ag_phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgReciprocalLink)
                    .HasColumnName("ag_reciprocal_link")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.AgRemarks)
                    .HasColumnName("ag_remarks")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AgRepresentationFeatures)
                    .HasColumnName("ag_representation_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgVmail)
                    .HasColumnName("ag_vmail")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgWebsite)
                    .HasColumnName("ag_website")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayAddressYn)
                    .HasColumnName("display_address_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.DisplayDistressedPropertyYn)
                    .HasColumnName("display_distressed_property_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ExBuildingCondition)
                    .HasColumnName("ex_building_condition")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExBuildingFaces)
                    .HasColumnName("ex_building_faces")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExBuildingSquareFeet)
                    .HasColumnName("ex_building_square_feet")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.ExCarportSpaces)
                    .HasColumnName("ex_carport_spaces")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.ExConstructionFeatures)
                    .HasColumnName("ex_construction_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.ExFenceFeatures)
                    .HasColumnName("ex_fence_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.ExFldZoneYn)
                    .HasColumnName("ex_fld_zone_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ExFoundationFeatures)
                    .HasColumnName("ex_foundation_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExLocationFeatures)
                    .HasColumnName("ex_location_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.ExLotSizeAcres)
                    .HasColumnName("ex_lot_size_acres")
                    .HasColumnType("decimal(10,4)");

                entity.Property(e => e.ExLotSizeDimensions)
                    .HasColumnName("ex_lot_size_dimensions")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExLotSizeFeatures)
                    .HasColumnName("ex_lot_size_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.ExLotSizeSource)
                    .HasColumnName("ex_lot_size_source")
                    .HasColumnType("char(2)");

                entity.Property(e => e.ExLotSizeSquareFeet)
                    .HasColumnName("ex_lot_size_square_feet")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ExLotsizeRange)
                    .HasColumnName("ex_lotsize_range")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExParkingFeatures)
                    .HasColumnName("ex_parking_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExParkingSpaces)
                    .HasColumnName("ex_parking_spaces")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.ExParkingSpacesTotal)
                    .HasColumnName("ex_parking_spaces_total")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.ExRoadFeatures)
                    .HasColumnName("ex_road_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExRoofFeatures)
                    .HasColumnName("ex_roof_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExSewerFeatures)
                    .HasColumnName("ex_sewer_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.ExSprinklerFeatures)
                    .HasColumnName("ex_sprinkler_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.ExStyle)
                    .HasColumnName("ex_style")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ExViewFeatures)
                    .HasColumnName("ex_view_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.ExWateraccessFeatures)
                    .HasColumnName("ex_wateraccess_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExWaterfrontFeatures)
                    .HasColumnName("ex_waterfront_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FiAdditionalFinanceInfo)
                    .HasColumnName("fi_additional_finance_Info")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FiCompTrigger)
                    .HasColumnName("fi_comp_trigger")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FiFinanceFeatures)
                    .HasColumnName("fi_finance_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FiFinanceSponsor)
                    .HasColumnName("fi_finance_sponsor")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FiFinanceTerms)
                    .HasColumnName("fi_finance_terms")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FiFirstTrustDeedAmount)
                    .HasColumnName("fi_first_trust_deed_amount")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiFirstTrustDeedAssumable)
                    .HasColumnName("fi_first_trust_deed_assumable")
                    .HasColumnType("char(1)");

                entity.Property(e => e.FiFirstTrustDeedDue).HasColumnName("fi_first_trust_deed_due");

                entity.Property(e => e.FiFirstTrustDeedFee)
                    .HasColumnName("fi_first_trust_deed_fee")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiFirstTrustDeedInterest)
                    .HasColumnName("fi_first_trust_deed_interest")
                    .HasColumnType("decimal(5,3)");

                entity.Property(e => e.FiFirstTrustDeedLender)
                    .HasColumnName("fi_first_trust_deed_lender")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FiFirstTrustDeedRate)
                    .HasColumnName("fi_first_trust_deed_rate")
                    .HasColumnType("char(2)");

                entity.Property(e => e.FiFirstTrustDeedType)
                    .HasColumnName("fi_first_trust_deed_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.FiGrossEquity)
                    .HasColumnName("fi_gross_equity")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiIgnoreCompTrigger)
                    .HasColumnName("fi_ignore_comp_trigger")
                    .HasColumnType("char(1)");

                entity.Property(e => e.FiIgnorePaidYn)
                    .HasColumnName("fi_ignore_paid_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.FiPossession)
                    .HasColumnName("fi_possession")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FiSecondTrustDeedAmount)
                    .HasColumnName("fi_second_trust_deed_amount")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiSecondTrustDeedAssumable)
                    .HasColumnName("fi_second_trust_deed_assumable")
                    .HasColumnType("char(1)");

                entity.Property(e => e.FiSecondTrustDeedDue).HasColumnName("fi_second_trust_deed_due");

                entity.Property(e => e.FiSecondTrustDeedFee)
                    .HasColumnName("fi_second_trust_deed_fee")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiSecondTrustDeedInterest)
                    .HasColumnName("fi_second_trust_deed_interest")
                    .HasColumnType("decimal(5,3)");

                entity.Property(e => e.FiSecondTrustDeedLender)
                    .HasColumnName("fi_second_trust_deed_lender")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FiSecondTrustDeedRate)
                    .HasColumnName("fi_second_trust_deed_rate")
                    .HasColumnType("char(2)");

                entity.Property(e => e.FiSecondTrustDeedType)
                    .HasColumnName("fi_second_trust_deed_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.FiTaxAmount)
                    .HasColumnName("fi_tax_amount")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiTaxDescriptionFeatures)
                    .HasColumnName("fi_tax_description_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FiTaxPeriod)
                    .HasColumnName("fi_tax_period")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.FiTotalTaxRate)
                    .HasColumnName("fi_total_tax_rate")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.IfCoolingFeatures)
                    .HasColumnName("if_cooling_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IfCoolingYn)
                    .HasColumnName("if_cooling_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.IfFloorFeatures)
                    .HasColumnName("if_floor_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IfGeneralFeatures)
                    .HasColumnName("if_general_features")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IfHeatingFeatures)
                    .HasColumnName("if_heating_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IfLevels)
                    .HasColumnName("if_levels")
                    .HasColumnType("char(2)");

                entity.Property(e => e.IfLevelsFeatures)
                    .HasColumnName("if_levels_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.IfPlumbingFeatures)
                    .HasColumnName("if_plumbing_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.IfSecurityFeatures)
                    .HasColumnName("if_security_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.IfSecuritySystemYn)
                    .HasColumnName("if_security_system_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.IfSpecialFeatures)
                    .HasColumnName("if_special_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IfUtilitiesFeatures)
                    .HasColumnName("if_utilities_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.IfWaterFeatures)
                    .HasColumnName("if_water_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.IfWindowFeatures)
                    .HasColumnName("if_window_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.InAcctsPayable)
                    .HasColumnName("in_accts_payable")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InAcctsReceivable)
                    .HasColumnName("in_accts_receivable")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InAdditionalBusiness)
                    .HasColumnName("in_additional_business")
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.InAdditionalPicturesYn)
                    .IsRequired()
                    .HasColumnName("in_additional_pictures_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InAdom)
                    .HasColumnName("in_adom")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InAgeFeatures)
                    .HasColumnName("in_age_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InAnnualCost)
                    .HasColumnName("in_annual_cost")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InAnnualGrossSales)
                    .HasColumnName("in_annual_gross_sales")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InAnnualNetOpertatingIncome)
                    .HasColumnName("in_annual_net_opertating_income")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InAnnualRent)
                    .HasColumnName("in_annual_rent")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InApNumber)
                    .HasColumnName("in_ap_number")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.InAssets)
                    .HasColumnName("in_assets")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InAssociationDues1)
                    .HasColumnName("in_association_dues1")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InAssociationDues2)
                    .HasColumnName("in_association_dues2")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InAssociationFeatures)
                    .HasColumnName("in_association_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InAssociationLitigationYn)
                    .HasColumnName("in_association_litigation_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InAssociationPeriod)
                    .HasColumnName("in_association_period")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.InAssociationPhone)
                    .HasColumnName("in_association_phone")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.InAssociationYn)
                    .HasColumnName("in_association_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InBusinessName)
                    .HasColumnName("in_business_name")
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.InBusinessType)
                    .HasColumnName("in_business_type")
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.InCloseDate).HasColumnName("in_close_date");

                entity.Property(e => e.InCompensationBuyAgent)
                    .HasColumnName("in_compensation_buy_agent")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.InCompensationNonrep)
                    .HasColumnName("in_compensation_nonrep")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.InCompensationTransactionAgent)
                    .HasColumnName("in_compensation_transaction_agent")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.InDateLeaseExpires).HasColumnName("in_date_lease_expires");

                entity.Property(e => e.InDetailUrl)
                    .HasColumnName("in_detail_url")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.InDistressType)
                    .HasColumnName("in_distress_type")
                    .HasMaxLength(59)
                    .IsUnicode(false);

                entity.Property(e => e.InEscrowDate).HasColumnName("in_escrow_date");

                entity.Property(e => e.InExclusions)
                    .HasColumnName("in_exclusions")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InImageCount)
                    .HasColumnName("in_image_count")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.InIsAttached)
                    .HasColumnName("in_is_attached")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InKeyboxFeatures)
                    .HasColumnName("in_keybox_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.InKeyboxLocation)
                    .HasColumnName("in_keybox_location")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InLastTransactionCode)
                    .HasColumnName("in_last_transaction_code")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InLatitude).HasColumnName("in_latitude");

                entity.Property(e => e.InLeaseAmount)
                    .HasColumnName("in_lease_amount")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InLeaseOptionYn)
                    .HasColumnName("in_lease_option_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InLeasePeriod)
                    .HasColumnName("in_lease_period")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.InLeaseTerm)
                    .HasColumnName("in_lease_term")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.InLegalDescription)
                    .HasColumnName("in_legal_description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InLegalFeatures)
                    .HasColumnName("in_legal_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InListDate).HasColumnName("in_list_date");

                entity.Property(e => e.InListPrice)
                    .HasColumnName("in_list_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InListPriceExclusionRemarks)
                    .HasColumnName("in_list_price_exclusion_remarks")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.InListingAgreementType)
                    .HasColumnName("in_listing_agreement_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.InListingHasForSaleSignYn)
                    .HasColumnName("in_listing_has_for_sale_sign_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InListingLoadedByBroker)
                    .HasColumnName("in_listing_loaded_by_broker")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.InLoadDate).HasColumnName("in_load_date");

                entity.Property(e => e.InLongitude).HasColumnName("in_longitude");

                entity.Property(e => e.InModifyDate).HasColumnName("in_modify_date");

                entity.Property(e => e.InNumberEmployees)
                    .HasColumnName("in_number_employees")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InNumberOffices)
                    .HasColumnName("in_number_offices")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InOccupantName)
                    .HasColumnName("in_occupant_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InOccupantPhone)
                    .HasColumnName("in_occupant_phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InOffmarketDate).HasColumnName("in_offmarket_date");

                entity.Property(e => e.InOrigListPrice)
                    .HasColumnName("in_orig_list_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InOwnerName)
                    .HasColumnName("in_owner_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InOwnerPhone)
                    .HasColumnName("in_owner_phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InPendingDate).HasColumnName("in_pending_date");

                entity.Property(e => e.InPendingPrice)
                    .HasColumnName("in_pending_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InPreviousListPrice)
                    .HasColumnName("in_previous_list_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InPreviousStatus)
                    .HasColumnName("in_previous_status")
                    .HasColumnType("char(2)");

                entity.Property(e => e.InProjectedEscrowCloseDate).HasColumnName("in_projected_escrow_close_date");

                entity.Property(e => e.InPropertyType)
                    .HasColumnName("in_property_type")
                    .HasColumnType("char(3)");

                entity.Property(e => e.InPublicRemarks)
                    .HasColumnName("in_public_remarks")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.InPullDate).HasColumnName("in_pull_date");

                entity.Property(e => e.InRangeHighPrice)
                    .HasColumnName("in_range_high_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InRangeLowPrice)
                    .HasColumnName("in_range_low_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InRangePriceFlag)
                    .HasColumnName("in_range_price_flag")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InReciprocalListing)
                    .HasColumnName("in_reciprocal_listing")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InRemodeledDate).HasColumnName("in_remodeled_date");

                entity.Property(e => e.InRestrictions)
                    .HasColumnName("in_restrictions")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InSellerAgreesToPayPoints)
                    .HasColumnName("in_seller_agrees_to_pay_points")
                    .HasColumnType("char(4)");

                entity.Property(e => e.InSellingOfficeComp)
                    .HasColumnName("in_selling_office_comp")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.InSellingOfficeCompType)
                    .HasColumnName("in_selling_office_comp_type")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InSellingOfficeCompensation)
                    .HasColumnName("in_selling_office_compensation")
                    .HasColumnType("char(4)");

                entity.Property(e => e.InShowingInstructions)
                    .HasColumnName("in_showing_instructions")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.InSoldAgentName)
                    .HasColumnName("in_sold_agent_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InSoldAgentOfficeId)
                    .HasColumnName("in_sold_agent_office_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.InSoldAgentPublicId)
                    .HasColumnName("in_sold_agent_public_id")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.InSoldDate).HasColumnName("in_sold_date");

                entity.Property(e => e.InSoldFinanceTerms)
                    .HasColumnName("in_sold_finance_terms")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InSoldOfficeName)
                    .HasColumnName("in_sold_office_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InSoldPrice)
                    .HasColumnName("in_sold_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InSoldTerms)
                    .HasColumnName("in_sold_terms")
                    .HasColumnType("char(2)");

                entity.Property(e => e.InStatus)
                    .HasColumnName("in_status")
                    .HasColumnType("char(2)");

                entity.Property(e => e.InStatusDate).HasColumnName("in_status_date");

                entity.Property(e => e.InSubtype)
                    .HasColumnName("in_subtype")
                    .HasColumnType("char(3)");

                entity.Property(e => e.InSystemExpireDate).HasColumnName("in_system_expire_date");

                entity.Property(e => e.InTotalAssessedValue)
                    .HasColumnName("in_total_assessed_value")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InTotalUnitsInComplex)
                    .HasColumnName("in_total_units_in_complex")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.InTractCode)
                    .HasColumnName("in_tract_code")
                    .HasColumnType("char(4)");

                entity.Property(e => e.InTractName)
                    .HasColumnName("in_tract_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InTraningAvailableYn)
                    .HasColumnName("in_traning_available_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InTransactDate).HasColumnName("in_transact_date");

                entity.Property(e => e.InTransferOfPossession)
                    .HasColumnName("in_transfer_of_possession")
                    .HasColumnType("char(2)");

                entity.Property(e => e.InValueInventory)
                    .HasColumnName("in_value_inventory")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InViewYn)
                    .HasColumnName("in_view_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InVirtualTourLink)
                    .HasColumnName("in_virtual_tour_link")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InWithdrawnDate).HasColumnName("in_withdrawn_date");

                entity.Property(e => e.InYearBuilt)
                    .HasColumnName("in_year_built")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.InYearEstablished)
                    .HasColumnName("in_year_established")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LastImport)
                    .HasColumnName("last_import")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ListOnInternetYn)
                    .HasColumnName("list_on_internet_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ListingIddYn)
                    .HasColumnName("listing_idd_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.PublishStatus)
                    .HasColumnName("publish_status")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RegMlsCode)
                    .HasColumnName("reg_mls_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmBathsTotal)
                    .HasColumnName("rm_baths_total")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.ScElementarySchool)
                    .HasColumnName("sc_elementary_school")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScHighSchool)
                    .HasColumnName("sc_high_school")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScJuniorHighSchool)
                    .HasColumnName("sc_junior_high_school")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScSchoolDistrict)
                    .HasColumnName("sc_school_district")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MlsComListings>(entity =>
            {
                entity.HasKey(e => new { e.OrgId, e.ListingId });

                entity.ToTable("mls_com_listings", "rezoradata");

                entity.HasIndex(e => e.LastImport)
                    .HasName("last_import");

                entity.HasIndex(e => new { e.LastImport, e.OrgId })
                    .HasName("updatefilter");

                entity.HasIndex(e => new { e.InLatitude, e.InLongitude, e.ListOnInternetYn, e.PublishStatus })
                    .HasName("geocoded");

                entity.Property(e => e.OrgId)
                    .HasColumnName("org_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ListingId)
                    .HasColumnName("listing_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.AdArea)
                    .HasColumnName("ad_area")
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.AdBlockNumber)
                    .HasColumnName("ad_block_number")
                    .HasColumnType("char(4)");

                entity.Property(e => e.AdCityName)
                    .HasColumnName("ad_city_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AdCountyCode)
                    .HasColumnName("ad_county_code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AdCountyFips)
                    .HasColumnName("ad_county_fips")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AdCrossStreets)
                    .HasColumnName("ad_cross_streets")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AdDirections)
                    .HasColumnName("ad_directions")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoCityName)
                    .HasColumnName("ad_geo_city_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoState)
                    .HasColumnName("ad_geo_state")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoStreetDesignator)
                    .HasColumnName("ad_geo_street_designator")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoStreetDirection)
                    .HasColumnName("ad_geo_street_direction")
                    .HasColumnType("char(2)");

                entity.Property(e => e.AdGeoStreetName)
                    .HasColumnName("ad_geo_street_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoStreetNumber)
                    .HasColumnName("ad_geo_street_number")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoStreetPostDir)
                    .HasColumnName("ad_geo_street_post_dir")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoStreetPreType)
                    .HasColumnName("ad_geo_street_pre_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoStreetUnitType)
                    .HasColumnName("ad_geo_street_unit_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoStreetZip4)
                    .HasColumnName("ad_geo_street_zip4")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoUnit)
                    .HasColumnName("ad_geo_unit")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoZipCode)
                    .HasColumnName("ad_geo_zip_code")
                    .HasColumnType("char(5)");

                entity.Property(e => e.AdLotNumber)
                    .HasColumnName("ad_lot_number")
                    .HasColumnType("char(3)");

                entity.Property(e => e.AdMapCode)
                    .HasColumnName("ad_map_code")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AdMapPrecision)
                    .HasColumnName("ad_map_precision")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.AdMarketingArea)
                    .HasColumnName("ad_marketing_area")
                    .HasColumnType("char(4)");

                entity.Property(e => e.AdNeighborhood)
                    .HasColumnName("ad_neighborhood")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AdParcelNumber)
                    .HasColumnName("ad_parcel_number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AdPostalCode)
                    .HasColumnName("ad_postal_code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.AdState)
                    .HasColumnName("ad_state")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.AdStreetDesignator)
                    .HasColumnName("ad_street_designator")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdStreetDirection)
                    .HasColumnName("ad_street_direction")
                    .HasColumnType("char(2)");

                entity.Property(e => e.AdStreetName)
                    .HasColumnName("ad_street_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdStreetNumber)
                    .HasColumnName("ad_street_number")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AdStreetPostDir)
                    .HasColumnName("ad_street_post_dir")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdStreetPreType)
                    .HasColumnName("ad_street_pre_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdStreetUnitType)
                    .HasColumnName("ad_street_unit_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdStreetZip4)
                    .HasColumnName("ad_street_zip4")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdTractNumber)
                    .HasColumnName("ad_tract_number")
                    .HasColumnType("char(5)");

                entity.Property(e => e.AdUnit)
                    .HasColumnName("ad_unit")
                    .HasColumnType("char(8)");

                entity.Property(e => e.AdZipCode)
                    .HasColumnName("ad_zip_code")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AdZoneFeatures)
                    .HasColumnName("ad_zone_features")
                    .HasMaxLength(59)
                    .IsUnicode(false);

                entity.Property(e => e.AgCoagentId)
                    .HasColumnName("ag_coagent_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.AgCoagentName)
                    .HasColumnName("ag_coagent_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgCoagentPhone)
                    .HasColumnName("ag_coagent_phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgEmail)
                    .HasColumnName("ag_email")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.AgFax)
                    .HasColumnName("ag_fax")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgId)
                    .HasColumnName("ag_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.AgMayRepresentSellerAndBuyer)
                    .HasColumnName("ag_may_represent_seller_and_buyer")
                    .HasColumnType("char(2)");

                entity.Property(e => e.AgMobilePhone)
                    .HasColumnName("ag_mobile_phone")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.AgName)
                    .HasColumnName("ag_name")
                    .HasMaxLength(61)
                    .IsUnicode(false);

                entity.Property(e => e.AgOfficeEmail)
                    .HasColumnName("ag_office_email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgOfficeId)
                    .HasColumnName("ag_office_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.AgOfficeName)
                    .HasColumnName("ag_office_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AgOfficePhone)
                    .HasColumnName("ag_office_phone")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.AgPager)
                    .HasColumnName("ag_pager")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgPhone)
                    .HasColumnName("ag_phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgReciprocalLink)
                    .HasColumnName("ag_reciprocal_link")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.AgRemarks)
                    .HasColumnName("ag_remarks")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AgRepresentationFeatures)
                    .HasColumnName("ag_representation_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgVmail)
                    .HasColumnName("ag_vmail")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgWebsite)
                    .HasColumnName("ag_website")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayAddressYn)
                    .HasColumnName("display_address_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.DisplayDistressedPropertyYn)
                    .HasColumnName("display_distressed_property_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ExBuildingDimensions)
                    .HasColumnName("ex_building_dimensions")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExBuildingSquareFeet)
                    .HasColumnName("ex_building_square_feet")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.ExFldZoneYn)
                    .HasColumnName("ex_fld_zone_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ExGeneralFeatures)
                    .HasColumnName("ex_general_features")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExLoadingDockYn)
                    .HasColumnName("ex_loading_dock_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ExLocationFeatures)
                    .HasColumnName("ex_location_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.ExLotSizeAcres)
                    .HasColumnName("ex_lot_size_acres")
                    .HasColumnType("decimal(10,4)");

                entity.Property(e => e.ExLotSizeDimensions)
                    .HasColumnName("ex_lot_size_dimensions")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExLotSizeFeatures)
                    .HasColumnName("ex_lot_size_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.ExLotSizeSource)
                    .HasColumnName("ex_lot_size_source")
                    .HasColumnType("char(2)");

                entity.Property(e => e.ExLotSizeSquareFeet)
                    .HasColumnName("ex_lot_size_square_feet")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ExLotsizeRange)
                    .HasColumnName("ex_lotsize_range")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExParkingFeatures)
                    .HasColumnName("ex_parking_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExParkingLots)
                    .HasColumnName("ex_parking_lots")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.ExParkingSpaces)
                    .HasColumnName("ex_parking_spaces")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.ExParkingSpacesTotal)
                    .HasColumnName("ex_parking_spaces_total")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.ExRoadFeatures)
                    .HasColumnName("ex_road_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExSewerFeatures)
                    .HasColumnName("ex_sewer_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.ExStyle)
                    .HasColumnName("ex_style")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ExViewFeatures)
                    .HasColumnName("ex_view_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.ExWateraccessFeatures)
                    .HasColumnName("ex_wateraccess_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExWaterfrontFeatures)
                    .HasColumnName("ex_waterfront_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FiAdditionalFinanceInfo)
                    .HasColumnName("fi_additional_finance_Info")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FiCompTrigger)
                    .HasColumnName("fi_comp_trigger")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FiFinanceFeatures)
                    .HasColumnName("fi_finance_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FiFinanceSponsor)
                    .HasColumnName("fi_finance_sponsor")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FiFinanceTerms)
                    .HasColumnName("fi_finance_terms")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FiFirstTrustDeedAmount)
                    .HasColumnName("fi_first_trust_deed_amount")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiFirstTrustDeedAssumable)
                    .HasColumnName("fi_first_trust_deed_assumable")
                    .HasColumnType("char(1)");

                entity.Property(e => e.FiFirstTrustDeedDue).HasColumnName("fi_first_trust_deed_due");

                entity.Property(e => e.FiFirstTrustDeedFee)
                    .HasColumnName("fi_first_trust_deed_fee")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiFirstTrustDeedInterest)
                    .HasColumnName("fi_first_trust_deed_interest")
                    .HasColumnType("decimal(5,3)");

                entity.Property(e => e.FiFirstTrustDeedLender)
                    .HasColumnName("fi_first_trust_deed_lender")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FiFirstTrustDeedRate)
                    .HasColumnName("fi_first_trust_deed_rate")
                    .HasColumnType("char(2)");

                entity.Property(e => e.FiFirstTrustDeedType)
                    .HasColumnName("fi_first_trust_deed_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.FiGrossEquity)
                    .HasColumnName("fi_gross_equity")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiIgnoreCompTrigger)
                    .HasColumnName("fi_ignore_comp_trigger")
                    .HasColumnType("char(1)");

                entity.Property(e => e.FiIgnorePaidYn)
                    .HasColumnName("fi_ignore_paid_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.FiPossession)
                    .HasColumnName("fi_possession")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FiSecondTrustDeedAmount)
                    .HasColumnName("fi_second_trust_deed_amount")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiSecondTrustDeedAssumable)
                    .HasColumnName("fi_second_trust_deed_assumable")
                    .HasColumnType("char(1)");

                entity.Property(e => e.FiSecondTrustDeedDue).HasColumnName("fi_second_trust_deed_due");

                entity.Property(e => e.FiSecondTrustDeedFee)
                    .HasColumnName("fi_second_trust_deed_fee")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiSecondTrustDeedInterest)
                    .HasColumnName("fi_second_trust_deed_interest")
                    .HasColumnType("decimal(5,3)");

                entity.Property(e => e.FiSecondTrustDeedLender)
                    .HasColumnName("fi_second_trust_deed_lender")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FiSecondTrustDeedRate)
                    .HasColumnName("fi_second_trust_deed_rate")
                    .HasColumnType("char(2)");

                entity.Property(e => e.FiSecondTrustDeedType)
                    .HasColumnName("fi_second_trust_deed_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.FiTaxAmount)
                    .HasColumnName("fi_tax_amount")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiTaxDescriptionFeatures)
                    .HasColumnName("fi_tax_description_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FiTaxPeriod)
                    .HasColumnName("fi_tax_period")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.FiTotalTaxRate)
                    .HasColumnName("fi_total_tax_rate")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.IfCoolingFeatures)
                    .HasColumnName("if_cooling_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IfGeneralFeatures)
                    .HasColumnName("if_general_features")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IfHeatingFeatures)
                    .HasColumnName("if_heating_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IfLevels)
                    .HasColumnName("if_levels")
                    .HasColumnType("char(2)");

                entity.Property(e => e.IfLevelsFeatures)
                    .HasColumnName("if_levels_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.IfSpecialFeatures)
                    .HasColumnName("if_special_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IfUtilitiesFeatures)
                    .HasColumnName("if_utilities_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.IfWaterFeatures)
                    .HasColumnName("if_water_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.InAdditionalPicturesYn)
                    .IsRequired()
                    .HasColumnName("in_additional_pictures_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InAdom)
                    .HasColumnName("in_adom")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InAgeFeatures)
                    .HasColumnName("in_age_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InApNumber)
                    .HasColumnName("in_ap_number")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.InAssociationDues1)
                    .HasColumnName("in_association_dues1")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InAssociationDues2)
                    .HasColumnName("in_association_dues2")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InAssociationFeatures)
                    .HasColumnName("in_association_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InAssociationLitigationYn)
                    .HasColumnName("in_association_litigation_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InAssociationPeriod)
                    .HasColumnName("in_association_period")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.InAssociationPhone)
                    .HasColumnName("in_association_phone")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.InAssociationYn)
                    .HasColumnName("in_association_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InCloseDate).HasColumnName("in_close_date");

                entity.Property(e => e.InCompensationBuyAgent)
                    .HasColumnName("in_compensation_buy_agent")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.InCompensationNonrep)
                    .HasColumnName("in_compensation_nonrep")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.InCompensationTransactionAgent)
                    .HasColumnName("in_compensation_transaction_agent")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.InDetailUrl)
                    .HasColumnName("in_detail_url")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.InDistressType)
                    .HasColumnName("in_distress_type")
                    .HasMaxLength(59)
                    .IsUnicode(false);

                entity.Property(e => e.InEscrowDate).HasColumnName("in_escrow_date");

                entity.Property(e => e.InExclusions)
                    .HasColumnName("in_exclusions")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InImageCount)
                    .HasColumnName("in_image_count")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.InLastTransactionCode)
                    .HasColumnName("in_last_transaction_code")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InLatitude).HasColumnName("in_latitude");

                entity.Property(e => e.InLeaseAmount)
                    .HasColumnName("in_lease_amount")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InLeaseOptionYn)
                    .HasColumnName("in_lease_option_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InLeasePeriod)
                    .HasColumnName("in_lease_period")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.InLeaseTerm)
                    .HasColumnName("in_lease_term")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.InLegalDescription)
                    .HasColumnName("in_legal_description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InLegalFeatures)
                    .HasColumnName("in_legal_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InListDate).HasColumnName("in_list_date");

                entity.Property(e => e.InListPrice)
                    .HasColumnName("in_list_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InListPriceExclusionRemarks)
                    .HasColumnName("in_list_price_exclusion_remarks")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.InListingAgreementType)
                    .HasColumnName("in_listing_agreement_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.InListingHasForSaleSignYn)
                    .HasColumnName("in_listing_has_for_sale_sign_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InListingLoadedByBroker)
                    .HasColumnName("in_listing_loaded_by_broker")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.InLoadDate).HasColumnName("in_load_date");

                entity.Property(e => e.InLongitude).HasColumnName("in_longitude");

                entity.Property(e => e.InModifyDate).HasColumnName("in_modify_date");

                entity.Property(e => e.InOffmarketDate).HasColumnName("in_offmarket_date");

                entity.Property(e => e.InOrigListPrice)
                    .HasColumnName("in_orig_list_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InOwnerName)
                    .HasColumnName("in_owner_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InOwnerPhone)
                    .HasColumnName("in_owner_phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InPendingDate).HasColumnName("in_pending_date");

                entity.Property(e => e.InPendingPrice)
                    .HasColumnName("in_pending_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InPreviousListPrice)
                    .HasColumnName("in_previous_list_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InPreviousStatus)
                    .HasColumnName("in_previous_status")
                    .HasColumnType("char(2)");

                entity.Property(e => e.InProjectedEscrowCloseDate).HasColumnName("in_projected_escrow_close_date");

                entity.Property(e => e.InPropertyType)
                    .HasColumnName("in_property_type")
                    .HasColumnType("char(3)");

                entity.Property(e => e.InPublicRemarks)
                    .HasColumnName("in_public_remarks")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.InPullDate).HasColumnName("in_pull_date");

                entity.Property(e => e.InRangeHighPrice)
                    .HasColumnName("in_range_high_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InRangeLowPrice)
                    .HasColumnName("in_range_low_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InRangePriceFlag)
                    .HasColumnName("in_range_price_flag")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InReciprocalListing)
                    .HasColumnName("in_reciprocal_listing")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InRestrictions)
                    .HasColumnName("in_restrictions")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InSellerAgreesToPayPoints)
                    .HasColumnName("in_seller_agrees_to_pay_points")
                    .HasColumnType("char(4)");

                entity.Property(e => e.InSellingOfficeComp)
                    .HasColumnName("in_selling_office_comp")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.InSellingOfficeCompType)
                    .HasColumnName("in_selling_office_comp_type")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InSellingOfficeCompensation)
                    .HasColumnName("in_selling_office_compensation")
                    .HasColumnType("char(4)");

                entity.Property(e => e.InShowingInstructions)
                    .HasColumnName("in_showing_instructions")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.InSoldAgentName)
                    .HasColumnName("in_sold_agent_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InSoldAgentOfficeId)
                    .HasColumnName("in_sold_agent_office_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.InSoldAgentPublicId)
                    .HasColumnName("in_sold_agent_public_id")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.InSoldDate).HasColumnName("in_sold_date");

                entity.Property(e => e.InSoldFinanceTerms)
                    .HasColumnName("in_sold_finance_terms")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InSoldOfficeName)
                    .HasColumnName("in_sold_office_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InSoldPrice)
                    .HasColumnName("in_sold_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InSoldTerms)
                    .HasColumnName("in_sold_terms")
                    .HasColumnType("char(2)");

                entity.Property(e => e.InStatus)
                    .HasColumnName("in_status")
                    .HasColumnType("char(2)");

                entity.Property(e => e.InStatusDate).HasColumnName("in_status_date");

                entity.Property(e => e.InSubtype)
                    .HasColumnName("in_subtype")
                    .HasColumnType("char(3)");

                entity.Property(e => e.InSystemExpireDate).HasColumnName("in_system_expire_date");

                entity.Property(e => e.InTotalAssessedValue)
                    .HasColumnName("in_total_assessed_value")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InTractCode)
                    .HasColumnName("in_tract_code")
                    .HasColumnType("char(4)");

                entity.Property(e => e.InTractName)
                    .HasColumnName("in_tract_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InTransactDate).HasColumnName("in_transact_date");

                entity.Property(e => e.InTransferOfPossession)
                    .HasColumnName("in_transfer_of_possession")
                    .HasColumnType("char(2)");

                entity.Property(e => e.InViewYn)
                    .HasColumnName("in_view_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InVirtualTourLink)
                    .HasColumnName("in_virtual_tour_link")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InWithdrawnDate).HasColumnName("in_withdrawn_date");

                entity.Property(e => e.InYearBuilt)
                    .HasColumnName("in_year_built")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.LastImport)
                    .HasColumnName("last_import")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ListOnInternetYn)
                    .HasColumnName("list_on_internet_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ListingIddYn)
                    .HasColumnName("listing_idd_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.PublishStatus)
                    .HasColumnName("publish_status")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RegMlsCode)
                    .HasColumnName("reg_mls_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmBathsTotal)
                    .HasColumnName("rm_baths_total")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.ScElementarySchool)
                    .HasColumnName("sc_elementary_school")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScHighSchool)
                    .HasColumnName("sc_high_school")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScJuniorHighSchool)
                    .HasColumnName("sc_junior_high_school")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScSchoolDistrict)
                    .HasColumnName("sc_school_district")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MlsFeatures>(entity =>
            {
                entity.HasKey(e => new { e.Type, e.Code });

                entity.ToTable("mls_features", "rezoradata");

                entity.HasIndex(e => e.LastImport)
                    .HasName("last_import");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastImport)
                    .HasColumnName("last_import")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.PublishStatus)
                    .HasColumnName("publish_status")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<MlsImportEntryHash0>(entity =>
            {
                entity.HasKey(e => new { e.OrgId, e.EntryId, e.EntryType });

                entity.ToTable("mls_import_entry_hash_0", "rezoradata");

                entity.HasIndex(e => new { e.OrgId, e.EntryId, e.EntryType })
                    .HasName("org_id")
                    .IsUnique();

                entity.HasIndex(e => new { e.OrgId, e.LastFileId, e.InUse })
                    .HasName("deletes");

                entity.HasIndex(e => new { e.OrgId, e.Uniq1, e.Uniq2 })
                    .HasName("org_id_uniq_1_uniq_2");

                entity.Property(e => e.OrgId)
                    .HasColumnName("org_id")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.EntryId)
                    .HasColumnName("entry_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.EntryType)
                    .HasColumnName("entry_type")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentHash)
                    .IsRequired()
                    .HasColumnName("current_hash")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.InUse)
                    .HasColumnName("in_use")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastChanged)
                    .HasColumnName("last_changed")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.LastFileId)
                    .HasColumnName("last_file_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Uniq1)
                    .HasColumnName("uniq_1")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Uniq2)
                    .HasColumnName("uniq_2")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MlsImportEntryHash1>(entity =>
            {
                entity.HasKey(e => new { e.OrgId, e.EntryId, e.EntryType });

                entity.ToTable("mls_import_entry_hash_1", "rezoradata");

                entity.HasIndex(e => new { e.OrgId, e.EntryId, e.EntryType })
                    .HasName("org_id")
                    .IsUnique();

                entity.HasIndex(e => new { e.OrgId, e.LastFileId, e.InUse })
                    .HasName("deletes");

                entity.HasIndex(e => new { e.OrgId, e.Uniq1, e.Uniq2 })
                    .HasName("idx_org_id_uniq_1_uniq_2");

                entity.Property(e => e.OrgId)
                    .HasColumnName("org_id")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.EntryId)
                    .HasColumnName("entry_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.EntryType)
                    .HasColumnName("entry_type")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentHash)
                    .IsRequired()
                    .HasColumnName("current_hash")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.InUse)
                    .HasColumnName("in_use")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastChanged)
                    .HasColumnName("last_changed")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.LastFileId)
                    .HasColumnName("last_file_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Uniq1)
                    .HasColumnName("uniq_1")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Uniq2)
                    .HasColumnName("uniq_2")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MlsImportEntryHash2>(entity =>
            {
                entity.HasKey(e => new { e.OrgId, e.EntryId, e.EntryType });

                entity.ToTable("mls_import_entry_hash_2", "rezoradata");

                entity.HasIndex(e => new { e.OrgId, e.EntryId, e.EntryType })
                    .HasName("org_id")
                    .IsUnique();

                entity.HasIndex(e => new { e.OrgId, e.LastFileId, e.InUse })
                    .HasName("deletes");

                entity.HasIndex(e => new { e.OrgId, e.Uniq1, e.Uniq2 })
                    .HasName("idx_org_id_uniq_1_uniq_2");

                entity.Property(e => e.OrgId)
                    .HasColumnName("org_id")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.EntryId)
                    .HasColumnName("entry_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.EntryType)
                    .HasColumnName("entry_type")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentHash)
                    .IsRequired()
                    .HasColumnName("current_hash")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.InUse)
                    .HasColumnName("in_use")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastChanged)
                    .HasColumnName("last_changed")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.LastFileId)
                    .HasColumnName("last_file_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Uniq1)
                    .HasColumnName("uniq_1")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Uniq2)
                    .HasColumnName("uniq_2")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MlsImportEntryHashDev>(entity =>
            {
                entity.HasKey(e => new { e.OrgId, e.EntryId, e.EntryType });

                entity.ToTable("mls_import_entry_hash_dev", "rezoradata");

                entity.HasIndex(e => new { e.OrgId, e.UniqId1 })
                    .HasName("uniq_id_1");

                entity.HasIndex(e => new { e.OrgId, e.EntryId, e.EntryType })
                    .HasName("org_id")
                    .IsUnique();

                entity.HasIndex(e => new { e.OrgId, e.UniqId1, e.UniqId2 })
                    .HasName("idx_uniq_id_1_uniq_id_2");

                entity.Property(e => e.OrgId)
                    .HasColumnName("org_id")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.EntryId)
                    .HasColumnName("entry_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.EntryType)
                    .HasColumnName("entry_type")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentHash)
                    .IsRequired()
                    .HasColumnName("current_hash")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.InUse)
                    .HasColumnName("in_use")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastChanged)
                    .HasColumnName("last_changed")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.LastFileId)
                    .HasColumnName("last_file_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UniqId1)
                    .HasColumnName("uniq_id_1")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UniqId2)
                    .HasColumnName("uniq_id_2")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MlsImportFailures>(entity =>
            {
                entity.HasKey(e => e.ImportFailureId);

                entity.ToTable("mls_import_failures", "rezoradata");

                entity.HasIndex(e => e.ListingId)
                    .HasName("listing_id");

                entity.HasIndex(e => new { e.OrgId, e.ListingId })
                    .HasName("idx_org_id_listing_id");

                entity.Property(e => e.ImportFailureId)
                    .HasColumnName("import_failure_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ImportFileId)
                    .HasColumnName("import_file_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ListingId)
                    .IsRequired()
                    .HasColumnName("listing_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ListingType)
                    .IsRequired()
                    .HasColumnName("listing_type")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OrgId)
                    .IsRequired()
                    .HasColumnName("org_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.RawData)
                    .IsRequired()
                    .HasColumnName("raw_data")
                    .HasColumnType("blob");

                entity.Property(e => e.RawError)
                    .HasColumnName("raw_error")
                    .HasColumnType("blob");
            });

            modelBuilder.Entity<MlsImportFiles>(entity =>
            {
                entity.HasKey(e => e.ImportFileId);

                entity.ToTable("mls_import_files", "rezoradata");

                entity.HasIndex(e => e.ExecutionId)
                    .HasName("idx_execution_id");

                entity.HasIndex(e => new { e.OrgId, e.FileType, e.FileHash })
                    .HasName("org_id_file_id");

                entity.Property(e => e.ImportFileId)
                    .HasColumnName("import_file_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DeletedDate).HasColumnName("deleted_date");

                entity.Property(e => e.DeletedItems)
                    .HasColumnName("deleted_items")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ExaminedItems)
                    .HasColumnName("examined_items")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ExecutionId)
                    .HasColumnName("execution_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.FailedDate).HasColumnName("failed_date");

                entity.Property(e => e.FailedItems)
                    .HasColumnName("failed_items")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FailureReason)
                    .HasColumnName("failure_reason")
                    .IsUnicode(false);

                entity.Property(e => e.FileHash)
                    .IsRequired()
                    .HasColumnName("file_hash")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.FileType)
                    .IsRequired()
                    .HasColumnName("file_type")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ImportedDate).HasColumnName("imported_date");

                entity.Property(e => e.IsComplete)
                    .HasColumnName("is_complete")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsDelta)
                    .HasColumnName("is_delta")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedItems)
                    .HasColumnName("modified_items")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NewItems)
                    .HasColumnName("new_items")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OrgId)
                    .IsRequired()
                    .HasColumnName("org_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.TotalItems)
                    .HasColumnName("total_items")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UploadedDate).HasColumnName("uploaded_date");
            });

            modelBuilder.Entity<MlsIncomeListings>(entity =>
            {
                entity.HasKey(e => new { e.OrgId, e.ListingId });

                entity.ToTable("mls_income_listings", "rezoradata");

                entity.HasIndex(e => e.LastImport)
                    .HasName("last_import");

                entity.HasIndex(e => new { e.LastImport, e.OrgId })
                    .HasName("updatefilter");

                entity.HasIndex(e => new { e.InLatitude, e.InLongitude, e.ListOnInternetYn, e.PublishStatus })
                    .HasName("geocoded");

                entity.Property(e => e.OrgId)
                    .HasColumnName("org_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ListingId)
                    .HasColumnName("listing_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.AdArea)
                    .HasColumnName("ad_area")
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.AdBlockNumber)
                    .HasColumnName("ad_block_number")
                    .HasColumnType("char(4)");

                entity.Property(e => e.AdCityName)
                    .HasColumnName("ad_city_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AdCountyCode)
                    .HasColumnName("ad_county_code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AdCountyFips)
                    .HasColumnName("ad_county_fips")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AdCrossStreets)
                    .HasColumnName("ad_cross_streets")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AdDirections)
                    .HasColumnName("ad_directions")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoCityName)
                    .HasColumnName("ad_geo_city_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoState)
                    .HasColumnName("ad_geo_state")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoStreetDesignator)
                    .HasColumnName("ad_geo_street_designator")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoStreetDirection)
                    .HasColumnName("ad_geo_street_direction")
                    .HasColumnType("char(2)");

                entity.Property(e => e.AdGeoStreetName)
                    .HasColumnName("ad_geo_street_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoStreetNumber)
                    .HasColumnName("ad_geo_street_number")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoStreetPostDir)
                    .HasColumnName("ad_geo_street_post_dir")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoStreetPreType)
                    .HasColumnName("ad_geo_street_pre_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoStreetUnitType)
                    .HasColumnName("ad_geo_street_unit_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoStreetZip4)
                    .HasColumnName("ad_geo_street_zip4")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoUnit)
                    .HasColumnName("ad_geo_unit")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoZipCode)
                    .HasColumnName("ad_geo_zip_code")
                    .HasColumnType("char(5)");

                entity.Property(e => e.AdLotNumber)
                    .HasColumnName("ad_lot_number")
                    .HasColumnType("char(3)");

                entity.Property(e => e.AdMapCode)
                    .HasColumnName("ad_map_code")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AdMapPrecision)
                    .HasColumnName("ad_map_precision")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.AdMarketingArea)
                    .HasColumnName("ad_marketing_area")
                    .HasColumnType("char(4)");

                entity.Property(e => e.AdNeighborhood)
                    .HasColumnName("ad_neighborhood")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AdParcelNumber)
                    .HasColumnName("ad_parcel_number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AdPostalCode)
                    .HasColumnName("ad_postal_code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.AdState)
                    .HasColumnName("ad_state")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.AdStreetDesignator)
                    .HasColumnName("ad_street_designator")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdStreetDirection)
                    .HasColumnName("ad_street_direction")
                    .HasColumnType("char(2)");

                entity.Property(e => e.AdStreetName)
                    .HasColumnName("ad_street_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdStreetNumber)
                    .HasColumnName("ad_street_number")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AdStreetPostDir)
                    .HasColumnName("ad_street_post_dir")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdStreetPreType)
                    .HasColumnName("ad_street_pre_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdStreetUnitType)
                    .HasColumnName("ad_street_unit_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdStreetZip4)
                    .HasColumnName("ad_street_zip4")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdTractNumber)
                    .HasColumnName("ad_tract_number")
                    .HasColumnType("char(5)");

                entity.Property(e => e.AdUnit)
                    .HasColumnName("ad_unit")
                    .HasColumnType("char(8)");

                entity.Property(e => e.AdZipCode)
                    .HasColumnName("ad_zip_code")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AdZoneFeatures)
                    .HasColumnName("ad_zone_features")
                    .HasMaxLength(59)
                    .IsUnicode(false);

                entity.Property(e => e.AgCoagentId)
                    .HasColumnName("ag_coagent_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.AgCoagentName)
                    .HasColumnName("ag_coagent_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgCoagentPhone)
                    .HasColumnName("ag_coagent_phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgEmail)
                    .HasColumnName("ag_email")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.AgFax)
                    .HasColumnName("ag_fax")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgId)
                    .HasColumnName("ag_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.AgMayRepresentSellerAndBuyer)
                    .HasColumnName("ag_may_represent_seller_and_buyer")
                    .HasColumnType("char(2)");

                entity.Property(e => e.AgMobilePhone)
                    .HasColumnName("ag_mobile_phone")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.AgName)
                    .HasColumnName("ag_name")
                    .HasMaxLength(61)
                    .IsUnicode(false);

                entity.Property(e => e.AgOfficeEmail)
                    .HasColumnName("ag_office_email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgOfficeId)
                    .HasColumnName("ag_office_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.AgOfficeName)
                    .HasColumnName("ag_office_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AgOfficePhone)
                    .HasColumnName("ag_office_phone")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.AgPager)
                    .HasColumnName("ag_pager")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgPhone)
                    .HasColumnName("ag_phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgReciprocalLink)
                    .HasColumnName("ag_reciprocal_link")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.AgRemarks)
                    .HasColumnName("ag_remarks")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AgRepresentationFeatures)
                    .HasColumnName("ag_representation_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgVmail)
                    .HasColumnName("ag_vmail")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgWebsite)
                    .HasColumnName("ag_website")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayAddressYn)
                    .HasColumnName("display_address_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.DisplayDistressedPropertyYn)
                    .HasColumnName("display_distressed_property_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ExBuildingCondition)
                    .HasColumnName("ex_building_condition")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExBuildingFaces)
                    .HasColumnName("ex_building_faces")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExBuildingSquareFeet)
                    .HasColumnName("ex_building_square_feet")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.ExCarportSpaces)
                    .HasColumnName("ex_carport_spaces")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.ExConstructionFeatures)
                    .HasColumnName("ex_construction_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.ExFenceFeatures)
                    .HasColumnName("ex_fence_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.ExFldZoneYn)
                    .HasColumnName("ex_fld_zone_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ExFoundationFeatures)
                    .HasColumnName("ex_foundation_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExGarageFeatures)
                    .HasColumnName("ex_garage_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExGarageRemotes)
                    .HasColumnName("ex_garage_remotes")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.ExGarageSpaces)
                    .HasColumnName("ex_garage_spaces")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.ExGarageType)
                    .HasColumnName("ex_garage_type")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ExGeneralFeatures)
                    .HasColumnName("ex_general_features")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExGolfFeatures)
                    .HasColumnName("ex_golf_features")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExHorsePropertyFeatures)
                    .HasColumnName("ex_horse_property_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.ExLocationFeatures)
                    .HasColumnName("ex_location_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.ExLotSizeAcres)
                    .HasColumnName("ex_lot_size_acres")
                    .HasColumnType("decimal(10,4)");

                entity.Property(e => e.ExLotSizeDimensions)
                    .HasColumnName("ex_lot_size_dimensions")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExLotSizeFeatures)
                    .HasColumnName("ex_lot_size_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.ExLotSizeSource)
                    .HasColumnName("ex_lot_size_source")
                    .HasColumnType("char(2)");

                entity.Property(e => e.ExLotSizeSquareFeet)
                    .HasColumnName("ex_lot_size_square_feet")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ExLotsizeRange)
                    .HasColumnName("ex_lotsize_range")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExParkingFeatures)
                    .HasColumnName("ex_parking_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExParkingSpaces)
                    .HasColumnName("ex_parking_spaces")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.ExParkingSpacesTotal)
                    .HasColumnName("ex_parking_spaces_total")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.ExPatioDimensions)
                    .HasColumnName("ex_patio_dimensions")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ExPatioFeatures)
                    .HasColumnName("ex_patio_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExPatioYn)
                    .HasColumnName("ex_patio_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ExPoolDimensions)
                    .HasColumnName("ex_pool_dimensions")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExPoolFeatures)
                    .HasColumnName("ex_pool_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExPoolYn)
                    .HasColumnName("ex_pool_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ExRoadFeatures)
                    .HasColumnName("ex_road_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExRoofFeatures)
                    .HasColumnName("ex_roof_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExRvParkingDimensions)
                    .HasColumnName("ex_rv_parking_dimensions")
                    .HasColumnType("char(6)");

                entity.Property(e => e.ExSewerFeatures)
                    .HasColumnName("ex_sewer_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.ExSpaFeatures)
                    .HasColumnName("ex_spa_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExSpaYn)
                    .HasColumnName("ex_spa_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ExSprinklerFeatures)
                    .HasColumnName("ex_sprinkler_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.ExStyle)
                    .HasColumnName("ex_style")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ExStyleFeatures)
                    .HasColumnName("ex_style_features")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExSubdivisionFeatures)
                    .HasColumnName("ex_subdivision_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExViewFeatures)
                    .HasColumnName("ex_view_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.ExWateraccessFeatures)
                    .HasColumnName("ex_wateraccess_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExWaterfrontFeatures)
                    .HasColumnName("ex_waterfront_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExWaterstructuresFeatures)
                    .HasColumnName("ex_waterstructures_features")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FiAdditionalFinanceInfo)
                    .HasColumnName("fi_additional_finance_Info")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FiCapRate)
                    .HasColumnName("fi_cap_rate")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiCompTrigger)
                    .HasColumnName("fi_comp_trigger")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FiFinanceFeatures)
                    .HasColumnName("fi_finance_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FiFinanceSponsor)
                    .HasColumnName("fi_finance_sponsor")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FiFinanceTerms)
                    .HasColumnName("fi_finance_terms")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FiFirstTrustDeedAmount)
                    .HasColumnName("fi_first_trust_deed_amount")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiFirstTrustDeedAssumable)
                    .HasColumnName("fi_first_trust_deed_assumable")
                    .HasColumnType("char(1)");

                entity.Property(e => e.FiFirstTrustDeedDue).HasColumnName("fi_first_trust_deed_due");

                entity.Property(e => e.FiFirstTrustDeedFee)
                    .HasColumnName("fi_first_trust_deed_fee")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiFirstTrustDeedInterest)
                    .HasColumnName("fi_first_trust_deed_interest")
                    .HasColumnType("decimal(5,3)");

                entity.Property(e => e.FiFirstTrustDeedLender)
                    .HasColumnName("fi_first_trust_deed_lender")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FiFirstTrustDeedRate)
                    .HasColumnName("fi_first_trust_deed_rate")
                    .HasColumnType("char(2)");

                entity.Property(e => e.FiFirstTrustDeedType)
                    .HasColumnName("fi_first_trust_deed_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.FiGaragesIncome)
                    .HasColumnName("fi_garages_income")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiGrossEquity)
                    .HasColumnName("fi_gross_equity")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiGrossMultiplier)
                    .HasColumnName("fi_gross_multiplier")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.FiGrossOperIncome)
                    .HasColumnName("fi_gross_oper_income")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiGrossSchedIncome)
                    .HasColumnName("fi_gross_sched_income")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiGrossSpendIncome)
                    .HasColumnName("fi_gross_spend_income")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiIgnoreCompTrigger)
                    .HasColumnName("fi_ignore_comp_trigger")
                    .HasColumnType("char(1)");

                entity.Property(e => e.FiIgnorePaidYn)
                    .HasColumnName("fi_ignore_paid_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.FiImprovDollars)
                    .HasColumnName("fi_improv_dollars")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiImprovPct)
                    .HasColumnName("fi_improv_pct")
                    .HasColumnType("decimal(5,0)");

                entity.Property(e => e.FiLandDollars)
                    .HasColumnName("fi_land_dollars")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiLandFeeLeaseYn)
                    .HasColumnName("fi_land_fee_lease_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.FiLandRate)
                    .HasColumnName("fi_land_rate")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiLaundryIncome)
                    .HasColumnName("fi_laundry_income")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiLeaseAmtPerYear)
                    .HasColumnName("fi_lease_amt_per_year")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiLeaseMoYr)
                    .HasColumnName("fi_lease_mo_yr")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FiLeaseYerExpires).HasColumnName("fi_lease_yer_expires");

                entity.Property(e => e.FiLoanPayment)
                    .HasColumnName("fi_loan_payment")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiMaintDollars)
                    .HasColumnName("fi_maint_dollars")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiMaintPct)
                    .HasColumnName("fi_maint_pct")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.FiMoGrossSchInc)
                    .HasColumnName("fi_mo_gross_sch_inc")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiNetIncome)
                    .HasColumnName("fi_net_income")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiNewTaxes)
                    .HasColumnName("fi_new_taxes")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiOperatingExp)
                    .HasColumnName("fi_operating_exp")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiOperatingPct)
                    .HasColumnName("fi_operating_pct")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.FiOtherExpAmt)
                    .HasColumnName("fi_other_exp_amt")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiOtherIncome)
                    .HasColumnName("fi_other_income")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FiOtherIncomeDesc)
                    .HasColumnName("fi_other_income_desc")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FiPerPropDollars)
                    .HasColumnName("fi_per_prop_dollars")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiPerPropRate)
                    .HasColumnName("fi_per_prop_rate")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiPoolExpense)
                    .HasColumnName("fi_pool_expense")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiPossession)
                    .HasColumnName("fi_possession")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FiPricePerUnit)
                    .HasColumnName("fi_price_per_unit")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiProfMgmtYn)
                    .HasColumnName("fi_prof_mgmt_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.FiSecondTrustDeedAmount)
                    .HasColumnName("fi_second_trust_deed_amount")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiSecondTrustDeedAssumable)
                    .HasColumnName("fi_second_trust_deed_assumable")
                    .HasColumnType("char(1)");

                entity.Property(e => e.FiSecondTrustDeedDue).HasColumnName("fi_second_trust_deed_due");

                entity.Property(e => e.FiSecondTrustDeedFee)
                    .HasColumnName("fi_second_trust_deed_fee")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiSecondTrustDeedInterest)
                    .HasColumnName("fi_second_trust_deed_interest")
                    .HasColumnType("decimal(5,3)");

                entity.Property(e => e.FiSecondTrustDeedLender)
                    .HasColumnName("fi_second_trust_deed_lender")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FiSecondTrustDeedRate)
                    .HasColumnName("fi_second_trust_deed_rate")
                    .HasColumnType("char(2)");

                entity.Property(e => e.FiSecondTrustDeedType)
                    .HasColumnName("fi_second_trust_deed_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.FiTaxAmount)
                    .HasColumnName("fi_tax_amount")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiTaxArea)
                    .HasColumnName("fi_tax_area")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FiTaxDescriptionFeatures)
                    .HasColumnName("fi_tax_description_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FiTaxPeriod)
                    .HasColumnName("fi_tax_period")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.FiTotalActualRent)
                    .HasColumnName("fi_total_actual_rent")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiTotalExpense)
                    .HasColumnName("fi_total_expense")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiTotalTaxRate)
                    .HasColumnName("fi_total_tax_rate")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.FiTotalTaxes)
                    .HasColumnName("fi_total_taxes")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiWorkmanComp)
                    .HasColumnName("fi_workman_comp")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.IfApplianceFeatures)
                    .HasColumnName("if_appliance_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IfBasementFeatures)
                    .HasColumnName("if_basement_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IfCoolingFeatures)
                    .HasColumnName("if_cooling_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IfCoolingYn)
                    .HasColumnName("if_cooling_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.IfEnergyFeatures)
                    .HasColumnName("if_energy_features")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.IfFireplaceFeatures)
                    .HasColumnName("if_fireplace_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IfFireplaceNumber)
                    .HasColumnName("if_fireplace_number")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.IfFireplaceYn)
                    .HasColumnName("if_fireplace_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.IfFloorFeatures)
                    .HasColumnName("if_floor_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IfGeneralFeatures)
                    .HasColumnName("if_general_features")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IfHeatingFeatures)
                    .HasColumnName("if_heating_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IfLevels)
                    .HasColumnName("if_levels")
                    .HasColumnType("char(2)");

                entity.Property(e => e.IfLevelsFeatures)
                    .HasColumnName("if_levels_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.IfPetFeatures)
                    .HasColumnName("if_pet_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IfPlumbingFeatures)
                    .HasColumnName("if_plumbing_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.IfSecurityFeatures)
                    .HasColumnName("if_security_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.IfSecuritySystemYn)
                    .HasColumnName("if_security_system_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.IfSpecialFeatures)
                    .HasColumnName("if_special_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IfUtilitiesFeatures)
                    .HasColumnName("if_utilities_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.IfWaterFeatures)
                    .HasColumnName("if_water_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.IfWindowFeatures)
                    .HasColumnName("if_window_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.InAdditionalPicturesYn)
                    .IsRequired()
                    .HasColumnName("in_additional_pictures_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InAdditionsAlter)
                    .HasColumnName("in_additions_alter")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InAdom)
                    .HasColumnName("in_adom")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InAgeFeatures)
                    .HasColumnName("in_age_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InApNumber)
                    .HasColumnName("in_ap_number")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.InAssociationDues1)
                    .HasColumnName("in_association_dues1")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InAssociationDues2)
                    .HasColumnName("in_association_dues2")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InAssociationFeatures)
                    .HasColumnName("in_association_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InAssociationLitigationYn)
                    .HasColumnName("in_association_litigation_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InAssociationPeriod)
                    .HasColumnName("in_association_period")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.InAssociationPhone)
                    .HasColumnName("in_association_phone")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.InAssociationYn)
                    .HasColumnName("in_association_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InAvgSqft1br)
                    .HasColumnName("in_avg_sqft_1br")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.InAvgSqft2br)
                    .HasColumnName("in_avg_sqft_2br")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.InAvgSqft3br)
                    .HasColumnName("in_avg_sqft_3br")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.InAvgSqftStudio)
                    .HasColumnName("in_avg_sqft_studio")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.InBldgPermit)
                    .HasColumnName("in_bldg_permit")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InBuilderName)
                    .HasColumnName("in_builder_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InCableTvYn)
                    .HasColumnName("in_cable_tv_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InCarports)
                    .HasColumnName("in_carports")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InCloseDate).HasColumnName("in_close_date");

                entity.Property(e => e.InCoastalZoneYn)
                    .HasColumnName("in_coastal_zone_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InCompensationBuyAgent)
                    .HasColumnName("in_compensation_buy_agent")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.InCompensationNonrep)
                    .HasColumnName("in_compensation_nonrep")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.InCompensationTransactionAgent)
                    .HasColumnName("in_compensation_transaction_agent")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.InDetailUrl)
                    .HasColumnName("in_detail_url")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.InDistressType)
                    .HasColumnName("in_distress_type")
                    .HasMaxLength(59)
                    .IsUnicode(false);

                entity.Property(e => e.InEscrowDate).HasColumnName("in_escrow_date");

                entity.Property(e => e.InExclusions)
                    .HasColumnName("in_exclusions")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InFloodZoneYn)
                    .HasColumnName("in_flood_zone_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InGarageNoRented)
                    .HasColumnName("in_garage_no_rented")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InGarageRentRate)
                    .HasColumnName("in_garage_rent_rate")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.InGaragesNo)
                    .HasColumnName("in_garages_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InGardenerYn)
                    .HasColumnName("in_gardener_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InImageCount)
                    .HasColumnName("in_image_count")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.InIsAttached)
                    .HasColumnName("in_is_attached")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InKeyboxFeatures)
                    .HasColumnName("in_keybox_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.InKeyboxLocation)
                    .HasColumnName("in_keybox_location")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InLastTransactionCode)
                    .HasColumnName("in_last_transaction_code")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InLatitude).HasColumnName("in_latitude");

                entity.Property(e => e.InLaundryEqmtYn)
                    .HasColumnName("in_laundry_eqmt_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InLeaseAmount)
                    .HasColumnName("in_lease_amount")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InLeaseOptionYn)
                    .HasColumnName("in_lease_option_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InLeasePeriod)
                    .HasColumnName("in_lease_period")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.InLeaseTerm)
                    .HasColumnName("in_lease_term")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.InLegalDescription)
                    .HasColumnName("in_legal_description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InLegalFeatures)
                    .HasColumnName("in_legal_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InListDate).HasColumnName("in_list_date");

                entity.Property(e => e.InListPrice)
                    .HasColumnName("in_list_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InListPriceExclusionRemarks)
                    .HasColumnName("in_list_price_exclusion_remarks")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.InListingAgreementType)
                    .HasColumnName("in_listing_agreement_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.InListingHasForSaleSignYn)
                    .HasColumnName("in_listing_has_for_sale_sign_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InListingLoadedByBroker)
                    .HasColumnName("in_listing_loaded_by_broker")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.InLoadDate).HasColumnName("in_load_date");

                entity.Property(e => e.InLongitude).HasColumnName("in_longitude");

                entity.Property(e => e.InManagerSalary)
                    .HasColumnName("in_manager_salary")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InModifyDate).HasColumnName("in_modify_date");

                entity.Property(e => e.InNumUnitsLeased)
                    .HasColumnName("in_num_units_leased")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InNumberPatio)
                    .HasColumnName("in_number_patio")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InNumberUnits)
                    .HasColumnName("in_number_units")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InOffmarketDate).HasColumnName("in_offmarket_date");

                entity.Property(e => e.InOrigListPrice)
                    .HasColumnName("in_orig_list_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InOtherExpDesc)
                    .HasColumnName("in_other_exp_desc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InOwnerName)
                    .HasColumnName("in_owner_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InOwnerPhone)
                    .HasColumnName("in_owner_phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InPendingDate).HasColumnName("in_pending_date");

                entity.Property(e => e.InPendingPrice)
                    .HasColumnName("in_pending_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InPestControlYn)
                    .HasColumnName("in_pest_control_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InPreviousListPrice)
                    .HasColumnName("in_previous_list_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InPreviousStatus)
                    .HasColumnName("in_previous_status")
                    .HasColumnType("char(2)");

                entity.Property(e => e.InProjectedEscrowCloseDate).HasColumnName("in_projected_escrow_close_date");

                entity.Property(e => e.InPropertyType)
                    .HasColumnName("in_property_type")
                    .HasColumnType("char(3)");

                entity.Property(e => e.InPublicRemarks)
                    .HasColumnName("in_public_remarks")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.InPullDate).HasColumnName("in_pull_date");

                entity.Property(e => e.InRangeHighPrice)
                    .HasColumnName("in_range_high_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InRangeLowPrice)
                    .HasColumnName("in_range_low_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InRangePriceFlag)
                    .HasColumnName("in_range_price_flag")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InRecRoomYn)
                    .HasColumnName("in_rec_room_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InReciprocalListing)
                    .HasColumnName("in_reciprocal_listing")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InRemodeledDate).HasColumnName("in_remodeled_date");

                entity.Property(e => e.InRentControlYn)
                    .HasColumnName("in_rent_control_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InRestrictions)
                    .HasColumnName("in_restrictions")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InSellerAgreesToPayPoints)
                    .HasColumnName("in_seller_agrees_to_pay_points")
                    .HasColumnType("char(4)");

                entity.Property(e => e.InSellingOfficeComp)
                    .HasColumnName("in_selling_office_comp")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.InSellingOfficeCompType)
                    .HasColumnName("in_selling_office_comp_type")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InSellingOfficeCompensation)
                    .HasColumnName("in_selling_office_compensation")
                    .HasColumnType("char(4)");

                entity.Property(e => e.InSepMtrElecYn)
                    .HasColumnName("in_sep_mtr_elec_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InSepMtrGasYn)
                    .HasColumnName("in_sep_mtr_gas_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InSepMtrWaterYn)
                    .HasColumnName("in_sep_mtr_water_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InShowingInstructions)
                    .HasColumnName("in_showing_instructions")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.InSlideZoneYn)
                    .HasColumnName("in_slide_zone_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InSoldAgentName)
                    .HasColumnName("in_sold_agent_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InSoldAgentOfficeId)
                    .HasColumnName("in_sold_agent_office_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.InSoldAgentPublicId)
                    .HasColumnName("in_sold_agent_public_id")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.InSoldDate).HasColumnName("in_sold_date");

                entity.Property(e => e.InSoldFinanceTerms)
                    .HasColumnName("in_sold_finance_terms")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InSoldOfficeName)
                    .HasColumnName("in_sold_office_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InSoldPrice)
                    .HasColumnName("in_sold_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InSoldTerms)
                    .HasColumnName("in_sold_terms")
                    .HasColumnType("char(2)");

                entity.Property(e => e.InStatus)
                    .HasColumnName("in_status")
                    .HasColumnType("char(2)");

                entity.Property(e => e.InStatusDate).HasColumnName("in_status_date");

                entity.Property(e => e.InSubtype)
                    .HasColumnName("in_subtype")
                    .HasColumnType("char(3)");

                entity.Property(e => e.InSystemExpireDate).HasColumnName("in_system_expire_date");

                entity.Property(e => e.InTenantPaysCableYn)
                    .HasColumnName("in_tenant_pays_cable_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InTenantPaysElecYn)
                    .HasColumnName("in_tenant_pays_elec_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InTenantPaysGasYn)
                    .HasColumnName("in_tenant_pays_gas_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InTenantPaysTrashYn)
                    .HasColumnName("in_tenant_pays_trash_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InTenantPaysWaterYn)
                    .HasColumnName("in_tenant_pays_water_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InTotalAssessedValue)
                    .HasColumnName("in_total_assessed_value")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InTotalBldgSqft)
                    .HasColumnName("in_total_bldg_sqft")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.InTotalBldgs)
                    .HasColumnName("in_total_bldgs")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InTotalUnitsInComplex)
                    .HasColumnName("in_total_units_in_complex")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.InTractCode)
                    .HasColumnName("in_tract_code")
                    .HasColumnType("char(4)");

                entity.Property(e => e.InTractName)
                    .HasColumnName("in_tract_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InTransactDate).HasColumnName("in_transact_date");

                entity.Property(e => e.InTransferOfPossession)
                    .HasColumnName("in_transfer_of_possession")
                    .HasColumnType("char(2)");

                entity.Property(e => e.InTrashYn)
                    .HasColumnName("in_trash_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InViewYn)
                    .HasColumnName("in_view_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InVirtualTourLink)
                    .HasColumnName("in_virtual_tour_link")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InVolt220OutletLocation)
                    .HasColumnName("in_volt220_outlet_location")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InWithdrawnDate).HasColumnName("in_withdrawn_date");

                entity.Property(e => e.InYearBuilt)
                    .HasColumnName("in_year_built")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.LastImport)
                    .HasColumnName("last_import")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ListOnInternetYn)
                    .HasColumnName("list_on_internet_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ListingIddYn)
                    .HasColumnName("listing_idd_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.PublishStatus)
                    .HasColumnName("publish_status")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RegMlsCode)
                    .HasColumnName("reg_mls_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmBathroomFeatures)
                    .HasColumnName("rm_bathroom_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RmBathsFull)
                    .HasColumnName("rm_baths_full")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.RmBathsHalf)
                    .HasColumnName("rm_baths_half")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.RmBathsQuarter)
                    .HasColumnName("rm_baths_quarter")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.RmBathsThreeQuarter)
                    .HasColumnName("rm_baths_three_quarter")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.RmBathsTotal)
                    .HasColumnName("rm_baths_total")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.RmBedroomFeatures)
                    .HasColumnName("rm_bedroom_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RmBedroomsTotal)
                    .HasColumnName("rm_bedrooms_total")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.RmBonusFeatures)
                    .HasColumnName("rm_bonus_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RmBonusYn)
                    .HasColumnName("rm_bonus_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.RmDenYn)
                    .HasColumnName("rm_den_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.RmDiningFeatures)
                    .HasColumnName("rm_dining_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RmFamilyYn)
                    .HasColumnName("rm_family_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.RmFormalDiningYn)
                    .HasColumnName("rm_formal_dining_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.RmGeneralFeatures)
                    .HasColumnName("rm_general_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RmKitchenFeatures)
                    .HasColumnName("rm_kitchen_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RmLaundryFeatures)
                    .HasColumnName("rm_laundry_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RmLivingFeatures)
                    .HasColumnName("rm_living_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RmLivingYn)
                    .HasColumnName("rm_living_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.RmMasterDressingAreaYn)
                    .HasColumnName("rm_master_dressing_area_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.RmMasterYn)
                    .HasColumnName("rm_master_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.RmRoomsTotal)
                    .HasColumnName("rm_rooms_total")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RmTermiteClearYn)
                    .HasColumnName("rm_termite_clear_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.RmUtilityFeatures)
                    .HasColumnName("rm_utility_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RmWalkInClosets)
                    .HasColumnName("rm_walk_in_closets")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.ScElementarySchool)
                    .HasColumnName("sc_elementary_school")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScHighSchool)
                    .HasColumnName("sc_high_school")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScJuniorHighSchool)
                    .HasColumnName("sc_junior_high_school")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScSchoolDistrict)
                    .HasColumnName("sc_school_district")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Un10ActualRent)
                    .HasColumnName("un_10_actual_rent")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Un10FurnishedYn)
                    .HasColumnName("un_10_furnished_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Un10NumberBaths)
                    .HasColumnName("un_10_number_baths")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Un10NumberBeds)
                    .HasColumnName("un_10_number_beds")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Un10NumberUnits)
                    .HasColumnName("un_10_number_units")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Un10TotalRent)
                    .HasColumnName("un_10_total_rent")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Un11ActualRent)
                    .HasColumnName("un_11_actual_rent")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Un11FurnishedYn)
                    .HasColumnName("un_11_furnished_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Un11NumberBaths)
                    .HasColumnName("un_11_number_baths")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Un11NumberBeds)
                    .HasColumnName("un_11_number_beds")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Un11NumberUnits)
                    .HasColumnName("un_11_number_units")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Un11TotalRent)
                    .HasColumnName("un_11_total_rent")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Un12ActualRent)
                    .HasColumnName("un_12_actual_rent")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Un12FurnishedYn)
                    .HasColumnName("un_12_furnished_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Un12NumberBaths)
                    .HasColumnName("un_12_number_baths")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Un12NumberBeds)
                    .HasColumnName("un_12_number_beds")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Un12NumberUnits)
                    .HasColumnName("un_12_number_units")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Un12TotalRent)
                    .HasColumnName("un_12_total_rent")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Un13ActualRent)
                    .HasColumnName("un_13_actual_rent")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Un13FurnishedYn)
                    .HasColumnName("un_13_furnished_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Un13NumberBaths)
                    .HasColumnName("un_13_number_baths")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Un13NumberBeds)
                    .HasColumnName("un_13_number_beds")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Un13NumberUnits)
                    .HasColumnName("un_13_number_units")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Un13TotalRent)
                    .HasColumnName("un_13_total_rent")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Un1ActualRent)
                    .HasColumnName("un_1_actual_rent")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Un1FurnishedYn)
                    .HasColumnName("un_1_furnished_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Un1NumberBaths)
                    .HasColumnName("un_1_number_baths")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Un1NumberBeds)
                    .HasColumnName("un_1_number_beds")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Un1NumberUnits)
                    .HasColumnName("un_1_number_units")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Un1TotalRent)
                    .HasColumnName("un_1_total_rent")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Un2ActualRent)
                    .HasColumnName("un_2_actual_rent")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Un2FurnishedYn)
                    .HasColumnName("un_2_furnished_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Un2NumberBaths)
                    .HasColumnName("un_2_number_baths")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Un2NumberBeds)
                    .HasColumnName("un_2_number_beds")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Un2NumberUnits)
                    .HasColumnName("un_2_number_units")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Un2TotalRent)
                    .HasColumnName("un_2_total_rent")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Un3ActualRent)
                    .HasColumnName("un_3_actual_rent")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Un3FurnishedYn)
                    .HasColumnName("un_3_furnished_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Un3NumberBaths)
                    .HasColumnName("un_3_number_baths")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Un3NumberBeds)
                    .HasColumnName("un_3_number_beds")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Un3NumberUnits)
                    .HasColumnName("un_3_number_units")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Un3TotalRent)
                    .HasColumnName("un_3_total_rent")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Un4ActualRent)
                    .HasColumnName("un_4_actual_rent")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Un4FurnishedYn)
                    .HasColumnName("un_4_furnished_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Un4NumberBaths)
                    .HasColumnName("un_4_number_baths")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Un4NumberBeds)
                    .HasColumnName("un_4_number_beds")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Un4NumberUnits)
                    .HasColumnName("un_4_number_units")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Un4TotalRent)
                    .HasColumnName("un_4_total_rent")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Un5ActualRent)
                    .HasColumnName("un_5_actual_rent")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Un5FurnishedYn)
                    .HasColumnName("un_5_furnished_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Un5NumberBaths)
                    .HasColumnName("un_5_number_baths")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Un5NumberBeds)
                    .HasColumnName("un_5_number_beds")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Un5NumberUnits)
                    .HasColumnName("un_5_number_units")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Un5TotalRent)
                    .HasColumnName("un_5_total_rent")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Un6ActualRent)
                    .HasColumnName("un_6_actual_rent")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Un6FurnishedYn)
                    .HasColumnName("un_6_furnished_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Un6NumberBaths)
                    .HasColumnName("un_6_number_baths")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Un6NumberBeds)
                    .HasColumnName("un_6_number_beds")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Un6NumberUnits)
                    .HasColumnName("un_6_number_units")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Un6TotalRent)
                    .HasColumnName("un_6_total_rent")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Un7ActualRent)
                    .HasColumnName("un_7_actual_rent")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Un7FurnishedYn)
                    .HasColumnName("un_7_furnished_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Un7NumberBaths)
                    .HasColumnName("un_7_number_baths")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Un7NumberBeds)
                    .HasColumnName("un_7_number_beds")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Un7NumberUnits)
                    .HasColumnName("un_7_number_units")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Un7TotalRent)
                    .HasColumnName("un_7_total_rent")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Un8ActualRent)
                    .HasColumnName("un_8_actual_rent")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Un8FurnishedYn)
                    .HasColumnName("un_8_furnished_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Un8NumberBaths)
                    .HasColumnName("un_8_number_baths")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Un8NumberBeds)
                    .HasColumnName("un_8_number_beds")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Un8NumberUnits)
                    .HasColumnName("un_8_number_units")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Un8TotalRent)
                    .HasColumnName("un_8_total_rent")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Un9ActualRent)
                    .HasColumnName("un_9_actual_rent")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Un9FurnishedYn)
                    .HasColumnName("un_9_furnished_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Un9NumberBaths)
                    .HasColumnName("un_9_number_baths")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Un9NumberBeds)
                    .HasColumnName("un_9_number_beds")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Un9NumberUnits)
                    .HasColumnName("un_9_number_units")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.Un9TotalRent)
                    .HasColumnName("un_9_total_rent")
                    .HasColumnType("decimal(10,0)");
            });

            modelBuilder.Entity<MlsLandListings>(entity =>
            {
                entity.HasKey(e => new { e.OrgId, e.ListingId });

                entity.ToTable("mls_land_listings", "rezoradata");

                entity.HasIndex(e => e.LastImport)
                    .HasName("last_import");

                entity.HasIndex(e => new { e.InLatitude, e.InLongitude, e.ListOnInternetYn, e.PublishStatus })
                    .HasName("geocoded");

                entity.Property(e => e.OrgId)
                    .HasColumnName("org_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ListingId)
                    .HasColumnName("listing_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.AdArea)
                    .HasColumnName("ad_area")
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.AdBlockNumber)
                    .HasColumnName("ad_block_number")
                    .HasColumnType("char(4)");

                entity.Property(e => e.AdCityName)
                    .HasColumnName("ad_city_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AdCountyCode)
                    .HasColumnName("ad_county_code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AdCountyFips)
                    .HasColumnName("ad_county_fips")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AdCrossStreets)
                    .HasColumnName("ad_cross_streets")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AdDirections)
                    .HasColumnName("ad_directions")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoCityName)
                    .HasColumnName("ad_geo_city_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoState)
                    .HasColumnName("ad_geo_state")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoStreetDesignator)
                    .HasColumnName("ad_geo_street_designator")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoStreetDirection)
                    .HasColumnName("ad_geo_street_direction")
                    .HasColumnType("char(2)");

                entity.Property(e => e.AdGeoStreetName)
                    .HasColumnName("ad_geo_street_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoStreetNumber)
                    .HasColumnName("ad_geo_street_number")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoStreetPostDir)
                    .HasColumnName("ad_geo_street_post_dir")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoStreetPreType)
                    .HasColumnName("ad_geo_street_pre_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoStreetUnitType)
                    .HasColumnName("ad_geo_street_unit_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoStreetZip4)
                    .HasColumnName("ad_geo_street_zip4")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoUnit)
                    .HasColumnName("ad_geo_unit")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoZipCode)
                    .HasColumnName("ad_geo_zip_code")
                    .HasColumnType("char(5)");

                entity.Property(e => e.AdLotNumber)
                    .HasColumnName("ad_lot_number")
                    .HasColumnType("char(3)");

                entity.Property(e => e.AdMapCode)
                    .HasColumnName("ad_map_code")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AdMapPrecision)
                    .HasColumnName("ad_map_precision")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.AdMarketingArea)
                    .HasColumnName("ad_marketing_area")
                    .HasColumnType("char(4)");

                entity.Property(e => e.AdNeighborhood)
                    .HasColumnName("ad_neighborhood")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AdParcelNumber)
                    .HasColumnName("ad_parcel_number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AdPostalCode)
                    .HasColumnName("ad_postal_code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.AdState)
                    .HasColumnName("ad_state")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.AdStreetDesignator)
                    .HasColumnName("ad_street_designator")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdStreetDirection)
                    .HasColumnName("ad_street_direction")
                    .HasColumnType("char(2)");

                entity.Property(e => e.AdStreetName)
                    .HasColumnName("ad_street_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdStreetNumber)
                    .HasColumnName("ad_street_number")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AdStreetPostDir)
                    .HasColumnName("ad_street_post_dir")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdStreetPreType)
                    .HasColumnName("ad_street_pre_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdStreetUnitType)
                    .HasColumnName("ad_street_unit_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdStreetZip4)
                    .HasColumnName("ad_street_zip4")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdTractNumber)
                    .HasColumnName("ad_tract_number")
                    .HasColumnType("char(5)");

                entity.Property(e => e.AdUnit)
                    .HasColumnName("ad_unit")
                    .HasColumnType("char(8)");

                entity.Property(e => e.AdZipCode)
                    .HasColumnName("ad_zip_code")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AdZoneFeatures)
                    .HasColumnName("ad_zone_features")
                    .HasMaxLength(59)
                    .IsUnicode(false);

                entity.Property(e => e.AgCoagentId)
                    .HasColumnName("ag_coagent_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.AgCoagentName)
                    .HasColumnName("ag_coagent_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgCoagentPhone)
                    .HasColumnName("ag_coagent_phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgEmail)
                    .HasColumnName("ag_email")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.AgFax)
                    .HasColumnName("ag_fax")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgId)
                    .HasColumnName("ag_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.AgMayRepresentSellerAndBuyer)
                    .HasColumnName("ag_may_represent_seller_and_buyer")
                    .HasColumnType("char(2)");

                entity.Property(e => e.AgMobilePhone)
                    .HasColumnName("ag_mobile_phone")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.AgName)
                    .HasColumnName("ag_name")
                    .HasMaxLength(61)
                    .IsUnicode(false);

                entity.Property(e => e.AgOfficeEmail)
                    .HasColumnName("ag_office_email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgOfficeId)
                    .HasColumnName("ag_office_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.AgOfficeName)
                    .HasColumnName("ag_office_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AgOfficePhone)
                    .HasColumnName("ag_office_phone")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.AgPager)
                    .HasColumnName("ag_pager")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgPhone)
                    .HasColumnName("ag_phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgReciprocalLink)
                    .HasColumnName("ag_reciprocal_link")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.AgRemarks)
                    .HasColumnName("ag_remarks")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AgRepresentationFeatures)
                    .HasColumnName("ag_representation_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgVmail)
                    .HasColumnName("ag_vmail")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgWebsite)
                    .HasColumnName("ag_website")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayAddressYn)
                    .HasColumnName("display_address_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.DisplayDistressedPropertyYn)
                    .HasColumnName("display_distressed_property_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ExAcresPasture)
                    .HasColumnName("ex_acres_pasture")
                    .HasColumnType("decimal(10,4)");

                entity.Property(e => e.ExAcresTillable)
                    .HasColumnName("ex_acres_tillable")
                    .HasColumnType("decimal(10,4)");

                entity.Property(e => e.ExAcresWooded)
                    .HasColumnName("ex_acres_wooded")
                    .HasColumnType("decimal(10,4)");

                entity.Property(e => e.ExFenceFeatures)
                    .HasColumnName("ex_fence_features")
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.ExFldZoneYn)
                    .HasColumnName("ex_fld_zone_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ExGeneralLandFeatures)
                    .HasColumnName("ex_general_land_features")
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ExLocationFeatures)
                    .HasColumnName("ex_location_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.ExLotSizeAcres)
                    .HasColumnName("ex_lot_size_acres")
                    .HasColumnType("decimal(10,4)");

                entity.Property(e => e.ExLotSizeDimensions)
                    .HasColumnName("ex_lot_size_dimensions")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExLotSizeFeatures)
                    .HasColumnName("ex_lot_size_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.ExLotSizeSource)
                    .HasColumnName("ex_lot_size_source")
                    .HasColumnType("char(2)");

                entity.Property(e => e.ExLotSizeSquareFeet)
                    .HasColumnName("ex_lot_size_square_feet")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ExLotsizeRange)
                    .HasColumnName("ex_lotsize_range")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExParkingFeatures)
                    .HasColumnName("ex_parking_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExParkingSpaces)
                    .HasColumnName("ex_parking_spaces")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.ExParkingSpacesTotal)
                    .HasColumnName("ex_parking_spaces_total")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.ExRoadFeatures)
                    .HasColumnName("ex_road_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExSewerFeatures)
                    .HasColumnName("ex_sewer_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.ExStormDrainsYn)
                    .HasColumnName("ex_storm_drains_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ExStreetFrontageYn)
                    .HasColumnName("ex_street_frontage_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ExStyle)
                    .HasColumnName("ex_style")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ExTreesDesc)
                    .HasColumnName("ex_trees_desc")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExTypesOfSoil)
                    .HasColumnName("ex_types_of_soil")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExViewFeatures)
                    .HasColumnName("ex_view_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.ExWaterTableYn)
                    .HasColumnName("ex_water_table_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ExWateraccessFeatures)
                    .HasColumnName("ex_wateraccess_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExWaterfrontFeatures)
                    .HasColumnName("ex_waterfront_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExWellDepth)
                    .HasColumnName("ex_well_depth")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ExWellGalPerMinute)
                    .HasColumnName("ex_well_gal_per_minute")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ExWellPumpMotorYn)
                    .HasColumnName("ex_well_pump_motor_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ExWellSizeHole)
                    .HasColumnName("ex_well_size_hole")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExWellYn)
                    .HasColumnName("ex_well_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.FiAdditionalFinanceInfo)
                    .HasColumnName("fi_additional_finance_Info")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FiCompTrigger)
                    .HasColumnName("fi_comp_trigger")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FiFinanceFeatures)
                    .HasColumnName("fi_finance_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FiFinanceSponsor)
                    .HasColumnName("fi_finance_sponsor")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FiFinanceTerms)
                    .HasColumnName("fi_finance_terms")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FiFirstTrustDeedAmount)
                    .HasColumnName("fi_first_trust_deed_amount")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiFirstTrustDeedAssumable)
                    .HasColumnName("fi_first_trust_deed_assumable")
                    .HasColumnType("char(1)");

                entity.Property(e => e.FiFirstTrustDeedDue).HasColumnName("fi_first_trust_deed_due");

                entity.Property(e => e.FiFirstTrustDeedFee)
                    .HasColumnName("fi_first_trust_deed_fee")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiFirstTrustDeedInterest)
                    .HasColumnName("fi_first_trust_deed_interest")
                    .HasColumnType("decimal(5,3)");

                entity.Property(e => e.FiFirstTrustDeedLender)
                    .HasColumnName("fi_first_trust_deed_lender")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FiFirstTrustDeedRate)
                    .HasColumnName("fi_first_trust_deed_rate")
                    .HasColumnType("char(2)");

                entity.Property(e => e.FiFirstTrustDeedType)
                    .HasColumnName("fi_first_trust_deed_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.FiGrossEquity)
                    .HasColumnName("fi_gross_equity")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiIgnoreCompTrigger)
                    .HasColumnName("fi_ignore_comp_trigger")
                    .HasColumnType("char(1)");

                entity.Property(e => e.FiIgnorePaidYn)
                    .HasColumnName("fi_ignore_paid_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.FiPossession)
                    .HasColumnName("fi_possession")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FiSecondTrustDeedAmount)
                    .HasColumnName("fi_second_trust_deed_amount")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiSecondTrustDeedAssumable)
                    .HasColumnName("fi_second_trust_deed_assumable")
                    .HasColumnType("char(1)");

                entity.Property(e => e.FiSecondTrustDeedDue).HasColumnName("fi_second_trust_deed_due");

                entity.Property(e => e.FiSecondTrustDeedFee)
                    .HasColumnName("fi_second_trust_deed_fee")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiSecondTrustDeedInterest)
                    .HasColumnName("fi_second_trust_deed_interest")
                    .HasColumnType("decimal(5,3)");

                entity.Property(e => e.FiSecondTrustDeedLender)
                    .HasColumnName("fi_second_trust_deed_lender")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FiSecondTrustDeedRate)
                    .HasColumnName("fi_second_trust_deed_rate")
                    .HasColumnType("char(2)");

                entity.Property(e => e.FiSecondTrustDeedType)
                    .HasColumnName("fi_second_trust_deed_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.FiTaxAmount)
                    .HasColumnName("fi_tax_amount")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiTaxDescriptionFeatures)
                    .HasColumnName("fi_tax_description_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FiTaxPeriod)
                    .HasColumnName("fi_tax_period")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.FiTotalTaxRate)
                    .HasColumnName("fi_total_tax_rate")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.IfLevelsFeatures)
                    .HasColumnName("if_levels_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.IfSpecialFeatures)
                    .HasColumnName("if_special_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IfUtilitiesFeatures)
                    .HasColumnName("if_utilities_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.IfWaterFeatures)
                    .HasColumnName("if_water_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.InAdditionalPicturesYn)
                    .IsRequired()
                    .HasColumnName("in_additional_pictures_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InAdom)
                    .HasColumnName("in_adom")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InApNumber)
                    .HasColumnName("in_ap_number")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.InAssociationDues1)
                    .HasColumnName("in_association_dues1")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InAssociationDues2)
                    .HasColumnName("in_association_dues2")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InAssociationFeatures)
                    .HasColumnName("in_association_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InAssociationLitigationYn)
                    .HasColumnName("in_association_litigation_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InAssociationPeriod)
                    .HasColumnName("in_association_period")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.InAssociationPhone)
                    .HasColumnName("in_association_phone")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.InAssociationYn)
                    .HasColumnName("in_association_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InClearedYn)
                    .HasColumnName("in_cleared_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InCloseDate).HasColumnName("in_close_date");

                entity.Property(e => e.InCoastalZoneYn)
                    .HasColumnName("in_coastal_zone_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InCompensationBuyAgent)
                    .HasColumnName("in_compensation_buy_agent")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.InCompensationNonrep)
                    .HasColumnName("in_compensation_nonrep")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.InCompensationTransactionAgent)
                    .HasColumnName("in_compensation_transaction_agent")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.InDetailUrl)
                    .HasColumnName("in_detail_url")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.InDistressType)
                    .HasColumnName("in_distress_type")
                    .HasMaxLength(59)
                    .IsUnicode(false);

                entity.Property(e => e.InElevation)
                    .HasColumnName("in_elevation")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InEscrowDate).HasColumnName("in_escrow_date");

                entity.Property(e => e.InExclusions)
                    .HasColumnName("in_exclusions")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InFloodZoneYn)
                    .HasColumnName("in_flood_zone_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InImageCount)
                    .HasColumnName("in_image_count")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.InImprovements)
                    .HasColumnName("in_improvements")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InLastTransactionCode)
                    .HasColumnName("in_last_transaction_code")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InLatitude).HasColumnName("in_latitude");

                entity.Property(e => e.InLeaseAmount)
                    .HasColumnName("in_lease_amount")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InLeaseOptionYn)
                    .HasColumnName("in_lease_option_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InLeasePeriod)
                    .HasColumnName("in_lease_period")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.InLeaseTerm)
                    .HasColumnName("in_lease_term")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.InLegalDescription)
                    .HasColumnName("in_legal_description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InLegalFeatures)
                    .HasColumnName("in_legal_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InListDate).HasColumnName("in_list_date");

                entity.Property(e => e.InListPrice)
                    .HasColumnName("in_list_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InListPriceExclusionRemarks)
                    .HasColumnName("in_list_price_exclusion_remarks")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.InListingAgreementType)
                    .HasColumnName("in_listing_agreement_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.InListingHasForSaleSignYn)
                    .HasColumnName("in_listing_has_for_sale_sign_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InListingLoadedByBroker)
                    .HasColumnName("in_listing_loaded_by_broker")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.InLoadDate).HasColumnName("in_load_date");

                entity.Property(e => e.InLongitude).HasColumnName("in_longitude");

                entity.Property(e => e.InMineralRightsYn)
                    .HasColumnName("in_mineral_rights_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InModifyDate).HasColumnName("in_modify_date");

                entity.Property(e => e.InOffmarketDate).HasColumnName("in_offmarket_date");

                entity.Property(e => e.InOrigListPrice)
                    .HasColumnName("in_orig_list_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InOwnerName)
                    .HasColumnName("in_owner_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InOwnerPhone)
                    .HasColumnName("in_owner_phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InOwnerSurveyYn)
                    .HasColumnName("in_owner_survey_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InPendingDate).HasColumnName("in_pending_date");

                entity.Property(e => e.InPendingPrice)
                    .HasColumnName("in_pending_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InPotentialUse)
                    .HasColumnName("in_potential_use")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InPresentUse)
                    .HasColumnName("in_present_use")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InPreviousListPrice)
                    .HasColumnName("in_previous_list_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InPreviousStatus)
                    .HasColumnName("in_previous_status")
                    .HasColumnType("char(2)");

                entity.Property(e => e.InProjectedEscrowCloseDate).HasColumnName("in_projected_escrow_close_date");

                entity.Property(e => e.InPropertyType)
                    .HasColumnName("in_property_type")
                    .HasColumnType("char(3)");

                entity.Property(e => e.InPublicRemarks)
                    .HasColumnName("in_public_remarks")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.InPullDate).HasColumnName("in_pull_date");

                entity.Property(e => e.InRangeHighPrice)
                    .HasColumnName("in_range_high_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InRangeLowPrice)
                    .HasColumnName("in_range_low_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InRangePriceFlag)
                    .HasColumnName("in_range_price_flag")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InReciprocalListing)
                    .HasColumnName("in_reciprocal_listing")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InRestrictions)
                    .HasColumnName("in_restrictions")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InSellerAgreesToPayPoints)
                    .HasColumnName("in_seller_agrees_to_pay_points")
                    .HasColumnType("char(4)");

                entity.Property(e => e.InSellingOfficeComp)
                    .HasColumnName("in_selling_office_comp")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.InSellingOfficeCompType)
                    .HasColumnName("in_selling_office_comp_type")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InSellingOfficeCompensation)
                    .HasColumnName("in_selling_office_compensation")
                    .HasColumnType("char(4)");

                entity.Property(e => e.InShowingInstructions)
                    .HasColumnName("in_showing_instructions")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.InSoldAgentName)
                    .HasColumnName("in_sold_agent_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InSoldAgentOfficeId)
                    .HasColumnName("in_sold_agent_office_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.InSoldAgentPublicId)
                    .HasColumnName("in_sold_agent_public_id")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.InSoldDate).HasColumnName("in_sold_date");

                entity.Property(e => e.InSoldFinanceTerms)
                    .HasColumnName("in_sold_finance_terms")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InSoldOfficeName)
                    .HasColumnName("in_sold_office_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InSoldPrice)
                    .HasColumnName("in_sold_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InSoldTerms)
                    .HasColumnName("in_sold_terms")
                    .HasColumnType("char(2)");

                entity.Property(e => e.InStatus)
                    .HasColumnName("in_status")
                    .HasColumnType("char(2)");

                entity.Property(e => e.InStatusDate).HasColumnName("in_status_date");

                entity.Property(e => e.InSubtype)
                    .HasColumnName("in_subtype")
                    .HasColumnType("char(3)");

                entity.Property(e => e.InSurveyYn)
                    .HasColumnName("in_survey_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InSystemExpireDate).HasColumnName("in_system_expire_date");

                entity.Property(e => e.InTopography)
                    .HasColumnName("in_topography")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InTotalAssessedValue)
                    .HasColumnName("in_total_assessed_value")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InTotalNumberLots)
                    .HasColumnName("in_total_number_lots")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InTractCode)
                    .HasColumnName("in_tract_code")
                    .HasColumnType("char(4)");

                entity.Property(e => e.InTractName)
                    .HasColumnName("in_tract_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InTransactDate).HasColumnName("in_transact_date");

                entity.Property(e => e.InTransferOfPossession)
                    .HasColumnName("in_transfer_of_possession")
                    .HasColumnType("char(2)");

                entity.Property(e => e.InViewYn)
                    .HasColumnName("in_view_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InVirtualTourLink)
                    .HasColumnName("in_virtual_tour_link")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InWaterDistName)
                    .HasColumnName("in_water_dist_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InWithdrawnDate).HasColumnName("in_withdrawn_date");

                entity.Property(e => e.LastImport)
                    .HasColumnName("last_import")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ListOnInternetYn)
                    .HasColumnName("list_on_internet_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ListingIddYn)
                    .HasColumnName("listing_idd_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.PublishStatus)
                    .HasColumnName("publish_status")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RegMlsCode)
                    .HasColumnName("reg_mls_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ScElementarySchool)
                    .HasColumnName("sc_elementary_school")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScHighSchool)
                    .HasColumnName("sc_high_school")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScJuniorHighSchool)
                    .HasColumnName("sc_junior_high_school")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScSchoolDistrict)
                    .HasColumnName("sc_school_district")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MlsLeaseListings>(entity =>
            {
                entity.HasKey(e => new { e.OrgId, e.ListingId });

                entity.ToTable("mls_lease_listings", "rezoradata");

                entity.HasIndex(e => e.LastImport)
                    .HasName("last_import");

                entity.HasIndex(e => new { e.PublishStatus, e.OrgId })
                    .HasName("idx_publish_status_org_id");

                entity.HasIndex(e => new { e.OrgId, e.AgCoagentId, e.AgId })
                    .HasName("idx_org_id_ag_coagent_id_ag_id");

                entity.HasIndex(e => new { e.OrgId, e.AgId, e.AgCoagentId })
                    .HasName("idx_org_id_ag_id_ag_coagent_id");

                entity.HasIndex(e => new { e.InLatitude, e.InLongitude, e.ListOnInternetYn, e.PublishStatus })
                    .HasName("geocoded");

                entity.Property(e => e.OrgId)
                    .HasColumnName("org_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ListingId)
                    .HasColumnName("listing_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.AdArea)
                    .HasColumnName("ad_area")
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.AdBlockNumber)
                    .HasColumnName("ad_block_number")
                    .HasColumnType("char(4)");

                entity.Property(e => e.AdCityName)
                    .HasColumnName("ad_city_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AdCountyCode)
                    .HasColumnName("ad_county_code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AdCountyFips)
                    .HasColumnName("ad_county_fips")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AdCrossStreets)
                    .HasColumnName("ad_cross_streets")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AdDirections)
                    .HasColumnName("ad_directions")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoCityName)
                    .HasColumnName("ad_geo_city_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoState)
                    .HasColumnName("ad_geo_state")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoStreetDesignator)
                    .HasColumnName("ad_geo_street_designator")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoStreetDirection)
                    .HasColumnName("ad_geo_street_direction")
                    .HasColumnType("char(2)");

                entity.Property(e => e.AdGeoStreetName)
                    .HasColumnName("ad_geo_street_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoStreetNumber)
                    .HasColumnName("ad_geo_street_number")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoStreetPostDir)
                    .HasColumnName("ad_geo_street_post_dir")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoStreetPreType)
                    .HasColumnName("ad_geo_street_pre_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoStreetUnitType)
                    .HasColumnName("ad_geo_street_unit_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoStreetZip4)
                    .HasColumnName("ad_geo_street_zip4")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoUnit)
                    .HasColumnName("ad_geo_unit")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoZipCode)
                    .HasColumnName("ad_geo_zip_code")
                    .HasColumnType("char(5)");

                entity.Property(e => e.AdLotNumber)
                    .HasColumnName("ad_lot_number")
                    .HasColumnType("char(3)");

                entity.Property(e => e.AdMapCode)
                    .HasColumnName("ad_map_code")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AdMapPrecision)
                    .HasColumnName("ad_map_precision")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.AdMarketingArea)
                    .HasColumnName("ad_marketing_area")
                    .HasColumnType("char(4)");

                entity.Property(e => e.AdNeighborhood)
                    .HasColumnName("ad_neighborhood")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AdParcelNumber)
                    .HasColumnName("ad_parcel_number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AdPostalCode)
                    .HasColumnName("ad_postal_code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.AdState)
                    .HasColumnName("ad_state")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.AdStreetDesignator)
                    .HasColumnName("ad_street_designator")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdStreetDirection)
                    .HasColumnName("ad_street_direction")
                    .HasColumnType("char(2)");

                entity.Property(e => e.AdStreetName)
                    .HasColumnName("ad_street_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdStreetNumber)
                    .HasColumnName("ad_street_number")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AdStreetPostDir)
                    .HasColumnName("ad_street_post_dir")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdStreetPreType)
                    .HasColumnName("ad_street_pre_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdStreetUnitType)
                    .HasColumnName("ad_street_unit_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdStreetZip4)
                    .HasColumnName("ad_street_zip4")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdTractNumber)
                    .HasColumnName("ad_tract_number")
                    .HasColumnType("char(5)");

                entity.Property(e => e.AdUnit)
                    .HasColumnName("ad_unit")
                    .HasColumnType("char(8)");

                entity.Property(e => e.AdZipCode)
                    .HasColumnName("ad_zip_code")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AdZoneFeatures)
                    .HasColumnName("ad_zone_features")
                    .HasMaxLength(59)
                    .IsUnicode(false);

                entity.Property(e => e.AgCoagentId)
                    .HasColumnName("ag_coagent_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.AgCoagentName)
                    .HasColumnName("ag_coagent_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgCoagentPhone)
                    .HasColumnName("ag_coagent_phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgEmail)
                    .HasColumnName("ag_email")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.AgFax)
                    .HasColumnName("ag_fax")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgId)
                    .HasColumnName("ag_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.AgMayRepresentSellerAndBuyer)
                    .HasColumnName("ag_may_represent_seller_and_buyer")
                    .HasColumnType("char(2)");

                entity.Property(e => e.AgMobilePhone)
                    .HasColumnName("ag_mobile_phone")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.AgName)
                    .HasColumnName("ag_name")
                    .HasMaxLength(61)
                    .IsUnicode(false);

                entity.Property(e => e.AgOfficeEmail)
                    .HasColumnName("ag_office_email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgOfficeId)
                    .HasColumnName("ag_office_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.AgOfficeName)
                    .HasColumnName("ag_office_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AgOfficePhone)
                    .HasColumnName("ag_office_phone")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.AgPager)
                    .HasColumnName("ag_pager")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgPhone)
                    .HasColumnName("ag_phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgReciprocalLink)
                    .HasColumnName("ag_reciprocal_link")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.AgRemarks)
                    .HasColumnName("ag_remarks")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AgRepresentationFeatures)
                    .HasColumnName("ag_representation_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgVmail)
                    .HasColumnName("ag_vmail")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgWebsite)
                    .HasColumnName("ag_website")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ConApprovalRequirement)
                    .HasColumnName("con_approval_requirement")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConMaintenanceFee)
                    .HasColumnName("con_maintenance_fee")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.ConManagementFeatures)
                    .HasColumnName("con_management_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ConMinimumLease)
                    .HasColumnName("con_minimum_lease")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ConUnitLevel)
                    .HasColumnName("con_unit_level")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayAddressYn)
                    .HasColumnName("display_address_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.DisplayDistressedPropertyYn)
                    .HasColumnName("display_distressed_property_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ExCarportSpaces)
                    .HasColumnName("ex_carport_spaces")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.ExConstructionFeatures)
                    .HasColumnName("ex_construction_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.ExFenceFeatures)
                    .HasColumnName("ex_fence_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.ExFldZoneYn)
                    .HasColumnName("ex_fld_zone_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ExFoundationFeatures)
                    .HasColumnName("ex_foundation_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExGarageFeatures)
                    .HasColumnName("ex_garage_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExGarageRemotes)
                    .HasColumnName("ex_garage_remotes")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.ExGarageSpaces)
                    .HasColumnName("ex_garage_spaces")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.ExGarageType)
                    .HasColumnName("ex_garage_type")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ExGeneralFeatures)
                    .HasColumnName("ex_general_features")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExGolfFeatures)
                    .HasColumnName("ex_golf_features")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExHorsePropertyFeatures)
                    .HasColumnName("ex_horse_property_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.ExLocationFeatures)
                    .HasColumnName("ex_location_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.ExLotSizeAcres)
                    .HasColumnName("ex_lot_size_acres")
                    .HasColumnType("decimal(10,4)");

                entity.Property(e => e.ExLotSizeDimensions)
                    .HasColumnName("ex_lot_size_dimensions")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExLotSizeFeatures)
                    .HasColumnName("ex_lot_size_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.ExLotSizeSource)
                    .HasColumnName("ex_lot_size_source")
                    .HasColumnType("char(2)");

                entity.Property(e => e.ExLotSizeSquareFeet)
                    .HasColumnName("ex_lot_size_square_feet")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ExLotsizeRange)
                    .HasColumnName("ex_lotsize_range")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExParkingFeatures)
                    .HasColumnName("ex_parking_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExParkingSpaces)
                    .HasColumnName("ex_parking_spaces")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.ExParkingSpacesTotal)
                    .HasColumnName("ex_parking_spaces_total")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.ExPatioDimensions)
                    .HasColumnName("ex_patio_dimensions")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ExPatioFeatures)
                    .HasColumnName("ex_patio_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExPatioYn)
                    .HasColumnName("ex_patio_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ExPoolFeatures)
                    .HasColumnName("ex_pool_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExPoolYn)
                    .HasColumnName("ex_pool_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ExRoadFeatures)
                    .HasColumnName("ex_road_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExRoofFeatures)
                    .HasColumnName("ex_roof_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExRvParkingDimensions)
                    .HasColumnName("ex_rv_parking_dimensions")
                    .HasColumnType("char(6)");

                entity.Property(e => e.ExSewerFeatures)
                    .HasColumnName("ex_sewer_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.ExSolarFeatures)
                    .HasColumnName("ex_solar_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.ExSpaFeatures)
                    .HasColumnName("ex_spa_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExSpaYn)
                    .HasColumnName("ex_spa_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ExSprinklerFeatures)
                    .HasColumnName("ex_sprinkler_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.ExStyle)
                    .HasColumnName("ex_style")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ExStyleFeatures)
                    .HasColumnName("ex_style_features")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExSubdivisionFeatures)
                    .HasColumnName("ex_subdivision_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExViewFeatures)
                    .HasColumnName("ex_view_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.ExWateraccessFeatures)
                    .HasColumnName("ex_wateraccess_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExWaterfrontFeatures)
                    .HasColumnName("ex_waterfront_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExWaterstructuresFeatures)
                    .HasColumnName("ex_waterstructures_features")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FiAdditionalFinanceInfo)
                    .HasColumnName("fi_additional_finance_Info")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FiCompTrigger)
                    .HasColumnName("fi_comp_trigger")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FiFinanceFeatures)
                    .HasColumnName("fi_finance_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FiFinanceSponsor)
                    .HasColumnName("fi_finance_sponsor")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FiFinanceTerms)
                    .HasColumnName("fi_finance_terms")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FiFirstTrustDeedAmount)
                    .HasColumnName("fi_first_trust_deed_amount")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiFirstTrustDeedAssumable)
                    .HasColumnName("fi_first_trust_deed_assumable")
                    .HasColumnType("char(1)");

                entity.Property(e => e.FiFirstTrustDeedDue).HasColumnName("fi_first_trust_deed_due");

                entity.Property(e => e.FiFirstTrustDeedFee)
                    .HasColumnName("fi_first_trust_deed_fee")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiFirstTrustDeedInterest)
                    .HasColumnName("fi_first_trust_deed_interest")
                    .HasColumnType("decimal(5,3)");

                entity.Property(e => e.FiFirstTrustDeedLender)
                    .HasColumnName("fi_first_trust_deed_lender")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FiFirstTrustDeedRate)
                    .HasColumnName("fi_first_trust_deed_rate")
                    .HasColumnType("char(2)");

                entity.Property(e => e.FiFirstTrustDeedType)
                    .HasColumnName("fi_first_trust_deed_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.FiGrossEquity)
                    .HasColumnName("fi_gross_equity")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiIgnoreCompTrigger)
                    .HasColumnName("fi_ignore_comp_trigger")
                    .HasColumnType("char(1)");

                entity.Property(e => e.FiIgnorePaidYn)
                    .HasColumnName("fi_ignore_paid_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.FiPossession)
                    .HasColumnName("fi_possession")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FiSecondTrustDeedAmount)
                    .HasColumnName("fi_second_trust_deed_amount")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiSecondTrustDeedAssumable)
                    .HasColumnName("fi_second_trust_deed_assumable")
                    .HasColumnType("char(1)");

                entity.Property(e => e.FiSecondTrustDeedDue).HasColumnName("fi_second_trust_deed_due");

                entity.Property(e => e.FiSecondTrustDeedFee)
                    .HasColumnName("fi_second_trust_deed_fee")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiSecondTrustDeedInterest)
                    .HasColumnName("fi_second_trust_deed_interest")
                    .HasColumnType("decimal(5,3)");

                entity.Property(e => e.FiSecondTrustDeedLender)
                    .HasColumnName("fi_second_trust_deed_lender")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FiSecondTrustDeedRate)
                    .HasColumnName("fi_second_trust_deed_rate")
                    .HasColumnType("char(2)");

                entity.Property(e => e.FiSecondTrustDeedType)
                    .HasColumnName("fi_second_trust_deed_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.FiTaxAmount)
                    .HasColumnName("fi_tax_amount")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiTaxDescriptionFeatures)
                    .HasColumnName("fi_tax_description_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FiTaxPeriod)
                    .HasColumnName("fi_tax_period")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.FiTotalTaxRate)
                    .HasColumnName("fi_total_tax_rate")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.IfApplianceFeatures)
                    .HasColumnName("if_appliance_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IfBasementFeatures)
                    .HasColumnName("if_basement_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IfCoolingFeatures)
                    .HasColumnName("if_cooling_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IfCoolingYn)
                    .HasColumnName("if_cooling_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.IfEnergyFeatures)
                    .HasColumnName("if_energy_features")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.IfFireplaceFeatures)
                    .HasColumnName("if_fireplace_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IfFireplaceNumber)
                    .HasColumnName("if_fireplace_number")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.IfFireplaceYn)
                    .HasColumnName("if_fireplace_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.IfFloorFeatures)
                    .HasColumnName("if_floor_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IfGeneralFeatures)
                    .HasColumnName("if_general_features")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IfHeatingFeatures)
                    .HasColumnName("if_heating_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IfLevels)
                    .HasColumnName("if_levels")
                    .HasColumnType("char(2)");

                entity.Property(e => e.IfLevelsFeatures)
                    .HasColumnName("if_levels_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.IfNumberCeilingFans)
                    .HasColumnName("if_number_ceiling_fans")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.IfPetFeatures)
                    .HasColumnName("if_pet_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IfPlumbingFeatures)
                    .HasColumnName("if_plumbing_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.IfSecurityFeatures)
                    .HasColumnName("if_security_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.IfSecuritySystemYn)
                    .HasColumnName("if_security_system_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.IfSpecialFeatures)
                    .HasColumnName("if_special_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IfUtilitiesFeatures)
                    .HasColumnName("if_utilities_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.IfWaterFeatures)
                    .HasColumnName("if_water_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.IfWindowFeatures)
                    .HasColumnName("if_window_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.InAdditionalPicturesYn)
                    .IsRequired()
                    .HasColumnName("in_additional_pictures_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InAdditionsAlterYn)
                    .HasColumnName("in_additions_alter_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InAdom)
                    .HasColumnName("in_adom")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InAgeFeatures)
                    .HasColumnName("in_age_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InApNumber)
                    .HasColumnName("in_ap_number")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.InAssociationDues1)
                    .HasColumnName("in_association_dues1")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InAssociationDues2)
                    .HasColumnName("in_association_dues2")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InAssociationFeatures)
                    .HasColumnName("in_association_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InAssociationLitigationYn)
                    .HasColumnName("in_association_litigation_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InAssociationPeriod)
                    .HasColumnName("in_association_period")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.InAssociationPhone)
                    .HasColumnName("in_association_phone")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.InAssociationYn)
                    .HasColumnName("in_association_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InBuilderName)
                    .HasColumnName("in_builder_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InCloseDate).HasColumnName("in_close_date");

                entity.Property(e => e.InCompensationBuyAgent)
                    .HasColumnName("in_compensation_buy_agent")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.InCompensationNonrep)
                    .HasColumnName("in_compensation_nonrep")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.InCompensationTransactionAgent)
                    .HasColumnName("in_compensation_transaction_agent")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.InDetailUrl)
                    .HasColumnName("in_detail_url")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.InDistressType)
                    .HasColumnName("in_distress_type")
                    .HasMaxLength(59)
                    .IsUnicode(false);

                entity.Property(e => e.InEscrowDate).HasColumnName("in_escrow_date");

                entity.Property(e => e.InExclusions)
                    .HasColumnName("in_exclusions")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InImageCount)
                    .HasColumnName("in_image_count")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.InIsAttached)
                    .HasColumnName("in_is_attached")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InKeyboxFeatures)
                    .HasColumnName("in_keybox_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.InKeyboxLocation)
                    .HasColumnName("in_keybox_location")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InLastTransactionCode)
                    .HasColumnName("in_last_transaction_code")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InLatitude).HasColumnName("in_latitude");

                entity.Property(e => e.InLeaseAmount)
                    .HasColumnName("in_lease_amount")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InLeaseOptionYn)
                    .HasColumnName("in_lease_option_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InLeasePeriod)
                    .HasColumnName("in_lease_period")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.InLeaseTerm)
                    .HasColumnName("in_lease_term")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.InLegalDescription)
                    .HasColumnName("in_legal_description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InLegalFeatures)
                    .HasColumnName("in_legal_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InListDate).HasColumnName("in_list_date");

                entity.Property(e => e.InListPrice)
                    .HasColumnName("in_list_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InListPriceExclusionRemarks)
                    .HasColumnName("in_list_price_exclusion_remarks")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.InListingAgreementType)
                    .HasColumnName("in_listing_agreement_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.InListingHasForSaleSignYn)
                    .HasColumnName("in_listing_has_for_sale_sign_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InListingLoadedByBroker)
                    .HasColumnName("in_listing_loaded_by_broker")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.InLivingSquareFeet)
                    .HasColumnName("in_living_square_feet")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InLoadDate).HasColumnName("in_load_date");

                entity.Property(e => e.InLongitude).HasColumnName("in_longitude");

                entity.Property(e => e.InModelName)
                    .HasColumnName("in_model_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InModifyDate).HasColumnName("in_modify_date");

                entity.Property(e => e.InOffmarketDate).HasColumnName("in_offmarket_date");

                entity.Property(e => e.InOrigListPrice)
                    .HasColumnName("in_orig_list_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InOwnerName)
                    .HasColumnName("in_owner_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InOwnerPhone)
                    .HasColumnName("in_owner_phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InPendingDate).HasColumnName("in_pending_date");

                entity.Property(e => e.InPendingPrice)
                    .HasColumnName("in_pending_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InPreviousListPrice)
                    .HasColumnName("in_previous_list_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InPreviousStatus)
                    .HasColumnName("in_previous_status")
                    .HasColumnType("char(2)");

                entity.Property(e => e.InProjectedEscrowCloseDate).HasColumnName("in_projected_escrow_close_date");

                entity.Property(e => e.InPropertyType)
                    .HasColumnName("in_property_type")
                    .HasColumnType("char(3)");

                entity.Property(e => e.InPublicRemarks)
                    .HasColumnName("in_public_remarks")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.InPullDate).HasColumnName("in_pull_date");

                entity.Property(e => e.InRangeHighLivingSquareFeet)
                    .HasColumnName("in_range_high_living_square_feet")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InRangeHighPrice)
                    .HasColumnName("in_range_high_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InRangeLowLivingSquareFeet)
                    .HasColumnName("in_range_low_living_square_feet")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InRangeLowPrice)
                    .HasColumnName("in_range_low_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InRangePriceFlag)
                    .HasColumnName("in_range_price_flag")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InReciprocalListing)
                    .HasColumnName("in_reciprocal_listing")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InRemodeledDate).HasColumnName("in_remodeled_date");

                entity.Property(e => e.InRestrictions)
                    .HasColumnName("in_restrictions")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InSellerAgreesToPayPoints)
                    .HasColumnName("in_seller_agrees_to_pay_points")
                    .HasColumnType("char(4)");

                entity.Property(e => e.InSellingOfficeComp)
                    .HasColumnName("in_selling_office_comp")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.InSellingOfficeCompType)
                    .HasColumnName("in_selling_office_comp_type")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InSellingOfficeCompensation)
                    .HasColumnName("in_selling_office_compensation")
                    .HasColumnType("char(4)");

                entity.Property(e => e.InShowingInstructions)
                    .HasColumnName("in_showing_instructions")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.InSoldAgentName)
                    .HasColumnName("in_sold_agent_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InSoldAgentOfficeId)
                    .HasColumnName("in_sold_agent_office_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.InSoldAgentPublicId)
                    .HasColumnName("in_sold_agent_public_id")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.InSoldDate).HasColumnName("in_sold_date");

                entity.Property(e => e.InSoldFinanceTerms)
                    .HasColumnName("in_sold_finance_terms")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InSoldOfficeName)
                    .HasColumnName("in_sold_office_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InSoldPrice)
                    .HasColumnName("in_sold_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InSoldTerms)
                    .HasColumnName("in_sold_terms")
                    .HasColumnType("char(2)");

                entity.Property(e => e.InStatus)
                    .HasColumnName("in_status")
                    .HasColumnType("char(2)");

                entity.Property(e => e.InStatusDate).HasColumnName("in_status_date");

                entity.Property(e => e.InSubtype)
                    .HasColumnName("in_subtype")
                    .HasColumnType("char(3)");

                entity.Property(e => e.InSystemExpireDate).HasColumnName("in_system_expire_date");

                entity.Property(e => e.InTotalAssessedValue)
                    .HasColumnName("in_total_assessed_value")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InTotalUnitsInComplex)
                    .HasColumnName("in_total_units_in_complex")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.InTractCode)
                    .HasColumnName("in_tract_code")
                    .HasColumnType("char(4)");

                entity.Property(e => e.InTractName)
                    .HasColumnName("in_tract_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InTransactDate).HasColumnName("in_transact_date");

                entity.Property(e => e.InTransferOfPossession)
                    .HasColumnName("in_transfer_of_possession")
                    .HasColumnType("char(2)");

                entity.Property(e => e.InViewYn)
                    .HasColumnName("in_view_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InVirtualTourLink)
                    .HasColumnName("in_virtual_tour_link")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InVolt220OutletLocation)
                    .HasColumnName("in_volt220_outlet_location")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InWithdrawnDate).HasColumnName("in_withdrawn_date");

                entity.Property(e => e.InYearBuilt)
                    .HasColumnName("in_year_built")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.LastImport)
                    .HasColumnName("last_import")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.LeAssociationDuesIncYn)
                    .HasColumnName("le_association_dues_inc_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.LeCableIncYn)
                    .HasColumnName("le_cable_inc_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.LeElectricIncYn)
                    .HasColumnName("le_electric_inc_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.LeFurnishedYn)
                    .HasColumnName("le_furnished_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.LeGardnerIncYn)
                    .HasColumnName("le_gardner_inc_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.LeGasIncYn)
                    .HasColumnName("le_gas_inc_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.LeMaidIncYn)
                    .HasColumnName("le_maid_inc_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.LeMoToMoYn)
                    .HasColumnName("le_mo_to_mo_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.LePetsYn)
                    .HasColumnName("le_pets_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.LePoolIncYn)
                    .HasColumnName("le_pool_inc_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.LeTrashIncYn)
                    .HasColumnName("le_trash_inc_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.LeWaterIncYn)
                    .HasColumnName("le_water_inc_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ListOnInternetYn)
                    .HasColumnName("list_on_internet_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ListingIddYn)
                    .HasColumnName("listing_idd_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.PublishStatus)
                    .HasColumnName("publish_status")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RegMlsCode)
                    .HasColumnName("reg_mls_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmBathroomFeatures)
                    .HasColumnName("rm_bathroom_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RmBathsFull)
                    .HasColumnName("rm_baths_full")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.RmBathsHalf)
                    .HasColumnName("rm_baths_half")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.RmBathsQuarter)
                    .HasColumnName("rm_baths_quarter")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.RmBathsThreeQuarter)
                    .HasColumnName("rm_baths_three_quarter")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.RmBathsTotal)
                    .HasColumnName("rm_baths_total")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.RmBedroomFeatures)
                    .HasColumnName("rm_bedroom_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RmBedroomsTotal)
                    .HasColumnName("rm_bedrooms_total")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.RmBonusFeatures)
                    .HasColumnName("rm_bonus_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RmBonusYn)
                    .HasColumnName("rm_bonus_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.RmConvertedBedroomYn)
                    .HasColumnName("rm_converted_bedroom_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.RmDenYn)
                    .HasColumnName("rm_den_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.RmDiningFeatures)
                    .HasColumnName("rm_dining_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RmFamilyYn)
                    .HasColumnName("rm_family_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.RmFormalDiningYn)
                    .HasColumnName("rm_formal_dining_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.RmGeneralFeatures)
                    .HasColumnName("rm_general_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RmKitchenFeatures)
                    .HasColumnName("rm_kitchen_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RmLaundryFeatures)
                    .HasColumnName("rm_laundry_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RmLivingFeatures)
                    .HasColumnName("rm_living_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RmLivingYn)
                    .HasColumnName("rm_living_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.RmMasterDressingAreaYn)
                    .HasColumnName("rm_master_dressing_area_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.RmMasterYn)
                    .HasColumnName("rm_master_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.RmRoom10Dimensions1)
                    .HasColumnName("rm_room10_dimensions1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom10Dimensions2)
                    .HasColumnName("rm_room10_dimensions2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom10Features)
                    .HasColumnName("rm_room10_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom10Type)
                    .HasColumnName("rm_room10_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.RmRoom11Dimensions1)
                    .HasColumnName("rm_room11_dimensions1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom11Dimensions2)
                    .HasColumnName("rm_room11_dimensions2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom11Features)
                    .HasColumnName("rm_room11_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom11Type)
                    .HasColumnName("rm_room11_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.RmRoom12Dimensions1)
                    .HasColumnName("rm_room12_dimensions1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom12Dimensions2)
                    .HasColumnName("rm_room12_dimensions2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom12Features)
                    .HasColumnName("rm_room12_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom12Type)
                    .HasColumnName("rm_room12_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.RmRoom13Dimensions1)
                    .HasColumnName("rm_room13_dimensions1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom13Dimensions2)
                    .HasColumnName("rm_room13_dimensions2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom13Features)
                    .HasColumnName("rm_room13_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom13Type)
                    .HasColumnName("rm_room13_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.RmRoom14Dimensions1)
                    .HasColumnName("rm_room14_dimensions1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom14Dimensions2)
                    .HasColumnName("rm_room14_dimensions2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom14Features)
                    .HasColumnName("rm_room14_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom14Type)
                    .HasColumnName("rm_room14_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.RmRoom1Dimensions1)
                    .HasColumnName("rm_room1_dimensions1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom1Dimensions2)
                    .HasColumnName("rm_room1_dimensions2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom1Features)
                    .HasColumnName("rm_room1_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom1Type)
                    .HasColumnName("rm_room1_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.RmRoom2Dimensions1)
                    .HasColumnName("rm_room2_dimensions1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom2Dimensions2)
                    .HasColumnName("rm_room2_dimensions2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom2Features)
                    .HasColumnName("rm_room2_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom2Type)
                    .HasColumnName("rm_room2_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.RmRoom3Dimensions1)
                    .HasColumnName("rm_room3_dimensions1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom3Dimensions2)
                    .HasColumnName("rm_room3_dimensions2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom3Features)
                    .HasColumnName("rm_room3_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom3Type)
                    .HasColumnName("rm_room3_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.RmRoom4Dimensions1)
                    .HasColumnName("rm_room4_dimensions1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom4Dimensions2)
                    .HasColumnName("rm_room4_dimensions2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom4Features)
                    .HasColumnName("rm_room4_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom4Type)
                    .HasColumnName("rm_room4_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.RmRoom5Dimensions1)
                    .HasColumnName("rm_room5_dimensions1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom5Dimensions2)
                    .HasColumnName("rm_room5_dimensions2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom5Features)
                    .HasColumnName("rm_room5_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom5Type)
                    .HasColumnName("rm_room5_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.RmRoom6Dimensions1)
                    .HasColumnName("rm_room6_dimensions1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom6Dimensions2)
                    .HasColumnName("rm_room6_dimensions2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom6Features)
                    .HasColumnName("rm_room6_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom6Type)
                    .HasColumnName("rm_room6_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.RmRoom7Dimensions1)
                    .HasColumnName("rm_room7_dimensions1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom7Dimensions2)
                    .HasColumnName("rm_room7_dimensions2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom7Features)
                    .HasColumnName("rm_room7_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom7Type)
                    .HasColumnName("rm_room7_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.RmRoom8Dimensions1)
                    .HasColumnName("rm_room8_dimensions1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom8Dimensions2)
                    .HasColumnName("rm_room8_dimensions2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom8Features)
                    .HasColumnName("rm_room8_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom8Type)
                    .HasColumnName("rm_room8_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.RmRoom9Dimensions1)
                    .HasColumnName("rm_room9_dimensions1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom9Dimensions2)
                    .HasColumnName("rm_room9_dimensions2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom9Features)
                    .HasColumnName("rm_room9_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom9Type)
                    .HasColumnName("rm_room9_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.RmRoomsTotal)
                    .HasColumnName("rm_rooms_total")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RmTermiteClearYn)
                    .HasColumnName("rm_termite_clear_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.RmUtilityFeatures)
                    .HasColumnName("rm_utility_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RmWalkInClosets)
                    .HasColumnName("rm_walk_in_closets")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.ScElementarySchool)
                    .HasColumnName("sc_elementary_school")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScHighSchool)
                    .HasColumnName("sc_high_school")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScJuniorHighSchool)
                    .HasColumnName("sc_junior_high_school")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScSchoolDistrict)
                    .HasColumnName("sc_school_district")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MlsLegal>(entity =>
            {
                entity.HasKey(e => e.LegalId);

                entity.ToTable("mls_legal", "rezoradata");

                entity.HasIndex(e => e.LegalPriority)
                    .HasName("legal_priority");

                entity.HasIndex(e => e.OrgId)
                    .HasName("org_id");

                entity.Property(e => e.LegalId)
                    .HasColumnName("legal_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LegalImagePath)
                    .IsRequired()
                    .HasColumnName("legal_image_path")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LegalPriority)
                    .HasColumnName("legal_priority")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LegalText)
                    .IsRequired()
                    .HasColumnName("legal_text")
                    .IsUnicode(false);

                entity.Property(e => e.OrgId)
                    .IsRequired()
                    .HasColumnName("org_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MlsListingTypes>(entity =>
            {
                entity.HasKey(e => e.ListingTypeId);

                entity.ToTable("mls_listing_types", "rezoradata");

                entity.Property(e => e.ListingTypeId)
                    .HasColumnName("listing_type_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ListingTypeTitle)
                    .IsRequired()
                    .HasColumnName("listing_type_title")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasColumnName("table_name")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MlsMedia>(entity =>
            {
                entity.HasKey(e => e.MediaId);

                entity.ToTable("mls_media", "rezoradata");

                entity.HasIndex(e => e.LastProcessed)
                    .HasName("last_processed");

                entity.HasIndex(e => e.PublishStatus)
                    .HasName("publish_status");

                entity.HasIndex(e => new { e.OrgId, e.ListingId, e.MediaFormat })
                    .HasName("org_id");

                entity.Property(e => e.MediaId)
                    .HasColumnName("media_id")
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.LastProcessed)
                    .HasColumnName("last_processed")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ListingId)
                    .IsRequired()
                    .HasColumnName("listing_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.MediaFormat)
                    .IsRequired()
                    .HasColumnName("media_format")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MediaOrder)
                    .HasColumnName("media_order")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MediaType)
                    .IsRequired()
                    .HasColumnName("media_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MediaUrl)
                    .IsRequired()
                    .HasColumnName("media_url")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrgId)
                    .IsRequired()
                    .HasColumnName("org_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PublishStatus)
                    .HasColumnName("publish_status")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<MlsMeta0>(entity =>
            {
                entity.HasKey(e => new { e.OrgId, e.ListingId, e.Key });

                entity.ToTable("mls_meta_0", "rezoradata");

                entity.HasIndex(e => new { e.OrgId, e.ListingId })
                    .HasName("org_listing");

                entity.Property(e => e.OrgId)
                    .HasColumnName("org_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ListingId)
                    .HasColumnName("listing_id")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MlsMeta1>(entity =>
            {
                entity.HasKey(e => new { e.OrgId, e.ListingId, e.Key });

                entity.ToTable("mls_meta_1", "rezoradata");

                entity.HasIndex(e => new { e.OrgId, e.ListingId })
                    .HasName("org_listing");

                entity.Property(e => e.OrgId)
                    .HasColumnName("org_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ListingId)
                    .HasColumnName("listing_id")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MlsMeta2>(entity =>
            {
                entity.HasKey(e => new { e.OrgId, e.ListingId, e.Key });

                entity.ToTable("mls_meta_2", "rezoradata");

                entity.HasIndex(e => new { e.OrgId, e.ListingId })
                    .HasName("org_listing");

                entity.Property(e => e.OrgId)
                    .HasColumnName("org_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ListingId)
                    .HasColumnName("listing_id")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MlsOffices>(entity =>
            {
                entity.HasKey(e => new { e.OrgId, e.AgOfficeId });

                entity.ToTable("mls_offices", "rezoradata");

                entity.HasIndex(e => e.LastImport)
                    .HasName("last_import");

                entity.HasIndex(e => new { e.LastImport, e.OrgId })
                    .HasName("updatefilter");

                entity.Property(e => e.OrgId)
                    .HasColumnName("org_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AgOfficeId)
                    .HasColumnName("ag_office_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.AdAddress)
                    .HasColumnName("ad_address")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdCityName)
                    .HasColumnName("ad_city_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdState)
                    .HasColumnName("ad_state")
                    .HasColumnType("char(2)");

                entity.Property(e => e.AdZipCode)
                    .HasColumnName("ad_zip_code")
                    .HasColumnType("char(5)");

                entity.Property(e => e.AgOfficeContactPerson)
                    .HasColumnName("ag_office_contact_person")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AgOfficeEmail)
                    .HasColumnName("ag_office_email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AgOfficeName)
                    .IsRequired()
                    .HasColumnName("ag_office_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AgOfficePhone)
                    .HasColumnName("ag_office_phone")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.AgOfficePhoneFax)
                    .HasColumnName("ag_office_phone_fax")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.AgOfficeStatus)
                    .HasColumnName("ag_office_status")
                    .HasColumnType("char(1)");

                entity.Property(e => e.AgOfficeType)
                    .HasColumnName("ag_office_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgOfficeWebsite)
                    .HasColumnName("ag_office_website")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IddAccessYn)
                    .HasColumnName("idd_access_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.IddParticipateYn)
                    .HasColumnName("idd_participate_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InLoadDate).HasColumnName("in_load_date");

                entity.Property(e => e.InTransactDate).HasColumnName("in_transact_date");

                entity.Property(e => e.LastImport)
                    .HasColumnName("last_import")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.PublishStatus)
                    .HasColumnName("publish_status")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<MlsOrganizations>(entity =>
            {
                entity.HasKey(e => e.MlsId);

                entity.ToTable("mls_organizations", "rezoradata");

                entity.HasIndex(e => e.OrgId)
                    .HasName("org_id");

                entity.Property(e => e.MlsId)
                    .HasColumnName("mls_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DisplayListingAgent)
                    .HasColumnName("display_listing_agent")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.HiresImages)
                    .HasColumnName("hires_images")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Isactive)
                    .HasColumnName("isactive")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.MlsName)
                    .IsRequired()
                    .HasColumnName("mls_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MlsNameDisplay)
                    .IsRequired()
                    .HasColumnName("mls_name_display")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MlsTimestamp)
                    .HasColumnName("mls_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.OrgId)
                    .IsRequired()
                    .HasColumnName("org_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MlsPhotos>(entity =>
            {
                entity.HasKey(e => new { e.OrgId, e.ListingId, e.FileName });

                entity.ToTable("mls_photos", "rezoradata");

                entity.HasIndex(e => e.LastImport)
                    .HasName("last_import");

                entity.HasIndex(e => e.OrgId)
                    .HasName("org_id");

                entity.HasIndex(e => e.PublishStatus)
                    .HasName("publish_status");

                entity.HasIndex(e => new { e.OrgId, e.PublishStatus })
                    .HasName("org_id_2");

                entity.Property(e => e.OrgId)
                    .HasColumnName("org_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ListingId)
                    .HasColumnName("listing_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .HasColumnName("file_name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FileDate).HasColumnName("file_date");

                entity.Property(e => e.FileOrder)
                    .HasColumnName("file_order")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.LastImport)
                    .HasColumnName("last_import")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.PublishStatus)
                    .HasColumnName("publish_status")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<MlsPrivateListings>(entity =>
            {
                entity.HasKey(e => new { e.OrgId, e.ListingId });

                entity.ToTable("mls_private_listings", "rezoradata");

                entity.HasIndex(e => e.AgId)
                    .HasName("ag_id");

                entity.HasIndex(e => e.InListPrice)
                    .HasName("in_list_price");

                entity.HasIndex(e => e.OrgId)
                    .HasName("org_id");

                entity.HasIndex(e => e.PublishStatus)
                    .HasName("publish_status");

                entity.HasIndex(e => e.RmBathsTotal)
                    .HasName("rm_baths_total");

                entity.HasIndex(e => e.RmBedroomsTotal)
                    .HasName("rm_bedrooms_total");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.HasIndex(e => new { e.OrgId, e.AgId })
                    .HasName("org_id_2");

                entity.HasIndex(e => new { e.OrgId, e.PublishStatus })
                    .HasName("org_id_3");

                entity.HasIndex(e => new { e.PublishStatus, e.AgId, e.AgCoagentId })
                    .HasName("ag_coagent_id");

                entity.Property(e => e.OrgId)
                    .HasColumnName("org_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("private");

                entity.Property(e => e.ListingId)
                    .HasColumnName("listing_id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AdCityName)
                    .HasColumnName("ad_city_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AdCountyCode)
                    .HasColumnName("ad_county_code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AdNeighborhood)
                    .HasColumnName("ad_neighborhood")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AdState)
                    .HasColumnName("ad_state")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.AdStreetDesignator)
                    .HasColumnName("ad_street_designator")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdStreetDirection)
                    .HasColumnName("ad_street_direction")
                    .HasColumnType("char(2)");

                entity.Property(e => e.AdStreetName)
                    .HasColumnName("ad_street_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdStreetNumber)
                    .HasColumnName("ad_street_number")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AdStreetPostDir)
                    .HasColumnName("ad_street_post_dir")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdUnit)
                    .HasColumnName("ad_unit")
                    .HasColumnType("char(8)");

                entity.Property(e => e.AdZipCode)
                    .HasColumnName("ad_zip_code")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AgCoagentId)
                    .HasColumnName("ag_coagent_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.AgCoagentName)
                    .IsRequired()
                    .HasColumnName("ag_coagent_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgCoagentPhone)
                    .IsRequired()
                    .HasColumnName("ag_coagent_phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgEmail)
                    .HasColumnName("ag_email")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.AgId)
                    .HasColumnName("ag_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.AgMobilePhone)
                    .HasColumnName("ag_mobile_phone")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.AgName)
                    .HasColumnName("ag_name")
                    .HasMaxLength(61)
                    .IsUnicode(false);

                entity.Property(e => e.AgOfficeId)
                    .HasColumnName("ag_office_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.AgOfficeName)
                    .HasColumnName("ag_office_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AgOfficePhone)
                    .HasColumnName("ag_office_phone")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.AgPhone)
                    .HasColumnName("ag_phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgReciprocalLink)
                    .HasColumnName("ag_reciprocal_link")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayAddressYn)
                    .HasColumnName("display_address_yn")
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("Y");

                entity.Property(e => e.ExLotSizeAcres)
                    .HasColumnName("ex_lot_size_acres")
                    .HasColumnType("decimal(10,4)");

                entity.Property(e => e.ExLotSizeSquareFeet)
                    .HasColumnName("ex_lot_size_square_feet")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FiTaxAmount)
                    .HasColumnName("fi_tax_amount")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InDetailUrl)
                    .HasColumnName("in_detail_url")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.InImageCount)
                    .HasColumnName("in_image_count")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.InLatitude).HasColumnName("in_latitude");

                entity.Property(e => e.InListPrice)
                    .HasColumnName("in_list_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InLivingSquareFeet)
                    .HasColumnName("in_living_square_feet")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InLongitude).HasColumnName("in_longitude");

                entity.Property(e => e.InPublicRemarks)
                    .HasColumnName("in_public_remarks")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.InSoldPrice)
                    .HasColumnName("in_sold_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InStatus)
                    .HasColumnName("in_status")
                    .HasColumnType("char(2)");

                entity.Property(e => e.InVirtualTourLink)
                    .HasColumnName("in_virtual_tour_link")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InYearBuilt)
                    .HasColumnName("in_year_built")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ListOnInternetYn)
                    .HasColumnName("list_on_internet_yn")
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("Y");

                entity.Property(e => e.PoTourId)
                    .HasColumnName("po_tour_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PublishStatus)
                    .HasColumnName("publish_status")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.RmBathsFull)
                    .HasColumnName("rm_baths_full")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.RmBathsHalf)
                    .HasColumnName("rm_baths_half")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.RmBathsQuarter)
                    .HasColumnName("rm_baths_quarter")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.RmBathsThreeQuarter)
                    .HasColumnName("rm_baths_three_quarter")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.RmBathsTotal)
                    .HasColumnName("rm_baths_total")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.RmBedroomsTotal)
                    .HasColumnName("rm_bedrooms_total")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.ScElementarySchool)
                    .HasColumnName("sc_elementary_school")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScHighSchool)
                    .HasColumnName("sc_high_school")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScJuniorHighSchool)
                    .HasColumnName("sc_junior_high_school")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScSchoolDistrict)
                    .HasColumnName("sc_school_district")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<MlsResListings>(entity =>
            {
                entity.HasKey(e => new { e.OrgId, e.ListingId });

                entity.ToTable("mls_res_listings", "rezoradata");

                entity.HasIndex(e => e.AgId)
                    .HasName("ag_id");

                entity.HasIndex(e => e.AgOfficeId)
                    .HasName("ag_office_id");

                entity.HasIndex(e => e.InListPrice)
                    .HasName("in_list_price");

                entity.HasIndex(e => e.LastImport)
                    .HasName("last_import");

                entity.HasIndex(e => e.OrgId)
                    .HasName("org_id");

                entity.HasIndex(e => e.PublishStatus)
                    .HasName("publish_status");

                entity.HasIndex(e => e.RmBathsFull)
                    .HasName("rm_baths_full");

                entity.HasIndex(e => e.RmBathsHalf)
                    .HasName("rm_baths_half");

                entity.HasIndex(e => e.RmBathsQuarter)
                    .HasName("rm_baths_quarter");

                entity.HasIndex(e => e.RmBathsThreeQuarter)
                    .HasName("rm_baths_three_quarter");

                entity.HasIndex(e => e.RmBathsTotal)
                    .HasName("rm_baths_total");

                entity.HasIndex(e => e.RmBedroomsTotal)
                    .HasName("rm_bedrooms_total");

                entity.HasIndex(e => new { e.LastImport, e.OrgId })
                    .HasName("updatefilter");

                entity.HasIndex(e => new { e.OrgId, e.AgCoagentId })
                    .HasName("idx_org_id_ag_coagent_id");

                entity.HasIndex(e => new { e.OrgId, e.AgId })
                    .HasName("org_id_2");

                entity.HasIndex(e => new { e.OrgId, e.PublishStatus })
                    .HasName("org_id_3");

                entity.HasIndex(e => new { e.PublishStatus, e.AgId, e.AgCoagentId })
                    .HasName("ag_coagent_id");

                entity.HasIndex(e => new { e.InLatitude, e.InLongitude, e.ListOnInternetYn, e.PublishStatus })
                    .HasName("geocoded");

                entity.Property(e => e.OrgId)
                    .HasColumnName("org_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ListingId)
                    .HasColumnName("listing_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.AdArea)
                    .HasColumnName("ad_area")
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.AdBlockNumber)
                    .HasColumnName("ad_block_number")
                    .HasColumnType("char(4)");

                entity.Property(e => e.AdCityName)
                    .HasColumnName("ad_city_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AdCountyCode)
                    .HasColumnName("ad_county_code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AdCountyFips)
                    .HasColumnName("ad_county_fips")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AdCrossStreets)
                    .HasColumnName("ad_cross_streets")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AdDirections)
                    .HasColumnName("ad_directions")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoCityName)
                    .HasColumnName("ad_geo_city_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoState)
                    .HasColumnName("ad_geo_state")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoStreetDesignator)
                    .HasColumnName("ad_geo_street_designator")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoStreetDirection)
                    .HasColumnName("ad_geo_street_direction")
                    .HasColumnType("char(2)");

                entity.Property(e => e.AdGeoStreetName)
                    .HasColumnName("ad_geo_street_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoStreetNumber)
                    .HasColumnName("ad_geo_street_number")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoStreetPostDir)
                    .HasColumnName("ad_geo_street_post_dir")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoStreetPreType)
                    .HasColumnName("ad_geo_street_pre_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoStreetUnitType)
                    .HasColumnName("ad_geo_street_unit_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoStreetZip4)
                    .HasColumnName("ad_geo_street_zip4")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoUnit)
                    .HasColumnName("ad_geo_unit")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.AdGeoZipCode)
                    .HasColumnName("ad_geo_zip_code")
                    .HasColumnType("char(5)");

                entity.Property(e => e.AdLotNumber)
                    .HasColumnName("ad_lot_number")
                    .HasColumnType("char(3)");

                entity.Property(e => e.AdMapCode)
                    .HasColumnName("ad_map_code")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AdMapPrecision)
                    .HasColumnName("ad_map_precision")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.AdMarketingArea)
                    .HasColumnName("ad_marketing_area")
                    .HasColumnType("char(4)");

                entity.Property(e => e.AdNeighborhood)
                    .HasColumnName("ad_neighborhood")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AdParcelNumber)
                    .HasColumnName("ad_parcel_number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AdPostalCode)
                    .HasColumnName("ad_postal_code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.AdState)
                    .HasColumnName("ad_state")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.AdStreetDesignator)
                    .HasColumnName("ad_street_designator")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdStreetDirection)
                    .HasColumnName("ad_street_direction")
                    .HasColumnType("char(2)");

                entity.Property(e => e.AdStreetName)
                    .HasColumnName("ad_street_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdStreetNumber)
                    .HasColumnName("ad_street_number")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AdStreetPostDir)
                    .HasColumnName("ad_street_post_dir")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdStreetPreType)
                    .HasColumnName("ad_street_pre_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdStreetUnitType)
                    .HasColumnName("ad_street_unit_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdStreetZip4)
                    .HasColumnName("ad_street_zip4")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdTractNumber)
                    .HasColumnName("ad_tract_number")
                    .HasColumnType("char(5)");

                entity.Property(e => e.AdUnit)
                    .HasColumnName("ad_unit")
                    .HasColumnType("char(8)");

                entity.Property(e => e.AdZipCode)
                    .HasColumnName("ad_zip_code")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AdZoneFeatures)
                    .HasColumnName("ad_zone_features")
                    .HasMaxLength(59)
                    .IsUnicode(false);

                entity.Property(e => e.AgCoagentId)
                    .HasColumnName("ag_coagent_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.AgCoagentName)
                    .HasColumnName("ag_coagent_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgCoagentPhone)
                    .HasColumnName("ag_coagent_phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgEmail)
                    .HasColumnName("ag_email")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.AgFax)
                    .HasColumnName("ag_fax")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgId)
                    .HasColumnName("ag_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.AgMayRepresentSellerAndBuyer)
                    .HasColumnName("ag_may_represent_seller_and_buyer")
                    .HasColumnType("char(2)");

                entity.Property(e => e.AgMobilePhone)
                    .HasColumnName("ag_mobile_phone")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.AgName)
                    .HasColumnName("ag_name")
                    .HasMaxLength(61)
                    .IsUnicode(false);

                entity.Property(e => e.AgOfficeEmail)
                    .HasColumnName("ag_office_email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgOfficeId)
                    .HasColumnName("ag_office_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.AgOfficeName)
                    .HasColumnName("ag_office_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AgOfficePhone)
                    .HasColumnName("ag_office_phone")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.AgPager)
                    .HasColumnName("ag_pager")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgPhone)
                    .HasColumnName("ag_phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgReciprocalLink)
                    .HasColumnName("ag_reciprocal_link")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.AgRemarks)
                    .HasColumnName("ag_remarks")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AgRepresentationFeatures)
                    .HasColumnName("ag_representation_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgVmail)
                    .HasColumnName("ag_vmail")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgWebsite)
                    .HasColumnName("ag_website")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ConApprovalRequirement)
                    .HasColumnName("con_approval_requirement")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConMaintenanceFee)
                    .HasColumnName("con_maintenance_fee")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.ConManagementFeatures)
                    .HasColumnName("con_management_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ConMinimumLease)
                    .HasColumnName("con_minimum_lease")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ConUnitLevel)
                    .HasColumnName("con_unit_level")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayAddressYn)
                    .HasColumnName("display_address_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.DisplayDistressedPropertyYn)
                    .HasColumnName("display_distressed_property_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ExBuildingCondition)
                    .HasColumnName("ex_building_condition")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExBuildingFaces)
                    .HasColumnName("ex_building_faces")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExBuildingSquareFeet)
                    .HasColumnName("ex_building_square_feet")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.ExCarportSpaces)
                    .HasColumnName("ex_carport_spaces")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.ExConstructionFeatures)
                    .HasColumnName("ex_construction_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.ExFenceFeatures)
                    .HasColumnName("ex_fence_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.ExFldZoneYn)
                    .HasColumnName("ex_fld_zone_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ExFoundationFeatures)
                    .HasColumnName("ex_foundation_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExGarageFeatures)
                    .HasColumnName("ex_garage_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExGarageRemotes)
                    .HasColumnName("ex_garage_remotes")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.ExGarageSpaces)
                    .HasColumnName("ex_garage_spaces")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.ExGarageType)
                    .HasColumnName("ex_garage_type")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ExGeneralFeatures)
                    .HasColumnName("ex_general_features")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExGolfFeatures)
                    .HasColumnName("ex_golf_features")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExHorsePropertyFeatures)
                    .HasColumnName("ex_horse_property_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.ExLocationFeatures)
                    .HasColumnName("ex_location_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.ExLotSizeAcres)
                    .HasColumnName("ex_lot_size_acres")
                    .HasColumnType("decimal(10,4)");

                entity.Property(e => e.ExLotSizeDimensions)
                    .HasColumnName("ex_lot_size_dimensions")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExLotSizeFeatures)
                    .HasColumnName("ex_lot_size_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.ExLotSizeSource)
                    .HasColumnName("ex_lot_size_source")
                    .HasColumnType("char(2)");

                entity.Property(e => e.ExLotSizeSquareFeet)
                    .HasColumnName("ex_lot_size_square_feet")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ExLotsizeRange)
                    .HasColumnName("ex_lotsize_range")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExParkingFeatures)
                    .HasColumnName("ex_parking_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExParkingSpaces)
                    .HasColumnName("ex_parking_spaces")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.ExParkingSpacesTotal)
                    .HasColumnName("ex_parking_spaces_total")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.ExPatioDimensions)
                    .HasColumnName("ex_patio_dimensions")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ExPatioFeatures)
                    .HasColumnName("ex_patio_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExPatioYn)
                    .HasColumnName("ex_patio_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ExPoolDimensions)
                    .HasColumnName("ex_pool_dimensions")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExPoolFeatures)
                    .HasColumnName("ex_pool_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExPoolYn)
                    .HasColumnName("ex_pool_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ExRoadFeatures)
                    .HasColumnName("ex_road_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExRoofFeatures)
                    .HasColumnName("ex_roof_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExRvParkingDimensions)
                    .HasColumnName("ex_rv_parking_dimensions")
                    .HasColumnType("char(6)");

                entity.Property(e => e.ExSewerFeatures)
                    .HasColumnName("ex_sewer_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.ExSolarFeatures)
                    .HasColumnName("ex_solar_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.ExSpaFeatures)
                    .HasColumnName("ex_spa_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExSpaYn)
                    .HasColumnName("ex_spa_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ExSprinklerFeatures)
                    .HasColumnName("ex_sprinkler_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.ExStyle)
                    .HasColumnName("ex_style")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ExStyleFeatures)
                    .HasColumnName("ex_style_features")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExSubdivisionFeatures)
                    .HasColumnName("ex_subdivision_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExViewFeatures)
                    .HasColumnName("ex_view_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.ExWateraccessFeatures)
                    .HasColumnName("ex_wateraccess_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExWaterfrontFeatures)
                    .HasColumnName("ex_waterfront_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExWaterstructuresFeatures)
                    .HasColumnName("ex_waterstructures_features")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FiAdditionalFinanceInfo)
                    .HasColumnName("fi_additional_finance_Info")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FiCompTrigger)
                    .HasColumnName("fi_comp_trigger")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FiFinanceFeatures)
                    .HasColumnName("fi_finance_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FiFinanceSponsor)
                    .HasColumnName("fi_finance_sponsor")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FiFinanceTerms)
                    .HasColumnName("fi_finance_terms")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FiFirstTrustDeedAmount)
                    .HasColumnName("fi_first_trust_deed_amount")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiFirstTrustDeedAssumable)
                    .HasColumnName("fi_first_trust_deed_assumable")
                    .HasColumnType("char(1)");

                entity.Property(e => e.FiFirstTrustDeedDue).HasColumnName("fi_first_trust_deed_due");

                entity.Property(e => e.FiFirstTrustDeedFee)
                    .HasColumnName("fi_first_trust_deed_fee")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiFirstTrustDeedInterest)
                    .HasColumnName("fi_first_trust_deed_interest")
                    .HasColumnType("decimal(5,3)");

                entity.Property(e => e.FiFirstTrustDeedLender)
                    .HasColumnName("fi_first_trust_deed_lender")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FiFirstTrustDeedRate)
                    .HasColumnName("fi_first_trust_deed_rate")
                    .HasColumnType("char(2)");

                entity.Property(e => e.FiFirstTrustDeedType)
                    .HasColumnName("fi_first_trust_deed_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.FiGrossEquity)
                    .HasColumnName("fi_gross_equity")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiIgnoreCompTrigger)
                    .HasColumnName("fi_ignore_comp_trigger")
                    .HasColumnType("char(1)");

                entity.Property(e => e.FiIgnorePaidYn)
                    .HasColumnName("fi_ignore_paid_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.FiPossession)
                    .HasColumnName("fi_possession")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FiSecondTrustDeedAmount)
                    .HasColumnName("fi_second_trust_deed_amount")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiSecondTrustDeedAssumable)
                    .HasColumnName("fi_second_trust_deed_assumable")
                    .HasColumnType("char(1)");

                entity.Property(e => e.FiSecondTrustDeedDue).HasColumnName("fi_second_trust_deed_due");

                entity.Property(e => e.FiSecondTrustDeedFee)
                    .HasColumnName("fi_second_trust_deed_fee")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiSecondTrustDeedInterest)
                    .HasColumnName("fi_second_trust_deed_interest")
                    .HasColumnType("decimal(5,3)");

                entity.Property(e => e.FiSecondTrustDeedLender)
                    .HasColumnName("fi_second_trust_deed_lender")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FiSecondTrustDeedRate)
                    .HasColumnName("fi_second_trust_deed_rate")
                    .HasColumnType("char(2)");

                entity.Property(e => e.FiSecondTrustDeedType)
                    .HasColumnName("fi_second_trust_deed_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.FiTaxAmount)
                    .HasColumnName("fi_tax_amount")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.FiTaxDescriptionFeatures)
                    .HasColumnName("fi_tax_description_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FiTaxPeriod)
                    .HasColumnName("fi_tax_period")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.FiTotalTaxRate)
                    .HasColumnName("fi_total_tax_rate")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.IfApplianceFeatures)
                    .HasColumnName("if_appliance_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IfBasementFeatures)
                    .HasColumnName("if_basement_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IfCoolingFeatures)
                    .HasColumnName("if_cooling_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IfCoolingYn)
                    .HasColumnName("if_cooling_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.IfEnergyFeatures)
                    .HasColumnName("if_energy_features")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.IfFireplaceFeatures)
                    .HasColumnName("if_fireplace_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IfFireplaceNumber)
                    .HasColumnName("if_fireplace_number")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.IfFireplaceYn)
                    .HasColumnName("if_fireplace_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.IfFloorFeatures)
                    .HasColumnName("if_floor_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IfGeneralFeatures)
                    .HasColumnName("if_general_features")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IfHeatingFeatures)
                    .HasColumnName("if_heating_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IfLevels)
                    .HasColumnName("if_levels")
                    .HasColumnType("char(2)");

                entity.Property(e => e.IfLevelsFeatures)
                    .HasColumnName("if_levels_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.IfNumberCeilingFans)
                    .HasColumnName("if_number_ceiling_fans")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.IfPetFeatures)
                    .HasColumnName("if_pet_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IfPlumbingFeatures)
                    .HasColumnName("if_plumbing_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.IfSecurityFeatures)
                    .HasColumnName("if_security_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.IfSecuritySystemYn)
                    .HasColumnName("if_security_system_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.IfSpecialFeatures)
                    .HasColumnName("if_special_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IfUtilitiesFeatures)
                    .HasColumnName("if_utilities_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.IfWaterFeatures)
                    .HasColumnName("if_water_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.IfWindowFeatures)
                    .HasColumnName("if_window_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.InAdditionalPicturesYn)
                    .IsRequired()
                    .HasColumnName("in_additional_pictures_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InAdditionsAlterYn)
                    .HasColumnName("in_additions_alter_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InAdom)
                    .HasColumnName("in_adom")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InAgeFeatures)
                    .HasColumnName("in_age_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InApNumber)
                    .HasColumnName("in_ap_number")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.InAssociationDues1)
                    .HasColumnName("in_association_dues1")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InAssociationDues2)
                    .HasColumnName("in_association_dues2")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InAssociationFeatures)
                    .HasColumnName("in_association_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InAssociationLitigationYn)
                    .HasColumnName("in_association_litigation_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InAssociationPeriod)
                    .HasColumnName("in_association_period")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.InAssociationPhone)
                    .HasColumnName("in_association_phone")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.InAssociationYn)
                    .HasColumnName("in_association_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InBuilderName)
                    .HasColumnName("in_builder_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InCloseDate).HasColumnName("in_close_date");

                entity.Property(e => e.InCompensationBuyAgent)
                    .HasColumnName("in_compensation_buy_agent")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.InCompensationNonrep)
                    .HasColumnName("in_compensation_nonrep")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.InCompensationTransactionAgent)
                    .HasColumnName("in_compensation_transaction_agent")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.InDetailUrl)
                    .HasColumnName("in_detail_url")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.InDistressType)
                    .HasColumnName("in_distress_type")
                    .HasMaxLength(59)
                    .IsUnicode(false);

                entity.Property(e => e.InEscrowDate).HasColumnName("in_escrow_date");

                entity.Property(e => e.InExclusions)
                    .HasColumnName("in_exclusions")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InImageCount)
                    .HasColumnName("in_image_count")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.InIsAttached)
                    .HasColumnName("in_is_attached")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InIsLandLeaseForPurchaseYn)
                    .HasColumnName("in_is_land_lease_for_purchase_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InKeyboxFeatures)
                    .HasColumnName("in_keybox_features")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.InKeyboxLocation)
                    .HasColumnName("in_keybox_location")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InLastTransactionCode)
                    .HasColumnName("in_last_transaction_code")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InLatitude).HasColumnName("in_latitude");

                entity.Property(e => e.InLeaseAmount)
                    .HasColumnName("in_lease_amount")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InLeaseOptionYn)
                    .HasColumnName("in_lease_option_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InLeasePeriod)
                    .HasColumnName("in_lease_period")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.InLeaseTerm)
                    .HasColumnName("in_lease_term")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.InLegalDescription)
                    .HasColumnName("in_legal_description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InLegalFeatures)
                    .HasColumnName("in_legal_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InListDate).HasColumnName("in_list_date");

                entity.Property(e => e.InListPrice)
                    .HasColumnName("in_list_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InListPriceExclusionRemarks)
                    .HasColumnName("in_list_price_exclusion_remarks")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.InListingAgreementType)
                    .HasColumnName("in_listing_agreement_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.InListingHasForSaleSignYn)
                    .HasColumnName("in_listing_has_for_sale_sign_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InListingLoadedByBroker)
                    .HasColumnName("in_listing_loaded_by_broker")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.InLivingSquareFeet)
                    .HasColumnName("in_living_square_feet")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InLoadDate).HasColumnName("in_load_date");

                entity.Property(e => e.InLongitude).HasColumnName("in_longitude");

                entity.Property(e => e.InMelloRoosYn)
                    .HasColumnName("in_mello_roos_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InModelName)
                    .HasColumnName("in_model_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InModifyDate).HasColumnName("in_modify_date");

                entity.Property(e => e.InOccupantFeatures)
                    .HasColumnName("in_occupant_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InOccupantName)
                    .HasColumnName("in_occupant_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InOccupantPhone)
                    .HasColumnName("in_occupant_phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InOffmarketDate).HasColumnName("in_offmarket_date");

                entity.Property(e => e.InOrigListPrice)
                    .HasColumnName("in_orig_list_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InOwnerName)
                    .HasColumnName("in_owner_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InOwnerPhone)
                    .HasColumnName("in_owner_phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InPendingDate).HasColumnName("in_pending_date");

                entity.Property(e => e.InPendingPrice)
                    .HasColumnName("in_pending_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InPreviousListPrice)
                    .HasColumnName("in_previous_list_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InPreviousStatus)
                    .HasColumnName("in_previous_status")
                    .HasColumnType("char(2)");

                entity.Property(e => e.InProjectedEscrowCloseDate).HasColumnName("in_projected_escrow_close_date");

                entity.Property(e => e.InPropertyType)
                    .HasColumnName("in_property_type")
                    .HasColumnType("char(3)");

                entity.Property(e => e.InPublicRemarks)
                    .HasColumnName("in_public_remarks")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.InPullDate).HasColumnName("in_pull_date");

                entity.Property(e => e.InRangeHighLivingSquareFeet)
                    .HasColumnName("in_range_high_living_square_feet")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InRangeHighPrice)
                    .HasColumnName("in_range_high_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InRangeLowLivingSquareFeet)
                    .HasColumnName("in_range_low_living_square_feet")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InRangeLowPrice)
                    .HasColumnName("in_range_low_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InRangePriceFlag)
                    .HasColumnName("in_range_price_flag")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InReciprocalListing)
                    .HasColumnName("in_reciprocal_listing")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InRemodeledDate).HasColumnName("in_remodeled_date");

                entity.Property(e => e.InRestrictions)
                    .HasColumnName("in_restrictions")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InRetreatYn)
                    .HasColumnName("in_retreat_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InSellerAgreesToPayPoints)
                    .HasColumnName("in_seller_agrees_to_pay_points")
                    .HasColumnType("char(4)");

                entity.Property(e => e.InSellingOfficeComp)
                    .HasColumnName("in_selling_office_comp")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.InSellingOfficeCompType)
                    .HasColumnName("in_selling_office_comp_type")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InSellingOfficeCompensation)
                    .HasColumnName("in_selling_office_compensation")
                    .HasColumnType("char(4)");

                entity.Property(e => e.InShowingInstructions)
                    .HasColumnName("in_showing_instructions")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.InSoldAgentName)
                    .HasColumnName("in_sold_agent_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InSoldAgentOfficeId)
                    .HasColumnName("in_sold_agent_office_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.InSoldAgentPublicId)
                    .HasColumnName("in_sold_agent_public_id")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.InSoldDate).HasColumnName("in_sold_date");

                entity.Property(e => e.InSoldFinanceTerms)
                    .HasColumnName("in_sold_finance_terms")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InSoldOfficeName)
                    .HasColumnName("in_sold_office_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InSoldPrice)
                    .HasColumnName("in_sold_price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InSoldTerms)
                    .HasColumnName("in_sold_terms")
                    .HasColumnType("char(2)");

                entity.Property(e => e.InStatus)
                    .HasColumnName("in_status")
                    .HasColumnType("char(2)");

                entity.Property(e => e.InStatusDate).HasColumnName("in_status_date");

                entity.Property(e => e.InSubtype)
                    .HasColumnName("in_subtype")
                    .HasColumnType("char(3)");

                entity.Property(e => e.InSystemExpireDate).HasColumnName("in_system_expire_date");

                entity.Property(e => e.InTotalAssessedValue)
                    .HasColumnName("in_total_assessed_value")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.InTotalUnitsInComplex)
                    .HasColumnName("in_total_units_in_complex")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.InTractCode)
                    .HasColumnName("in_tract_code")
                    .HasColumnType("char(4)");

                entity.Property(e => e.InTractName)
                    .HasColumnName("in_tract_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InTransactDate).HasColumnName("in_transact_date");

                entity.Property(e => e.InTransferOfPossession)
                    .HasColumnName("in_transfer_of_possession")
                    .HasColumnType("char(2)");

                entity.Property(e => e.InViewYn)
                    .HasColumnName("in_view_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InVirtualTourLink)
                    .HasColumnName("in_virtual_tour_link")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InVolt220OutletLocation)
                    .HasColumnName("in_volt220_outlet_location")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InWithdrawnDate).HasColumnName("in_withdrawn_date");

                entity.Property(e => e.InYearBuilt)
                    .HasColumnName("in_year_built")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.LandFeatures)
                    .HasColumnName("land_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LandLeaseAmount)
                    .HasColumnName("land_lease_amount")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.LandLeaseExpireDate).HasColumnName("land_lease_expire_date");

                entity.Property(e => e.LandLeaseRenewDate).HasColumnName("land_lease_renew_date");

                entity.Property(e => e.LandLeaseTerm)
                    .HasColumnName("land_lease_term")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.LandLeaseTransferAmount)
                    .HasColumnName("land_lease_transfer_amount")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.LandOwnershipType)
                    .HasColumnName("land_ownership_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.LastImport)
                    .HasColumnName("last_import")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ListOnInternetYn)
                    .HasColumnName("list_on_internet_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ListingIddYn)
                    .HasColumnName("listing_idd_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.PublishStatus)
                    .HasColumnName("publish_status")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RegMlsCode)
                    .HasColumnName("reg_mls_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmBathroomFeatures)
                    .HasColumnName("rm_bathroom_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RmBathsFull)
                    .HasColumnName("rm_baths_full")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.RmBathsHalf)
                    .HasColumnName("rm_baths_half")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.RmBathsQuarter)
                    .HasColumnName("rm_baths_quarter")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.RmBathsThreeQuarter)
                    .HasColumnName("rm_baths_three_quarter")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.RmBathsTotal)
                    .HasColumnName("rm_baths_total")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.RmBedroomFeatures)
                    .HasColumnName("rm_bedroom_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RmBedroomsTotal)
                    .HasColumnName("rm_bedrooms_total")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.RmBonusFeatures)
                    .HasColumnName("rm_bonus_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RmBonusYn)
                    .HasColumnName("rm_bonus_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.RmConvertedBedroomYn)
                    .HasColumnName("rm_converted_bedroom_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.RmDenYn)
                    .HasColumnName("rm_den_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.RmDiningFeatures)
                    .HasColumnName("rm_dining_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RmFamilyYn)
                    .HasColumnName("rm_family_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.RmFormalDiningYn)
                    .HasColumnName("rm_formal_dining_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.RmGeneralFeatures)
                    .HasColumnName("rm_general_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RmKitchenFeatures)
                    .HasColumnName("rm_kitchen_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RmLaundryFeatures)
                    .HasColumnName("rm_laundry_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RmLivingFeatures)
                    .HasColumnName("rm_living_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RmLivingYn)
                    .HasColumnName("rm_living_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.RmMasterDressingAreaYn)
                    .HasColumnName("rm_master_dressing_area_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.RmMasterYn)
                    .HasColumnName("rm_master_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.RmRoom10Dimensions1)
                    .HasColumnName("rm_room10_dimensions1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom10Dimensions2)
                    .HasColumnName("rm_room10_dimensions2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom10Features)
                    .HasColumnName("rm_room10_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom10Type)
                    .HasColumnName("rm_room10_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.RmRoom11Dimensions1)
                    .HasColumnName("rm_room11_dimensions1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom11Dimensions2)
                    .HasColumnName("rm_room11_dimensions2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom11Features)
                    .HasColumnName("rm_room11_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom11Type)
                    .HasColumnName("rm_room11_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.RmRoom12Dimensions1)
                    .HasColumnName("rm_room12_dimensions1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom12Dimensions2)
                    .HasColumnName("rm_room12_dimensions2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom12Features)
                    .HasColumnName("rm_room12_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom12Type)
                    .HasColumnName("rm_room12_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.RmRoom13Dimensions1)
                    .HasColumnName("rm_room13_dimensions1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom13Dimensions2)
                    .HasColumnName("rm_room13_dimensions2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom13Features)
                    .HasColumnName("rm_room13_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom13Type)
                    .HasColumnName("rm_room13_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.RmRoom14Dimensions1)
                    .HasColumnName("rm_room14_dimensions1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom14Dimensions2)
                    .HasColumnName("rm_room14_dimensions2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom14Features)
                    .HasColumnName("rm_room14_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom14Type)
                    .HasColumnName("rm_room14_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.RmRoom1Dimensions1)
                    .HasColumnName("rm_room1_dimensions1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom1Dimensions2)
                    .HasColumnName("rm_room1_dimensions2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom1Features)
                    .HasColumnName("rm_room1_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom1Type)
                    .HasColumnName("rm_room1_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.RmRoom2Dimensions1)
                    .HasColumnName("rm_room2_dimensions1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom2Dimensions2)
                    .HasColumnName("rm_room2_dimensions2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom2Features)
                    .HasColumnName("rm_room2_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom2Type)
                    .HasColumnName("rm_room2_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.RmRoom3Dimensions1)
                    .HasColumnName("rm_room3_dimensions1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom3Dimensions2)
                    .HasColumnName("rm_room3_dimensions2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom3Features)
                    .HasColumnName("rm_room3_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom3Type)
                    .HasColumnName("rm_room3_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.RmRoom4Dimensions1)
                    .HasColumnName("rm_room4_dimensions1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom4Dimensions2)
                    .HasColumnName("rm_room4_dimensions2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom4Features)
                    .HasColumnName("rm_room4_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom4Type)
                    .HasColumnName("rm_room4_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.RmRoom5Dimensions1)
                    .HasColumnName("rm_room5_dimensions1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom5Dimensions2)
                    .HasColumnName("rm_room5_dimensions2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom5Features)
                    .HasColumnName("rm_room5_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom5Type)
                    .HasColumnName("rm_room5_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.RmRoom6Dimensions1)
                    .HasColumnName("rm_room6_dimensions1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom6Dimensions2)
                    .HasColumnName("rm_room6_dimensions2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom6Features)
                    .HasColumnName("rm_room6_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom6Type)
                    .HasColumnName("rm_room6_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.RmRoom7Dimensions1)
                    .HasColumnName("rm_room7_dimensions1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom7Dimensions2)
                    .HasColumnName("rm_room7_dimensions2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom7Features)
                    .HasColumnName("rm_room7_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom7Type)
                    .HasColumnName("rm_room7_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.RmRoom8Dimensions1)
                    .HasColumnName("rm_room8_dimensions1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom8Dimensions2)
                    .HasColumnName("rm_room8_dimensions2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom8Features)
                    .HasColumnName("rm_room8_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom8Type)
                    .HasColumnName("rm_room8_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.RmRoom9Dimensions1)
                    .HasColumnName("rm_room9_dimensions1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom9Dimensions2)
                    .HasColumnName("rm_room9_dimensions2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom9Features)
                    .HasColumnName("rm_room9_features")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RmRoom9Type)
                    .HasColumnName("rm_room9_type")
                    .HasColumnType("char(2)");

                entity.Property(e => e.RmRoomsTotal)
                    .HasColumnName("rm_rooms_total")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RmTermiteClearYn)
                    .HasColumnName("rm_termite_clear_yn")
                    .HasColumnType("char(1)");

                entity.Property(e => e.RmUtilityFeatures)
                    .HasColumnName("rm_utility_features")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RmWalkInClosets)
                    .HasColumnName("rm_walk_in_closets")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.ScElementarySchool)
                    .HasColumnName("sc_elementary_school")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScHighSchool)
                    .HasColumnName("sc_high_school")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScJuniorHighSchool)
                    .HasColumnName("sc_junior_high_school")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScSchoolDistrict)
                    .HasColumnName("sc_school_district")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MlsStats>(entity =>
            {
                entity.HasKey(e => new { e.OrgId, e.ListingTypeId });

                entity.ToTable("mls_stats", "rezoradata");

                entity.Property(e => e.OrgId)
                    .HasColumnName("org_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ListingTypeId)
                    .HasColumnName("listing_type_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("6");

                entity.Property(e => e.ActiveGeocodes)
                    .HasColumnName("active_geocodes")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActiveListings)
                    .HasColumnName("active_listings")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ImageListings)
                    .HasColumnName("image_listings")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Imported).HasColumnName("imported");

                entity.Property(e => e.StatsTimestamp)
                    .HasColumnName("stats_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<MlsUsedListings>(entity =>
            {
                entity.HasKey(e => new { e.OrgId, e.ListingId, e.ListingTypeId });

                entity.ToTable("mls_used_listings", "rezoradata");

                entity.Property(e => e.OrgId)
                    .HasColumnName("org_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ListingId)
                    .HasColumnName("listing_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ListingTypeId)
                    .HasColumnName("listing_type_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("6");
            });

            modelBuilder.Entity<Newsletters>(entity =>
            {
                entity.HasKey(e => e.NewsletterId);

                entity.ToTable("newsletters", "rezoradata");

                entity.HasIndex(e => e.EmsEmailId)
                    .HasName("ems_email_id");

                entity.HasIndex(e => e.NewsletterAuthorized)
                    .HasName("newsletter_authorized");

                entity.HasIndex(e => e.NewsletterAutomated)
                    .HasName("newsletter_automated");

                entity.HasIndex(e => e.NewsletterEditedDate)
                    .HasName("newsletter_edited_date");

                entity.HasIndex(e => e.NewsletterSentDate)
                    .HasName("newsletter_sent_date");

                entity.HasIndex(e => e.TemplateId)
                    .HasName("template_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.HasIndex(e => new { e.UserId, e.NewsletterSentDate, e.NewsletterId })
                    .HasName("user_id_2");

                entity.Property(e => e.NewsletterId)
                    .HasColumnName("newsletter_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BounceCount)
                    .HasColumnName("bounce_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClickCount)
                    .HasColumnName("click_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EmailCount)
                    .HasColumnName("email_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EmsEmailId)
                    .IsRequired()
                    .HasColumnName("ems_email_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewsletterAdminPublished).HasColumnName("newsletter_admin_published");

                entity.Property(e => e.NewsletterAllowOnline)
                    .HasColumnName("newsletter_allow_online")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NewsletterArticles)
                    .HasColumnName("newsletter_articles")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NewsletterAuthorized)
                    .HasColumnName("newsletter_authorized")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.NewsletterAutomated)
                    .HasColumnName("newsletter_automated")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NewsletterCampaignName)
                    .IsRequired()
                    .HasColumnName("newsletter_campaign_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NewsletterDate).HasColumnName("newsletter_date");

                entity.Property(e => e.NewsletterEditedDate)
                    .HasColumnName("newsletter_edited_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.NewsletterHeadline)
                    .IsRequired()
                    .HasColumnName("newsletter_headline")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NewsletterHeadline2)
                    .IsRequired()
                    .HasColumnName("newsletter_headline2")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NewsletterHeadline3)
                    .IsRequired()
                    .HasColumnName("newsletter_headline3")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NewsletterHeadline4)
                    .IsRequired()
                    .HasColumnName("newsletter_headline4")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NewsletterHeadline5)
                    .IsRequired()
                    .HasColumnName("newsletter_headline5")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NewsletterHeight)
                    .HasColumnName("newsletter_height")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NewsletterHtmlTimestamp).HasColumnName("newsletter_html_timestamp");

                entity.Property(e => e.NewsletterJson)
                    .IsRequired()
                    .HasColumnName("newsletter_json")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.NewsletterJsonDraft)
                    .IsRequired()
                    .HasColumnName("newsletter_json_draft")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.NewsletterListings)
                    .HasColumnName("newsletter_listings")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NewsletterMessage)
                    .IsRequired()
                    .HasColumnName("newsletter_message")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.NewsletterPreviewId)
                    .IsRequired()
                    .HasColumnName("newsletter_preview_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewsletterProds)
                    .HasColumnName("newsletter_prods")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NewsletterReportCharts)
                    .IsRequired()
                    .HasColumnName("newsletter_report_charts")
                    .IsUnicode(false);

                entity.Property(e => e.NewsletterReportStats)
                    .IsRequired()
                    .HasColumnName("newsletter_report_stats")
                    .IsUnicode(false);

                entity.Property(e => e.NewsletterRsvp)
                    .HasColumnName("newsletter_rsvp")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NewsletterSentDate).HasColumnName("newsletter_sent_date");

                entity.Property(e => e.NewsletterSubject)
                    .IsRequired()
                    .HasColumnName("newsletter_subject")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NewsletterTitle)
                    .IsRequired()
                    .HasColumnName("newsletter_title")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NewsletterVersion)
                    .HasColumnName("newsletter_version")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.NewsletterWidth)
                    .HasColumnName("newsletter_width")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OpenCount)
                    .HasColumnName("open_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ReachCount)
                    .HasColumnName("reach_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SpamCount)
                    .HasColumnName("spam_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("template_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ThumbnailTimestamp).HasColumnName("thumbnail_timestamp");

                entity.Property(e => e.TotalClickCount)
                    .HasColumnName("total_click_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TotalOpenCount)
                    .HasColumnName("total_open_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Template)
                    .WithMany(p => p.Newsletters)
                    .HasForeignKey(d => d.TemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("newsletters_ibfk_2");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Newsletters)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("newsletters_ibfk_1");
            });

            modelBuilder.Entity<NewslettersArticles>(entity =>
            {
                entity.HasKey(e => e.ArticleId);

                entity.ToTable("newsletters_articles", "rezoradata");

                entity.HasIndex(e => e.ArticleOrder)
                    .HasName("article_order");

                entity.HasIndex(e => e.NewsletterId)
                    .HasName("newsletter_id");

                entity.HasIndex(e => new { e.NewsletterId, e.ArticleOrder })
                    .HasName("newsletter_id_2")
                    .IsUnique();

                entity.Property(e => e.ArticleId)
                    .HasColumnName("article_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArticleDate)
                    .IsRequired()
                    .HasColumnName("article_date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ArticleLink)
                    .IsRequired()
                    .HasColumnName("article_link")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ArticleOrder)
                    .HasColumnName("article_order")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArticleSource)
                    .IsRequired()
                    .HasColumnName("article_source")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ArticleSummary)
                    .IsRequired()
                    .HasColumnName("article_summary")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ArticleTimestamp)
                    .HasColumnName("article_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ArticleTitle)
                    .IsRequired()
                    .HasColumnName("article_title")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NewsletterId)
                    .HasColumnName("newsletter_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Newsletter)
                    .WithMany(p => p.NewslettersArticles)
                    .HasForeignKey(d => d.NewsletterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("newsletters_articles_ibfk_1");
            });

            modelBuilder.Entity<NewslettersCrmDataAdmins>(entity =>
            {
                entity.HasKey(e => e.CrmdataId);

                entity.ToTable("newsletters_crm_data_admins", "rezoradata");

                entity.Property(e => e.CrmdataId)
                    .HasColumnName("crmdata_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CrmEvent)
                    .HasColumnName("crm_event")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CrmEventSubject)
                    .HasColumnName("crm_event_subject")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CrmType)
                    .HasColumnName("crm_type")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EventTimestamp).HasColumnName("event_timestamp");

                entity.Property(e => e.ScheduleId)
                    .HasColumnName("schedule_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<NewslettersCrmDataAgents>(entity =>
            {
                entity.HasKey(e => e.CrmdataId);

                entity.ToTable("newsletters_crm_data_agents", "rezoradata");

                entity.Property(e => e.CrmdataId)
                    .HasColumnName("crmdata_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CrmEvent)
                    .HasColumnName("crm_event")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CrmEventSubject)
                    .HasColumnName("crm_event_subject")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CrmType)
                    .HasColumnName("crm_type")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EventTimestamp).HasColumnName("event_timestamp");

                entity.Property(e => e.NewsletterId)
                    .HasColumnName("newsletter_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<NewslettersListingsClicktoplayImages>(entity =>
            {
                entity.HasKey(e => e.ClicktoplayImageId);

                entity.ToTable("newsletters_listings_clicktoplay_images", "rezoradata");

                entity.HasIndex(e => new { e.NewsletterId, e.OrgId, e.ListingId, e.ListingTypeId })
                    .HasName("newsletter_id");

                entity.Property(e => e.ClicktoplayImageId)
                    .HasColumnName("clicktoplay_image_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.ClicktoplayImagePath)
                    .HasColumnName("clicktoplay_image_path")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ClicktoplayImageTimestamp)
                    .HasColumnName("clicktoplay_image_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ListingId)
                    .IsRequired()
                    .HasColumnName("listing_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.ListingOrder)
                    .HasColumnName("listing_order")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.ListingPhotoHeight)
                    .HasColumnName("listing_photo_height")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ListingPhotoWidth)
                    .HasColumnName("listing_photo_width")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ListingTypeId)
                    .HasColumnName("listing_type_id")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.NewsletterId)
                    .HasColumnName("newsletter_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OrgId)
                    .IsRequired()
                    .HasColumnName("org_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NewslettersListingsTemplates>(entity =>
            {
                entity.HasKey(e => e.ListingtemplateId);

                entity.ToTable("newsletters_listings_templates", "rezoradata");

                entity.HasIndex(e => new { e.TemplateId, e.ListingPosition })
                    .HasName("template_id");

                entity.Property(e => e.ListingtemplateId)
                    .HasColumnName("listingtemplate_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ListingPosition)
                    .HasColumnName("listing_position")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ListingtemplateName)
                    .IsRequired()
                    .HasColumnName("listingtemplate_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateId)
                    .HasColumnName("template_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<NewslettersMessages>(entity =>
            {
                entity.HasKey(e => e.MessageId);

                entity.ToTable("newsletters_messages", "rezoradata");

                entity.HasIndex(e => e.MessageOrder)
                    .HasName("message_order");

                entity.HasIndex(e => new { e.NewsletterId, e.MessageOrder })
                    .HasName("newsletter_id")
                    .IsUnique();

                entity.Property(e => e.MessageId)
                    .HasColumnName("message_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MessageDate)
                    .HasColumnName("message_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.MessageOrder)
                    .HasColumnName("message_order")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MessageText)
                    .HasColumnName("message_text")
                    .IsUnicode(false);

                entity.Property(e => e.NewsletterId)
                    .HasColumnName("newsletter_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Newsletter)
                    .WithMany(p => p.NewslettersMessages)
                    .HasForeignKey(d => d.NewsletterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("newsletters_messages_ibfk_1");
            });

            modelBuilder.Entity<NewslettersOgTags>(entity =>
            {
                entity.ToTable("newsletters_og_tags", "rezoradata");

                entity.HasIndex(e => new { e.NewsletterId, e.OgTagName })
                    .HasName("idx_newsletter_id_og_tag_name");

                entity.Property(e => e.NewslettersOgTagsId)
                    .HasColumnName("newsletters_og_tags_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NewsletterId)
                    .HasColumnName("newsletter_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OgTagName)
                    .IsRequired()
                    .HasColumnName("og_tag_name")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.OgTagValue)
                    .IsRequired()
                    .HasColumnName("og_tag_value")
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NewslettersReports>(entity =>
            {
                entity.HasKey(e => e.ReportId);

                entity.ToTable("newsletters_reports", "rezoradata");

                entity.HasIndex(e => e.NewsletterId)
                    .HasName("newsletter_id");

                entity.Property(e => e.ReportId)
                    .HasColumnName("report_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CityId)
                    .HasColumnName("city_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NewsletterId)
                    .HasColumnName("newsletter_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ReportCharts)
                    .IsRequired()
                    .HasColumnName("report_charts")
                    .IsUnicode(false);

                entity.Property(e => e.ReportStats)
                    .IsRequired()
                    .HasColumnName("report_stats")
                    .IsUnicode(false);

                entity.Property(e => e.ResidenceType)
                    .IsRequired()
                    .HasColumnName("residence_type")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ZipId)
                    .IsRequired()
                    .HasColumnName("zip_id")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NewslettersSchedules>(entity =>
            {
                entity.HasKey(e => e.ScheduleId);

                entity.ToTable("newsletters_schedules", "rezoradata");

                entity.HasIndex(e => e.BrokerageId)
                    .HasName("brokerage_id");

                entity.HasIndex(e => e.MasterId)
                    .HasName("master_id");

                entity.HasIndex(e => e.ScheduleDatetime)
                    .HasName("schedule_datetime");

                entity.HasIndex(e => e.ScheduleSentdate)
                    .HasName("schedule_sentdate");

                entity.HasIndex(e => e.TemplateId)
                    .HasName("template_id");

                entity.HasIndex(e => new { e.TemplateId, e.BrokerageId })
                    .HasName("template_id_2")
                    .IsUnique();

                entity.Property(e => e.ScheduleId)
                    .HasColumnName("schedule_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BounceCount)
                    .HasColumnName("bounce_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BrokerageId)
                    .HasColumnName("brokerage_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClickCount)
                    .HasColumnName("click_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EmailCount)
                    .HasColumnName("email_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MasterId)
                    .HasColumnName("master_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OpenCount)
                    .HasColumnName("open_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ScheduleDatetime).HasColumnName("schedule_datetime");

                entity.Property(e => e.ScheduleExpiration).HasColumnName("schedule_expiration");

                entity.Property(e => e.ScheduleFinishdate).HasColumnName("schedule_finishdate");

                entity.Property(e => e.ScheduleMessage)
                    .IsRequired()
                    .HasColumnName("schedule_message")
                    .IsUnicode(false);

                entity.Property(e => e.ScheduleSentdate).HasColumnName("schedule_sentdate");

                entity.Property(e => e.ScheduleStartdate).HasColumnName("schedule_startdate");

                entity.Property(e => e.ScheduleSubject)
                    .IsRequired()
                    .HasColumnName("schedule_subject")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ScheduleTimestamp)
                    .HasColumnName("schedule_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.SpamCount)
                    .HasColumnName("spam_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("template_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Template)
                    .WithMany(p => p.NewslettersSchedules)
                    .HasForeignKey(d => d.TemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("newsletters_schedules_ibfk_1");
            });

            modelBuilder.Entity<NewslettersSchedulesOptouts>(entity =>
            {
                entity.HasKey(e => e.OptoutId);

                entity.ToTable("newsletters_schedules_optouts", "rezoradata");

                entity.HasIndex(e => e.BrokerageId)
                    .HasName("brokerage_id");

                entity.HasIndex(e => e.ScheduleId)
                    .HasName("schedule_id");

                entity.HasIndex(e => e.TemplateId)
                    .HasName("template_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.HasIndex(e => new { e.ScheduleId, e.UserId })
                    .HasName("schedule_id_2")
                    .IsUnique();

                entity.Property(e => e.OptoutId)
                    .HasColumnName("optout_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BrokerageId)
                    .HasColumnName("brokerage_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OptoutTimestamp)
                    .HasColumnName("optout_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ScheduleId)
                    .HasColumnName("schedule_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("template_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<NewslettersTemp>(entity =>
            {
                entity.HasKey(e => e.NewsletterId);

                entity.ToTable("newsletters_temp", "rezoradata");

                entity.HasIndex(e => e.EmsEmailId)
                    .HasName("ems_email_id");

                entity.HasIndex(e => e.NewsletterAuthorized)
                    .HasName("newsletter_authorized");

                entity.HasIndex(e => e.NewsletterAutomated)
                    .HasName("newsletter_automated");

                entity.HasIndex(e => e.NewsletterEditedDate)
                    .HasName("newsletter_edited_date");

                entity.HasIndex(e => e.NewsletterSentDate)
                    .HasName("newsletter_sent_date");

                entity.HasIndex(e => e.TemplateId)
                    .HasName("template_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.HasIndex(e => new { e.UserId, e.NewsletterSentDate, e.NewsletterId })
                    .HasName("user_id_2");

                entity.Property(e => e.NewsletterId)
                    .HasColumnName("newsletter_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BounceCount)
                    .HasColumnName("bounce_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClickCount)
                    .HasColumnName("click_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EmailCount)
                    .HasColumnName("email_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EmsEmailId)
                    .IsRequired()
                    .HasColumnName("ems_email_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewsletterAuthorized)
                    .HasColumnName("newsletter_authorized")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.NewsletterAutomated)
                    .HasColumnName("newsletter_automated")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NewsletterDate).HasColumnName("newsletter_date");

                entity.Property(e => e.NewsletterEditedDate)
                    .HasColumnName("newsletter_edited_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.NewsletterHeadline)
                    .IsRequired()
                    .HasColumnName("newsletter_headline")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NewsletterHeadline2)
                    .IsRequired()
                    .HasColumnName("newsletter_headline2")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NewsletterHeadline3)
                    .IsRequired()
                    .HasColumnName("newsletter_headline3")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NewsletterMessage)
                    .IsRequired()
                    .HasColumnName("newsletter_message")
                    .IsUnicode(false);

                entity.Property(e => e.NewsletterPreviewId)
                    .IsRequired()
                    .HasColumnName("newsletter_preview_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewsletterSentDate).HasColumnName("newsletter_sent_date");

                entity.Property(e => e.NewsletterSubject)
                    .IsRequired()
                    .HasColumnName("newsletter_subject")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OpenCount)
                    .HasColumnName("open_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SpamCount)
                    .HasColumnName("spam_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("template_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<NewslettersTemplates>(entity =>
            {
                entity.HasKey(e => e.TemplateId);

                entity.ToTable("newsletters_templates", "rezoradata");

                entity.HasIndex(e => e.MasterId)
                    .HasName("master_id");

                entity.HasIndex(e => e.RequestContactUserId)
                    .HasName("request_contact_user_id");

                entity.HasIndex(e => e.TemplateClass)
                    .HasName("template_class");

                entity.HasIndex(e => e.TemplateRestricted)
                    .HasName("template_restricted");

                entity.HasIndex(e => e.TemplateTitle)
                    .HasName("template_title");

                entity.HasIndex(e => e.TemplateTypeId)
                    .HasName("template_type_id");

                entity.HasIndex(e => new { e.TemplateClass, e.MasterEnabled, e.TemplateStatus })
                    .HasName("template_class_2");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("template_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AllowEmail)
                    .HasColumnName("allow_email")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.AllowOnline)
                    .HasColumnName("allow_online")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.AllowPrint)
                    .HasColumnName("allow_print")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BounceCount)
                    .HasColumnName("bounce_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClickCount)
                    .HasColumnName("click_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EmailCount)
                    .HasColumnName("email_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsDisplayAd)
                    .HasColumnName("is_display_ad")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsResponsive)
                    .HasColumnName("is_responsive")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsWellcomemat)
                    .HasColumnName("is_wellcomemat")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MasterEnabled)
                    .HasColumnName("master_enabled")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.MasterId)
                    .HasColumnName("master_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OpenCount)
                    .HasColumnName("open_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ReachCount)
                    .HasColumnName("reach_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ReportCharts)
                    .IsRequired()
                    .HasColumnName("report_charts")
                    .IsUnicode(false);

                entity.Property(e => e.ReportStats)
                    .IsRequired()
                    .HasColumnName("report_stats")
                    .IsUnicode(false);

                entity.Property(e => e.RequestContactUserId)
                    .HasColumnName("request_contact_user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RequestMessage)
                    .IsRequired()
                    .HasColumnName("request_message")
                    .IsUnicode(false);

                entity.Property(e => e.RequestUrl)
                    .IsRequired()
                    .HasColumnName("request_url")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SpamCount)
                    .HasColumnName("spam_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplateArchived)
                    .HasColumnName("template_archived")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TemplateArticles)
                    .HasColumnName("template_articles")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplateCampaignId)
                    .HasColumnName("template_campaign_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TemplateCampaignName)
                    .IsRequired()
                    .HasColumnName("template_campaign_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateClass)
                    .HasColumnName("template_class")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.TemplateDate)
                    .HasColumnName("template_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TemplateDefaultMessage)
                    .IsRequired()
                    .HasColumnName("template_default_message")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.TemplateDefaultSubject)
                    .IsRequired()
                    .HasColumnName("template_default_subject")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateHead)
                    .IsRequired()
                    .HasColumnName("template_head")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.TemplateHeadlines)
                    .HasColumnName("template_headlines")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplateHeight)
                    .HasColumnName("template_height")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TemplateHtmlTimestamp).HasColumnName("template_html_timestamp");

                entity.Property(e => e.TemplateJson)
                    .IsRequired()
                    .HasColumnName("template_json")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.TemplateJsonDraft)
                    .IsRequired()
                    .HasColumnName("template_json_draft")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.TemplateListings)
                    .HasColumnName("template_listings")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplateMessageMax)
                    .HasColumnName("template_message_max")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplateMessages)
                    .HasColumnName("template_messages")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplateName)
                    .IsRequired()
                    .HasColumnName("template_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateNotes)
                    .IsRequired()
                    .HasColumnName("template_notes")
                    .IsUnicode(false);

                entity.Property(e => e.TemplatePath)
                    .IsRequired()
                    .HasColumnName("template_path")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TemplatePchefprods)
                    .HasColumnName("template_pchefprods")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TemplatePreviewId)
                    .IsRequired()
                    .HasColumnName("template_preview_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TemplatePrice).HasColumnName("template_price");

                entity.Property(e => e.TemplateProds)
                    .HasColumnName("template_prods")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TemplateRestricted)
                    .HasColumnName("template_restricted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplateRsvp)
                    .HasColumnName("template_rsvp")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TemplateStatus)
                    .HasColumnName("template_status")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.TemplateThumbnailPath)
                    .IsRequired()
                    .HasColumnName("template_thumbnail_path")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateTitle)
                    .IsRequired()
                    .HasColumnName("template_title")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateTypeId)
                    .HasColumnName("template_type_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("33");

                entity.Property(e => e.TemplateVersion)
                    .HasColumnName("template_version")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.TemplateWidth)
                    .HasColumnName("template_width")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ThumbnailTimestamp).HasColumnName("thumbnail_timestamp");

                entity.Property(e => e.TotalClickCount)
                    .HasColumnName("total_click_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TotalOpenCount)
                    .HasColumnName("total_open_count")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.TemplateType)
                    .WithMany(p => p.NewslettersTemplates)
                    .HasForeignKey(d => d.TemplateTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("newsletters_templates_ibfk_1");
            });

            modelBuilder.Entity<NewslettersTemplatesCats>(entity =>
            {
                entity.HasKey(e => e.CatId);

                entity.ToTable("newsletters_templates_cats", "rezoradata");

                entity.HasIndex(e => e.BrokerageId)
                    .HasName("brokerage_id");

                entity.HasIndex(e => e.CatTitle)
                    .HasName("type_title");

                entity.HasIndex(e => e.MasterId)
                    .HasName("master_id");

                entity.Property(e => e.CatId)
                    .HasColumnName("cat_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BrokerageId)
                    .HasColumnName("brokerage_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CatDate)
                    .HasColumnName("cat_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CatTitle)
                    .IsRequired()
                    .HasColumnName("cat_title")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Isactive)
                    .HasColumnName("isactive")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Isvisible)
                    .HasColumnName("isvisible")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.MasterId)
                    .HasColumnName("master_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<NewslettersTemplatesClasses>(entity =>
            {
                entity.HasKey(e => e.ClassId);

                entity.ToTable("newsletters_templates_classes", "rezoradata");

                entity.HasIndex(e => e.ClassTitle)
                    .HasName("class_title");

                entity.Property(e => e.ClassId)
                    .HasColumnName("class_id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClassTitle)
                    .IsRequired()
                    .HasColumnName("class_title")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NewslettersTemplatesDefaults>(entity =>
            {
                entity.HasKey(e => e.DefaultId);

                entity.ToTable("newsletters_templates_defaults", "rezoradata");

                entity.HasIndex(e => new { e.BrokerageId, e.TypeId })
                    .HasName("brokerage_id");

                entity.Property(e => e.DefaultId)
                    .HasColumnName("default_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.BrokerageId)
                    .HasColumnName("brokerage_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DefaultTimestamp)
                    .HasColumnName("default_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("template_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TypeId)
                    .HasColumnName("type_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<NewslettersTemplatesDefaultsTypes>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.ToTable("newsletters_templates_defaults_types", "rezoradata");

                entity.HasIndex(e => new { e.TypeId, e.TypeChannel })
                    .HasName("type_id");

                entity.Property(e => e.TypeId)
                    .HasColumnName("type_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.TypeChannel)
                    .IsRequired()
                    .HasColumnName("type_channel")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasColumnName("type_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TypeTimestamp)
                    .HasColumnName("type_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<NewslettersTemplatesToBrokerages>(entity =>
            {
                entity.HasKey(e => e.TemplatetobrokerageId);

                entity.ToTable("newsletters_templates_to_brokerages", "rezoradata");

                entity.HasIndex(e => e.BrokerageId)
                    .HasName("brokerage_id");

                entity.HasIndex(e => e.TemplateId)
                    .HasName("template_id");

                entity.HasIndex(e => new { e.TemplateId, e.BrokerageId })
                    .HasName("template_id_2")
                    .IsUnique();

                entity.Property(e => e.TemplatetobrokerageId)
                    .HasColumnName("templatetobrokerage_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BrokerageId)
                    .HasColumnName("brokerage_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("template_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplatetobrokerageTimestamp)
                    .HasColumnName("templatetobrokerage_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.HasOne(d => d.Brokerage)
                    .WithMany(p => p.NewslettersTemplatesToBrokerages)
                    .HasForeignKey(d => d.BrokerageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("newsletters_templates_to_brokerages_ibfk_2");

                entity.HasOne(d => d.Template)
                    .WithMany(p => p.NewslettersTemplatesToBrokerages)
                    .HasForeignKey(d => d.TemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("newsletters_templates_to_brokerages_ibfk_1");
            });

            modelBuilder.Entity<NewslettersTemplatesToCampaigns>(entity =>
            {
                entity.HasKey(e => e.TemplatetocampaignId);

                entity.ToTable("newsletters_templates_to_campaigns", "rezoradata");

                entity.HasIndex(e => new { e.TemplateId, e.CampaignId })
                    .HasName("template_id")
                    .IsUnique();

                entity.Property(e => e.TemplatetocampaignId)
                    .HasColumnName("templatetocampaign_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CampaignId)
                    .HasColumnName("campaign_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("template_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplatetocampaignTimestamp)
                    .HasColumnName("templatetocampaign_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<NewslettersTemplatesToCats>(entity =>
            {
                entity.HasKey(e => new { e.CatId, e.TemplateId });

                entity.ToTable("newsletters_templates_to_cats", "rezoradata");

                entity.Property(e => e.CatId)
                    .HasColumnName("cat_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("template_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<NewslettersTemplatesToDisplayads>(entity =>
            {
                entity.HasKey(e => e.TemplatetodisplayadId);

                entity.ToTable("newsletters_templates_to_displayads", "rezoradata");

                entity.HasIndex(e => e.TemplateId)
                    .HasName("template_id");

                entity.Property(e => e.TemplatetodisplayadId)
                    .HasColumnName("templatetodisplayad_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DisplayadImageFormat)
                    .IsRequired()
                    .HasColumnName("displayad_image_format")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("png");

                entity.Property(e => e.DisplayadImageLeft)
                    .HasColumnName("displayad_image_left")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DisplayadImageTop)
                    .HasColumnName("displayad_image_top")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DisplayadImageWidth)
                    .HasColumnName("displayad_image_width")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("400");

                entity.Property(e => e.SitescoutCreativeType)
                    .IsRequired()
                    .HasColumnName("sitescout_creative_type")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("banner");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("template_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<NewslettersTemplatesToJson>(entity =>
            {
                entity.HasKey(e => e.TemplateToJsonId);

                entity.ToTable("newsletters_templates_to_json", "rezoradata");

                entity.HasIndex(e => e.TemplateId)
                    .HasName("template_id");

                entity.Property(e => e.TemplateToJsonId)
                    .HasColumnName("template_to_json_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("template_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplateJson)
                    .IsRequired()
                    .HasColumnName("template_json")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.TemplateToJsonTimestamp)
                    .HasColumnName("template_to_json_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<NewslettersTemplatesToUsers>(entity =>
            {
                entity.HasKey(e => e.TemplatetouserId);

                entity.ToTable("newsletters_templates_to_users", "rezoradata");

                entity.HasIndex(e => new { e.TemplateId, e.UserId })
                    .HasName("template_id")
                    .IsUnique();

                entity.Property(e => e.TemplatetouserId)
                    .HasColumnName("templatetouser_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("template_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplatetouserTimestamp)
                    .HasColumnName("templatetouser_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<NewslettersTemplatesTypes>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.ToTable("newsletters_templates_types", "rezoradata");

                entity.HasIndex(e => e.TypeTitle)
                    .HasName("type_title");

                entity.Property(e => e.TypeId)
                    .HasColumnName("type_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TypeDate)
                    .HasColumnName("type_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TypeOrder)
                    .HasColumnName("type_order")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.TypeTitle)
                    .IsRequired()
                    .HasColumnName("type_title")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NewslettersToDisplayads>(entity =>
            {
                entity.HasKey(e => e.NewslettertodisplayadId);

                entity.ToTable("newsletters_to_displayads", "rezoradata");

                entity.HasIndex(e => e.NewsletterId)
                    .HasName("newsletter_id");

                entity.Property(e => e.NewslettertodisplayadId)
                    .HasColumnName("newslettertodisplayad_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DisplayadImageFormat)
                    .IsRequired()
                    .HasColumnName("displayad_image_format")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("png");

                entity.Property(e => e.DisplayadImageHeight)
                    .HasColumnName("displayad_image_height")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DisplayadImageLeft)
                    .HasColumnName("displayad_image_left")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DisplayadImagePath)
                    .IsRequired()
                    .HasColumnName("displayad_image_path")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayadImageTop)
                    .HasColumnName("displayad_image_top")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DisplayadImageWidth)
                    .HasColumnName("displayad_image_width")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("400");

                entity.Property(e => e.NewsletterId)
                    .HasColumnName("newsletter_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SitescoutAssetUrl)
                    .IsRequired()
                    .HasColumnName("sitescout_asset_url")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SitescoutCreativeId)
                    .HasColumnName("sitescout_creative_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SitescoutCreativeType)
                    .IsRequired()
                    .HasColumnName("sitescout_creative_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SitescoutReviewStatus)
                    .IsRequired()
                    .HasColumnName("sitescout_review_status")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NewslettersToListings>(entity =>
            {
                entity.HasKey(e => e.NewslettertolistingId);

                entity.ToTable("newsletters_to_listings", "rezoradata");

                entity.HasIndex(e => e.ListingId)
                    .HasName("property_id");

                entity.HasIndex(e => e.NewsletterId)
                    .HasName("newsletter_id");

                entity.HasIndex(e => e.NewslettertolistingOrder)
                    .HasName("newslettertolisting_order");

                entity.HasIndex(e => e.OrgId)
                    .HasName("org_id");

                entity.HasIndex(e => new { e.NewsletterId, e.NewslettertolistingOrder })
                    .HasName("newsletter_id_2")
                    .IsUnique();

                entity.HasIndex(e => new { e.OrgId, e.ListingId, e.ListingTypeId })
                    .HasName("org_id_2");

                entity.Property(e => e.NewslettertolistingId)
                    .HasColumnName("newslettertolisting_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ListingId)
                    .IsRequired()
                    .HasColumnName("listing_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.ListingTypeId)
                    .HasColumnName("listing_type_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("6");

                entity.Property(e => e.NewsletterId)
                    .HasColumnName("newsletter_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NewslettertolistingDate)
                    .HasColumnName("newslettertolisting_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.NewslettertolistingHeadline)
                    .HasColumnName("newslettertolisting_headline")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NewslettertolistingMessage)
                    .HasColumnName("newslettertolisting_message")
                    .IsUnicode(false);

                entity.Property(e => e.NewslettertolistingOrder)
                    .HasColumnName("newslettertolisting_order")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OrgId)
                    .IsRequired()
                    .HasColumnName("org_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Newsletter)
                    .WithMany(p => p.NewslettersToListings)
                    .HasForeignKey(d => d.NewsletterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("newsletters_to_listings_ibfk_1");
            });

            modelBuilder.Entity<NewslettersToListingsImage>(entity =>
            {
                entity.HasKey(e => e.NliId);

                entity.ToTable("newsletters_to_listings_image", "rezoradata");

                entity.Property(e => e.NliId)
                    .HasColumnName("nli_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ImagePosition)
                    .HasColumnName("image_position")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ListingId)
                    .IsRequired()
                    .HasColumnName("listing_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ListingNumber)
                    .HasColumnName("listing_number")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NewsletterId)
                    .HasColumnName("newsletter_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OrgId)
                    .IsRequired()
                    .HasColumnName("org_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UseImagePosition)
                    .HasColumnName("use_image_position")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<NewslettersToPchefprods>(entity =>
            {
                entity.HasKey(e => e.NewslettertoprodId);

                entity.ToTable("newsletters_to_pchefprods", "rezoradata");

                entity.HasIndex(e => e.NewsletterId)
                    .HasName("newsletter_id");

                entity.HasIndex(e => e.NewslettertoprodOrder)
                    .HasName("newslettertoprod_order");

                entity.HasIndex(e => e.ProdId)
                    .HasName("product_id");

                entity.HasIndex(e => new { e.NewsletterId, e.NewslettertoprodOrder })
                    .HasName("newsletter_id_2")
                    .IsUnique();

                entity.Property(e => e.NewslettertoprodId)
                    .HasColumnName("newslettertoprod_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NewsletterId)
                    .HasColumnName("newsletter_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NewslettertoprodDate)
                    .HasColumnName("newslettertoprod_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.NewslettertoprodHeadline)
                    .HasColumnName("newslettertoprod_headline")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NewslettertoprodMessage)
                    .HasColumnName("newslettertoprod_message")
                    .IsUnicode(false);

                entity.Property(e => e.NewslettertoprodOrder)
                    .HasColumnName("newslettertoprod_order")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProdId)
                    .HasColumnName("prod_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Newsletter)
                    .WithMany(p => p.NewslettersToPchefprods)
                    .HasForeignKey(d => d.NewsletterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("newsletters_to_pchefprods_ibfk_1");
            });

            modelBuilder.Entity<NewslettersToProds>(entity =>
            {
                entity.HasKey(e => e.NewslettertoprodId);

                entity.ToTable("newsletters_to_prods", "rezoradata");

                entity.HasIndex(e => e.NewsletterId)
                    .HasName("newsletter_id");

                entity.HasIndex(e => e.NewslettertoprodOrder)
                    .HasName("newslettertoprod_order");

                entity.HasIndex(e => e.ProdId)
                    .HasName("product_id");

                entity.HasIndex(e => new { e.NewsletterId, e.NewslettertoprodOrder })
                    .HasName("newsletter_id_2")
                    .IsUnique();

                entity.Property(e => e.NewslettertoprodId)
                    .HasColumnName("newslettertoprod_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NewsletterId)
                    .HasColumnName("newsletter_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NewslettertoprodDate)
                    .HasColumnName("newslettertoprod_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.NewslettertoprodHeadline)
                    .HasColumnName("newslettertoprod_headline")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NewslettertoprodMessage)
                    .HasColumnName("newslettertoprod_message")
                    .IsUnicode(false);

                entity.Property(e => e.NewslettertoprodOrder)
                    .HasColumnName("newslettertoprod_order")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProdId)
                    .IsRequired()
                    .HasColumnName("prod_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Newsletter)
                    .WithMany(p => p.NewslettersToProds)
                    .HasForeignKey(d => d.NewsletterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("newsletters_to_prods_ibfk_1");
            });

            modelBuilder.Entity<NewslettersToRsvpevent>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.ToTable("newsletters_to_rsvpevent", "rezoradata");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EventCapacity)
                    .HasColumnName("event_capacity")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EventChangeddate)
                    .HasColumnName("event_changeddate")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.EventCreateddate)
                    .HasColumnName("event_createddate")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.EventCurrency)
                    .IsRequired()
                    .HasColumnName("event_currency")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EventDescription)
                    .IsRequired()
                    .HasColumnName("event_description")
                    .IsUnicode(false);

                entity.Property(e => e.EventEnddate)
                    .HasColumnName("event_enddate")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.EventLogoUrl)
                    .HasColumnName("event_logo_url")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EventName)
                    .IsRequired()
                    .HasColumnName("event_name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EventOnline)
                    .HasColumnName("event_online")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EventStartdate)
                    .HasColumnName("event_startdate")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.EventStatus)
                    .IsRequired()
                    .HasColumnName("event_status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EventUrl)
                    .IsRequired()
                    .HasColumnName("event_url")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EventVenueAddr)
                    .IsRequired()
                    .HasColumnName("event_venue_addr")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EventVenueLat)
                    .IsRequired()
                    .HasColumnName("event_venue_lat")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EventVenueLon)
                    .IsRequired()
                    .HasColumnName("event_venue_lon")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EventVenueName)
                    .IsRequired()
                    .HasColumnName("event_venue_name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NewsletterId)
                    .HasColumnName("newsletter_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<NewslettersUsersSchedules>(entity =>
            {
                entity.HasKey(e => e.ScheduleId);

                entity.ToTable("newsletters_users_schedules", "rezoradata");

                entity.HasIndex(e => e.NewsletterId)
                    .HasName("newsletter_id");

                entity.HasIndex(e => e.ScheduleDatetime)
                    .HasName("schedule_datetime");

                entity.HasIndex(e => e.ScheduleSentdate)
                    .HasName("schedule_sentdate");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.ScheduleId)
                    .HasColumnName("schedule_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NewsletterId)
                    .HasColumnName("newsletter_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ScheduleDatetime).HasColumnName("schedule_datetime");

                entity.Property(e => e.ScheduleSentdate).HasColumnName("schedule_sentdate");

                entity.Property(e => e.ScheduleTimestamp)
                    .HasColumnName("schedule_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<PinterestLog>(entity =>
            {
                entity.HasKey(e => e.RzPostId);

                entity.ToTable("pinterest_log", "rezoradata");

                entity.HasIndex(e => e.ItemId)
                    .HasName("newsletter_id");

                entity.HasIndex(e => e.PPostId)
                    .HasName("p_post_id");

                entity.Property(e => e.RzPostId)
                    .HasColumnName("rz_post_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClickCount)
                    .HasColumnName("click_count")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId)
                    .HasColumnName("item_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OpenCount)
                    .HasColumnName("open_count")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PDescription)
                    .IsRequired()
                    .HasColumnName("p_description")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PImage)
                    .IsRequired()
                    .HasColumnName("p_image")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PPostId)
                    .HasColumnName("p_post_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PTitle)
                    .IsRequired()
                    .HasColumnName("p_title")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PotentialReach)
                    .HasColumnName("potential_reach")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RequestTimestamp)
                    .HasColumnName("request_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<ProductsLifevantage>(entity =>
            {
                entity.HasKey(e => e.ProdId);

                entity.ToTable("products_lifevantage", "rezoradata");

                entity.Property(e => e.ProdId)
                    .HasColumnName("prod_id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastImport)
                    .HasColumnName("last_import")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ProdDescLong)
                    .IsRequired()
                    .HasColumnName("prod_desc_long")
                    .IsUnicode(false);

                entity.Property(e => e.ProdDescShort)
                    .IsRequired()
                    .HasColumnName("prod_desc_short")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProdPhoto)
                    .IsRequired()
                    .HasColumnName("prod_photo")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProdPrice)
                    .HasColumnName("prod_price")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ProdTitle)
                    .IsRequired()
                    .HasColumnName("prod_title")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PublishStatus)
                    .HasColumnName("publish_status")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ProductsMiche>(entity =>
            {
                entity.HasKey(e => e.ProdId);

                entity.ToTable("products_miche", "rezoradata");

                entity.Property(e => e.ProdId)
                    .HasColumnName("prod_id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastImport)
                    .HasColumnName("last_import")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ProdDescLong)
                    .IsRequired()
                    .HasColumnName("prod_desc_long")
                    .IsUnicode(false);

                entity.Property(e => e.ProdDescShort)
                    .IsRequired()
                    .HasColumnName("prod_desc_short")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProdPhoto)
                    .IsRequired()
                    .HasColumnName("prod_photo")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProdPrice)
                    .HasColumnName("prod_price")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ProdTitle)
                    .IsRequired()
                    .HasColumnName("prod_title")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PublishStatus)
                    .HasColumnName("publish_status")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ProductsPchef>(entity =>
            {
                entity.HasKey(e => e.ProdId);

                entity.ToTable("products_pchef", "rezoradata");

                entity.Property(e => e.ProdId)
                    .HasColumnName("prod_id")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.LastImport)
                    .HasColumnName("last_import")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ProdDescLong)
                    .IsRequired()
                    .HasColumnName("prod_desc_long")
                    .IsUnicode(false);

                entity.Property(e => e.ProdDescShort)
                    .IsRequired()
                    .HasColumnName("prod_desc_short")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProdPrice)
                    .HasColumnName("prod_price")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ProdTitle)
                    .IsRequired()
                    .HasColumnName("prod_title")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PublishStatus)
                    .HasColumnName("publish_status")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ProductsPosh>(entity =>
            {
                entity.HasKey(e => e.ProdId);

                entity.ToTable("products_posh", "rezoradata");

                entity.Property(e => e.ProdId)
                    .HasColumnName("prod_id")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ClassCategory)
                    .IsRequired()
                    .HasColumnName("class_category")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExcludeFromBuyFive)
                    .IsRequired()
                    .HasColumnName("exclude_from_buy_five")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FillWeight)
                    .IsRequired()
                    .HasColumnName("fill_weight")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fragrance)
                    .IsRequired()
                    .HasColumnName("fragrance")
                    .IsUnicode(false);

                entity.Property(e => e.HowToUse)
                    .IsRequired()
                    .HasColumnName("how_to_use")
                    .IsUnicode(false);

                entity.Property(e => e.Ingredients)
                    .IsRequired()
                    .HasColumnName("ingredients")
                    .IsUnicode(false);

                entity.Property(e => e.LastImport)
                    .HasColumnName("last_import")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.PerkPurchase)
                    .IsRequired()
                    .HasColumnName("perk_purchase")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PerksOverrideCost).HasColumnName("perks_override_cost");

                entity.Property(e => e.PerksOverrideEarn).HasColumnName("perks_override_earn");

                entity.Property(e => e.ProdDescLong)
                    .IsRequired()
                    .HasColumnName("prod_desc_long")
                    .IsUnicode(false);

                entity.Property(e => e.ProdDescShort)
                    .IsRequired()
                    .HasColumnName("prod_desc_short")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProdPrice)
                    .HasColumnName("prod_price")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ProdSize)
                    .IsRequired()
                    .HasColumnName("prod_size")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProdSubtitle)
                    .IsRequired()
                    .HasColumnName("prod_subtitle")
                    .IsUnicode(false);

                entity.Property(e => e.ProdTitle)
                    .IsRequired()
                    .HasColumnName("prod_title")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PublishStatus)
                    .HasColumnName("publish_status")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TabDetails)
                    .IsRequired()
                    .HasColumnName("tab_details")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WhatDoesItDo)
                    .IsRequired()
                    .HasColumnName("what_does_it_do")
                    .IsUnicode(false);

                entity.Property(e => e.WhatIsIt)
                    .IsRequired()
                    .HasColumnName("what_is_it")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductsSchein>(entity =>
            {
                entity.HasKey(e => e.ProdId);

                entity.ToTable("products_schein", "rezoradata");

                entity.Property(e => e.ProdId)
                    .HasColumnName("prod_id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastImport)
                    .HasColumnName("last_import")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ProdManufacturer)
                    .IsRequired()
                    .HasColumnName("prod_manufacturer")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProdPhoto)
                    .IsRequired()
                    .HasColumnName("prod_photo")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProdPrice)
                    .HasColumnName("prod_price")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ProdTitle)
                    .IsRequired()
                    .HasColumnName("prod_title")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PublishStatus)
                    .HasColumnName("publish_status")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ProductsSwift>(entity =>
            {
                entity.HasKey(e => e.ProdId);

                entity.ToTable("products_swift", "rezoradata");

                entity.Property(e => e.ProdId)
                    .HasColumnName("prod_id")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.LastImport)
                    .HasColumnName("last_import")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ProdDescLong)
                    .IsRequired()
                    .HasColumnName("prod_desc_long")
                    .IsUnicode(false);

                entity.Property(e => e.ProdDescShort)
                    .IsRequired()
                    .HasColumnName("prod_desc_short")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProdPhoto)
                    .IsRequired()
                    .HasColumnName("prod_photo")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProdPrice)
                    .HasColumnName("prod_price")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ProdTitle)
                    .IsRequired()
                    .HasColumnName("prod_title")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PublishStatus)
                    .HasColumnName("publish_status")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PurgeRequest>(entity =>
            {
                entity.ToTable("purge_request", "rezoradata");

                entity.HasIndex(e => e.PurgeTypeId)
                    .HasName("purge_type_id");

                entity.HasIndex(e => new { e.EntityEmail, e.RelatedUserId })
                    .HasName("idx_entity_email_related_user_id");

                entity.Property(e => e.PurgeRequestId)
                    .HasColumnName("purge_request_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.EntityEmail)
                    .HasColumnName("entity_email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EntityId)
                    .IsRequired()
                    .HasColumnName("entity_id")
                    .HasColumnType("blob");

                entity.Property(e => e.PurgeTypeId)
                    .HasColumnName("purge_type_id")
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.RelatedUserId)
                    .HasColumnName("related_user_id")
                    .HasColumnType("int(11) unsigned");

                entity.HasOne(d => d.PurgeType)
                    .WithMany(p => p.PurgeRequest)
                    .HasForeignKey(d => d.PurgeTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("purge_request_ibfk_1");
            });

            modelBuilder.Entity<PurgeType>(entity =>
            {
                entity.ToTable("purge_type", "rezoradata");

                entity.Property(e => e.PurgeTypeId)
                    .HasColumnName("purge_type_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.PurgeType1)
                    .HasColumnName("purge_type")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Siragents>(entity =>
            {
                entity.ToTable("SIRAgents", "rezoradata");

                entity.HasIndex(e => e.Doctype)
                    .HasName("doctype");

                entity.HasIndex(e => e.Guid)
                    .HasName("guid");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Doctype)
                    .IsRequired()
                    .HasColumnName("doctype")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Document)
                    .IsRequired()
                    .HasColumnName("document")
                    .HasColumnType("blob");

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasColumnName("guid")
                    .HasMaxLength(72)
                    .IsUnicode(false);

                entity.Property(e => e.Processed)
                    .HasColumnName("processed")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SircommercialListings>(entity =>
            {
                entity.ToTable("SIRCommercialListings", "rezoradata");

                entity.HasIndex(e => e.Doctype)
                    .HasName("doctype");

                entity.HasIndex(e => e.Guid)
                    .HasName("guid");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Doctype)
                    .IsRequired()
                    .HasColumnName("doctype")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Document)
                    .IsRequired()
                    .HasColumnName("document")
                    .HasColumnType("blob");

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasColumnName("guid")
                    .HasMaxLength(72)
                    .IsUnicode(false);

                entity.Property(e => e.Processed)
                    .HasColumnName("processed")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SircorpStaff>(entity =>
            {
                entity.ToTable("SIRCorpStaff", "rezoradata");

                entity.HasIndex(e => e.Doctype)
                    .HasName("doctype");

                entity.HasIndex(e => e.Guid)
                    .HasName("guid");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Doctype)
                    .IsRequired()
                    .HasColumnName("doctype")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Document)
                    .IsRequired()
                    .HasColumnName("document")
                    .HasColumnType("blob");

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasColumnName("guid")
                    .HasMaxLength(72)
                    .IsUnicode(false);

                entity.Property(e => e.Processed)
                    .HasColumnName("processed")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Sirmeta0>(entity =>
            {
                entity.HasKey(e => new { e.ListingId, e.Key });

                entity.ToTable("SIRMeta_0", "rezoradata");

                entity.HasIndex(e => e.ListingId)
                    .HasName("guid");

                entity.HasIndex(e => new { e.Key, e.Value })
                    .HasName("idx_key_value");

                entity.Property(e => e.ListingId)
                    .HasColumnName("listing_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .HasMaxLength(72)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<Sirmeta1>(entity =>
            {
                entity.HasKey(e => new { e.ListingId, e.Key });

                entity.ToTable("SIRMeta_1", "rezoradata");

                entity.HasIndex(e => e.ListingId)
                    .HasName("guid");

                entity.HasIndex(e => new { e.Key, e.Value })
                    .HasName("idx_key_value");

                entity.Property(e => e.ListingId)
                    .HasColumnName("listing_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .HasMaxLength(72)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<Sirmeta2>(entity =>
            {
                entity.HasKey(e => new { e.ListingId, e.Key });

                entity.ToTable("SIRMeta_2", "rezoradata");

                entity.HasIndex(e => e.ListingId)
                    .HasName("guid");

                entity.HasIndex(e => new { e.Key, e.Value })
                    .HasName("idx_key_value");

                entity.Property(e => e.ListingId)
                    .HasColumnName("listing_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .HasMaxLength(72)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<SirnonSales>(entity =>
            {
                entity.ToTable("SIRNonSales", "rezoradata");

                entity.HasIndex(e => e.Doctype)
                    .HasName("doctype");

                entity.HasIndex(e => e.Guid)
                    .HasName("guid");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Doctype)
                    .IsRequired()
                    .HasColumnName("doctype")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Document)
                    .IsRequired()
                    .HasColumnName("document")
                    .HasColumnType("blob");

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasColumnName("guid")
                    .HasMaxLength(72)
                    .IsUnicode(false);

                entity.Property(e => e.Processed)
                    .HasColumnName("processed")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Siroffice>(entity =>
            {
                entity.ToTable("SIROffice", "rezoradata");

                entity.HasIndex(e => e.Doctype)
                    .HasName("doctype");

                entity.HasIndex(e => e.Guid)
                    .HasName("guid");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Doctype)
                    .IsRequired()
                    .HasColumnName("doctype")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Document)
                    .IsRequired()
                    .HasColumnName("document")
                    .HasColumnType("blob");

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasColumnName("guid")
                    .HasMaxLength(72)
                    .IsUnicode(false);

                entity.Property(e => e.Processed)
                    .HasColumnName("processed")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SirotherFiles>(entity =>
            {
                entity.ToTable("SIROtherFiles", "rezoradata");

                entity.HasIndex(e => e.Doctype)
                    .HasName("doctype");

                entity.HasIndex(e => e.Guid)
                    .HasName("guid");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Doctype)
                    .IsRequired()
                    .HasColumnName("doctype")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Document)
                    .IsRequired()
                    .HasColumnName("document")
                    .HasColumnType("blob");

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasColumnName("guid")
                    .HasMaxLength(72)
                    .IsUnicode(false);

                entity.Property(e => e.Processed)
                    .HasColumnName("processed")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SirresidentialListings>(entity =>
            {
                entity.ToTable("SIRResidentialListings", "rezoradata");

                entity.HasIndex(e => e.Doctype)
                    .HasName("doctype");

                entity.HasIndex(e => e.Guid)
                    .HasName("guid");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Doctype)
                    .IsRequired()
                    .HasColumnName("doctype")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Document)
                    .IsRequired()
                    .HasColumnName("document")
                    .HasColumnType("blob");

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasColumnName("guid")
                    .HasMaxLength(72)
                    .IsUnicode(false);

                entity.Property(e => e.Processed)
                    .HasColumnName("processed")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SirstaticCodes>(entity =>
            {
                entity.ToTable("SIRStaticCodes", "rezoradata");

                entity.HasIndex(e => e.Doctype)
                    .HasName("doctype");

                entity.HasIndex(e => e.Guid)
                    .HasName("guid");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Doctype)
                    .IsRequired()
                    .HasColumnName("doctype")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Document)
                    .IsRequired()
                    .HasColumnName("document")
                    .HasColumnType("blob");

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasColumnName("guid")
                    .HasMaxLength(72)
                    .IsUnicode(false);

                entity.Property(e => e.Processed)
                    .HasColumnName("processed")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Sirteam>(entity =>
            {
                entity.ToTable("SIRTeam", "rezoradata");

                entity.HasIndex(e => e.Doctype)
                    .HasName("doctype");

                entity.HasIndex(e => e.Guid)
                    .HasName("guid");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Doctype)
                    .IsRequired()
                    .HasColumnName("doctype")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Document)
                    .IsRequired()
                    .HasColumnName("document")
                    .HasColumnType("blob");

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasColumnName("guid")
                    .HasMaxLength(72)
                    .IsUnicode(false);

                entity.Property(e => e.Processed)
                    .HasColumnName("processed")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SothebysAffiliates>(entity =>
            {
                entity.HasKey(e => e.AffiliateId);

                entity.ToTable("sothebys_affiliates", "rezoradata");

                entity.Property(e => e.AffiliateId)
                    .HasColumnName("affiliate_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AffiliateName)
                    .IsRequired()
                    .HasColumnName("affiliate_name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AffiliateTheme)
                    .IsRequired()
                    .HasColumnName("affiliate_theme")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BrokerageId)
                    .HasColumnName("brokerage_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ThumbnailsLog>(entity =>
            {
                entity.HasKey(e => e.RequestId);

                entity.ToTable("thumbnails_log", "rezoradata");

                entity.Property(e => e.RequestId)
                    .HasColumnName("request_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RequestStatus)
                    .HasColumnName("request_status")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RequestTimestamp)
                    .HasColumnName("request_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ResponseJson)
                    .IsRequired()
                    .HasColumnName("response_json")
                    .IsUnicode(false);

                entity.Property(e => e.ResponseJsonInitial)
                    .IsRequired()
                    .HasColumnName("response_json_initial")
                    .IsUnicode(false);

                entity.Property(e => e.ResponseThumbnailPath)
                    .IsRequired()
                    .HasColumnName("response_thumbnail_path")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseTimestamp).HasColumnName("response_timestamp");

                entity.Property(e => e.ThumbnailId)
                    .HasColumnName("thumbnail_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ThumbnailType)
                    .HasColumnName("thumbnail_type")
                    .HasMaxLength(17)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TwitterLog>(entity =>
            {
                entity.HasKey(e => e.RzPostId);

                entity.ToTable("twitter_log", "rezoradata");

                entity.HasIndex(e => e.ItemId)
                    .HasName("newsletter_id");

                entity.HasIndex(e => e.TwPostId)
                    .HasName("fb_post_id");

                entity.Property(e => e.RzPostId)
                    .HasColumnName("rz_post_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClickCount)
                    .HasColumnName("click_count")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ItemId)
                    .HasColumnName("item_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OpenCount)
                    .HasColumnName("open_count")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PotentialReach)
                    .HasColumnName("potential_reach")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RequestTimestamp)
                    .HasColumnName("request_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TwDescription)
                    .IsRequired()
                    .HasColumnName("tw_description")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TwImage)
                    .IsRequired()
                    .HasColumnName("tw_image")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TwPostId)
                    .HasColumnName("tw_post_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TwTitle)
                    .IsRequired()
                    .HasColumnName("tw_title")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserActions>(entity =>
            {
                entity.HasKey(e => e.ActionId);

                entity.ToTable("user_actions", "rezoradata");

                entity.Property(e => e.ActionId)
                    .HasColumnName("action_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasColumnName("action")
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserLoginNonce>(entity =>
            {
                entity.HasKey(e => e.NonceId);

                entity.ToTable("user_login_nonce", "rezoradata");

                entity.HasIndex(e => e.NonceKey)
                    .HasName("idx_nonce_key");

                entity.Property(e => e.NonceId)
                    .HasColumnName("nonce_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.ExpireDate)
                    .HasColumnName("expire_date")
                    .HasDefaultValueSql("0000-00-00 00:00:00");

                entity.Property(e => e.NonceKey)
                    .IsRequired()
                    .HasColumnName("nonce_key")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.NonceType)
                    .IsRequired()
                    .HasColumnName("nonce_type")
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasDefaultValueSql("user");

                entity.Property(e => e.OwnerId)
                    .HasColumnName("owner_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<UserNotifications>(entity =>
            {
                entity.HasKey(e => e.NotificationId);

                entity.ToTable("user_notifications", "rezoradata");

                entity.Property(e => e.NotificationId)
                    .HasColumnName("notification_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.NotificationType)
                    .IsRequired()
                    .HasColumnName("notification_type")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("users", "rezoradata");

                entity.HasIndex(e => e.BrokerageId)
                    .HasName("brokerage_id");

                entity.HasIndex(e => e.UserDirectoryHidden)
                    .HasName("user_directory_hidden");

                entity.HasIndex(e => e.UserEmail)
                    .HasName("user_email")
                    .IsUnique();

                entity.HasIndex(e => e.UserPassword)
                    .HasName("user_password");

                entity.HasIndex(e => e.UserReportDaily)
                    .HasName("user_report_interval");

                entity.HasIndex(e => e.UserReportMonthly)
                    .HasName("user_report_monthly");

                entity.HasIndex(e => e.UserReportWeekly)
                    .HasName("user_report_weekly");

                entity.HasIndex(e => e.UserSitename)
                    .HasName("user_sitename");

                entity.HasIndex(e => e.UserSsoUid)
                    .HasName("user_sso_uid");

                entity.HasIndex(e => e.UserStatusId)
                    .HasName("user_status_id");

                entity.HasIndex(e => e.UserTypeId)
                    .HasName("user_type_id");

                entity.HasIndex(e => new { e.UserStatusId, e.UserTypeId, e.BrokerageId })
                    .HasName("user_status_id_2");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AmemberId)
                    .HasColumnName("amember_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AmemberLogin)
                    .IsRequired()
                    .HasColumnName("amember_login")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AmemberPassword)
                    .IsRequired()
                    .HasColumnName("amember_password")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BrokerageEmployeeId)
                    .IsRequired()
                    .HasColumnName("brokerage_employee_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BrokerageId)
                    .HasColumnName("brokerage_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.TempImage)
                    .IsRequired()
                    .HasColumnName("temp_image")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TempMlsAgentids)
                    .IsRequired()
                    .HasColumnName("temp_mls_agentids")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TempMlsOrgids)
                    .IsRequired()
                    .HasColumnName("temp_mls_orgids")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserAddonEnhancedContacts)
                    .HasColumnName("user_addon_enhanced_contacts")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserAllowAssume)
                    .HasColumnName("user_allow_assume")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserBio)
                    .IsRequired()
                    .HasColumnName("user_bio")
                    .IsUnicode(false);

                entity.Property(e => e.UserBlog)
                    .IsRequired()
                    .HasColumnName("user_blog")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserCompanyCity)
                    .IsRequired()
                    .HasColumnName("user_company_city")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserCompanyCountry)
                    .IsRequired()
                    .HasColumnName("user_company_country")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserCompanyLogoPath)
                    .IsRequired()
                    .HasColumnName("user_company_logo_path")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserCompanyLogoPathAlt)
                    .IsRequired()
                    .HasColumnName("user_company_logo_path_alt")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserCompanyName)
                    .IsRequired()
                    .HasColumnName("user_company_name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UserCompanyState)
                    .IsRequired()
                    .HasColumnName("user_company_state")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UserCompanyStreet)
                    .IsRequired()
                    .HasColumnName("user_company_street")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserCompanySuite)
                    .IsRequired()
                    .HasColumnName("user_company_suite")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserCompanyWebsite)
                    .IsRequired()
                    .HasColumnName("user_company_website")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserCompanyZip)
                    .IsRequired()
                    .HasColumnName("user_company_zip")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserCrmDups)
                    .IsRequired()
                    .HasColumnName("user_crm_dups")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserCrmEmail)
                    .IsRequired()
                    .HasColumnName("user_crm_email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserCrmId)
                    .IsRequired()
                    .HasColumnName("user_crm_id")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserCrmSyncTimestamp).HasColumnName("user_crm_sync_timestamp");

                entity.Property(e => e.UserDate)
                    .HasColumnName("user_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserDirectoryHidden)
                    .HasColumnName("user_directory_hidden")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserDre)
                    .IsRequired()
                    .HasColumnName("user_dre")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UserEbToken)
                    .IsRequired()
                    .HasColumnName("user_eb_token")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserEmail)
                    .IsRequired()
                    .HasColumnName("user_email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserEmailWork)
                    .IsRequired()
                    .HasColumnName("user_email_work")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserFacebook)
                    .IsRequired()
                    .HasColumnName("user_facebook")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserFname)
                    .HasColumnName("user_fname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserGoogleplus)
                    .IsRequired()
                    .HasColumnName("user_googleplus")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserHomeCity)
                    .IsRequired()
                    .HasColumnName("user_home_city")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserHomeState)
                    .IsRequired()
                    .HasColumnName("user_home_state")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UserHomeStreet)
                    .IsRequired()
                    .HasColumnName("user_home_street")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserHomeSuite)
                    .IsRequired()
                    .HasColumnName("user_home_suite")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserHomeZip)
                    .IsRequired()
                    .HasColumnName("user_home_zip")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserInstagram)
                    .IsRequired()
                    .HasColumnName("user_instagram")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserLanguage)
                    .IsRequired()
                    .HasColumnName("user_language")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.UserLinkedin)
                    .IsRequired()
                    .HasColumnName("user_linkedin")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserLname)
                    .IsRequired()
                    .HasColumnName("user_lname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserMattEnabled)
                    .HasColumnName("user_matt_enabled")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.UserObserver)
                    .HasColumnName("user_observer")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasColumnName("user_password")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserPhoneFax)
                    .IsRequired()
                    .HasColumnName("user_phone_fax")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UserPhoneHome)
                    .IsRequired()
                    .HasColumnName("user_phone_home")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UserPhoneMobile)
                    .IsRequired()
                    .HasColumnName("user_phone_mobile")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UserPhoneWork)
                    .IsRequired()
                    .HasColumnName("user_phone_work")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UserPhotoPath)
                    .IsRequired()
                    .HasColumnName("user_photo_path")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserPinterest)
                    .IsRequired()
                    .HasColumnName("user_pinterest")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserPoEmail)
                    .IsRequired()
                    .HasColumnName("user_po_email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserReportDaily)
                    .HasColumnName("user_report_daily")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserReportMonthly)
                    .HasColumnName("user_report_monthly")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserReportUnsubscribes)
                    .HasColumnName("user_report_unsubscribes")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserReportWeekly)
                    .HasColumnName("user_report_weekly")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserRetargetingId)
                    .IsRequired()
                    .HasColumnName("user_retargeting_id")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserSitename)
                    .IsRequired()
                    .HasColumnName("user_sitename")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserSsoBypass)
                    .HasColumnName("user_sso_bypass")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserSsoUid)
                    .IsRequired()
                    .HasColumnName("user_sso_uid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserStatusId)
                    .HasColumnName("user_status_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.UserTagline)
                    .IsRequired()
                    .HasColumnName("user_tagline")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.UserTitle)
                    .IsRequired()
                    .HasColumnName("user_title")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UserTwitter)
                    .IsRequired()
                    .HasColumnName("user_twitter")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserTypeId)
                    .HasColumnName("user_type_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.UserWebsite)
                    .IsRequired()
                    .HasColumnName("user_website")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserYoutube)
                    .IsRequired()
                    .HasColumnName("user_youtube")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.UserStatus)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("users_ibfk_1");

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("users_ibfk_2");
            });

            modelBuilder.Entity<UsersAssumptions>(entity =>
            {
                entity.HasKey(e => e.AssumptionId);

                entity.ToTable("users_assumptions", "rezoradata");

                entity.HasIndex(e => e.AssumeeId)
                    .HasName("assumee_id");

                entity.HasIndex(e => e.AssumerId)
                    .HasName("assumer_id");

                entity.Property(e => e.AssumptionId)
                    .HasColumnName("assumption_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AssumeeId)
                    .HasColumnName("assumee_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AssumerId)
                    .HasColumnName("assumer_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AssumptionKey)
                    .IsRequired()
                    .HasColumnName("assumption_key")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AssumptionTimestamp)
                    .HasColumnName("assumption_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.AssumptionType)
                    .HasColumnName("assumption_type")
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UsersCrmsAccess>(entity =>
            {
                entity.HasKey(e => e.Userscrms);

                entity.ToTable("users_crms_access", "rezoradata");

                entity.Property(e => e.Userscrms)
                    .HasColumnName("userscrms")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AutoSyncId)
                    .HasColumnName("auto_sync_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CrmActive)
                    .HasColumnName("crm_active")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.CrmLastImport).HasColumnName("crm_last_import");

                entity.Property(e => e.CrmRestricted)
                    .HasColumnName("crm_restricted")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.CrmTypeId)
                    .HasColumnName("crm_type_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Token)
                    .HasColumnName("token")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<UsersExitsurveyOptions>(entity =>
            {
                entity.HasKey(e => e.OptionId);

                entity.ToTable("users_exitsurvey_options", "rezoradata");

                entity.Property(e => e.OptionId)
                    .HasColumnName("option_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OptionMessage)
                    .IsRequired()
                    .HasColumnName("option_message")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OptionOrder)
                    .HasColumnName("option_order")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OptionPublic)
                    .HasColumnName("option_public")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.OptionTypeId)
                    .HasColumnName("option_type_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<UsersExitsurveyResponses>(entity =>
            {
                entity.HasKey(e => e.ResponseId);

                entity.ToTable("users_exitsurvey_responses", "rezoradata");

                entity.Property(e => e.ResponseId)
                    .HasColumnName("response_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OptionId)
                    .HasColumnName("option_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ResponseDate)
                    .HasColumnName("response_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ResponseNps)
                    .HasColumnName("response_nps")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ResponseReason)
                    .HasColumnName("response_reason")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseTypeId)
                    .HasColumnName("response_type_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<UsersFbpages>(entity =>
            {
                entity.ToTable("users_fbpages", "rezoradata");

                entity.HasIndex(e => e.PageId)
                    .HasName("page_id")
                    .IsUnique();

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.UsersfbpagesId)
                    .HasColumnName("usersfbpages_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.ContactBusinessCity)
                    .HasColumnName("contact_business_city")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContactBusinessState)
                    .HasColumnName("contact_business_state")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContactBusinessStreet)
                    .HasColumnName("contact_business_street")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContactBusinessStreet2)
                    .HasColumnName("contact_business_street2")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContactBusinessZip)
                    .HasColumnName("contact_business_zip")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContactCompany)
                    .HasColumnName("contact_company")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContactHomeCity)
                    .HasColumnName("contact_home_city")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContactHomeState)
                    .HasColumnName("contact_home_state")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContactHomeStreet)
                    .HasColumnName("contact_home_street")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContactHomeStreet2)
                    .HasColumnName("contact_home_street2")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContactHomeZip)
                    .HasColumnName("contact_home_zip")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ContactPhoneFax)
                    .HasColumnName("contact_phone_fax")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContactPhoneHome)
                    .HasColumnName("contact_phone_home")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContactPhoneMobile)
                    .HasColumnName("contact_phone_mobile")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContactPhoneWork)
                    .HasColumnName("contact_phone_work")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContactTitle)
                    .HasColumnName("contact_title")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ListId)
                    .HasColumnName("list_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PageId)
                    .HasColumnName("page_id")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<UsersLog>(entity =>
            {
                entity.HasKey(e => e.ActivityId);

                entity.ToTable("users_log", "rezoradata");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.HasIndex(e => new { e.ActivityId, e.UserId })
                    .HasName("activity_id");

                entity.HasIndex(e => new { e.ActivityType, e.UserId, e.ActivityTimestamp })
                    .HasName("activity_timestamp");

                entity.Property(e => e.ActivityId)
                    .HasColumnName("activity_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActivityTimestamp)
                    .HasColumnName("activity_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ActivityType)
                    .IsRequired()
                    .HasColumnName("activity_type")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StatusNew)
                    .HasColumnName("status_new")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StatusOld)
                    .HasColumnName("status_old")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<UsersNotificationPrefs>(entity =>
            {
                entity.HasKey(e => e.NotificationPrefId);

                entity.ToTable("users_notification_prefs", "rezoradata");

                entity.Property(e => e.NotificationPrefId)
                    .HasColumnName("notification_pref_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Enabled)
                    .HasColumnName("enabled")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.EnabledDate)
                    .HasColumnName("enabled_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.NotificationId)
                    .HasColumnName("notification_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NotificationTypeId)
                    .HasColumnName("notification_type_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<UsersRanks>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("users_ranks", "rezoradata");

                entity.HasIndex(e => e.EmailCount)
                    .HasName("email_count");

                entity.HasIndex(e => e.RankNumber)
                    .HasName("rank_number");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.BounceRate).HasColumnName("bounce_rate");

                entity.Property(e => e.ClickRate).HasColumnName("click_rate");

                entity.Property(e => e.ContactCount)
                    .HasColumnName("contact_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EmailCount)
                    .HasColumnName("email_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EmailRate).HasColumnName("email_rate");

                entity.Property(e => e.LoginRate).HasColumnName("login_rate");

                entity.Property(e => e.NewsletterRate).HasColumnName("newsletter_rate");

                entity.Property(e => e.OpenRate).HasColumnName("open_rate");

                entity.Property(e => e.PostcardRate).HasColumnName("postcard_rate");

                entity.Property(e => e.RankNumber).HasColumnName("rank_number");

                entity.Property(e => e.RankPercentile).HasColumnName("rank_percentile");

                entity.Property(e => e.RankTimestamp)
                    .HasColumnName("rank_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.SpamRate).HasColumnName("spam_rate");
            });

            modelBuilder.Entity<UsersStatuses>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("users_statuses", "rezoradata");

                entity.Property(e => e.StatusId)
                    .HasColumnName("status_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StatusTitle)
                    .IsRequired()
                    .HasColumnName("status_title")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UsersToActions>(entity =>
            {
                entity.ToTable("users_to_actions", "rezoradata");

                entity.HasIndex(e => e.Action)
                    .HasName("gdpr_action");

                entity.HasIndex(e => new { e.UserId, e.Action })
                    .HasName("idx_user_id_action");

                entity.Property(e => e.UsersToActionsId)
                    .HasColumnName("users_to_actions_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.AcceptedTerms)
                    .HasColumnName("accepted_terms")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Action)
                    .HasColumnName("action")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.ActionNavigation)
                    .WithMany(p => p.UsersToActions)
                    .HasForeignKey(d => d.Action)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("users_to_actions_ibfk_1");
            });

            modelBuilder.Entity<UsersToAmember>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("users_to_amember", "rezoradata");

                entity.HasIndex(e => new { e.UserId, e.MemberId })
                    .HasName("idx_user_id_member_id");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MemberId)
                    .HasColumnName("member_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<UsersToCampaigns>(entity =>
            {
                entity.HasKey(e => e.UsertocampaignId);

                entity.ToTable("users_to_campaigns", "rezoradata");

                entity.HasIndex(e => e.CampaignId)
                    .HasName("campaign_id");

                entity.HasIndex(e => e.Ignored)
                    .HasName("ignore");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.HasIndex(e => new { e.UserId, e.CampaignId })
                    .HasName("user_id_2");

                entity.Property(e => e.UsertocampaignId)
                    .HasColumnName("usertocampaign_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CampaignId)
                    .HasColumnName("campaign_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Ignored)
                    .HasColumnName("ignored")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UsertocampaignTimestamp)
                    .HasColumnName("usertocampaign_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<UsersToContacts>(entity =>
            {
                entity.HasKey(e => e.UsertocontactId);

                entity.ToTable("users_to_contacts", "rezoradata");

                entity.HasIndex(e => e.ContactId)
                    .HasName("contact_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.HasIndex(e => e.UsertocontactNew)
                    .HasName("usertocontact_new");

                entity.HasIndex(e => e.UsertocontactShareActivity)
                    .HasName("usertocontact_seeall");

                entity.HasIndex(e => e.UsertocontactUnsubscribe)
                    .HasName("usertocontact_unsubscribe");

                entity.HasIndex(e => new { e.ContactId, e.UsertocontactShareActivity })
                    .HasName("contact_id_2");

                entity.Property(e => e.UsertocontactId)
                    .HasColumnName("usertocontact_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UsertocontactNew)
                    .HasColumnName("usertocontact_new")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.UsertocontactShareActivity)
                    .HasColumnName("usertocontact_share_activity")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UsertocontactTimestamp)
                    .HasColumnName("usertocontact_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UsertocontactUnsubscribe)
                    .HasColumnName("usertocontact_unsubscribe")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.UsersToContacts)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("users_to_contacts_ibfk_2");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersToContacts)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("users_to_contacts_ibfk_1");
            });

            modelBuilder.Entity<UsersToCrms>(entity =>
            {
                entity.HasKey(e => e.UtcrmId);

                entity.ToTable("users_to_crms", "rezoradata");

                entity.Property(e => e.UtcrmId)
                    .HasColumnName("utcrm_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BtcrmId)
                    .HasColumnName("btcrm_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UtcrmTimestamp).HasColumnName("utcrm_timestamp");
            });

            modelBuilder.Entity<UsersToElements>(entity =>
            {
                entity.HasKey(e => e.UteId);

                entity.ToTable("users_to_elements", "rezoradata");

                entity.HasIndex(e => new { e.UserId, e.BteId })
                    .HasName("group_id");

                entity.Property(e => e.UteId)
                    .HasColumnName("ute_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.BteId)
                    .HasColumnName("bte_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UteTimestamp)
                    .HasColumnName("ute_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<UsersToGroups>(entity =>
            {
                entity.HasKey(e => e.UsertogroupId);

                entity.ToTable("users_to_groups", "rezoradata");

                entity.HasIndex(e => e.GroupId)
                    .HasName("idx_group_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("idx_user_id");

                entity.HasIndex(e => new { e.UserId, e.GroupId })
                    .HasName("user_id")
                    .IsUnique();

                entity.Property(e => e.UsertogroupId)
                    .HasColumnName("usertogroup_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UsertogroupTimestamp)
                    .HasColumnName("usertogroup_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<UsersToMlsAgents>(entity =>
            {
                entity.HasKey(e => e.UsertomlsagentId);

                entity.ToTable("users_to_mls_agents", "rezoradata");

                entity.HasIndex(e => e.AgentId)
                    .HasName("agent_id");

                entity.HasIndex(e => e.OrgId)
                    .HasName("org_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.HasIndex(e => new { e.OrgId, e.AgentId })
                    .HasName("org_id_2");

                entity.HasIndex(e => new { e.OrgId, e.AgentId, e.NotifyOnChange, e.UserId })
                    .HasName("notify");

                entity.Property(e => e.UsertomlsagentId)
                    .HasColumnName("usertomlsagent_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AgentId)
                    .IsRequired()
                    .HasColumnName("agent_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.NotifyOnChange)
                    .HasColumnName("notify_on_change")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.OrgId)
                    .IsRequired()
                    .HasColumnName("org_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UsertomlsagentTimestamp)
                    .HasColumnName("usertomlsagent_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersToMlsAgents)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("users_to_mls_agents_ibfk_1");
            });

            modelBuilder.Entity<UsersToMlsOffices>(entity =>
            {
                entity.HasKey(e => e.UsertomlsofficeId);

                entity.ToTable("users_to_mls_offices", "rezoradata");

                entity.HasIndex(e => e.OfficeId)
                    .HasName("office_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.HasIndex(e => new { e.OrgId, e.OfficeId })
                    .HasName("org_id");

                entity.Property(e => e.UsertomlsofficeId)
                    .HasColumnName("usertomlsoffice_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OfficeId)
                    .IsRequired()
                    .HasColumnName("office_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.OrgId)
                    .IsRequired()
                    .HasColumnName("org_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UsertomlsofficeTimestamp)
                    .HasColumnName("usertomlsoffice_timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersToMlsOffices)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("users_to_mls_offices_ibfk_1");
            });

            modelBuilder.Entity<UsersToSitescoutAudiences>(entity =>
            {
                entity.HasKey(e => e.UserSitescoutAudienceId);

                entity.ToTable("users_to_sitescout_audiences", "rezoradata");

                entity.Property(e => e.UserSitescoutAudienceId)
                    .HasColumnName("user_sitescout_audience_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.AudienceDefault)
                    .HasColumnName("audience_default")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AudienceType)
                    .HasColumnName("audience_type")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SitescoutAudienceId)
                    .HasColumnName("sitescout_audience_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SitescoutAudienceTag)
                    .HasColumnName("sitescout_audience_tag")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubscriptionEnabled)
                    .HasColumnName("subscription_enabled")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.SubscriptionType)
                    .HasColumnName("subscription_type")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<UsersToSitescoutCampaigns>(entity =>
            {
                entity.HasKey(e => e.UserSitescoutCampaignId);

                entity.ToTable("users_to_sitescout_campaigns", "rezoradata");

                entity.HasIndex(e => e.AmemberProductId)
                    .HasName("amember_product_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.HasIndex(e => new { e.UserId, e.AmemberProductId })
                    .HasName("user_id_2");

                entity.HasIndex(e => new { e.UserId, e.DisplayAds })
                    .HasName("user_id_3");

                entity.Property(e => e.UserSitescoutCampaignId)
                    .HasColumnName("user_sitescout_campaign_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.AmemberProductId)
                    .HasColumnName("amember_product_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CampaignEnabled)
                    .HasColumnName("campaign_enabled")
                    .HasColumnType("int(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CampaignName)
                    .HasColumnName("campaign_name")
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasDefaultValueSql("Campaign");

                entity.Property(e => e.CampaignUrl)
                    .HasColumnName("campaign_url")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultCampaign)
                    .HasColumnName("default_campaign")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DisplayAds)
                    .IsRequired()
                    .HasColumnName("display_ads")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SitescoutCampaignId)
                    .HasColumnName("sitescout_campaign_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<UsersTypes>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.ToTable("users_types", "rezoradata");

                entity.Property(e => e.TypeId)
                    .HasColumnName("type_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasColumnName("type_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserToAmemberSub>(entity =>
            {
                entity.HasKey(e => e.SubId);

                entity.ToTable("user_to_amember_sub", "rezoradata");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.HasIndex(e => new { e.UserId, e.AmemberProductId })
                    .HasName("user_id_product_id");

                entity.Property(e => e.SubId)
                    .HasColumnName("sub_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.AmemberProductId)
                    .HasColumnName("amember_product_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.LastModified)
                    .HasColumnName("last_modified")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<UserToSms>(entity =>
            {
                entity.ToTable("user_to_sms", "rezoradata");

                entity.HasIndex(e => e.MobileNumber)
                    .HasName("idx_mobile_number");

                entity.Property(e => e.UsertosmsId)
                    .HasColumnName("usertosms_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Accepted)
                    .HasColumnName("accepted")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.MobileNumber)
                    .IsRequired()
                    .HasColumnName("mobile_number")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<WellcomematImportLog>(entity =>
            {
                entity.HasKey(e => e.WellcomematImportId);

                entity.ToTable("wellcomemat_import_log", "rezoradata");

                entity.Property(e => e.WellcomematImportId)
                    .HasColumnName("wellcomemat_import_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.ImportDbEnd).HasColumnName("import_db_end");

                entity.Property(e => e.ImportDbStart).HasColumnName("import_db_start");

                entity.Property(e => e.ImportError)
                    .HasColumnName("import_error")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ImportMediaEnd).HasColumnName("import_media_end");

                entity.Property(e => e.ImportMediaStart).HasColumnName("import_media_start");

                entity.Property(e => e.ImportMediaTotalCount)
                    .HasColumnName("import_media_total_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ImportMediaValidCount)
                    .HasColumnName("import_media_valid_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LoadMediaEnd).HasColumnName("load_media_end");

                entity.Property(e => e.LoadMediaStart).HasColumnName("load_media_start");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WellcomematMedia>(entity =>
            {
                entity.HasKey(e => e.Hash);

                entity.ToTable("wellcomemat_media", "rezoradata");

                entity.HasIndex(e => e.ListingId)
                    .HasName("listing_id");

                entity.HasIndex(e => e.Replaced)
                    .HasName("replaced");

                entity.Property(e => e.Hash)
                    .HasColumnName("hash")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Customid)
                    .HasColumnName("customid")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ImageHash)
                    .HasColumnName("image_hash")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImageHttpUrl)
                    .HasColumnName("image_http_url")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ImageIcon)
                    .HasColumnName("image_icon")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImageLarge)
                    .HasColumnName("image_large")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImageMedium)
                    .HasColumnName("image_medium")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImagePlay)
                    .HasColumnName("image_play")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImageSmall)
                    .HasColumnName("image_small")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImageSquare)
                    .HasColumnName("image_square")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImageThumbnail)
                    .HasColumnName("image_thumbnail")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImageThumbnail16x9)
                    .HasColumnName("image_thumbnail_16x9")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Keywords)
                    .HasColumnName("keywords")
                    .HasMaxLength(65)
                    .IsUnicode(false);

                entity.Property(e => e.ListingId)
                    .HasColumnName("listing_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.LocationAddress)
                    .HasColumnName("location_address")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCity)
                    .HasColumnName("location_city")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationLatitude)
                    .HasColumnName("location_latitude")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationLongitude)
                    .HasColumnName("location_longitude")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationPostalCode)
                    .HasColumnName("location_postal_code")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.LocationStateProvince)
                    .HasColumnName("location_state_province")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Original)
                    .HasColumnName("original")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalHttpUrl)
                    .HasColumnName("original_http_url")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Replaced)
                    .HasColumnName("replaced")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Slideshow)
                    .HasColumnName("slideshow")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .HasColumnName("source")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCode)
                    .HasColumnName("status_code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusMessage)
                    .HasColumnName("status_message")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TrafficUrl)
                    .HasColumnName("traffic_url")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VideoHttpUrl)
                    .HasColumnName("video_http_url")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VideoType)
                    .HasColumnName("video_type")
                    .HasColumnType("int(11)");

                entity.Property(e => e.VideoV1080p)
                    .HasColumnName("video_v1080p")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VideoV270p)
                    .HasColumnName("video_v270p")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VideoV360p)
                    .HasColumnName("video_v360p")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VideoV480p)
                    .HasColumnName("video_v480p")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VideoV720p)
                    .HasColumnName("video_v720p")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WellcomematImportId)
                    .HasColumnName("wellcomemat_import_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Wm1Id)
                    .HasColumnName("wm1_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Workflows>(entity =>
            {
                entity.HasKey(e => e.WorkflowId);

                entity.ToTable("workflows", "rezoradata");

                entity.HasIndex(e => e.WorkflowTypeId)
                    .HasName("idx_mission_type_id");

                entity.HasIndex(e => new { e.UserId, e.Completed })
                    .HasName("user_id");

                entity.HasIndex(e => new { e.UserId, e.OrgId, e.ListingId, e.Completed })
                    .HasName("listing");

                entity.Property(e => e.WorkflowId)
                    .HasColumnName("workflow_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Completed).HasColumnName("completed");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ListingId)
                    .HasColumnName("listing_id")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ListingTypeId)
                    .HasColumnName("listing_type_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OrgId)
                    .HasColumnName("org_id")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.PdfTimestamp)
                    .IsRequired()
                    .HasColumnName("pdf_timestamp")
                    .IsUnicode(false);

                entity.Property(e => e.Steps)
                    .HasColumnName("steps")
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WorkflowName)
                    .HasColumnName("workflow_name")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.WorkflowTypeId)
                    .HasColumnName("workflow_type_id")
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WorkflowSteps>(entity =>
            {
                entity.HasKey(e => e.WorkflowStepId);

                entity.ToTable("workflow_steps", "rezoradata");

                entity.HasIndex(e => e.NewsletterId)
                    .HasName("idx_newsletter_id");

                entity.HasIndex(e => e.StepId)
                    .HasName("idx_step_id");

                entity.HasIndex(e => e.WorkflowId)
                    .HasName("idx_mission_id");

                entity.HasIndex(e => new { e.WorkflowId, e.Complete })
                    .HasName("idx_mission_id_complete");

                entity.HasIndex(e => new { e.WorkflowId, e.StepId })
                    .HasName("idx_mission_id_step_id");

                entity.Property(e => e.WorkflowStepId)
                    .HasColumnName("workflow_step_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Complete).HasColumnName("complete");

                entity.Property(e => e.MetaJson)
                    .HasColumnName("meta_json")
                    .HasColumnType("blob");

                entity.Property(e => e.NewsletterId)
                    .HasColumnName("newsletter_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StepId)
                    .HasColumnName("step_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WorkflowId)
                    .HasColumnName("workflow_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<WorkflowTemplates>(entity =>
            {
                entity.HasKey(e => e.WorkflowTemplateId);

                entity.ToTable("workflow_templates", "rezoradata");

                entity.HasIndex(e => new { e.BrokerageId, e.WorkflowTypeId, e.StepId })
                    .HasName("step");

                entity.Property(e => e.WorkflowTemplateId)
                    .HasColumnName("workflow_template_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BrokerageId)
                    .IsRequired()
                    .HasColumnName("brokerage_id")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.StepId)
                    .HasColumnName("step_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TemplateId)
                    .IsRequired()
                    .HasColumnName("template_id")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.WorkflowTypeId)
                    .IsRequired()
                    .HasColumnName("workflow_type_id")
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WorkflowTypes>(entity =>
            {
                entity.HasKey(e => e.TypeKeyword);

                entity.ToTable("workflow_types", "rezoradata");

                entity.HasIndex(e => e.TypeKeyword)
                    .HasName("keyword");

                entity.HasIndex(e => e.WorkflowTypeId)
                    .HasName("mission_type_id");

                entity.Property(e => e.TypeKeyword)
                    .HasColumnName("type_keyword")
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.BrokerageId)
                    .HasColumnName("brokerage_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.RequiresListing)
                    .HasColumnName("requires_listing")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Steps)
                    .HasColumnName("steps")
                    .HasColumnType("blob");

                entity.Property(e => e.TypeName)
                    .HasColumnName("type_name")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.UserStarted)
                    .HasColumnName("user_started")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.WorkflowTypeId)
                    .HasColumnName("workflow_type_id")
                    .HasColumnType("int(11)");
            });
        }
    }
}
