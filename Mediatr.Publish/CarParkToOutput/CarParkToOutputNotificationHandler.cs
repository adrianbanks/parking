using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Parking.Domain;
using Parking.Mediatr.Publish.SendOutput;

namespace Parking.Mediatr.Publish.CarParkToOutput;

internal sealed class CarParkToOutputNotificationHandler(IMediator mediator) : INotificationHandler<CarParkToOutputNotification>
{
    public async Task Handle(CarParkToOutputNotification notification, CancellationToken cancellationToken)
    {
        var output = CarParkOutputFormatter.Format(notification.CarPark);
        await mediator.Publish(new SendOutputNotification(output), cancellationToken);
    }
}
