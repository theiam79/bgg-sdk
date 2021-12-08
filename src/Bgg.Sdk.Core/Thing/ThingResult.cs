using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bgg.Sdk.Core.Thing
{
    [XmlRoot("items")]
    public class ThingResult
    {
        [XmlAttribute("termsofuse")]
        public string TermsOfUse { get; init; } = "";
        [XmlElement("item")]
        public List<ItemElement> Items { get; init; } = new();

        public class ItemElement
        {
            [XmlAttribute("type")]
            public ThingType ThingType { get; init; } = ThingType.Unknown;

            [XmlAttribute("id")]
            public int Id { get; init; }

            [XmlElement("thumbnail")]
            public string Thumbnail { get; init; } = "";

            [XmlElement("image")]
            public string Image { get; init; } = "";

            [XmlElement("name")]
            public List<NameElement> Names { get; init; } = new();

            [XmlElement("description")]
            public string Description { get; init; } = "";

            [XmlElement("yearpublished")]
            public ValueElement<int> YearPublished { get; init; } = new();

            [XmlElement("minplayers")]
            public ValueElement<int> MinPlayers { get; init; } = new();

            [XmlElement("maxplayers")]
            public ValueElement<int> MaxPlayers { get; init; } = new();

            [XmlElement("poll")]
            public List<PollElement> Polls { get; init; } = new();

            [XmlElement("playingtime")]
            public ValueElement<int> PlayingTime { get; init; } = new();

            [XmlElement("minplaytime")]
            public ValueElement<int> MinPlaytime { get; init; } = new();

            [XmlElement("maxplaytime")]
            public ValueElement<int> MaxPlaytime { get; init; } = new();

            [XmlElement("minage")]
            public ValueElement<int> MinAge { get; init; } = new();

            [XmlElement("link")]
            public List<LinkElement> Links { get; init; } = new();
            [XmlElement("videos")]
            public VideoCollectionElement VideoList { get; init; } = new();
            [XmlElement("versions")]
            public VersionCollectionElement VersionList { get; init; } = new();
            [XmlElement("comments")]
            public CommentCollectionElement CommentList { get; init; } = new();
            [XmlElement("statistics")]
            public StatisticsElement Statistics { get; init; } = new();
            [XmlElement("marketplacelistings")]
            public MarketplaceListingCollectionElement MarketplaceListingCollection { get; init; } = new();

            public class VideoCollectionElement
            {
                [XmlAttribute("total")]
                public int Total { get; init; }
                [XmlElement("video")]
                public List<VideoElement> Videos { get; init; } = new();
                public class VideoElement
                {
                    [XmlAttribute("id")]
                    public int Id { get; init; }
                    [XmlAttribute("title")]
                    public string Title { get; init; } = "";
                    [XmlAttribute("category")]
                    public string Category { get; init; } = "";
                    [XmlAttribute("language")]
                    public string Language { get; init; } = "";
                    [XmlAttribute("link")]
                    public string Url { get; init; } = "";
                    [XmlAttribute("username")]
                    public string UserName { get; init; } = "";
                    [XmlAttribute("userid")]
                    public int UserId { get; init; }
                    [XmlAttribute("postdate")]
                    public DateTime PostDate { get; init; }
                }
            }

            public class VersionCollectionElement
            {
                [XmlElement("item")]
                public List<VersionElement> Versions { get; init; } = new();
                public class VersionElement
                {
                    //[XmlAttribute("type")]
                    //public ThingType Type { get; init; } = ThingType.Unknown;
                    [XmlAttribute("id")]
                    public int Id { get; init; }
                    [XmlElement("thumbnail")]
                    public string Thumbnail { get; init; } = "";

                    [XmlElement("image")]
                    public string Image { get; init; } = "";

                    [XmlElement("name")]
                    public List<NameElement> Names { get; init; } = new();

                    [XmlElement("link")]
                    public List<LinkElement> Links { get; init; } = new();

                    [XmlElement("yearpublished")]
                    public ValueElement<int> YearPublished { get; init; } = new();
                    [XmlElement("productcode")]
                    public ValueElement ProductCode { get; init; } = new();
                    [XmlElement("width")]
                    public ValueElement<double> Width { get; init; } = new();
                    [XmlElement("length")]
                    public ValueElement<double> Length { get; init; } = new();
                    [XmlElement("depth")]
                    public ValueElement<double> Depth { get; init; } = new();
                    [XmlElement("weight")]
                    public ValueElement<double> Weight { get; init; } = new();
                }
            }

            public class CommentCollectionElement
            {
                [XmlAttribute("page")]
                public int Page { get; init; }
                [XmlAttribute("totalitems")]
                public int TotalItems { get; init; }
                [XmlElement("comment")]
                public List<CommentElement> Comments { get; init; } = new();
                public class CommentElement
                {
                    [XmlAttribute("username")]
                    public string UserName { get; init; } = "";
                    [XmlAttribute("rating")]
                    public string Rating { get; init; } = "";
                    [XmlAttribute("value")]
                    public string Value { get; init; } = "";
                }
            }

            public class StatisticsElement
            {
                [XmlElement("ratings")]
                public RatingsElement Ratings { get; init; } = new();
                public class RatingsElement
                {
                    [XmlElement("usersrated")]
                    public ValueElement<int> UsersRated { get; init; } = new();
                    [XmlElement("average")]
                    public ValueElement<double> Average { get; init; } = new();
                    [XmlElement("bayesaverage")]
                    public ValueElement<double> BayesAverage { get; init; } = new();
                    [XmlElement("ranks")]
                    public RankCollectionElement RankCollection { get; init; } = new();
                    [XmlElement("stddev")]
                    public ValueElement<double> StandardDeviation { get; init; } = new();
                    [XmlElement("median")]
                    public ValueElement<double> Median { get; init; } = new();
                    [XmlElement("owned")]
                    public ValueElement<int> Owned { get; init; } = new();
                    [XmlElement("trading")]
                    public ValueElement<int> Trading { get; init; } = new();
                    [XmlElement("wanting")]
                    public ValueElement<int> Wanting { get; init; } = new();
                    [XmlElement("wishing")]
                    public ValueElement<int> Wishing { get; init; } = new();
                    [XmlElement("numcomments")]
                    public ValueElement<int> NumberOfComments { get; init; } = new();
                    [XmlElement("numweights")]
                    public ValueElement<int> NumberOfWeights { get; init; } = new();
                    [XmlElement("avgerageweight")]
                    public ValueElement<double> AverageWeight { get; init; } = new();
                    public class RankCollectionElement
                    {
                        [XmlElement("rank")]
                        public List<RankElement> Ranks { get; init; } = new();
                        public class RankElement
                        {
                            [XmlAttribute("type")]
                            public RankType RankType { get; init; } = RankType.Unknown;
                            [XmlAttribute("id")]
                            public int Id { get; init; }
                            [XmlAttribute("name")]
                            public string Name { get; init; } = "";
                            [XmlAttribute("friendlyname")]
                            public string FriendlyName { get; init; } = "";
                            [XmlAttribute("value")]
                            public int Value { get; init; }
                            [XmlAttribute("bayesaverage")]
                            public double BayesAverage { get; init; }
                        }
                    }
                }
            }

            public class MarketplaceListingCollectionElement
            {
                [XmlElement("listing")]
                public List<ListingElement> Listings { get; init; } = new();
                public class ListingElement
                {
                    [XmlElement("listdate")]
                    public ValueElement ListDateString { get; init; } = new();
                    [XmlElement("price")]
                    public PriceElement Price { get; init; } = new();
                    [XmlElement("condition")]
                    public ValueElement Condition { get; init; } = new();
                    [XmlElement("notes")]
                    public ValueElement Notes { get; init; } = new();
                    [XmlElement("link")]
                    public SimpleLinkElement Link { get; init; } = new();
                    public class SimpleLinkElement
                    {
                        [XmlAttribute("href")]
                        public string Url { get; init; } = "";
                        [XmlAttribute("title")]
                        public string Title { get; init; } = "";
                    }
                    public class PriceElement
                    {
                        [XmlAttribute("currency")]
                        public string Currency { get; init; } = "";
                        [XmlAttribute("value")]
                        public double Value { get; init; }
                    }
                }
            }

            public class PollElement
            {
                [XmlAttribute("name")]
                public string Name { get; init; } = "";

                [XmlAttribute("title")]
                public string Title { get; init; } = "";

                [XmlAttribute("totalvotes")]
                public int TotalVotes { get; init; }
                [XmlElement("results")]
                public List<ResultCollectionElement> ResultCollections { get; init; } = new();
                public class ResultCollectionElement
                {
                    [XmlAttribute("numplayers")]
                    public string? NumberOfPlayers { get; init; }

                    [XmlElement("result")]
                    public PollResultElement[] Results { get; init; } = Array.Empty<PollResultElement>();
                    public class PollResultElement
                    {
                        [XmlAttribute("level")]
                        public string? Level { get; init; }
                        [XmlAttribute("value")]
                        public string Value { get; init; } = "";
                        [XmlAttribute("numvotes")]
                        public int NumberOfVotes { get; init; }
                    }
                }
            }
        }
    }
}
