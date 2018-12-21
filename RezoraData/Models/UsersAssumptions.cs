using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class UsersAssumptions
    {
        public int AssumptionId { get; set; }
        public string AssumptionKey { get; set; }
        public string AssumptionType { get; set; }
        public DateTimeOffset AssumptionTimestamp { get; set; }
        public int AssumerId { get; set; }
        public int AssumeeId { get; set; }
    }
}
