using System.Threading;
using System.Threading.Tasks;
using Mediator;
using Parking.Domain;
using Parking.Mediator.Publish.FetchDataFromUrl;

namespace Parking.Mediator.Publish.Information;

internal sealed class InformationNotificationHandler(IMediator mediator) : INotificationHandler<InformationNotification>
{
    public async ValueTask Handle(InformationNotification notification, CancellationToken cancellationToken)
    {
        await mediator.Publish(new FetchDataFromUrlNotification(SourceData.Url), cancellationToken);
    }
}
