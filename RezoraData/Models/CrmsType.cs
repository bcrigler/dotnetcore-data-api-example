using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class CrmsType
    {
        public int CrmId { get; set; }
        public string CrmName { get; set; }
        public string IconPath { get; set; }
        public string ApplicationId { get; set; }
        public string ClientSecret { get; set; }
    }
}
