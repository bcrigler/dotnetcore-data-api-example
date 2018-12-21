using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class BrokeragesToElements
    {
        public int Brokeragestoelements1 { get; set; }
        public int BrokerageId { get; set; }
        public string Token { get; set; }
        public int? ElementTypeId { get; set; }
        public byte ElementRestricted { get; set; }
        public byte ElementActive { get; set; }
        public DateTimeOffset? ElementLastImport { get; set; }
    }
}
