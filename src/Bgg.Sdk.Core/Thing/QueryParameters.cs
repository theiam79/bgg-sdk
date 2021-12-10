using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bgg.Sdk.Core.Thing
{
    public class QueryParameters
    {
        public QueryParameters(int id)
        {
            Ids.Add(id);
        }

        /// <summary>
        /// The Id of the thing to query
        /// </summary>
        [AliasAs("id")]
        [Query(CollectionFormat.Csv)]
        public List<int> Ids { get; init; } = new();

        /// <summary>
        /// Return version info for the item(s) 
        /// </summary>
        [AliasAs("versions")]
        public bool? Versions { get; set; } = true;

        /// <summary>
        /// Return Videos for the item(s)
        /// </summary>
        [AliasAs("videos")]
        public bool? Videos { get; set; } = true;

        /// <summary>
        /// Return ranking and statistical info for the item(s)
        /// </summary>
        [AliasAs("stats")]
        public bool? Stats { get; set; } = true;

        /// <summary>
        /// Return market listings for the item(s)
        /// </summary>
        [AliasAs("marketplace")]
        public bool? Marketplace { get; set; } = true;

        /// <summary>
        /// Return all comments about the item(s). Also includes ratings when commented
        /// </summary>
        [AliasAs("comments")]
        public bool? Comments { get; set; } = true;

        /// <summary>
        /// Return all ratings for the item. Also includes comments when rated. Cannot be used with <see cref="Comments"/>. If both are specified, <see cref="Comments"/> takes precedence.
        /// </summary>
        [AliasAs("ratingcomments")]
        public bool? RatingComments { get; set; }

        /// <summary>
        /// Controls the page of data for paged collections, such as <see cref="Comments"/> and <see cref="RatingComments"/>
        /// </summary>
        [AliasAs("page")]
        public int Page { get; set; } = 1;

        /// <summary>
        /// Controls the max number of records for paging from 10 to 100
        /// </summary>
        [AliasAs("pagesize")]
        public int PageSize { get; set; } = 100;

    }

    public enum Type
    {

    }
}
