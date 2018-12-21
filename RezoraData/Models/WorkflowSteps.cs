using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class WorkflowSteps
    {
        public int WorkflowStepId { get; set; }
        public int WorkflowId { get; set; }
        public int StepId { get; set; }
        public DateTime? Complete { get; set; }
        public int? NewsletterId { get; set; }
        public byte[] MetaJson { get; set; }
    }
}
