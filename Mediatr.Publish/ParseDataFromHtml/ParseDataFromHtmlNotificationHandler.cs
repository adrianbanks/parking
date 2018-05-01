using MediatR;
using Parking.Domain;
using Parking.Mediatr.Publish.BestMatchCarPark;

namespace Parking.Mediatr.Publish.ParseDataFromHtml
{
    internal sealed class ParseDataFromHtmlNotificationHandler : NotificationHandler<ParseDataFromHtmlNotification>
    {
        private readonly IMediator mediator;

        public ParseDataFromHtmlNotificationHandler(IMediator mediator) => this.mediator = mediator;

        protected override async void HandleCore(ParseDataFromHtmlNotification notification)
        {
            var carParks = CarParkParser.ParseFromHtml(notification.Html);
            await mediator.Publish(new BestMatchCarParkNotification(carParks));
        }
    }
}
