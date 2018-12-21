using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class ApiLog
    {
        public int RequestId { get; set; }
        public DateTimeOffset RequestTimestamp { get; set; }
        public string RequestType { get; set; }
        public string RequestMethod { get; set; }
        public int ResponseStatus { get; set; }
        public string ResponseFormat { get; set; }
        public string RequesterType { get; set; }
        public int RequesterId { get; set; }
    }
}
