using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bgg.Sdk.Core.Collection
{
    [XmlRoot("items")]
    public class Collection
    {
        [XmlAttribute("totalitems")]
        public int TotalItems { get; set; }
        
        [XmlAttribute("termsofuse")]
        public string? TermsOfUse { get; set; }
        
        [XmlAttribute("pubdate")]
        public string? PubDate { get; set; }

        [XmlElement("item")]
        public List<ItemElement> Items { get; set; } = new();

        public class ItemElement
        {
            [XmlAttribute("objectid")]
            public int ObjectId { get; set; }

            [XmlElement("name")]
            public string Name { get; set; } = "";

            [XmlElement("yearpublished")]
            public int YearPublished { get; set; }

            [XmlElement("image")]
            public string Image { get; set; } = "";

            [XmlElement("thumbnail")]
            public string Thumbnail { get; set; } = "";

            [XmlElement("stats")]
            public StatsElement Stats { get; set; } = new();

            [XmlElement("status")]
            public StatusElement Status { get; set; } = new();

            [XmlElement("numplays")]
            public int NumPlays { get; set; }

            public class StatsElement
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
            }

            public class StatusElement
            {
                [XmlAttribute("own")]
                public bool Own { get; set; }

                [XmlAttribute("prevowned")]
                public bool PreviouslyOwned { get; set; }

                [XmlAttribute("fortrade")]
                public bool ForTrade { get; set; }

                [XmlAttribute("want")]
                public bool Want { get; set; }

                [XmlAttribute("wanttoplay")]
                public bool WantToPlay { get; set; }

                [XmlAttribute("wanttobuy")]
                public bool WantToBuy { get; set; }

                [XmlAttribute("wishlist")]
                public bool Wishlist { get; set; }

                [XmlAttribute("wishlistpriority")]
                public int? WishlistPriority { get; set; }

                [XmlAttribute("preordered")]
                public bool Preordered { get; set; }

                [XmlAttribute("lastmodified")]
                public string LastModifiedString { get; set; } = "";

                //[XmlIgnore]
                //public DateTime? LastModified => DateTime.TryParse(LastModifiedString, out var date) ? date : null;
            }
        }
    }
}
