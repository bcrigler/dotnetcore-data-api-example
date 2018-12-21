using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class MlsOrganizations
    {
        public int MlsId { get; set; }
        public string OrgId { get; set; }
        public string MlsName { get; set; }
        public string MlsNameDisplay { get; set; }
        public int HiresImages { get; set; }
        public byte DisplayListingAgent { get; set; }
        public DateTimeOffset MlsTimestamp { get; set; }
        public int Isactive { get; set; }
    }
}
