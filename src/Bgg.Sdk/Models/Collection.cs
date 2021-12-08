using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bgg.Sdk.Models
{
    public class Collection
    {
        public int TotalItems { get; init; }
        public string TermsOfUse { get; init; } = "";
        public DateTime GeneratedDate { get; init; }
        public List<CollectionItem> CollectionItems { get; init; } = new();
        public class CollectionItem
        {
            public int ObjectId { get; init; }
            public string Name { get; init; } = "";
            public int YearPublished { get; init; }
            public string ImageUrl { get; init; } = "";
            public string ThumbnailUrl { get; init; } = "";
            public int MinimumPlayerCount { get; init; }
            public int MaxPlayerCount { get; init; }
            public TimeSpan MinimumPlayTime { get; init; }
            public TimeSpan MaximumPlayTime { get; init; }
            public TimeSpan AveragePlayTime { get; init; }
            public int TotalOwnedCopies { get; init; }
            public CollectionItemStatus Status { get; init; }
            public Core.WishlistPriority WishlistPriority { get; init; }
            public DateTime StatusLastModified { get; init; }

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
