using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class UsersToActions
    {
        public int UsersToActionsId { get; set; }
        public int UserId { get; set; }
        public DateTimeOffset Time { get; set; }
        public int Action { get; set; }
        public byte AcceptedTerms { get; set; }

        public UserActions ActionNavigation { get; set; }
    }
}
