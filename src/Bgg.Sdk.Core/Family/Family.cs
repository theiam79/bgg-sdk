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
        public Family Family { get; set; } = new();

    }

    public class Family
    {
        [XmlAttribute("type")]
        public string FamilyType { get; set; } = "";
        [XmlAttribute("id")]
        public int Id { get; set; }
        [XmlElement("thumbnail")]
        public string ThumbnailUrl { get; set; } = "";
        [XmlElement("image")]
        public string ImageUrl { get; set; } = "";
        [XmlElement("name")]
        public Name[] Names { get; set; } = Array.Empty<Name>();
        [XmlElement("description")]
        public string Description { get; set; } = "";
        [XmlElement("link")]
        public Link[] Links { get; set; } = Array.Empty<Link>();
    }

    public class Name
    {
        [XmlAttribute("type")]
        public string Type { get; set; } = "";
        [XmlAttribute("sortindex")]
        public int SortIndex { get; set; }
        [XmlAttribute("value")]
        public string Value { get; set; } = "";
    }

    public class Link
    {
        [XmlAttribute("type")]
        public string Type { get; set; } = "";
        [XmlAttribute("id")]
        public int Id { get; set; }
        [XmlAttribute("value")]
        public string Value { get; set; } = "";
        [XmlAttribute("inbound")]
        public bool Inbound { get; set; }
    }
}
