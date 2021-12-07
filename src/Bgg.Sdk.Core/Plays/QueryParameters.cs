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

        [AliasAs("username")]
        public string? UserName { get; init; }
        [AliasAs("id")]
        public int? Id { get; init; }
        [AliasAs("type")]
        public ListType? Type { get; set; }
        [AliasAs("mindate")]
        public DateTime? MinimumDate { get; set; }
        [AliasAs("maxdate")]
        public DateTime? MaximumDate { get; set; }
        [AliasAs("subtype")]
        public ListSubType? SubType { get; set; }
        [AliasAs("page")]
        public int Page { get; set; } = 1;
    }
}
