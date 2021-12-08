using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bgg.Sdk.Core.Thread
{
    public class QueryParameters
    {
        public QueryParameters(int id)
        {
            Id = id;
        }

        /// <summary>
        /// Specifies the id of the thread to retrieve.
        /// </summary>
        [AliasAs("id")]
        public int Id { get; init; }

        /// <summary>
        /// Filters the results so that only articles with an equal or higher id than NNN will be returned.
        /// </summary>
        [AliasAs("minarticleid")]
        public int? MinimumArticleId { get; init; }

        /// <summary>
        /// Limits the number of articles returned
        /// </summary>
        [AliasAs("count")]
        public int? Count { get; init; }

        /// <summary>
        /// Which style of date filter should be used
        /// </summary>
        public DateFilterType DateFilterType { private get; set; } = DateFilterType.DateOnly;

        /// <summary>
        /// The date to use for date filtering
        /// </summary>
        public DateTime? DateFilter { private get; set; }
        
        [AliasAs("minarticledate")]
        public string? DateFilterQueryString => (DateFilter, DateFilterType) switch
        {
            (null, _) => null,
            (not null, DateFilterType.DateOnly) => DateFilter.Value.ToString("yyyy-MM-dd"),
            (not null, DateFilterType.DateTime) => DateFilter.Value.ToString("yyyy-MM-dd hh:mm:ss"),
            _ => null
        };
        
    }


}
