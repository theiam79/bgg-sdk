
using Bgg.Sdk.Core.Guild;
using Riok.Mapperly.Abstractions;

namespace Bgg.Sdk.Mapping.Mappers
{
    [Mapper]
    internal static partial class GuildMapper
    {
        [MapProperty(nameof(Guild.CreatedString), nameof(Models.Guild.CreatedDate))]
        [MapPropertyFromSource(nameof(Models.Guild.Members), Use = nameof(CreatePagedCollection))]
        public static partial Models.Guild ToGuild(Guild model);
        private static partial Models.Guild.LocationInfo ToLocationInfo(Guild.LocationElement model);

        [MapProperty(nameof(Guild.MemberCollectionElement.MemberElement.Date), nameof(Models.Guild.Member.JoinDate))]
        [MapperIgnoreSource(nameof(Guild.MemberCollectionElement.MemberElement.DateString))]
        private static partial Models.Guild.Member ToMember(Guild.MemberCollectionElement.MemberElement model);
        private static Models.PagedCollection<Models.Guild.Member> CreatePagedCollection(Guild guild)
        {
            return new Models.PagedCollection<Models.Guild.Member>
            {
                Total = guild.MemberList.Count,
                Page = guild.MemberList.Page,
                Items = guild.MemberList.Members.ConvertAll(ToMember)
            };
        }
    }
}
