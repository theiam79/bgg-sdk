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

        [AliasAs("id")]
        public int Id { get; set; }
        [AliasAs("members")]
        public bool Members { get; set; } = true;
        [AliasAs("sort")]
        public SortType? SortType { get; set; }
        [AliasAs("page")]
        public int Page { get; set; }

    }

    public enum SortType
    {
        [EnumMember(Value ="username")]
        Username = 1,
        [EnumMember(Value ="date")]
        Date = 2
    }
}
