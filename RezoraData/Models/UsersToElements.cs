using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class UsersToElements
    {
        public int UteId { get; set; }
        public int UserId { get; set; }
        public int BteId { get; set; }
        public DateTimeOffset UteTimestamp { get; set; }
    }
}
