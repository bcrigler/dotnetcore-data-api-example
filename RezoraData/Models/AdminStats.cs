using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class AdminStats
    {
        public int StatsId { get; set; }
        public DateTimeOffset StatsTimestamp { get; set; }
        public int StatsUsersTotal { get; set; }
        public int StatsAgentsTotal { get; set; }
        public int StatsAgentsActive { get; set; }
        public int StatsAgentsInactive { get; set; }
        public int StatsAgentsTrial { get; set; }
        public int StatsAgentsActivation { get; set; }
        public int StatsAgentsComplimentary { get; set; }
        public int StatsConsumersTotal { get; set; }
        public int StatsBrokersTotal { get; set; }
        public int StatsEmails { get; set; }
        public int StatsOpens { get; set; }
        public int StatsClicks { get; set; }
    }
}
