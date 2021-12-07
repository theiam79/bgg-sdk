using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bgg.Sdk.Mapping
{
    internal class CollectionProfile : Profile
    {
        public CollectionProfile()
        {
            CreateMap<Core.Collection.Collection.ItemElement, Models.Collection.CollectionItem>()
                .ForMember(dest => dest.ImageUrl, opt => opt.MapFrom(src => src.Image))
                .ForMember(dest => dest.ThumbnailUrl, opt => opt.MapFrom(src => src.Thumbnail))
                .ForMember(dest => dest.MinimumPlayerCount, opt => opt.MapFrom(src => src.Stats.MinPlayers))
                .ForMember(dest => dest.MaxPlayerCount, opt => opt.MapFrom(src => src.Stats.MaxPlayers))
                .ForMember(dest => dest.MinimumPlayTime, opt => opt.MapFrom(src => src.Stats.MinPlaytime))
                .ForMember(dest => dest.MaximumPlayTime, opt => opt.MapFrom(src => src.Stats.MaxPlaytime))
                .ForMember(dest => dest.AveragePlayTime, opt => opt.MapFrom(src => src.Stats.Playtime))
                .ForMember(dest => dest.TotalOwnedCopies, opt => opt.MapFrom(src => src.Stats.NumberOwned))
                .ForMember(dest => dest.Status, opt => opt.MapFrom<CollectionItemStatusResolver>())
                .ForMember(dest => dest.WishlistPriority, opt => opt.MapFrom(src => src.Status.WishlistPriority))
                .ForMember(dest => dest.StatusLastModified, opt => opt.MapFrom(src => src.Status.LastModifiedString));

            CreateMap<Core.Collection.Collection, Models.Collection>()
                .ForMember(dest => dest.GeneratedDate, opt => opt.MapFrom(src => src.PubDate))
                .ForMember(dest => dest.CollectionItems, opt => opt.MapFrom(src => src.Items));
        }
    }
}
