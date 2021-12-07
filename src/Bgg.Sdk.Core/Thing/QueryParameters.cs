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
            Id = id;
        }

        [AliasAs("id")]
        public int Id { get; set; }
        [AliasAs("versions")]
        public bool? Versions { get; set; } = true;
        [AliasAs("videos")]
        public bool? Videos { get; set; } = true;
        [AliasAs("stats")]
        public bool? Stats { get; set; } = true;
        [AliasAs("marketplace")]
        public bool? Marketplace { get; set; } = true;
        [AliasAs("comments")]
        public bool? Comments { get; set; } = true;

    }

    public enum Type
    {

    }
}
