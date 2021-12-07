using AutoMapper;
using Bgg.Sdk.Core;
using Bgg.Sdk.Core.Thing;
using Bgg.Sdk.Models;
//using Bgg.Sdk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bgg.Sdk.Mapping
{
    internal class GlobalMappings : Profile
    {
        public GlobalMappings()
        {
            CreateMap<string, TimeSpan>().ConvertUsing<MinuteStringToTimespanConverter>();
            CreateMap<int, TimeSpan>().ConvertUsing(x => TimeSpan.FromMinutes(x));
            CreateMap<ValueElement<int>, TimeSpan>().ConvertUsing(x => TimeSpan.FromMinutes(x.Value));
            CreateMap<ValueElement, DateTime>().ConvertUsing<ValueElementToDateTimeConverter>();
            CreateMap<ValueElement<int>, int>().ConvertUsing<ValueElementConverter<int>>();
            CreateMap<ValueElement<double>, double>().ConvertUsing<ValueElementConverter<double>>();
            CreateMap<ValueElement<DateTime>, DateTime>().ConvertUsing<ValueElementConverter<DateTime>>();
            CreateMap<ValueElement, string>().ConvertUsing<ValueElementConverter>();
            CreateMap<Core.NameElement, Models.Name>();
            CreateMap<Core.LinkElement, Models.Link>()
                .ForMember(dest => dest.Direction, opt => opt.MapFrom<LinkDirectionResolver>());



            //CreateMap<Core.Thing.ThingResult.ItemElement.PollElement, KeyValuePair<string, Models.Thing.Poll>>()
            //    .ConstructUsing()
            //    .ForPath(dest => dest.Value.Results, opt => opt.MapFrom(src => src.ResultCollections))
            //    .ForPath(dest => dest.Key, opt => opt.MapFrom(src => src.Name));

            //CreateMap<Core.Thing.ThingResult.ItemElement.PollElement.ResultCollectionElement.PollResultElement, Models.Thing.PollOption>()
            //    .Include<Core.Thing.ThingResult.ItemElement.PollElement.ResultCollectionElement.PollResultElement, Models.Thing.LanguageDependenceOption>()
            //    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Value));

            //CreateMap<Core.Thing.ThingResult.ItemElement.PollElement.ResultCollectionElement.PollResultElement, Models.Thing.LanguageDependenceOption>()
            //    .ForMember(dest => dest.Level, opt => opt.MapFrom(src => src.Level));

            //CreateMap(typeof(Core.Thing.ThingResult.ItemElement.PollElement.ResultCollectionElement), typeof(Models.Thing.PollResult<>))
            //    .Include(typeof(Core.Thing.ThingResult.ItemElement.PollElement.ResultCollectionElement), typeof(Models.Thing.PollResult<Models.Thing.LanguageDependenceOption>))
            //    .Include(typeof(Core.Thing.ThingResult.ItemElement.PollElement.ResultCollectionElement), typeof(Models.Thing.SuggestedPlayerCountResult))
            //    .ForMember("Options", opt => opt.MapFrom("Results"));

            //CreateMap<Core.Thing.ThingResult.ItemElement.PollElement.ResultCollectionElement, Models.Thing.PollResult<Models.Thing.LanguageDependenceOption>>();
            //CreateMap<Core.Thing.ThingResult.ItemElement.PollElement.ResultCollectionElement, Models.Thing.SuggestedPlayerCountResult>()
            //    .ForMember(dest => dest.NumberOfPlayers, opt => opt.MapFrom(src => src.NumberOfPlayers));


            //CreateMap(typeof(Core.Thing.ThingResult.ItemElement.PollElement), typeof(Models.Thing.Poll<,>))
            //    .Include(typeof(Core.Thing.ThingResult.ItemElement.PollElement), typeof(Models.Thing.SuggestedPlayerCountPoll))
            //    .Include(typeof(Core.Thing.ThingResult.ItemElement.PollElement), typeof(Models.Thing.LanguageDependencePoll))
            //    .ForMember("Results", opt => opt.MapFrom("ResultCollections"));


            //CreateMap<Core.Thing.ThingResult, Models.Thing>()
            //    .ForMember(dest => dest.SuggestedPlayerCount, opt => opt.MapFrom(src => src.Item.Polls.FirstOrDefault(p => p.Name == "suggested_numplayers")))
            //    .ForMember(dest => dest.LanguageDependence, opt => opt.MapFrom(src => src.Item.Polls.FirstOrDefault(p => p.Name == "language_dependence")))
            //    .ForMember(dest => dest.OtherPolls, opt => opt.MapFrom(src => src.Item.Polls.Where(p => p.Name != "suggested_numplayers" && p.Name != "language_dependence")));
        }
    }

    //public class StringToDateTimeConverter : ITypeConverter<string, DateTime>
    //{
    //    public DateTime Convert(string source, DateTime destination, ResolutionContext context)
    //    {
    //        return DateTime.TryParse(source, out var parsed) ? parsed : default;
    //    }
    //}
}
