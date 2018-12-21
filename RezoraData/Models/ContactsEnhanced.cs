using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class ContactsEnhanced
    {
        public string ContactEmail { get; set; }
        public int ResultsPremium { get; set; }
        public DateTimeOffset LastUpdated { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string Location { get; set; }
        public string Education { get; set; }
        public string Occupation { get; set; }
        public string Children { get; set; }
        public string HouseholdIncome { get; set; }
        public string HighNetWorth { get; set; }
        public string MaritalStatus { get; set; }
        public string HomeOwnerStatus { get; set; }
        public string HomeMarketValue { get; set; }
        public string LengthOfResidence { get; set; }
        public string ErrorMessage { get; set; }
    }
}
