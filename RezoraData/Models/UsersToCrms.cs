using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class UsersToCrms
    {
        public int UtcrmId { get; set; }
        public int? UserId { get; set; }
        public int? BtcrmId { get; set; }
        public DateTimeOffset? UtcrmTimestamp { get; set; }
    }
}
