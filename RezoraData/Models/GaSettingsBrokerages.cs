using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class GaSettingsBrokerages
    {
        public int BrokerageId { get; set; }
        public byte? GaOn { get; set; }
        public string Sites { get; set; }
    }
}
