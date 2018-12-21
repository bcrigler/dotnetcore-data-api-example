using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class CloudelementsLog
    {
        public int RequestId { get; set; }
        public DateTimeOffset RequestTimestamp { get; set; }
        public string RequestType { get; set; }
        public string RequestMethod { get; set; }
        public string ResponseStatus { get; set; }
        public string ResponseFormat { get; set; }
        public int RequesterId { get; set; }
    }
}
