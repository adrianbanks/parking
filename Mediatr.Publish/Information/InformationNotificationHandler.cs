using MediatR;
using Parking.Domain;
using Parking.Mediatr.Publish.FetchDataFromUrl;

namespace Parking.Mediatr.Publish.Information;

internal sealed class InformationNotificationHandler(IMediator mediator) : NotificationHandler<InformationNotification>
{
    protected override async void HandleCore(InformationNotification notification)
    {
        await mediator.Publish(new FetchDataFromUrlNotification(SourceData.Url));
    }
}