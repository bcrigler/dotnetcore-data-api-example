using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class NewslettersToDisplayads
    {
        public int NewslettertodisplayadId { get; set; }
        public int NewsletterId { get; set; }
        public int DisplayadImageLeft { get; set; }
        public int DisplayadImageTop { get; set; }
        public int DisplayadImageWidth { get; set; }
        public string DisplayadImageFormat { get; set; }
        public string DisplayadImagePath { get; set; }
        public string SitescoutAssetUrl { get; set; }
        public string SitescoutCreativeType { get; set; }
        public int SitescoutCreativeId { get; set; }
        public string SitescoutReviewStatus { get; set; }
        public int? DisplayadImageHeight { get; set; }
    }
}
