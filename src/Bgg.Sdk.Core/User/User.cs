using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Bgg.Sdk.Core;

namespace Bgg.Sdk.Core.User
{
    [XmlRoot("user")]
    public class User
    {
        [XmlAttribute("id")]
        public int Id { get; init; }
        [XmlAttribute("name")]
        public string Name { get; init; } = "";
        [XmlAttribute("termsofuse")]
        public string TermsOfUse { get; init; } = "";
        [XmlElement("firstname")]
        public ValueElement FirstName { get; init; } = new();
        [XmlElement("lastname")]
        public ValueElement LastName { get; init; } = new();
        [XmlElement("avatarlink")]
        public ValueElement AvatarLink { get; init; } = new();
        [XmlElement("yearregistered")]
        public ValueElement<int> YearRegistered { get; init; } = new();
        [XmlElement("lastlogin")]
        public ValueElement<DateTime> LastLogin { get; init; } = new();
        [XmlElement("stateorprovince")]
        public ValueElement StateOrProvince { get; init; } = new();
        [XmlElement("country")]
        public ValueElement Country { get; init; } = new();
        [XmlElement("webaddress")]
        public ValueElement WebAddress { get; init; } = new();
        [XmlElement("xboxaccount")]
        public ValueElement XboxAccount { get; init; } = new();
        [XmlElement("wiiaccount")]
        public ValueElement WiiAccount { get; init; } = new();
        [XmlElement("psnaccount")]
        public ValueElement PsnAccount { get; init; } = new();
        [XmlElement("battlenetaccount")]
        public ValueElement BattleNetAccount { get; init; } = new();
        [XmlElement("steamaccount")]
        public ValueElement SteamAccount { get; init; } = new();
        [XmlElement("traderating")]
        public ValueElement<int> TradeRating { get; init; } = new();
        [XmlElement("marketrating")]
        public ValueElement<int> MarketRating { get; init; } = new();
        [XmlElement("buddies")]
        public BuddyCollectionElement BuddyCollection { get; init; } = new();
        [XmlElement("guilds")]
        public GuildCollectionElement GuildCollection { get; init; } = new();
        [XmlElement("top")]
        public RankedCollectionElement Top { get; init; } = new();
        [XmlElement("hot")]
        public RankedCollectionElement Hot { get; init; } = new();

        public class BuddyCollectionElement
        {
            [XmlAttribute("total")]
            public int Total { get; init; }
            [XmlAttribute("page")]
            public int Page { get; init; }
            [XmlElement("buddy")]
            public List<BuddyElement> Buddies { get; init; } = new();
            public class BuddyElement
            {
                [XmlAttribute("id")]
                public int Id { get; init; }
                [XmlAttribute("name")]
                public string Name { get; init; } = "";
            }
        }

        public class GuildCollectionElement
        {
            [XmlAttribute("total")]
            public int Total { get; init; }
            [XmlAttribute("page")]
            public int Page { get; init; }
            [XmlElement("guild")]
            public List<GuildElement> Guilds { get; init; } = new();
            public class GuildElement
            {
                [XmlAttribute("id")]
                public int Id { get; init; }
                [XmlAttribute("name")]
                public string Name { get; init; } = "";
            }
        }

        public class RankedCollectionElement
        {
            [XmlAttribute("domain")]
            public RankingDomain Domain { get; init; } = RankingDomain.Unknown;

            [XmlElement("item")]
            public List<RankedItemElement> RankedItems { get; init; } = new();
            public class RankedItemElement
            {
                [XmlAttribute("rank")]
                public int Rank { get; init; }
                [XmlAttribute("type")]
                public string Type { get; init; } = "";
                [XmlAttribute("id")]
                public int Id { get; init; }
                [XmlAttribute("name")]
                public string Name { get; init; } = "";
            }
        }
    }
}
