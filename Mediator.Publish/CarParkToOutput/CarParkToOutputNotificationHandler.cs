using System.Threading;
using System.Threading.Tasks;
using Mediator;
using Parking.Domain;
using Parking.Mediator.Publish.SendOutput;

namespace Parking.Mediator.Publish.CarParkToOutput;

internal sealed class CarParkToOutputNotificationHandler(IMediator mediator) : INotificationHandler<CarParkToOutputNotification>
{
    public async ValueTask Handle(CarParkToOutputNotification notification, CancellationToken cancellationToken)
    {
        var output = CarParkOutputFormatter.Format(notification.CarPark);
        await mediator.Publish(new SendOutputNotification(output), cancellationToken);
    }
}
