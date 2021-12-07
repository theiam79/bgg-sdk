using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bgg.Sdk.Core
{
    public class ValueElement
    {
        [XmlAttribute("value")]
        public string Value { get; set; } = "";
    }

    public class ValueElement<T> where T : struct
    {
        [XmlAttribute("value")]
        public T Value { get; set; } = default;
    }
}
