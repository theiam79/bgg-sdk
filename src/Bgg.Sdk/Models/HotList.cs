namespace Bgg.Sdk.Models
{
    public class HotList
    {
        public string TermsOfUse { get; init; } = "";
        public List<HotItem> HotItems { get; init; } = new();
        public class HotItem
        {
            public int Id { get; init; }
            public int Rank { get; init; }
            public string ThumbnailUrl { get; init; } = "";
            public string Name { get; init; } = "";
            public int YearPublished { get; init; }
        }
    }
}
