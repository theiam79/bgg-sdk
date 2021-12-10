using AutoMapper;

namespace Bgg.Sdk.Mapping
{
    internal class FamilyProfile : Profile
    {
        public FamilyProfile()
        {
            CreateMap<Core.Family.FamilyResult.FamilyElement, Models.FamilyCollection.Family>()
                //.ForMember(dest => dest.FamilyType, opt => opt.MapFrom(src => src.FamilyType))
                //.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                //.ForMember(dest => dest.ThumbnailUrl, opt => opt.MapFrom(src => src.ThumbnailUrl))
                //.ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                //.ForMember(dest => dest.Names, opt => opt.MapFrom(src => src.Names))
                //.ForMember(dest => dest.Links, opt => opt.MapFrom(src => src.Links))
                ;

            CreateMap<Core.Family.FamilyResult, Models.FamilyCollection>();
        }
    }
}
