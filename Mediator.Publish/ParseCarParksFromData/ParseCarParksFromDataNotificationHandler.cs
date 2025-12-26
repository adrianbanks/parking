using System.Threading;
using System.Threading.Tasks;
using Mediator;
using Parking.Domain;
using Parking.Mediator.Publish.BestMatchCarPark;

namespace Parking.Mediator.Publish.ParseCarParksFromData;

internal sealed class ParseCarParksFromDataNotificationHandler(IMediator mediator) : INotificationHandler<ParseCarParksFromDataNotification>
{
    public async ValueTask Handle(ParseCarParksFromDataNotification notification, CancellationToken cancellationToken)
    {
        var carParks = CarParkParser.Parse(notification.Data);
        await mediator.Publish(new BestMatchCarParkNotification(carParks), cancellationToken);
    }
}
