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
        public int Id { get; set; }
        [XmlAttribute("name")]
        public string Name { get; set; } = "";
        [XmlAttribute("created")]
        public string CreatedString { get; set; } = "";
        //[XmlIgnore]
        //public DateTime Created => DateTime.TryParse(CreatedString, out var date) ? date : default;
        [XmlAttribute("termsofuse")]
        public string TermsOfUse { get; set; } = "";
        [XmlElement("category")]
        public string Category { get; set; } = "";
        [XmlElement("website")]
        public string Website { get; set; } = "";
        [XmlElement("manager")]
        public string Manager { get; set; } = "";
        [XmlElement("description")]
        public string Description { get; set; } = "";
        [XmlElement("location")]
        public LocationElement Location { get; init; } = new();
        [XmlElement("members")]
        public MemberCollectionElement MemberList { get; init; } = new();
        public class LocationElement
        {
            [XmlElement("addr1")]
            public string Address1 { get; set; } = "";
            [XmlElement("addr2")]
            public string Address2 { get; set; } = "";
            [XmlElement("city")]
            public string City { get; set; } = "";
            [XmlElement("stateorprovince")]
            public string StateOrProvince { get; set; } = "";
            [XmlElement("postalcode")]
            public string PostalCode { get; set; } = "";
            [XmlElement("country")]
            public string Country { get; set; } = "";
        }
        public class MemberCollectionElement
        {
            [XmlAttribute("count")]
            public int Count { get; set; }
            [XmlAttribute("page")]
            public int Page { get; set; }
            [XmlElement("member")]
            public List<MemberElement> Members { get; set; } = new();
            public class MemberElement
            {
                [XmlAttribute("name")]
                public string Name { get; set; } = "";
                [XmlAttribute("date")]
                public string DateString { get; set; } = "";
                [XmlIgnore]
                public DateTime Date => DateTime.TryParse(DateString, out var date) ? date : default;
            }
        }
    }



}
