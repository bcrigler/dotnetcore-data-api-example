using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class UsersToContacts
    {
        public int UsertocontactId { get; set; }
        public int UserId { get; set; }
        public int ContactId { get; set; }
        public DateTimeOffset UsertocontactTimestamp { get; set; }
        public byte UsertocontactNew { get; set; }
        public byte UsertocontactShareActivity { get; set; }
        public byte UsertocontactUnsubscribe { get; set; }

        public Contacts Contact { get; set; }
        public Users User { get; set; }
    }
}
