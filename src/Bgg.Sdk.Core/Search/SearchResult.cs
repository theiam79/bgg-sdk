using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bgg.Sdk.Core.Search
{
    [XmlRoot("items")]
    public class SearchResult
    {
        [XmlAttribute("total")]
        public int Total { get; init; }

        [XmlAttribute("termsofuse")]
        public string TermsOfUse { get; init; } = "";

        [XmlElement("item")]
        public List<ItemElement> Items = new();

        public class ItemElement
        {
            [XmlAttribute("type")]
            public ThingType ItemType { get; init; } = ThingType.Unknown;

            [XmlAttribute("id")]
            public int Id { get; init; }

            [XmlElement("name")]
            public NameElement Name = new();

            [XmlElement("yearpublished")]
            public ValueElement<int> YearPublished = new();
        }
    }
}
