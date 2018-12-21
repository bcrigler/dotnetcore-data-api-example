using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class WorkflowTypes
    {
        public int WorkflowTypeId { get; set; }
        public string TypeName { get; set; }
        public string TypeKeyword { get; set; }
        public byte[] Steps { get; set; }
        public int? BrokerageId { get; set; }
        public int CategoryId { get; set; }
        public byte UserStarted { get; set; }
        public byte RequiresListing { get; set; }
    }
}
