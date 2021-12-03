using System.Runtime.Serialization;

namespace Bgg.Sdk.Core
{
    public enum ItemType
    {
        [EnumMember(Value = "boardgame")]
        Boardgame = 1,
        [EnumMember(Value = "boardgameexpansion")]
        BoardgameExpansion = 2,
        [EnumMember(Value = "boardgameaccessory")]
        BoardgameAccessory = 3,
        [EnumMember(Value = "videogame")]
        VideoGame = 4,
        [EnumMember(Value = "rpgitem")]
        RpgItem = 5,
        [EnumMember(Value = "rpgissue")]
        RpgIssue = 6
    }
}
