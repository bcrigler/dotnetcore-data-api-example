using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class CloudelementsUsersToAccounts
    {
        public int ElementUsertoaccountId { get; set; }
        public int UserId { get; set; }
        public string ElementCrmAccId { get; set; }
        public string ElementCrmAccName { get; set; }
        public int ElementId { get; set; }
        public DateTimeOffset ElementUsertoaccountTimestamp { get; set; }
    }
}
