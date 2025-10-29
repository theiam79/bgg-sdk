
using Bgg.Sdk.Core;
using Bgg.Sdk.Core.Plays;
using Riok.Mapperly.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bgg.Sdk.Mapping.Mappers
{
    [Mapper]
    internal static partial class PlayInfoMapper
    {
        [MapPropertyFromSource(nameof(Models.PlayInfo.Plays), Use = nameof(CreatePagedCollection))]
        public static partial Models.PlayInfo ToPlayInfo(PlayResult model);

        private static Models.PagedCollection<Models.PlayInfo.Play> CreatePagedCollection(PlayResult playResult)
        {
            return new Models.PagedCollection<Models.PlayInfo.Play>
            {
                Total = playResult.Total,
                Page = playResult.Page,
                Items = playResult.Plays.ConvertAll(ToPlay)
            };
        }

        [MapProperty(nameof(PlayResult.PlayElement.Length), nameof(Models.PlayInfo.Play.Duration))]
        [MapProperty(nameof(PlayResult.PlayElement.Item), nameof(Models.PlayInfo.Play.PlayedItem))]
        [MapProperty(nameof(PlayResult.PlayElement.PlayerList.Players), nameof(Models.PlayInfo.Play.Players))]
        private static partial Models.PlayInfo.Play ToPlay(PlayResult.PlayElement model);

        private static TimeSpan TimespanFromMinutes(int minutes) => TimeSpan.FromMinutes(minutes);

        [MapPropertyFromSource(nameof(Models.PlayInfo.Play.Item.SubType), Use = nameof(GetListSubType))]
        private static partial Models.PlayInfo.Play.Item ToItem(PlayResult.PlayElement.ItemElement model);

        private static ListSubType GetListSubType(PlayResult.PlayElement.ItemElement source)
        {
            return source.TypeList.Subtypes.Select(s => s.Value).Aggregate((x, y) => x | y);
        }

        [MapProperty(nameof(PlayResult.PlayElement.PlayerCollectionElement.PlayerElement.Win), nameof(Models.PlayInfo.Play.Player.Winner))]
        private static partial Models.PlayInfo.Play.Player ToPlayer(PlayResult.PlayElement.PlayerCollectionElement.PlayerElement model);
    }
}
