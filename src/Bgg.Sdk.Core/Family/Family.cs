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
        public string TermsOfUse { get; set; } = "";
        [XmlElement("item")]
        public FamilyElement Family { get; set; } = new();
        public class FamilyElement
        {
            [XmlAttribute("type")]
            public FamilyType FamilyType { get; set; } = FamilyType.Unknown;
            [XmlAttribute("id")]
            public int Id { get; set; }
            [XmlElement("thumbnail")]
            public string ThumbnailUrl { get; set; } = "";
            [XmlElement("image")]
            public string ImageUrl { get; set; } = "";
            [XmlElement("name")]
            public List<NameElement> Names { get; set; } = new();
            [XmlElement("description")]
            public string Description { get; set; } = "";
            [XmlElement("link")]
            public List<LinkElement> Links { get; set; } = new();
        }
    }
}
