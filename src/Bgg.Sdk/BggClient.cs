using Bgg.Sdk.Core;
using Bgg.Sdk.Mapping.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bgg.Sdk
{
    /// <summary>
    /// The default implementation of <see cref="IBggClient"/>
    /// </summary>
    /// <remarks>
    /// The default constructor
    /// </remarks>
    /// <param name="bggApi">The <see cref="IBggApi"/> used to make requests</param>
    public class BggClient(IBggApi bggApi) : IBggClient
    {

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public Task<Models.Collection> CollectionAsync(string username) => CollectionAsync(new Core.Collection.QueryParameters(username));

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public async Task<Models.Collection> CollectionAsync(Core.Collection.QueryParameters queryParameters)
        {
            var response = await bggApi.GetCollection(queryParameters);
            return CollectionMapper.ToCollection(response);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public Task<Models.FamilyCollection> FamilyAsync(int id) => FamilyAsync(new Core.Family.QueryParameters(id));

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public async Task<Models.FamilyCollection> FamilyAsync(Core.Family.QueryParameters queryParameters)
        {
            var response = await bggApi.Family(queryParameters);
            return FamilyMapper.ToFamilyCollection(response);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public Task<Models.Forum> ForumAsync(int id) => ForumAsync(new Core.Forum.QueryParameters(id));

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public async Task<Models.Forum> ForumAsync(Core.Forum.QueryParameters queryParameters)
        {
            var response = await bggApi.Forum(queryParameters);
            response.Page = queryParameters.Page;
            return ForumMapper.ToForum(response);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public Task<Models.ForumList> ForumListAsync(int id) => ForumListAsync(new Core.ForumList.QueryParameters(id));

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public async Task<Models.ForumList> ForumListAsync(Core.ForumList.QueryParameters queryParameters)
        {
            var response = await bggApi.ForumList(queryParameters);
            return ForumListMapper.ToForumList(response);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public Task<Models.Guild> GuildAsync(int id) => GuildAsync(new Core.Guild.QueryParameters(id));

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public async Task<Models.Guild> GuildAsync(Core.Guild.QueryParameters queryParameters)
        {
            var response = await bggApi.Guild(queryParameters);
            return GuildMapper.ToGuild(response);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public Task<Models.HotList> HotListAsync(Core.HotItems.HotListType hotListType) => HotListAsync(new Core.HotItems.QueryParameters(hotListType));

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public async Task<Models.HotList> HotListAsync(Core.HotItems.QueryParameters queryParameters)
        {
            var response = await bggApi.HotItems(queryParameters);
            return HotListMapper.ToHotList(response);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public Task<Models.PlayInfo> PlayInfoAsync(string username) => PlayInfoAsync(new Core.Plays.QueryParameters(username));

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public Task<Models.PlayInfo> PlayInfoAsync(int id) => PlayInfoAsync(new Core.Plays.QueryParameters(id));

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public Task<Models.PlayInfo> PlayInfoAsync(string username, int id) => PlayInfoAsync(new Core.Plays.QueryParameters(username, id));

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public async Task<Models.PlayInfo> PlayInfoAsync(Core.Plays.QueryParameters queryParameters)
        {
            var response = await bggApi.Plays(queryParameters);
            return PlayInfoMapper.ToPlayInfo(response);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public Task<Models.SearchResult> SearchAsync(string searchTerm) => SearchAsync(new Core.Search.QueryParameters(searchTerm));

        /// <summary>
        /// <inheritdoc/>
        /// </summary>`
        public async Task<Models.SearchResult> SearchAsync(Core.Search.QueryParameters queryParameters)
        {
            var response = await bggApi.Search(queryParameters);
            return SearchMapper.ToSearchResult(response);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public Task<Models.ThingCollection> ThingAsync(int id) => ThingAsync(new Core.Thing.QueryParameters(id));

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public async Task<Models.ThingCollection> ThingAsync(Core.Thing.QueryParameters queryParameters)
        {
            var response = await bggApi.Things(queryParameters);
            return ThingMapper.ToThingCollection(response);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public Task<Models.Thread> ThreadAsync(int id) => ThreadAsync(new Core.Thread.QueryParameters(id));

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public async Task<Models.Thread> ThreadAsync(Core.Thread.QueryParameters queryParameters)
        {
            var response = await bggApi.Thread(queryParameters);
            return ThreadMapper.ToThread(response);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public Task<Models.User> UserAsync(string username) => UserAsync(new Core.User.QueryParameters(username));

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public async Task<Models.User> UserAsync(Core.User.QueryParameters queryParameters)
        {
            var response = await bggApi.User(queryParameters);
            return UserMapper.ToUser(response);
        }
    }
}
