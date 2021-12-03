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

        public Application(IBggApi bggApi)
        {
            _bggApi = bggApi;
        }

        public async Task Run()
        {
            //var parameters = new Collection.QueryParameters("")
            //{
            //    ExcludedType = ItemType.BoardgameExpansion,
            //    Stats = true,
            //};

            //var collection = await _bggApi.GetCollection(parameters);
            //var collection = await _bggApi.GetCollection("");

            //var search = new Search.QueryParameters("7 wonders");
            //var search1 = await _bggApi.Search(search);
            //search.Types.Add(ItemType.BoardgameExpansion);
            //search.Types.Add(ItemType.BoardgameAccessory);
            //var search2 = await _bggApi.Search(search);
            //search.Types.Add(ItemType.Boardgame);
            //var search3 = await _bggApi.Search(search);

            //var user = await _bggApi.User("theiam79");
            //var family = await _bggApi.Family(22783);
            //var forum = await _bggApi.Forum(3665735);
            //var forumList = await _bggApi.ForumList(192135);
            //var guild = await _bggApi.Guild(3022);
            //var hotgames = await _bggApi.HotItems(Core.HotItems.HotListType.Boardgame);
            //var plays = await _bggApi.Plays("theiam79", 36218);
            //var things = await _bggApi.Things(173346);
            //var polls = things.Items.First().Polls;
            //foreach (var poller in polls)
            //{
            //    var casted = poller as Core.Thing.NumberOfPlayersPoll;

            //}

            var queryParams = new Core.Thread.QueryParameters
            {
                Id = 2767067,
                DateFilter = DateTime.Today.AddYears(-10),
                FilterType = Core.Thread.FilterType.DateTime
            };

            var thread = await _bggApi.Thread(queryParams);
        }
    }
}
