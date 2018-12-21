using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class GalleryTimeframes
    {
        public int TimeframeId { get; set; }
        public string TimeframeName { get; set; }
        public int TimeframeOrder { get; set; }
        public byte TimeframePublic { get; set; }
        public string TimeframeDescription { get; set; }
    }
}
