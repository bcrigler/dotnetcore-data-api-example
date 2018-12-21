using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class ExternalPostingsLog
    {
        public int LogId { get; set; }
        public DateTimeOffset LogTimestamp { get; set; }
        public int PostingId { get; set; }

        public ExternalPostings Posting { get; set; }
    }
}
