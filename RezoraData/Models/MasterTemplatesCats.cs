using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class MasterTemplatesCats
    {
        public int CatId { get; set; }
        public DateTimeOffset CatDate { get; set; }
        public string CatTitle { get; set; }
        public int BrandId { get; set; }
    }
}
