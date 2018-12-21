using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class MasterContactsLists
    {
        public int ListId { get; set; }
        public string ListName { get; set; }
        public DateTimeOffset ListDate { get; set; }
        public int ListType { get; set; }
        public int UserId { get; set; }
        public int ListUpdating { get; set; }
        public int? ListRestricted { get; set; }
        public int? BrokerageId { get; set; }
    }
}
