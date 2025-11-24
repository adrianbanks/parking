using System.Threading;
using System.Threading.Tasks;
using Parking.Domain;
using Parking.Shiny.Publish.SendOutput;
using Shiny.Mediator;

namespace Parking.Shiny.Publish.CarParkToOutput;

internal sealed class CarParkToOutputEventHandler : IEventHandler<CarParkToOutputEvent>
{
    public async Task Handle(CarParkToOutputEvent @event, IMediatorContext context, CancellationToken cancellationToken)
    {
        var output = CarParkOutputFormatter.Format(@event.CarPark);
        await context.Publish(new SendOutputEvent(output), cancellationToken: cancellationToken);
    }
}
