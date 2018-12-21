using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class MattSectionsHidden
    {
        public int Id { get; set; }
        public int? SectionId { get; set; }
        public int? UserId { get; set; }
    }
}
