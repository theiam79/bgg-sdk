using System.Xml.Serialization;

namespace Bgg.Sdk.Core.Models.Collection
{

    public partial class Item
    {
        [XmlAttribute("objectid")]
        public int ObjectId { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("yearpublished")]
        public int YearPublished { get; set; }

        [XmlElement("image")]
        public string Image { get; set; }

        [XmlElement("thumbnail")]
        public string Thumbnail { get; set; }

        [XmlElement("stats")]
        public Stats Stats { get; set; }

        [XmlElement("status")]
        public Status Status { get; set; }

        [XmlElement("numplays")]
        public int NumPlays { get; set; }
    }
}
