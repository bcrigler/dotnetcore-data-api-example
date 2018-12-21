using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class MlsAgents
    {
        public string OrgId { get; set; }
        public string AdAddress { get; set; }
        public string AdCityName { get; set; }
        public string AdState { get; set; }
        public string AdZipCode { get; set; }
        public string AgEmail { get; set; }
        public string AgId { get; set; }
        public string AgMemberSecondaryId { get; set; }
        public string AgNameFirst { get; set; }
        public string AgNameLast { get; set; }
        public string AgNameMiddle { get; set; }
        public string AgOfficeId { get; set; }
        public string AgOfficeMobile { get; set; }
        public string AgOfficePhone { get; set; }
        public string AgOfficePhoneExt { get; set; }
        public string AgPassword { get; set; }
        public string AgPhone { get; set; }
        public string AgPhoneFax { get; set; }
        public string AgPhonePager { get; set; }
        public string AgPhoneVoiceMail { get; set; }
        public string AgRealEstateLicenseNumber { get; set; }
        public string AgStatus { get; set; }
        public string AgType { get; set; }
        public string AgWebsite { get; set; }
        public string IddAccessYn { get; set; }
        public string IddParticipateYn { get; set; }
        public string InKeepDataCurrentFromMlsYn { get; set; }
        public DateTime InLoadDate { get; set; }
        public DateTime? InTransactDate { get; set; }
        public int? PublishStatus { get; set; }
        public DateTimeOffset LastUpdate { get; set; }
        public int LastImport { get; set; }
    }
}
