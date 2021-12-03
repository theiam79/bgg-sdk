using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Bgg.Sdk.Core.Plays
{
    public class QueryParameters
    {
        public QueryParameters(string username) : this(username, null) { }
        public QueryParameters(int id) : this(null, (int?)id) { }
        public QueryParameters(string username, int id) : this(username, (int?)id) { }

        private QueryParameters(string? username, int? id)
        {
            UserName = username;
            Id = id;
        }

        [AliasAs("username")]
        public string? UserName { get; init; }
        [AliasAs("id")]
        public int? Id { get; init; }
        [AliasAs("type")]
        public Type? Type { get; set; }
        [AliasAs("mindate")]
        public DateTime? MinimumDate { get; set; }
        [AliasAs("maxdate")]
        public DateTime? MaximumDate { get; set; }
        [AliasAs("subtype")]
        public SubType? SubType { get; set; }
        [AliasAs("page")]
        public int Page { get; set; } = 1;
    }

    public enum Type
    {
        [EnumMember(Value ="thing")]
        Thing = 1,
        [EnumMember(Value ="family")]
        Family = 2
    }

    public enum SubType
    {
        [EnumMember(Value = "boardgame")]
        Boardgame = 1,
        [EnumMember(Value = "boardgameexpansion")]
        BoardgameExpansion = 2,
        [EnumMember(Value = "boardgameaccessory")]
        BoardgameAccessory = 3,
        [EnumMember(Value = "boardgameintegration")]
        BoardgameIntegration = 4,
        [EnumMember(Value = "boardgamecompilation")]
        BoardgameCompilation = 5,
        [EnumMember(Value = "boardgameimplementation")]
        BoardgameImplementation = 6,
        [EnumMember(Value = "rpg")]
        Rpg = 7,
        [EnumMember(Value = "rpgitem")]
        RpgItem = 8,
        [EnumMember(Value = "videogame")]
        Videogame = 9
    }
}
