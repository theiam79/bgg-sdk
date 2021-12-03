using Bgg.Sdk.Core;
using Bgg.Sdk.UI.Terminal;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Refit;
using Polly;

public static class Program
{
    public static async Task Main(string[] args)
    {
        var host = Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                services.AddTransient<Application>();

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
            })
            .Build();

        var app = host.Services.GetRequiredService<Application>();

        await app.Run();
    }
}


