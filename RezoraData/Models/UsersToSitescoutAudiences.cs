using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class UsersToSitescoutAudiences
    {
        public int UserSitescoutAudienceId { get; set; }
        public int? UserId { get; set; }
        public int? SitescoutAudienceId { get; set; }
        public string SitescoutAudienceTag { get; set; }
        public int? AudienceDefault { get; set; }
        public byte SubscriptionEnabled { get; set; }
        public byte SubscriptionType { get; set; }
        public int AudienceType { get; set; }
    }
}
