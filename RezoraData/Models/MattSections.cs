using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class MattSections
    {
        public int SectionId { get; set; }
        public string SectionTitle { get; set; }
        public int SectionClassId { get; set; }
        public int? SectionOwnerId { get; set; }
        public int SectionOwnerTypeId { get; set; }
        public byte SectionDistributeMethod { get; set; }
        public string SectionJson { get; set; }
        public string SectionJsonDraft { get; set; }
        public DateTimeOffset? SectionTimestamp { get; set; }
        public byte? SectionRestricted { get; set; }
    }
}
