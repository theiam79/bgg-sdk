using Bgg.Sdk.Core;

namespace Bgg.Sdk.Models
{
    public class Thing
    {
        public string TermsOfUse { get; init; } = "";
        public ThingType ThingType { get; init; }
        public int Id { get; init; }
        public string ThumbnailUrl { get; init; } = "";
        public string ImageUrl { get; init; } = "";
        public List<Name> Names { get; init; } = new();
        public string Description { get; init; } = "";
        public int YearPublished { get; init; }
        public int MinimumPlayerCount { get; init; }
        public int MaximumPlayerCount { get; init; }
        //public SuggestedPlayerCountPoll SuggestedPlayerCount { get; init; } = new();
        //public LanguageDependencePoll LanguageDependence { get; init; } = new();
        //public List<Poll<PollResult<PollOption>, PollOption>> OtherPolls { get; init; } = new();
        public List<Poll> Polls { get; init; } = new();
        public TimeSpan AveragePlaytime { get; init; }
        public TimeSpan MinimumPlaytime { get; init; }
        public TimeSpan MaximumPlaytime { get; init; }
        public int MinimumAge { get; init; }
        public List<Link> Links { get; init; } = new();
        public List<Video> Videos { get; init; } = new();
        public List<Version> Versions { get; init; } = new();
        public PagedCollection<Comment> Comments { get; init; } = new();
        public List<MarketplaceListing> MarketplaceListings { get; init; } = new();
        public ThingStatistics Statistics { get; init; } = new();
        public List<Ranking> Rankings { get; init; } = new();

        public class Video
        {
            public int Id { get; init; }
            public string Title { get; init; } = "";
            public string Category { get; init; } = "";
            public string Language { get; init; } = "";
            public string Url { get; init; } = "";
            public string UserName { get; init; } = "";
            public int UserId { get; init; }
            public DateTime PostDate { get; init; }
        }

        public class Version
        {
            //public ThingType Type { get; init; } = ThingType.Unknown;
            public int Id { get; init; }
            public string ThumbnailUrl { get; init; } = "";
            public string ImageUrl { get; init; } = "";
            public List<Name> Names { get; init; } = new();
            public List<Link> Links { get; init; } = new();
            public int YearPublished { get; init; }
            public string ProductCode { get; init; } = "";
            public double Width { get; init; }
            public double Length { get; init; }
            public double Depth { get; init; }
            public double Weight { get; init; }
        }

        public class Comment
        {
            public string UserName { get; init; } = "";
            public string Rating { get; init; } = "";
            public string Value { get; init; } = "";
        }

        public class MarketplaceListing
        {
            public DateTime ListDate { get; init; }
            public string Currency { get; init; } = "";
            public string Price { get; init; } = "";
            public string Condition { get; init; } = "";
            public string Notes { get; init; } = "";
            public string UrlTitle { get; init; } = "";
            public string Url { get; init; } = "";
        }


        public class ThingStatistics
        {
            public int UsersRated { get; init; }
            public double AverageRating { get; init; }
            public double BayesAverage { get; init; }
            public double StandardDeviation { get; init; }
            public double Median { get; init; }
            public int Owned { get; init; }
            public int Trading { get; init; }
            public int Wanting { get; init; }
            public int Wishing { get; init; }
            public int NumberOfComments { get; init; }
            public int NumberOfWeights { get; init; }
            public double AverageWeight { get; init; }
        }

        public class Ranking
        {
            public RankType RankType { get; init; }
            public int Id { get; init; }
            public string Name { get; init; } = "";
            public string FriendlyName { get; init; } = "";
            public int Rank { get; init; }
            public double BayesAverage { get; init; }
        }

        public class Poll
        {
            public string Name { get; init; } = "";
            public string Title { get; init; } = "";
            public int TotalVotes { get; init; }
            public List<PollResult> Results { get; init; } = new();
        }

        //public class SuggestedPlayerCountPoll : Poll<SuggestedPlayerCountResult, PollOption> { }
        //public class SuggestedPlayerCountResult : PollResult<PollOption>
        //{
        //    public string NumberOfPlayers { get; init; } = "";
        //}

        //public class LanguageDependencePoll : Poll<PollResult<LanguageDependenceOption>, LanguageDependenceOption> { }
        //public class LanguageDependenceOption : PollOption
        //{
        //    public int Level { get; init; }
        //}

        //public class Poll<TResult,TOption> where TResult : PollResult<TOption> where TOption : PollOption
        //{
        //    public string Name { get; init; } = "";
        //    public string Title { get; init; } = "";
        //    public int TotalVotes { get; init; }
        //    public List<TResult> Results { get; init; } = new();
        //}

        //public class PollResult<TOption> where TOption : PollOption
        //{
        //    public List<TOption> Options { get; init; } = new();
        //}

        public class PollResult
        {
            public List<PollOption> Options { get; init; } = new();
        }

        public class PollOption
        {
            public int Level { get; init; }
            public int NumberOfVotes { get; init; }
            public string Description { get; init; } = "";
        }
    }
}
