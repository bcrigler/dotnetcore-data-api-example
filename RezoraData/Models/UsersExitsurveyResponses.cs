using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class UsersExitsurveyResponses
    {
        public int ResponseId { get; set; }
        public int UserId { get; set; }
        public int ResponseTypeId { get; set; }
        public int? OptionId { get; set; }
        public string ResponseReason { get; set; }
        public int? ResponseNps { get; set; }
        public DateTimeOffset ResponseDate { get; set; }
    }
}
