using System.Threading;
using System.Threading.Tasks;
using Mediator.Switch;
using Parking.Domain;
using Parking.SwitchMediator.Publish.SendOutput;

namespace Parking.SwitchMediator.Publish.CarParkToOutput;

internal sealed class CarParkToOutputEventHandler(IPublisher publisher) : INotificationHandler<CarParkToOutputEvent>
{
    public async Task Handle(CarParkToOutputEvent notification, CancellationToken cancellationToken)
    {
        var output = CarParkOutputFormatter.Format(notification.CarPark);
        await publisher.Publish(new SendOutputEvent(output), cancellationToken: cancellationToken);
    }
}
