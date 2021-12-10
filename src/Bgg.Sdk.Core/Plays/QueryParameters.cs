using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Bgg.Sdk.Core.Plays
{
    public class QueryParameters
    {
        public QueryParameters(string username) : this(username, null) { }
        public QueryParameters(int id) : this(null, (int?)id) { }
        public QueryParameters(string username, int id) : this(username, (int?)id) { }

        private QueryParameters(string? username, int? id)
        {
            UserName = username;
            Id = id;
        }

        /// <summary>
        /// Name of the player you want to request information for.
        /// </summary>
        [AliasAs("username")]
        public string? UserName { get; init; }

        /// <summary>
        /// Id of the item to request play information for
        /// </summary>
        [AliasAs("id")]
        public int? Id { get; init; }

        /// <summary>
        /// The type of item to request play information for
        /// </summary>
        [AliasAs("type")]
        public ListType? Type { get; set; }

        /// <summary>
        /// Exclude plays before this date
        /// </summary>
        [AliasAs("mindate")]
        public DateTime? MinimumDate { get; set; }

        /// <summary>
        /// Exclude plays after this date
        /// </summary>
        [AliasAs("maxdate")]
        public DateTime? MaximumDate { get; set; }

        /// <summary>
        /// Filter the results to the specified item subtypes
        /// </summary>
        [AliasAs("subtype")]
        public ListSubType? SubType { get; set; }

        /// <summary>
        /// Controls the page of data for plays.
        /// Page size is 100.
        /// </summary>
        [AliasAs("page")]
        public int Page { get; set; } = 1;
    }
}
