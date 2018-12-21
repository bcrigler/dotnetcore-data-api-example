using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class Workflows
    {
        public int WorkflowId { get; set; }
        public int UserId { get; set; }
        public string OrgId { get; set; }
        public string ListingId { get; set; }
        public int? ListingTypeId { get; set; }
        public DateTime? Completed { get; set; }
        public DateTime Created { get; set; }
        public string WorkflowTypeId { get; set; }
        public string Steps { get; set; }
        public string WorkflowName { get; set; }
        public string PdfTimestamp { get; set; }
    }
}
