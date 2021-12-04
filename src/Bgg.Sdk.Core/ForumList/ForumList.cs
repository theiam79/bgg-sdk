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
        public ForumListType ForumListType { get; set; } = ForumListType.Unknown;
        [XmlAttribute("id")]
        public int Id { get; set; }
        [XmlAttribute("termsofuse")]
        public string TermsOfUse { get; set; } = "";
        [XmlElement("forum")]
        public List<ForumElement> Forums { get; set; } = new();
        public class ForumElement
        {
            [XmlAttribute("id")]
            public int Id { get; set; }
            [XmlAttribute("groupid")]
            public int GroupId { get; set; }
            [XmlAttribute("title")]
            public string Title { get; set; } = "";
            [XmlAttribute("noposting")]
            public bool NoPosting { get; set; }
            [XmlAttribute("description")]
            public string Description { get; set; } = "";
            [XmlAttribute("numthreads")]
            public int NumberOfThreads { get; set; }
            [XmlAttribute("numposts")]
            public int NumberOfPosts { get; set; }
            [XmlAttribute("lastpostdate")]
            public string LastPostDateString { get; set; } = "";
            //[XmlIgnore]
            //public DateTime LastPostDate => DateTime.TryParse(LastPostDateString, out var date) ? date : default;
        }
    }

}
