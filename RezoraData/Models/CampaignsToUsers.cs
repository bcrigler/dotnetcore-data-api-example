using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class CampaignsToUsers
    {
        public int CampaigntouserId { get; set; }
        public DateTimeOffset CampaigntouserTimestamp { get; set; }
        public int CampaignId { get; set; }
        public int UserId { get; set; }
    }
}
