using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class GroupsToElements
    {
        public int GteId { get; set; }
        public int GroupId { get; set; }
        public int BteId { get; set; }
        public DateTimeOffset GteTimestamp { get; set; }
    }
}
