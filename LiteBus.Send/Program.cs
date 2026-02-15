using System.Threading.Tasks;
using LiteBus.Commands;
using LiteBus.Commands.Abstractions;
using LiteBus.Extensions.Microsoft.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Parking.LiteBus.Send.Information;

namespace Parking.LiteBus.Send;

public static class Program
{
    public static async Task Main()
    {
        var host = new HostBuilder()
            .ConfigureServices((_, collection) =>
            {
                collection.AddLiteBus(liteBus =>
                {
                    liteBus.AddCommandModule(module =>
                    {
                        module.RegisterFromAssembly(typeof(Program).Assembly);
                    });
                });
            })
            .Build();

        var mediator = host.Services.GetRequiredService<ICommandMediator>();

        await mediator.SendAsync(new InformationCommand());
    }
}
