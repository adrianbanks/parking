using System.Threading;
using System.Threading.Tasks;
using Mediator.Switch;
using Parking.Domain;
using Parking.SwitchMediator.ValuePublish.CarParkToOutput;

namespace Parking.SwitchMediator.ValuePublish.BestMatchCarPark;

internal sealed class BestMatchCarParkEventHandler(IPublisher publisher) : IValueNotificationHandler<BestMatchCarParkEvent>
{
    public async ValueTask Handle(BestMatchCarParkEvent notification, CancellationToken cancellationToken)
    {
        var bestCarPark = BestMatchCalculator.CalculateBestMatch(notification.CarParks);
        await publisher.Publish(new CarParkToOutputEvent(bestCarPark), cancellationToken);
    }
}
