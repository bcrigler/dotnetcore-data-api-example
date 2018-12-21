using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class NewslettersTemplatesCats
    {
        public int CatId { get; set; }
        public DateTimeOffset CatDate { get; set; }
        public string CatTitle { get; set; }
        public int BrokerageId { get; set; }
        public int Isactive { get; set; }
        public int MasterId { get; set; }
        public int Isvisible { get; set; }
    }
}
