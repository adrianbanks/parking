using System.Threading;
using System.Threading.Tasks;
using Mediator;
using Parking.Domain;
using Parking.Mediator.Publish.CarParkToOutput;

namespace Parking.Mediator.Publish.BestMatchCarPark;

internal sealed class BestMatchCarParkNotificationHandler(IMediator mediator) : INotificationHandler<BestMatchCarParkNotification>
{
    public async ValueTask Handle(BestMatchCarParkNotification notification, CancellationToken cancellationToken)
    {
        var bestCarPark = BestMatchCalculator.CalculateBestMatch(notification.CarParks);
        await mediator.Publish(new CarParkToOutputNotification(bestCarPark), cancellationToken);
    }
}
