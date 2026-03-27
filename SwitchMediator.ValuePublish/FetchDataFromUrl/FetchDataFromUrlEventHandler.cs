using System.Threading;
using System.Threading.Tasks;
using Mediator.Switch;
using Parking.Domain;
using Parking.SwitchMediator.ValuePublish.ParseCarParksFromData;

namespace Parking.SwitchMediator.ValuePublish.FetchDataFromUrl;

internal sealed class FetchDataFromUrlEventHandler(IPublisher publisher) : IValueNotificationHandler<FetchDataFromUrlEvent>
{
    public async ValueTask Handle(FetchDataFromUrlEvent notification, CancellationToken cancellationToken)
    {
        var data = await DataFetcher.FetchData(notification.Url);
        await publisher.Publish(new ParseCarParksFromDataEvent(data), cancellationToken);
    }
}
