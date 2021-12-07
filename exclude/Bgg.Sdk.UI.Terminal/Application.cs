using Bgg.Sdk.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collection = Bgg.Sdk.Core.Collection;
using Search = Bgg.Sdk.Core.Search;

namespace Bgg.Sdk.UI.Terminal
{
    public class Application
    {
        private readonly IBggApi _bggApi;
        private readonly IBggClient _bggClient;

        public Application(IBggApi bggApi, IBggClient bggClient)
        {
            _bggApi = bggApi;
            _bggClient = bggClient;
        }

        public async Task Run()
        {
            var collectionParameters = new Collection.QueryParameters("theiam79")
            {
                ExcludedType = ThingType.BoardgameExpansion,
                Stats = true,
                Own = true
            };

            var collection = await _bggClient.CollectionAsync(collectionParameters);

            var familyParameters = new Core.Family.QueryParameters(22783)
            {
                FamilyType = FamilyType.BoardGameFamily
            };

            var family = await _bggClient.FamilyAsync(familyParameters);

            var forumParameters = new Core.Forum.QueryParameters(3665735)
            {

            };
            
            var forum = await _bggClient.ForumAsync(forumParameters);

            var forumListParameters = new Core.ForumList.QueryParameters(192135)
            {

            };
            
            var forumList = await _bggClient.ForumListAsync(forumListParameters);

            var guildParameters = new Core.Guild.QueryParameters(3022)
            {

            };

            var guild = await _bggClient.GuildAsync(guildParameters);

            var hotlistParameters = new Core.HotItems.QueryParameters(Core.HotItems.HotListType.Boardgame)
            {

            };

            var hotlist = await _bggClient.HotListAsync(hotlistParameters);

            var playParameters = new Core.Plays.QueryParameters("theiam79", 36218)
            {

            };

            var plays = await _bggClient.PlayInfoAsync(playParameters);

            var searchParameters = new Core.Search.QueryParameters("7 wonders")
            {

            };

            var searchResults = await _bggClient.SearchAsync(searchParameters);

            var thingParameters = new Core.Thing.QueryParameters(173346)
            {
                Versions = true,
                Videos = true,
                Stats = true,
                Marketplace = true,
                Comments = true,
            };

            var thing = await _bggClient.ThingAsync(thingParameters);

            var threadParameters = new Core.Thread.QueryParameters(2767067)
            {

            };

            var thread = await _bggClient.ThreadAsync(threadParameters);

            var userParameters = new Core.User.QueryParameters("theiam79")
            {
                Buddies = true,
                Guilds = true,
                Top = true,
                Hot = true
            };

            var user = await _bggClient.UserAsync(userParameters);
        }
    }
}
