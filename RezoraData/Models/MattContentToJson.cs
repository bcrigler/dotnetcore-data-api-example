using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class MattContentToJson
    {
        public int ContentToJsonId { get; set; }
        public DateTimeOffset ContentToJsonTimestamp { get; set; }
        public int ContentId { get; set; }
        public string ContentJson { get; set; }
    }
}
