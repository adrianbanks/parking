using MediatR;
using Parking.Domain;
using Parking.Mediatr.Publish.BestMatchCarPark;

namespace Parking.Mediatr.Publish.ParseCarParksFromData
{
    internal sealed class ParseCarParksFromDataNotificationHandler(IMediator mediator) : NotificationHandler<ParseCarParksFromDataNotification>
    {
        protected override async void HandleCore(ParseCarParksFromDataNotification notification)
        {
            var carParks = CarParkParser.Parse(notification.Data);
            await mediator.Publish(new BestMatchCarParkNotification(carParks));
        }
    }
}
