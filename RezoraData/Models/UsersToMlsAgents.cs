using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class UsersToMlsAgents
    {
        public int UsertomlsagentId { get; set; }
        public int UserId { get; set; }
        public string OrgId { get; set; }
        public string AgentId { get; set; }
        public DateTimeOffset UsertomlsagentTimestamp { get; set; }
        public byte NotifyOnChange { get; set; }

        public Users User { get; set; }
    }
}
