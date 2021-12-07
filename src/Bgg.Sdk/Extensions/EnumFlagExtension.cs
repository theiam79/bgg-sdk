//using Bgg.Sdk.Models;

namespace Bgg.Sdk.Extensions
{
    internal static class EnumFlagExtension
    {
        internal static T GetFlag<T>(this bool value, T flag) where T : struct, Enum
        {
            return value ? flag : default;
        }
    }
}
