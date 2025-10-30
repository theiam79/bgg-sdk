
using Bgg.Sdk.Core;
using Bgg.Sdk.Core.Plays;
using Bgg.Sdk.Core.Thing;
using Riok.Mapperly.Abstractions;
using System;
using static Bgg.Sdk.Models.PlayInfo;

namespace Bgg.Sdk.Mapping.Mappers
{
    [Mapper]
    [UseStaticMapper(typeof(NameMapper))]
    [UseStaticMapper(typeof(LinkMapper))]
    internal static partial class ThingMapper
    {
        [MapProperty(nameof(ThingResult.Items), nameof(Models.ThingCollection.Things))]
        public static partial Models.ThingCollection ToThingCollection(ThingResult model);

        [MapProperty(nameof(ThingResult.ItemElement.Thumbnail), nameof(Models.ThingCollection.Thing.ThumbnailUrl))]
        [MapProperty(nameof(ThingResult.ItemElement.Image), nameof(Models.ThingCollection.Thing.ImageUrl))]
        [MapProperty(nameof(ThingResult.ItemElement.YearPublished.Value), nameof(Models.ThingCollection.Thing.YearPublished))]
        [MapProperty(nameof(ThingResult.ItemElement.MinPlayers.Value), nameof(Models.ThingCollection.Thing.MinimumPlayerCount))]
        [MapProperty(nameof(ThingResult.ItemElement.MaxPlayers.Value), nameof(Models.ThingCollection.Thing.MaximumPlayerCount))]
        [MapProperty(nameof(ThingResult.ItemElement.PlayingTime.Value), nameof(Models.ThingCollection.Thing.AveragePlaytime))]
        [MapProperty(nameof(ThingResult.ItemElement.MinPlaytime.Value), nameof(Models.ThingCollection.Thing.MinimumPlaytime))]
        [MapProperty(nameof(ThingResult.ItemElement.MaxPlaytime.Value), nameof(Models.ThingCollection.Thing.MaximumPlaytime))]
        [MapProperty(nameof(ThingResult.ItemElement.MinAge.Value), nameof(Models.ThingCollection.Thing.MinimumAge))]
        [MapProperty(nameof(ThingResult.ItemElement.VideoList.Videos), nameof(Models.ThingCollection.Thing.Videos))]
        [MapProperty(nameof(ThingResult.ItemElement.VersionList.Versions), nameof(Models.ThingCollection.Thing.Versions))]
        [MapPropertyFromSource(nameof(Models.ThingCollection.Thing.Comments), Use = nameof(CreateCommentPagedCollection))]
        [MapProperty(nameof(ThingResult.ItemElement.Statistics.Ratings), nameof(Models.ThingCollection.Thing.Statistics))]
        [MapPropertyFromSource(nameof(Models.ThingCollection.Thing.Rankings), Use = nameof(CreateRankingCollection))]
        [MapProperty(nameof(ThingResult.ItemElement.MarketplaceListingCollection.Listings), nameof(Models.ThingCollection.Thing.MarketplaceListings))]
        private static partial Models.ThingCollection.Thing ToThing(ThingResult.ItemElement model);


        [MapProperty(nameof(ThingResult.ItemElement.PollElement.ResultCollections), nameof(Models.ThingCollection.Thing.Poll.Results))]
        private static partial Models.ThingCollection.Thing.Poll ToPoll(ThingResult.ItemElement.PollElement model);

        [MapProperty(nameof(ThingResult.ItemElement.PollElement.ResultCollectionElement.Results), nameof(Models.ThingCollection.Thing.PollResult.Options))]
        [MapperIgnoreSource(nameof(ThingResult.ItemElement.PollElement.ResultCollectionElement.NumberOfPlayers))]
        private static partial Models.ThingCollection.Thing.PollResult ToPollResult(ThingResult.ItemElement.PollElement.ResultCollectionElement model);

        [MapProperty(nameof(ThingResult.ItemElement.PollElement.ResultCollectionElement.PollResultElement.Value), nameof(Models.ThingCollection.Thing.PollOption.Description))]
        private static partial Models.ThingCollection.Thing.PollOption ToPollOption(ThingResult.ItemElement.PollElement.ResultCollectionElement.PollResultElement model);

        private static partial Models.ThingCollection.Thing.Video ToVideo(ThingResult.ItemElement.VideoCollectionElement.VideoElement model);

        [MapProperty(nameof(ThingResult.ItemElement.VersionCollectionElement.VersionElement.Thumbnail), nameof(Models.ThingCollection.Thing.Version.ThumbnailUrl))]
        [MapProperty(nameof(ThingResult.ItemElement.VersionCollectionElement.VersionElement.Image), nameof(Models.ThingCollection.Thing.Version.ImageUrl))]
        [MapProperty(nameof(ThingResult.ItemElement.VersionCollectionElement.VersionElement.YearPublished.Value), nameof(Models.ThingCollection.Thing.Version.YearPublished))]
        [MapProperty(nameof(ThingResult.ItemElement.VersionCollectionElement.VersionElement.ProductCode.Value), nameof(Models.ThingCollection.Thing.Version.ProductCode))]
        [MapProperty(nameof(ThingResult.ItemElement.VersionCollectionElement.VersionElement.Width.Value), nameof(Models.ThingCollection.Thing.Version.Width))]
        [MapProperty(nameof(ThingResult.ItemElement.VersionCollectionElement.VersionElement.Length.Value), nameof(Models.ThingCollection.Thing.Version.Length))]
        [MapProperty(nameof(ThingResult.ItemElement.VersionCollectionElement.VersionElement.Depth.Value), nameof(Models.ThingCollection.Thing.Version.Depth))]
        [MapProperty(nameof(ThingResult.ItemElement.VersionCollectionElement.VersionElement.Weight.Value), nameof(Models.ThingCollection.Thing.Version.Weight))]
        private static partial Models.ThingCollection.Thing.Version ToVersion(ThingResult.ItemElement.VersionCollectionElement.VersionElement model);

        private static Models.PagedCollection<Models.ThingCollection.Thing.Comment> CreateCommentPagedCollection(ThingResult.ItemElement source)
        {
            return new Models.PagedCollection<Models.ThingCollection.Thing.Comment>
            {
                Total = source.CommentList.TotalItems,
                Page = source.CommentList.Page,
                Items = source.CommentList.Comments.ConvertAll(ToComment)
            };
        }

        private static partial Models.ThingCollection.Thing.Comment ToComment(ThingResult.ItemElement.CommentCollectionElement.CommentElement model);

        [MapProperty(nameof(ThingResult.ItemElement.StatisticsElement.RatingsElement.Average.Value), nameof(Models.ThingCollection.Thing.ThingStatistics.AverageRating))]
        [MapProperty(nameof(ThingResult.ItemElement.StatisticsElement.RatingsElement.UsersRated.Value), nameof(Models.ThingCollection.Thing.ThingStatistics.UsersRated))]
        [MapProperty(nameof(ThingResult.ItemElement.StatisticsElement.RatingsElement.BayesAverage.Value), nameof(Models.ThingCollection.Thing.ThingStatistics.BayesAverage))]
        [MapProperty(nameof(ThingResult.ItemElement.StatisticsElement.RatingsElement.StandardDeviation.Value), nameof(Models.ThingCollection.Thing.ThingStatistics.StandardDeviation))]
        [MapProperty(nameof(ThingResult.ItemElement.StatisticsElement.RatingsElement.Median.Value), nameof(Models.ThingCollection.Thing.ThingStatistics.Median))]
        [MapProperty(nameof(ThingResult.ItemElement.StatisticsElement.RatingsElement.Owned.Value), nameof(Models.ThingCollection.Thing.ThingStatistics.Owned))]
        [MapProperty(nameof(ThingResult.ItemElement.StatisticsElement.RatingsElement.Trading.Value), nameof(Models.ThingCollection.Thing.ThingStatistics.Trading))]
        [MapProperty(nameof(ThingResult.ItemElement.StatisticsElement.RatingsElement.Wanting.Value), nameof(Models.ThingCollection.Thing.ThingStatistics.Wanting))]
        [MapProperty(nameof(ThingResult.ItemElement.StatisticsElement.RatingsElement.Wishing.Value), nameof(Models.ThingCollection.Thing.ThingStatistics.Wishing))]
        [MapProperty(nameof(ThingResult.ItemElement.StatisticsElement.RatingsElement.NumberOfComments.Value), nameof(Models.ThingCollection.Thing.ThingStatistics.NumberOfComments))]
        [MapProperty(nameof(ThingResult.ItemElement.StatisticsElement.RatingsElement.NumberOfWeights.Value), nameof(Models.ThingCollection.Thing.ThingStatistics.NumberOfWeights))]
        [MapProperty(nameof(ThingResult.ItemElement.StatisticsElement.RatingsElement.AverageWeight.Value), nameof(Models.ThingCollection.Thing.ThingStatistics.AverageWeight))]
        [MapperIgnoreSource(nameof(ThingResult.ItemElement.StatisticsElement.RatingsElement.RankCollection))]
        private static partial Models.ThingCollection.Thing.ThingStatistics ToThingStatistics(ThingResult.ItemElement.StatisticsElement.RatingsElement model);

        private static List<Models.ThingCollection.Thing.Ranking> CreateRankingCollection(ThingResult.ItemElement source)
        {
            return source.Statistics.Ratings.RankCollection.Ranks.ConvertAll(ToRanking);
        }

        [MapProperty(nameof(ThingResult.ItemElement.StatisticsElement.RatingsElement.RankCollectionElement.RankElement.Value), nameof(Models.ThingCollection.Thing.Ranking.Rank))]
        private static partial Models.ThingCollection.Thing.Ranking ToRanking(ThingResult.ItemElement.StatisticsElement.RatingsElement.RankCollectionElement.RankElement model);

        [MapProperty(nameof(ThingResult.ItemElement.MarketplaceListingCollectionElement.ListingElement.ListDateString.Value), nameof(Models.ThingCollection.Thing.MarketplaceListing.ListDate))]
        [MapProperty(nameof(ThingResult.ItemElement.MarketplaceListingCollectionElement.ListingElement.Price.Currency), nameof(Models.ThingCollection.Thing.MarketplaceListing.Currency))]
        [MapProperty(nameof(ThingResult.ItemElement.MarketplaceListingCollectionElement.ListingElement.Price.Value), nameof(Models.ThingCollection.Thing.MarketplaceListing.Price))]
        [MapProperty(nameof(ThingResult.ItemElement.MarketplaceListingCollectionElement.ListingElement.Condition.Value), nameof(Models.ThingCollection.Thing.MarketplaceListing.Condition))]
        [MapProperty(nameof(ThingResult.ItemElement.MarketplaceListingCollectionElement.ListingElement.Notes.Value), nameof(Models.ThingCollection.Thing.MarketplaceListing.Notes))]
        [MapProperty(nameof(ThingResult.ItemElement.MarketplaceListingCollectionElement.ListingElement.Link.Url), nameof(Models.ThingCollection.Thing.MarketplaceListing.Url))]
        [MapProperty(nameof(ThingResult.ItemElement.MarketplaceListingCollectionElement.ListingElement.Link.Title), nameof(Models.ThingCollection.Thing.MarketplaceListing.UrlTitle))]
        private static partial Models.ThingCollection.Thing.MarketplaceListing ToMarketplaceListing(ThingResult.ItemElement.MarketplaceListingCollectionElement.ListingElement model);

        private static TimeSpan TimespanFromMinutes(int minutes) => TimeSpan.FromMinutes(minutes);
    }
}
