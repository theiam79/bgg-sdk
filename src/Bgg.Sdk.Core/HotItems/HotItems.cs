using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bgg.Sdk.Core.HotItems
{
    [XmlRoot("items")]
    public class HotItems
    {
        [XmlAttribute("termsofuse")]
        public string TermsOfUse { get; init; } = "";
        [XmlElement("item")]
        public List<ItemElement> Items { get; init; } = new();
        public class ItemElement
        {
            [XmlAttribute("id")]
            public int Id { get; init; }
            [XmlAttribute("rank")]
            public int Rank { get; init; }
            [XmlElement("thumbnail")]
            public ValueElement Thumbnail { get; init; } = new();
            [XmlElement("name")]
            public ValueElement Name { get; init; } = new();
            [XmlElement("yearpublished")]
            public ValueElement<int> YearPublished { get; init; } = new();
        }
    }
}
