using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class ApiKeys
    {
        public int KeyId { get; set; }
        public string KeyUsername { get; set; }
        public string KeyValue { get; set; }
        public string RequesterType { get; set; }
        public int RequesterId { get; set; }
    }
}
