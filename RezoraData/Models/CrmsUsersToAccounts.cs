using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class CrmsUsersToAccounts
    {
        public int CrmUsertoaccountId { get; set; }
        public int? UserId { get; set; }
        public string CrmAccId { get; set; }
        public string CrmAccName { get; set; }
        public int? CrmId { get; set; }
        public DateTimeOffset? CrmUsertoaccountTimestamp { get; set; }
    }
}
