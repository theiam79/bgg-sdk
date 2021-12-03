using System.Xml.Serialization;

namespace Bgg.Sdk.Core.User
{
    public class GuildInfo
    {
        [XmlAttribute("total")]
        public int Total { get; set; }
        [XmlAttribute("page")]
        public int Page { get; set; }
        [XmlElement("guild")]
        public Guild[] Guilds { get; set; } = Array.Empty<Guild>();
        public class Guild
        {
            [XmlAttribute("id")]
            public int Id { get; set; }
            [XmlAttribute("name")]
            public string Name { get; set; } = "";
        }
    }
}
