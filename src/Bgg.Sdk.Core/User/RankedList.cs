using System.Xml.Serialization;

namespace Bgg.Sdk.Core.User
{
    public class RankedList
    {
        [XmlAttribute("domain")]
        public string Domain { get; set; } = "";

        [XmlElement("item")]
        public RankedItem[] Items { get; set; } = Array.Empty<RankedItem>();
        public class RankedItem
        {
            [XmlAttribute("rank")]
            public int Rank { get; set; }
            [XmlAttribute("type")]
            public string Type { get; set; } = "";
            [XmlAttribute("id")]
            public int Id { get; set; }
            [XmlAttribute("name")]
            public string Name { get; set; } = "";
        }
    }
}
