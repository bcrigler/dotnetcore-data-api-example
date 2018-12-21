using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class UsersToGroups
    {
        public int UsertogroupId { get; set; }
        public DateTimeOffset UsertogroupTimestamp { get; set; }
        public int UserId { get; set; }
        public int GroupId { get; set; }
    }
}
