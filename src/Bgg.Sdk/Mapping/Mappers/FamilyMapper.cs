using Bgg.Sdk.Core.Family;
using Bgg.Sdk.Models;
using Riok.Mapperly.Abstractions;

namespace Bgg.Sdk.Mapping.Mappers
{
    [Mapper]
    [UseStaticMapper(typeof(LinkMapper))]
    [UseStaticMapper(typeof(NameMapper))]
    internal static partial class FamilyMapper
    {
        private static partial FamilyCollection.Family ToFamily(FamilyResult.FamilyElement model);
        public static partial FamilyCollection ToFamilyCollection(FamilyResult model);
    }
}
