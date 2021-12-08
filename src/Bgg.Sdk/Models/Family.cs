using Bgg.Sdk.Core;

namespace Bgg.Sdk.Models
{
    public class FamilyCollection
    {
        public string TermsOfUse { get; init; } = "";
        public List<Family> Families { get; init; } = new();
        public class Family
        {
            public FamilyType FamilyType { get; init; }
            public int Id { get; init; }
            public string ThumbnailUrl { get; init; } = "";
            public string ImageUrl { get; init; } = "";
            public string Description { get; init; } = "";
            public List<Name> Names { get; init; } = new();
            public List<Link> Links { get; init; } = new();
        }
    }
}
