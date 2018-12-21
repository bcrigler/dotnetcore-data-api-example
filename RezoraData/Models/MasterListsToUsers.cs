using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class MasterListsToUsers
    {
        public int MasterlisttouserId { get; set; }
        public DateTimeOffset? MasterlisttouserTimestamp { get; set; }
        public int? ListId { get; set; }
        public int? UserId { get; set; }
        public byte? ListIgnored { get; set; }
        public byte? ListAccepted { get; set; }
        public byte? FromGroup { get; set; }
        public byte Revoking { get; set; }
    }
}
