using Bgg.Sdk.Core;
using Microsoft.Extensions.DependencyInjection;
using Polly;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bgg.Sdk.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddBgg(this IServiceCollection services)
        {
            services
                .AddRefitClient<IBggApi>(new RefitSettings
                {
                    ContentSerializer = new XmlContentSerializer()
                })
                .ConfigureHttpClient(client =>
                {
                    client.BaseAddress = new Uri("https://www.boardgamegeek.com/xmlapi2");
                })
                .AddTransientHttpErrorPolicy(builder => builder
                    .OrResult(r => r.StatusCode == System.Net.HttpStatusCode.Accepted)
                    .WaitAndRetryAsync(5, attempt => TimeSpan.FromSeconds(Math.Pow(2, attempt))))
                ;

            services.AddAutoMapper(typeof(BggClient));
            services.AddTransient<IBggClient, BggClient>();
            return services;
        } 
    }
}
