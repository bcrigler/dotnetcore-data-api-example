using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class UsersLog
    {
        public int ActivityId { get; set; }
        public DateTimeOffset ActivityTimestamp { get; set; }
        public string ActivityType { get; set; }
        public int UserId { get; set; }
        public int StatusOld { get; set; }
        public int StatusNew { get; set; }
    }
}
