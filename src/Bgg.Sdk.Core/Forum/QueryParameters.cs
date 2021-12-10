using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bgg.Sdk.Core.Forum
{
    public class QueryParameters
    {
        public QueryParameters(int id)
        {
            Id = id;
        }

        /// <summary>
        /// Specifies the id of the forum. This is the id that appears in the address of the page when visiting a forum in the browser.
        /// </summary>
        [AliasAs("id")]
        public int Id { get; set; }

        /// <summary>
        /// The page of the thread list to return; page size is 50. Threads in the thread list are sorted in order of most recent post.
        /// </summary>
        [AliasAs("page")]
        public int Page { get; set; } = 1;
    }

}
