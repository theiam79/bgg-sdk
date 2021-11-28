using System.Xml.Serialization;

namespace Bgg.Sdk.Core.Models.Collection
{
    public class Stats
    {
        [XmlAttribute("minplayers")]
        public int MinPlayers { get; set; }
        
        [XmlAttribute("maxplayers")]
        public int MaxPlayers { get; set; }
        
        [XmlAttribute("minplaytime")]
        public int MinPlaytime { get; set; }
        
        [XmlAttribute("maxplaytime")]
        public int MaxPlaytime { get; set; }
        
        [XmlElement("rating")]
        public ValueElement Rating { get; set; }
    }
}
