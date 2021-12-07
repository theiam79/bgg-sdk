using AutoMapper;
using Bgg.Sdk.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bgg.Sdk
{
    public class BggClient : IBggClient
    {
        private readonly IBggApi _bggApi;
        private readonly IMapper _mapper;

        public BggClient(IBggApi bggApi, IMapper mapper)
        {
            _bggApi = bggApi;
            _mapper = mapper;
        }

        public Task<Models.Collection> CollectionAsync(string username) => CollectionAsync(new Core.Collection.QueryParameters(username));
        public async Task<Models.Collection> CollectionAsync(Core.Collection.QueryParameters queryParameters)
        {
            var response = await _bggApi.GetCollection(queryParameters);
            return _mapper.Map<Models.Collection>(response);
        }

        public Task<Models.Family> FamilyAsync(int id) => FamilyAsync(new Core.Family.QueryParameters(id));
        public async Task<Models.Family> FamilyAsync(Core.Family.QueryParameters queryParameters)
        {
            var response = await _bggApi.Family(queryParameters);
            return _mapper.Map<Models.Family>(response);
        }

        public Task<Models.Forum> ForumAsync(int id) => ForumAsync(new Core.Forum.QueryParameters(id));
        public async Task<Models.Forum> ForumAsync(Core.Forum.QueryParameters queryParameters)
        {
            var response = await _bggApi.Forum(queryParameters);
            response.Page = queryParameters.Page;
            return _mapper.Map<Models.Forum>(response);
        }

        public Task<Models.ForumList> ForumListAsync(int id) => ForumListAsync(new Core.ForumList.QueryParameters(id));
        public async Task<Models.ForumList> ForumListAsync(Core.ForumList.QueryParameters queryParameters)
        {
            var response = await _bggApi.ForumList(queryParameters);
            return _mapper.Map<Models.ForumList>(response);
        }

        public Task<Models.Guild> GuildAsync(int id) => GuildAsync(new Core.Guild.QueryParameters(id));
        public async Task<Models.Guild> GuildAsync(Core.Guild.QueryParameters queryParameters)
        {
            var response = await _bggApi.Guild(queryParameters);
            return _mapper.Map<Models.Guild>(response);
        }

        public Task<Models.HotList> HotListAsync(Core.HotItems.HotListType hotListType) => HotListAsync(new Core.HotItems.QueryParameters(hotListType));
        public async Task<Models.HotList> HotListAsync(Core.HotItems.QueryParameters queryParameters)
        {
            var response = await _bggApi.HotItems(queryParameters);
            return _mapper.Map<Models.HotList>(response);
        }

        public Task<Models.PlayInfo> PlayInfoAsync(string username) => PlayInfoAsync(new Core.Plays.QueryParameters(username));
        public Task<Models.PlayInfo> PlayInfoAsync(int id) => PlayInfoAsync(new Core.Plays.QueryParameters(id));
        public Task<Models.PlayInfo> PlayInfoAsync(string username, int id) => PlayInfoAsync(new Core.Plays.QueryParameters(username, id));
        public async Task<Models.PlayInfo> PlayInfoAsync(Core.Plays.QueryParameters queryParameters)
        {
            var response = await _bggApi.Plays(queryParameters);
            return _mapper.Map<Models.PlayInfo>(response);
        }

        public Task<Models.SearchResult> SearchAsync(string searchTerm) => SearchAsync(new Core.Search.QueryParameters(searchTerm));
        public async Task<Models.SearchResult> SearchAsync(Core.Search.QueryParameters queryParameters)
        {
            var response = await _bggApi.Search(queryParameters);
            return _mapper.Map<Models.SearchResult>(response);
        }

        public Task<Models.Thing> ThingAsync(int id) => ThingAsync(new Core.Thing.QueryParameters(id));
        public async Task<Models.Thing> ThingAsync(Core.Thing.QueryParameters queryParameters)
        {
            var response = await _bggApi.Things(queryParameters);
            return _mapper.Map<Models.Thing>(response);
        }

        public Task<Models.Thread> ThreadAsync(int id) => ThreadAsync(new Core.Thread.QueryParameters(id));
        public async Task<Models.Thread> ThreadAsync(Core.Thread.QueryParameters queryParameters)
        {
            var response = await _bggApi.Thread(queryParameters);
            return _mapper.Map<Models.Thread>(response);
        }

        public async Task<Models.User> UserAsync(Core.User.QueryParameters queryParameters)
        {
            var response = await _bggApi.User(queryParameters);
            return _mapper.Map<Models.User>(response);
        }
    }
}
