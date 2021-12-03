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
        public Item[] Items = Array.Empty<Item>();
    }
}
