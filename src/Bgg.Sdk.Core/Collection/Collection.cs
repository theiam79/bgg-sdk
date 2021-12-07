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
        public int TotalItems { get; init; }

        [XmlAttribute("termsofuse")]
        public string TermsOfUse { get; init; } = "";

        [XmlAttribute("pubdate")]
        public string PubDate { get; init; } = "";

        [XmlElement("item")]
        public List<ItemElement> Items { get; init; } = new();

        public class ItemElement
        {
            [XmlAttribute("objectid")]
            public int ObjectId { get; init; }

            [XmlElement("name")]
            public string Name { get; init; } = "";

            [XmlElement("yearpublished")]
            public int YearPublished { get; init; }

            [XmlElement("image")]
            public string Image { get; init; } = "";

            [XmlElement("thumbnail")]
            public string Thumbnail { get; init; } = "";

            [XmlElement("stats")]
            public StatsElement Stats { get; init; } = new();

            [XmlElement("status")]
            public StatusElement Status { get; init; } = new();

            [XmlElement("numplays")]
            public int NumPlays { get; init; }

            public class StatsElement
            {
                [XmlAttribute("minplayers")]
                public int MinPlayers { get; init; }

                [XmlAttribute("maxplayers")]
                public int MaxPlayers { get; init; }

                [XmlAttribute("minplaytime")]
                public int MinPlaytime { get; init; }

                [XmlAttribute("maxplaytime")]
                public int MaxPlaytime { get; init; }

                [XmlAttribute("playingtime")]
                public int Playtime { get; init; }

                [XmlAttribute("numowned")]
                public int NumberOwned { get; init; }
            }

            public class StatusElement
            {
                [XmlAttribute("own")]
                public bool Own { get; init; }

                [XmlAttribute("prevowned")]
                public bool PreviouslyOwned { get; init; }

                [XmlAttribute("fortrade")]
                public bool ForTrade { get; init; }

                [XmlAttribute("want")]
                public bool Want { get; init; }

                [XmlAttribute("wanttoplay")]
                public bool WantToPlay { get; init; }

                [XmlAttribute("wanttobuy")]
                public bool WantToBuy { get; init; }

                [XmlAttribute("wishlist")]
                public bool Wishlist { get; init; }

                [XmlAttribute("wishlistpriority")]
                public int WishlistPriority { get; init; }

                [XmlAttribute("preordered")]
                public bool Preordered { get; init; }

                [XmlAttribute("lastmodified")]
                public string LastModifiedString { get; init; } = "";
            }
        }
    }
}
