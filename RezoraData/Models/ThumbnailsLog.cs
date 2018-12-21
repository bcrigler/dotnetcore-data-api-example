using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class ThumbnailsLog
    {
        public int RequestId { get; set; }
        public DateTimeOffset RequestTimestamp { get; set; }
        public DateTimeOffset? ResponseTimestamp { get; set; }
        public string ThumbnailType { get; set; }
        public int? ThumbnailId { get; set; }
        public string ResponseThumbnailPath { get; set; }
        public string ResponseJsonInitial { get; set; }
        public string ResponseJson { get; set; }
        public byte RequestStatus { get; set; }
    }
}
