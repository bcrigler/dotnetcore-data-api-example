using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class GroupsToAdmins
    {
        public int GrouptoadminId { get; set; }
        public DateTimeOffset GrouptoadmindTimestamp { get; set; }
        public int GroupId { get; set; }
        public int UserId { get; set; }
    }
}
