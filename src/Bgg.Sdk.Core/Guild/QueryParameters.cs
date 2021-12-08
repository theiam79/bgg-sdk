using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Bgg.Sdk.Core.Guild
{
    public class QueryParameters
    {
        public QueryParameters(int id)
        {
            Id = id;
        }

        /// <summary>
        /// The Id of the guild
        /// </summary>
        [AliasAs("id")]
        public int Id { get; set; }

        /// <summary>
        /// Include the member roster
        /// </summary>
        [AliasAs("members")]
        public bool Members { get; set; } = true;

        /// <summary>
        /// Optionally sort the member list
        /// </summary>
        [AliasAs("sort")]
        public SortType? SortType { get; set; }

        /// <summary>
        /// Controls the page of data for <see cref="Members"/>.
        /// Page size is 25.
        /// </summary>
        [AliasAs("page")]
        public int Page { get; set; } = 1;

    }

    public enum SortType
    {
        [EnumMember(Value ="username")]
        Username = 1,
        [EnumMember(Value ="date")]
        Date = 2
    }
}
