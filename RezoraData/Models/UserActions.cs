using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class UserActions
    {
        public UserActions()
        {
            UsersToActions = new HashSet<UsersToActions>();
        }

        public int ActionId { get; set; }
        public string Action { get; set; }

        public ICollection<UsersToActions> UsersToActions { get; set; }
    }
}
