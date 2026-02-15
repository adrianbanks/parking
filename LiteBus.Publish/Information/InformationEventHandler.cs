using System.Threading;
using System.Threading.Tasks;
using LiteBus.Events.Abstractions;
using Parking.Domain;
using Parking.LiteBus.Publish.FetchDataFromUrl;

namespace Parking.LiteBus.Publish.Information;

internal sealed class InformationEventHandler(IEventPublisher publisher) : IEventHandler<InformationEvent>
{
    public async Task HandleAsync(InformationEvent message, CancellationToken cancellationToken)
    {
        await publisher.PublishAsync(new FetchDataFromUrlEvent(SourceData.Url), cancellationToken: cancellationToken);
    }
}
