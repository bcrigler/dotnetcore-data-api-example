using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class GallProducts
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public float ProductPrice { get; set; }
        public DateTimeOffset ProductCreated { get; set; }
        public int TemplateId { get; set; }
    }
}
