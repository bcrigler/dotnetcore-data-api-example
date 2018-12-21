using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class PurgeType
    {
        public PurgeType()
        {
            PurgeRequest = new HashSet<PurgeRequest>();
        }

        public int PurgeTypeId { get; set; }
        public string PurgeType1 { get; set; }

        public ICollection<PurgeRequest> PurgeRequest { get; set; }
    }
}
