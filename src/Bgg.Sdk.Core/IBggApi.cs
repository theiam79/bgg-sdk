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
        Task<Collection.Collection> GetCollection(Collection.QueryParameters queryParameters);
        public Task<Collection.Collection> GetCollection(string username) => GetCollection(new Collection.QueryParameters(username));

        [Get("/search")]
        Task<Search.SearchResult> Search(Search.QueryParameters queryParameters);
        public Task<Search.SearchResult> Search(string searchTerm) => Search(new Search.QueryParameters(searchTerm));

        [Get("/user")]
        Task<User.User> User(User.QueryParameters queryParameters);
        public Task<User.User> User(string username) => User(new User.QueryParameters(username));

        [Get("/family")]
        Task<Family.FamilyResult> Family(Family.QueryParameters queryParameters);
        public Task<Family.FamilyResult> Family(int id) => Family(new Family.QueryParameters(id));

        [Get("/forum")]
        Task<Forum.Forum> Forum(Forum.QueryParameters queryParameters);
        public Task<Forum.Forum> Forum(int id) => Forum(new Forum.QueryParameters(id));

        [Get("/forumlist")]
        Task<ForumList.ForumList> ForumList(ForumList.QueryParameters queryParameters);
        public Task<ForumList.ForumList> ForumList(int id) => ForumList(new ForumList.QueryParameters(id));

        [Get("/guild")]
        Task<Guild.Guild> Guild(Guild.QueryParameters queryParameters);
        public Task<Guild.Guild> Guild(int id) => Guild(new Guild.QueryParameters(id));

        [Get("/hot")]
        Task<HotItems.HotItems> HotItems(HotItems.QueryParameters queryParameters);
        public Task<HotItems.HotItems> HotItems(HotItems.HotListType hotlistType) => HotItems(new HotItems.QueryParameters(hotlistType));

        [Get("/plays")]
        Task<Plays.PlayResult> Plays(Plays.QueryParameters queryParameters);
        public Task<Plays.PlayResult> Plays(string username) => Plays(new Plays.QueryParameters(username));
        public Task<Plays.PlayResult> Plays(int id) => Plays(new Plays.QueryParameters(id));
        public Task<Plays.PlayResult> Plays(string username, int id) => Plays(new Plays.QueryParameters(username, id));

        [Get("/thing")]
        Task<Thing.ThingResult> Things(Thing.QueryParameters queryParameters);
        public Task<Thing.ThingResult> Things(int id) => Things(new Thing.QueryParameters(id));

        [Get("/thread")]
        Task<Thread.ThreadElement> Thread(Thread.QueryParameters queryParameters);
        public Task<Thread.ThreadElement> Thread(int id) => Thread(new Thread.QueryParameters { Id = id });
    }
}
