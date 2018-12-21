using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class MattContentHidden
    {
        public int Id { get; set; }
        public int? ContentId { get; set; }
        public int? UserId { get; set; }
    }
}
