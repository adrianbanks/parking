using System.Threading;
using System.Threading.Tasks;
using Mediator.Switch;
using Parking.Domain;
using Parking.SwitchMediator.ValuePublish.SendOutput;

namespace Parking.SwitchMediator.ValuePublish.CarParkToOutput;

internal sealed class CarParkToOutputEventHandler(IPublisher publisher) : IValueNotificationHandler<CarParkToOutputEvent>
{
    public async ValueTask Handle(CarParkToOutputEvent notification, CancellationToken cancellationToken)
    {
        var output = CarParkOutputFormatter.Format(notification.CarPark);
        await publisher.Publish(new SendOutputEvent(output), cancellationToken: cancellationToken);
    }
}
