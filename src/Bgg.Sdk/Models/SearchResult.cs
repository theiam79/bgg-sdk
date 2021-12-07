using Bgg.Sdk.Core;

namespace Bgg.Sdk.Models
{
    public class SearchResult
    {
        public int TotalItems { get; init; }
        public string TermsOfUse { get; init; } = "";
        public List<Item> Items { get; init; } = new();
        public class Item
        {
            public ThingType ItemType { get; init; }
            public int Id { get; init; }
            public string Name { get; init; } = "";
            public int YearPublished { get; init; }
        }
    }
}
