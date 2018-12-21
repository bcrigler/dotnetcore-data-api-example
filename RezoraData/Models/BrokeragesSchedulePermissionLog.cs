using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class BrokeragesSchedulePermissionLog
    {
        public int LogId { get; set; }
        public DateTimeOffset? LogTimestamp { get; set; }
        public int? BrokerageId { get; set; }
        public int? ScheduleAllowed { get; set; }
        public int? UserId { get; set; }
    }
}
