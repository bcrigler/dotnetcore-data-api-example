using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class MlsOffices
    {
        public string OrgId { get; set; }
        public string AdAddress { get; set; }
        public string AdCityName { get; set; }
        public string AdState { get; set; }
        public string AdZipCode { get; set; }
        public string AgOfficeContactPerson { get; set; }
        public string AgOfficeEmail { get; set; }
        public string AgOfficeId { get; set; }
        public string AgOfficeName { get; set; }
        public string AgOfficePhone { get; set; }
        public string AgOfficePhoneFax { get; set; }
        public string AgOfficeStatus { get; set; }
        public string AgOfficeType { get; set; }
        public string AgOfficeWebsite { get; set; }
        public string IddAccessYn { get; set; }
        public string IddParticipateYn { get; set; }
        public DateTime InLoadDate { get; set; }
        public DateTime? InTransactDate { get; set; }
        public int? PublishStatus { get; set; }
        public DateTimeOffset LastUpdate { get; set; }
        public int LastImport { get; set; }
    }
}
