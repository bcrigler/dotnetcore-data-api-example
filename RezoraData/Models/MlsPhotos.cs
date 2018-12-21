using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class MlsPhotos
    {
        public string OrgId { get; set; }
        public string ListingId { get; set; }
        public string FileName { get; set; }
        public DateTime? FileDate { get; set; }
        public long FileOrder { get; set; }
        public int? PublishStatus { get; set; }
        public DateTimeOffset LastUpdate { get; set; }
        public int LastImport { get; set; }
    }
}
