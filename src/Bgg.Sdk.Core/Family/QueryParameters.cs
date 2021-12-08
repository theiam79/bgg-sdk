using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bgg.Sdk.Core.Family
{
    public class QueryParameters
    {
        public QueryParameters(int id)
        {
            Ids.Add(id);
        }

        /// <summary>
        /// Specifies the id of the family to retrieve. 
        /// To request multiple families with a single query, NNN can specify a comma-delimited list of ids.
        /// </summary>
        [AliasAs("id")]
        [Query(CollectionFormat.Csv)]
        public List<int> Ids { get; init; } = new();

        /// <summary>
        /// Specifies that, regardless of the type of family asked for by id, the results are filtered by the FAMILYTPE(s) specified. 
        /// Multiple FAMILYTYPEs can be specified in a comma-delimited list.
        /// </summary>
        [AliasAs("type")]
        [Query(CollectionFormat.Csv)]
        public List<FamilyType>? FamilyTypes {get;set;}
    }
}
