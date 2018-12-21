using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class PurgeRequest
    {
        public int PurgeRequestId { get; set; }
        public int PurgeTypeId { get; set; }
        public byte[] EntityId { get; set; }
        public string EntityEmail { get; set; }
        public int? RelatedUserId { get; set; }

        public PurgeType PurgeType { get; set; }
    }
}
