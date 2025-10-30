
using Bgg.Sdk.Core.Search;
using Riok.Mapperly.Abstractions;

namespace Bgg.Sdk.Mapping.Mappers
{
    [Mapper]
    internal static partial class SearchMapper
    {
        [MapProperty(nameof(SearchResult.Total), nameof(Models.SearchResult.TotalItems))]
        public static partial Models.SearchResult ToSearchResult(SearchResult model);

        [MapProperty(nameof(SearchResult.ItemElement.Name.Value), nameof(Models.SearchResult.Item.Name))]
        [MapProperty(nameof(SearchResult.ItemElement.YearPublished.Value), nameof(Models.SearchResult.Item.YearPublished))]
        private static partial Models.SearchResult.Item ToItem(SearchResult.ItemElement model);
    }
}
