using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bgg.Sdk.Core.User
{
    public class QueryParameters
    {
        public QueryParameters(string username)
        {
            UserName = username;
        }

        [AliasAs("name")]
        public string UserName { get; set; }
        [AliasAs("buddies")]
        public bool Buddies { get; set; } = true;
        [AliasAs("guilds")]
        public bool Guilds { get; set; } = true;
        [AliasAs("top")]
        public bool Top { get; set; } = true;
        [AliasAs("hot")]
        public bool Hot { get; set; } = true;
        [AliasAs("page")]
        public int Page { get; set; } = 1;
    }
}
