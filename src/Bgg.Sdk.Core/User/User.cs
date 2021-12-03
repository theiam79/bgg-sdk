﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Bgg.Sdk.Core;

namespace Bgg.Sdk.Core.User
{
    [XmlRoot("user")]
    public class User
    {
        [XmlAttribute("id")]
        public int Id { get; set; }
        [XmlAttribute("name")]
        public string Name { get; set; } = "";
        [XmlAttribute("termsofuse")]
        public string TermsOfUse { get; set; } = "";
        [XmlElement("firstname")]
        public ValueElement FirstName { get; set; } = new();
        [XmlElement("lastname")]
        public ValueElement LastName { get; set; } = new();
        [XmlElement("avatarlink")]
        public ValueElement AvatarLink { get; set; } = new();
        [XmlElement("yearregistered")]
        public ValueElement<int> YearRegistered { get; set; } = new();
        [XmlElement("lastlogin")]
        public ValueElement<DateTime> LastLogin { get; set; } = new();
        [XmlElement("stateorprovince")]
        public ValueElement StateOrProvince { get; set; } = new();
        [XmlElement("country")]
        public ValueElement Country { get; set; } = new();
        [XmlElement("webaddress")]
        public ValueElement WebAddress { get; set; } = new();
        [XmlElement("xboxaccount")]
        public ValueElement XboxAccount { get; set; } = new();
        [XmlElement("wiiaccount")]
        public ValueElement WiiAccount { get; set; } = new();
        [XmlElement("psnaccount")]
        public ValueElement PsnAccount { get; set; } = new();
        [XmlElement("battlenetaccount")]
        public ValueElement BattleNetAccount { get; set; } = new();
        [XmlElement("steamaccount")]
        public ValueElement SteamAccount { get; set; } = new();
        [XmlElement("traderating")]
        public ValueElement<int> TradeRating { get; set; } = new();
        [XmlElement("marketrating")]
        public ValueElement<int> MarketRating { get; set; } = new();
        [XmlElement("buddies")]
        public BuddyInfo Buddies { get; set; } = new();
        [XmlElement("guilds")]
        public GuildInfo Guilds { get; set; } = new();
        [XmlElement("top")]
        public RankedList Top { get; set; } = new();
        [XmlElement("hot")]
        public RankedList Hot { get; set; } = new();
    }
}
