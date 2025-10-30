using Bgg.Sdk.Core; 
using Bgg.Sdk.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Polly;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bgg.Sdk.Extensions
{
    /// <summary>
    /// Extension methods for <see cref="IServiceCollection"/>
    /// </summary>
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Registers the default implementation of <see cref="IBggApi"/> and <see cref="IBggClient"/>
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> to register services with</param>
        /// <returns>The <see cref="IServiceCollection"/> with the services registered</returns>
        public static IServiceCollection AddBggClient(this IServiceCollection services, string apiToken)
        {
            services
                .AddRefitClient<IBggApi>(new RefitSettings
                {
                    ContentSerializer = new XmlContentSerializer(),
                    DeserializationExceptionFactory = async (response, exception) =>
                    {
                        try
                        {
                            XmlSerializer serializer = new(typeof(ErrorResponse));
                            if (serializer.Deserialize(await response.Content.ReadAsStreamAsync()) is ErrorResponse errorResponse)
                            {
                                string[] bggErrors = [.. errorResponse.Errors.Select(e => e.Message)];
                                return new BggApiException($"Something went wrong reading the response from the Board Game Geek API", bggErrors);
                            }
                        }
                        catch (Exception) { }

                        return exception;
                    }
                })
                .ConfigureHttpClient(client =>
                {
                    client.BaseAddress = new Uri("https://boardgamegeek.com/xmlapi2");
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiToken);
                })
                .AddTransientHttpErrorPolicy(builder => builder
                    .OrResult(r => r.StatusCode == System.Net.HttpStatusCode.Accepted)
                    .WaitAndRetryAsync(5, attempt => TimeSpan.FromSeconds(Math.Pow(2, attempt))))
                ;

            services.TryAddTransient<IBggClient, BggClient>();
            return services;
        } 
    }
}
