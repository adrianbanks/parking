using System.Threading;
using System.Threading.Tasks;
using Mediator.Switch;
using Parking.Domain;
using Parking.SwitchMediator.ValuePublish.BestMatchCarPark;

namespace Parking.SwitchMediator.ValuePublish.ParseCarParksFromData;

internal sealed class ParseCarParksFromDataEventHandler(IPublisher publisher) : IValueNotificationHandler<ParseCarParksFromDataEvent>
{
    public async ValueTask Handle(ParseCarParksFromDataEvent notification, CancellationToken cancellationToken)
    {
        var carParks = CarParkParser.Parse(notification.Data);
        await publisher.Publish(new BestMatchCarParkEvent(carParks), cancellationToken);
    }
}
