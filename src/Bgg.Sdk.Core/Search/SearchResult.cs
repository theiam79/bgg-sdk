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
        public int Total { get; set; }

        [XmlAttribute("termsofuse")]
        public string TermsOfUse { get; set; } = "";

        [XmlElement("item")]
        public List<ItemElement> Items = new();

        public class ItemElement
        {
            [XmlAttribute("type")]
            public ItemType ItemType { get; set; } = ItemType.Unknown;

            [XmlAttribute("id")]
            public int Id { get; set; }

            [XmlElement("name")]
            public NameElement Name = new();

            [XmlElement("yearpublished")]
            public ValueElement YearPublished = new();
        }
    }
}
