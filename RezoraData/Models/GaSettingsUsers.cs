using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class GaSettingsUsers
    {
        public int UserId { get; set; }
        public byte? GaOn { get; set; }
        public string Sites { get; set; }
    }
}
