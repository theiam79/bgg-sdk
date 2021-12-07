using Bgg.Sdk.Core;

namespace Bgg.Sdk.Models
{
    public class ForumList
    {
        public ListType ForumListType { get; init; }
        public int Id { get; init; }
        public string TermsOfUse { get; init; } = "";
        public List<Forum> Forums { get; init; } = new();
        public class Forum
        {
            public int Id { get; init; }
            public int GroupId { get; init; }
            public string Title { get; init; } = "";
            public int NumberOfThreads { get; init; }
            public int NumberOfPosts { get; init; }
            public DateTime LastPostDate { get; init; }
            public bool NoPosting { get; init; }
            public string Description { get; init; } = "";
        }
    }
}
