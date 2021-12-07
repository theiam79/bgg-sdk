using AutoMapper;

namespace Bgg.Sdk.Mapping
{
    internal class ForumProfile : Profile
    {
        public ForumProfile()
        {
            CreateMap<Core.Forum.Forum.ThreadCollectionElement.ThreadElement, Models.Forum.Thread>()
                .ForMember(dest => dest.CreateDate, opt => opt.MapFrom(src => src.PostDateString))
                .ForMember(dest => dest.LastPostDate, opt => opt.MapFrom(src => src.LastPostDateString));

            CreateMap<Core.Forum.Forum, Models.Forum>()
                .ForMember(dest => dest.LastPostDate, opt => opt.MapFrom(src => src.LastPostDateString))
                .ForPath(dest => dest.Threads.Items, opt => opt.MapFrom(src => src.ThreadCollection.Threads))
                .ForPath(dest => dest.Threads.Total, opt => opt.MapFrom(src => src.NumberOfThreads))
                .ForPath(dest => dest.Threads.Page, opt => opt.MapFrom(src => src.Page));
        }
    }
}
