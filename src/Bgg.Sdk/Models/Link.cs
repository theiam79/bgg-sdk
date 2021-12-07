using Bgg.Sdk.Core;

namespace Bgg.Sdk.Models
{
    public class Link
    {
        public LinkType LinkType { get; init; }
        public int Id { get; init; }
        public string Value { get; init; } = "";
        public LinkDirection Direction { get; init; }
    }
}
