using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Bgg.Sdk.Core.HotItems
{
    public class QueryParameters
    {
        public QueryParameters(HotListType hotListType)
        {
            HotListType = hotListType;
        }

        [AliasAs("type")]
        public HotListType HotListType { get; set; }
    }

    public enum HotListType
    {
        [EnumMember(Value ="boardgame")]
        Boardgame = 1,
        [EnumMember(Value ="rpg")]
        Rpg = 2,
        [EnumMember(Value="videogame")]
        Videogame = 3,
        [EnumMember(Value="boardgameexpansion")]
        BoardgameExpansion = 4,
        [EnumMember(Value ="rpgperson")]
        RpgPerson = 5,
        [EnumMember(Value="boardgamecompany")]
        BoardgameCompany = 6,
        [EnumMember(Value = "rpgcompany")]
        RpgCompany = 7,
        [EnumMember(Value = "videogamecompany")]
        VideogameCompany = 8
    }
}
