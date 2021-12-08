using Bgg.Sdk.Core.HotItems;
using Bgg.Sdk.Models;

namespace Bgg.Sdk
{
    public interface IBggClient
    {
        Task<Collection> CollectionAsync(Core.Collection.QueryParameters queryParameters);
        Task<Collection> CollectionAsync(string username);
        Task<FamilyCollection> FamilyAsync(int id);
        Task<FamilyCollection> FamilyAsync(Core.Family.QueryParameters queryParameters);
        Task<Forum> ForumAsync(int id);
        Task<Forum> ForumAsync(Core.Forum.QueryParameters queryParameters);
        Task<ForumList> ForumListAsync(int id);
        Task<ForumList> ForumListAsync(Core.ForumList.QueryParameters queryParameters);
        Task<Guild> GuildAsync(int id);
        Task<Guild> GuildAsync(Core.Guild.QueryParameters queryParameters);
        Task<HotList> HotListAsync(HotListType hotListType);
        Task<HotList> HotListAsync(QueryParameters queryParameters);
        Task<PlayInfo> PlayInfoAsync(int id);
        Task<PlayInfo> PlayInfoAsync(Core.Plays.QueryParameters queryParameters);
        Task<PlayInfo> PlayInfoAsync(string username);
        Task<PlayInfo> PlayInfoAsync(string username, int id);
        Task<SearchResult> SearchAsync(Core.Search.QueryParameters queryParameters);
        Task<SearchResult> SearchAsync(string searchTerm);
        Task<ThingCollection> ThingAsync(int id);
        Task<ThingCollection> ThingAsync(Core.Thing.QueryParameters queryParameters);
        Task<Models.Thread> ThreadAsync(int id);
        Task<Models.Thread> ThreadAsync(Core.Thread.QueryParameters queryParameters);
        Task<User> UserAsync(Core.User.QueryParameters queryParameters);
    }
}