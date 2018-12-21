using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class NewslettersListingsClicktoplayImages
    {
        public int ClicktoplayImageId { get; set; }
        public DateTimeOffset ClicktoplayImageTimestamp { get; set; }
        public int NewsletterId { get; set; }
        public string OrgId { get; set; }
        public string ListingId { get; set; }
        public byte ListingTypeId { get; set; }
        public byte ListingOrder { get; set; }
        public int ListingPhotoWidth { get; set; }
        public int ListingPhotoHeight { get; set; }
        public string ClicktoplayImagePath { get; set; }
    }
}
