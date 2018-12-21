using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class WorkflowTemplates
    {
        public int WorkflowTemplateId { get; set; }
        public string TemplateId { get; set; }
        public string BrokerageId { get; set; }
        public string WorkflowTypeId { get; set; }
        public int StepId { get; set; }
    }
}
