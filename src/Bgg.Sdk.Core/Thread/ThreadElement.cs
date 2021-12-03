using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bgg.Sdk.Core.Thread
{
    [XmlRoot("thread")]
    public class ThreadElement
    {
        [XmlAttribute("id")]
        public int Id { get; init; }
        [XmlAttribute("numarticles")]
        public int NumberOfArticles { get; init; }
        [XmlAttribute("link")]
        public string Link { get; init; } = "";
        [XmlAttribute("termsofuse")]
        public string TermsOfUse { get; init; } = "";
        [XmlElement("subject")]
        public string Subject { get; init; } = "";
        [XmlElement("articles")]
        public ArticleCollectionElement ArticleCollection { get; init; } = new();
        public class ArticleCollectionElement
        {
            [XmlElement("article")]
            public List<ArticleElement> Articles { get; init; } = new();
            public class ArticleElement
            {
                [XmlAttribute("id")]
                public int Id { get; init; }
                [XmlAttribute("username")]
                public string Username { get; init; } = "";
                [XmlAttribute("link")]
                public string Link { get; init; } = "";
                [XmlAttribute("postdate")]
                public DateTime PostDate { get; init; }
                [XmlAttribute("editdate")]
                public DateTime EditDate { get; init; }
                [XmlAttribute("numedits")]
                public int NumberOfEdits { get; init; }
                [XmlElement("subject")]
                public string Subject { get; init; } = "";
                [XmlElement("body")]
                public string Body { get; init; } = "";
            }
        }
    }
}
