using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class MasterNewslettersToRsvpevent
    {
        public int EventId { get; set; }
        public int NewsletterId { get; set; }
        public string EventName { get; set; }
        public string EventDescription { get; set; }
        public string EventUrl { get; set; }
        public DateTime EventStartdate { get; set; }
        public DateTime EventEnddate { get; set; }
        public DateTime EventCreateddate { get; set; }
        public DateTime EventChangeddate { get; set; }
        public int EventCapacity { get; set; }
        public string EventStatus { get; set; }
        public string EventCurrency { get; set; }
        public int EventOnline { get; set; }
        public string EventVenueName { get; set; }
        public string EventVenueLon { get; set; }
        public string EventVenueLat { get; set; }
        public string EventVenueAddr { get; set; }
        public string EventLogoUrl { get; set; }
    }
}
