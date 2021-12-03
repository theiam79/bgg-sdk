using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bgg.Sdk.Core.Collection
{
    public class QueryParameters
    {
        public QueryParameters(string username)
        {
            UserName = username;
        }

        [AliasAs("username")]
        public string UserName { get; }

        [AliasAs("subtype")]
        public ItemType? CollectionType { get; set; } = ItemType.Boardgame;

        [AliasAs("excludesubtype")]
        public ItemType? ExcludedType { get; set; }
        //id

        [AliasAs("stats")]
        public bool Stats { get; set; } = true;

        [AliasAs("own")]
        public bool? Own { get; set; }

        [AliasAs("rated")]
        public bool? Rated { get; set; }

        [AliasAs("played")]
        public bool? Played { get; set; }

        [AliasAs("comment")]
        public bool? Comment { get; set; }

        [AliasAs("trade")]
        public bool? Trade { get; set; }

        [AliasAs("want")]
        public bool? Want { get; set; }

        [AliasAs("wishlist")]
        public bool? Wishlist { get; set; }

        [AliasAs("wishlistpriority")]
        public int? WishlistPriority { get; set; } = null;

        [AliasAs("preordered")]
        public bool? PreOrdered { get; set; }

        [AliasAs("wanttoplay")]
        public bool? WantToPlay { get; set; }

        [AliasAs("wanttobuy")]
        public bool? WantToBuy { get; set; }

        [AliasAs("prevowned")]
        public bool? PreviouslyOwned { get; set; }

        [AliasAs("hasparts")]
        public bool? HasParts { get; set; }

        [AliasAs("wantparts")]
        public bool? WantParts { get; set; }

        [AliasAs("minrating")]
        public int? MinimumRating { get; set; } = null;

        [AliasAs("rating")]
        public int? MaximumRating { get; set; } = null;

        [AliasAs("minbggrating")]
        public int? MinimumBggRating { get; set; } = null;

        [AliasAs("bggrating")]
        public int? MaximumBggRating { get; set; } = null;

        [AliasAs("minplays")]
        public int? MiniumPlays { get; set; } = null;

        [AliasAs("maxplays")]
        public int? MaximumPlays { get; set; } = null;
    }
}
