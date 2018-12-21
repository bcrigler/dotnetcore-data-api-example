using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class GalleryToTemplate
    {
        public int GallerytotemplateId { get; set; }
        public DateTimeOffset GallerytotemplateTimestamp { get; set; }
        public int TemplateId { get; set; }
        public string TemplateTitle { get; set; }
        public int GalleryId { get; set; }
        public float Price { get; set; }
        public int TemplateTypeId { get; set; }
    }
}
