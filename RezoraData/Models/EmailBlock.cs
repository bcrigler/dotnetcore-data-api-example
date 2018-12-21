using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class EmailBlock
    {
        public int BlockId { get; set; }
        public string BlockedAddress { get; set; }
        public int BlockType { get; set; }
        public int? BlockedUser { get; set; }
        public int? PurgeRequestId { get; set; }
    }
}
