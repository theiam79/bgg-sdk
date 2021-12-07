using AutoMapper;
using Bgg.Sdk.Core;
//using Bgg.Sdk.Models;

namespace Bgg.Sdk.Mapping
{
    internal class MinuteStringToTimespanConverter : ITypeConverter<string, TimeSpan>
    {
        public TimeSpan Convert(string source, TimeSpan destination, ResolutionContext context)
        {
            var minutes = int.TryParse(source, out var parsed) ? parsed : default;
            return TimeSpan.FromMinutes(minutes);
        }
    }

    internal class ValueElementToDateTimeConverter : ITypeConverter<ValueElement, DateTime>
    {
        public DateTime Convert(ValueElement source, DateTime destination, ResolutionContext context)
        {
            return DateTime.TryParse(source.Value, out var parsed) ? parsed : default;
        }
    }
}
