using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class GallCollections
    {
        public int CollectionId { get; set; }
        public string CollectionName { get; set; }
        public float CollectionPriceDefault { get; set; }
        public DateTimeOffset CollectionCreated { get; set; }
        public byte CollectionRestricted { get; set; }
        public byte CollectionStatus { get; set; }
    }
}
