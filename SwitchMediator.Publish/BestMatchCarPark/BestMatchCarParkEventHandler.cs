using System.Threading;
using System.Threading.Tasks;
using Mediator.Switch;
using Parking.Domain;
using Parking.SwitchMediator.Publish.CarParkToOutput;

namespace Parking.SwitchMediator.Publish.BestMatchCarPark;

internal sealed class BestMatchCarParkEventHandler(IPublisher publisher) : INotificationHandler<BestMatchCarParkEvent>
{
    public async Task Handle(BestMatchCarParkEvent notification, CancellationToken cancellationToken)
    {
        var bestCarPark = BestMatchCalculator.CalculateBestMatch(notification.CarParks);
        await publisher.Publish(new CarParkToOutputEvent(bestCarPark), cancellationToken);
    }
}
