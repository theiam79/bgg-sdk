using AutoMapper;

namespace Bgg.Sdk.Mapping
{
    internal class ThingProfile : Profile
    {
        public ThingProfile()
        {
            CreateMap<Core.Thing.ThingResult.ItemElement.PollElement.ResultCollectionElement.PollResultElement, Models.Thing.PollOption>()
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Value));

            CreateMap<Core.Thing.ThingResult.ItemElement.PollElement.ResultCollectionElement, Models.Thing.PollResult>()
                .ForMember(dest => dest.Options, opt => opt.MapFrom(src => src.Results));

            CreateMap<Core.Thing.ThingResult.ItemElement.PollElement, Models.Thing.Poll>()
                .ForMember(dest => dest.Results, opt => opt.MapFrom(src => src.ResultCollections));

            CreateMap<Core.Thing.ThingResult.ItemElement.VideoCollectionElement.VideoElement, Models.Thing.Video>();

            CreateMap<Core.Thing.ThingResult.ItemElement.VersionCollectionElement.VersionElement, Models.Thing.Version>()
                .ForMember(dest => dest.ThumbnailUrl, opt => opt.MapFrom(src => src.Thumbnail))
                .ForMember(dest => dest.ImageUrl, opt => opt.MapFrom(src => src.Image));

            CreateMap<Core.Thing.ThingResult.ItemElement.CommentCollectionElement.CommentElement, Models.Thing.Comment>();

            CreateMap<Core.Thing.ThingResult.ItemElement.CommentCollectionElement, Models.PagedCollection<Models.Thing.Comment>>()
                .ForMember(dest => dest.Total, opt => opt.MapFrom(src => src.TotalItems))
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Comments));

            CreateMap<Core.Thing.ThingResult.ItemElement.MarketplaceListingCollectionElement.ListingElement, Models.Thing.MarketplaceListing>()
                .ForMember(dest => dest.ListDate, opt => opt.MapFrom(src => src.ListDateString))
                .ForMember(dest => dest.Currency, opt => opt.MapFrom(src => src.Price.Currency))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price.Value))
                .ForMember(dest => dest.UrlTitle, opt => opt.MapFrom(src => src.Link.Title))
                .ForMember(dest => dest.Url, opt => opt.MapFrom(src => src.Link.Url));

            CreateMap<Core.Thing.ThingResult.ItemElement.StatisticsElement.RatingsElement, Models.Thing.ThingStatistics>()
                .ForMember(dest => dest.AverageRating, opt => opt.MapFrom(src => src.Average));

            CreateMap<Core.Thing.ThingResult.ItemElement.StatisticsElement.RatingsElement.RankCollectionElement.RankElement, Models.Thing.Ranking>()
                .ForMember(dest => dest.Rank, opt => opt.MapFrom(src => src.Value));



            CreateMap<Core.Thing.ThingResult, Models.Thing>()
                .ForMember(dest => dest.ThingType, opt => opt.MapFrom(src => src.Item.ThingType))
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Item.Id))
                .ForMember(dest => dest.ThumbnailUrl, opt => opt.MapFrom(src => src.Item.Thumbnail))
                .ForMember(dest => dest.ImageUrl, opt => opt.MapFrom(src => src.Item.Image))
                .ForMember(dest => dest.Names, opt => opt.MapFrom(src => src.Item.Names))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Item.Description))
                .ForMember(dest => dest.YearPublished, opt => opt.MapFrom(src => src.Item.YearPublished))
                .ForMember(dest => dest.MinimumPlayerCount, opt => opt.MapFrom(src => src.Item.MinPlayers))
                .ForMember(dest => dest.MaximumPlayerCount, opt => opt.MapFrom(src => src.Item.MaxPlayers))
                .ForMember(dest => dest.Polls, opt => opt.MapFrom(src => src.Item.Polls))
                .ForMember(dest => dest.AveragePlaytime, opt => opt.MapFrom(src => src.Item.PlayingTime))
                .ForMember(dest => dest.MinimumPlaytime, opt => opt.MapFrom(src => src.Item.MinPlaytime))
                .ForMember(dest => dest.MaximumPlaytime, opt => opt.MapFrom(src => src.Item.MaxPlaytime))
                .ForMember(dest => dest.MinimumAge, opt => opt.MapFrom(src => src.Item.MinAge))
                .ForMember(dest => dest.Links, opt => opt.MapFrom(src => src.Item.Links))
                .ForMember(dest => dest.Videos, opt => opt.MapFrom(src => src.Item.VideoList.Videos))
                .ForMember(dest => dest.Versions, opt => opt.MapFrom(src => src.Item.VersionList.Versions))
                .ForMember(dest => dest.Comments, opt => opt.MapFrom(src => src.Item.CommentList))
                .ForMember(dest => dest.MarketplaceListings, opt => opt.MapFrom(src => src.Item.MarketplaceListingCollection.Listings))
                .ForMember(dest => dest.Statistics, opt => opt.MapFrom(src => src.Item.Statistics.Ratings))
                .ForMember(dest => dest.Rankings, opt => opt.MapFrom(src => src.Item.Statistics.Ratings.RankCollection.Ranks))
                ;

        }
    }
}
