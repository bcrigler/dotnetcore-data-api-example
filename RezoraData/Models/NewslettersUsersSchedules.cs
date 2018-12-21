using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class NewslettersUsersSchedules
    {
        public int ScheduleId { get; set; }
        public DateTimeOffset ScheduleTimestamp { get; set; }
        public int NewsletterId { get; set; }
        public int UserId { get; set; }
        public DateTime? ScheduleDatetime { get; set; }
        public DateTime? ScheduleSentdate { get; set; }
    }
}
