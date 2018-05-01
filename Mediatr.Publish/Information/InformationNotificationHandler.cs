using MediatR;
using Parking.Domain;
using Parking.Mediatr.Publish.FetchDataFromUrl;

namespace Parking.Mediatr.Publish.Information
{
    internal sealed class InformationNotificationHandler : NotificationHandler<InformationNotification>
    {
        private readonly IMediator mediator;

        public InformationNotificationHandler(IMediator mediator) => this.mediator = mediator;

        protected override async void HandleCore(InformationNotification notification)
        {
            await mediator.Publish(new FetchDataFromUrlNotification(SourceData.Url));
        }
    }
}
