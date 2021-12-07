using AutoMapper;
using Bgg.Sdk.Core;
//using Bgg.Sdk.Models;

namespace Bgg.Sdk.Mapping
{
    internal class LinkDirectionResolver : IValueResolver<LinkElement, Models.Link, Models.LinkDirection>
    {
        public Models.LinkDirection Resolve(LinkElement source, Models.Link destination, Models.LinkDirection destMember, ResolutionContext context)
        {
            return source.Inbound ? Models.LinkDirection.Inbound : Models.LinkDirection.Outbound;
        }
    }
}
