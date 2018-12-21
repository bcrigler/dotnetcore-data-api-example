using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class WellcomematImportLog
    {
        public int WellcomematImportId { get; set; }
        public int ImportError { get; set; }
        public int? UserId { get; set; }
        public DateTimeOffset? LoadMediaStart { get; set; }
        public DateTimeOffset? LoadMediaEnd { get; set; }
        public DateTimeOffset? ImportMediaStart { get; set; }
        public DateTimeOffset? ImportMediaEnd { get; set; }
        public int? ImportMediaTotalCount { get; set; }
        public int? ImportMediaValidCount { get; set; }
        public DateTimeOffset? ImportDbStart { get; set; }
        public DateTimeOffset? ImportDbEnd { get; set; }
    }
}
