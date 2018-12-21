using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class UsersExitsurveyOptions
    {
        public int OptionId { get; set; }
        public int OptionTypeId { get; set; }
        public string OptionMessage { get; set; }
        public int OptionOrder { get; set; }
        public byte OptionPublic { get; set; }
    }
}
