using System.Threading;
using System.Threading.Tasks;
using Mediator.Switch;
using Parking.Domain;
using Parking.SwitchMediator.ValuePublish.FetchDataFromUrl;

namespace Parking.SwitchMediator.ValuePublish.Information;

internal sealed class InformationEventHandler(IPublisher publisher) : IValueNotificationHandler<InformationEvent>
{
    public async ValueTask Handle(InformationEvent notification, CancellationToken cancellationToken)
    {
        await publisher.Publish(new FetchDataFromUrlEvent(SourceData.Url), cancellationToken);
    }
}
