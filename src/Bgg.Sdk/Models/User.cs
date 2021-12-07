using Bgg.Sdk.Core;

namespace Bgg.Sdk.Models
{
    public class User
    {
        public int Id { get; init; }
        public string Name { get; init; } = "";
        public string TermsOfUse { get; init; } = "";
        public string FirstName { get; init; } = "";
        public string LastName { get; init; } = "";
        public string AvatarLink { get; init; } = "";
        public int YearRegistered { get; init; }
        public DateTime LastLogin { get; init; }
        public string StateOrProvince { get; init; } = "";
        public string Country { get; init; } = "";
        public string WebAddress { get; init; } = "";
        public string XboxAccount { get; init; } = "";
        public string WiiAccount { get; init; } = "";
        public string PsnAccount { get; init; } = "";
        public string BattleNetAccount { get; init; } = "";
        public string SteamAccount { get; init; } = "";
        public int TradeRating { get; init; }
        public int MarketRating { get; init; }
        public PagedCollection<Buddy> Buddies { get; init; } = new();
        public PagedCollection<Guild> Guilds { get; init; } = new();
        public RankedCollection Top { get; init; } = new();
        public RankedCollection Hot { get; init; } = new();



        public class Buddy
        {
            public int Id { get; init; }
            public string Name { get; init; } = "";
        }

        public class Guild
        {
            public int Id { get; init; }
            public string Name { get; init; } = "";
        }

        public class RankedCollection
        {
            public RankingDomain Domain { get; init; }
            public List<RankedItem> Items { get; init; } = new();
            public class RankedItem
            {
                public int Rank { get; init; }
                public string Type { get; init; } = "";
                public int Id { get; init; }
                public string Name { get; init; } = "";
            }
        }
    }
}
