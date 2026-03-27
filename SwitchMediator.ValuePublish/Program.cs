using System.Threading.Tasks;
using Mediator.Switch;
using Mediator.Switch.Extensions.Microsoft.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Parking.SwitchMediator.ValuePublish.Information;

namespace Parking.SwitchMediator.ValuePublish;

public static class Program
{
    public static async Task Main()
    {
        var host = new HostBuilder()
            .ConfigureServices((_, collection) =>
            {
                collection.AddMediator<AppMediator>(options =>
                {
                    options.KnownTypes = AppMediator.KnownTypes;
                });
            })
            .Build();

        var publisher = host.Services.GetRequiredService<IValuePublisher>();
        await publisher.Publish(new InformationEvent());
    }
}
