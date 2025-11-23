using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Parking.Domain;
using Parking.Mediatr.Publish.BestMatchCarPark;

namespace Parking.Mediatr.Publish.ParseCarParksFromData;

internal sealed class ParseCarParksFromDataNotificationHandler(IMediator mediator) : INotificationHandler<ParseCarParksFromDataNotification>
{
    public async Task Handle(ParseCarParksFromDataNotification notification, CancellationToken cancellationToken)
    {
        var carParks = CarParkParser.Parse(notification.Data);
        await mediator.Publish(new BestMatchCarParkNotification(carParks), cancellationToken);
    }
}
