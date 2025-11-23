using MediatR;
using Parking.Domain;
using Parking.Mediatr.Publish.BestMatchCarPark;

namespace Parking.Mediatr.Publish.ParseCarParksFromData
{
    internal sealed class ParseCarParksFromDataNotificationHandler : NotificationHandler<ParseCarParksFromDataNotification>
    {
        private readonly IMediator mediator;

        public ParseCarParksFromDataNotificationHandler(IMediator mediator) => this.mediator = mediator;

        protected override async void HandleCore(ParseCarParksFromDataNotification notification)
        {
            var carParks = CarParkParser.Parse(notification.Html);
            await mediator.Publish(new BestMatchCarParkNotification(carParks));
        }
    }
}
