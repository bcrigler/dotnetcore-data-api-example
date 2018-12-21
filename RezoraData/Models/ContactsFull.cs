using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class ContactsFull
    {
        public int ContactId { get; set; }
        public int UserId { get; set; }
        public DateTimeOffset FullTimestamp { get; set; }
        public string FullData { get; set; }
    }
}
