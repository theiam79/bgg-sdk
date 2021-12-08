using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bgg.Sdk.Core.Search
{
    public class QueryParameters
    {
        public QueryParameters(string searchTerm)
        {
            SearchTerm = searchTerm;
        }

        /// <summary>
        /// The search string
        /// </summary>
        [AliasAs("query")]
        public string SearchTerm { get; }

        /// <summary>
        /// Filter results to only those matching given type(s)
        /// </summary>
        [AliasAs("type")]
        [Query(CollectionFormat.Csv)]
        public List<ThingType>? Types { get; init; }

        /// <summary>
        /// Limit results to those that match the query exactly
        /// </summary>
        [AliasAs("exact")]
        public bool? Exact { get; set; }

    }
}
