using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class MattSectionToJson
    {
        public int SectionToJsonId { get; set; }
        public DateTimeOffset SectionToJsonTimestamp { get; set; }
        public int SectionId { get; set; }
        public string SectionJson { get; set; }
    }
}
