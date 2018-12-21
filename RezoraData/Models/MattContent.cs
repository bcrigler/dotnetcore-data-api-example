using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class MattContent
    {
        public int ContentId { get; set; }
        public string ContentTitle { get; set; }
        public int ContentClassId { get; set; }
        public int ContentOwnerId { get; set; }
        public int ContentOwnerTypeId { get; set; }
        public byte AllowPrint { get; set; }
        public byte IsDisplayAd { get; set; }
        public string ContentJson { get; set; }
        public string ContentJsonDraft { get; set; }
        public DateTimeOffset? ContentTimestamp { get; set; }
        public byte? ContentRestricted { get; set; }
        public int ContentWidth { get; set; }
        public int ContentHeight { get; set; }
    }
}
