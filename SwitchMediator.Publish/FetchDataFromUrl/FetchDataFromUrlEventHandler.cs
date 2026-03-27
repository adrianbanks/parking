using System.Threading;
using System.Threading.Tasks;
using Mediator.Switch;
using Parking.Domain;
using Parking.SwitchMediator.Publish.ParseCarParksFromData;

namespace Parking.SwitchMediator.Publish.FetchDataFromUrl;

internal sealed class FetchDataFromUrlEventHandler(IPublisher publisher) : INotificationHandler<FetchDataFromUrlEvent>
{
    public async Task Handle(FetchDataFromUrlEvent notification, CancellationToken cancellationToken)
    {
        var data = await DataFetcher.FetchData(notification.Url);
        await publisher.Publish(new ParseCarParksFromDataEvent(data), cancellationToken);
    }
}
