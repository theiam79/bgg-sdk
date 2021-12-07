using System.Xml.Serialization;

namespace Bgg.Sdk.Core
{
    public class NameElement
    {
        [XmlAttribute("type")]
        public NameType NameType { get; set; } = NameType.Unknown;
        [XmlAttribute("sortindex")]
        public int SortIndex { get; set; }
        [XmlAttribute("value")]
        public string Value { get; set; } = "";
    }
}
