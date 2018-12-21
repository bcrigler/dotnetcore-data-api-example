using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class MlsLegal
    {
        public int LegalId { get; set; }
        public string OrgId { get; set; }
        public string LegalImagePath { get; set; }
        public string LegalText { get; set; }
        public int LegalPriority { get; set; }
    }
}
