using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class GroupsToTemplates
    {
        public int GrouptotemplateId { get; set; }
        public DateTimeOffset GrouptotemplateTimestamp { get; set; }
        public int GroupId { get; set; }
        public int TemplateId { get; set; }
    }
}
