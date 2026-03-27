using System;
using System.Threading.Tasks;
using Mediator.Switch;
using Mediator.Switch.Extensions.Microsoft.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Parking.SwitchMediator.ValueSend.Information;

namespace Parking.SwitchMediator.ValueSend;

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

        var sender = host.Services.GetRequiredService<IValueSender>();
        var output = await sender.Send(new InformationRequest());
        Console.WriteLine(output);
    }
}
