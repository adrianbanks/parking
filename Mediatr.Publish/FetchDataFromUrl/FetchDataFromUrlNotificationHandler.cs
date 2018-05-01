using MediatR;
using Parking.Domain;
using Parking.Mediatr.Publish.ParseDataFromHtml;

namespace Parking.Mediatr.Publish.FetchDataFromUrl
{
    internal sealed class FetchDataFromUrlNotificationHandler : NotificationHandler<FetchDataFromUrlNotification>
    {
        private readonly IMediator mediator;

        public FetchDataFromUrlNotificationHandler(IMediator mediator) => this.mediator = mediator;

        protected override async void HandleCore(FetchDataFromUrlNotification notification)
        {
            var html = await DataFetcher.FetchData(notification.Url);
            await mediator.Publish(new ParseDataFromHtmlNotification(html));
        }
    }
}
