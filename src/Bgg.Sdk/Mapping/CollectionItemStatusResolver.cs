using AutoMapper;
using Bgg.Sdk.Extensions;
//using Bgg.Sdk.Models;

namespace Bgg.Sdk.Mapping
{
    internal class CollectionItemStatusResolver : IValueResolver<Core.Collection.Collection.ItemElement, Models.Collection.CollectionItem, Models.Collection.CollectionItem.CollectionItemStatus>
    {
        public Models.Collection.CollectionItem.CollectionItemStatus Resolve(Core.Collection.Collection.ItemElement source,
                                                                             Models.Collection.CollectionItem destination,
                                                                             Models.Collection.CollectionItem.CollectionItemStatus destMember,
                                                                             ResolutionContext context)
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
    }
}
