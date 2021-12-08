using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bgg.Sdk.Core.ForumList
{
    public class QueryParameters
    {
        public QueryParameters(int id)
        {
            Id = id;
        }

        /// <summary>
        /// Specifies the id of the type of database entry you want the forum list for. 
        /// This is the id that appears in the address of the page when visiting a particular game in the database.
        /// </summary>
        [AliasAs("id")]
        public int Id { get; set; }

        /// <summary>
        /// The type of entry in the database.
        /// </summary>
        [AliasAs("type")]
        public ListType ForumListType { get; set; } = ListType.Thing;
    }
}
