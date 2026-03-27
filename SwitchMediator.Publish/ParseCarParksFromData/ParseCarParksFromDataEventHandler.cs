using System.Threading;
using System.Threading.Tasks;
using Mediator.Switch;
using Parking.Domain;
using Parking.SwitchMediator.Publish.BestMatchCarPark;

namespace Parking.SwitchMediator.Publish.ParseCarParksFromData;

internal sealed class ParseCarParksFromDataEventHandler(IPublisher publisher) : INotificationHandler<ParseCarParksFromDataEvent>
{
    public async Task Handle(ParseCarParksFromDataEvent notification, CancellationToken cancellationToken)
    {
        var carParks = CarParkParser.Parse(notification.Data);
        await publisher.Publish(new BestMatchCarParkEvent(carParks), cancellationToken);
    }
}
