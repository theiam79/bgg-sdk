using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bgg.Sdk.Core.Plays
{
    [XmlRoot("plays")]
    public class PlayResult
    {
        [XmlAttribute("total")]
        public int Total { get; init; }
        [XmlAttribute("page")]
        public int Page { get; init; }
        [XmlAttribute("termsofuse")]
        public string TermsOfUse { get; init; } = "";
        [XmlElement("play")]
        public List<PlayElement> Plays { get; init; } = new();
        public class PlayElement
        {
            [XmlAttribute("id")]
            public int Id { get; init; }
            [XmlAttribute("userid")]
            public int UserId { get; init; }
            [XmlAttribute("date")]
            public DateTime Date { get; init; }
            [XmlAttribute("quantity")]
            public int Quantity { get; init; }
            [XmlAttribute("length")]
            public int Length { get; init; }
            [XmlAttribute("incomplete")]
            public bool Incomplete { get; init; }
            [XmlAttribute("nowinstats")]
            public bool NowInStats { get; init; }
            [XmlAttribute("location")]
            public string Location { get; init; } = "";
            [XmlElement("item")]
            public ItemElement Item { get; init; } = new();
            [XmlElement("players")]
            public PlayerCollectionElement PlayerList { get; init; } = new();
            public class ItemElement
            {
                [XmlAttribute("name")]
                public string Name { get; init; } = "";
                [XmlAttribute("objecttype")]
                public string ObjectType { get; init; } = "";
                [XmlAttribute("objectid")]
                public int ObjectId { get; init; }
                [XmlElement("subtypes")]
                public TypeCollectionElement TypeList { get; init; } = new();
                public class TypeCollectionElement
                {
                    [XmlElement("subtype")]
                    public List<ValueElement> Subtypes { get; init; } = new();
                }
            }
            public class PlayerCollectionElement
            {
                [XmlElement("player")]
                public List<PlayerElement> Players { get; init; } = new();
                public class PlayerElement
                {
                    [XmlAttribute("username")]
                    public string Username { get; init; } = "";
                    [XmlAttribute("userid")]
                    public int UserId { get; init; }
                    [XmlAttribute("name")]
                    public string Name { get; init; } = "";
                    [XmlAttribute("startpostition")]
                    public string StartPostition { get; init; } = "";
                    [XmlAttribute("color")]
                    public string Color { get; init; } = "";
                    [XmlAttribute("score")]
                    public int Score { get; init; }
                    [XmlAttribute("new")]
                    public bool New { get; init; }
                    [XmlAttribute("rating")]
                    public int Rating { get; init; }
                    [XmlAttribute("win")]
                    public bool Win { get; init; }
                }
            }
        }
    }
}
