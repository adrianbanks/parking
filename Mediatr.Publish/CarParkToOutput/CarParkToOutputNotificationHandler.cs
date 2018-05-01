using MediatR;
using Parking.Domain;
using Parking.Mediatr.Publish.SendOutput;

namespace Parking.Mediatr.Publish.CarParkToOutput
{
    internal sealed class CarParkToOutputNotificationHandler : NotificationHandler<CarParkToOutputNotification>
    {
        private readonly IMediator mediator;

        public CarParkToOutputNotificationHandler(IMediator mediator) => this.mediator = mediator;

        protected override async void HandleCore(CarParkToOutputNotification notification)
        {
            var output = CarParkOutputFormatter.Format(notification.CarPark);
            await mediator.Publish(new SendOutputNotification(output));
        }
    }
}
