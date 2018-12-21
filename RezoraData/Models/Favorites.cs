using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class Favorites
    {
        public int FavoriteId { get; set; }
        public string FavoriteNotes { get; set; }
        public DateTimeOffset FavoriteTimestamp { get; set; }
        public int UserId { get; set; }
        public string OrgId { get; set; }
        public string ListingId { get; set; }
        public int ListingTypeId { get; set; }

        public Users User { get; set; }
    }
}
