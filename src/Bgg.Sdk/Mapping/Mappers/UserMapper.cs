
using Bgg.Sdk.Core.User;
using Riok.Mapperly.Abstractions;

namespace Bgg.Sdk.Mapping.Mappers
{
    [Mapper]
    internal static partial class UserMapper
    {
        [MapProperty(nameof(User.FirstName.Value), nameof(Models.User.FirstName))]
        [MapProperty(nameof(User.LastName.Value), nameof(Models.User.LastName))]
        [MapProperty(nameof(User.AvatarLink.Value), nameof(Models.User.AvatarLink))]
        [MapProperty(nameof(User.YearRegistered.Value), nameof(Models.User.YearRegistered))]
        [MapProperty(nameof(User.LastLogin.Value), nameof(Models.User.LastLogin))]
        [MapProperty(nameof(User.StateOrProvince.Value), nameof(Models.User.StateOrProvince))]
        [MapProperty(nameof(User.Country.Value), nameof(Models.User.Country))]
        [MapProperty(nameof(User.WebAddress.Value), nameof(Models.User.WebAddress))]
        [MapProperty(nameof(User.XboxAccount.Value), nameof(Models.User.XboxAccount))]
        [MapProperty(nameof(User.WiiAccount.Value), nameof(Models.User.WiiAccount))]
        [MapProperty(nameof(User.PsnAccount.Value), nameof(Models.User.PsnAccount))]
        [MapProperty(nameof(User.BattleNetAccount.Value), nameof(Models.User.BattleNetAccount))]
        [MapProperty(nameof(User.SteamAccount.Value), nameof(Models.User.SteamAccount))]
        [MapProperty(nameof(User.TradeRating.Value), nameof(Models.User.TradeRating))]
        [MapProperty(nameof(User.MarketRating.Value), nameof(Models.User.MarketRating))]
        [MapPropertyFromSource(nameof(Models.User.Buddies), Use = nameof(CreateBuddyPagedCollection))]
        [MapPropertyFromSource(nameof(Models.User.Guilds), Use = nameof(CreateGuildPagedCollection))]
        public static partial Models.User ToUser(User model);

        private static Models.PagedCollection<Models.User.Buddy> CreateBuddyPagedCollection(User source)
        {
            return new Models.PagedCollection<Models.User.Buddy>
            {
                Total = source.BuddyCollection.Total,
                Page = source.BuddyCollection.Page,
                Items = source.BuddyCollection.Buddies.ConvertAll(ToBuddy)
            };
        }
        private static partial Models.User.Buddy ToBuddy(User.BuddyCollectionElement.BuddyElement model);
        private static Models.PagedCollection<Models.User.Guild> CreateGuildPagedCollection(User source)
        {
            return new Models.PagedCollection<Models.User.Guild>
            {
                Total = source.GuildCollection.Total,
                Page = source.GuildCollection.Page,
                Items = source.GuildCollection.Guilds.ConvertAll(ToGuild)
            };
        }
        private static partial Models.User.Guild ToGuild(User.GuildCollectionElement.GuildElement model);
        [MapProperty(nameof(User.RankedCollectionElement.RankedItems), nameof(Models.User.RankedCollection.Items))]
        private static partial Models.User.RankedCollection ToRankedCollection(User.RankedCollectionElement model);
        private static partial Models.User.RankedCollection.RankedItem ToRankedItem(User.RankedCollectionElement.RankedItemElement model);
    }
}
