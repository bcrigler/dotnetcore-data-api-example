using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class GroupsToMasterContactsLists
    {
        public int GrouptomastercontactslistsId { get; set; }
        public DateTimeOffset? GrouptomastercontactslistsTimestamp { get; set; }
        public int? GroupId { get; set; }
        public int? ListId { get; set; }
    }
}
