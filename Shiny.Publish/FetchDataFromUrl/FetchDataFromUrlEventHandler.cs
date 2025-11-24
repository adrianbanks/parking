using System.Threading;
using System.Threading.Tasks;
using Parking.Domain;
using Parking.Shiny.Publish.ParseCarParksFromData;
using Shiny.Mediator;

namespace Parking.Shiny.Publish.FetchDataFromUrl;

internal sealed class FetchDataFromUrlEventHandler : IEventHandler<FetchDataFromUrlEvent>
{
    public async Task Handle(FetchDataFromUrlEvent @event, IMediatorContext context, CancellationToken cancellationToken)
    {
        var data = await DataFetcher.FetchData(@event.Url);
        await context.Publish(new ParseCarParksFromDataEvent(data), cancellationToken: cancellationToken);
    }
}
