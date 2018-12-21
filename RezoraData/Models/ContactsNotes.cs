using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class ContactsNotes
    {
        public int NoteId { get; set; }
        public DateTimeOffset NoteDate { get; set; }
        public string NoteText { get; set; }
        public int ContactId { get; set; }

        public Contacts Contact { get; set; }
    }
}
