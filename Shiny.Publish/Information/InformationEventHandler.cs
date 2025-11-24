using System.Threading;
using System.Threading.Tasks;
using Parking.Domain;
using Parking.Shiny.Publish.FetchDataFromUrl;
using Shiny.Mediator;

namespace Parking.Shiny.Publish.Information;

internal sealed class InformationEventHandler : IEventHandler<InformationEvent>
{
    public async Task Handle(InformationEvent @event, IMediatorContext context, CancellationToken cancellationToken)
    {
        await context.Publish(new FetchDataFromUrlEvent(SourceData.Url), cancellationToken: cancellationToken);
    }
}
