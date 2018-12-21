using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class UserLoginNonce
    {
        public long NonceId { get; set; }
        public int OwnerId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public string NonceKey { get; set; }
        public string NonceType { get; set; }
    }
}
