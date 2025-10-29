using Bgg.Sdk.Core;
using Bgg.Sdk.UI.Terminal;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Refit;
using Polly;
using Bgg.Sdk;
using Bgg.Sdk.Extensions;

public static class Program
{
    public static async Task Main(string[] args)
    {
        var host = Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                services.AddTransient<Application>();
                services.AddBggClient("YOUR_API_TOKEN");
            })
            .Build();

        var app = host.Services.GetRequiredService<Application>();

        await app.Run();
    }
}


