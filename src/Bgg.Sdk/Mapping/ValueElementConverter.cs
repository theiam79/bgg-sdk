using AutoMapper;
using Bgg.Sdk.Core;
//using Bgg.Sdk.Models;

namespace Bgg.Sdk.Mapping
{
    internal class ValueElementConverter<T> : ITypeConverter<ValueElement<T>, T> where T : struct
    {
        public T Convert(ValueElement<T> source, T destination, ResolutionContext context)
        {
            return source.Value;
        }
    }

    internal class ValueElementConverter : ITypeConverter<ValueElement, string>
    {
        public string Convert(ValueElement source, string destination, ResolutionContext context)
        {
            return source.Value;
        }
    }
}
