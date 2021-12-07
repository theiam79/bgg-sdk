using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bgg.Sdk.Core.ForumList
{
    [XmlRoot("forums")]
    public class ForumList
    {
        [XmlAttribute("type")]
        public ListType ForumListType { get; init; } = ListType.Unknown;
        [XmlAttribute("id")]
        public int Id { get; init; }
        [XmlAttribute("termsofuse")]
        public string TermsOfUse { get; init; } = "";
        [XmlElement("forum")]
        public List<ForumElement> Forums { get; init; } = new();
        public class ForumElement
        {
            [XmlAttribute("id")]
            public int Id { get; init; }
            [XmlAttribute("groupid")]
            public int GroupId { get; init; }
            [XmlAttribute("title")]
            public string Title { get; init; } = "";
            [XmlAttribute("noposting")]
            public bool NoPosting { get; init; }
            [XmlAttribute("description")]
            public string Description { get; init; } = "";
            [XmlAttribute("numthreads")]
            public int NumberOfThreads { get; init; }
            [XmlAttribute("numposts")]
            public int NumberOfPosts { get; init; }
            [XmlAttribute("lastpostdate")]
            public string LastPostDateString { get; init; } = "";
        }
    }

}
