using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class MasterCampaignsToBrokerages
    {
        public int MastercampaigntobrokerageId { get; set; }
        public DateTimeOffset MastercampaigntobrokerageTimestamp { get; set; }
        public int CampaignId { get; set; }
        public int BrokerageId { get; set; }
    }
}
