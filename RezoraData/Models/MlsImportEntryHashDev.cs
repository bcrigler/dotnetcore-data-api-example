using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class MlsImportEntryHashDev
    {
        public string OrgId { get; set; }
        public string EntryId { get; set; }
        public string EntryType { get; set; }
        public string CurrentHash { get; set; }
        public DateTime LastChanged { get; set; }
        public byte InUse { get; set; }
        public int LastFileId { get; set; }
        public string UniqId1 { get; set; }
        public string UniqId2 { get; set; }
    }
}
