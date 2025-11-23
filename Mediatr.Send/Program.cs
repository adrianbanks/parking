using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Parking.Mediatr.Send.Information;

namespace Parking.Mediatr.Send;

internal static class Program
{
    internal static async Task Main()
    {
        var services = new ServiceCollection();
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));
        var provider = services.BuildServiceProvider();
        var mediator = provider.GetRequiredService<IMediator>();

        var output = await mediator.Send(new InformationRequest());
        Console.WriteLine(output);
    }
}
