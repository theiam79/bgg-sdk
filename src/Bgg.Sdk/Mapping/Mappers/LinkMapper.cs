
using Bgg.Sdk.Core;
using Bgg.Sdk.Models;
using Riok.Mapperly.Abstractions;

namespace Bgg.Sdk.Mapping.Mappers
{
    [Mapper]
    internal static partial class LinkMapper
    {
        [MapProperty(nameof(LinkElement.Inbound), nameof(Link.Direction), Use = nameof(GetLinkDirection))]
        public static partial Link ToLink(LinkElement model);
        private static LinkDirection GetLinkDirection(bool inbound) => inbound ? LinkDirection.Inbound : LinkDirection.Outbound;
    }
}
