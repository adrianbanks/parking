using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Parking.Domain;
using Parking.Mediatr.Publish.CarParkToOutput;

namespace Parking.Mediatr.Publish.BestMatchCarPark;

internal sealed class BestMatchCarParkNotificationHandler(IMediator mediator) : INotificationHandler<BestMatchCarParkNotification>
{
    public async Task Handle(BestMatchCarParkNotification notification, CancellationToken cancellationToken)
    {
        var bestCarPark = BestMatchCalculator.CalculateBestMatch(notification.CarParks);
        await mediator.Publish(new CarParkToOutputNotification(bestCarPark), cancellationToken);
    }
}
