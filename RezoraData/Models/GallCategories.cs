using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class GallCategories
    {
        public int CatId { get; set; }
        public string CatName { get; set; }
        public DateTimeOffset CatCreated { get; set; }
    }
}
