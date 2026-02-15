using System.Threading;
using System.Threading.Tasks;
using LiteBus.Events.Abstractions;
using Parking.Domain;
using Parking.LiteBus.Publish.SendOutput;

namespace Parking.LiteBus.Publish.CarParkToOutput;

internal sealed class CarParkToOutputEventHandler(IEventPublisher publisher) : IEventHandler<CarParkToOutputEvent>
{
    public async Task HandleAsync(CarParkToOutputEvent message, CancellationToken cancellationToken)
    {
        var output = CarParkOutputFormatter.Format(message.BestMatch);
        await publisher.PublishAsync(new SendOutputEvent(output), cancellationToken);
    }
}
