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

        [AliasAs("query")]
        public string SearchTerm { get; }

        [AliasAs("type")]
        [Query(CollectionFormat.Csv)]
        public List<ThingType>? Types { get; init; }

        [AliasAs("exact")]
        public bool? Exact { get; set; }

    }
}
