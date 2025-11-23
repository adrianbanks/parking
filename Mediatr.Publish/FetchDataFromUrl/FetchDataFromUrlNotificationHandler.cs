using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Parking.Domain;
using Parking.Mediatr.Publish.ParseCarParksFromData;

namespace Parking.Mediatr.Publish.FetchDataFromUrl;

internal sealed class FetchDataFromUrlNotificationHandler(IMediator mediator) : INotificationHandler<FetchDataFromUrlNotification>
{
    public async Task Handle(FetchDataFromUrlNotification notification, CancellationToken cancellationToken)
    {
        var data = await DataFetcher.FetchData(notification.Url);
        await mediator.Publish(new ParseCarParksFromDataNotification(data), cancellationToken);
    }
}
