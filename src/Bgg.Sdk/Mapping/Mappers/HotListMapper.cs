
using Bgg.Sdk.Core.HotItems;
using Riok.Mapperly.Abstractions;

namespace Bgg.Sdk.Mapping.Mappers
{
    [Mapper]
    internal static partial class HotListMapper
    {
        [MapProperty(nameof(HotItems.Items), nameof(Models.HotList.HotItems))]
        public static partial Models.HotList ToHotList(HotItems model);

        [MapProperty(nameof(HotItems.ItemElement.Thumbnail.Value), nameof(Models.HotList.HotItem.ThumbnailUrl))]
        [MapProperty(nameof(HotItems.ItemElement.Name.Value), nameof(Models.HotList.HotItem.Name))]
        [MapProperty(nameof(HotItems.ItemElement.YearPublished.Value), nameof(Models.HotList.HotItem.YearPublished))]
        private static partial Models.HotList.HotItem ToHotItem(HotItems.ItemElement model);
    }
}
