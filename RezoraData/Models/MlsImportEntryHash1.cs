using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class MlsImportEntryHash1
    {
        public string OrgId { get; set; }
        public string EntryId { get; set; }
        public string EntryType { get; set; }
        public string CurrentHash { get; set; }
        public DateTime LastChanged { get; set; }
        public byte InUse { get; set; }
        public int LastFileId { get; set; }
        public string Uniq1 { get; set; }
        public string Uniq2 { get; set; }
    }
}
