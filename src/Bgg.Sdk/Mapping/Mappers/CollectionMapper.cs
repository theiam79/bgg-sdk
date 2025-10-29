
using Bgg.Sdk.Core.Collection;
using Bgg.Sdk.Extensions;
using Riok.Mapperly.Abstractions;

namespace Bgg.Sdk.Mapping.Mappers
{
    [Mapper]
    internal static partial class CollectionMapper
    {
        [MapProperty(nameof(Collection.ItemElement.Image), nameof(Models.Collection.CollectionItem.ImageUrl))]
        [MapProperty(nameof(Collection.ItemElement.Thumbnail), nameof(Models.Collection.CollectionItem.ThumbnailUrl))]
        [MapProperty(nameof(Collection.ItemElement.Stats.MinPlayers), nameof(Models.Collection.CollectionItem.MinimumPlayerCount))]
        [MapProperty(nameof(Collection.ItemElement.Stats.MaxPlayers), nameof(Models.Collection.CollectionItem.MaxPlayerCount))]
        [MapProperty(nameof(Collection.ItemElement.Stats.MinPlaytime), nameof(Models.Collection.CollectionItem.MinimumPlayTime))]
        [MapProperty(nameof(Collection.ItemElement.Stats.MaxPlaytime), nameof(Models.Collection.CollectionItem.MaximumPlayTime))]
        [MapProperty(nameof(Collection.ItemElement.Stats.Playtime), nameof(Models.Collection.CollectionItem.AveragePlayTime))]
        [MapProperty(nameof(Collection.ItemElement.Stats.NumberOwned), nameof(Models.Collection.CollectionItem.TotalOwnedCopies))]
        [MapProperty(nameof(Collection.ItemElement.Status.WishlistPriority), nameof(Models.Collection.CollectionItem.WishlistPriority))]
        [MapProperty(nameof(Collection.ItemElement.Status.LastModifiedString), nameof(Models.Collection.CollectionItem.StatusLastModified))]
        [MapPropertyFromSource(nameof(Models.Collection.CollectionItem.Status), Use =nameof(GetStatus))]
        private static partial Models.Collection.CollectionItem ToCollectionItem(Core.Collection.Collection.ItemElement item);

        private static Models.Collection.CollectionItem.CollectionItemStatus GetStatus(Collection.ItemElement source)
        {
            return
                source.Status.Own.GetFlag(Models.Collection.CollectionItem.CollectionItemStatus.Owned)
                | source.Status.PreviouslyOwned.GetFlag(Models.Collection.CollectionItem.CollectionItemStatus.PreviouslyOwned)
                | source.Status.ForTrade.GetFlag(Models.Collection.CollectionItem.CollectionItemStatus.ForTrade)
                | source.Status.Want.GetFlag(Models.Collection.CollectionItem.CollectionItemStatus.Want)
                | source.Status.WantToPlay.GetFlag(Models.Collection.CollectionItem.CollectionItemStatus.WantToPlay)
                | source.Status.WantToBuy.GetFlag(Models.Collection.CollectionItem.CollectionItemStatus.Want)
                | source.Status.Wishlist.GetFlag(Models.Collection.CollectionItem.CollectionItemStatus.Wishlist)
                | source.Status.Preordered.GetFlag(Models.Collection.CollectionItem.CollectionItemStatus.Preordered);
        }

        [MapProperty(nameof(Collection.PubDate), nameof(Models.Collection.GeneratedDate))]
        [MapProperty(nameof(Collection.Items), nameof(Models.Collection.CollectionItems))]
        public static partial Models.Collection ToCollection(Core.Collection.Collection collection);

        private static TimeSpan TimespanFromMinutes(int minutes) => TimeSpan.FromMinutes(minutes);
    }
}
