using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class ContactsLists
    {
        public ContactsLists()
        {
            ContactsToLists = new HashSet<ContactsToLists>();
        }

        public int ListId { get; set; }
        public string ListName { get; set; }
        public DateTimeOffset ListDate { get; set; }
        public int ListType { get; set; }
        public int UserId { get; set; }
        public int ElementId { get; set; }
        public string ElementCrmId { get; set; }
        public int ListUpdating { get; set; }
        public int? MclListId { get; set; }
        public byte? ListRemoved { get; set; }

        public Users User { get; set; }
        public ICollection<ContactsToLists> ContactsToLists { get; set; }
    }
}
