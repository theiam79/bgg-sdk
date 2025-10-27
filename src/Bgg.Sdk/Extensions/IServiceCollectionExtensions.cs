using Bgg.Sdk.Core;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Polly;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bgg.Sdk.Extensions
{
    /// <summary>
    /// Extension methods for <see cref="IServiceCollection"/>
    /// </summary>
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Registers the default implementation of <see cref="IBggApi"/> and <see cref="IBggClient"/>, as well as all maps used by the library
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> to register services with</param>
        /// <returns>The <see cref="IServiceCollection"/> with the services registered</returns>
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

            services.AddAutoMapper(config =>
            {
                config.AddMaps(typeof(IBggClient));
            });
            services.TryAddTransient<IBggClient, BggClient>();
            return services;
        } 
    }
}
