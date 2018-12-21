using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class Users
    {
        public Users()
        {
            Contacts = new HashSet<Contacts>();
            ContactsLists = new HashSet<ContactsLists>();
            ContactsPending = new HashSet<ContactsPending>();
            Favorites = new HashSet<Favorites>();
            Newsletters = new HashSet<Newsletters>();
            UsersToContacts = new HashSet<UsersToContacts>();
            UsersToMlsAgents = new HashSet<UsersToMlsAgents>();
            UsersToMlsOffices = new HashSet<UsersToMlsOffices>();
        }

        public int UserId { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public int UserStatusId { get; set; }
        public int UserTypeId { get; set; }
        public string UserFname { get; set; }
        public string UserLname { get; set; }
        public string UserCompanyName { get; set; }
        public string UserTitle { get; set; }
        public string UserEmailWork { get; set; }
        public string UserWebsite { get; set; }
        public string UserBlog { get; set; }
        public string UserFacebook { get; set; }
        public string UserGoogleplus { get; set; }
        public string UserInstagram { get; set; }
        public string UserLinkedin { get; set; }
        public string UserPinterest { get; set; }
        public string UserTwitter { get; set; }
        public string UserYoutube { get; set; }
        public string UserPhoneWork { get; set; }
        public string UserPhoneHome { get; set; }
        public string UserPhoneMobile { get; set; }
        public string UserPhoneFax { get; set; }
        public string UserPhotoPath { get; set; }
        public string UserHomeStreet { get; set; }
        public string UserHomeSuite { get; set; }
        public string UserHomeCity { get; set; }
        public string UserHomeState { get; set; }
        public string UserHomeZip { get; set; }
        public string UserCompanyWebsite { get; set; }
        public string UserCompanyStreet { get; set; }
        public string UserCompanySuite { get; set; }
        public string UserCompanyCity { get; set; }
        public string UserCompanyState { get; set; }
        public string UserCompanyZip { get; set; }
        public string UserCompanyCountry { get; set; }
        public string UserCompanyLogoPath { get; set; }
        public string UserCompanyLogoPathAlt { get; set; }
        public string UserTagline { get; set; }
        public string UserBio { get; set; }
        public string UserCrmEmail { get; set; }
        public string UserCrmId { get; set; }
        public string UserCrmDups { get; set; }
        public DateTimeOffset? UserCrmSyncTimestamp { get; set; }
        public DateTimeOffset UserDate { get; set; }
        public int UserReportDaily { get; set; }
        public int UserReportWeekly { get; set; }
        public int UserReportMonthly { get; set; }
        public byte UserReportUnsubscribes { get; set; }
        public int UserAddonEnhancedContacts { get; set; }
        public string UserSitename { get; set; }
        public int UserDirectoryHidden { get; set; }
        public string UserSsoUid { get; set; }
        public byte UserSsoBypass { get; set; }
        public byte UserAllowAssume { get; set; }
        public string UserEbToken { get; set; }
        public string UserPoEmail { get; set; }
        public string UserRetargetingId { get; set; }
        public string UserDre { get; set; }
        public string UserLanguage { get; set; }
        public byte UserObserver { get; set; }
        public string AmemberLogin { get; set; }
        public string AmemberPassword { get; set; }
        public int? AmemberId { get; set; }
        public int BrokerageId { get; set; }
        public string BrokerageEmployeeId { get; set; }
        public string TempImage { get; set; }
        public string TempMlsAgentids { get; set; }
        public string TempMlsOrgids { get; set; }
        public byte UserMattEnabled { get; set; }

        public UsersStatuses UserStatus { get; set; }
        public UsersTypes UserType { get; set; }
        public ICollection<Contacts> Contacts { get; set; }
        public ICollection<ContactsLists> ContactsLists { get; set; }
        public ICollection<ContactsPending> ContactsPending { get; set; }
        public ICollection<Favorites> Favorites { get; set; }
        public ICollection<Newsletters> Newsletters { get; set; }
        public ICollection<UsersToContacts> UsersToContacts { get; set; }
        public ICollection<UsersToMlsAgents> UsersToMlsAgents { get; set; }
        public ICollection<UsersToMlsOffices> UsersToMlsOffices { get; set; }
    }
}
