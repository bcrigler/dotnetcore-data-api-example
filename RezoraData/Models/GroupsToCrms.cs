using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class GroupsToCrms
    {
        public int GtcrmId { get; set; }
        public int? GroupId { get; set; }
        public int? BtcrmId { get; set; }
        public DateTimeOffset? GtcrmTimestamp { get; set; }
    }
}
