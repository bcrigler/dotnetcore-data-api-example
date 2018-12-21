using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class MlsImportFailures
    {
        public int ImportFailureId { get; set; }
        public int ImportFileId { get; set; }
        public string OrgId { get; set; }
        public string ListingId { get; set; }
        public string ListingType { get; set; }
        public byte[] RawData { get; set; }
        public byte[] RawError { get; set; }
    }
}
