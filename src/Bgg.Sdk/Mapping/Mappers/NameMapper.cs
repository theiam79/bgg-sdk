
using Bgg.Sdk.Core;
using Bgg.Sdk.Models;
using Riok.Mapperly.Abstractions;

namespace Bgg.Sdk.Mapping.Mappers
{
    [Mapper]
    internal static partial class NameMapper
    {
        public static partial Name ToName(NameElement model);

    }
}
