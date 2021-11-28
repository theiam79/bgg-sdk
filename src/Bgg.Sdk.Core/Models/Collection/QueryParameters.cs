using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bgg.Sdk.Core.Models.Collection
{
    public class QueryParameters
    {
        public string UserName { get; set; } = "";
        public ItemType CollectionType { get; set; }
        public ItemType ExcludedType { get; set; }
        //id
        public bool Stats { get; set; } = true;
        public bool? Own { get; set; }
        public bool? Rated { get; set; }
        public bool? Played { get; set; }
        public bool? Comment { get; set; }
        public bool? Trade { get; set; }
        public bool? Want { get; set; }
        public bool? Wishlist { get; set; }
        public int? WishlistPriority { get; set; } = null;
        public bool? PreOrdered { get; set; }
        public bool? WantToPlay { get; set; }
        public bool? WantToBuy { get; set; }
        public bool? PreviouslyOwned { get; set; }
        public bool? HasParts { get; set; }
        public bool? WantParts { get; set; }
        public int? MinimumRating { get; set; } = null;
        public int? MaximumRating { get; set; } = null;
        public int? MinimumBggRating { get; set; }
        public int? MaximumBggRating { get; set; }
        public int? MiniumPlays { get; set; }
        public int? MaximumPlays { get; set; }
    }

    public enum ItemType
    {
        Boardgame = 1,
        BoardgameExpansion = 2,
        BoardgameAccessory = 3
    }
}
