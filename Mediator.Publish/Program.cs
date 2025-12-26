using System.Threading.Tasks;
using Mediator;
using Microsoft.Extensions.DependencyInjection;
using Parking.Mediator.Publish.Information;

namespace Parking.Mediator.Publish;

internal static class Program
{
    internal static async Task Main()
    {
        var services = new ServiceCollection();
        services.AddMediator();
        var provider = services.BuildServiceProvider();
        var mediator = provider.GetRequiredService<IMediator>();

        await mediator.Publish(new InformationNotification());
    }
}
