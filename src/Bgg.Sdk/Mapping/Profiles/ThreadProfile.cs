using AutoMapper;

namespace Bgg.Sdk.Mapping
{
    internal class ThreadProfile : Profile
    {
        public ThreadProfile()
        {
            CreateMap<Core.Thread.ThreadElement.ArticleCollectionElement.ArticleElement, Models.Thread.Article>()
                .ForMember(dest => dest.Url, opt => opt.MapFrom(src => src.Link));

            CreateMap<Core.Thread.ThreadElement, Models.Thread>()
                .ForMember(dest => dest.Url, opt => opt.MapFrom(src => src.Link))
                .ForMember(dest => dest.Articles, opt => opt.MapFrom(src => src.ArticleCollection.Articles));
        }
    }
}
