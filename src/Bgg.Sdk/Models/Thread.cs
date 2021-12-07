namespace Bgg.Sdk.Models
{
    public class Thread
    {
        public int Id { get; init; }
        public int NumberOfArticles { get; init; }
        public string Url { get; init; } = "";
        public string TermsOfUse { get; init; } = "";
        public string Subject { get; init; } = "";
        public List<Article> Articles { get; init; } = new();
        public class Article
        {
            public int Id { get; init; }
            public string Username { get; init; } = "";
            public string Url { get; init; } = "";
            public DateTime PostDate { get; init; }
            public DateTime EditDate { get; init; }
            public int NumberOfEdits { get; init; }
            public string Subject { get; init; } = "";
            public string Body { get; init; } = "";
        }
    }
}
