using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bgg.Sdk.Core
{
    public enum NameType
    {
        Unknown = 0,
        [XmlEnum("primary")]
        Primary = 1,
        [XmlEnum("alternate")]
        Alternate = 2
    }

    public enum LinkType
    {
        Unknown = 0,
        [XmlEnum("boardgamecategory")]
        BoardGameCategory = 1,
        [XmlEnum("boardgamemechanic")]
        BoardGameMechanic = 2,
        [XmlEnum("boardgamefamily")]
        BoardGameFamily = 3,
        [XmlEnum("boardgameexpansion")]
        BoardGameExpansion = 4,
        [XmlEnum("boardgameimplementation")]
        BoardGameImplemenetation = 5,
        [XmlEnum("boardgamedesigner")]
        BoardGameDesigner = 6,
        [XmlEnum("boardgameartist")]
        BoardGameArtist = 7,
        [XmlEnum("boardgamepublisher")]
        BoardGamePublisher = 8
    }

    public enum RankType
    {
        Unknown = 0,
        [XmlEnum("subtype")]
        SubType = 1,
        [XmlEnum("family")]
        Family = 2
    }

    public enum RankingDomain
    {
        Unknown = 0,
        [XmlEnum("boardgame")]
        BoardGame = 1
    }

    public enum ItemType
    {
        Unknown = 0,
        [EnumMember(Value = "boardgame")]
        [XmlEnum("boardgame")]
        Boardgame = 1,
        [EnumMember(Value = "boardgameexpansion")]
        [XmlEnum("boardgameexpansion")]
        BoardgameExpansion = 2,
        [EnumMember(Value = "boardgameaccessory")]
        [XmlEnum("boardgameaccessory")]
        BoardgameAccessory = 3,
        [EnumMember(Value = "videogame")]
        [XmlEnum("videogame")]
        VideoGame = 4,
        [EnumMember(Value = "rpgitem")]
        [XmlEnum("rpgitem")]
        RpgItem = 5,
        [EnumMember(Value = "rpgissue")]
        [XmlEnum("rpgissue")]
        RpgIssue = 6
    }

    public enum ForumListType
    {
        Unknown = 0,
        [EnumMember(Value = "thing")]
        [XmlEnum("thing")]
        Thing = 1,
        [EnumMember(Value = "family")]
        [XmlEnum("family")]
        Family = 2,
    }

    public enum FamilyType
    {
        Unknown = 0,
        [EnumMember(Value = "rpg")]
        [XmlEnum("rpg")]
        Rpg = 1,
        [EnumMember(Value = "rpgperiodical")]
        [XmlEnum("rpgperiodical")]
        RpgPeriodical = 2,
        [EnumMember(Value = "boardgamefamily")]
        [XmlEnum("boardgamefamily")]
        BoardGameFamily = 3
    }
}
