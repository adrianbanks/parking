using System.Threading.Tasks;
using LiteBus.Events;
using LiteBus.Events.Abstractions;
using LiteBus.Extensions.Microsoft.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Parking.LiteBus.Publish.Information;

namespace Parking.LiteBus.Publish;

public static class Program
{
    public static async Task Main()
    {
        var host = new HostBuilder()
            .ConfigureServices((_, collection) =>
            {
                collection.AddLiteBus(liteBus =>
                {
                    liteBus.AddEventModule(module =>
                    {
                        module.RegisterFromAssembly(typeof(Program).Assembly);
                    });
                });
            })
            .Build();

        var publisher = host.Services.GetRequiredService<IEventPublisher>();

        await publisher.PublishAsync(new InformationEvent());
    }
}
