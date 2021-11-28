﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bgg.Sdk.Core.Models.Collection
{
    [XmlRoot("items")]
    public class Collection
    {
        [XmlAttribute("totalitems")]
        public int TotalItems { get; set; }
        
        [XmlAttribute("termsofuse")]
        public string? TermsOfUse { get; set; }
        
        [XmlAttribute("pubdate")]
        public string? PubDate { get; set; }

        [XmlElement("item")]
        public Item[] Items { get; set; } = Array.Empty<Item>();
    }
}
