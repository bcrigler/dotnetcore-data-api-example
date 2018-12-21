using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class MasterSchedules
    {
        public int ScheduleId { get; set; }
        public DateTimeOffset ScheduleTimestamp { get; set; }
        public int TemplateId { get; set; }
        public int BrandId { get; set; }
        public DateTime? ScheduleDatetime { get; set; }
        public string ScheduleMessage { get; set; }
        public string ScheduleSubject { get; set; }
        public DateTime? ScheduleExpiration { get; set; }
        public byte? ScheduleUseLocal { get; set; }
        public DateTime? ScheduleSentdate { get; set; }
        public DateTime? ScheduleStartdate { get; set; }
        public DateTime? ScheduleFinishdate { get; set; }
        public int OpenCount { get; set; }
        public int ClickCount { get; set; }
        public int BounceCount { get; set; }
        public int SpamCount { get; set; }
        public int EmailCount { get; set; }
        public byte ScheduleUseLocalTimezone { get; set; }
    }
}
