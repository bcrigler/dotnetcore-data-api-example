using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class EmsCompositeMetrics
    {
        public long ContactId { get; set; }
        public int UserId { get; set; }
        public DateTime? LastProcessed { get; set; }
        public int? LastProcessedNewsletter { get; set; }
        public DateTime? LastDelivered { get; set; }
        public int? LastDeliveredNewsletter { get; set; }
        public DateTime? LastOpened { get; set; }
        public int? LastOpenedNewsletter { get; set; }
        public DateTime? LastClicked { get; set; }
        public int? LastClickedNewsletter { get; set; }
        public int TotalProcessed { get; set; }
        public int TotalDelivered { get; set; }
        public int TotalOpened { get; set; }
        public int TotalClicked { get; set; }
        public float? AciHours { get; set; }
        public byte? IsSunset { get; set; }
        public DateTime? SunsetDate { get; set; }
        public DateTime? SunriseDate { get; set; }
        public int? TotalSunsets { get; set; }
        public DateTime LastActivty { get; set; }
        public DateTime? LastCalculated { get; set; }
    }
}
