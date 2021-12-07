using AutoMapper;

namespace Bgg.Sdk.Mapping
{
    internal class GuildProfile : Profile
    {
        public GuildProfile()
        {
            CreateMap<Core.Guild.Guild.LocationElement, Models.Guild.LocationInfo>();

            CreateMap<Core.Guild.Guild.MemberCollectionElement.MemberElement, Models.Guild.Member>()
                .ForMember(dest => dest.JoinDate, opt => opt.MapFrom(src => src.DateString));

            CreateMap<Core.Guild.Guild.MemberCollectionElement, Models.PagedCollection<Models.Guild.Member>>()
                .ForMember(dest => dest.Total, opt => opt.MapFrom(src => src.Page))
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Members));

            CreateMap<Core.Guild.Guild, Models.Guild>()
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.CreatedString))
                .ForMember(dest => dest.Members, opt => opt.MapFrom(src => src.MemberList));
        }
    }
}
