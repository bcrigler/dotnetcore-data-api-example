using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class ContactsMeta
    {
        public int ContactMetaId { get; set; }
        public int? ContactId { get; set; }
        public int ContactMetaTypeId { get; set; }
        public string MetaValue { get; set; }
        public int? UserId { get; set; }
    }
}
