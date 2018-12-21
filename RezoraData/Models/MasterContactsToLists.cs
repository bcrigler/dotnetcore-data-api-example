using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class MasterContactsToLists
    {
        public int ContacttolistId { get; set; }
        public int ContactId { get; set; }
        public int ListId { get; set; }
        public DateTimeOffset ContacttolistDate { get; set; }
        public int ContacttolistUpdating { get; set; }
    }
}
