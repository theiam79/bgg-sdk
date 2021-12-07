using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bgg.Sdk.Core.Forum
{
    [XmlRoot("forum")]
    public class Forum
    {
        [XmlIgnore]
        public int Page { get; set; }
        [XmlAttribute("id")]
        public int Id { get; init; }
        [XmlAttribute("title")]
        public string Title { get; init; } = "";
        [XmlAttribute("numthreads")]
        public int NumberOfThreads { get; init; }
        [XmlAttribute("numposts")]
        public int NumberOfPosts { get; init; }
        [XmlAttribute("lastpostdate")]
        public string LastPostDateString { get; init; } = "";
        [XmlAttribute("noposting")]
        public bool NoPosting { get; init; }
        [XmlAttribute("termsofuse")]
        public string TermsOfUse { get; init; } = "";
        [XmlElement("threads")]
        public ThreadCollectionElement ThreadCollection { get; init; } = new();
        public class ThreadCollectionElement
        {
            [XmlElement("thread")]
            public List<ThreadElement> Threads { get; init; } = new();
            public class ThreadElement
            {
                [XmlAttribute("id")]
                public int Id { get; init; }
                [XmlAttribute("subject")]
                public string Subject { get; init; } = "";
                [XmlAttribute("author")]
                public string Author { get; init; } = "";
                [XmlAttribute("numarticles")]
                public int NumberOfArticles { get; init; }
                [XmlAttribute("postdate")]
                public string PostDateString { get; init; } = "";
                [XmlAttribute("lastpostdate")]
                public string LastPostDateString { get; init; } = "";
            }
        }
    }
}
