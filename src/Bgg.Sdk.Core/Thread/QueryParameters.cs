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
        [AliasAs("id")]
        public int Id { get; init; }
        [AliasAs("minarticleid")]
        public int? MinimumArticleId { get; init; }

        //[AliasAs("minarticledate")]
        //[Query(Format = "yyyy-MM-dd")]
        //public DateTime? MinimumArticleDate { get; init; }
        //[AliasAs("minarticledate")]
        //[Query(Format = "yyyy-MM-dd hh:mm:ss")]
        //public DateTime? MinimumArticleDateTime { get; init; }
        
        [AliasAs("count")]
        public int? Count { get; init; }

        public FilterType FilterType { private get; set; } = FilterType.DateOnly;
        public DateTime? DateFilter { private get; set; }
        
        [AliasAs("minarticledate")]
        public string? DateFilterQueryString => (DateFilter, FilterType) switch
        {
            (null, _) => null,
            (not null, FilterType.DateOnly) => DateFilter.Value.ToString("yyyy-MM-dd"),
            (not null, FilterType.DateTime) => DateFilter.Value.ToString("yyyy-MM-dd hh:mm:ss"),
            _ => null
        };
        
    }

    public enum FilterType
    {
        DateOnly = 1,
        DateTime = 2
    }
}
