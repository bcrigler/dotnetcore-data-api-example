using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class UsersFbpages
    {
        public int UsersfbpagesId { get; set; }
        public int UserId { get; set; }
        public string PageId { get; set; }
        public int ListId { get; set; }
        public byte? ContactName { get; set; }
        public byte? ContactCompany { get; set; }
        public byte? ContactTitle { get; set; }
        public byte? ContactPhoneHome { get; set; }
        public byte? ContactPhoneWork { get; set; }
        public byte? ContactPhoneMobile { get; set; }
        public byte? ContactPhoneFax { get; set; }
        public byte? ContactBusinessStreet { get; set; }
        public byte? ContactBusinessStreet2 { get; set; }
        public byte? ContactBusinessCity { get; set; }
        public byte? ContactBusinessState { get; set; }
        public byte? ContactBusinessZip { get; set; }
        public byte? ContactHomeStreet { get; set; }
        public byte? ContactHomeStreet2 { get; set; }
        public byte? ContactHomeCity { get; set; }
        public byte? ContactHomeState { get; set; }
        public byte? ContactHomeZip { get; set; }
    }
}
