using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class UsersCrmsAccess
    {
        public int Userscrms { get; set; }
        public int? UserId { get; set; }
        public string Token { get; set; }
        public int? CrmTypeId { get; set; }
        public byte? CrmRestricted { get; set; }
        public byte? CrmActive { get; set; }
        public DateTimeOffset? CrmLastImport { get; set; }
        public int? AutoSyncId { get; set; }
    }
}
