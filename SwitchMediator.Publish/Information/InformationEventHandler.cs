using System.Threading;
using System.Threading.Tasks;
using Mediator.Switch;
using Parking.Domain;
using Parking.SwitchMediator.Publish.FetchDataFromUrl;

namespace Parking.SwitchMediator.Publish.Information;

internal sealed class InformationEventHandler(IPublisher publisher) : INotificationHandler<InformationEvent>
{
    public async Task Handle(InformationEvent notification, CancellationToken cancellationToken)
    {
        await publisher.Publish(new FetchDataFromUrlEvent(SourceData.Url), cancellationToken);
    }
}
