using Mediator;
using Parking.Domain;

namespace Parking.Mediator.Publish.CarParkToOutput;

internal sealed class CarParkToOutputNotification(CarPark carPark) : INotification
{
    public CarPark CarPark { get; } = carPark;
}
