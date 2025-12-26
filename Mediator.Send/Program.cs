using System;
using System.Threading.Tasks;
using Mediator;
using Microsoft.Extensions.DependencyInjection;
using Parking.Mediator.Send.Information;

namespace Parking.Mediator.Send;

internal static class Program
{
    internal static async Task Main()
    {
        var services = new ServiceCollection();
        services.AddMediator();
        var provider = services.BuildServiceProvider();
        var mediator = provider.GetRequiredService<IMediator>();

        var output = await mediator.Send(new InformationRequest());
        Console.WriteLine(output);
    }
}
