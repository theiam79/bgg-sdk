using Bgg.Sdk.Core;

namespace Bgg.Sdk.Models
{
    public class PlayInfo
    {
        public string TermsOfUse { get; init; } = "";
        public PagedCollection<Play> Plays { get; init; } = new();
        public class Play
        {
            public int Id { get; init; }
            public int UserId { get; init; }
            public DateTime Date { get; init; }
            public int Quantity { get; init; }
            public TimeSpan Duration { get; init; }
            public bool Incomplete { get; init; }
            public bool NowInStats { get; init; }
            public string Location { get; init; } = "";
            public Item PlayedItem { get; init; } = new();
            public List<Player> Players { get; init; } = new();
            public class Item
            {
                public string Name { get; init; } = "";
                public ListType ObjectType { get; init; }
                public int ObjectId { get; init; }
                public ListSubType SubType { get; init; }
            }

            public class Player
            {
                public string Username { get; init; } = "";
                public int UserId { get; init; }
                public string Name { get; init; } = "";
                public string StartPostition { get; init; } = "";
                public string Color { get; init; } = "";
                public int Score { get; init; }
                public bool New { get; init; }
                public string Rating { get; init; } = "";
                public bool Winner { get; init; }
            }
        }
    }
}
