using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class Gallery
    {
        public int GalleryId { get; set; }
        public string GalleryName { get; set; }
        public string GalleryDescription { get; set; }
        public int GalleryAllowPublish { get; set; }
        public int GalleryGlobalAccess { get; set; }
        public int GalleryPrivate { get; set; }
    }
}
