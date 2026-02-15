using System.Threading;
using System.Threading.Tasks;
using LiteBus.Events.Abstractions;
using Parking.Domain;
using Parking.LiteBus.Publish.ParseCarParksFromData;

namespace Parking.LiteBus.Publish.FetchDataFromUrl;

internal sealed class FetchDataFromUrlEventHandler(IEventPublisher publisher) : IEventHandler<FetchDataFromUrlEvent>
{
    public async Task HandleAsync(FetchDataFromUrlEvent message, CancellationToken cancellationToken)
    {
        var data = await DataFetcher.FetchData(message.Url);
        await publisher.PublishAsync(new ParseCarParksFromDataEvent(data), cancellationToken);
    }
}
