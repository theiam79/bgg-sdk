using AutoMapper;
using Bgg.Sdk.Core;
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
    public class BggClient : IBggClient
    {
        private readonly IBggApi _bggApi;
        private readonly IMapper _mapper;

        /// <summary>
        /// The default constructor
        /// </summary>
        /// <param name="bggApi">The <see cref="IBggApi"/> used to make requests</param>
        /// <param name="mapper">The <see cref="IMapper"/> used to map responses</param>
        public BggClient(IBggApi bggApi, IMapper mapper)
        {
            _bggApi = bggApi;
            _mapper = mapper;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public Task<Models.Collection> CollectionAsync(string username) => CollectionAsync(new Core.Collection.QueryParameters(username));

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public async Task<Models.Collection> CollectionAsync(Core.Collection.QueryParameters queryParameters)
        {
            var response = await _bggApi.GetCollection(queryParameters);
            return _mapper.Map<Models.Collection>(response);
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
            var response = await _bggApi.Family(queryParameters);
            return _mapper.Map<Models.FamilyCollection>(response);
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
            var response = await _bggApi.Forum(queryParameters);
            response.Page = queryParameters.Page;
            return _mapper.Map<Models.Forum>(response);
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
            var response = await _bggApi.ForumList(queryParameters);
            return _mapper.Map<Models.ForumList>(response);
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
            var response = await _bggApi.Guild(queryParameters);
            return _mapper.Map<Models.Guild>(response);
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
            var response = await _bggApi.HotItems(queryParameters);
            return _mapper.Map<Models.HotList>(response);
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
            var response = await _bggApi.Plays(queryParameters);
            return _mapper.Map<Models.PlayInfo>(response);
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
            var response = await _bggApi.Search(queryParameters);
            return _mapper.Map<Models.SearchResult>(response);
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
            var response = await _bggApi.Things(queryParameters);
            return _mapper.Map<Models.ThingCollection>(response);
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
            var response = await _bggApi.Thread(queryParameters);
            return _mapper.Map<Models.Thread>(response);
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
            var response = await _bggApi.User(queryParameters);
            return _mapper.Map<Models.User>(response);
        }
    }
}
