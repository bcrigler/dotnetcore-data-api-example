using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class UsersStatuses
    {
        public UsersStatuses()
        {
            Users = new HashSet<Users>();
        }

        public int StatusId { get; set; }
        public string StatusTitle { get; set; }

        public ICollection<Users> Users { get; set; }
    }
}
