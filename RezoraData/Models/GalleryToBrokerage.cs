using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class GalleryToBrokerage
    {
        public int GallerytobrokerageId { get; set; }
        public int GalleryId { get; set; }
        public int BrokerageId { get; set; }
    }
}
