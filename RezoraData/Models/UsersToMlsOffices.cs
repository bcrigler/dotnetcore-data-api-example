using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class UsersToMlsOffices
    {
        public int UsertomlsofficeId { get; set; }
        public int UserId { get; set; }
        public string OrgId { get; set; }
        public string OfficeId { get; set; }
        public DateTimeOffset UsertomlsofficeTimestamp { get; set; }

        public Users User { get; set; }
    }
}
