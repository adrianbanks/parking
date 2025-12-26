using System.Threading;
using System.Threading.Tasks;
using Mediator;
using Parking.Domain;
using Parking.Mediator.Publish.ParseCarParksFromData;

namespace Parking.Mediator.Publish.FetchDataFromUrl;

internal sealed class FetchDataFromUrlNotificationHandler(IMediator mediator) : INotificationHandler<FetchDataFromUrlNotification>
{
    public async ValueTask Handle(FetchDataFromUrlNotification notification, CancellationToken cancellationToken)
    {
        var data = await DataFetcher.FetchData(notification.Url);
        await mediator.Publish(new ParseCarParksFromDataNotification(data), cancellationToken);
    }
}
