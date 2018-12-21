using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class AdminCommandHash
    {
        public int CommandHashId { get; set; }
        public string CommandHash { get; set; }
        public byte[] CommandData { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public int Status { get; set; }
    }
}
