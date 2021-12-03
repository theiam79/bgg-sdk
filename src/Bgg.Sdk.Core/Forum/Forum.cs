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
        [XmlAttribute("id")]
        public int Id { get; set; }
        [XmlAttribute("title")]
        public string Title { get; set; } = "";
        [XmlAttribute("numthreads")]
        public int NumberOfThreads { get; set; }
        [XmlAttribute("numposts")]
        public int NumberOfPosts { get; set; }
        [XmlAttribute("lastpostdate")]
        public string LastPostDateString { get; set; } = "";
        [XmlIgnore]
        public DateTime LastPostDate => DateTime.TryParse(LastPostDateString, out var date) ? date : default;
        [XmlAttribute("noposting")]
        public bool NoPosting { get; set; }
        [XmlAttribute("termsofuse")]
        public string TermsOfUse { get; set; } = "";
        [XmlElement("threads")]
        public ThreadCollection Threads { get; set; } = new();
    }

    public class ThreadCollection
    {
        [XmlElement("thread")]
        public Thread[] Threads { get; set; } = Array.Empty<Thread>();
    }

    public class Thread
    {
        [XmlAttribute("id")]
        public int Id { get; set; }
        [XmlAttribute("subject")]
        public string Subject { get; set; } = "";
        [XmlAttribute("author")]
        public string Author { get; set; } = "";
        [XmlAttribute("numarticles")]
        public int NumberOfArticles { get; set; }
        [XmlAttribute("postdate")]
        public string PostDateString { get; set; } = "";
        public DateTime PostDate => DateTime.TryParse(PostDateString, out var date) ? date : default;
        [XmlAttribute("lastpostdate")]
        public string LastPostDateString { get; set; } = "";
        public DateTime LastPostDate => DateTime.TryParse(LastPostDateString, out var date) ? date : default;
    }
}
