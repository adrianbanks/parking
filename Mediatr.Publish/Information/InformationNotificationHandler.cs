using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Parking.Domain;
using Parking.Mediatr.Publish.FetchDataFromUrl;

namespace Parking.Mediatr.Publish.Information;

internal sealed class InformationNotificationHandler(IMediator mediator) : INotificationHandler<InformationNotification>
{
    public async Task Handle(InformationNotification notification, CancellationToken cancellationToken)
    {
        await mediator.Publish(new FetchDataFromUrlNotification(SourceData.Url), cancellationToken);
    }
}
