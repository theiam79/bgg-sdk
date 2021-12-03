using System.Xml.Serialization;

namespace Bgg.Sdk.Core.Collection
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

        [XmlAttribute("playingtime")]
        public int Playtime { get; set; }

        [XmlAttribute("numowned")]
        public int NumberOwned { get; set; }
        
        //[XmlElement("rating")]
        //public ValueElement Rating { get; set; }
    }
}
