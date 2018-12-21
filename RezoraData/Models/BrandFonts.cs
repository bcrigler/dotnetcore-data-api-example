using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class BrandFonts
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public string Font { get; set; }

        public Brands Brand { get; set; }
    }
}
