using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class NewslettersSchedulesOptouts
    {
        public int OptoutId { get; set; }
        public DateTimeOffset OptoutTimestamp { get; set; }
        public int ScheduleId { get; set; }
        public int UserId { get; set; }
        public int TemplateId { get; set; }
        public int BrokerageId { get; set; }
    }
}
