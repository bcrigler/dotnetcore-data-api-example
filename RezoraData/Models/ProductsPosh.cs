using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class ProductsPosh
    {
        public string ProdId { get; set; }
        public string ProdTitle { get; set; }
        public string ProdDescShort { get; set; }
        public string ProdDescLong { get; set; }
        public float ProdPrice { get; set; }
        public string ExcludeFromBuyFive { get; set; }
        public string FillWeight { get; set; }
        public string Fragrance { get; set; }
        public float PerksOverrideCost { get; set; }
        public float PerksOverrideEarn { get; set; }
        public string PerkPurchase { get; set; }
        public string WhatDoesItDo { get; set; }
        public string WhatIsIt { get; set; }
        public string HowToUse { get; set; }
        public string Ingredients { get; set; }
        public string ProdSize { get; set; }
        public string ProdSubtitle { get; set; }
        public string TabDetails { get; set; }
        public string ClassCategory { get; set; }
        public byte PublishStatus { get; set; }
        public DateTimeOffset LastUpdate { get; set; }
        public int LastImport { get; set; }
    }
}
