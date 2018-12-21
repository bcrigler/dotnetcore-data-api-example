using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class Brands
    {
        public Brands()
        {
            BrandFonts = new HashSet<BrandFonts>();
            Brokerages = new HashSet<Brokerages>();
        }

        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public DateTimeOffset BrandTimestamp { get; set; }
        public byte BrandIsXd { get; set; }

        public ICollection<BrandFonts> BrandFonts { get; set; }
        public ICollection<Brokerages> Brokerages { get; set; }
    }
}
