using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bgg.Sdk.Core.Guild
{
    [XmlRoot("guild")]
    public class Guild
    {
        [XmlAttribute("id")]
        public int Id { get; init; }
        [XmlAttribute("name")]
        public string Name { get; init; } = "";
        [XmlAttribute("created")]
        public string CreatedString { get; init; } = "";
        [XmlAttribute("termsofuse")]
        public string TermsOfUse { get; init; } = "";
        [XmlElement("category")]
        public string Category { get; init; } = "";
        [XmlElement("website")]
        public string Website { get; init; } = "";
        [XmlElement("manager")]
        public string Manager { get; init; } = "";
        [XmlElement("description")]
        public string Description { get; init; } = "";
        [XmlElement("location")]
        public LocationElement Location { get; init; } = new();
        [XmlElement("members")]
        public MemberCollectionElement MemberList { get; init; } = new();
        public class LocationElement
        {
            [XmlElement("addr1")]
            public string Address1 { get; init; } = "";
            [XmlElement("addr2")]
            public string Address2 { get; init; } = "";
            [XmlElement("city")]
            public string City { get; init; } = "";
            [XmlElement("stateorprovince")]
            public string StateOrProvince { get; init; } = "";
            [XmlElement("postalcode")]
            public string PostalCode { get; init; } = "";
            [XmlElement("country")]
            public string Country { get; init; } = "";
        }
        public class MemberCollectionElement
        {
            [XmlAttribute("count")]
            public int Count { get; init; }
            [XmlAttribute("page")]
            public int Page { get; init; }
            [XmlElement("member")]
            public List<MemberElement> Members { get; init; } = new();
            public class MemberElement
            {
                [XmlAttribute("name")]
                public string Name { get; init; } = "";
                [XmlAttribute("date")]
                public string DateString { get; init; } = "";
                [XmlIgnore]
                public DateTime Date => DateTime.TryParse(DateString, out var date) ? date : default;
            }
        }
    }



}
