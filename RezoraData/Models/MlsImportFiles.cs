using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class MlsImportFiles
    {
        public int ImportFileId { get; set; }
        public string OrgId { get; set; }
        public string FileType { get; set; }
        public string FileHash { get; set; }
        public int TotalItems { get; set; }
        public int ModifiedItems { get; set; }
        public int NewItems { get; set; }
        public int DeletedItems { get; set; }
        public int? ExaminedItems { get; set; }
        public int FailedItems { get; set; }
        public DateTime UploadedDate { get; set; }
        public DateTime? ImportedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public byte IsComplete { get; set; }
        public DateTime? FailedDate { get; set; }
        public string FailureReason { get; set; }
        public string ExecutionId { get; set; }
        public byte IsDelta { get; set; }
    }
}
