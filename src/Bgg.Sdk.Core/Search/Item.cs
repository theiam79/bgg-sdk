using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bgg.Sdk.Core.Search
{
    public class Item
    {
        [XmlAttribute("type")]
        public string Type { get; set; } = "";

        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlElement("name")]
        public Name Name = new();

        [XmlElement("yearpublished")]
        public ValueElement YearPublished = new();
    }
}
