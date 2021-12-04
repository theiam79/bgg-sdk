using System.Xml.Serialization;

namespace Bgg.Sdk.Core
{
    public class LinkElement
    {
        [XmlAttribute("type")]
        public LinkType LinkType { get; set; } = 0;
        [XmlAttribute("id")]
        public int Id { get; set; }
        [XmlAttribute("value")]
        public string Value { get; set; } = "";
        [XmlAttribute("inbound")]
        public bool Inbound { get; set; }
    }
}
