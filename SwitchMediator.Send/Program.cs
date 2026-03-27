using System;
using System.Threading.Tasks;
using Mediator.Switch;
using Mediator.Switch.Extensions.Microsoft.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Parking.SwitchMediator.Send.Information;

namespace Parking.SwitchMediator.Send;

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

        var sender = host.Services.GetRequiredService<ISender>();
        var output = await sender.Send(new InformationRequest());
        Console.WriteLine(output);
    }
}
