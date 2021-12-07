using AutoMapper;

namespace Bgg.Sdk.Mapping
{
    internal class HotListProfile : Profile
    {
        public HotListProfile()
        {
            CreateMap<Core.HotItems.HotItems.ItemElement, Models.HotList.HotItem>()
                .ForMember(dest => dest.ThumbnailUrl, opt => opt.MapFrom(src => src.Thumbnail));

            CreateMap<Core.HotItems.HotItems, Models.HotList>()
                .ForMember(dest => dest.HotItems, opt => opt.MapFrom(src => src.Items));
        }
    }
}
