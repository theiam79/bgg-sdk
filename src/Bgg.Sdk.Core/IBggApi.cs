using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collection = Bgg.Sdk.Core.Collection;
using Search = Bgg.Sdk.Core.Search;

namespace Bgg.Sdk.Core
{
    public interface IBggApi
    {
        [Get("/collection")]
        Task<ApiResponse<Collection.Collection>> GetCollectionResponse(Collection.QueryParameters queryParameters);

        [Get("/collection")]
        Task<Collection.Collection> GetCollection(Collection.QueryParameters queryParameters);

        [Get("/search")]
        Task<Search.SearchResult> Search(Search.QueryParameters queryParameters);

        [Get("/user")]
        Task<User.User> User(User.QueryParameters queryParameters);

        [Get("/family")]
        Task<Family.FamilyResult> Family(Family.QueryParameters queryParameters);

        [Get("/forum")]
        Task<Forum.Forum> Forum(Forum.QueryParameters queryParameters);

        [Get("/forumlist")]
        Task<ForumList.ForumList> ForumList(ForumList.QueryParameters queryParameters);

        [Get("/guild")]
        Task<Guild.Guild> Guild(Guild.QueryParameters queryParameters);

        [Get("/hot")]
        Task<HotItems.HotItems> HotItems(HotItems.QueryParameters queryParameters);

        [Get("/plays")]
        Task<Plays.PlayResult> Plays(Plays.QueryParameters queryParameters);

        [Get("/thing")]
        Task<Thing.ThingResult> Things(Thing.QueryParameters queryParameters);

        [Get("/thread")]
        Task<Thread.ThreadElement> Thread(Thread.QueryParameters queryParameters);
    }
}
