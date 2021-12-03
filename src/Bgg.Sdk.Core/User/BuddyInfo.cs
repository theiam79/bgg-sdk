using System.Xml.Serialization;

namespace Bgg.Sdk.Core.User
{
    public class BuddyInfo
    {
        [XmlAttribute("total")]
        public int Total { get; set; }
        [XmlAttribute("page")]
        public int Page { get; set; }
        [XmlElement("buddy")]
        public Buddy[] Buddies { get; set; } = Array.Empty<Buddy>();
        public class Buddy
        {
            [XmlAttribute("id")]
            public int Id { get; set; }
            [XmlAttribute("name")]
            public string Name { get; set; } = "";
        }
    }
}
