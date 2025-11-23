using MediatR;
using Parking.Domain;
using Parking.Mediatr.Publish.ParseCarParksFromData;

namespace Parking.Mediatr.Publish.FetchDataFromUrl;

internal sealed class FetchDataFromUrlNotificationHandler(IMediator mediator) : NotificationHandler<FetchDataFromUrlNotification>
{
    protected override async void HandleCore(FetchDataFromUrlNotification notification)
    {
        var data = await DataFetcher.FetchData(notification.Url);
        await mediator.Publish(new ParseCarParksFromDataNotification(data));
    }
}
