using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class UserToAmemberSub
    {
        public int SubId { get; set; }
        public int UserId { get; set; }
        public int AmemberProductId { get; set; }
        public int Status { get; set; }
        public DateTime LastModified { get; set; }
        public DateTime Created { get; set; }
    }
}
