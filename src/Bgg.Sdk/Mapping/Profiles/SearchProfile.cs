using AutoMapper;

namespace Bgg.Sdk.Mapping
{
    internal class SearchProfile : Profile
    {
        public SearchProfile()
        {
            CreateMap<Core.Search.SearchResult.ItemElement, Models.SearchResult.Item>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name.Value));

            CreateMap<Core.Search.SearchResult, Models.SearchResult>()
                .ForMember(dest => dest.TotalItems, opt => opt.MapFrom(src => src.Total));
        }
    }
}
