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
        public Item[] Items { get; init; } = Array.Empty<Item>();
    }

	public class Item
    {
		[XmlAttribute("type")]
		public string Type { get; init; } = "";

		[XmlAttribute("id")]
		public int Id { get; set; }

		[XmlElement("thumbnail")]
		public string Thumbnail { get; set; } = "";

		[XmlElement("image")]
		public string Image { get; set; } = "";

		[XmlElement("name")]
		public Name[] Names { get; set; }

		[XmlElement("description")]
		public string Description { get; set; } = "";

		[XmlElement("yearpublished")]
		public ValueElement<int> YearPublished { get; set; } = new();

		[XmlElement("minplayers")]
		public ValueElement<int> MinPlayers { get; set; } = new();

		[XmlElement("maxplayers")]
		public ValueElement<int> MaxPlayers { get; set; } = new();

        [XmlElement("poll")]
        public Poll[] Polls { get; set; } = Array.Empty<Poll>();

        [XmlElement("playingtime")]
		public ValueElement<int> PlayingTime { get; set; } = new();

		[XmlElement("minplaytime")]
		public ValueElement<int> MinPlaytime { get; set; } = new();

		[XmlElement("maxplaytime")]
		public ValueElement<int> MaxPlaytime { get; set; } = new();

		[XmlElement("minage")]
		public ValueElement<int> MinAge { get; set; } = new();

        [XmlElement("link")]
		public Link[] Links { get; set; } = Array.Empty<Link>();
        [XmlElement("videos")]
        public VideoList VideoList { get; init; } = new();
        [XmlElement("versions")]
        public VersionList VersionList { get; init; } = new();
        [XmlElement("comments")]
        public CommentList CommentList { get; init; } = new();
        [XmlElement("statistics")]
        public Statistics Statistics { get; init; } = new();
        [XmlElement("marketplacelistings")]
        public MarketplaceListingCollection MarketplaceListingCollection { get; init; } = new();
	}

    public class VideoList
    {
        [XmlAttribute("total")]
        public int Total { get; init; }
        [XmlElement("video")]
        public Video[] Videos { get; set; } = Array.Empty<Video>();
    }

    public class Video
    {
        [XmlAttribute("id")]
        public int Id { get; init; }
        [XmlAttribute("title")]
        public string Title { get; init; } = "";
        [XmlAttribute("category")]
        public string Category { get; init; } = "";
        [XmlAttribute("language")]
        public string Language { get; set; } = "";
        [XmlAttribute("link")]
        public string Link { get; set; } = "";
        [XmlAttribute("username")]
        public string UserName { get; init; } = "";
        [XmlAttribute("userid")]
        public int UserId { get; init; }
        [XmlAttribute("postdate")]
        public DateTime PostDate { get; init; }
    }

    public class VersionList
    {
        [XmlElement("item")]
        public List<Version> Versions { get; set; } = new();
    }

    public class Version
    {
        [XmlAttribute("type")]
        public string Type { get; init; } = "";
        [XmlAttribute("id")]
        public int Id { get; init; }
        [XmlElement("thumbnail")]
        public string Thumbnail { get; set; } = "";

        [XmlElement("image")]
        public string Image { get; set; } = "";

        [XmlElement("name")]
        public Name[] Names { get; set; } = Array.Empty<Name>();

        [XmlElement("link")]
        public Link[] Links { get; set; } = Array.Empty<Link>();

        [XmlElement("yearpublished")]
        public ValueElement<int> YearPublished { get; set; } = new();
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
        //[XmlElement("link")]
        //public Link Link { get; init; } = new();
    }

    public class CommentList
    {
        [XmlAttribute("page")]
        public int Page { get; init; }
        [XmlAttribute("totalitems")]
        public int TotalItems { get; init; }
        [XmlElement("comment")]
        public List<Comment> Comments { get; init; } = new();
    }
    public class Comment
    {
        [XmlAttribute("username")]
        public string UserName { get; init; } = "";
        [XmlAttribute("rating")]
        public string RatingString { get; init; } = "";
        [XmlAttribute("value")]
        public string Value { get; init; } = "";
    }

    public class Statistics
    {
        [XmlElement("ratings")]
        public Ratings Ratings { get; init; } = new();
    }

    public class Ratings
    {
        [XmlElement("usersrated")]
        public ValueElement<int> UsersRated { get; init; } = new();
        [XmlElement("average")]
        public ValueElement<double> Average { get; init; } = new();
        [XmlElement("bayesaverage")]
        public ValueElement<double> BayesAverage { get; init; } = new();
        [XmlElement("ranks")]
        public RankCollection RankCollection { get; init; } = new();
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
    }

    public class RankCollection
    {
        [XmlElement("rank")]
        public List<Rank> Ranks { get; init; } = new();
    }

    public class Rank
    {
        [XmlAttribute("type")]
        public string Type { get; init; } = "";
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

    public class MarketplaceListingCollection
    {
        [XmlElement("listing")]
        public List<Listing> Listings { get; init; } = new();
    }

    public class Listing
    {
        [XmlElement("listdate")]
        public ValueElement ListDateString { get; init; } = new();
        [XmlElement("price")]
        public Price Price { get; init; } = new();
        [XmlElement("condition")]
        public ValueElement Condition { get; init; } = new();
        [XmlElement("notes")]
        public ValueElement Notes { get; init; } = new();
        [XmlElement("link")]
        public LinkElement Link { get; init; } = new();
        public class LinkElement
        {
            [XmlAttribute("href")]
            public string Url { get; init; } = "";
            [XmlAttribute("title")]
            public string Title { get; init; } = "";
        }
    }

    public class Price
    {
        [XmlAttribute("currency")]
        public string Currency { get; init; } = "";
        [XmlAttribute("value")]
        public double Value { get; init; }
    }

	public class Poll
	{
		[XmlAttribute("name")]
		public string Name { get; set; } = "";

		[XmlAttribute("title")]
		public string Title { get; set; } = "";

		[XmlAttribute("totalvotes")]
		public int TotalVotes { get; set; }
        [XmlElement("results")]
        public ResultList[] ResultLists { get; set; } = Array.Empty<ResultList>();
	}

    public class ResultList
    {
        [XmlAttribute("numplayers")]
        public string? NumberOfPlayers { get; set; }

        [XmlElement("result")]
        public PollResult[] Results { get; init; } = Array.Empty<PollResult>();
    }

    public class PollResult
    {
        [XmlAttribute("level")]
        public string? Level { get; init; }
        [XmlAttribute("value")]
        public string Value { get; init; } = "";
        [XmlAttribute("numvotes")]
        public int NumberOfVotes { get; set; }
    }

    public class Name
	{
		[XmlAttribute("type")]
		public string Type { get; set; } = "";

		[XmlAttribute("sortindex")]
		public int SortIndex { get; set; }

		[XmlAttribute("value")]
		public string Value { get; set; } = "";
	}

	public class Link
	{
		[XmlAttribute("type")]
		public string Type { get; set; } = "";

		[XmlAttribute("id")]
		public int Id { get; set; }

		[XmlAttribute("value")]
		public string Value { get; set; } = "";
	}





    //[XmlType("numplayers")]
    //public class NumberOfPlayersPoll : Poll
    //   {
    //	[XmlElement("results")]
    //	public NumberOfPlayersResultList[] Results { get; set; } = Array.Empty<NumberOfPlayersResultList>();

    //	public class NumberOfPlayersResultList : ResultList<Result>
    //       {
    //		[XmlAttribute("numplayers")]
    //		public string NumberOfPlayers { get; init; } = "";

    //		//[XmlElement("result")]
    //		//public Result[] Results { get; init; } = Array.Empty<Result>();
    //	}
    //   }

    //public class LanguageDependencePoll : Poll
    //   {
    //	[XmlElement("results")]
    //	public ResultList<LanguageResult> Results { get; init; } = new();
    //	public class LanguageResult : Result
    //       {
    //		[XmlAttribute("level")]
    //		public int Level { get; init; }
    //       }
    //   }

    //public class AgePoll : Poll
    //   {
    //	[XmlElement("results")]
    //	public ResultList<Result> ResultsList { get; init; } = new();
    //   }

    //public class ResultList<T> where T : Result
    //   {
    //	[XmlElement("result")]
    //	public T[] Results { get; init; } = Array.Empty<T>();
    //}

    //public class Result
    //   {
    //	[XmlAttribute("value")]
    //	public string Value { get; set; } = "";
    //	[XmlAttribute("numvotes")]
    //	public int NumberOfVotes { get; init; }
    //   }


    //public class Poll
    //   {
    //	[XmlAttribute("name")]
    //	public string Name { get; set; } = "";

    //	[XmlAttribute("title")]
    //	public string Title { get; set; } = "";

    //	[XmlAttribute("totalvotes")]
    //	public int TotalVotes { get; set; }
    //}
}
