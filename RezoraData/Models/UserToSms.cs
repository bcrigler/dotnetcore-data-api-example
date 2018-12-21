using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class UserToSms
    {
        public int UsertosmsId { get; set; }
        public int UserId { get; set; }
        public string MobileNumber { get; set; }
        public byte Accepted { get; set; }
    }
}
