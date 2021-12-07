using AutoMapper;

namespace Bgg.Sdk.Mapping
{
    internal class ForumListProfile : Profile
    {
        public ForumListProfile()
        {
            CreateMap<Core.ForumList.ForumList.ForumElement, Models.ForumList.Forum>()
                .ForMember(dest => dest.LastPostDate, opt => opt.MapFrom(dest => dest.LastPostDateString));

            CreateMap<Core.ForumList.ForumList, Models.ForumList>();
        }
    }
}
