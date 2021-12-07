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

        [AliasAs("id")]
        public int Id { get; init; }
        [AliasAs("minarticleid")]
        public int? MinimumArticleId { get; init; }
        
        [AliasAs("count")]
        public int? Count { get; init; }

        public DateFilterType DateFilterType { private get; set; } = DateFilterType.DateOnly;
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

    public enum DateFilterType
    {
        DateOnly = 1,
        DateTime = 2
    }
}
