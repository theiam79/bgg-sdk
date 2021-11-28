using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collection = Bgg.Sdk.Core.Models.Collection;

namespace Bgg.Sdk.Core
{
    public interface IBggApi
    {
        [Get("/collection")]
        Task<Collection.Collection> GetCollection(Collection.QueryParameters queryParameters);
    }
}
