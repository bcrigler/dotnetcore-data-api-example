using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class Groups
    {
        public int GroupId { get; set; }
        public DateTimeOffset GroupTimestamp { get; set; }
        public string GroupName { get; set; }
        public string GroupDescription { get; set; }
        public int BrokerageId { get; set; }
        public int GroupRestricted { get; set; }
    }
}
