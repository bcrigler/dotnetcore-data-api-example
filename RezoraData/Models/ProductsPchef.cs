using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class ProductsPchef
    {
        public string ProdId { get; set; }
        public string ProdTitle { get; set; }
        public string ProdDescShort { get; set; }
        public string ProdDescLong { get; set; }
        public float ProdPrice { get; set; }
        public byte PublishStatus { get; set; }
        public DateTimeOffset LastUpdate { get; set; }
        public int LastImport { get; set; }
    }
}
