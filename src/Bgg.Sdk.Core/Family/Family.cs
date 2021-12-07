using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bgg.Sdk.Core.Family
{
    [XmlRoot("items")]
    public class FamilyResult
    {
        [XmlAttribute("termsofuse")]
        public string TermsOfUse { get; init; } = "";
        [XmlElement("item")]
        public FamilyElement Family { get; init; } = new();
        public class FamilyElement
        {
            [XmlAttribute("type")]
            public FamilyType FamilyType { get; init; } = FamilyType.Unknown;
            [XmlAttribute("id")]
            public int Id { get; init; }
            [XmlElement("thumbnail")]
            public string ThumbnailUrl { get; init; } = "";
            [XmlElement("image")]
            public string ImageUrl { get; init; } = "";
            [XmlElement("name")]
            public List<NameElement> Names { get; init; } = new();
            [XmlElement("description")]
            public string Description { get; init; } = "";
            [XmlElement("link")]
            public List<LinkElement> Links { get; init; } = new();
        }
    }
}
