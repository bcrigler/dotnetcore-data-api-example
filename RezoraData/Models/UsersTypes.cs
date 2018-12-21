using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class UsersTypes
    {
        public UsersTypes()
        {
            Users = new HashSet<Users>();
        }

        public int TypeId { get; set; }
        public string TypeName { get; set; }

        public ICollection<Users> Users { get; set; }
    }
}
