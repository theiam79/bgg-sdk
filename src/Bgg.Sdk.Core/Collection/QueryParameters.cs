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

        /// <summary>
        /// Name of the user to retrieve the collection for.
        /// </summary>
        [AliasAs("username")]
        public string UserName { get; }

        //todo version info - doesn't seem to do anything?

        /// <summary>
        /// Specifies which collection to retrieve.
        /// </summary>
        [AliasAs("subtype")]
        public ThingType? CollectionType { get; set; } = ThingType.Boardgame;

        /// <summary>
        /// Specify which types to exclude.
        /// </summary>
        [AliasAs("excludesubtype")]
        public ThingType? ExcludedType { get; set; }
        
        /// <summary>
        /// Filter collection to only specified items.
        /// </summary>
        [AliasAs("id")]
        [Query(CollectionFormat.Csv)]
        public List<int>? Ids { get; set; }

        /// <summary>
        /// Returns more abbreviated results.
        /// </summary>
        [AliasAs("brief")]
        public bool Brief { get; set; } = false;

        /// <summary>
        /// Return expaned rating and ranking info for the collection
        /// </summary>
        [AliasAs("stats")]
        public bool Stats { get; set; } = true;

        /// <summary>
        /// Filter for owned games. False excludes items marked this way.
        /// </summary>
        [AliasAs("own")]
        public bool? Own { get; set; }


        /// <summary>
        /// Filter for rated games. False exludes items marked this way.
        /// </summary>
        [AliasAs("rated")]
        public bool? Rated { get; set; }

        /// <summary>
        /// Filter for played games. False exludes items marked this way.
        /// </summary>
        [AliasAs("played")]
        public bool? Played { get; set; }

        /// <summary>
        /// Filter for commented games. False exludes items marked this way.
        /// </summary>
        [AliasAs("comment")]
        public bool? Comment { get; set; }

        /// <summary>
        /// Filter for games marked for trade. False exludes items marked this way.
        /// </summary>
        [AliasAs("trade")]
        public bool? Trade { get; set; }

        /// <summary>
        /// Filter for games wanted for trade. False exludes items marked this way.
        /// </summary>
        [AliasAs("want")]
        public bool? Want { get; set; }

        /// <summary>
        /// Filter for wishlisted games. False exludes items marked this way.
        /// </summary>
        [AliasAs("wishlist")]
        public bool? Wishlist { get; set; }

        /// <summary>
        /// Filter to games with specified wishlist priority
        /// </summary>
        [AliasAs("wishlistpriority")]
        public WishlistPriority? WishlistPriority { get; set; } = null;

        /// <summary>
        /// Filter for preordered games. False exludes items marked this way.
        /// </summary>
        [AliasAs("preordered")]
        public bool? PreOrdered { get; set; }

        /// <summary>
        /// Filter for games marked as want to play. False exludes items marked this way.
        /// </summary>
        [AliasAs("wanttoplay")]
        public bool? WantToPlay { get; set; }

        /// <summary>
        /// Filter for games marked as want to buy. False exludes items marked this way.
        /// </summary>
        [AliasAs("wanttobuy")]
        public bool? WantToBuy { get; set; }

        /// <summary>
        /// Filter for previously owned games. False exludes items marked this way.
        /// </summary>
        [AliasAs("prevowned")]
        public bool? PreviouslyOwned { get; set; }

        /// <summary>
        /// Filter for games with parts. False exludes items marked this way.
        /// </summary>
        [AliasAs("hasparts")]
        public bool? HasParts { get; set; }

        /// <summary>
        /// Filter for games with parts wanted. False exludes items marked this way.
        /// </summary>
        [AliasAs("wantparts")]
        public bool? WantParts { get; set; }

        /// <summary>
        /// Return only games personally rated above this value
        /// </summary>
        [AliasAs("minrating")]
        public Rating? MinimumRating { get; set; } = null;

        /// <summary>
        /// Return only games personally rated below this value
        /// </summary>
        [AliasAs("rating")]
        public Rating? MaximumRating { get; set; } = null;

        /// <summary>
        /// Return only games rated above this value by the community
        /// </summary>
        [AliasAs("minbggrating")]
        public int? MinimumBggRating { get; set; } = null;

        /// <summary>
        /// Return only games rated below this value by the community
        /// </summary>
        [AliasAs("bggrating")]
        public int? MaximumBggRating { get; set; } = null;

        /// <summary>
        /// Return only games with at least this many plays
        /// </summary>
        [AliasAs("minplays")]
        public int? MiniumPlays { get; set; } = null;

        /// <summary>
        /// Return only games with less recorded plays than this
        /// </summary>
        [AliasAs("maxplays")]
        public int? MaximumPlays { get; set; } = null;

        //show private - no auth so not working

        /// <summary>
        /// Restrict the collection results ot the single specified collection.
        /// </summary>
        [AliasAs("collid")]
        public int? CollectionId { get; set; }

        /// <summary>
        /// Which style of date filter should be used
        /// </summary>
        public DateFilterType DateFilterType { private get; set; } = DateFilterType.DateOnly;

        /// <summary>
        /// The date to use for date filtering
        /// </summary>
        public DateTime? ModifiedSince { private get; set; }

        [AliasAs("modifiedsince")]
        public string? ModifiedSinceQueryString => (ModifiedSince, DateFilterType) switch
        {
            (null, _) => null,
            (not null, DateFilterType.DateOnly) => ModifiedSince.Value.ToString("yyyy-MM-dd"),
            (not null, DateFilterType.DateTime) => ModifiedSince.Value.ToString("yyyy-MM-dd hh:mm:ss"),
            _ => null
        };
    }
}
