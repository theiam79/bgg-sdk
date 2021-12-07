using AutoMapper;

namespace Bgg.Sdk.Mapping
{
    internal class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<Core.User.User.RankedCollectionElement.RankedItemElement, Models.User.RankedCollection.RankedItem>();

            CreateMap<Core.User.User.RankedCollectionElement, Models.User.RankedCollection>()
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.RankedItems));

            CreateMap<Core.User.User.GuildCollectionElement.GuildElement, Models.User.Guild>();

            CreateMap<Core.User.User.GuildCollectionElement, Models.PagedCollection<Models.User.Guild>>()
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Guilds));

            CreateMap<Core.User.User.BuddyCollectionElement.BuddyElement, Models.User.Buddy>();

            CreateMap<Core.User.User.BuddyCollectionElement, Models.PagedCollection<Models.User.Buddy>>()
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Buddies));

            CreateMap<Core.User.User, Models.User>()
                .ForMember(dest => dest.Buddies, opt => opt.MapFrom(src => src.BuddyCollection))
                .ForMember(dest => dest.Guilds, opt => opt.MapFrom(src => src.GuildCollection));
        }
    }
}
