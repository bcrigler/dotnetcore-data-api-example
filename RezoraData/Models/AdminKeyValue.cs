using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class AdminKeyValue
    {
        public string Class { get; set; }
        public string Key { get; set; }
        public string Contents { get; set; }
        public string Type { get; set; }
        public int? Expires { get; set; }
    }
}
