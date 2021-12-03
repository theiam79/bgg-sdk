using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bgg.Sdk.Core.Search
{
    public class Name
    {
        [XmlAttribute("type")]
        public string Type { get; set; } = "";

        [XmlAttribute("value")]
        public string Value { get; set; } = "";
    }
}
