using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class EmsUserAgent
    {
        public int EventId { get; set; }
        public DateTimeOffset EventTimestamp { get; set; }
        public DateTime? EventDatetime { get; set; }
        public string EventUserAgent { get; set; }
        public string EventReferer { get; set; }
        public string EventRemoteAddr { get; set; }
        public int? BrokerageId { get; set; }
        public int? ContactId { get; set; }
        public int? UserId { get; set; }
        public int? NewsletterId { get; set; }
        public int MobileAndroid { get; set; }
        public int MobileBlackberry { get; set; }
        public int MobileIphone { get; set; }
        public int MobileIpod { get; set; }
        public int MobileWindows { get; set; }
        public int MobileWebos { get; set; }
        public int TabletAndroid { get; set; }
        public int TabletIpad { get; set; }
        public int DesktopChrome { get; set; }
        public int DesktopLinux { get; set; }
        public int DesktopMac { get; set; }
        public int DesktopWindows { get; set; }
        public int Other { get; set; }
        public int? EmsSourceId { get; set; }
    }
}
