using AutoMapper;

namespace Bgg.Sdk.Mapping
{
    internal class FamilyProfile : Profile
    {
        public FamilyProfile()
        {
            CreateMap<Core.Family.FamilyResult, Models.Family>()
                .ForMember(dest => dest.FamilyType, opt => opt.MapFrom(src => src.Family.FamilyType))
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Family.Id))
                .ForMember(dest => dest.ThumbnailUrl, opt => opt.MapFrom(src => src.Family.ThumbnailUrl))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Family.Description))
                .ForMember(dest => dest.Names, opt => opt.MapFrom(src => src.Family.Names))
                .ForMember(dest => dest.Links, opt => opt.MapFrom(src => src.Family.Links));
        }
    }
}
