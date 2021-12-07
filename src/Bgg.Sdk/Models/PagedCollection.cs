namespace Bgg.Sdk.Models
{
    public class PagedCollection<T>
    {
        public int Total { get; init; }
        public int Page { get; init; }
        public List<T> Items { get; init; } = new();
    }
}
