using AutoMapper;

namespace Bgg.Sdk.Mapping
{
    internal class ThingProfile : Profile
    {
        public ThingProfile()
        {
            CreateMap<Core.Thing.ThingResult.ItemElement.PollElement.ResultCollectionElement.PollResultElement, Models.ThingCollection.Thing.PollOption>()
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Value));

            CreateMap<Core.Thing.ThingResult.ItemElement.PollElement.ResultCollectionElement, Models.ThingCollection.Thing.PollResult>()
                .ForMember(dest => dest.Options, opt => opt.MapFrom(src => src.Results));

            CreateMap<Core.Thing.ThingResult.ItemElement.PollElement, Models.ThingCollection.Thing.Poll>()
                .ForMember(dest => dest.Results, opt => opt.MapFrom(src => src.ResultCollections));

            CreateMap<Core.Thing.ThingResult.ItemElement.VideoCollectionElement.VideoElement, Models.ThingCollection.Thing.Video>();

            CreateMap<Core.Thing.ThingResult.ItemElement.VersionCollectionElement.VersionElement, Models.ThingCollection.Thing.Version>()
                .ForMember(dest => dest.ThumbnailUrl, opt => opt.MapFrom(src => src.Thumbnail))
                .ForMember(dest => dest.ImageUrl, opt => opt.MapFrom(src => src.Image));

            CreateMap<Core.Thing.ThingResult.ItemElement.CommentCollectionElement.CommentElement, Models.ThingCollection.Thing.Comment>();

            CreateMap<Core.Thing.ThingResult.ItemElement.CommentCollectionElement, Models.PagedCollection<Models.ThingCollection.Thing.Comment>>()
                .ForMember(dest => dest.Total, opt => opt.MapFrom(src => src.TotalItems))
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Comments));

            CreateMap<Core.Thing.ThingResult.ItemElement.MarketplaceListingCollectionElement.ListingElement, Models.ThingCollection.Thing.MarketplaceListing>()
                .ForMember(dest => dest.ListDate, opt => opt.MapFrom(src => src.ListDateString))
                .ForMember(dest => dest.Currency, opt => opt.MapFrom(src => src.Price.Currency))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price.Value))
                .ForMember(dest => dest.UrlTitle, opt => opt.MapFrom(src => src.Link.Title))
                .ForMember(dest => dest.Url, opt => opt.MapFrom(src => src.Link.Url));

            CreateMap<Core.Thing.ThingResult.ItemElement.StatisticsElement.RatingsElement, Models.ThingCollection.Thing.ThingStatistics>()
                .ForMember(dest => dest.AverageRating, opt => opt.MapFrom(src => src.Average));

            CreateMap<Core.Thing.ThingResult.ItemElement.StatisticsElement.RatingsElement.RankCollectionElement.RankElement, Models.ThingCollection.Thing.Ranking>()
                .ForMember(dest => dest.Rank, opt => opt.MapFrom(src => src.Value));

            CreateMap<Core.Thing.ThingResult.ItemElement, Models.ThingCollection.Thing>()
                //.ForMember(dest => dest.ThingType, opt => opt.MapFrom(src => src.ThingType))
                //.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.ThumbnailUrl, opt => opt.MapFrom(src => src.Thumbnail))
                .ForMember(dest => dest.ImageUrl, opt => opt.MapFrom(src => src.Image))
                //.ForMember(dest => dest.Names, opt => opt.MapFrom(src => src.Names))
                //.ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                //.ForMember(dest => dest.YearPublished, opt => opt.MapFrom(src => src.YearPublished))
                .ForMember(dest => dest.MinimumPlayerCount, opt => opt.MapFrom(src => src.MinPlayers))
                .ForMember(dest => dest.MaximumPlayerCount, opt => opt.MapFrom(src => src.MaxPlayers))
                //.ForMember(dest => dest.Polls, opt => opt.MapFrom(src => src.Polls))
                .ForMember(dest => dest.AveragePlaytime, opt => opt.MapFrom(src => src.PlayingTime))
                .ForMember(dest => dest.MinimumPlaytime, opt => opt.MapFrom(src => src.MinPlaytime))
                .ForMember(dest => dest.MaximumPlaytime, opt => opt.MapFrom(src => src.MaxPlaytime))
                .ForMember(dest => dest.MinimumAge, opt => opt.MapFrom(src => src.MinAge))
                //.ForMember(dest => dest.Links, opt => opt.MapFrom(src => src.Links))
                .ForMember(dest => dest.Videos, opt => opt.MapFrom(src => src.VideoList.Videos))
                .ForMember(dest => dest.Versions, opt => opt.MapFrom(src => src.VersionList.Versions))
                .ForMember(dest => dest.Comments, opt => opt.MapFrom(src => src.CommentList))
                .ForMember(dest => dest.MarketplaceListings, opt => opt.MapFrom(src => src.MarketplaceListingCollection.Listings))
                .ForMember(dest => dest.Statistics, opt => opt.MapFrom(src => src.Statistics.Ratings))
                .ForMember(dest => dest.Rankings, opt => opt.MapFrom(src => src.Statistics.Ratings.RankCollection.Ranks))
                ;

            CreateMap<Core.Thing.ThingResult, Models.ThingCollection>()
                .ForMember(dest => dest.Things, opt => opt.MapFrom(src => src.Items));
        }
    }
}
