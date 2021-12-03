using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Bgg.Sdk.Core.Family
{
    public class QueryParameters
    {
        public QueryParameters(int id)
        {
            Id = id;
        }

        [AliasAs("id")]
        public int Id { get; set; }
        [AliasAs("type")]
        public FamilyType? FamilyType {get;set;}
    }

    public enum FamilyType
    {
        [EnumMember(Value = "rpg")]
        Rpg = 1,
        [EnumMember(Value = "rpgperiodical")]
        RpgPeriodical = 2,
        [EnumMember(Value = "boardgamefamily")]
        BoardGameFamily = 3
    }
}
