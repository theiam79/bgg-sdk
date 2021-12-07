namespace Bgg.Sdk.Models
{
    public class Guild
    {
        public int Id { get; init; }
        public string Name { get; init; } = "";
        public DateTime CreatedDate { get; init; }
        public string TermsOfUse { get; init; } = "";
        public string Category { get; init; } = "";
        public string Website { get; init; } = "";
        public string Manager { get; init; } = "";
        public string Description { get; init; } = "";
        public PagedCollection<Member> Members { get; init; } = new();
        public LocationInfo Location { get; init; } = new();

        public class Member
        {
            public string Name { get; init; } = "";
            public DateTime JoinDate { get; init; }
        }

        public class LocationInfo
        {
            public string Address1 { get; set; } = "";
            public string Address2 { get; set; } = "";
            public string City { get; set; } = "";
            public string StateOrProvince { get; set; } = "";
            public string PostalCode { get; set; } = "";
            public string Country { get; set; } = "";
        }
    }
}
