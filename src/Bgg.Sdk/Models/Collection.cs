using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bgg.Sdk.Models
{
    public class Collection
    {
        public int TotalItems { get; set; }
        public string TermsOfUse { get; set; } = "";
        public DateTime GeneratedDate { get; set; }
        public List<CollectionItem> CollectionItems { get; set; } = new();
        public class CollectionItem
        {
            public int ObjectId { get; set; }
            public string Name { get; set; } = "";
            public int YearPublished { get; set; }
            public string ImageUrl { get; set; } = "";
            public string ThumbnailUrl { get; set; } = "";
            public int MinimumPlayerCount { get; set; }
            public int MaxPlayerCount { get; set; }
            public TimeSpan MinimumPlayTime { get; set; }
            public TimeSpan MaximumPlayTime { get; set; }
            public TimeSpan AveragePlayTime { get; set; }
            public int TotalOwnedCopies { get; set; }
            public CollectionItemStatus Status { get; set; }
            public int WishlistPriority { get; set; }
            public DateTime StatusLastModified { get; set; }

            [Flags]
            public enum CollectionItemStatus
            {
                Owned = 1 << 0,
                PreviouslyOwned = 1 << 1,
                ForTrade = 1 << 2,
                Want = 1 << 3,
                WantToPlay = 1 << 4,
                WantToBuy = 1 << 5,
                Wishlist = 1 << 6,
                Preordered = 1 << 7
            }
        }
    }
}
