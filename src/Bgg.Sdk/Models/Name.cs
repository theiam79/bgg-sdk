using Bgg.Sdk.Core;

namespace Bgg.Sdk.Models
{
    public class Name
    {
        public NameType NameType { get; init; }
        public int SortIndex { get; init; }
        public string Value { get; init; } = "";
    }
}
