using System.Threading.Tasks;
using Mediator;
using Microsoft.Extensions.DependencyInjection;
using Parking.Mediator.Publish.Information;

namespace Parking.Mediator.Publish;

public static class Program
{
    public static async Task Main()
    {
        var services = new ServiceCollection();
        services.AddMediator();
        var provider = services.BuildServiceProvider();
        var mediator = provider.GetRequiredService<IMediator>();

        await mediator.Publish(new InformationNotification());
    }
}
