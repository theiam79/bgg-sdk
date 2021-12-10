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

        /// <summary>
        /// The username
        /// </summary>
        [AliasAs("name")]
        public string UserName { get; set; }

        /// <summary>
        /// Include the user's buddy information
        /// </summary>
        [AliasAs("buddies")]
        public bool Buddies { get; set; } = true;

        /// <summary>
        /// Include the user's guild information
        /// </summary>
        [AliasAs("guilds")]
        public bool Guilds { get; set; } = true;

        /// <summary>
        /// Include the user's Top 10 list
        /// </summary>
        [AliasAs("top")]
        public bool Top { get; set; } = true;

        /// <summary>
        /// Include the User's Hot 10 list
        /// </summary>
        [AliasAs("hot")]
        public bool Hot { get; set; } = true;

        /// <summary>
        /// The domain to use for the users top and hot lists
        /// </summary>
        [AliasAs("domain")]
        public RankingDomain? Domain { get; set; }

        /// <summary>
        /// Controls the page of data for paged collections, such as <see cref="Buddies"/> and <see cref="Guilds"/>. 
        /// Page size is 100 records.
        /// </summary>
        [AliasAs("page")]
        public int Page { get; set; } = 1;
    }
}
