using MediatR;
using Parking.Domain;
using Parking.Mediatr.Publish.CarParkToOutput;

namespace Parking.Mediatr.Publish.BestMatchCarPark;

internal sealed class BestMatchCarParkNotificationHandler(IMediator mediator) : NotificationHandler<BestMatchCarParkNotification>
{
    protected override async void HandleCore(BestMatchCarParkNotification notification)
    {
        var bestCarPark = BestMatchCalculator.CalculateBestMatch(notification.CarParks);
        await mediator.Publish(new CarParkToOutputNotification(bestCarPark));
    }
}