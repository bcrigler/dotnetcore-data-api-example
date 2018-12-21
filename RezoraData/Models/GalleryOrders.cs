using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class GalleryOrders
    {
        public int OrderId { get; set; }
        public DateTimeOffset OrderTimestamp { get; set; }
        public string OrderContactName { get; set; }
        public string OrderContactEmail { get; set; }
        public string OrderContactPhone { get; set; }
        public string OrderMessage { get; set; }
        public int OrderTimeframeId { get; set; }
        public string OrderGroups { get; set; }
        public int OrderGallery { get; set; }
        public int OrderStatusId { get; set; }
        public int OrderAssigneeId { get; set; }
        public string OrderComments { get; set; }
        public int? OrderZendeskId { get; set; }
        public float OrderPrice { get; set; }
        public string TemplateTitle { get; set; }
        public int ClassId { get; set; }
        public int TemplateId { get; set; }
        public int BrokerageId { get; set; }
        public int? NewTemplateId { get; set; }
    }
}
