namespace Bgg.Sdk.Models
{
    public class Forum
    {
        public int Id { get; init; }
        public string Title { get; init; } = "";
        public int NumberOfThreads { get; init; }
        public int NumberOfPosts { get; init; }
        public DateTime LastPostDate { get; init; }
        public bool NoPosting { get; init; }
        public string TermsOfUse { get; init; } = "";
        public PagedCollection<Thread> Threads { get; init; } = new();
        public class Thread
        {
            public int Id { get; init; }
            public string Subject { get; init; } = "";
            public string Author { get; init; } = "";
            public int NumberOfArticles { get; init; }
            public DateTime CreateDate { get; init; }
            public DateTime LastPostDate { get; init; }
        }
    }
}
