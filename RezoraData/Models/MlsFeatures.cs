using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class MlsFeatures
    {
        public string Type { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int? PublishStatus { get; set; }
        public DateTimeOffset LastUpdate { get; set; }
        public int LastImport { get; set; }
    }
}
