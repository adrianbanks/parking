using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Parking.Mediatr.Publish.Information;

namespace Parking.Mediatr.Publish;

internal static class Program
{
    internal static async Task Main()
    {
        var services = new ServiceCollection();
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));
        var provider = services.BuildServiceProvider();
        var mediator = provider.GetRequiredService<IMediator>();

        await mediator.Publish(new InformationNotification());
    }
}
