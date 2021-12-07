using AutoMapper;

namespace Bgg.Sdk.Mapping
{
    internal class PlayInfoProfile : Profile
    {
        public PlayInfoProfile()
        {
            CreateMap<Core.Plays.PlayResult.PlayElement.ItemElement, Models.PlayInfo.Play.Item>()
                .ForMember(dest => dest.SubType, opt => opt.MapFrom(src => src.TypeList.Subtypes.Select(s => s.Value).Aggregate((x, y) => x | y)));

            CreateMap<Core.Plays.PlayResult.PlayElement.PlayerCollectionElement.PlayerElement, Models.PlayInfo.Play.Player>()
                .ForMember(dest => dest.Winner, opt => opt.MapFrom(src => src.Win));

            CreateMap<Core.Plays.PlayResult.PlayElement, Models.PlayInfo.Play>()
                .ForMember(dest => dest.Duration, opt => opt.MapFrom(src => src.Length))
                .ForMember(dest => dest.PlayedItem, opt => opt.MapFrom(src => src.Item))
                .ForMember(dest => dest.Players, opt => opt.MapFrom(src => src.PlayerList.Players));

            CreateMap<Core.Plays.PlayResult, Models.PlayInfo>()
                .ForPath(dest => dest.Plays.Total, opt => opt.MapFrom(src => src.Total))
                .ForPath(dest => dest.Plays.Page, opt => opt.MapFrom(src => src.Page))
                .ForPath(dest => dest.Plays.Items, opt => opt.MapFrom(src => src.Plays));
        }
    }
}
