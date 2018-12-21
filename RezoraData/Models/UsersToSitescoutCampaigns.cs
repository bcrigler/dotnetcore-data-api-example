using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class UsersToSitescoutCampaigns
    {
        public int UserSitescoutCampaignId { get; set; }
        public int? UserId { get; set; }
        public int? SitescoutCampaignId { get; set; }
        public int CampaignEnabled { get; set; }
        public int? AmemberProductId { get; set; }
        public string CampaignName { get; set; }
        public byte DefaultCampaign { get; set; }
        public byte Deleted { get; set; }
        public string CampaignUrl { get; set; }
        public string DisplayAds { get; set; }
    }
}
